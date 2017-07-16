using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace RaysHotDogApp.WebService.Models
{
    [DataContract(IsReference=true)]
    public class HotDogGroup
    {
        [DataMember]
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int HotDogGroupId { get; set; }
        [DataMember]
        public string GroupName { get; set; }
        [DataMember]
        public string ImagePath { get; set; }
        //Navigation property
        [DataMember]
        public List<HotDog> HotDogs { get; set; }
    }
}