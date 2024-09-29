namespace ELearningProject.Data
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
