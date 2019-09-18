using Murano.DBRepository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Murano.DBRepository
{
    public class MuranoContext : DbContext
    {
        public MuranoContext() : base("Murano") { }

        public DbSet<ResultRequests> ResultRequests { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<ResultRequests>();
        //}
    }

    //public class MuranoInitializer : DropCreateDatabaseIfModelChanges<MuranoContext>
    //{
    //    protected override void Seed(MuranoContext context)
    //    {
    //        var resultRequests = new List<ResultRequests>()
    //        {
    //            new ResultRequests
    //            {
    //                Name = "Тест",
    //                Link = "Урл",
    //                Snippet = "Описание"
    //            }
    //        };
    //        resultRequests.ForEach(i => context.ResultRequests.Add(i));
    //        context.SaveChanges();
    //    }
    //}
}