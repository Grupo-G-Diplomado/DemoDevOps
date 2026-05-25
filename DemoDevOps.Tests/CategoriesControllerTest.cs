using AutoMapper;
using DemoDevOps.Controllers;
using DemoDevOps.Models;
using DemoDevOps.Models.Dtos;
using DemoDevOps.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace DemoDevOps.Tests;

public class CategoriesControllerTest
{
    [Fact]
    public void GetCategories_ReturnsOkResult()
    {
        var categoryRepositoryMock = new Mock<ICategoryRepository>();
        var mapperMock = new Mock<IMapper>();

        var categories = new List<Category>
        {
            new Category { ID = 1, Name = "Tecnologia" }
        };

        categoryRepositoryMock
            .Setup(repo => repo.GetCategories())
            .Returns(categories);

        mapperMock
            .Setup(mapper => mapper.Map<CategoryDto>(It.IsAny<Category>()))
            .Returns(new CategoryDto { ID = 1, Name = "Tecnologia" });

        var controller = new CategoriesController(
            categoryRepositoryMock.Object,
            mapperMock.Object
        );

        var result = controller.GetCategories();

        Assert.IsType<OkObjectResult>(result);
    }
}