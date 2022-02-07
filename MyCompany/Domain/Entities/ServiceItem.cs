using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Fill in the service name")]
        [Display(Name = "Service Name")]
        public override string Title { get; set; }

        [Display(Name = "Short description of the service")]
        public override string Subtitle { get; set; }

        [Display(Name = "Full description of the service")]
        public override string Text { get; set; }
    }
}
