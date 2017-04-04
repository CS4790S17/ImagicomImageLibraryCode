using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace Application.DAL
{
    public class DataContextCMSBase : Imagicom.Core.EF.DAL.DataContextBase
    {
        public DbSet<ImageLibrary> ImageLibraries { get; set; }
        public DbSet<ImageLibraryData> ImageLibraryData { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ImageLibrary>()
                .HasRequired(e => e.Data)
                .WithRequiredPrincipal();
        }

    }
}

