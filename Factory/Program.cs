using System;
using System.Configuration;


namespace Factory
{
    public interface IDBConString
    {
        string ConString
        {
            get;
        }
 
    }
    class SQL : IDBConString
    {

        public string ConString
        {
            get { return ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString; }
        }
    }

    class Oracle : IDBConString
    {
      
        public string ConString
        {
            get { return ConfigurationManager.ConnectionStrings["OracleCon"].ConnectionString; }
        }       
    }

    class MySQL : IDBConString
    {        
        public string ConString
        {
            get { return ConfigurationManager.ConnectionStrings["MySqlCon"].ConnectionString; }
        }
    }
    
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
                case 2:
                    return new MySQL();                
                default:
                    return null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IDBConString dBConString = DBConFactory.GetDbConStringInstance(1); // Change value to get different connection string
            Console.WriteLine($"Connection string - {dBConString.ConString}");

            Console.ReadLine();
        }
    }
}
