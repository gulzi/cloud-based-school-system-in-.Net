﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3082
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.3082.
// 
#pragma warning disable 1591

namespace PakTurk_school_system.ManageCourseWS {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ManageCoursesWebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class ManageCoursesWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback Delete_Course_BLLOperationCompleted;
        
        private System.Threading.SendOrPostCallback Add_Course_BLLOperationCompleted;
        
        private System.Threading.SendOrPostCallback Assign_To_Class_BLLOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ManageCoursesWebService() {
            this.Url = global::PakTurk_school_system.Properties.Settings.Default.PakTurk_school_system_ManageCourseWS_ManageCoursesWebService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event HelloWorldCompletedEventHandler HelloWorldCompleted;
        
        /// <remarks/>
        public event Delete_Course_BLLCompletedEventHandler Delete_Course_BLLCompleted;
        
        /// <remarks/>
        public event Add_Course_BLLCompletedEventHandler Add_Course_BLLCompleted;
        
        /// <remarks/>
        public event Assign_To_Class_BLLCompletedEventHandler Assign_To_Class_BLLCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld() {
            object[] results = this.Invoke("HelloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        /// <remarks/>
        public void HelloWorldAsync(object userState) {
            if ((this.HelloWorldOperationCompleted == null)) {
                this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
            }
            this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
        }
        
        private void OnHelloWorldOperationCompleted(object arg) {
            if ((this.HelloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Delete_Course_BLL", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Delete_Course_BLL(string course) {
            object[] results = this.Invoke("Delete_Course_BLL", new object[] {
                        course});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void Delete_Course_BLLAsync(string course) {
            this.Delete_Course_BLLAsync(course, null);
        }
        
        /// <remarks/>
        public void Delete_Course_BLLAsync(string course, object userState) {
            if ((this.Delete_Course_BLLOperationCompleted == null)) {
                this.Delete_Course_BLLOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDelete_Course_BLLOperationCompleted);
            }
            this.InvokeAsync("Delete_Course_BLL", new object[] {
                        course}, this.Delete_Course_BLLOperationCompleted, userState);
        }
        
        private void OnDelete_Course_BLLOperationCompleted(object arg) {
            if ((this.Delete_Course_BLLCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Delete_Course_BLLCompleted(this, new Delete_Course_BLLCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Add_Course_BLL", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Add_Course_BLL(string course, string type) {
            object[] results = this.Invoke("Add_Course_BLL", new object[] {
                        course,
                        type});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void Add_Course_BLLAsync(string course, string type) {
            this.Add_Course_BLLAsync(course, type, null);
        }
        
        /// <remarks/>
        public void Add_Course_BLLAsync(string course, string type, object userState) {
            if ((this.Add_Course_BLLOperationCompleted == null)) {
                this.Add_Course_BLLOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAdd_Course_BLLOperationCompleted);
            }
            this.InvokeAsync("Add_Course_BLL", new object[] {
                        course,
                        type}, this.Add_Course_BLLOperationCompleted, userState);
        }
        
        private void OnAdd_Course_BLLOperationCompleted(object arg) {
            if ((this.Add_Course_BLLCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Add_Course_BLLCompleted(this, new Add_Course_BLLCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Assign_To_Class_BLL", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Assign_To_Class_BLL(string course, string className) {
            object[] results = this.Invoke("Assign_To_Class_BLL", new object[] {
                        course,
                        className});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void Assign_To_Class_BLLAsync(string course, string className) {
            this.Assign_To_Class_BLLAsync(course, className, null);
        }
        
        /// <remarks/>
        public void Assign_To_Class_BLLAsync(string course, string className, object userState) {
            if ((this.Assign_To_Class_BLLOperationCompleted == null)) {
                this.Assign_To_Class_BLLOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAssign_To_Class_BLLOperationCompleted);
            }
            this.InvokeAsync("Assign_To_Class_BLL", new object[] {
                        course,
                        className}, this.Assign_To_Class_BLLOperationCompleted, userState);
        }
        
        private void OnAssign_To_Class_BLLOperationCompleted(object arg) {
            if ((this.Assign_To_Class_BLLCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Assign_To_Class_BLLCompleted(this, new Assign_To_Class_BLLCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void Delete_Course_BLLCompletedEventHandler(object sender, Delete_Course_BLLCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Delete_Course_BLLCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Delete_Course_BLLCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void Add_Course_BLLCompletedEventHandler(object sender, Add_Course_BLLCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Add_Course_BLLCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Add_Course_BLLCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void Assign_To_Class_BLLCompletedEventHandler(object sender, Assign_To_Class_BLLCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Assign_To_Class_BLLCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Assign_To_Class_BLLCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591