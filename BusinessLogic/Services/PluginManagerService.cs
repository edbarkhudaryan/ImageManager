using BusinessLogic.Interfaces;
using BusinessLogic.IServices;
using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BusinessLogic.Services
{
    public class PluginManagerService : IPluginManagerService
    {
        private readonly Dictionary<string, IImageEffect> _plugins = new Dictionary<string, IImageEffect>();

        public void RegisterPlugin(IImageEffect plugin)
        {
            if (!_plugins.ContainsKey(plugin.Name))
            {
                _plugins[plugin.Name] = plugin;
            }
        }

        public async Task ApplyEffectAsync(string effectName, ImageData image, object parameter)
        {
            if (_plugins.ContainsKey(effectName))
            {
                await _plugins[effectName].ApplyAsync(image, parameter);
            }
            else
            {
                Console.WriteLine($"Effect {effectName} not found.");
            }
        }
    }

}
