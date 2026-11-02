using System;
using Godot;

public partial class CameraRig : Node3D
{
    [Export] public float MoveSpeed { get; set; } = 10f;
    [Export] public float RotationSpeed { get; set; } = 90f;
    [Export] public float MouseSensitivity { get; set; } = 0.3f;
    [Export] public float ZoomStep { get; set; } = 1f;
    [Export] public float MinZoom { get; set; } = 5f;
    [Export] public float MaxZoom { get; set; } = 30f;
    [Export] public float MinPitch { get; set; } = -80f;
    [Export] public float MaxPitch { get; set; } = -25f;
    [Export] public float Smoothing { get; set; } = 10f;


    private Node3D _pitchNode;
    private Camera3D _camera;

    private Vector3 _targetPosition;
    private float _targetYaw;
    private float _targetPitch;
    private float _targetZoom;

    private float _yaw;
    private float _pitch;
    private float _zoom;

    public override void _Ready()
    {
        _pitchNode = GetNode<Node3D>("Pitch");
        _camera = GetNode<Camera3D>("Pitch/Camera3D");

        _targetPosition = Position;
        _yaw = _targetYaw = RotationDegrees.Y;
        _pitch = _targetPitch = _pitchNode.RotationDegrees.X;
        _zoom = _targetZoom = _camera.Position.Z;
    }

    public override void _Process(double delta)
    {
        float dt = (float)delta;

        Vector2 input = Input.GetVector("camera_left", "camera_right", "camera_forward", "camera_back");
        Vector3 direction = Transform.Basis * new Vector3(input.X, 0f, input.Y);
        _targetPosition += direction * MoveSpeed * dt;

        float rotationInput = Input.GetAxis("camera_rotate_left", "camera_rotate_right");
        _targetYaw -= rotationInput * RotationSpeed * dt;

        float t = 1f - Mathf.Exp(-Smoothing * dt);
        Position = Position.Lerp(_targetPosition, t);
        _yaw = Mathf.Lerp(_yaw, _targetYaw, t);
        _pitch = Mathf.Lerp(_pitch, _targetPitch, t);
        _zoom = Mathf.Lerp(_zoom, _targetZoom, t);

        RotationDegrees = new Vector3(0f, _yaw, 0f);
        _pitchNode.RotationDegrees = new Vector3(_pitch, 0f, 0f);
        _camera.Position = new Vector3(0f, 0f, _zoom);
    }

    public override void _UnhandledInput(InputEvent @event)
    {
        if (@event is InputEventMouseMotion motion && Input.IsActionPressed("camera_drag"))
        {
            _targetYaw -= motion.Relative.X * MouseSensitivity;
            _targetPitch = Mathf.Clamp(_targetPitch - motion.Relative.Y * MouseSensitivity, MinPitch, MaxPitch);
        }
        if (@event.IsActionPressed("camera_zoom_in"))
            _targetZoom = Mathf.Clamp(_targetZoom - ZoomStep, MinZoom, MaxZoom);
        if (@event.IsActionPressed("camera_zoom_out"))
            _targetZoom = Mathf.Clamp(_targetZoom + ZoomStep, MinZoom, MaxZoom);
        if (_targetZoom == 0)
        {
            return;
        }

    }
}
