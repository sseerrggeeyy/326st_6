using Contract.core;
using System.ServiceModel;

namespace lab2
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IEmployeeService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IEmployeeService : IEmployeeControl
    {
    }
}
