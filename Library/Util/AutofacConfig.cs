using Autofac;
using Autofac.Integration.Mvc;
using Entity;
using Library.Services.Abstractions.DbService;
using Library.Services.Implementations.DbService;
using System.Web.Mvc;

namespace Library.Util
{
    public class AutofacConfig
    {
        /// <summary>
        /// Настройка IoC Autofac
        /// </summary>
        public static void ConfigureContainer()
        {
            //Создание контейнера.
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            //Регистрация зависимостей
            builder.RegisterType<LibraryContext>().InstancePerRequest();
            builder.RegisterType<BookService>()
                .As<IBookService>();

            //Внедрение зависимостей в контейнер
            var container = builder.Build();

            //Установка сапоставление зависимостей
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}