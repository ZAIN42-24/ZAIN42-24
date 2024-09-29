namespace ELearningProject.Data
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Phone_Number { get; set; }
        public string RegisterEmail { get; set; }

        public ELearningProject.Areas.Identity.Pages.Account.RegisterModel? RegisterModel { get; set; }
        public int RoleId { get; set; }
        public Role? Role { get; set; }
    }
}
