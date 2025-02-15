using System.Collections.Generic;

namespace ImageManager.Models
{
	public class ImageDataModel
    {
        public string Name { get; set; }
        public List<string> AppliedEffects { get;  set; } = new List<string>();
    }
}