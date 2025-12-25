using System.Data;

namespace S6G2
{
    public class ProgressReport
    {
        public int CompletedCredits { get; set; }
        public int RemainingCredits { get; set; }
        public DataTable CourseProgress { get; set; }
    }
}