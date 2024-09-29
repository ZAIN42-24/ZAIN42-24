namespace ELearningProject.Data
{
    public class Lesson
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required , MinLength(0)]
        public int Number {  get; set; }

        [Required]
        public string VideoUrl { get; set; }
        [Required]
        public string LessonDetails { get; set; } = string.Empty;
        [Required]
        public string CourseOrder { get; set; }

        public int ModuleId { get; set; }

        public Module? Module { get; set; }
    }
}
