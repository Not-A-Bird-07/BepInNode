using BepInNode.NodeArguments;

namespace BepInNode.Nodes.GameObject;

public class RightHandTransform : Node
{
    public RightHandTransform()
    {
        Name = nameof(RightHandTransform);
        Description = "Returns the right hand transform of your gorilla.";
        NodeCategory = NodeCategories.GorillaTagger;
        SizeOverride = new(250, 120);

        ArgsOut.Add(new ArgOut { Type = typeof(UnityEngine.Transform) });
    }
}
