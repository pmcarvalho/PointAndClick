using Godot;
using System;
using System.ComponentModel;

public partial class FloorCollisionShape3D : CollisionShape3D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public override void _UnhandledInput(InputEvent @event)
	{
		if (@event is InputEventMouseButton button)
		{
			if(button.Pressed == true && button.ButtonIndex == (Godot.MouseButton) 1)
			{
				CharacterBody3D player = (CharacterBody3D)GetNode("../../CharacterBody3D");
				//player.Position = new Vector3(0,0,0);
				player.Position = new Vector3(button.Position[0],player.Position[1],button.Position[1]);
				GD.Print("AA",button.Position);
				GD.Print(player.Position);
				foreach(PropertyDescriptor descriptor in TypeDescriptor.GetProperties(button))
				{
					string name = descriptor.Name;
					object value = descriptor.GetValue(button);
					//GD.Print("{", name,"} = {", value, "}");
				}
			}
		}
	}
	
}
