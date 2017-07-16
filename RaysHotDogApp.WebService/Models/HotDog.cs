using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace RaysHotDogApp.WebService.Models
{
    //navigation property becomes reference type
    [DataContract(IsReference=true)]
    public class HotDog
    {
        //attributes
        [Key]
        [DataMember]
        public int HotDogId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string ShortDescription { get; set; }
        [DataMember]
        public string LongDescription { get; set; }
        [DataMember]
        public string ImagePath { get; set; }
        [DataMember]
        public float Price { get; set; }
        [DataMember]
        public bool Avaliable { get; set; }
        [DataMember]
        public int PrepTime { get; set; }
        [DataMember]
        public List<string> Ingredients { get; set; }
        [DataMember]
        public bool IsFavourite { get; set; }
        [DataMember]
        public int HotDogGroupId { get; set; } //Fk
        [DataMember]
        public HotDogGroup Group { get; set; } //Navigation property
    }
}