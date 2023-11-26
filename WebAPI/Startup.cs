using Business.Abstract;
using Business.Concrete;
using Core.DependencyResolvers;
using Core.Utilities.IoC;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Core.Extensions;

namespace WebAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add serices to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //IoC
            //services.AddSingleton<IMangaService, MangaManager>();
            //services.AddSingleton<IMangaDal,EfMangaDal>();

            //services.AddSingleton<IMangakaService, MangakaManager>();
            //services.AddSingleton<IMangakaDal, EfMangakaDal>();

            //services.AddSingleton<IGenreService, GenreManager>();
            //services.AddSingleton<IGenreDal, EfGenreDal>();

            services.AddDependencyResolvers(new ICoreModule[] { new CoreModule() });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {

        }
    }
}
