﻿namespace TaskTracker.Models;

public class Task
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public Priority Priority { get; set; }
    public DateTime TargetDate { get; set; }
}