describe('Nubox Test Suite', function () {
    it('Test título de página inicio sea igual a Software para contadores y pymes | Nubox', function () {
      // https://on.cypress.io/visit
      cy.visit('https://www.nubox.com')  
      // Here we've made our first assertion using a '.should()' command.     
      cy.title().should('include', 'Software para contadores y pymes | Nubox')
      //   ↲               ↲            ↲
      // subject        chainer      value
    })


    it('Click en Acceso Clientes', function () {
        cy.clock()
        // https://on.cypress.io/click        
        cy.get('.main-nav__link').contains('Acceso Clientes').click()
        cy.tick(2000)

        cy.visit("https://web.nubox.com/Login/Account/Login") 
        cy.location().should(function (location) {
            expect(location.hash).to.be.empty
            expect(location.host).to.eq('web.nubox.com')
            expect(location.hostname).to.eq('web.nubox.com')            
            expect(location.port).to.eq('')
            expect(location.protocol).to.eq('https:')
        })
    })


    it('usuario y password bloqueado, muestra mensaje de error', function () {
        // https://on.cypress.io/click
        cy.clock()
        cy.get(".nbx-input-cirrus >input:first").first().type('33333333-3').should('have.value', '33333333-3')
        cy.get(".nbx-input-cirrus >input:last").first().type('admin123').should('have.value', 'admin123')
        cy.get(".nbx-form_btn_login").click()
        cy.tick(2000)

        cy.get(".jqx-notification-content:first").contains('Tu cuenta ha sido bloqueada')
    })

})