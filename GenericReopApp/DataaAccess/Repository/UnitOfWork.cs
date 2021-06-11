using DataaAccess.Interfaces;
using DataaAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataaAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext Context { get; }

        public UnitOfWork(DemoDatabaseContext context)
        {
            Context = context;
        }
        //public void Commit()
        //{
        //    Context.SaveChanges();
        //}

        public void Dispose()
        {
            Context.Dispose();

        }
    }
}
