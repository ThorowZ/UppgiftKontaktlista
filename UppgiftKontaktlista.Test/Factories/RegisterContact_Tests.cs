
using Business.Models;
using Data.Services;

namespace UppgiftKontaktlista.Test.Factories
{
    internal class RegisterContact_Tests;

    [Fact]
    public void Create_ShouldReturnRegisterContact()
    {
        //Arrange

        // Act
        ContactFormat result = ContactService.Create();

        // Assert
        Assert.IsType<ContactFormat>(result);
    }
}
