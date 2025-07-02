using FastTech.Domain.Constants;
using FastTech.Application.Interfaces;
using FastTech.Domain.Settings;
using Microsoft.Extensions.Options;

namespace FastTech.Api.Robots.RabbitMQ
{
    public class ItemCardapioConsumerService : BaseRabbitMQConsumerService
    {
        public override string Queue => "FastTech.ItemCardapio";

        public override string RoutingKey => "ItemCardapio.*";

        public ItemCardapioConsumerService(IServiceProvider serviceProvider, IOptions<FastTechSettings> settings,  ILogger<ItemCardapioConsumerService> logger)
            : base(serviceProvider, settings, logger)
        {
            ServiceMaps.Add(AppConstants.Routes.RabbitMQ.ItemCardapioInsert, sp => serviceProvider.GetService<IItemCardapioApplicationService>());
            ServiceMaps.Add(AppConstants.Routes.RabbitMQ.ItemCardapioUpdate, sp => serviceProvider.GetService<IItemCardapioApplicationService>());
        }
    }
}