
using Moq;
using Xunit;

using Application.Services;
using Application.Models;
using Domain.Entities;
using Domain.Interfaces;

public class UserServiceTests
{
    [Fact]
    public void GetAll_ShouldReturnUserDtosWithCorrectData()
    {
        // Arrange: preparamos un usuario de ejemplo
        var users = new List<User>
        {
            new User
            {
                Id = 1,
                Name = "Juan",
                LastName = "Perez",
                Email = "juan@gmail.com",
                CreationDate = new DateTime(2026, 1, 15)
            }
        };

        var repositoryMock = new Mock<IUserRepository>();
        repositoryMock
            .Setup(repository => repository.GetAll())
            .Returns(users);

        var service = new UserService(repositoryMock.Object);

        // Act: ejecutamos el método que queremos probar
        var result = service.GetAll();

        // Assert: comprobamos el resultado
        Assert.Single(result);

        Assert.Equal(1, result[0].Id);
        Assert.Equal("Juan Perez", result[0].FullName);
        Assert.Equal("juan@gmail.com", result[0].Email);
        Assert.Equal(
            new DateTime(2026, 1, 15),
            result[0].CreationDate
        );
    }
}
