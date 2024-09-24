using Godot;
using System;

public partial class Player : CharacterBody2D
{
    [Export]
    public PackedScene Test { get; set; }

	public override void _Ready()
	{
		
	}

    public override void _Process(double delta)
    {
        base._Process(delta);

        if (Input.IsActionJustPressed("drop_coin"))
        {
            Node2D t = (Node2D)Test.Instantiate();

            t.Transform = this.Transform;

            GetParent().AddChild(t);
        }
    }

}
