﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab2CLient.EmpServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmpServiceReference.IEmployeeService")]
    public interface IEmployeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlOf_EmployeeDTO/read", ReplyAction="http://tempuri.org/IControlOf_EmployeeDTO/readResponse")]
        Contract.DTO.EmployeeDTO[] read();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlOf_EmployeeDTO/read", ReplyAction="http://tempuri.org/IControlOf_EmployeeDTO/readResponse")]
        System.Threading.Tasks.Task<Contract.DTO.EmployeeDTO[]> readAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlOf_EmployeeDTO/readById", ReplyAction="http://tempuri.org/IControlOf_EmployeeDTO/readByIdResponse")]
        Contract.DTO.EmployeeDTO readById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlOf_EmployeeDTO/readById", ReplyAction="http://tempuri.org/IControlOf_EmployeeDTO/readByIdResponse")]
        System.Threading.Tasks.Task<Contract.DTO.EmployeeDTO> readByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlOf_EmployeeDTO/create", ReplyAction="http://tempuri.org/IControlOf_EmployeeDTO/createResponse")]
        void create(Contract.DTO.EmployeeDTO entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlOf_EmployeeDTO/create", ReplyAction="http://tempuri.org/IControlOf_EmployeeDTO/createResponse")]
        System.Threading.Tasks.Task createAsync(Contract.DTO.EmployeeDTO entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlOf_EmployeeDTO/update", ReplyAction="http://tempuri.org/IControlOf_EmployeeDTO/updateResponse")]
        void update(Contract.DTO.EmployeeDTO entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlOf_EmployeeDTO/update", ReplyAction="http://tempuri.org/IControlOf_EmployeeDTO/updateResponse")]
        System.Threading.Tasks.Task updateAsync(Contract.DTO.EmployeeDTO entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlOf_EmployeeDTO/deleteById", ReplyAction="http://tempuri.org/IControlOf_EmployeeDTO/deleteByIdResponse")]
        void deleteById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlOf_EmployeeDTO/deleteById", ReplyAction="http://tempuri.org/IControlOf_EmployeeDTO/deleteByIdResponse")]
        System.Threading.Tasks.Task deleteByIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServiceChannel : Lab2CLient.EmpServiceReference.IEmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<Lab2CLient.EmpServiceReference.IEmployeeService>, Lab2CLient.EmpServiceReference.IEmployeeService {
        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Contract.DTO.EmployeeDTO[] read() {
            return base.Channel.read();
        }
        
        public System.Threading.Tasks.Task<Contract.DTO.EmployeeDTO[]> readAsync() {
            return base.Channel.readAsync();
        }
        
        public Contract.DTO.EmployeeDTO readById(int id) {
            return base.Channel.readById(id);
        }
        
        public System.Threading.Tasks.Task<Contract.DTO.EmployeeDTO> readByIdAsync(int id) {
            return base.Channel.readByIdAsync(id);
        }
        
        public void create(Contract.DTO.EmployeeDTO entity) {
            base.Channel.create(entity);
        }
        
        public System.Threading.Tasks.Task createAsync(Contract.DTO.EmployeeDTO entity) {
            return base.Channel.createAsync(entity);
        }
        
        public void update(Contract.DTO.EmployeeDTO entity) {
            base.Channel.update(entity);
        }
        
        public System.Threading.Tasks.Task updateAsync(Contract.DTO.EmployeeDTO entity) {
            return base.Channel.updateAsync(entity);
        }
        
        public void deleteById(int id) {
            base.Channel.deleteById(id);
        }
        
        public System.Threading.Tasks.Task deleteByIdAsync(int id) {
            return base.Channel.deleteByIdAsync(id);
        }
    }
}
