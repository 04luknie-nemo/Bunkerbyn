using Godot;
using System;

public partial class CameraRig : Node3D
{
	[Export] public float MoveSpeed { get; set; } = 10f;
	[Export] public float RotationSpeed { get; set; } = 90f;

	public override void _Process(double delta)
	{
		Vector2 input = Input.GetVector("camera_left", "camera_right", "camera_forward", "camera_back");
		Vector3 direction = new Vector3(input.X, 0f, input.Y);
		direction = Transform.Basis * direction;
		Position += direction * MoveSpeed * (float)delta;

		float rotationInput = Input.GetAxis("camera_rotate_left", "camera_rotate_right");
		RotateY(Mathf.DegToRad(RotationSpeed * -rotationInput * (float)delta));
	}
}
