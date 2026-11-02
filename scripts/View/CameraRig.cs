using Godot;
using System;

public partial class CameraRig : Node3D
{
    [Export] public float MoveSpeed { get; set; } = 10f;
    [Export] public float RotationSpeed { get; set; } = 90f;
    [Export]
    public float ZoomStep { get; set; } = 1f;
    public float MinZoom { get; set; } = 5f;
    public float MaxZoom { get; set; } = 30f;

    private Camera3D _camera;

    public override void _Ready()
    {
        _camera = GetNode<Camera3D>("Pitch/Camera3D");
    }


    public override void _Process(double delta)
    {
        Vector2 input = Input.GetVector("camera_left", "camera_right", "camera_forward", "camera_back");
        Vector3 direction = new Vector3(input.X, 0f, input.Y);
        direction = Transform.Basis * direction;
        Position += direction * MoveSpeed * (float)delta;

        float rotationInput = Input.GetAxis("camera_rotate_left", "camera_rotate_right");
        RotateY(Mathf.DegToRad(RotationSpeed * -rotationInput * (float)delta));
    }

    public override void _UnhandledInput(InputEvent @event)
    {
        float change = 0f;
        if (@event.IsActionPressed("camera_zoom_in"))
            change = -ZoomStep;
        if (@event.IsActionPressed("camer_zoom_out"))
            change = ZoomStep;
        if (change == 0f) return;

        Vector3 pos = _camera.Position;
        pos.Z = Math.Clamp(pos.Z + change, MinZoom, MaxZoom);
        _camera.Position = pos;
    }
}
