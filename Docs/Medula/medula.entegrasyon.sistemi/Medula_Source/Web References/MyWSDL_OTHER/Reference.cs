﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.1.
// 
#pragma warning disable 1591

namespace meno.MyWSDL_OTHER {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="YardimciIslemlerSoapBinding", Namespace="http://servisler.ws.gss.sgk.gov.tr")]
    public partial class YardimciIslemlerService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback saglikTesisiAraOperationCompleted;
        
        private System.Threading.SendOrPostCallback doktorAraOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public YardimciIslemlerService() {
            this.Url = global::meno.Properties.Settings.Default.meno_MyWSDL_OTHER_YardimciIslemlerService;
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
        public event saglikTesisiAraCompletedEventHandler saglikTesisiAraCompleted;
        
        /// <remarks/>
        public event doktorAraCompletedEventHandler doktorAraCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://servisler.ws.gss.sgk.gov.tr", ResponseNamespace="http://servisler.ws.gss.sgk.gov.tr", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("saglikTesisiAraReturn", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public SaglikTesisiAraCevapDVO saglikTesisiAra([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] SaglikTesisiAraGirisDVO saglikTesisiAraGiris) {
            object[] results = this.Invoke("saglikTesisiAra", new object[] {
                        saglikTesisiAraGiris});
            return ((SaglikTesisiAraCevapDVO)(results[0]));
        }
        
        /// <remarks/>
        public void saglikTesisiAraAsync(SaglikTesisiAraGirisDVO saglikTesisiAraGiris) {
            this.saglikTesisiAraAsync(saglikTesisiAraGiris, null);
        }
        
        /// <remarks/>
        public void saglikTesisiAraAsync(SaglikTesisiAraGirisDVO saglikTesisiAraGiris, object userState) {
            if ((this.saglikTesisiAraOperationCompleted == null)) {
                this.saglikTesisiAraOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsaglikTesisiAraOperationCompleted);
            }
            this.InvokeAsync("saglikTesisiAra", new object[] {
                        saglikTesisiAraGiris}, this.saglikTesisiAraOperationCompleted, userState);
        }
        
        private void OnsaglikTesisiAraOperationCompleted(object arg) {
            if ((this.saglikTesisiAraCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.saglikTesisiAraCompleted(this, new saglikTesisiAraCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://servisler.ws.gss.sgk.gov.tr", ResponseNamespace="http://servisler.ws.gss.sgk.gov.tr", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("doktorAraReturn", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public DoktorAraCevapDVO doktorAra([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] DoktorAraGirisDVO doktorAraGiris) {
            object[] results = this.Invoke("doktorAra", new object[] {
                        doktorAraGiris});
            return ((DoktorAraCevapDVO)(results[0]));
        }
        
        /// <remarks/>
        public void doktorAraAsync(DoktorAraGirisDVO doktorAraGiris) {
            this.doktorAraAsync(doktorAraGiris, null);
        }
        
        /// <remarks/>
        public void doktorAraAsync(DoktorAraGirisDVO doktorAraGiris, object userState) {
            if ((this.doktorAraOperationCompleted == null)) {
                this.doktorAraOperationCompleted = new System.Threading.SendOrPostCallback(this.OndoktorAraOperationCompleted);
            }
            this.InvokeAsync("doktorAra", new object[] {
                        doktorAraGiris}, this.doktorAraOperationCompleted, userState);
        }
        
        private void OndoktorAraOperationCompleted(object arg) {
            if ((this.doktorAraCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.doktorAraCompleted(this, new doktorAraCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dvo.gss.sgk.gov.tr")]
    public partial class SaglikTesisiAraGirisDVO {
        
        private int saglikTesisKoduField;
        
        private string tesisAdiField;
        
        private string tesisIlKoduField;
        
        private string tesisKoduField;
        
        private string tesisTuruField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int saglikTesisKodu {
            get {
                return this.saglikTesisKoduField;
            }
            set {
                this.saglikTesisKoduField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string tesisAdi {
            get {
                return this.tesisAdiField;
            }
            set {
                this.tesisAdiField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string tesisIlKodu {
            get {
                return this.tesisIlKoduField;
            }
            set {
                this.tesisIlKoduField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string tesisKodu {
            get {
                return this.tesisKoduField;
            }
            set {
                this.tesisKoduField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string tesisTuru {
            get {
                return this.tesisTuruField;
            }
            set {
                this.tesisTuruField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dvo.gss.sgk.gov.tr")]
    public partial class DoktorListDVO {
        
        private string drAdiField;
        
        private string drDiplomaNoField;
        
        private string drSoyadiField;
        
        private string drTescilNoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string drAdi {
            get {
                return this.drAdiField;
            }
            set {
                this.drAdiField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string drDiplomaNo {
            get {
                return this.drDiplomaNoField;
            }
            set {
                this.drDiplomaNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string drSoyadi {
            get {
                return this.drSoyadiField;
            }
            set {
                this.drSoyadiField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string drTescilNo {
            get {
                return this.drTescilNoField;
            }
            set {
                this.drTescilNoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dvo.gss.sgk.gov.tr")]
    public partial class DoktorAraCevapDVO {
        
        private DoktorListDVO[] doktorlarField;
        
        private string sonucKoduField;
        
        private string sonucMesajiField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DoktorListDVO[] doktorlar {
            get {
                return this.doktorlarField;
            }
            set {
                this.doktorlarField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string sonucKodu {
            get {
                return this.sonucKoduField;
            }
            set {
                this.sonucKoduField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string sonucMesaji {
            get {
                return this.sonucMesajiField;
            }
            set {
                this.sonucMesajiField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dvo.gss.sgk.gov.tr")]
    public partial class DoktorAraGirisDVO {
        
        private string drAdiField;
        
        private string drBransKoduField;
        
        private string drDiplomaNoField;
        
        private string drSoyadiField;
        
        private string drTescilNoField;
        
        private int saglikTesisiKoduField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string drAdi {
            get {
                return this.drAdiField;
            }
            set {
                this.drAdiField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string drBransKodu {
            get {
                return this.drBransKoduField;
            }
            set {
                this.drBransKoduField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string drDiplomaNo {
            get {
                return this.drDiplomaNoField;
            }
            set {
                this.drDiplomaNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string drSoyadi {
            get {
                return this.drSoyadiField;
            }
            set {
                this.drSoyadiField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string drTescilNo {
            get {
                return this.drTescilNoField;
            }
            set {
                this.drTescilNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int saglikTesisiKodu {
            get {
                return this.saglikTesisiKoduField;
            }
            set {
                this.saglikTesisiKoduField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dvo.gss.sgk.gov.tr")]
    public partial class SaglikTesisiListDVO {
        
        private string tesisIlField;
        
        private string tesisAdiField;
        
        private int tesisKoduField;
        
        private string tesisSinifKoduField;
        
        private string tesisTuruField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string tesisIl {
            get {
                return this.tesisIlField;
            }
            set {
                this.tesisIlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string tesisAdi {
            get {
                return this.tesisAdiField;
            }
            set {
                this.tesisAdiField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int tesisKodu {
            get {
                return this.tesisKoduField;
            }
            set {
                this.tesisKoduField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string tesisSinifKodu {
            get {
                return this.tesisSinifKoduField;
            }
            set {
                this.tesisSinifKoduField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string tesisTuru {
            get {
                return this.tesisTuruField;
            }
            set {
                this.tesisTuruField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dvo.gss.sgk.gov.tr")]
    public partial class SaglikTesisiAraCevapDVO {
        
        private string sonucKoduField;
        
        private string sonucMesajiField;
        
        private SaglikTesisiListDVO[] tesislerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string sonucKodu {
            get {
                return this.sonucKoduField;
            }
            set {
                this.sonucKoduField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string sonucMesaji {
            get {
                return this.sonucMesajiField;
            }
            set {
                this.sonucMesajiField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SaglikTesisiListDVO[] tesisler {
            get {
                return this.tesislerField;
            }
            set {
                this.tesislerField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void saglikTesisiAraCompletedEventHandler(object sender, saglikTesisiAraCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class saglikTesisiAraCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal saglikTesisiAraCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SaglikTesisiAraCevapDVO Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SaglikTesisiAraCevapDVO)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void doktorAraCompletedEventHandler(object sender, doktorAraCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class doktorAraCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal doktorAraCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DoktorAraCevapDVO Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DoktorAraCevapDVO)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591