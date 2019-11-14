﻿using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Microsoft.Extensions.Configuration;
using Swizzer.Web.Infrustructure.SQL;

namespace Swizzer.Web.Infrustructure.IoC
{
    public class MainModule : Autofac.Module
    {
        private readonly IConfiguration _configuration;
        public MainModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new SqlModule(_configuration));
            base.Load(builder);
        }
    }
}
