﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.225
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFpart.VersionService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Car_Version", Namespace="http://schemas.datacontract.org/2004/07/WCFpart")]
    [System.SerializableAttribute()]
    public partial class Car_Version : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Version_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Version_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Version_CountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Version_PersonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Version_TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Version_BrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Version_ShopField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal Version_Price_Normal_RentalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal Version_Price_Member_RentalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal Version_Price_Normal_CatchField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal Version_Price_Member_CatchField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal Version_Price_OverField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal Version_Price_RidingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal Version_Price_Over_RidingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal Version_Price_DepositField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Version_InfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Version_IMGField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Version_BaseKMField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WFpart.VersionService.Car_Order[] Car_OrderField;
        
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
        public int Version_ID {
            get {
                return this.Version_IDField;
            }
            set {
                if ((this.Version_IDField.Equals(value) != true)) {
                    this.Version_IDField = value;
                    this.RaisePropertyChanged("Version_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Version_Name {
            get {
                return this.Version_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.Version_NameField, value) != true)) {
                    this.Version_NameField = value;
                    this.RaisePropertyChanged("Version_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int Version_Count {
            get {
                return this.Version_CountField;
            }
            set {
                if ((this.Version_CountField.Equals(value) != true)) {
                    this.Version_CountField = value;
                    this.RaisePropertyChanged("Version_Count");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int Version_Person {
            get {
                return this.Version_PersonField;
            }
            set {
                if ((this.Version_PersonField.Equals(value) != true)) {
                    this.Version_PersonField = value;
                    this.RaisePropertyChanged("Version_Person");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int Version_Type {
            get {
                return this.Version_TypeField;
            }
            set {
                if ((this.Version_TypeField.Equals(value) != true)) {
                    this.Version_TypeField = value;
                    this.RaisePropertyChanged("Version_Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int Version_Brand {
            get {
                return this.Version_BrandField;
            }
            set {
                if ((this.Version_BrandField.Equals(value) != true)) {
                    this.Version_BrandField = value;
                    this.RaisePropertyChanged("Version_Brand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public int Version_Shop {
            get {
                return this.Version_ShopField;
            }
            set {
                if ((this.Version_ShopField.Equals(value) != true)) {
                    this.Version_ShopField = value;
                    this.RaisePropertyChanged("Version_Shop");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public decimal Version_Price_Normal_Rental {
            get {
                return this.Version_Price_Normal_RentalField;
            }
            set {
                if ((this.Version_Price_Normal_RentalField.Equals(value) != true)) {
                    this.Version_Price_Normal_RentalField = value;
                    this.RaisePropertyChanged("Version_Price_Normal_Rental");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public decimal Version_Price_Member_Rental {
            get {
                return this.Version_Price_Member_RentalField;
            }
            set {
                if ((this.Version_Price_Member_RentalField.Equals(value) != true)) {
                    this.Version_Price_Member_RentalField = value;
                    this.RaisePropertyChanged("Version_Price_Member_Rental");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=9)]
        public decimal Version_Price_Normal_Catch {
            get {
                return this.Version_Price_Normal_CatchField;
            }
            set {
                if ((this.Version_Price_Normal_CatchField.Equals(value) != true)) {
                    this.Version_Price_Normal_CatchField = value;
                    this.RaisePropertyChanged("Version_Price_Normal_Catch");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=10)]
        public decimal Version_Price_Member_Catch {
            get {
                return this.Version_Price_Member_CatchField;
            }
            set {
                if ((this.Version_Price_Member_CatchField.Equals(value) != true)) {
                    this.Version_Price_Member_CatchField = value;
                    this.RaisePropertyChanged("Version_Price_Member_Catch");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=11)]
        public decimal Version_Price_Over {
            get {
                return this.Version_Price_OverField;
            }
            set {
                if ((this.Version_Price_OverField.Equals(value) != true)) {
                    this.Version_Price_OverField = value;
                    this.RaisePropertyChanged("Version_Price_Over");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=12)]
        public decimal Version_Price_Riding {
            get {
                return this.Version_Price_RidingField;
            }
            set {
                if ((this.Version_Price_RidingField.Equals(value) != true)) {
                    this.Version_Price_RidingField = value;
                    this.RaisePropertyChanged("Version_Price_Riding");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=13)]
        public decimal Version_Price_Over_Riding {
            get {
                return this.Version_Price_Over_RidingField;
            }
            set {
                if ((this.Version_Price_Over_RidingField.Equals(value) != true)) {
                    this.Version_Price_Over_RidingField = value;
                    this.RaisePropertyChanged("Version_Price_Over_Riding");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=14)]
        public decimal Version_Price_Deposit {
            get {
                return this.Version_Price_DepositField;
            }
            set {
                if ((this.Version_Price_DepositField.Equals(value) != true)) {
                    this.Version_Price_DepositField = value;
                    this.RaisePropertyChanged("Version_Price_Deposit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=15)]
        public string Version_Info {
            get {
                return this.Version_InfoField;
            }
            set {
                if ((object.ReferenceEquals(this.Version_InfoField, value) != true)) {
                    this.Version_InfoField = value;
                    this.RaisePropertyChanged("Version_Info");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=16)]
        public string Version_IMG {
            get {
                return this.Version_IMGField;
            }
            set {
                if ((object.ReferenceEquals(this.Version_IMGField, value) != true)) {
                    this.Version_IMGField = value;
                    this.RaisePropertyChanged("Version_IMG");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=17)]
        public int Version_BaseKM {
            get {
                return this.Version_BaseKMField;
            }
            set {
                if ((this.Version_BaseKMField.Equals(value) != true)) {
                    this.Version_BaseKMField = value;
                    this.RaisePropertyChanged("Version_BaseKM");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=18)]
        public WFpart.VersionService.Car_Order[] Car_Order {
            get {
                return this.Car_OrderField;
            }
            set {
                if ((object.ReferenceEquals(this.Car_OrderField, value) != true)) {
                    this.Car_OrderField = value;
                    this.RaisePropertyChanged("Car_Order");
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
        private WFpart.VersionService.Car_Checkout[] Car_CheckoutField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public WFpart.VersionService.Car_Checkout[] Car_Checkout {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VersionService.IVersion")]
    public interface IVersion {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVersion/AddVersion", ReplyAction="http://tempuri.org/IVersion/AddVersionResponse")]
        bool AddVersion(WFpart.VersionService.Car_Version Version);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVersion/DeleteVersion", ReplyAction="http://tempuri.org/IVersion/DeleteVersionResponse")]
        bool DeleteVersion(int VersionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVersion/UpdateVersion", ReplyAction="http://tempuri.org/IVersion/UpdateVersionResponse")]
        bool UpdateVersion(WFpart.VersionService.Car_Version TempVersion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVersion/SelectVersion_ID", ReplyAction="http://tempuri.org/IVersion/SelectVersion_IDResponse")]
        WFpart.VersionService.Car_Version SelectVersion_ID(int VersionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVersion/SelectAllVersions", ReplyAction="http://tempuri.org/IVersion/SelectAllVersionsResponse")]
        WFpart.VersionService.Car_Version[] SelectAllVersions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVersion/SelectVersionDIY_Func", ReplyAction="http://tempuri.org/IVersion/SelectVersionDIY_FuncResponse")]
        WFpart.VersionService.Car_Version[] SelectVersionDIY_Func(System.Func<WFpart.VersionService.Car_Version, bool> where);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVersion/SelectVersionDIY_Field", ReplyAction="http://tempuri.org/IVersion/SelectVersionDIY_FieldResponse")]
        WFpart.VersionService.Car_Version[] SelectVersionDIY_Field(System.Func<WFpart.VersionService.Car_Version, bool> where, System.Func<WFpart.VersionService.Car_Version, WFpart.VersionService.Car_Version> select);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVersionChannel : WFpart.VersionService.IVersion, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VersionClient : System.ServiceModel.ClientBase<WFpart.VersionService.IVersion>, WFpart.VersionService.IVersion {
        
        public VersionClient() {
        }
        
        public VersionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VersionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VersionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VersionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddVersion(WFpart.VersionService.Car_Version Version) {
            return base.Channel.AddVersion(Version);
        }
        
        public bool DeleteVersion(int VersionID) {
            return base.Channel.DeleteVersion(VersionID);
        }
        
        public bool UpdateVersion(WFpart.VersionService.Car_Version TempVersion) {
            return base.Channel.UpdateVersion(TempVersion);
        }
        
        public WFpart.VersionService.Car_Version SelectVersion_ID(int VersionID) {
            return base.Channel.SelectVersion_ID(VersionID);
        }
        
        public WFpart.VersionService.Car_Version[] SelectAllVersions() {
            return base.Channel.SelectAllVersions();
        }
        
        public WFpart.VersionService.Car_Version[] SelectVersionDIY_Func(System.Func<WFpart.VersionService.Car_Version, bool> where) {
            return base.Channel.SelectVersionDIY_Func(where);
        }
        
        public WFpart.VersionService.Car_Version[] SelectVersionDIY_Field(System.Func<WFpart.VersionService.Car_Version, bool> where, System.Func<WFpart.VersionService.Car_Version, WFpart.VersionService.Car_Version> select) {
            return base.Channel.SelectVersionDIY_Field(where, select);
        }
    }
}