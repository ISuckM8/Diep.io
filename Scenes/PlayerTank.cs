using Godot;
using System;

public partial class PlayerTank : Node2D
{
	private Health healthNode;
	private TankMovement tankMovement;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		healthNode = GetNode<Health>("TankBase/Health");
		healthNode.HealthMax = new Stat(100, 15);
		healthNode.healthCurrent = healthNode.HealthMax.StatCurrentValue;

		tankMovement = GetNode<TankMovement>("TankBase/TankMovement");
	}

    public override void _PhysicsProcess(double delta)
    {
        tankMovement.LookAtMouse();
    }
}
