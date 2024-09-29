namespace ELearningProject.Data
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public double Price { get; set; } = 0;
        public bool IsProgressLimited { get; set; } = false;
        public int InstructorId { get; set; }
        public Instructor? Instructor { get; set; }
    }
}
