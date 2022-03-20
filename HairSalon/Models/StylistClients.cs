using System.ComponentModel.DataAnnotations;

namespace Salon.Models
{
  public class StylistClients
    {
        [Key]      
        public int StylistClientId { get; set; }
        public int ClientId { get; set; }
        public int StylistId { get; set; }
        public virtual Clients Clients { get; set; }
        public virtual Stylists Stylists { get; set; }
    }
}