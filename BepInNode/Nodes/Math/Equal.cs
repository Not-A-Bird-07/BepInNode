﻿using BepInNode.NodeArguments;
using IconFonts;

namespace BepInNode.Nodes.Math;

public class Equal : Node
{
    public float First { get; set; }
    public float Second { get; set; }

    public Equal()
    {
        Name = $"Equal {FontAwesome6.Equals}";
        Description = "Returns true if the two numeric values are the same";
        NodeCategory = NodeCategories.Math;

        ArgsIn.Add(new ArgIn { Type = typeof(float), ArgName = nameof(First) });
        ArgsIn.Add(new ArgIn { Type = typeof(float), ArgName = nameof(Second) });
        ArgsOut.Add(new ArgOut { Type = typeof(bool) });
    }
}
