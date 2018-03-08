using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBDDSpecFlow
{
    class Calculadora
    {
        public int primerNumero { get; set; }
        public int segundoNumero { get; set; }
        static void Main(string[] args)
        {

        }

        public int Sumar()
        {
            return primerNumero + segundoNumero;
        }

        internal int Restar()
        {
            return primerNumero - segundoNumero;
        }
    }
}
