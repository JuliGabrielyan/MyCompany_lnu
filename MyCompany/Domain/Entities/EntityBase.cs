using System;
using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get;set; }

        [Display(Name = "Title")]
        public virtual string Title { get; set; }

        [Display(Name = "Subtitle")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Full Description")]
        public virtual string Text { get; set; }

        [Display(Name = "Title Image")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "SEO MetaTitle")]
        public string MetaTitle { get; set; }

        [Display(Name = "SEO MetaDescription")]
        public string MetaDescription { get; set; }

        [Display(Name = "SEO MetaKeywords")]
        public string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
