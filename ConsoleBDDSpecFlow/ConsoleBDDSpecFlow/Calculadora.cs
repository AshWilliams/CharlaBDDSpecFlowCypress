using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBDDSpecFlow
{
    /*
     * Desde Consola Administración de Paquetes
     * cd .\ConsoleBDDSpecFlow
       nunit3-console.exe --labels=All --out=TestResult.txt "--result=TestResult.xml;format=nunit2" bin\Debug\ConsoleBDDSpecFlow.exe
       specflow.exe nunitexecutionreport ConsoleBDDSpecFlow.csproj /out:MyResult.html    */
    class Calculadora
    {
        public int primerNumero { get; set; }
        public int segundoNumero { get; set; }
        static void Main(string[] args)
        {
            throw new NotSupportedException();
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
