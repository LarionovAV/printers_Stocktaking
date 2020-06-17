using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace printers_Stocktaking.Model
{
    class CommonElements
    {
        public static TreeNode DepTreeRoot { get; private set; }
        public static BindingList<Building> Buildings { get; private set; }
        public static BindingList<Creator> Creators { get; private set; }
        public static BindingList<PrinterModel> PrinterModels { get; private set; }
        public static BindingList<PrinterType> PrintersTypes { get; private set; }
        public static BindingList<PrinterStatement> PrinterStatements { get; private set; }
        public static BindingList<CartridgeModel> CartridgeModels { get; private set; }
        public static BindingList<CartridgeStatement> CartridgeStatements { get; private set; }
        public static BindingList<Measure> Measures { get; private set; }
        public static BindingList<Material> Materials { get; private set; }

        private static string sql;
        
        public static Dictionary<string, Color> actions = new Dictionary<string, Color>();
        private CommonElements() { }
        public static void Init() {
            InitDepTree();
            InitActions();
            InitCreators();
            InitPrinterModels();
            InitPrintersType();
            InitPrinterStatements();
            InitBuildings();
            InitCartridgeModels();
            InitCartridgeStatements();
            InitMeasures();
        }

        public static void InitMaterials() {
            if (Materials == null)
                Materials = new BindingList<Material>();

            Materials.Clear();
            sql = "SELECT * from \"Material\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                Materials.Add(new Material(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3)));
            }
            reader.Close();

            Materials.Add(new Material(-1, "--Новый--", 0, -1));
        }
        private static void InitMeasures() {
            Measures = new BindingList<Measure>();
            sql = "SELECT * from \"Measure\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                Measures.Add(new Measure(record.GetInt32(0), record.GetString(1), record.GetString(2)));
            }
            reader.Close();
        }
        private static void InitCartridgeStatements() {
            CartridgeStatements = new BindingList<CartridgeStatement>();
            sql = "SELECT * from \"Cartridge_statement\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                CartridgeStatements.Add(new CartridgeStatement(record.GetInt32(0), record.GetString(1)));
            }
            reader.Close();
        }
        private static void InitCartridgeModels() {
            CartridgeModels = new BindingList<CartridgeModel>();
            sql = "SELECT * from \"Cartridge_model\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                CartridgeModels.Add(new CartridgeModel(record.GetInt32(0), record.GetString(1)));
            }
            reader.Close();

            CartridgeModels.Add(new CartridgeModel(-1, "--Новая--"));
        }
        private static void InitPrinterStatements() {
            PrinterStatements = new BindingList<PrinterStatement>();
            sql = "SELECT * from \"Device_statement\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                PrinterStatements.Add(new PrinterStatement(record.GetInt32(0), record.GetString(1)));
            }
            reader.Close();
        }
        private static void InitPrintersType() {
            PrintersTypes = new BindingList<PrinterType>();
            
            sql = "SELECT * from \"Device_type\" ORDER BY \"name\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                PrintersTypes.Add(new PrinterType(record.GetInt32(0), record.GetString(1)));
            }
            reader.Close();

            PrintersTypes.Add(new PrinterType(-1, "--Новый--"));
        }
        private static void InitCreators() {
            Creators = new BindingList<Creator>();
           
            sql = "SELECT * from \"Creator\" ORDER BY \"name\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                Creators.Add(new Creator(record.GetInt32(0), record.GetString(1)));
            }
            reader.Close();

            Creators.Add(new Creator(-1, "--Новая--"));
        }

        private static void InitPrinterModels() {
            PrinterModels = new BindingList<PrinterModel>();
        }
        private static void InitActions() {
            actions.Add("add", Color.Green);
            actions.Add("upd", Color.Yellow);
            actions.Add("del", Color.Red);
        }
      

        public static void InitBuildings() {
            Buildings = new BindingList<Building>();

            sql = "SELECT * from \"Building\" ORDER BY \"name\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader) {
                Buildings.Add(new Building(record.GetInt32(0), record.GetString(1), record.GetString(2)));
            }
            reader.Close();
        }

        private static void InitDepTree() {
            DepTreeRoot = new TreeNode("Организация")
            {
                Name = "NULL"
            };

            fillDepTree(DepTreeRoot);
        }

        public static void fillDepTree(TreeNode node) {
            sql = 
                "SELECT \"dep_ID\", \"name\" FROM \"Department\" " +
                "WHERE \"parent_dep_ID\" " +
                (node.Name == "NULL"? "is null" : ("= " + node.Name)) +
                " ORDER BY \"name\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader) {
                node.Nodes.Add(record.GetInt32(0).ToString(), record.GetString(1));
            }
            reader.Close();
            foreach (TreeNode ch_node in node.Nodes) {
                fillDepTree(ch_node);
            }
        }
    }
}
