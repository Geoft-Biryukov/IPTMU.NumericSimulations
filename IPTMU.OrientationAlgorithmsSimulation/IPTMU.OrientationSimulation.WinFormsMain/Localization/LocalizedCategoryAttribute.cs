using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.OrientationSimulation.WinFormsMain.Localization
{
    public class LocalizedCategoryAttribute : CategoryAttribute
    {
        private readonly ResourceManager resourceManager;
        private readonly string resourceKey;

        public LocalizedCategoryAttribute(string resourceKey)
            : base (resourceKey)
        {
            if (string.IsNullOrWhiteSpace(resourceKey))
                throw new ArgumentException($"'{nameof(resourceKey)}' cannot be null or whitespace.", nameof(resourceKey));

            this.resourceKey = resourceKey;
            resourceManager = new ResourceManager("IPTMU.OrientationSimulation.WinFormsMain.Resources.GlobalStrings",
                typeof(LocalizedDisplayNameAttribute).Assembly);
        }        

        protected override string GetLocalizedString(string value)
        {
            var localizedValue = resourceManager.GetString(value);
            return string.IsNullOrWhiteSpace(localizedValue) ? $"[[{value}]]" : localizedValue;
        }
    }
}
