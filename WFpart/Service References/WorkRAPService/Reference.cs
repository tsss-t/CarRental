﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.225
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFpart.WorkRAPService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User_WorkRAP", Namespace="http://schemas.datacontract.org/2004/07/WCFpart")]
    [System.SerializableAttribute()]
    public partial class User_WorkRAP : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WorkRAP_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid WorkRAP_UserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WorkRAP_TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime WorkRAP_TimeField;
        
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
        public int WorkRAP_ID {
            get {
                return this.WorkRAP_IDField;
            }
            set {
                if ((this.WorkRAP_IDField.Equals(value) != true)) {
                    this.WorkRAP_IDField = value;
                    this.RaisePropertyChanged("WorkRAP_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid WorkRAP_User {
            get {
                return this.WorkRAP_UserField;
            }
            set {
                if ((this.WorkRAP_UserField.Equals(value) != true)) {
                    this.WorkRAP_UserField = value;
                    this.RaisePropertyChanged("WorkRAP_User");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int WorkRAP_Type {
            get {
                return this.WorkRAP_TypeField;
            }
            set {
                if ((this.WorkRAP_TypeField.Equals(value) != true)) {
                    this.WorkRAP_TypeField = value;
                    this.RaisePropertyChanged("WorkRAP_Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public System.DateTime WorkRAP_Time {
            get {
                return this.WorkRAP_TimeField;
            }
            set {
                if ((this.WorkRAP_TimeField.Equals(value) != true)) {
                    this.WorkRAP_TimeField = value;
                    this.RaisePropertyChanged("WorkRAP_Time");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WorkRAPService.IWorkRAP")]
    public interface IWorkRAP {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkRAP/AddWorkRAP", ReplyAction="http://tempuri.org/IWorkRAP/AddWorkRAPResponse")]
        bool AddWorkRAP(WFpart.WorkRAPService.User_WorkRAP WorkRAP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkRAP/DeleteWorkRAP", ReplyAction="http://tempuri.org/IWorkRAP/DeleteWorkRAPResponse")]
        bool DeleteWorkRAP(int WorkRAPID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkRAP/UpdateWorkRAP", ReplyAction="http://tempuri.org/IWorkRAP/UpdateWorkRAPResponse")]
        bool UpdateWorkRAP(WFpart.WorkRAPService.User_WorkRAP TempWorkRAP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkRAP/SelectWorkRAP_ID", ReplyAction="http://tempuri.org/IWorkRAP/SelectWorkRAP_IDResponse")]
        WFpart.WorkRAPService.User_WorkRAP SelectWorkRAP_ID(int WorkRAPID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkRAP/SelectWorkRAP_UID", ReplyAction="http://tempuri.org/IWorkRAP/SelectWorkRAP_UIDResponse")]
        WFpart.WorkRAPService.User_WorkRAP[] SelectWorkRAP_UID(System.Guid UID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkRAP/SelectAllWorkRAPs", ReplyAction="http://tempuri.org/IWorkRAP/SelectAllWorkRAPsResponse")]
        WFpart.WorkRAPService.User_WorkRAP[] SelectAllWorkRAPs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkRAP/SelectWorkRAPDIY_Func", ReplyAction="http://tempuri.org/IWorkRAP/SelectWorkRAPDIY_FuncResponse")]
        WFpart.WorkRAPService.User_WorkRAP[] SelectWorkRAPDIY_Func(System.Func<WFpart.WorkRAPService.User_WorkRAP, bool> where);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkRAP/SelectWorkRAPDIY_Field", ReplyAction="http://tempuri.org/IWorkRAP/SelectWorkRAPDIY_FieldResponse")]
        WFpart.WorkRAPService.User_WorkRAP[] SelectWorkRAPDIY_Field(System.Func<WFpart.WorkRAPService.User_WorkRAP, bool> where, System.Func<WFpart.WorkRAPService.User_WorkRAP, WFpart.WorkRAPService.User_WorkRAP> select);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWorkRAPChannel : WFpart.WorkRAPService.IWorkRAP, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WorkRAPClient : System.ServiceModel.ClientBase<WFpart.WorkRAPService.IWorkRAP>, WFpart.WorkRAPService.IWorkRAP {
        
        public WorkRAPClient() {
        }
        
        public WorkRAPClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WorkRAPClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WorkRAPClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WorkRAPClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddWorkRAP(WFpart.WorkRAPService.User_WorkRAP WorkRAP) {
            return base.Channel.AddWorkRAP(WorkRAP);
        }
        
        public bool DeleteWorkRAP(int WorkRAPID) {
            return base.Channel.DeleteWorkRAP(WorkRAPID);
        }
        
        public bool UpdateWorkRAP(WFpart.WorkRAPService.User_WorkRAP TempWorkRAP) {
            return base.Channel.UpdateWorkRAP(TempWorkRAP);
        }
        
        public WFpart.WorkRAPService.User_WorkRAP SelectWorkRAP_ID(int WorkRAPID) {
            return base.Channel.SelectWorkRAP_ID(WorkRAPID);
        }
        
        public WFpart.WorkRAPService.User_WorkRAP[] SelectWorkRAP_UID(System.Guid UID) {
            return base.Channel.SelectWorkRAP_UID(UID);
        }
        
        public WFpart.WorkRAPService.User_WorkRAP[] SelectAllWorkRAPs() {
            return base.Channel.SelectAllWorkRAPs();
        }
        
        public WFpart.WorkRAPService.User_WorkRAP[] SelectWorkRAPDIY_Func(System.Func<WFpart.WorkRAPService.User_WorkRAP, bool> where) {
            return base.Channel.SelectWorkRAPDIY_Func(where);
        }
        
        public WFpart.WorkRAPService.User_WorkRAP[] SelectWorkRAPDIY_Field(System.Func<WFpart.WorkRAPService.User_WorkRAP, bool> where, System.Func<WFpart.WorkRAPService.User_WorkRAP, WFpart.WorkRAPService.User_WorkRAP> select) {
            return base.Channel.SelectWorkRAPDIY_Field(where, select);
        }
    }
}
