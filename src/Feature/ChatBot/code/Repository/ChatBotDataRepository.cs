using System;
using System.Linq;
using Sitecore.Services.Core;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Demo.Group.Feature.ChatBot.Models;
using System.Collections.Generic;

namespace Sitecore.Demo.Group.Feature.ChatBot.Controller
{
  internal class ChatBotDataRepository : IRepository<PersonModel>
  {
    public void Add(PersonModel entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(PersonModel entity)
    {
      throw new NotImplementedException();
    }

    public bool Exists(PersonModel entity)
    {
      throw new NotImplementedException();
    }
     
    public IQueryable<PersonModel> GetAll()
    {
      var newsItems = new List<PersonModel>();

      //TODO: Replace with search
      var newsFolder = Sitecore.Data.Database.GetDatabase("master").GetItem(new ID("{E8EB840B-4977-42CC-B389-3816BDE6F9CE}"));

      foreach (Item item in newsFolder.Children)
      {
        var person = new PersonModel();

        person.Name = item["Name"];
        person.Title = item["Title"];
        person.Summary = item["Summary"];
        person.Description = item["Description"];
        Data.Fields.FileField fileField = item.Fields["Picture"];

        string url = Sitecore.Resources.Media.MediaManager.GetMediaUrl(fileField.MediaItem);
        person.Picture = url;
        person.itemId = item.ID.ToString();
        person.Id = item.ID.ToString();
        person.Url = item.Paths.ContentPath;
        newsItems.Add(person);
      }

      return newsItems.AsQueryable(); ;
    }
    

    public void Update(PersonModel entity)
    {
      throw new NotImplementedException();
    }

    PersonModel IRepository<PersonModel>.FindById(string id)
    {
      throw new NotImplementedException();
    }
  }
}