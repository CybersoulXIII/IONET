using System;
using System.Xml;
using System.Xml.Serialization;

namespace IONET.Collada.Types
{
	[Serializable()]
	[XmlType(AnonymousType=true)]
	public partial class SID_Name_String
	{
		[XmlAttribute("sid")]
		public string sID;
		
		[XmlAttribute("name")]
		public string Name;

		[XmlText()]
	    public string Value;
    }
}

