using CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Domain.Dtos;
using CleanArchitecture.Presentation.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace ClenArchitecture.UnitTest;

public class CarsControllerUnitTest
{
    [Fact]
    public async void Create_ReturnsOkResult_WhenRequestIsValid()
    {
        //Arrange parçasý 
        var mediatorMock = new Mock<IMediator>(); //sahte bir mediator mock eklendi 
        CreateCarCommand createCarCommand = new(
            "Toyota", "Corolla", 5000);
        MessageResponse response = new("Araç baþarýyla kaydedildi!");
        CancellationToken cancellationToken = new();


        mediatorMock.Setup(m => m.Send(createCarCommand, cancellationToken))
            .ReturnsAsync(response);  //fake bir cevap dönddürüyoruz

        CarsController carsController = new(mediatorMock.Object);

        //Act
        var result = await carsController.Create(createCarCommand, cancellationToken);

        //Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var returnValue = Assert.IsType<MessageResponse>(okResult.Value);

        Assert.Equal(response, returnValue);
        mediatorMock.Verify(m => m.Send(createCarCommand, cancellationToken), Times.Once());
    }
}