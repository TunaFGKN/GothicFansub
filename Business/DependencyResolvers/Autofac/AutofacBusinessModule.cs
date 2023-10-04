using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MangaManager>().As<IMangaService>().SingleInstance();
            builder.RegisterType<EfMangaDal>().As<IMangaDal>().SingleInstance();

            builder.RegisterType<MangakaManager>().As<IMangakaService>().SingleInstance();
            builder.RegisterType<EfMangakaDal>().As<IMangakaDal>().SingleInstance();

            builder.RegisterType<GenreManager>().As<IGenreService>().SingleInstance();
            builder.RegisterType<EfGenreDal>().As<IGenreDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
