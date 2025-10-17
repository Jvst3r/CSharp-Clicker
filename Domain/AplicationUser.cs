using Microsoft.AspNetCore.Identity;
using Сsharp_Clicker.Domain;

namespace CSharpClicker.Domain;

public class ApplicationUser : IdentityUser<Guid>
{
    public long CurrentScore { get; set; }

    public long RecordScore { get; set; }

    public ICollection<UserBoost> UserBoosts { get; set; }
}