
using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string First { get; set; }
    public string Last { get; set; }
    public List<Client> Clients { get; set; }
  }
}
