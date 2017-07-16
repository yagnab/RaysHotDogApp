using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RaysHotDogApp.WebService.Models
{
    public class HotDog
    {
        //attributes
        [Key]
        public int HotDogId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImagePath { get; set; }
        public float Price { get; set; }
        public bool Avaliable { get; set; }
        public int PrepTime { get; set; }
        public List<string> Ingredients { get; set; }
        public bool IsFavourite { get; set; }
        public int GroupId { get; set; } //Fk
        public HotDogGroup Group { get; set; } //Navigation property
    }
}