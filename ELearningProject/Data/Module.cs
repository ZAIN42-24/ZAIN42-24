namespace ELearningProject.Data
{
    public class Module
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required, MinLength(0)]
        public int Number {  get; set; }

        public int CourseId { get; set; }

        public Course? Course { get; set; }
    }
}
