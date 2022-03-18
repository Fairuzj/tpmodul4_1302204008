using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_NIM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nama User : ");

            HaloGeneric.SapaUser<String>(Console.ReadLine());
            Console.ReadLine();

            DataGeneric<String>(Console.ReadLine()).PrintData();
        }
    }
    class HaloGeneric
    {
        public static void SapaUser<X> (X x)
        {
            Console.WriteLine("Halo user " + x);
        }
    }
    class DataGeneric<T>
    {
        T data;
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
