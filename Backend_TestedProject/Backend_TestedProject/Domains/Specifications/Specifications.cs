using Backend_TestedProject.Domains;

namespace Backend_TestedProject.Infrastruchers.Models.Specifications
{
    public class Specifications:BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}
