﻿using ClassLibrary1;
using ClassLibrary1.Services;
using Reface.AppStarter.AppModules;
using Reface.AppStarter.Attributes;
using Reface.AppStarter.Tests.Services;

namespace Reface.AppStarter.Tests
{
    [AutoConfigAppModule]
    [ComponentScanAppModule]
    [CL1AppModule]
    public class TestAppModule : AppModule
    {
        [ComponentCreator]
        public IServiceRegistedByAppModule GetServiceRegistedByAppModule()
        {
            return new DefaultServiceRegistedByAppModule();
        }

        [ReplaceCreator]
        public ICL1Service GetCL1Service()
        {
            return new MyDefaultCL1Service();
        }
    }
}
