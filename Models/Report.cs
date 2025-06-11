namespace Models
{
    public class Report
    {
        public int ReporterId { get; set; }
        public int TargetId { get; set; }
        public string ReportText { get; set; }
        public DateTime SubmissionTime { get; set; }

        public Report(int reporterId, int targetId, string reportText, DateTime submissionTime)
        {
            ReporterId = reporterId;
            TargetId = targetId;
            ReportText = reportText;
            SubmissionTime = submissionTime;
        }
    }
}