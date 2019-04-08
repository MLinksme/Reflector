using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reflector;
using Reflector.Utils.Define;

namespace TESTPlugin
{
    public class Class1: ReflectHandle, IConnHandler
    {
        public string PageLoad()
        {
           return  RequestMethod+": " + RequestFile;
        }

        public void Request(RequestArgs arg)
        {
            
        }

        public void Start()
        {
        }
    }
}
