using AutoMapper;
using Entity.Models;
using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Util
{
    public static class AutoMapperConfig
    {
        public static void ConfigureMapper(this IMapperConfigurationExpression mapper)
        {
            mapper.CreateMap<AddBookViewModel, Book>();
        }
    }
}