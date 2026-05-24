using System;
using DemoDevOps.Models;
using DemoDevOps.Models.Dtos;
using AutoMapper;

namespace DemoDevOps.Mapping;

public class CategoryProfile: Profile
{
    public CategoryProfile()
    {
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Category, CreateCategoryDto>().ReverseMap();
    }
}
