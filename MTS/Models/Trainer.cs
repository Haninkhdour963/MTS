﻿public class Trainer
{
    public int Id { get; set; }
    public string UserId { get; set; } // Link to Identity User
    public string Name { get; set; }
    public ICollection<Task> Tasks { get; set; }
}