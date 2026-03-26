using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_103082400029
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser<string>("Debby");

        }
    }

    class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine("Halo user " + user);
        }
    }

}