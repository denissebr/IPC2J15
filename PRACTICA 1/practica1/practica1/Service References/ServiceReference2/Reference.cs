﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34014
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace practica1.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.Service1Soap")]
    public interface Service1Soap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento error del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/comprobar", ReplyAction="*")]
        practica1.ServiceReference2.comprobarResponse comprobar(practica1.ServiceReference2.comprobarRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombre del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarLibro", ReplyAction="*")]
        practica1.ServiceReference2.AgregarLibroResponse AgregarLibro(practica1.ServiceReference2.AgregarLibroRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombre del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarCliente", ReplyAction="*")]
        practica1.ServiceReference2.AgregarClienteResponse AgregarCliente(practica1.ServiceReference2.AgregarClienteRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombre del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarLibro", ReplyAction="*")]
        practica1.ServiceReference2.buscarLibroResponse buscarLibro(practica1.ServiceReference2.buscarLibroRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class comprobarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="comprobar", Namespace="http://tempuri.org/", Order=0)]
        public practica1.ServiceReference2.comprobarRequestBody Body;
        
        public comprobarRequest() {
        }
        
        public comprobarRequest(practica1.ServiceReference2.comprobarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class comprobarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string error;
        
        public comprobarRequestBody() {
        }
        
        public comprobarRequestBody(string error) {
            this.error = error;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class comprobarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="comprobarResponse", Namespace="http://tempuri.org/", Order=0)]
        public practica1.ServiceReference2.comprobarResponseBody Body;
        
        public comprobarResponse() {
        }
        
        public comprobarResponse(practica1.ServiceReference2.comprobarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class comprobarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool comprobarResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string error;
        
        public comprobarResponseBody() {
        }
        
        public comprobarResponseBody(bool comprobarResult, string error) {
            this.comprobarResult = comprobarResult;
            this.error = error;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarLibroRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarLibro", Namespace="http://tempuri.org/", Order=0)]
        public practica1.ServiceReference2.AgregarLibroRequestBody Body;
        
        public AgregarLibroRequest() {
        }
        
        public AgregarLibroRequest(practica1.ServiceReference2.AgregarLibroRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarLibroRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int existencia;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int pagina;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string autor;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string tema;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int disponibles;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public int prestamos;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public int reserva;
        
        public AgregarLibroRequestBody() {
        }
        
        public AgregarLibroRequestBody(string nombre, int existencia, int pagina, string autor, string tema, int disponibles, int prestamos, int reserva) {
            this.nombre = nombre;
            this.existencia = existencia;
            this.pagina = pagina;
            this.autor = autor;
            this.tema = tema;
            this.disponibles = disponibles;
            this.prestamos = prestamos;
            this.reserva = reserva;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarLibroResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarLibroResponse", Namespace="http://tempuri.org/", Order=0)]
        public practica1.ServiceReference2.AgregarLibroResponseBody Body;
        
        public AgregarLibroResponse() {
        }
        
        public AgregarLibroResponse(practica1.ServiceReference2.AgregarLibroResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarLibroResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool AgregarLibroResult;
        
        public AgregarLibroResponseBody() {
        }
        
        public AgregarLibroResponseBody(bool AgregarLibroResult) {
            this.AgregarLibroResult = AgregarLibroResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarCliente", Namespace="http://tempuri.org/", Order=0)]
        public practica1.ServiceReference2.AgregarClienteRequestBody Body;
        
        public AgregarClienteRequest() {
        }
        
        public AgregarClienteRequest(practica1.ServiceReference2.AgregarClienteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarClienteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int carnet;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public long dpi;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string direccion;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public long telefono;
        
        public AgregarClienteRequestBody() {
        }
        
        public AgregarClienteRequestBody(int carnet, string nombre, long dpi, string direccion, long telefono) {
            this.carnet = carnet;
            this.nombre = nombre;
            this.dpi = dpi;
            this.direccion = direccion;
            this.telefono = telefono;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarClienteResponse", Namespace="http://tempuri.org/", Order=0)]
        public practica1.ServiceReference2.AgregarClienteResponseBody Body;
        
        public AgregarClienteResponse() {
        }
        
        public AgregarClienteResponse(practica1.ServiceReference2.AgregarClienteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarClienteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool AgregarClienteResult;
        
        public AgregarClienteResponseBody() {
        }
        
        public AgregarClienteResponseBody(bool AgregarClienteResult) {
            this.AgregarClienteResult = AgregarClienteResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class buscarLibroRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="buscarLibro", Namespace="http://tempuri.org/", Order=0)]
        public practica1.ServiceReference2.buscarLibroRequestBody Body;
        
        public buscarLibroRequest() {
        }
        
        public buscarLibroRequest(practica1.ServiceReference2.buscarLibroRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class buscarLibroRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        public buscarLibroRequestBody() {
        }
        
        public buscarLibroRequestBody(string nombre) {
            this.nombre = nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class buscarLibroResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="buscarLibroResponse", Namespace="http://tempuri.org/", Order=0)]
        public practica1.ServiceReference2.buscarLibroResponseBody Body;
        
        public buscarLibroResponse() {
        }
        
        public buscarLibroResponse(practica1.ServiceReference2.buscarLibroResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class buscarLibroResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool buscarLibroResult;
        
        public buscarLibroResponseBody() {
        }
        
        public buscarLibroResponseBody(bool buscarLibroResult) {
            this.buscarLibroResult = buscarLibroResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Service1SoapChannel : practica1.ServiceReference2.Service1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1SoapClient : System.ServiceModel.ClientBase<practica1.ServiceReference2.Service1Soap>, practica1.ServiceReference2.Service1Soap {
        
        public Service1SoapClient() {
        }
        
        public Service1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        practica1.ServiceReference2.comprobarResponse practica1.ServiceReference2.Service1Soap.comprobar(practica1.ServiceReference2.comprobarRequest request) {
            return base.Channel.comprobar(request);
        }
        
        public bool comprobar(ref string error) {
            practica1.ServiceReference2.comprobarRequest inValue = new practica1.ServiceReference2.comprobarRequest();
            inValue.Body = new practica1.ServiceReference2.comprobarRequestBody();
            inValue.Body.error = error;
            practica1.ServiceReference2.comprobarResponse retVal = ((practica1.ServiceReference2.Service1Soap)(this)).comprobar(inValue);
            error = retVal.Body.error;
            return retVal.Body.comprobarResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        practica1.ServiceReference2.AgregarLibroResponse practica1.ServiceReference2.Service1Soap.AgregarLibro(practica1.ServiceReference2.AgregarLibroRequest request) {
            return base.Channel.AgregarLibro(request);
        }
        
        public bool AgregarLibro(string nombre, int existencia, int pagina, string autor, string tema, int disponibles, int prestamos, int reserva) {
            practica1.ServiceReference2.AgregarLibroRequest inValue = new practica1.ServiceReference2.AgregarLibroRequest();
            inValue.Body = new practica1.ServiceReference2.AgregarLibroRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.existencia = existencia;
            inValue.Body.pagina = pagina;
            inValue.Body.autor = autor;
            inValue.Body.tema = tema;
            inValue.Body.disponibles = disponibles;
            inValue.Body.prestamos = prestamos;
            inValue.Body.reserva = reserva;
            practica1.ServiceReference2.AgregarLibroResponse retVal = ((practica1.ServiceReference2.Service1Soap)(this)).AgregarLibro(inValue);
            return retVal.Body.AgregarLibroResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        practica1.ServiceReference2.AgregarClienteResponse practica1.ServiceReference2.Service1Soap.AgregarCliente(practica1.ServiceReference2.AgregarClienteRequest request) {
            return base.Channel.AgregarCliente(request);
        }
        
        public bool AgregarCliente(int carnet, string nombre, long dpi, string direccion, long telefono) {
            practica1.ServiceReference2.AgregarClienteRequest inValue = new practica1.ServiceReference2.AgregarClienteRequest();
            inValue.Body = new practica1.ServiceReference2.AgregarClienteRequestBody();
            inValue.Body.carnet = carnet;
            inValue.Body.nombre = nombre;
            inValue.Body.dpi = dpi;
            inValue.Body.direccion = direccion;
            inValue.Body.telefono = telefono;
            practica1.ServiceReference2.AgregarClienteResponse retVal = ((practica1.ServiceReference2.Service1Soap)(this)).AgregarCliente(inValue);
            return retVal.Body.AgregarClienteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        practica1.ServiceReference2.buscarLibroResponse practica1.ServiceReference2.Service1Soap.buscarLibro(practica1.ServiceReference2.buscarLibroRequest request) {
            return base.Channel.buscarLibro(request);
        }
        
        public bool buscarLibro(string nombre) {
            practica1.ServiceReference2.buscarLibroRequest inValue = new practica1.ServiceReference2.buscarLibroRequest();
            inValue.Body = new practica1.ServiceReference2.buscarLibroRequestBody();
            inValue.Body.nombre = nombre;
            practica1.ServiceReference2.buscarLibroResponse retVal = ((practica1.ServiceReference2.Service1Soap)(this)).buscarLibro(inValue);
            return retVal.Body.buscarLibroResult;
        }
    }
}
