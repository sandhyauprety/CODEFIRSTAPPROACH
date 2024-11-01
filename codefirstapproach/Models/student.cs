using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace codefirstapproach.Models
{
    public class student
    {
        [Key]
        public int ID { get; set; }
        [Column("StudentName",TypeName="varchar(200)")]
        public string Name { get; set; }

        [Column("StudentGender", TypeName = "varchar(200)")]

        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
