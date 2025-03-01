public class Student
{
    public int Id { get; set; }
    public string UserId { get; set; } // Link to Identity User
    public string Name { get; set; }
    public ICollection<Submission> Submissions { get; set; }
}