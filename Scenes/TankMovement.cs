using Godot;
using System;

public partial class TankMovement : Node2D
{
	public void MoveTank(float x, float y, float speed)
	{
		Position += new Vector2(x, y) * speed;
	}

	public void LookAtMouse()
	{
		LookAt(GetGlobalMousePosition());
	}
}
