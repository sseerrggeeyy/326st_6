using Contract.DTO;
using System.Collections.Generic;
using System.ServiceModel;

namespace Contract.core
{
    [ServiceContract]
    public interface IOrderControl : IControl<OrderDTO>
    {
        
    }
}
