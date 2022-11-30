using test.Domain.Models;

namespace test.Dal.Interfaces
{
    public interface IOrderRep:IBaseRep<Order>
    {
        Order GetOrder(string Description);
    }
}
