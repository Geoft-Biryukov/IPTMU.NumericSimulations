using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace IPTMU.OrientationSimulation.WinFormsMain.Localization
{
    public static class UpdateAppConfig
    {
        private readonly static string appSettings = "appSettings";

        public static void Update(string key, string value)
        {
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentException($"'{nameof(key)}' cannot be null or whitespace.", nameof(key));
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException($"'{nameof(value)}' cannot be null or whitespace.", nameof(value));
            
            var doc = new XmlDocument();
            doc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            var elements = doc.GetElementsByTagName(appSettings);

            foreach (XmlElement element in elements)
            {
                foreach (XmlNode node in element.ChildNodes)
                {
                    if(node.Attributes[0].Value.Equals(key))
                    {
                        node.Attributes[1].Value = value;
                    }
                }
            }

            ConfigurationManager.RefreshSection(appSettings);
            doc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }
    }
}
