﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.225
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCpart.CheckoutService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Car_Checkout", Namespace="http://schemas.datacontract.org/2004/07/WCFpart")]
    [System.SerializableAttribute()]
    public partial class Car_Checkout : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Checkout_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Checkout_OrderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.Guid> Checkout_UserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Checkout_TimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Checkout_KMField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool Checkout_MarkField;
        
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
        public int Checkout_ID {
            get {
                return this.Checkout_IDField;
            }
            set {
                if ((this.Checkout_IDField.Equals(value) != true)) {
                    this.Checkout_IDField = value;
                    this.RaisePropertyChanged("Checkout_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Checkout_Order {
            get {
                return this.Checkout_OrderField;
            }
            set {
                if ((this.Checkout_OrderField.Equals(value) != true)) {
                    this.Checkout_OrderField = value;
                    this.RaisePropertyChanged("Checkout_Order");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.Guid> Checkout_User {
            get {
                return this.Checkout_UserField;
            }
            set {
                if ((this.Checkout_UserField.Equals(value) != true)) {
                    this.Checkout_UserField = value;
                    this.RaisePropertyChanged("Checkout_User");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public System.DateTime Checkout_Time {
            get {
                return this.Checkout_TimeField;
            }
            set {
                if ((this.Checkout_TimeField.Equals(value) != true)) {
                    this.Checkout_TimeField = value;
                    this.RaisePropertyChanged("Checkout_Time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int Checkout_KM {
            get {
                return this.Checkout_KMField;
            }
            set {
                if ((this.Checkout_KMField.Equals(value) != true)) {
                    this.Checkout_KMField = value;
                    this.RaisePropertyChanged("Checkout_KM");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public bool Checkout_Mark {
            get {
                return this.Checkout_MarkField;
            }
            set {
                if ((this.Checkout_MarkField.Equals(value) != true)) {
                    this.Checkout_MarkField = value;
                    this.RaisePropertyChanged("Checkout_Mark");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CheckoutService.ICheckout")]
    public interface ICheckout {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICheckout/AddCheckout", ReplyAction="http://tempuri.org/ICheckout/AddCheckoutResponse")]
        bool AddCheckout(MVCpart.CheckoutService.Car_Checkout Checkout);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICheckout/DeleteCheckout", ReplyAction="http://tempuri.org/ICheckout/DeleteCheckoutResponse")]
        bool DeleteCheckout(int CheckoutID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICheckout/UpdateCheckout", ReplyAction="http://tempuri.org/ICheckout/UpdateCheckoutResponse")]
        bool UpdateCheckout(MVCpart.CheckoutService.Car_Checkout TempCheckout);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICheckout/SelectCheckout_ID", ReplyAction="http://tempuri.org/ICheckout/SelectCheckout_IDResponse")]
        MVCpart.CheckoutService.Car_Checkout SelectCheckout_ID(int CheckoutID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICheckout/SelectAllCheckouts", ReplyAction="http://tempuri.org/ICheckout/SelectAllCheckoutsResponse")]
        MVCpart.CheckoutService.Car_Checkout[] SelectAllCheckouts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICheckout/SelectCheckoutDIY_Func", ReplyAction="http://tempuri.org/ICheckout/SelectCheckoutDIY_FuncResponse")]
        MVCpart.CheckoutService.Car_Checkout[] SelectCheckoutDIY_Func(System.Func<MVCpart.CheckoutService.Car_Checkout, bool> where);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICheckout/SelectCheckoutDIY_Field", ReplyAction="http://tempuri.org/ICheckout/SelectCheckoutDIY_FieldResponse")]
        MVCpart.CheckoutService.Car_Checkout[] SelectCheckoutDIY_Field(System.Func<MVCpart.CheckoutService.Car_Checkout, bool> where, System.Func<MVCpart.CheckoutService.Car_Checkout, MVCpart.CheckoutService.Car_Checkout> select);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICheckoutChannel : MVCpart.CheckoutService.ICheckout, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CheckoutClient : System.ServiceModel.ClientBase<MVCpart.CheckoutService.ICheckout>, MVCpart.CheckoutService.ICheckout {
        
        public CheckoutClient() {
        }
        
        public CheckoutClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CheckoutClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CheckoutClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CheckoutClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddCheckout(MVCpart.CheckoutService.Car_Checkout Checkout) {
            return base.Channel.AddCheckout(Checkout);
        }
        
        public bool DeleteCheckout(int CheckoutID) {
            return base.Channel.DeleteCheckout(CheckoutID);
        }
        
        public bool UpdateCheckout(MVCpart.CheckoutService.Car_Checkout TempCheckout) {
            return base.Channel.UpdateCheckout(TempCheckout);
        }
        
        public MVCpart.CheckoutService.Car_Checkout SelectCheckout_ID(int CheckoutID) {
            return base.Channel.SelectCheckout_ID(CheckoutID);
        }
        
        public MVCpart.CheckoutService.Car_Checkout[] SelectAllCheckouts() {
            return base.Channel.SelectAllCheckouts();
        }
        
        public MVCpart.CheckoutService.Car_Checkout[] SelectCheckoutDIY_Func(System.Func<MVCpart.CheckoutService.Car_Checkout, bool> where) {
            return base.Channel.SelectCheckoutDIY_Func(where);
        }
        
        public MVCpart.CheckoutService.Car_Checkout[] SelectCheckoutDIY_Field(System.Func<MVCpart.CheckoutService.Car_Checkout, bool> where, System.Func<MVCpart.CheckoutService.Car_Checkout, MVCpart.CheckoutService.Car_Checkout> select) {
            return base.Channel.SelectCheckoutDIY_Field(where, select);
        }
    }
}