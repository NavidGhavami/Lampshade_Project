using _0_Framework.Infrastructure;
using _01_LampshadeQuery.Contracts.Cart;
using _01_LampshadeQuery.Contracts.Product;
using _01_LampshadeQuery.Contracts.ProductCategory;
using _01_LampshadeQuery.Contracts.Slider;
using _01_LampshadeQuery.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopManagement.Application;
using ShopManagement.Application.Contract.Order;
using ShopManagement.Application.Contract.Product;
using ShopManagement.Application.Contract.ProductCategory;
using ShopManagement.Application.Contract.ProductPicture;
using ShopManagement.Application.Contract.Slider;
using ShopManagement.Configuration.Permissions;
using ShopManagement.Domain.Order;
using ShopManagement.Domain.Product;
using ShopManagement.Domain.ProductCategory;
using ShopManagement.Domain.ProductPicture;
using ShopManagement.Domain.Services;
using ShopManagement.Domain.Slider;
using ShopManagement.Infrastructure.EFCore;
using ShopManagement.Infrastructure.EFCore.Repository;
using ShopManagement.Infrastructure.InventoryAcl;

namespace ShopManagement.Configuration
{
    public class ShopMangementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IProductCategoryApplication, ProductCategoryApplication>();
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();

            services.AddTransient<IProductApplication, ProductApplication>();
            services.AddTransient<IProductRepository, ProductRepository>();

            services.AddTransient<IProductPictureApplication, ProductPictureApplication>();
            services.AddTransient<IProductPictureRepository, ProductPictureRepository>();

            services.AddTransient<ISliderApplication, SliderApplication>();
            services.AddTransient<ISliderRepository, SliderRepository>();

            services.AddTransient<IOrderApplication, OrderApplication>();
            services.AddTransient<IOrderRepository, OrderRepository>();

            services.AddTransient<IShopInventoryAcl, ShopInventoryAcl>();

            services.AddSingleton<ICartService, CartService>();

            services.AddTransient<ISliderQuery, SlideQuery>();

            services.AddTransient<IProductCategoryQuery, ProductCategoryQuery>();

            services.AddTransient<IProductQueryModel, ProductQuery>();

            services.AddTransient<IPermissionExposition, ShopPermissionExposition>();

            services.AddTransient<ICartCalculatorService, CartCalculatorService>();

            



            services.AddDbContext<ShopContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
