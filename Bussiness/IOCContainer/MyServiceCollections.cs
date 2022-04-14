using Bussiness.Abstract;
using Bussiness.Concrete;
using Bussiness.FluentValidations;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.ContextConnection;
using Entities.DtoTable;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Bussiness.IOCContainer
{
    public static  class MyServiceCollections
    {
        public static IServiceCollection MyService(this IServiceCollection services)
        {
            services.AddDbContext<BlogContext>();
            services.AddScoped<IUnitOfWorks, UnitOfWorks>();

            services.AddScoped<IAccountsManager, MyAccountsManager>();
            services.AddScoped<IBlogsManager, BlogsManager>();
            services.AddScoped<ICommentsManager, CommentsManager>();

            services.AddSingleton<IValidator <DtoBlogsComments>, BlogsCommentsValidation>();
            services.AddSingleton<IValidator<DtoBlogs>, BlogsValidation>();


            return services;


        }
    }
}
