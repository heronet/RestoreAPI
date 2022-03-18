using ReStoreAPI.Models;

namespace ReStoreAPI.Data;

public static class DbInitialzer
{
    public static void Initialize(StoreContext context)
    {
        if (context.Products.Any()) return;

        var products = new List<Product> {
            new Product{
                Name = "Angular Speedster Board 2000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Green Angular Speedster Board 3000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product{
                Name = "Red Angular Speedster Board 4000",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni soluta sed natus cumque dolor? Veritatis repellendus illum delectus exercitationem nisi nihil voluptatibus sunt nemo, reiciendis recusandae vel. Necessitatibus, ex perspiciatis!",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
        };
        foreach (var product in products)
        {
            context.Products.Add(product);
        }
        context.SaveChanges();
    }
}
