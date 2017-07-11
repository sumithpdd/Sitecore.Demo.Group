using System;
using System.ComponentModel.DataAnnotations;

namespace Sitecore.Demo.Group.Feature.ChatBot.Models
{
  public class PersonModel : Sitecore.Services.Core.Model.EntityIdentity
  {  
    public string itemId { get; set; }

    [Required]
    public string Title { get; set; }
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    public string Summary { get; set; }
    public string Picture { get; set; }
    
    public DateTime Date { get; set; }
  }
}