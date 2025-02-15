using BusinessLogic.IServices;
using ImageManager.Mapers;
using ImageManager.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace ImageManager.Controllers
{
	public class ImageEffectsController : ApiController
	{
        private readonly IPluginManagerService _pluginManager;

        public ImageEffectsController(IPluginManagerService pluginManager)
        {
            _pluginManager = pluginManager;
        }

        [HttpPost]
        [Route("api/applyEffect")]
        public async Task<IHttpActionResult> ApplyEffect([FromBody] EffectRequest request)
        {
            var image = Mappers.MapToImageData(new ImageDataModel { Name = request.ImageName, AppliedEffects = new List<string>() });
            await _pluginManager.ApplyEffectAsync(request.EffectName, image, request.Parameter);
            return  Ok(new { image.Name, Effects = image.AppliedEffects });
        }
    }
}