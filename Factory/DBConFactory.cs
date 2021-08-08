namespace Factory
{
    static class DBConFactory
    {
        public static IDBConString GetDbConStringInstance(int Id)
        {
            switch (Id)
            {
                case 0:
                    return new SQL();
                case 1:
                    return new Oracle();
                default:
                    return null;
            }
        }
    }
}
