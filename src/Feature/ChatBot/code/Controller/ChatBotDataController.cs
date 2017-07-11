using Sitecore.Demo.Group.Feature.ChatBot.Models;
using Sitecore.Services.Core;
using Sitecore.Services.Infrastructure.Sitecore.Services;

namespace Sitecore.Demo.Group.Feature.ChatBot.Controller
{
  [ServicesController("chatbot.chatbotdata")]
  public class ChatBotDataController : EntityService<PersonModel>
  {
    public ChatBotDataController(IRepository<PersonModel> repository)
    : base(repository)
    {
    }

    public ChatBotDataController()
    : this(new ChatBotDataRepository())
    {
    }

  }
}