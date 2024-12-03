using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleTon
{
    public class saver
    {
        public static saver Instance;

        private saver()    
        {

        }
        public static saver GetInstance() 
        {
            if (Instance == null) 
            {
                Instance = new saver();
            }
            return Instance;
        }
        public void saverDoc(string[] txt)
        {
            string path = @"MyDocuments";
            string[] values;
        }
    }
}
