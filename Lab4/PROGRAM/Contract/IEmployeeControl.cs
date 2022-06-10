using Contract.DTO;
using System.ServiceModel;

namespace Contract.core
{
    [ServiceContract]
    public interface IEmployeeControl : IControl<EmployeeDTO>
    {

    }
}
