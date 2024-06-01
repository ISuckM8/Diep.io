using Godot;
using System;

public partial class Health : Node2D
{
	[Signal]
	public delegate void HealthChangedEventHandler();

	[Signal]
	public delegate void DeathEventHandler();

	[Export]
	public float healthCurrent;	// Health is never going to be affected by a stat, so it'll remain as a variable.

	public Stat HealthMax;	// Mostly for tanks and projectiles, won't affect XP givers.



    public void TakeDamge(int damageTaken)
	{
		healthCurrent -= damageTaken;

		if (healthCurrent < 0)
		{
			healthCurrent = 0;
			
			EmitSignal(SignalName.Death);
		}

		EmitSignal(SignalName.HealthChanged);
	}

	public void Heal(int healthHealed)
	{
		healthCurrent += healthHealed;

		if (healthCurrent > HealthMax.StatCurrentValue)
		{
			healthCurrent = HealthMax.StatCurrentValue;
		}

		EmitSignal(SignalName.HealthChanged);
	}
}
