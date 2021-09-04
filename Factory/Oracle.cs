using System.Configuration;

namespace Factory
{
    // This class will return Oracle Connection String
    class Oracle : IDBConString
    {
        public string ConString
        {
            get { return ConfigurationManager.ConnectionStrings["OracleCon"].ConnectionString; }
        }
    }
}
