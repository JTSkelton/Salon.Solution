using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Salon.Models
{
  public class Client
  {
    public Client()
        {
            this.JoinEntities = new HashSet<StylistClients>();
        }

    [Key]
    public int ClientId { get; set; }
    public string Name { get; set; }
    public int StylistId { get; set; }
    public virtual ICollection<StylistClients> JoinEntities { get;}
    
  }
}