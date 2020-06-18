using System.Threading.Tasks;

namespace Content.Pipeline.Creator.Clients.Interfaces
{
    public interface IMessagingClient
    {
        Task SendMessageAsync<T>(T obj);
    }
}
