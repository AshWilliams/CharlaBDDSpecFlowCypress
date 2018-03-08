using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ConsoleBDDSpecFlow.Steps
{
    [Binding]
    public class SpecFlowCalculadoraSteps
    {
        private int resultado;
        private Calculadora calculadora = new Calculadora();
        [Given(@"Dado Ingrese (.*) a la Calculadora")]
        public void GivenDadoIngreseALaCalculadora(int primero)
        {
            calculadora.primerNumero = primero;
        }
        
        [Given(@"Y Ingrese (.*) a la calculadora")]
        public void GivenYIngreseALaCalculadora(int segundo)
        {
            calculadora.segundoNumero = segundo;
        }
        
        [When(@"Cuando invoco Sumar")]
        public void WhenCuandoInvocoSumar()
        {
            resultado = calculadora.Sumar();
        }
        
        [Then(@"Entonces el resultado debiese ser (.*)")]
        public void ThenEntoncesElResultadoDebieseSer(int resultoEsperado)
        {
            Assert.AreEqual(resultado, resultoEsperado);
        }
    }
}
