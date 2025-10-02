using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GiftOfTheGiversMWeb.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
        public string Location { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        public string Status { get; set; }

        // Navigation properties
        public virtual ICollection<Donation> Donations { get; set; }
        public virtual ICollection<Volunteer> Volunteer { get; set; }


    }
}
