using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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


            //Внедрение зависимостей в контейнер
            var container = builder.Build();

            //Установка сапоставление зависимостей
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}