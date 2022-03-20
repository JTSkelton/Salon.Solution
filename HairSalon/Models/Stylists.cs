using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Salon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.JoinEntities = new HashSet<StylistClients>();
    }
    [Key]
    public int StylistId { get; set; }
    public string StylistName { get; set; }
    public string HairStyles { get; set; }
    public int Age { get; set; }
    public virtual ICollection<StylistClients> JoinEntities { get; set; }
  }
}