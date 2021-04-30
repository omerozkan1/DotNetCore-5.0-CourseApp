﻿using System.ComponentModel.DataAnnotations;

namespace FreeCourse.Web.Models.Catalog
{
    public class CourseCreateInput
    {
        [Display(Name="Kurs ismi")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Kurs fiyatı")]
        [Required]
        public decimal Price { get; set; }

        [Display(Name = "Kurs açıklaması")]
        [Required]
        public string Description { get; set; }
        public string UserId { get; set; }
        public string Picture { get; set; }

        [Display(Name = "Kurs kategorisi")]
        [Required]
        public string CategoryId { get; set; }
        public FeatureViewModel Feature { get; set; }
    }
}
