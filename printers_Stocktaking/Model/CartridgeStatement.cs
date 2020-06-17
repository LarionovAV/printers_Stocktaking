namespace printers_Stocktaking.Model
{
    class CartridgeStatement
    {
        public int ID { get; private set; }
        public string Name { get; set; }

        public CartridgeStatement() { }
        public CartridgeStatement(string name)
        {
            Name = name;
        }
        public CartridgeStatement(int id, string name) : this(name)
        {
            ID = id;
        }
    }
}
