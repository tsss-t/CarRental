﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.225
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFpart.OrderService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Car_Order", Namespace="http://schemas.datacontract.org/2004/07/WCFpart")]
    [System.SerializableAttribute()]
    public partial class Car_Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Order_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid Order_UserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Order_ShopField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Order_VersionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Order_CountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Order_RentalTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Order_Start_TimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Order_End_TimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Order_ActionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Order_MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool Order_IsCatchField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool Order_DepositPayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Order_TimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WFpart.OrderService.Car_Checkout[] Car_CheckoutField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WFpart.OrderService.Car_Get[] Car_GetField;
        
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
        public int Order_ID {
            get {
                return this.Order_IDField;
            }
            set {
                if ((this.Order_IDField.Equals(value) != true)) {
                    this.Order_IDField = value;
                    this.RaisePropertyChanged("Order_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Order_User {
            get {
                return this.Order_UserField;
            }
            set {
                if ((this.Order_UserField.Equals(value) != true)) {
                    this.Order_UserField = value;
                    this.RaisePropertyChanged("Order_User");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int Order_Shop {
            get {
                return this.Order_ShopField;
            }
            set {
                if ((this.Order_ShopField.Equals(value) != true)) {
                    this.Order_ShopField = value;
                    this.RaisePropertyChanged("Order_Shop");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int Order_Version {
            get {
                return this.Order_VersionField;
            }
            set {
                if ((this.Order_VersionField.Equals(value) != true)) {
                    this.Order_VersionField = value;
                    this.RaisePropertyChanged("Order_Version");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int Order_Count {
            get {
                return this.Order_CountField;
            }
            set {
                if ((this.Order_CountField.Equals(value) != true)) {
                    this.Order_CountField = value;
                    this.RaisePropertyChanged("Order_Count");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int Order_RentalType {
            get {
                return this.Order_RentalTypeField;
            }
            set {
                if ((this.Order_RentalTypeField.Equals(value) != true)) {
                    this.Order_RentalTypeField = value;
                    this.RaisePropertyChanged("Order_RentalType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public System.DateTime Order_Start_Time {
            get {
                return this.Order_Start_TimeField;
            }
            set {
                if ((this.Order_Start_TimeField.Equals(value) != true)) {
                    this.Order_Start_TimeField = value;
                    this.RaisePropertyChanged("Order_Start_Time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public System.DateTime Order_End_Time {
            get {
                return this.Order_End_TimeField;
            }
            set {
                if ((this.Order_End_TimeField.Equals(value) != true)) {
                    this.Order_End_TimeField = value;
                    this.RaisePropertyChanged("Order_End_Time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public int Order_Action {
            get {
                return this.Order_ActionField;
            }
            set {
                if ((this.Order_ActionField.Equals(value) != true)) {
                    this.Order_ActionField = value;
                    this.RaisePropertyChanged("Order_Action");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=9)]
        public string Order_Message {
            get {
                return this.Order_MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.Order_MessageField, value) != true)) {
                    this.Order_MessageField = value;
                    this.RaisePropertyChanged("Order_Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=10)]
        public bool Order_IsCatch {
            get {
                return this.Order_IsCatchField;
            }
            set {
                if ((this.Order_IsCatchField.Equals(value) != true)) {
                    this.Order_IsCatchField = value;
                    this.RaisePropertyChanged("Order_IsCatch");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=11)]
        public bool Order_DepositPay {
            get {
                return this.Order_DepositPayField;
            }
            set {
                if ((this.Order_DepositPayField.Equals(value) != true)) {
                    this.Order_DepositPayField = value;
                    this.RaisePropertyChanged("Order_DepositPay");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=12)]
        public System.DateTime Order_Time {
            get {
                return this.Order_TimeField;
            }
            set {
                if ((this.Order_TimeField.Equals(value) != true)) {
                    this.Order_TimeField = value;
                    this.RaisePropertyChanged("Order_Time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=13)]
        public WFpart.OrderService.Car_Checkout[] Car_Checkout {
            get {
                return this.Car_CheckoutField;
            }
            set {
                if ((object.ReferenceEquals(this.Car_CheckoutField, value) != true)) {
                    this.Car_CheckoutField = value;
                    this.RaisePropertyChanged("Car_Checkout");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=14)]
        public WFpart.OrderService.Car_Get[] Car_Get {
            get {
                return this.Car_GetField;
            }
            set {
                if ((object.ReferenceEquals(this.Car_GetField, value) != true)) {
                    this.Car_GetField = value;
                    this.RaisePropertyChanged("Car_Get");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Car_Get", Namespace="http://schemas.datacontract.org/2004/07/WCFpart")]
    [System.SerializableAttribute()]
    public partial class Car_Get : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GetCar_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GetCar_OrderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GetCar_UserValidationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GetCar_CarNumberField;
        
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
        public int GetCar_ID {
            get {
                return this.GetCar_IDField;
            }
            set {
                if ((this.GetCar_IDField.Equals(value) != true)) {
                    this.GetCar_IDField = value;
                    this.RaisePropertyChanged("GetCar_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int GetCar_Order {
            get {
                return this.GetCar_OrderField;
            }
            set {
                if ((this.GetCar_OrderField.Equals(value) != true)) {
                    this.GetCar_OrderField = value;
                    this.RaisePropertyChanged("GetCar_Order");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GetCar_UserValidation {
            get {
                return this.GetCar_UserValidationField;
            }
            set {
                if ((object.ReferenceEquals(this.GetCar_UserValidationField, value) != true)) {
                    this.GetCar_UserValidationField = value;
                    this.RaisePropertyChanged("GetCar_UserValidation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string GetCar_CarNumber {
            get {
                return this.GetCar_CarNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.GetCar_CarNumberField, value) != true)) {
                    this.GetCar_CarNumberField = value;
                    this.RaisePropertyChanged("GetCar_CarNumber");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrderService.IOrder")]
    public interface IOrder {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/AddOrder", ReplyAction="http://tempuri.org/IOrder/AddOrderResponse")]
        bool AddOrder(WFpart.OrderService.Car_Order Order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/DeleteOrder", ReplyAction="http://tempuri.org/IOrder/DeleteOrderResponse")]
        bool DeleteOrder(int OrderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/UpdateOrder", ReplyAction="http://tempuri.org/IOrder/UpdateOrderResponse")]
        bool UpdateOrder(WFpart.OrderService.Car_Order TempOrder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/PayDeposit", ReplyAction="http://tempuri.org/IOrder/PayDepositResponse")]
        bool PayDeposit(int OrderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/SelectOrder_ID", ReplyAction="http://tempuri.org/IOrder/SelectOrder_IDResponse")]
        WFpart.OrderService.Car_Order SelectOrder_ID(int OrderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/SelectAllOrders", ReplyAction="http://tempuri.org/IOrder/SelectAllOrdersResponse")]
        WFpart.OrderService.Car_Order[] SelectAllOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/SelectOrderDIY_Func", ReplyAction="http://tempuri.org/IOrder/SelectOrderDIY_FuncResponse")]
        WFpart.OrderService.Car_Order[] SelectOrderDIY_Func(System.Func<WFpart.OrderService.Car_Order, bool> where);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/SelectOrderDIY_Field", ReplyAction="http://tempuri.org/IOrder/SelectOrderDIY_FieldResponse")]
        WFpart.OrderService.Car_Order[] SelectOrderDIY_Field(System.Func<WFpart.OrderService.Car_Order, bool> where, System.Func<WFpart.OrderService.Car_Order, WFpart.OrderService.Car_Order> select);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrderChannel : WFpart.OrderService.IOrder, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrderClient : System.ServiceModel.ClientBase<WFpart.OrderService.IOrder>, WFpart.OrderService.IOrder {
        
        public OrderClient() {
        }
        
        public OrderClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrderClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddOrder(WFpart.OrderService.Car_Order Order) {
            return base.Channel.AddOrder(Order);
        }
        
        public bool DeleteOrder(int OrderID) {
            return base.Channel.DeleteOrder(OrderID);
        }
        
        public bool UpdateOrder(WFpart.OrderService.Car_Order TempOrder) {
            return base.Channel.UpdateOrder(TempOrder);
        }
        
        public bool PayDeposit(int OrderID) {
            return base.Channel.PayDeposit(OrderID);
        }
        
        public WFpart.OrderService.Car_Order SelectOrder_ID(int OrderID) {
            return base.Channel.SelectOrder_ID(OrderID);
        }
        
        public WFpart.OrderService.Car_Order[] SelectAllOrders() {
            return base.Channel.SelectAllOrders();
        }
        
        public WFpart.OrderService.Car_Order[] SelectOrderDIY_Func(System.Func<WFpart.OrderService.Car_Order, bool> where) {
            return base.Channel.SelectOrderDIY_Func(where);
        }
        
        public WFpart.OrderService.Car_Order[] SelectOrderDIY_Field(System.Func<WFpart.OrderService.Car_Order, bool> where, System.Func<WFpart.OrderService.Car_Order, WFpart.OrderService.Car_Order> select) {
            return base.Channel.SelectOrderDIY_Field(where, select);
        }
    }
}
