using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MaerskLineDDAC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserTokenCache> UserTokenCacheList { get; set; }

        public System.Data.Entity.DbSet<MaerskLineDDAC.Models.Company> Companies { get; set; }

        public System.Data.Entity.DbSet<MaerskLineDDAC.Models.Container> Containers { get; set; }

        public System.Data.Entity.DbSet<MaerskLineDDAC.Models.Ship> Ships { get; set; }

        public System.Data.Entity.DbSet<MaerskLineDDAC.Models.Yard> Yards { get; set; }

        public System.Data.Entity.DbSet<MaerskLineDDAC.Models.BookingSchedule> BookingSchedules { get; set; }
    }

    public class UserTokenCache
    {
        [Key]
        public int UserTokenCacheId { get; set; }
        public string webUserUniqueId { get; set; }
        public byte[] cacheBits { get; set; }
        public DateTime LastWrite { get; set; }
    }
}