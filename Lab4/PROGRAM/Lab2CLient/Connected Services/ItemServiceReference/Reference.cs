﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab2CLient.ItemServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ItemServiceReference.IItemService")]
    public interface IItemService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlOf_ItemDTO/read", ReplyAction="http://tempuri.org/IControlOf_ItemDTO/readResponse")]
        Contract.DTO.ItemDTO[] read();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlOf_ItemDTO/read", ReplyAction="http://tempuri.org/IControlOf_ItemDTO/readResponse")]
        System.Threading.Tasks.Task<Contract.DTO.ItemDTO[]> readAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlOf_ItemDTO/readById", ReplyAction="http://tempuri.org/IControlOf_ItemDTO/readByIdResponse")]
        Contract.DTO.ItemDTO readById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlOf_ItemDTO/readById", ReplyAction="http://tempuri.org/IControlOf_ItemDTO/readByIdResponse")]
        System.Threading.Tasks.Task<Contract.DTO.ItemDTO> readByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlOf_ItemDTO/create", ReplyAction="http://tempuri.org/IControlOf_ItemDTO/createResponse")]
        void create(Contract.DTO.ItemDTO entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlOf_ItemDTO/create", ReplyAction="http://tempuri.org/IControlOf_ItemDTO/createResponse")]
        System.Threading.Tasks.Task createAsync(Contract.DTO.ItemDTO entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlOf_ItemDTO/update", ReplyAction="http://tempuri.org/IControlOf_ItemDTO/updateResponse")]
        void update(Contract.DTO.ItemDTO entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlOf_ItemDTO/update", ReplyAction="http://tempuri.org/IControlOf_ItemDTO/updateResponse")]
        System.Threading.Tasks.Task updateAsync(Contract.DTO.ItemDTO entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlOf_ItemDTO/deleteById", ReplyAction="http://tempuri.org/IControlOf_ItemDTO/deleteByIdResponse")]
        void deleteById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlOf_ItemDTO/deleteById", ReplyAction="http://tempuri.org/IControlOf_ItemDTO/deleteByIdResponse")]
        System.Threading.Tasks.Task deleteByIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IItemServiceChannel : Lab2CLient.ItemServiceReference.IItemService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ItemServiceClient : System.ServiceModel.ClientBase<Lab2CLient.ItemServiceReference.IItemService>, Lab2CLient.ItemServiceReference.IItemService {
        
        public ItemServiceClient() {
        }
        
        public ItemServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ItemServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ItemServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ItemServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Contract.DTO.ItemDTO[] read() {
            return base.Channel.read();
        }
        
        public System.Threading.Tasks.Task<Contract.DTO.ItemDTO[]> readAsync() {
            return base.Channel.readAsync();
        }
        
        public Contract.DTO.ItemDTO readById(int id) {
            return base.Channel.readById(id);
        }
        
        public System.Threading.Tasks.Task<Contract.DTO.ItemDTO> readByIdAsync(int id) {
            return base.Channel.readByIdAsync(id);
        }
        
        public void create(Contract.DTO.ItemDTO entity) {
            base.Channel.create(entity);
        }
        
        public System.Threading.Tasks.Task createAsync(Contract.DTO.ItemDTO entity) {
            return base.Channel.createAsync(entity);
        }
        
        public void update(Contract.DTO.ItemDTO entity) {
            base.Channel.update(entity);
        }
        
        public System.Threading.Tasks.Task updateAsync(Contract.DTO.ItemDTO entity) {
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