using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
public class EternalGoal : Goal
{
    public EternalGoal(string description, int points) : base(description, points) { }

    public override void RecordEvent()
    {
        GoalManager.UserScore += Points;
    }

    public override string GetStatus()
    {
        return "[∞] " + ToString();
    }

    public override void Reset() { } // Eternal goals do not need reset
}