using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practidaDeClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            auto auto1 = new auto();
            string colordeauto = auto1.x;
            string modelodeauto = auto1.y;

            bool combustibledeauto = auto1.z;
            Console.WriteLine(colordeauto);
            Console.WriteLine(modelodeauto);
            if (combustibledeauto)
            {
                Console.WriteLine("el tanqe esta lleno");
            }
            Console.ReadKey();
        }
    }
    public class auto
    {
        private string color = "rojo", modelo = "mustangio";
        private bool combustible = true;

        public string x
        {

            get { return color; }

        }
        public string y
        {
            get { return modelo; }
        }
        public bool z
        {
            get { return combustible; }
        }
    }
}
