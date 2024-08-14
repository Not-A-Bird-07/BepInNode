using BepInNode.NodeArguments;
using UnityEngine;

namespace BepInNode.Core.CoreNodes.Variables.Get
{
    public class PrimitiveTypeGet : Node
    {
        public PrimitiveTypeGet()
        {
            Name = "PrimitiveTypeGet";
            NodeType = NodeTypes.Variable;
            Description = "Gets the value of the PrimitiveType variable";
            NodeCategory = NodeCategories.Variables;

            ArgsOut.Add(new ArgOut { Type = typeof(PrimitiveType) });
        }
    }
}
