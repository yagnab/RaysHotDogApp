using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RaysHotDogApp.WebService.Models
{
    public class HotDogGroup
    {
        [Key]
        public string GroupName { get; set; }
        public int HotDogGroupId { get; set; }
        public string ImagePath { get; set; }

        //Navigation property
        public List<HotDog> HotDogs { get; set; }
    }
}