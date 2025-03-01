using System.ComponentModel.DataAnnotations;

public class Report
{
    [Key] // Explicitly mark this property as the primary key
    public int ReportId { get; set; } // Primary key

    public string ReportName { get; set; }
    public DateTime GeneratedDate { get; set; }
    // Other properties
}