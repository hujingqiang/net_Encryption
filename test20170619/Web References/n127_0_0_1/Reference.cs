// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace test20170619.n127_0_0_1 {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// CodeRemarks
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "7.0.1.24")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="TestServiceSoap", Namespace="http://tempuri.org/")]
    public partial class TestService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        public UserDetails UserDetailsValue;
        
        private System.Threading.SendOrPostCallback SayHelloOperationCompleted;
        
        /// CodeRemarks
        public TestService() {
            this.Url = "http://127.0.0.1:8080/TestService.asmx";
        }
        
        public TestService(string url) {
            this.Url = url;
        }
        
        /// CodeRemarks
        public event SayHelloCompletedEventHandler SayHelloCompleted;
        
        /// CodeRemarks
        [System.Web.Services.Protocols.SoapHeaderAttribute("UserDetailsValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SayHello", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SayHello(string name) {
            object[] results = this.Invoke("SayHello", new object[] {
                        name});
            return ((string)(results[0]));
        }
        
        /// CodeRemarks
        public void SayHelloAsync(string name) {
            this.SayHelloAsync(name, null);
        }
        
        /// CodeRemarks
        public void SayHelloAsync(string name, object userState) {
            if ((this.SayHelloOperationCompleted == null)) {
                this.SayHelloOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSayHelloOperationCompleted);
            }
            this.InvokeAsync("SayHello", new object[] {
                        name}, this.SayHelloOperationCompleted, userState);
        }
        
        private void OnSayHelloOperationCompleted(object arg) {
            if ((this.SayHelloCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SayHelloCompleted(this, new SayHelloCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// CodeRemarks
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "7.0.1.24")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/", IsNullable=false)]
    public partial class UserDetails : System.Web.Services.Protocols.SoapHeader {
        
        /// <remarks/>
        public string userName;
        
        /// <remarks/>
        public string password;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr;
    }
    
    /// CodeRemarks
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "7.0.1.24")]
    public delegate void SayHelloCompletedEventHandler(object sender, SayHelloCompletedEventArgs e);
    
    /// CodeRemarks
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "7.0.1.24")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SayHelloCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SayHelloCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// CodeRemarks
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}
