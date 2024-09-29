namespace ELearningProject.Data
{
    public class Enrolment
    {
        [Required]
        public DateTime EnrolmentDateTime { get; set; } = DateTime.Now;
        public DateTime CompletedDateTime {  get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Course? Course { get; set; }
        public Student? Student { get; set; }
    }
}
