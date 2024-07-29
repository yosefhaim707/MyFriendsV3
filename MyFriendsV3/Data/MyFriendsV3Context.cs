using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFriendsV3.Models;

namespace MyFriendsV3.Data
{
    public class MyFriendsV3Context : DbContext
    {
        public MyFriendsV3Context (DbContextOptions<MyFriendsV3Context> options)
            : base(options)
        {
        }

        public DbSet<MyFriendsV3.Models.Picture> Picture { get; set; } = default!;
        public DbSet<MyFriendsV3.Models.User> User { get; set; } = default!;
    }
}
