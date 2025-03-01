public class Feedback
{
    public int Id { get; set; }
    public int SubmissionId { get; set; }
    public Submission Submission { get; set; }
    public string Comment { get; set; }
    public int Grade { get; set; }
}