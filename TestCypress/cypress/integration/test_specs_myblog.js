describe('Mi Blog Test Suite', function () {
    it('Test título de página inicio sea igual a Robert Rozas Navarro', function () {
      // https://on.cypress.io/visit
      cy.visit('http://robert-rozas-blog.azurewebsites.net/')  
      // Here we've made our first assertion using a '.should()' command.     
      cy.title().should('include', 'Robert Rozas Navarro')
      //   ↲               ↲            ↲
      // subject        chainer      value
      
    })


    it('Click en Humor', function () {
        cy.clock()
        // https://on.cypress.io/click        
        cy.get('a').contains('Humor').click()
        cy.tick(2000) 
        cy.location().should(function (location) {
            expect(location.href).to.eq('http://robert-rozas-blog.azurewebsites.net/Category/humor')
        })       
        
    })

    it('Chequeo Dominio',function(){
        cy.location().should(function (location) {
            expect(location.hash).to.be.empty
            expect(location.host).to.eq('robert-rozas-blog.azurewebsites.net')
            expect(location.hostname).to.eq('robert-rozas-blog.azurewebsites.net')            
            expect(location.port).to.eq('')
            expect(location.protocol).to.eq('http:')
        })
    })

    it('Humor no tiene posts',function(){
        cy.get('#content > p').contains('No posts found!')
    })


    // it('usuario y password bloqueado, muestra mensaje de error', function () {
    //     // https://on.cypress.io/click
    //     cy.clock()
    //     cy.get(".nbx-input-cirrus >input:first").first().type('33333333-3').should('have.value', '33333333-3')
    //     cy.get(".nbx-input-cirrus >input:last").first().type('admin123').should('have.value', 'admin123')
    //     cy.get(".nbx-form_btn_login").click()
    //     cy.tick(2000)

    //     cy.get(".jqx-notification-content:first").contains('Tu cuenta ha sido bloqueada')
    // })

})