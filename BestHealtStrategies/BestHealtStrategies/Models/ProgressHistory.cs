﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static BestHealtStrategies.Models.ValueObjects.ValueObjects;

namespace BestHealtStrategies.Models
{
    public class ProgressHistory
    {
        public ProgressHistory() { }

        public ProgressHistory(
            int iD, 
            DateTime date, 
            int weight, 
            ActivityLevel activity, 
            double bmi, 
            double height, 
            int age, 
            User user,
            string userId)
        {
            Id = iD;
            Date = date;
            Weight = weight;
            Activity = activity;
            Bmi = bmi;
            Height = height;
            Age = age;
            User = user;
            UserId = userId;
        }

        [Key]
        public int Id { get; set; }
        [Required, DataType(DataType.DateTime)]
        public DateTime Date { get; set; }
        [Required]
        public int Weight { get; set; }
        [Required, EnumDataType(typeof(ActivityLevel))]
        public ActivityLevel Activity { get; set; }
        [Required]
        public double Bmi { get; set; }
        [Required]
        public double Height { get; set; }
        [Required]
        public int Age { get; set; }
        public User User { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
    }
}
