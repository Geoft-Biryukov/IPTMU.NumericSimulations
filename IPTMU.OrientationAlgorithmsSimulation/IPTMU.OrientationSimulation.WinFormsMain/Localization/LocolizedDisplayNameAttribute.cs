using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.OrientationSimulation.WinFormsMain.Localization
{
    public class LocolizedDisplayNameAttribute : DisplayNameAttribute
    {
        private readonly ResourceManager resourceManager;
        private readonly string resourceKey;

        public LocolizedDisplayNameAttribute(string resourceKey)
        {
            if (string.IsNullOrWhiteSpace(resourceKey)) 
                throw new ArgumentException($"'{nameof(resourceKey)}' cannot be null or whitespace.", nameof(resourceKey));
            
            this.resourceKey = resourceKey;
            resourceManager = new ResourceManager(typeof(string));
        }

        public override string DisplayName
        {
            get
            {
                var displayName = Properties.Resources.ResourceManager.GetString(resourceKey);
                return string.IsNullOrWhiteSpace(displayName) ? $"[[{resourceKey}]]" : displayName;
            }
        }
    }
}
