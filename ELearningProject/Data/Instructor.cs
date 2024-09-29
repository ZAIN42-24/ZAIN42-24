namespace ELearningProject.Data
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        public int User_ID { get; set; }
        public User? User { get; set; }
    }
}
