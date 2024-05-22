using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
// Base class for goals
public abstract class Goal
{
    public string Description { get; set; }
    public int Points { get; set; }
    public bool IsCompleted { get; internal set; } // Change the setter to internal

    protected Goal(string description, int points)
    {
        Description = description;
        Points = points;
        IsCompleted = false;
    }

    public abstract void RecordEvent();
    public abstract string GetStatus();
    public abstract void Reset();

    public override string ToString()
    {
        return $"{Description} - {Points} points";
    }
}

