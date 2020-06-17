namespace printers_Stocktaking.Model
{
    interface IDbEntity
    {
        void Create();
        void Delete();
        void Update();

        void Find(int id);
    }
}
