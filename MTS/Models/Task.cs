﻿public class Task
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Deadline { get; set; }
    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; }
    public ICollection<Submission> Submissions { get; set; }
}