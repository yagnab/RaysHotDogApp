using System.Collections.Generic;

namespace RaysHotDogApp.Repository.Entities
{
    public class HotDogGroup
    {
        public string GroupName { get; set; }
        public int HotDogGroupId { get; set; }
        public string ImagePath { get; set; }
        public List<HotDog> HotDogs { get; set; }
    }
}
