using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class FactoryDBProvider
    {
        public FactoryDBProvider()
        {

        }
        public static IDBProvider GetProvider()
        {
            // if................
            return new ADODBProvider();
        }
    }
}
