using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace MyMusic.Data
{
    public class MyMusicContext : DbContext
    {
        public MyMusicContext (DbContextOptions<MyMusicContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.Video> Video { get; set; }
    }
}
