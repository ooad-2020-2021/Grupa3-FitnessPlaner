﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BestHealtStrategies.Models
{
    public class Meal
    {
        public Meal() { }
        
        [Key]
        public int ID { get; set; }
        [Required, RegularExpression(@"[a-zA-Z ]+")]
        public string Title { get; set; }
        [Required, Url]
        public string Image { get; set; }
        [Required]
        public int ReadyInMinutes { get; set; }
        [Required]
        public int Servings { get; set; }
        [Required, Url]
        public string SourceURL { get; set; }
        [ForeignKey("DailyMealPlan")]
        public int? MealPlanID { get; set; }
        [Required]
        public DailyMealPlan DailyMealPlan { get; set; }
        [Required]
        public string Summary { get; set; }
        [Required]
        public string Instructions { get; set; }

        public static implicit operator List<object>(Meal v)
        {
            throw new NotImplementedException();
        }
    }
}
