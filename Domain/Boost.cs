namespace Сsharp_Clicker.Domain
{
    public class Boost
    {
        public int Id { get;private set; } 
        public string Title { get;private set; }
        public long Price { get; set; }

        public long Profit { get; set; }

        public bool IsAuto {  get; set; }
            
        public byte[] Image { get; set; }

    }
}
