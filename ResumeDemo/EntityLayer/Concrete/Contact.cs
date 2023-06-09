using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class Contact
{
    [Key]
    public int ContactId { get; set; }
    public string ContactType { get; set; }
    public string ContactLink { get; set; }
    public bool ContactStatus { get; set; }

    public int AdminId { get; set; }
    public Admin Admin { get; set; }
}