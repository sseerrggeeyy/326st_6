using Contract.DTO;
using System.ServiceModel;

namespace Contract.core
{
    [ServiceContract]
    public interface IPartControl : IControl<PartDTO>
    {

    }
}
