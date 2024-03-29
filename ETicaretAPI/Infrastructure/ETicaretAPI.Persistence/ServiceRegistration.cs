﻿using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace ETicaretAPI.Persistence
{
    public static  class ServiceRegistration
    {
        public static void AddPersistenceServices(this
            IServiceCollection services)
        {
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        }
    }
}
