using Godot;
using System;

public partial class Health : Node2D
{
	[Signal]
	public delegate void HealthChangedEventHandler();

	[Signal]
	public delegate void DeathEventHandler();

	public Stat HealthCurrent;
	public Stat HealthMax;



    public void TakeDamge(int damageTaken)
	{
		HealthCurrent.StatCurrentValue -= damageTaken;
		if (HealthCurrent.StatCurrentValue <= 0)
		{
			HealthCurrent.StatCurrentValue = 0;
			
			Death();
		}

		EmitSignal(SignalName.HealthChanged);
	}

	public void Death()
	{
		EmitSignal(SignalName.Death);
	}
}
