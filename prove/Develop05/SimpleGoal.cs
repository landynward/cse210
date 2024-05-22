using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
public class SimpleGoal : Goal
{
    public SimpleGoal(string description, int points) : base(description, points) { }

    public override void RecordEvent()
    {
        IsCompleted = true;
        GoalManager.UserScore += Points;
    }

    public override string GetStatus()
    {
        return IsCompleted ? "[X] " + ToString() : "[ ] " + ToString();
    }

    public override void Reset() { } // Simple goals do not need reset
}