using BepInNode.NodeArguments;

namespace BepInNode.Nodes.GameObject;

public class IsModdedRoom : Node
{
    public IsModdedRoom()
    {
        Name = nameof(IsModdedRoom);
        Description = "Returns true if you are in a modded room, else returns false";
        NodeCategory = NodeCategories.Room;
        SizeOverride = new(250, 120);

        ArgsOut.Add(new ArgOut { Type = typeof(bool) });
    }
}
