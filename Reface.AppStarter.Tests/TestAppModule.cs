﻿using System.Collections.Generic;

namespace Reface.AppStarter.Tests
{
    public class TestAppModule : IAppModule
    {

        public IEnumerable<IAppModule> DependentModules => new IAppModule[]
        {
            new ComponentScanAppModule(this)
        };

        public void OnUsing(AppSetup setup)
        {
        }
    }
}
