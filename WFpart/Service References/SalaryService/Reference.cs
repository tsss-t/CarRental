﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.225
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFpart.SalaryService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User_Salary", Namespace="http://schemas.datacontract.org/2004/07/WCFpart")]
    [System.SerializableAttribute()]
    public partial class User_Salary : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Salary_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal Salary_PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid Salary_RoleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Salary_ID {
            get {
                return this.Salary_IDField;
            }
            set {
                if ((this.Salary_IDField.Equals(value) != true)) {
                    this.Salary_IDField = value;
                    this.RaisePropertyChanged("Salary_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Salary_Price {
            get {
                return this.Salary_PriceField;
            }
            set {
                if ((this.Salary_PriceField.Equals(value) != true)) {
                    this.Salary_PriceField = value;
                    this.RaisePropertyChanged("Salary_Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Salary_Role {
            get {
                return this.Salary_RoleField;
            }
            set {
                if ((this.Salary_RoleField.Equals(value) != true)) {
                    this.Salary_RoleField = value;
                    this.RaisePropertyChanged("Salary_Role");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SalaryService.ISalary")]
    public interface ISalary {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalary/AddSalary", ReplyAction="http://tempuri.org/ISalary/AddSalaryResponse")]
        bool AddSalary(WFpart.SalaryService.User_Salary Salary);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalary/DeleteSalary", ReplyAction="http://tempuri.org/ISalary/DeleteSalaryResponse")]
        bool DeleteSalary(int SalaryID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalary/UpdateSalary", ReplyAction="http://tempuri.org/ISalary/UpdateSalaryResponse")]
        bool UpdateSalary(WFpart.SalaryService.User_Salary TempSalary);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalary/SelectSalary_ID", ReplyAction="http://tempuri.org/ISalary/SelectSalary_IDResponse")]
        WFpart.SalaryService.User_Salary SelectSalary_ID(int SalaryID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalary/SelectAllSalarys", ReplyAction="http://tempuri.org/ISalary/SelectAllSalarysResponse")]
        WFpart.SalaryService.User_Salary[] SelectAllSalarys();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalary/SelectSalaryDIY_Func", ReplyAction="http://tempuri.org/ISalary/SelectSalaryDIY_FuncResponse")]
        WFpart.SalaryService.User_Salary[] SelectSalaryDIY_Func(System.Func<WFpart.SalaryService.User_Salary, bool> where);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalary/SelectSalaryDIY_Field", ReplyAction="http://tempuri.org/ISalary/SelectSalaryDIY_FieldResponse")]
        WFpart.SalaryService.User_Salary[] SelectSalaryDIY_Field(System.Func<WFpart.SalaryService.User_Salary, bool> where, System.Func<WFpart.SalaryService.User_Salary, WFpart.SalaryService.User_Salary> select);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISalaryChannel : WFpart.SalaryService.ISalary, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SalaryClient : System.ServiceModel.ClientBase<WFpart.SalaryService.ISalary>, WFpart.SalaryService.ISalary {
        
        public SalaryClient() {
        }
        
        public SalaryClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SalaryClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SalaryClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SalaryClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddSalary(WFpart.SalaryService.User_Salary Salary) {
            return base.Channel.AddSalary(Salary);
        }
        
        public bool DeleteSalary(int SalaryID) {
            return base.Channel.DeleteSalary(SalaryID);
        }
        
        public bool UpdateSalary(WFpart.SalaryService.User_Salary TempSalary) {
            return base.Channel.UpdateSalary(TempSalary);
        }
        
        public WFpart.SalaryService.User_Salary SelectSalary_ID(int SalaryID) {
            return base.Channel.SelectSalary_ID(SalaryID);
        }
        
        public WFpart.SalaryService.User_Salary[] SelectAllSalarys() {
            return base.Channel.SelectAllSalarys();
        }
        
        public WFpart.SalaryService.User_Salary[] SelectSalaryDIY_Func(System.Func<WFpart.SalaryService.User_Salary, bool> where) {
            return base.Channel.SelectSalaryDIY_Func(where);
        }
        
        public WFpart.SalaryService.User_Salary[] SelectSalaryDIY_Field(System.Func<WFpart.SalaryService.User_Salary, bool> where, System.Func<WFpart.SalaryService.User_Salary, WFpart.SalaryService.User_Salary> select) {
            return base.Channel.SelectSalaryDIY_Field(where, select);
        }
    }
}
