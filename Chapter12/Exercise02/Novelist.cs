using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[XmlRoot("novelist")]
public class Novelist {
    [XmlElement(ElementName = "name")]
    [DataMember(Name = "name")]
    public string Name { get; set; }

    [XmlElement(ElementName = "birth")]
    [DataMember(Name = "birth")]
    public DateTime Birth { get; set; }

    [XmlArray("masterpieces")]
    [XmlArrayItem("title",typeof(string))]
    [DataMember(Name = "masterpieces")]
    public string[] Masterpieces { get; set; }

    public override string ToString()
    {
        return string.Format("[Name={0}, Birth={1}, Masterpieces={2}]",
                              Name, Birth, Masterpieces);
    }
}
