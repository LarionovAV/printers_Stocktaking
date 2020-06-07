using System.Windows.Forms;

namespace printers_Stocktaking.Model
{
    class CommonElements
    {
        public static TreeNode DepTreeRoot { get; private set; }
 /*       public static BindingList<Creator> Creators { get; private set; }
        public static BindingList<MatherialType> MatherialTypes { get; private set; }
        public static BindingList<DeviceType> DeviceTypes { get; private set; }
        public static BindingList<Statement> Statements { get; private set; }
*/
        private CommonElements() { }
        public static void Init() {
            InitDepTree();
            InitCreators();
            InitDeviceTypes();
            InitStatements();
        }

        private static void InitDeviceTypes() {
   /*         DeviceTypes = DeviceType.getDeviceTypes();
            DeviceTypes.Insert(0, new DeviceType(-1, "--Все типы--"));*/
        }
        private static void InitStatements()
        {
 /*           Statements = Statement.getStatements();
            Statements.Insert(0, new Statement(-1, "--Любое состояние--"));*/
        }
        private static void InitCreators() {
 /*           Creators = Creator.getCreators();
            Creators.Insert(0, new Creator(-1, "--Все производители--"));*/
        }

        private static void InitDepTree() {
            DepTreeRoot = new TreeNode("Организация")
            {
                Name = "-1"
            };

            DepTreeRoot.Nodes.Add("1", "Подразделение 1");
            DepTreeRoot.Nodes[0].Nodes.Add("11", "Подразделение 1-1");
            DepTreeRoot.Nodes[0].Nodes.Add("12", "Подразделение 1-2");
            DepTreeRoot.Nodes[0].Nodes.Add("13", "Подразделение 1-3");


            DepTreeRoot.Nodes.Add("2", "Подразделение 2");
            DepTreeRoot.Nodes[1].Nodes.Add("21", "Подразделение 2-1");
            DepTreeRoot.Nodes[1].Nodes.Add("22", "Подразделение 2-2");


            DepTreeRoot.Nodes.Add("3", "Подразделение 3");
            DepTreeRoot.Nodes[2].Nodes.Add("31", "Подразделение 3-1");
            DepTreeRoot.Nodes[2].Nodes.Add("32", "Подразделение 3-2");
            DepTreeRoot.Nodes[2].Nodes.Add("33", "Подразделение 3-3");


            //Department.fillTree(DepTreeRoot, -1);
        }

        public static void refreshDepTree() {
          /*  DepTreeRoot.Nodes.Clear();
            Department.fillTree(DepTreeRoot, -1);*/
        }
    }
}
