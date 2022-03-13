using System.Collections.Generic;

namespace Salon.Models
{
  public class Stylists
  {
    public int StylistId { get; set; }
    public string Name { get; set; }
    public string HairStyles { get; set; }
    public int Age { get; set; }
    public int ClientId { get; set; }
    public virtual Clients Clients { get; set; }
  }
}