﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.225
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFpart.RAPService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User_RAP", Namespace="http://schemas.datacontract.org/2004/07/WCFpart")]
    [System.SerializableAttribute()]
    public partial class User_RAP : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RAP_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RAP_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal RAP_PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WFpart.RAPService.User_WorkRAP User_WorkRAPField;
        
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
        public int RAP_ID {
            get {
                return this.RAP_IDField;
            }
            set {
                if ((this.RAP_IDField.Equals(value) != true)) {
                    this.RAP_IDField = value;
                    this.RaisePropertyChanged("RAP_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RAP_Name {
            get {
                return this.RAP_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.RAP_NameField, value) != true)) {
                    this.RAP_NameField = value;
                    this.RaisePropertyChanged("RAP_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal RAP_Price {
            get {
                return this.RAP_PriceField;
            }
            set {
                if ((this.RAP_PriceField.Equals(value) != true)) {
                    this.RAP_PriceField = value;
                    this.RaisePropertyChanged("RAP_Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public WFpart.RAPService.User_WorkRAP User_WorkRAP {
            get {
                return this.User_WorkRAPField;
            }
            set {
                if ((object.ReferenceEquals(this.User_WorkRAPField, value) != true)) {
                    this.User_WorkRAPField = value;
                    this.RaisePropertyChanged("User_WorkRAP");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RAPService.IRAP")]
    public interface IRAP {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRAP/AddRAP", ReplyAction="http://tempuri.org/IRAP/AddRAPResponse")]
        bool AddRAP(WFpart.RAPService.User_RAP RAP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRAP/DeleteRAP", ReplyAction="http://tempuri.org/IRAP/DeleteRAPResponse")]
        bool DeleteRAP(int RAPID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRAP/UpdateRAP", ReplyAction="http://tempuri.org/IRAP/UpdateRAPResponse")]
        bool UpdateRAP(WFpart.RAPService.User_RAP TempRAP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRAP/SelectRAP_ID", ReplyAction="http://tempuri.org/IRAP/SelectRAP_IDResponse")]
        WFpart.RAPService.User_RAP SelectRAP_ID(int RAPID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRAP/SelectAllRAPs", ReplyAction="http://tempuri.org/IRAP/SelectAllRAPsResponse")]
        WFpart.RAPService.User_RAP[] SelectAllRAPs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRAP/SelectRAPDIY_Func", ReplyAction="http://tempuri.org/IRAP/SelectRAPDIY_FuncResponse")]
        WFpart.RAPService.User_RAP[] SelectRAPDIY_Func(System.Func<WFpart.RAPService.User_RAP, bool> where);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRAP/SelectRAPDIY_Field", ReplyAction="http://tempuri.org/IRAP/SelectRAPDIY_FieldResponse")]
        WFpart.RAPService.User_RAP[] SelectRAPDIY_Field(System.Func<WFpart.RAPService.User_RAP, bool> where, System.Func<WFpart.RAPService.User_RAP, WFpart.RAPService.User_RAP> select);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRAPChannel : WFpart.RAPService.IRAP, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RAPClient : System.ServiceModel.ClientBase<WFpart.RAPService.IRAP>, WFpart.RAPService.IRAP {
        
        public RAPClient() {
        }
        
        public RAPClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RAPClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RAPClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RAPClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddRAP(WFpart.RAPService.User_RAP RAP) {
            return base.Channel.AddRAP(RAP);
        }
        
        public bool DeleteRAP(int RAPID) {
            return base.Channel.DeleteRAP(RAPID);
        }
        
        public bool UpdateRAP(WFpart.RAPService.User_RAP TempRAP) {
            return base.Channel.UpdateRAP(TempRAP);
        }
        
        public WFpart.RAPService.User_RAP SelectRAP_ID(int RAPID) {
            return base.Channel.SelectRAP_ID(RAPID);
        }
        
        public WFpart.RAPService.User_RAP[] SelectAllRAPs() {
            return base.Channel.SelectAllRAPs();
        }
        
        public WFpart.RAPService.User_RAP[] SelectRAPDIY_Func(System.Func<WFpart.RAPService.User_RAP, bool> where) {
            return base.Channel.SelectRAPDIY_Func(where);
        }
        
        public WFpart.RAPService.User_RAP[] SelectRAPDIY_Field(System.Func<WFpart.RAPService.User_RAP, bool> where, System.Func<WFpart.RAPService.User_RAP, WFpart.RAPService.User_RAP> select) {
            return base.Channel.SelectRAPDIY_Field(where, select);
        }
    }
}
