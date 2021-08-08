using System.Configuration;

namespace Factory
{
    class SQL : IDBConString
    {

        public string ConString
        {
            get { return ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString; }
        }
    }
}
