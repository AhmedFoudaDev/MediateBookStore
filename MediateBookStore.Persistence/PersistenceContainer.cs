using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using MediateBookStore.Application.Contracts;
using MediateBookStore.Persistence.Repos;

namespace MediateBookStore.Persistence
{
    public static class PersistenceContainer
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BookStoreDBContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("BookStoreConnectionString")));

            services.AddScoped(typeof(IAsyncRepos<>), typeof(BaseRepos<>));
            services.AddScoped(typeof(IBookRepos), typeof(BookRepos));
            services.AddScoped(typeof(IAuthorRepos), typeof(AuthorRepos));
            return services;
        }
    }

}
