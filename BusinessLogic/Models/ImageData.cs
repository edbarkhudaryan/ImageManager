using System.Collections.Generic;

namespace BusinessLogic.Models
{
    public class ImageData
    {
        public string Name { get; set; }
        public List<string> AppliedEffects { get;  set; } = new List<string>();

        public void AddEffect(string effectName)
        {
            AppliedEffects.Add(effectName);
        }
    }
}
