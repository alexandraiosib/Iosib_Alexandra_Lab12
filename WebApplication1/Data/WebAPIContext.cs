using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebAPI.Data
{
    public class WebAPIContext : DbContext
    {
        public WebAPIContext (DbContextOptions<WebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.ShopList> ShopList { get; set; }
    }
}
