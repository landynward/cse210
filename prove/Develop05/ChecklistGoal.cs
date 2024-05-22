using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string description, int points, int targetCount, int bonusPoints) : base(description, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = 0;
    }

    public override void RecordEvent()
    {
        CurrentCount++;
        GoalManager.UserScore += Points;
        if (CurrentCount >= TargetCount)
        {
            IsCompleted = true;
            GoalManager.UserScore += BonusPoints;
        }
    }

    public override string GetStatus()
    {
        return IsCompleted ? $"[X] {ToString()} (Completed {CurrentCount}/{TargetCount} times)" : $"[ ] {ToString()} (Completed {CurrentCount}/{TargetCount} times)";
    }

    public override void Reset()
    {
        CurrentCount = 0;
        IsCompleted = false;
    }
}