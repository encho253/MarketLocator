﻿[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(MarketLocator.Web.App_Start.NinjectWeb), "Start")]

namespace MarketLocator.Web.App_Start
{
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject.Web.Common.WebHost;

    public static class NinjectWeb
    {
        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
        }
    }
}