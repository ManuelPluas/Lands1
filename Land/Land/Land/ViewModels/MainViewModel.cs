using System;
using System.Collections.Generic;
using System.Text;

namespace Land.ViewModels
{
    public class MainViewModel
    {
        #region ViewModel
        public LoginViewModel Login{ get; set; }
        #endregion

        #region constructores
        public MainViewModel ()
        {
            this.Login = new LoginViewModel();
        }
        #endregion
    }
}
