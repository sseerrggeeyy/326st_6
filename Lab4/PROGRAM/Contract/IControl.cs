using System.Collections.Generic;
using System.ServiceModel;

namespace Contract.core
{
    [ServiceContract]
    public interface IControl<T>
    {
        [OperationContract]
        List<T> read();
        [OperationContract]
        T readById(int id);
        [OperationContract]
        void create(T entity);
        [OperationContract]
        void update(T entity);
        [OperationContract]
        void deleteById(int id);
    }
}
