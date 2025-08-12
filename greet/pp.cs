using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Greet
{
    public class PP
    {
        string name;
        public PP()
        {
            name = "sun Goku";
        }
        public PP(string name)
        {
            this.name = name;
        }

        public void greet()
        {
            Console.WriteLine($"Hello {name}");
        }
    }

}