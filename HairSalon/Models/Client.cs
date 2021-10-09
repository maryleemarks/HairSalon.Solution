using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public Client()
    {
      this.Stylists = new HashSet<Stylist>();
    }

    public int ClientId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Restaurant> Stylists { get; set; }
  }
}