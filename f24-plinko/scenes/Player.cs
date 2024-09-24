using Godot;
using System;

public partial class Player : CharacterBody2D
{
    [Export]
    public PackedScene Test { get; set; }

    [Export]
    public float Speed { get; set; } = 100.0f;

    public override void _Ready()
    {
        // not doing anything in the setup yet
    }

    public override void _Process(double delta)
    {
        base._Process(delta);

        Vector2 displacement = new Vector2(0, 0);

        if (Input.IsKeyPressed(Key.A))
        {
            displacement.X = -Speed * (float)delta;
        }

        if (Input.IsKeyPressed(Key.D))
        {
            displacement.X = +Speed * (float)delta;
        }

        Position += displacement;


        if (Input.IsActionJustPressed("drop_coin"))
        {
            Node2D t = Test.Instantiate<Node2D>();

            t.Transform = this.Transform;

            GetParent().AddChild(t);
        }
    }

}
