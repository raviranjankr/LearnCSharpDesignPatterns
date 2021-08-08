using System.Configuration;

namespace Factory
{
    class Oracle : IDBConString
    {

        public string ConString
        {
            get { return ConfigurationManager.ConnectionStrings["OracleCon"].ConnectionString; }
        }
    }
}
