using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class BlurEffect
    {
        public string Name => "Blur";
        public async Task ApplyAsync(ImageData image, object parameter)
        {
            await Task.Delay(100);
            image.AddEffect($"Blur applied with {parameter}px");
        }
    }
}
