using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Salon.Models
{
  public class Clients
  {
    [Key]
    public int ClientId { get; set; }
    public string Name { get; set; }
    public int StylistId { get; set; }
    public virtual Stylists Stylists { get; set; }
    
  }
}