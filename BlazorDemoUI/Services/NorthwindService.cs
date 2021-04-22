using Microsoft.AspNetCore.Components;
using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoUI.Services
{
    public partial class NorthwindService
    {
        private readonly NavigationManager navigationManager;

        public NorthwindService(NavigationManager navigationManager)
        {
            this.navigationManager = navigationManager;
        }

        public void Export(string table, string type, Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"/export/northwind/{table}/{type}") : $"/export/northwind/{table}/{type}", true);
        }
    }
}
