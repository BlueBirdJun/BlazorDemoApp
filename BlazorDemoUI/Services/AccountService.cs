using BlazorDemoUI.Models;
using BlazorDemoUI.Models.Account;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDemoUI.Services
{
    public class AccountService
    {
        private IHttpService _httpService;
        private NavigationManager _navigationManager;
        private string _userKey = "user";

        public User User { get; private set; }
    }
}
