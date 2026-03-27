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

            DataGeneric<string> data = new DataGeneric<string>("103082400029");
            data.PrintData();
             
        }
    }

    class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine("Halo user " + user);
        }
    }

    class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah : " + data);
        }
    }

}