Feature: SpecFlowCalculadora
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Sumar Dos Números
	Given Dado Ingrese 50 a la Calculadora
	And Y Ingrese 70 a la calculadora
	When Cuando invoco Sumar 
	Then Entonces el resultado debiese ser 120


Scenario: Restar Dos Números
	Given Ingresan 300 a la Calculadora
	And Y Ingresan 120 a la calculadora
	When Cuando llamo a Restar
	Then El resultado de la resta debiese ser 180

Scenario: Multiplicar Dos Números
	Given Ingresen 4 a la Calculadora
	And Y Ingresen 5 a la calculadora
	When Cuando llamamos a Multiplicar
	Then El resultado de la multiplicacion debiese ser 20