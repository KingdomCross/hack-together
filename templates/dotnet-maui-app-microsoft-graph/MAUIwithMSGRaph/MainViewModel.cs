using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIwithMSGRaph
{
    internal class MainViewModel
    {
        [ObservableProperty]
        private string userName = "";

        [ObservableProperty]
        private string userGivenName = "";

        [ObservableProperty]
        private string userSurname = "";

        [ObservableProperty]
        private string userPrincipalName = "";
    }
}
