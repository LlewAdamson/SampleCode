﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyGate_Global_3D_Secure_Enterprise_Example.Authenticate {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://api.mygateglobal.com/", ConfigurationName="Authenticate.APIService")]
    public interface APIService {
        
        // CODEGEN: Generating message contract since the operation execRequest is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://api.mygateglobal.com/execRequest", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        MyGate_Global_3D_Secure_Enterprise_Example.Authenticate.execRequestOut execRequest(MyGate_Global_3D_Secure_Enterprise_Example.Authenticate.execRequestIn request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://api.mygateglobal.com/")]
    public partial class responseMessage : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string statusField;
        
        private string uidTransactionIndexField;
        
        private string dtRequestReceivedField;
        
        private string dtResponseSentField;
        
        private resWarning warningsField;
        
        private resError errorsField;
        
        private resMGMessage mgMessageField;
        
        private resFspMessage fspMessageField;
        
        private resTdsLookup tdsLookupField;
        
        private resTdsAuth tdsAuthField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("status");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string uidTransactionIndex {
            get {
                return this.uidTransactionIndexField;
            }
            set {
                this.uidTransactionIndexField = value;
                this.RaisePropertyChanged("uidTransactionIndex");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string dtRequestReceived {
            get {
                return this.dtRequestReceivedField;
            }
            set {
                this.dtRequestReceivedField = value;
                this.RaisePropertyChanged("dtRequestReceived");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string dtResponseSent {
            get {
                return this.dtResponseSentField;
            }
            set {
                this.dtResponseSentField = value;
                this.RaisePropertyChanged("dtResponseSent");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public resWarning warnings {
            get {
                return this.warningsField;
            }
            set {
                this.warningsField = value;
                this.RaisePropertyChanged("warnings");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public resError errors {
            get {
                return this.errorsField;
            }
            set {
                this.errorsField = value;
                this.RaisePropertyChanged("errors");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public resMGMessage mgMessage {
            get {
                return this.mgMessageField;
            }
            set {
                this.mgMessageField = value;
                this.RaisePropertyChanged("mgMessage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public resFspMessage fspMessage {
            get {
                return this.fspMessageField;
            }
            set {
                this.fspMessageField = value;
                this.RaisePropertyChanged("fspMessage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public resTdsLookup tdsLookup {
            get {
                return this.tdsLookupField;
            }
            set {
                this.tdsLookupField = value;
                this.RaisePropertyChanged("tdsLookup");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public resTdsAuth tdsAuth {
            get {
                return this.tdsAuthField;
            }
            set {
                this.tdsAuthField = value;
                this.RaisePropertyChanged("tdsAuth");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://api.mygateglobal.com/")]
    public partial class resWarning : object, System.ComponentModel.INotifyPropertyChanged {
        
        private resMessages warningField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public resMessages warning {
            get {
                return this.warningField;
            }
            set {
                this.warningField = value;
                this.RaisePropertyChanged("warning");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://api.mygateglobal.com/")]
    public partial class resMessages : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codeField;
        
        private string messageField;
        
        private string descriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://api.mygateglobal.com/")]
    public partial class resTdsAuth : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codeField;
        
        private string messageField;
        
        private string liabilityShiftField;
        
        private string ccAuthAllowedField;
        
        private string eciFlagField;
        
        private string paresStatusField;
        
        private string signatureVerificationField;
        
        private string xidField;
        
        private string cavvField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string liabilityShift {
            get {
                return this.liabilityShiftField;
            }
            set {
                this.liabilityShiftField = value;
                this.RaisePropertyChanged("liabilityShift");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string ccAuthAllowed {
            get {
                return this.ccAuthAllowedField;
            }
            set {
                this.ccAuthAllowedField = value;
                this.RaisePropertyChanged("ccAuthAllowed");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string eciFlag {
            get {
                return this.eciFlagField;
            }
            set {
                this.eciFlagField = value;
                this.RaisePropertyChanged("eciFlag");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string paresStatus {
            get {
                return this.paresStatusField;
            }
            set {
                this.paresStatusField = value;
                this.RaisePropertyChanged("paresStatus");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string signatureVerification {
            get {
                return this.signatureVerificationField;
            }
            set {
                this.signatureVerificationField = value;
                this.RaisePropertyChanged("signatureVerification");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string xid {
            get {
                return this.xidField;
            }
            set {
                this.xidField = value;
                this.RaisePropertyChanged("xid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string cavv {
            get {
                return this.cavvField;
            }
            set {
                this.cavvField = value;
                this.RaisePropertyChanged("cavv");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://api.mygateglobal.com/")]
    public partial class resTdsLookup : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codeField;
        
        private string messageField;
        
        private string authRequiredField;
        
        private string liabilityShiftField;
        
        private string ccAuthAllowedField;
        
        private string eciFlagField;
        
        private string enrolledField;
        
        private string acsUrlField;
        
        private string payloadField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string authRequired {
            get {
                return this.authRequiredField;
            }
            set {
                this.authRequiredField = value;
                this.RaisePropertyChanged("authRequired");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string liabilityShift {
            get {
                return this.liabilityShiftField;
            }
            set {
                this.liabilityShiftField = value;
                this.RaisePropertyChanged("liabilityShift");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string ccAuthAllowed {
            get {
                return this.ccAuthAllowedField;
            }
            set {
                this.ccAuthAllowedField = value;
                this.RaisePropertyChanged("ccAuthAllowed");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string eciFlag {
            get {
                return this.eciFlagField;
            }
            set {
                this.eciFlagField = value;
                this.RaisePropertyChanged("eciFlag");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string enrolled {
            get {
                return this.enrolledField;
            }
            set {
                this.enrolledField = value;
                this.RaisePropertyChanged("enrolled");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string acsUrl {
            get {
                return this.acsUrlField;
            }
            set {
                this.acsUrlField = value;
                this.RaisePropertyChanged("acsUrl");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string payload {
            get {
                return this.payloadField;
            }
            set {
                this.payloadField = value;
                this.RaisePropertyChanged("payload");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://api.mygateglobal.com/")]
    public partial class resFspMessage : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codeField;
        
        private string messageField;
        
        private string authorizationCodeField;
        
        private string processorResponseField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string authorizationCode {
            get {
                return this.authorizationCodeField;
            }
            set {
                this.authorizationCodeField = value;
                this.RaisePropertyChanged("authorizationCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string processorResponse {
            get {
                return this.processorResponseField;
            }
            set {
                this.processorResponseField = value;
                this.RaisePropertyChanged("processorResponse");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://api.mygateglobal.com/")]
    public partial class resMGMessage : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string cardCountryField;
        
        private string currencyCodeField;
        
        private string eciFlagField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string cardCountry {
            get {
                return this.cardCountryField;
            }
            set {
                this.cardCountryField = value;
                this.RaisePropertyChanged("cardCountry");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string currencyCode {
            get {
                return this.currencyCodeField;
            }
            set {
                this.currencyCodeField = value;
                this.RaisePropertyChanged("currencyCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string eciFlag {
            get {
                return this.eciFlagField;
            }
            set {
                this.eciFlagField = value;
                this.RaisePropertyChanged("eciFlag");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://api.mygateglobal.com/")]
    public partial class resError : object, System.ComponentModel.INotifyPropertyChanged {
        
        private resMessages errorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public resMessages error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
                this.RaisePropertyChanged("error");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class execRequestIn {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.mygateglobal.com/", Order=0)]
        public string requestMessage;
        
        public execRequestIn() {
        }
        
        public execRequestIn(string requestMessage) {
            this.requestMessage = requestMessage;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class execRequestOut {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.mygateglobal.com/", Order=0)]
        public MyGate_Global_3D_Secure_Enterprise_Example.Authenticate.responseMessage responseMessage;
        
        public execRequestOut() {
        }
        
        public execRequestOut(MyGate_Global_3D_Secure_Enterprise_Example.Authenticate.responseMessage responseMessage) {
            this.responseMessage = responseMessage;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface APIServiceChannel : MyGate_Global_3D_Secure_Enterprise_Example.Authenticate.APIService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class APIServiceClient : System.ServiceModel.ClientBase<MyGate_Global_3D_Secure_Enterprise_Example.Authenticate.APIService>, MyGate_Global_3D_Secure_Enterprise_Example.Authenticate.APIService {
        
        public APIServiceClient() {
        }
        
        public APIServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public APIServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public APIServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public APIServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MyGate_Global_3D_Secure_Enterprise_Example.Authenticate.execRequestOut MyGate_Global_3D_Secure_Enterprise_Example.Authenticate.APIService.execRequest(MyGate_Global_3D_Secure_Enterprise_Example.Authenticate.execRequestIn request) {
            return base.Channel.execRequest(request);
        }
        
        public MyGate_Global_3D_Secure_Enterprise_Example.Authenticate.responseMessage execRequest(string requestMessage) {
            MyGate_Global_3D_Secure_Enterprise_Example.Authenticate.execRequestIn inValue = new MyGate_Global_3D_Secure_Enterprise_Example.Authenticate.execRequestIn();
            inValue.requestMessage = requestMessage;
            MyGate_Global_3D_Secure_Enterprise_Example.Authenticate.execRequestOut retVal = ((MyGate_Global_3D_Secure_Enterprise_Example.Authenticate.APIService)(this)).execRequest(inValue);
            return retVal.responseMessage;
        }
    }
}
