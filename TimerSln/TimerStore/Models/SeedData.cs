using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace TimerStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(

                    new Product
                    {
                        Name = "A-158WEA-1E CASIO",
                        ProductImg = "A-158WEA-1E-CASIO.jpg",
                        Description = "Мужские электронные часы",
                        Favourite = false,
                        Gender = "man",
                        MechanismType = "Electronics",
                        CaseMaterial = "Steel",
                        wristletType = "Steel",
                        Price = 2740,
                        Discount = 20,
                        Category = "Wrist",
                        BrandName = "Casio",
                        totalCount = 3
                    },
                    new Product
                    {
                        Name = "A-158WEA-9E CASIO",
                        ProductImg = "A-158WEA-9E-CASIO.jpg",
                        Description = "Мужские электронные часы",
                        Favourite = false,
                        Gender = "man",
                        MechanismType = "Electronics",
                        CaseMaterial = "Steel",
                        wristletType = "Steel",
                        Price = 2840,
                        Discount = 10,
                        Category = "Wrist",
                        BrandName = "Casio",
                        totalCount = 5
                    }, 
                    new Product
                    {
                        Name = "A-168WEGC-3E CASIO",
                        ProductImg = "A-168WEGC-3E-CASIO.jpg",
                        Description = "Мужские электронные часы",
                        Favourite = true,
                        Gender = "man",
                        MechanismType = "Electronics",
                        CaseMaterial = "Steel",
                        wristletType = "Steel",
                        Price = 4890,
                        Discount = 0,
                        Category = "Wrist",
                        BrandName = "Casio",
                        totalCount = 4
                    }, 
                    new Product
                    {
                        Name = "CTD0D007H ORIENT",
                        ProductImg = "CTD0D007H-ORIENT.jpg",
                        Description = "Мужские электронные часы",
                        Favourite = true,
                        Gender = "man",
                        MechanismType = "Electronics",
                        CaseMaterial = "Steel",
                        wristletType = "Steel",
                        Price = 8000,
                        Discount = 20,
                        Category = "Wrist",
                        BrandName = "Orient",
                        totalCount = 3
                    }, 
                    new Product
                    {
                        Name = "FAB00001P ORIENT",
                        ProductImg = "FAB00001P-ORIENT.jpg",
                        Description = "Мужские электронные часы",
                        Favourite = false,
                        Gender = "man",
                        MechanismType = "Electronics",
                        CaseMaterial = "Steel",
                        wristletType = "Steel",
                        Price = 9800,
                        Discount = 10,
                        Category = "Wrist",
                        BrandName = "Orient",
                        totalCount = 2
                    }, 
                    new Product
                    {
                        Name = "FAC09003B ORIENT",
                        ProductImg = "FAC09003B-ORIENT.jpg",
                        Description = "Мужские электронные часы",
                        Favourite = false,
                        Gender = "man",
                        MechanismType = "Electronics",
                        CaseMaterial = "Steel",
                        wristletType = "Steel",
                        Price = 18000,
                        Discount = 20,
                        Category = "Wrist",
                        BrandName = "Orient",
                        totalCount = 3
                    }, 
                    new Product
                    {
                        Name = "DL2133SLW(BK) ROMANSON",
                        ProductImg = "DL2133SLW-BK-ROMANSON.jpg",
                        Description = "Женские электронные часы",
                        Favourite = false,
                        Gender = "wooman",
                        MechanismType = "Quartz",
                        CaseMaterial = "Steel",
                        wristletType = "leather belt",
                        Price = 5700,
                        Discount = 5,
                        Category = "Wrist",
                        BrandName = "Romanson",
                        totalCount = 3
                    }, 
                    new Product
                    {
                        Name = "DL333SLW(BK) ROMANSON",
                        ProductImg = "DL333SLW-BK-ROMANSON.jpg",
                        Description = "Женские электронные часы",
                        Favourite = false,
                        Gender = "wooman",
                        MechanismType = "Quartz",
                        CaseMaterial = "Steel",
                        wristletType = "leather belt",
                        Price = 5300,
                        Discount = 5,
                        Category = "Wrist",
                        BrandName = "Romanson",
                        totalCount = 4
                    }, 
                    new Product
                    {
                        Name = "DL111SLW(BK) ROMANSON",
                        ProductImg = "DL111SLW-BK-ROMANSON.jpg",
                        Description = "Женские электронные часы",
                        Favourite = false,
                        Gender = "wooman",
                        MechanismType = "Quartz",
                        CaseMaterial = "Steel",
                        wristletType = "leather belt",
                        Price = 5100,
                        Discount = 15,
                        Category = "Wrist",
                        BrandName = "Romanson",
                        totalCount = 2
                    }, 
                    new Product
                    {
                        Name = "DZ1400 DIESEL",
                        ProductImg = "DZ1400-DIESEL.jpg",
                        Description = "Мужские электронные часы",
                        Favourite = false,
                        Gender = "man",
                        MechanismType = "Electronics",
                        CaseMaterial = "Steel",
                        wristletType = "Steel",
                        Price = 23440,
                        Discount = 20,
                        Category = "Wrist",
                        BrandName = "DIESEL",
                        totalCount = 3
                    },
                    new Product
                    {
                        Name = "DZ1599 DIESEL",
                        ProductImg = "DZ1599-DIESEL.jpg",
                        Description = "Мужские электронные часы",
                        Favourite = false,
                        Gender = "man",
                        MechanismType = "Electronics",
                        CaseMaterial = "Steel",
                        wristletType = "Steel",
                        Price = 27400,
                        Discount = 20,
                        Category = "Wrist",
                        BrandName = "DIESEL",
                        totalCount = 3
                    }, 
                    new Product
                    {
                        Name = "DZ1399 DIESEL",
                        ProductImg = "DZ1399-DIESEL.jpg",
                        Description = "Мужские электронные часы",
                        Favourite = false,
                        Gender = "man",
                        MechanismType = "Electronics",
                        CaseMaterial = "Steel",
                        wristletType = "Steel",
                        Price = 25040,
                        Discount = 20,
                        Category = "Wrist",
                        BrandName = "DIESEL",
                        totalCount = 3
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
