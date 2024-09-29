namespace ELearningProject.Data
{
    public class Student_Lesson
    {
        [Required]
        public int StudentId { get; set; }
        public DateTime CompletedDateTime { get; set; }
        public int LessonId { get; set; }

        public Student? Student { get; set; }
        public Lesson? Lesson { get; set; }
    }
}
