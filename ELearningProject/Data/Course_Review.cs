namespace ELearningProject.Data
{
    public class Course_Review
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(0), MaxLength(5)]
        public int Rate { get; set; }

        public string Comment { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public Student? Student { get; set; }
        public Course? Course { get; set; }
    }
}
