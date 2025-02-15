using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using System.Threading.Tasks;

namespace BusinessLogic.IServices
{
    public interface IPluginManagerService
    {
        void RegisterPlugin(IImageEffect plugin);
        Task ApplyEffectAsync(string effectName, ImageData image, object parameter);
    }
}
