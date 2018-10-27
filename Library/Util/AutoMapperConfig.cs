using AutoMapper;
using Entity.Models;
using Library.ViewModels;

namespace Library.Util
{
    public static class AutoMapperConfig
    {
        /// <summary>
        /// Настройка конфигурации AutoMapper
        /// </summary>
        /// <param name="mapper"></param>
        public static void ConfigureMapper(this IMapperConfigurationExpression mapper)
        {
            //Регистрация карт
            mapper.CreateMap<AddBookViewModel, Book>();
        }
    }
}