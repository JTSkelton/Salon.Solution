using System.ComponentModel.DataAnnotations;

namespace Salon.Models
{
  public class StylistClients
    {
        [Key]      
        public int StylistClientId { get; set; }
        public int ClientId { get; set; }
        public int StylistId { get; set; }
        public virtual Client Clients { get; set; }
        public virtual Stylist Stylists { get; set; }
    }
}