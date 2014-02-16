using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Kartwheel_Desktop {
	public static class AppConfiguration {
		static public List<string> GetDBMS_AdaptersNames() {
			XmlDocument xml = new XmlDocument();
			xml.Load("ConfigFiles/DBMS_Adapters.xml");
			List<string> adapters = new List<string>();
			foreach (XmlElement adapter in xml.GetElementsByTagName("Adapter")) {
				foreach (XmlElement attribute in adapter) {
					if (attribute.Name == "Name") {
						adapters.Add(attribute.InnerText);
					}
				}
			}
			return adapters;
		}
	}
}
