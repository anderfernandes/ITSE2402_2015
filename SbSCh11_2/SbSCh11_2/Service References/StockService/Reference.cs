﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace SbSCh11_2.StockService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.webserviceX.NET/", ConfigurationName="StockService.StockQuoteSoap")]
    public interface StockQuoteSoap {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.webserviceX.NET/GetQuote", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.IAsyncResult BeginGetQuote(string symbol, System.AsyncCallback callback, object asyncState);
        
        string EndGetQuote(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface StockQuoteSoapChannel : SbSCh11_2.StockService.StockQuoteSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetQuoteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetQuoteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StockQuoteSoapClient : System.ServiceModel.ClientBase<SbSCh11_2.StockService.StockQuoteSoap>, SbSCh11_2.StockService.StockQuoteSoap {
        
        private BeginOperationDelegate onBeginGetQuoteDelegate;
        
        private EndOperationDelegate onEndGetQuoteDelegate;
        
        private System.Threading.SendOrPostCallback onGetQuoteCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public StockQuoteSoapClient() {
        }
        
        public StockQuoteSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StockQuoteSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockQuoteSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockQuoteSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetQuoteCompletedEventArgs> GetQuoteCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SbSCh11_2.StockService.StockQuoteSoap.BeginGetQuote(string symbol, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetQuote(symbol, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string SbSCh11_2.StockService.StockQuoteSoap.EndGetQuote(System.IAsyncResult result) {
            return base.Channel.EndGetQuote(result);
        }
        
        private System.IAsyncResult OnBeginGetQuote(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string symbol = ((string)(inValues[0]));
            return ((SbSCh11_2.StockService.StockQuoteSoap)(this)).BeginGetQuote(symbol, callback, asyncState);
        }
        
        private object[] OnEndGetQuote(System.IAsyncResult result) {
            string retVal = ((SbSCh11_2.StockService.StockQuoteSoap)(this)).EndGetQuote(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetQuoteCompleted(object state) {
            if ((this.GetQuoteCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetQuoteCompleted(this, new GetQuoteCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetQuoteAsync(string symbol) {
            this.GetQuoteAsync(symbol, null);
        }
        
        public void GetQuoteAsync(string symbol, object userState) {
            if ((this.onBeginGetQuoteDelegate == null)) {
                this.onBeginGetQuoteDelegate = new BeginOperationDelegate(this.OnBeginGetQuote);
            }
            if ((this.onEndGetQuoteDelegate == null)) {
                this.onEndGetQuoteDelegate = new EndOperationDelegate(this.OnEndGetQuote);
            }
            if ((this.onGetQuoteCompletedDelegate == null)) {
                this.onGetQuoteCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetQuoteCompleted);
            }
            base.InvokeAsync(this.onBeginGetQuoteDelegate, new object[] {
                        symbol}, this.onEndGetQuoteDelegate, this.onGetQuoteCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override SbSCh11_2.StockService.StockQuoteSoap CreateChannel() {
            return new StockQuoteSoapClientChannel(this);
        }
        
        private class StockQuoteSoapClientChannel : ChannelBase<SbSCh11_2.StockService.StockQuoteSoap>, SbSCh11_2.StockService.StockQuoteSoap {
            
            public StockQuoteSoapClientChannel(System.ServiceModel.ClientBase<SbSCh11_2.StockService.StockQuoteSoap> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetQuote(string symbol, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = symbol;
                System.IAsyncResult _result = base.BeginInvoke("GetQuote", _args, callback, asyncState);
                return _result;
            }
            
            public string EndGetQuote(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("GetQuote", _args, result)));
                return _result;
            }
        }
    }
}