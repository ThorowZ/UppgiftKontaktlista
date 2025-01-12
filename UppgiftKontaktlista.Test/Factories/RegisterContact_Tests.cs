
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
                Lastname = "lastname",
                Email = "email",
                Phone = "phoneNumber"
            };

            // Act - Själva utförandet
            ContactFormat result = contactService.Add(contactFormat);

            // Assert - test delen
            Assert.IsType<ContactFormat>(result);
            Assert.Equal(contactFormat.Firstname, result.Firstname);
            Assert.Equal(contactFormat.Lastname, result.Lastname);
            Assert.Equal(contactFormat.Email, result.Email);
            Assert.Equal(contactFormat.Phone, result.Phone);  
        }
    }
}
