using System;
using TechTalk.SpecFlow;

namespace ConsoleBDDSpecFlow
{
    [Binding]
    public class SpecFlowCalculadoraSteps3
    {
        [Given(@"Ingresen (.*) a la Calculadora")]
        public void GivenIngresenALaCalculadora(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Y Ingresen (.*) a la calculadora")]
        public void GivenYIngresenALaCalculadora(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Cuando llamamos a Multiplicar")]
        public void WhenCuandoLlamamosAMultiplicar()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"El resultado de la multiplicacion debiese ser (.*)")]
        public void ThenElResultadoDeLaMultiplicacionDebieseSer(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
