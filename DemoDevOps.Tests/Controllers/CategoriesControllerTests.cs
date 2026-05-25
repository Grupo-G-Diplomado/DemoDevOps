using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Moq;
using Xunit;
using DemoDevOps.Controllers;
using DemoDevOps.Models;
using DemoDevOps.Models.Dtos;
using DemoDevOps.Repository.IRepository;

namespace DemoDevOps.Tests.Controllers
{
    public class CategoriesControllerTests
    {
        private readonly Mock<ICategoryRepository> _mockRepo;
        private readonly Mock<IMapper> _mockMapper;
        private readonly CategoriesController _controller;

        public CategoriesControllerTests()
        {
            _mockRepo = new Mock<ICategoryRepository>();
            _mockMapper = new Mock<IMapper>();

            _controller = new CategoriesController(_mockRepo.Object, _mockMapper.Object);
        }

        [Fact]
        public void GetCategories_ReturnsOkResult_WithListOfCategoryDtos()
        {
            // Arrange (Preparación)
            var mockCategories = new List<Category>
            {
                new Category { ID = 1, Name = "Tecnología" },
                new Category { ID = 2, Name = "Deportes" }
            };

            var mockCategoriesDto = new CategoryDto { ID = 1, Name = "Tecnología" };

            _mockRepo.Setup(repo => repo.GetCategories()).Returns(mockCategories);
            
            _mockMapper.Setup(mapper => mapper.Map<CategoryDto>(It.IsAny<Category>())).Returns(mockCategoriesDto);

            var result = _controller.GetCategories();

            var okResult = Assert.IsType<OkObjectResult>(result);

            var returnValue = Assert.IsType<List<CategoryDto>>(okResult.Value);
            
            Assert.Equal(2, returnValue.Count);
        }
    }
}
