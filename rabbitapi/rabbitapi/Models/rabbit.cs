using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rabbitapi.Models
{
    public class Rabbit
    {
        public enum FurColors
        {
            White,
            Brown,
            Black,
            Grey
        }
        public enum EyeColors
        {
            Blue,
            Black,
            Red
        }
        public enum Genders
        {
            Male,
            Female
        }
        
        [Required]
        public String Name { get; set; }

        [Required]
        public FurColors FurColor { get; set; }

        [Required]
        public EyeColors EyeColor { get; set; }

        [Required]
        public Genders Gender { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public int Id { get; set; }

       
        public Rabbit(String name, FurColors furColor, EyeColors eyeColor, Genders gender, int age, int id)
        {
            Name = name;
            FurColor = furColor;
            EyeColor = eyeColor;
            Gender = gender;
            Age = age;
            Id = id;
        }
        public void Move()
        {
            Console.WriteLine("The rabbit is moving left and right like crazy.");
        }
        public void Sleep()
        {
            Console.WriteLine("The rabbit is sleeping like a rock.");
        }
        public void Eat()
        {
            Console.WriteLine("The rabbit is eating some food");
        }
     

    }
}
