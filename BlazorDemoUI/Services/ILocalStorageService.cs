using System.Threading.Tasks;

namespace BlazorDemoUI.Services
{
    public interface ILocalStorageService
    {
        Task<T> GetItem<T>(string key);
        Task RemoveItem(string key);
        Task SetItem<T>(string key, T value);
    }
}