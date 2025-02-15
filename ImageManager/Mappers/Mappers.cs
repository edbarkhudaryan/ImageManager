using BusinessLogic.Models;
using ImageManager.Models;
using System.Collections.Generic;

namespace ImageManager.Mapers
{
	public static class Mappers
	{
        public static ImageData MapToImageData(ImageDataModel model)
        {
            return new ImageData
            {
                Name = model.Name,
                AppliedEffects = new List<string>(model.AppliedEffects)
            };
        }

    }
}