public class Submission
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int TaskId { get; set; }
    public Task Task { get; set; }
    public string FilePath { get; set; }
    public DateTime SubmissionDate { get; set; }
    public ICollection<Feedback> Feedbacks { get; set; }
}