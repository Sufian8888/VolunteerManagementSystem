using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_M_S.BUSSINESS_LAYER
{
    internal class Authentication
    {
        public string  name { get; set; }
        public string  password { get; set; }

        public Authentication(string name,string password)
        {
            this.name = name;
            this.password = password;
        }
    }
}
