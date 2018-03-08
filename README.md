Charla Técnica: 10 Cosas que Necesitas 
Saber Sobre BDD + Demo SpecFlow y Cypress
================================================================================

Para el proyecto de Visual Studio 2017 es necesario seguir los siguientes pasos:

Configuración
-------------

*   Actualizar a la última versión de Visual Studio
*   En Herramientas -> Extensiones y Actualizaciones
*   Instalar NUnit 3 Test Adapter
*   Instalar SpecFlow for Visual Studio 2017
*   Desde Nuget agregar al Proyecto:
*   NUnit 3.9.0
*   SpecFlow 2.3.1

* * *

En el App.config:

    <specFlow>    
       <unitTestProvider name="NUnit"></unitTestProvider>
    </specFlow>
