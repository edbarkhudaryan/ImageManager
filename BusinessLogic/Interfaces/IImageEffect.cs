using BusinessLogic.Models;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IImageEffect
    {
        string Name { get; }
        Task ApplyAsync(ImageData image, object parameter);
    }
}
