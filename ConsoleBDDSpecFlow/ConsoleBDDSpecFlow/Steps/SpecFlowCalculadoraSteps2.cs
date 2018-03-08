using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ConsoleBDDSpecFlow.Steps
{
    [Binding]
    public class SpecFlowCalculadoraSteps2
    {
        private int resultado;
        private Calculadora calculadora = new Calculadora();

        [Given(@"Ingresan (.*) a la Calculadora")]
        public void GivenIngresanALaCalculadora(int primero)
        {
            calculadora.primerNumero = primero;
        }
        
        [Given(@"Y Ingresan (.*) a la calculadora")]
        public void GivenYIngresanALaCalculadora(int segundo)
        {
            calculadora.segundoNumero = segundo;
        }
        
        [When(@"Cuando llamo a Restar")]
        public void WhenCuandoLlamoARestar()
        {
            resultado = calculadora.Restar();
        }
        
        [Then(@"El resultado de la resta debiese ser (.*)")]
        public void ThenElResultadoDeLaRestaDebieseSer(int resultoEsperado)
        {
            Assert.AreEqual(resultado, resultoEsperado);
        }
    }
}
