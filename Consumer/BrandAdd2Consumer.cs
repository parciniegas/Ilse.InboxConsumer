using Ilse.Bus.Subscriber;
using Ilse.InboxConsumer.Domain;

namespace Ilse.InboxConsumer.Consumer;

public class BrandAdd2Consumer : BaseConsumer<InboxEvent>
{
    public BrandAdd2Consumer(IBusSubscriber busSubscriber) : base(busSubscriber)
    {
        Subscribe("eShop.Catalog.BrandAdded", GetType().Name);
    }

    public override Task<bool> Consume(InboxEvent message)
    {
        Console.WriteLine(message.ToString());
        return Task.FromResult(true);
    }
}
