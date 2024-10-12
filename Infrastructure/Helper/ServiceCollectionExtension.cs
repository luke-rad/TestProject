using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Helper
{
	public static class ServiceCollectionExtension
	{
		public static void AddRepositoryServices(this IServiceCollection services)
		{

			services.AddScoped<ICategoryRepository, CategoryRepository>();
			services.AddScoped<IProductRepository, ProductRepository>();
		}
	}
}
