using BepInNode.CustomAttributes;
using BepInNode.NodeArguments;
using System.Xml.Serialization;
using Newtonsoft.Json;
using UnityEngine;

namespace BepInNode.Core.CoreNodes.Variables.Set
{
    public class PrimitiveTypeSet : Node
    {
        [IgnoreProperty]
        public UnityEngine.PrimitiveType ValueIn { get; set; }

        [IgnoreProperty]
        public PrimitiveType EnumValue { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        public List<Enum> PrimitiveEnums { get; set; } = new();

        public PrimitiveTypeSet()
        {
            Name = "PrimitiveTypeSet";
            NodeType = NodeTypes.Variable;
            Description = "Sets the value of the PrimitiveType variable";
            NodeCategory = NodeCategories.Variables;
            SizeOverride = new(300, 150);

            foreach (UnityEngine.PrimitiveType key in Enum.GetValues(typeof(UnityEngine.PrimitiveType)))
                PrimitiveEnums.Add(key);

            ArgsIn.Add(new ArgIn { Type = typeof(UnityEngine.PrimitiveType), ArgName = nameof(PrimitiveType) });
            ArgsOut.Add(new ArgOut { Type = typeof(UnityEngine.PrimitiveType) });
        }
    }
}
