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

		static public string GetClassName(string DBMS_Name) {
			XmlDocument xml = new XmlDocument();
			xml.Load("ConfigFiles/DBMS_Adapters.xml");
			foreach (XmlElement el in xml.GetElementsByTagName("Adapter")) {
				foreach (XmlElement attr in el.GetElementsByTagName("Name")) {
					if (attr.InnerText == DBMS_Name) {
						return el.GetElementsByTagName("Class")[0].InnerText;
					}
				}
			}
			return null;
		}
	}
}