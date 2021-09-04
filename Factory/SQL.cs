using System.Configuration;

namespace Factory
{
    // This class will return SQL Connection String
    class SQL : IDBConString
    {
        public string ConString
        {
            get { return ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString; }
        }
    }
}
