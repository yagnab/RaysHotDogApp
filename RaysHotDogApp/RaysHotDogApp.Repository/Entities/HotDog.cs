namespace RaysHotDogApp.Repository.Entities
{
    public class HotDog
    {
        //attributes
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
        public HotDogGroup Group { get; set; }
    }
}
