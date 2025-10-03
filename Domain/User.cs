namespace Сsharp_Clicker.Domain
{
    public class ApplicationUser
    {
        public Guid Id { get; set; }
        private string UserName { get; set; }
        private string Password { get; set; }
        private long CurrentScore { get; set; }
        private long RecordScore {  get; set; }

        public ICollection<UserBoost> UserBoosts { get; set; }
    }
}
