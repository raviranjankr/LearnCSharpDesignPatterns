namespace Factory
{
    // DBConFactory declares the factory method that is supposed to return different connection string.    
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
