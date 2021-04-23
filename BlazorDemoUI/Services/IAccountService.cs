using BlazorDemoUI.Models;
using BlazorDemoUI.Models.Account;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDemoUI.Services
{
    public interface IAccountService
    {
        User User { get; }

        Task Delete(string id);
        Task<IList<User>> GetAll();
        Task<User> GetById(string id);
        Task Initialize();
        Task Login(Login model);
        Task Logout();
        Task Register(AddUser model);
        Task Update(string id, EditUser model);
    }
}