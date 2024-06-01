using Godot;
using System;

public partial class Stat : Node
{
	public float StatCurrentValue { get; set; }
	public float StatIncrementValue { get; private set; }
	public int StatLevel { get; private set; }


	public void IncreaseStatLevel()
	{
		StatLevel++;
		StatCurrentValue = StatCurrentValue + (StatIncrementValue * (StatLevel - 1));
	}


	public Stat(float statCurrentValue, float statIncrementValue)
	{
		StatCurrentValue = statCurrentValue;
		StatIncrementValue = statIncrementValue;;
		StatLevel = 0;
	}
}
