using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Salon.Models
{
  public class Stylists
  {
    public Stylists()
    {
      this.Clients = new HashSet<Clients>();
    }
    [Key]
    public int StylistId { get; set; }
    public string Name { get; set; }
    public string HairStyles { get; set; }
    public int Age { get; set; }
    public virtual ICollection<Clients> Clients { get; set; }
  }
}