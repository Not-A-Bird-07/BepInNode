using BepInNode.NodeArguments;

namespace BepInNode.Nodes.GameObject;

public class LeftHandTransform : Node
{
    public LeftHandTransform()
    {
        Name = nameof(LeftHandTransform);
        Description = "Returns the left hand transform of your gorilla.";
        NodeCategory = NodeCategories.GorillaTagger;
        SizeOverride = new(250, 120);

        ArgsOut.Add(new ArgOut { Type = typeof(UnityEngine.Transform) });
    }
}
