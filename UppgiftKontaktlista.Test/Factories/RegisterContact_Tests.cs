
using Business.Models;
using Data.Services;

namespace UppgiftKontaktlista.Test.Factories
{
    public class RegisterContact_Tests
    {

    [Fact]
    public void Register_ShouldReturnRegisterContact()
    {
            //Arrange - Förberedelse
            var contactService = new ContactService();
            var contactFormat = new ContactFormat() 
            {
                Firstname = "firstname",
                Lastname = "lastname" 
            };

        // Act - Själva utförandet
        ContactFormat result = ContactService.Add();

        // Assert - test delen
        Assert.IsType<ContactFormat>(result);
        }
    }
}
