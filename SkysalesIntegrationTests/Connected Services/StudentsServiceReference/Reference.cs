﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SkysalesIntegrationTests.StudentsServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StudentsServiceReference.IStudentWebService")]
    public interface IStudentWebService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentWebService/Add", ReplyAction="http://tempuri.org/IStudentWebService/AddResponse")]
        SkySales.Common.Models.Student Add(SkySales.Common.Models.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentWebService/Add", ReplyAction="http://tempuri.org/IStudentWebService/AddResponse")]
        System.Threading.Tasks.Task<SkySales.Common.Models.Student> AddAsync(SkySales.Common.Models.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentWebService/GetById", ReplyAction="http://tempuri.org/IStudentWebService/GetByIdResponse")]
        SkySales.Common.Models.Student GetById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentWebService/GetById", ReplyAction="http://tempuri.org/IStudentWebService/GetByIdResponse")]
        System.Threading.Tasks.Task<SkySales.Common.Models.Student> GetByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentWebService/GetAll", ReplyAction="http://tempuri.org/IStudentWebService/GetAllResponse")]
        System.Collections.Generic.List<SkySales.Common.Models.Student> GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentWebService/GetAll", ReplyAction="http://tempuri.org/IStudentWebService/GetAllResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<SkySales.Common.Models.Student>> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentWebService/Update", ReplyAction="http://tempuri.org/IStudentWebService/UpdateResponse")]
        SkySales.Common.Models.Student Update(SkySales.Common.Models.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentWebService/Update", ReplyAction="http://tempuri.org/IStudentWebService/UpdateResponse")]
        System.Threading.Tasks.Task<SkySales.Common.Models.Student> UpdateAsync(SkySales.Common.Models.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentWebService/Delete", ReplyAction="http://tempuri.org/IStudentWebService/DeleteResponse")]
        SkySales.Common.Models.Student Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentWebService/Delete", ReplyAction="http://tempuri.org/IStudentWebService/DeleteResponse")]
        System.Threading.Tasks.Task<SkySales.Common.Models.Student> DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStudentWebServiceChannel : SkysalesIntegrationTests.StudentsServiceReference.IStudentWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentWebServiceClient : System.ServiceModel.ClientBase<SkysalesIntegrationTests.StudentsServiceReference.IStudentWebService>, SkysalesIntegrationTests.StudentsServiceReference.IStudentWebService {
        
        public StudentWebServiceClient() {
        }
        
        public StudentWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StudentWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SkySales.Common.Models.Student Add(SkySales.Common.Models.Student student) {
            return base.Channel.Add(student);
        }
        
        public System.Threading.Tasks.Task<SkySales.Common.Models.Student> AddAsync(SkySales.Common.Models.Student student) {
            return base.Channel.AddAsync(student);
        }
        
        public SkySales.Common.Models.Student GetById(int id) {
            return base.Channel.GetById(id);
        }
        
        public System.Threading.Tasks.Task<SkySales.Common.Models.Student> GetByIdAsync(int id) {
            return base.Channel.GetByIdAsync(id);
        }
        
        public System.Collections.Generic.List<SkySales.Common.Models.Student> GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<SkySales.Common.Models.Student>> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public SkySales.Common.Models.Student Update(SkySales.Common.Models.Student student) {
            return base.Channel.Update(student);
        }
        
        public System.Threading.Tasks.Task<SkySales.Common.Models.Student> UpdateAsync(SkySales.Common.Models.Student student) {
            return base.Channel.UpdateAsync(student);
        }
        
        public SkySales.Common.Models.Student Delete(int id) {
            return base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task<SkySales.Common.Models.Student> DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}
