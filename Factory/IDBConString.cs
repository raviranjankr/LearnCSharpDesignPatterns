namespace Factory
{
    // Interface having definition of Connection String. Class will inherit this interface have to write logic for return connection string.
    interface IDBConString
    {
        string ConString
        {
            get;
        }
    }
}
