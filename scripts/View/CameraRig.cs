using Godot;
using System;

public partial class CameraRig : Node3D
{
	[Export] public float MoveSpeed { get; set; } = 10f;

	public override void _Process(double delta)
	{
		Vector2 input = Input.GetVector("camera_left", "camera_right", "camera_forward", "camera_back");
		Vector3 direction = new Vector3(input.X, 0f, input.Y);
		direction = Transform.Basis * direction;
		Position += direction * MoveSpeed * (float)delta;
	}
}
