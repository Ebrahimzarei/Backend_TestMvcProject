using System.ComponentModel.DataAnnotations;

namespace Backend_TestedProject.Domains
{
    public class BaseEntity
    {
        [Key]
        public Nullable<int> Id { get; set; }

    }
}
