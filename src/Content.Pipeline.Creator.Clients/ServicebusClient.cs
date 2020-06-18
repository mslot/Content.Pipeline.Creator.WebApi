using Content.Pipeline.Creator.Clients.Interfaces;
using Content.Pipeline.Creator.Core;
using Microsoft.Azure.ServiceBus;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Content.Pipeline.Creator.Clients
{
    public class ServicebusClient : IMessagingClient
    {
        private readonly ServicebusOptions _options;
        private readonly TopicClient _topicClient;

        public ServicebusClient(ServicebusOptions options)
        {
            _options = options;
            _topicClient = new TopicClient(_options.ConnectionString, entityPath: options.TopicName);
        }
        public async Task SendMessageAsync<T>(T obj)
        {
            string json = JsonSerializer.Serialize(obj);
            Message message = new Message(Encoding.UTF8.GetBytes(json));
            await _topicClient.SendAsync(message);
        }
    }
}
