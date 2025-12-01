using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domin;
using domin;//bayad ezafe besheh

namespace infra
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options) 
        {
        }


        public DbSet<Prouduct> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<NewsCat> NewsCats { get; set; }
        public DbSet<News> Newses { get; set; }
        public DbSet<SlideShow> SlideShows { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }

    }


}
