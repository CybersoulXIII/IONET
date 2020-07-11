using System;
using System.Xml;
using System.Xml.Serialization;

namespace IONET.Collada.Physics.Physics_Material
{
	[Serializable()]
	[XmlType(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="instance_physics_material", Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=true)]
	public partial class Instance_Physics_Material
	{
		[XmlAttribute("sid")]
		public string sID;
		
		[XmlAttribute("name")]
		public string Name;	
		
		[XmlAttribute("url")]
		public string URL;	
		
	    [XmlElement(ElementName = "extra")]
		public IONET.Collada.Core.Extensibility.Extra[] Extra;		
		
	}
}

