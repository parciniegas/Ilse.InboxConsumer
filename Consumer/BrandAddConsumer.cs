using Ilse.Bus.Subscriber;
using Ilse.InboxConsumer.Domain;

namespace Ilse.InboxConsumer.Consumer;

public class BrandAddConsumer : BaseConsumer<InboxEvent>
{
    public BrandAddConsumer(IBusSubscriber busSubscriber) : base(busSubscriber)
    {
        Subscribe("eShop.Catalog.BrandAdded", GetType().Name);
    }

    public override Task<bool> Consume(InboxEvent message)
    {
        Console.WriteLine(message.ToString());
        return Task.FromResult(true);
    }
}
