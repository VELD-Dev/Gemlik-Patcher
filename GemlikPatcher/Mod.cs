using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemlik_Patcher
{
    [Serializable]
    public class Mod
    {
        public string name;
        public string path;
        public Mod()
        {
            name = "Empty Name";
            path = "C:/Empty Name";
        }
        public Mod(string name, string path)
        {
            this.name = name;
            this.path = path;
        }
    }
}
