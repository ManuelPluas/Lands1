using System;
using System.Collections.Generic;
using System.Text;

namespace Land.Infrastructure
{
    using ViewModels;
    public class InstanceLocator
    {
        #region properties
        public MainViewModel Main
            { 
            get; 
            set; 
            }
        #endregion
        #region contructores
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
