﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoWeb2V2.App_Start.StartUp))]
namespace ProyectoWeb2V2.App_Start
{
    public partial class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}