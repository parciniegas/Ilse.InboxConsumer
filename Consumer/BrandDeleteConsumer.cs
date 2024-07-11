using Ilse.Bus.Subscriber;
using Ilse.InboxConsumer.Domain;

namespace Ilse.InboxConsumer.Consumer;

public class BrandDeleteConsumer : BaseConsumer<InboxEvent>
{
    public BrandDeleteConsumer(IBusSubscriber busSubscriber) : base(busSubscriber)
    {
        Subscribe("eShop.Catalog.BrandDeleted", GetType().Name);
    }

    public override Task<bool> Consume(InboxEvent message)
    {
        Console.WriteLine(message.ToString());
        return Task.FromResult(true);
    }
}
