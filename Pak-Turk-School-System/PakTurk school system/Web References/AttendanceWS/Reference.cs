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

namespace PakTurk_school_system.AttendanceWS {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AttendanceWebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class AttendanceWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback displayStudentsBLLOperationCompleted;
        
        private System.Threading.SendOrPostCallback display4UpdateStudentsBLLOperationCompleted;
        
        private System.Threading.SendOrPostCallback markAttendanceBLLOperationCompleted;
        
        private System.Threading.SendOrPostCallback getStudentDetailsBLLOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAttendanceBLLOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AttendanceWebService() {
            this.Url = global::PakTurk_school_system.Properties.Settings.Default.PakTurk_school_system_AttendanceWS_AttendanceWebService;
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
        public event displayStudentsBLLCompletedEventHandler displayStudentsBLLCompleted;
        
        /// <remarks/>
        public event display4UpdateStudentsBLLCompletedEventHandler display4UpdateStudentsBLLCompleted;
        
        /// <remarks/>
        public event markAttendanceBLLCompletedEventHandler markAttendanceBLLCompleted;
        
        /// <remarks/>
        public event getStudentDetailsBLLCompletedEventHandler getStudentDetailsBLLCompleted;
        
        /// <remarks/>
        public event getAttendanceBLLCompletedEventHandler getAttendanceBLLCompleted;
        
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/displayStudentsBLL", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet displayStudentsBLL(string className) {
            object[] results = this.Invoke("displayStudentsBLL", new object[] {
                        className});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void displayStudentsBLLAsync(string className) {
            this.displayStudentsBLLAsync(className, null);
        }
        
        /// <remarks/>
        public void displayStudentsBLLAsync(string className, object userState) {
            if ((this.displayStudentsBLLOperationCompleted == null)) {
                this.displayStudentsBLLOperationCompleted = new System.Threading.SendOrPostCallback(this.OndisplayStudentsBLLOperationCompleted);
            }
            this.InvokeAsync("displayStudentsBLL", new object[] {
                        className}, this.displayStudentsBLLOperationCompleted, userState);
        }
        
        private void OndisplayStudentsBLLOperationCompleted(object arg) {
            if ((this.displayStudentsBLLCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.displayStudentsBLLCompleted(this, new displayStudentsBLLCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/display4UpdateStudentsBLL", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string display4UpdateStudentsBLL(string rollNo, string date) {
            object[] results = this.Invoke("display4UpdateStudentsBLL", new object[] {
                        rollNo,
                        date});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void display4UpdateStudentsBLLAsync(string rollNo, string date) {
            this.display4UpdateStudentsBLLAsync(rollNo, date, null);
        }
        
        /// <remarks/>
        public void display4UpdateStudentsBLLAsync(string rollNo, string date, object userState) {
            if ((this.display4UpdateStudentsBLLOperationCompleted == null)) {
                this.display4UpdateStudentsBLLOperationCompleted = new System.Threading.SendOrPostCallback(this.Ondisplay4UpdateStudentsBLLOperationCompleted);
            }
            this.InvokeAsync("display4UpdateStudentsBLL", new object[] {
                        rollNo,
                        date}, this.display4UpdateStudentsBLLOperationCompleted, userState);
        }
        
        private void Ondisplay4UpdateStudentsBLLOperationCompleted(object arg) {
            if ((this.display4UpdateStudentsBLLCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.display4UpdateStudentsBLLCompleted(this, new display4UpdateStudentsBLLCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/markAttendanceBLL", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string markAttendanceBLL(string rollNo, string date, string isPresent, int flag) {
            object[] results = this.Invoke("markAttendanceBLL", new object[] {
                        rollNo,
                        date,
                        isPresent,
                        flag});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void markAttendanceBLLAsync(string rollNo, string date, string isPresent, int flag) {
            this.markAttendanceBLLAsync(rollNo, date, isPresent, flag, null);
        }
        
        /// <remarks/>
        public void markAttendanceBLLAsync(string rollNo, string date, string isPresent, int flag, object userState) {
            if ((this.markAttendanceBLLOperationCompleted == null)) {
                this.markAttendanceBLLOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmarkAttendanceBLLOperationCompleted);
            }
            this.InvokeAsync("markAttendanceBLL", new object[] {
                        rollNo,
                        date,
                        isPresent,
                        flag}, this.markAttendanceBLLOperationCompleted, userState);
        }
        
        private void OnmarkAttendanceBLLOperationCompleted(object arg) {
            if ((this.markAttendanceBLLCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.markAttendanceBLLCompleted(this, new markAttendanceBLLCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getStudentDetailsBLL", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void getStudentDetailsBLL(string userName, ref string fName, ref string lName, ref string rollNo) {
            object[] results = this.Invoke("getStudentDetailsBLL", new object[] {
                        userName,
                        fName,
                        lName,
                        rollNo});
            fName = ((string)(results[0]));
            lName = ((string)(results[1]));
            rollNo = ((string)(results[2]));
        }
        
        /// <remarks/>
        public void getStudentDetailsBLLAsync(string userName, string fName, string lName, string rollNo) {
            this.getStudentDetailsBLLAsync(userName, fName, lName, rollNo, null);
        }
        
        /// <remarks/>
        public void getStudentDetailsBLLAsync(string userName, string fName, string lName, string rollNo, object userState) {
            if ((this.getStudentDetailsBLLOperationCompleted == null)) {
                this.getStudentDetailsBLLOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetStudentDetailsBLLOperationCompleted);
            }
            this.InvokeAsync("getStudentDetailsBLL", new object[] {
                        userName,
                        fName,
                        lName,
                        rollNo}, this.getStudentDetailsBLLOperationCompleted, userState);
        }
        
        private void OngetStudentDetailsBLLOperationCompleted(object arg) {
            if ((this.getStudentDetailsBLLCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getStudentDetailsBLLCompleted(this, new getStudentDetailsBLLCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getAttendanceBLL", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getAttendanceBLL(string rollNo) {
            object[] results = this.Invoke("getAttendanceBLL", new object[] {
                        rollNo});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getAttendanceBLLAsync(string rollNo) {
            this.getAttendanceBLLAsync(rollNo, null);
        }
        
        /// <remarks/>
        public void getAttendanceBLLAsync(string rollNo, object userState) {
            if ((this.getAttendanceBLLOperationCompleted == null)) {
                this.getAttendanceBLLOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAttendanceBLLOperationCompleted);
            }
            this.InvokeAsync("getAttendanceBLL", new object[] {
                        rollNo}, this.getAttendanceBLLOperationCompleted, userState);
        }
        
        private void OngetAttendanceBLLOperationCompleted(object arg) {
            if ((this.getAttendanceBLLCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAttendanceBLLCompleted(this, new getAttendanceBLLCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void displayStudentsBLLCompletedEventHandler(object sender, displayStudentsBLLCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class displayStudentsBLLCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal displayStudentsBLLCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void display4UpdateStudentsBLLCompletedEventHandler(object sender, display4UpdateStudentsBLLCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class display4UpdateStudentsBLLCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal display4UpdateStudentsBLLCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void markAttendanceBLLCompletedEventHandler(object sender, markAttendanceBLLCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class markAttendanceBLLCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal markAttendanceBLLCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void getStudentDetailsBLLCompletedEventHandler(object sender, getStudentDetailsBLLCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getStudentDetailsBLLCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getStudentDetailsBLLCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string fName {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string lName {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string rollNo {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void getAttendanceBLLCompletedEventHandler(object sender, getAttendanceBLLCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAttendanceBLLCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAttendanceBLLCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591