using System.Collections.Generic;

namespace Salon.Models
{
  public class Clients
  {
    public Clients()
    {
      this.Stylists = new HashSet<Stylists>();
    }
    public int ClientId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Stylists> Stylists { get; set; }
  }
}