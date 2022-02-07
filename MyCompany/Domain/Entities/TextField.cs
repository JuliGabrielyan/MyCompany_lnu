using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Title")]
        public override string Title { get; set; } = "Info Page";

        [Display(Name = "Content")]
        public override string Text { get; set; } = "Content is filled by admin";
    }
}
