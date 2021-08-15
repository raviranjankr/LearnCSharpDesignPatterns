using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class ChaiStall
    {
        private Dictionary<int, GaramChai> mOrders = new Dictionary<int, GaramChai>();
        private readonly ChaiMaker chaiMaker;

        public ChaiStall(ChaiMaker chaiMaker)
        {
           this.chaiMaker = chaiMaker ?? throw new ArgumentNullException("ChaiMaker", "Chai Maker cannot be null");
        }

        public void TakeOrder(string teaType, int table)
        {
            mOrders[table] = chaiMaker.Make(teaType);
        }

        public void Serve()
        {
            foreach (var table in mOrders.Keys)
            {
                Console.WriteLine($"Serving Chai to table # {table}");
            }
        }
    }
}
