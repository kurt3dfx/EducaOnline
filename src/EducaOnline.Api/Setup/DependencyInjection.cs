using EducaOnline.Conteudo.Application.Services;
using EducaOnline.Conteudo.Data;
using EducaOnline.Conteudo.Data.Repository;
using EducaOnline.Conteudo.Domain;

using EducaOnline.Core.Communication.Mediator;
using EducaOnline.Core.Data.EventSourcing;

namespace EducaOnline.WebApp.MVC.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterService(this IServiceCollection services)
        {
            // Add service registrations here
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            // Event Sourcing
            //services.AddSingleton<IEventStoreService, EventStoreService>();
            //services.AddSingleton<IEventSourcingRepository, EventSourcingRepository>();

            // 
            services.AddScoped<ICursoRepository, CursoRepository>();
            services.AddScoped<IMatriculaService, MatriculaService>();
            services.AddScoped<ICursoAppService, CursoAppService>();
            services.AddScoped<ConteudoContext>();
        }
    }
}
