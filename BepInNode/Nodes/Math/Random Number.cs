using BepInNode.NodeArguments;

namespace BepInNode.Nodes.Math
{
    public class Random_Number_Float : Node
    {
        public float First { get; set; }
        public float Second { get; set; }

        public Random_Number_Float()
        {
            Name = $"Random Number Float";
            Description = "Returns A Random Float";
            NodeCategory = NodeCategories.Math;

            ArgsIn.Add(new ArgIn { Type = typeof(float), ArgName = nameof(First) });
            ArgsIn.Add(new ArgIn { Type = typeof(float), ArgName = nameof(Second) });
            ArgsOut.Add(new ArgOut { Type = typeof(float) });
        }
    }

    public class Random_Number_Int : Node
    {
        public float First { get; set; }
        public float Second { get; set; }

        public Random_Number_Int()
        {
            Name = $"Random Number Int";
            Description = "Returns A Random Int";
            NodeCategory = NodeCategories.Math;

            ArgsIn.Add(new ArgIn { Type = typeof(Int32), ArgName = nameof(First) });
            ArgsIn.Add(new ArgIn { Type = typeof(Int32), ArgName = nameof(Second) });
            ArgsOut.Add(new ArgOut { Type = typeof(Int32) });
        }
    }
}
