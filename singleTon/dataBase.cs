using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleTon
{
    public class dataBase
    {
        private static dataBase _instance;
        private static readonly object _lock = new object();
        private SqlConnection _connection;

        private dataBase()
        {
            _connection = new SqlConnection("your_conection_string");
        }

        public static dataBase Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    { 
                       _instance = new dataBase();  
                    }                  
                }
                return _instance;
            }
        }
        public SqlConnection GetConnection()
        {
            return _connection;
        }

    }
}
