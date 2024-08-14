using BepInNode.CustomAttributes;
using BepInNode.NodeArguments;
using Newtonsoft.Json;
using System.Xml.Serialization;
using UnityEngine;

namespace BepInNode.Nodes.GameObject
{
    public class NewGameObject : Node
    {
        [IgnoreProperty]
        public PrimitiveType EnumValue { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        public List<Enum> PrimitiveEnums { get; set; } = new();

        public System.Numerics.Vector3 Pos { get; set; }
        public System.Numerics.Vector3 Rot { get; set; }
        public System.Numerics.Vector3 Scl { get; set; }

        public NewGameObject()
        {
            Name = nameof(NewGameObject);
            Description = "Instantiates a new Game Object";
            NodeCategory = NodeCategories.GameObject;
            SizeOverride = new(300, 320);

            foreach (UnityEngine.PrimitiveType key in Enum.GetValues(typeof(UnityEngine.PrimitiveType)))
                PrimitiveEnums.Add(key);

            ArgsIn.Add(new ArgIn { Type = typeof(PrimitiveType), ArgName = nameof(PrimitiveType) });
            ArgsIn.Add(new ArgIn { Type = typeof(System.Numerics.Vector3), ArgName = nameof(Pos) });
            ArgsIn.Add(new ArgIn { Type = typeof(System.Numerics.Vector3), ArgName = nameof(Rot) });
            ArgsIn.Add(new ArgIn { Type = typeof(System.Numerics.Vector3), ArgName = nameof(Scl) });

            ArgsOut.Add(new ArgOut { Type = typeof(UnityEngine.GameObject) });
        }
    }
}
