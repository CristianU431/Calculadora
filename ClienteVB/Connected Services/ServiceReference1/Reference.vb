﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ServiceReference1
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServiceReference1.CalculadoraSoap")>  _
    Public Interface CalculadoraSoap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Suma", ReplyAction:="*")>  _
        Function Suma(ByVal nro1 As Double, ByVal nro2 As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Suma", ReplyAction:="*")>  _
        Function SumaAsync(ByVal nro1 As Double, ByVal nro2 As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Resta", ReplyAction:="*")>  _
        Function Resta(ByVal nro1 As Double, ByVal nro2 As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Resta", ReplyAction:="*")>  _
        Function RestaAsync(ByVal nro1 As Double, ByVal nro2 As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Multiplicacion", ReplyAction:="*")>  _
        Function Multiplicacion(ByVal nro1 As Double, ByVal nro2 As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Multiplicacion", ReplyAction:="*")>  _
        Function MultiplicacionAsync(ByVal nro1 As Double, ByVal nro2 As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Division", ReplyAction:="*")>  _
        Function Division(ByVal nro1 As Double, ByVal nro2 As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Division", ReplyAction:="*")>  _
        Function DivisionAsync(ByVal nro1 As Double, ByVal nro2 As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Factorial", ReplyAction:="*")>  _
        Function Factorial(ByVal n As Integer) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Factorial", ReplyAction:="*")>  _
        Function FactorialAsync(ByVal n As Integer) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Potencia", ReplyAction:="*")>  _
        Function Potencia(ByVal nro1 As Integer, ByVal nro2 As Integer) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Potencia", ReplyAction:="*")>  _
        Function PotenciaAsync(ByVal nro1 As Integer, ByVal nro2 As Integer) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Tangente", ReplyAction:="*")>  _
        Function Tangente(ByVal nro As Integer) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Tangente", ReplyAction:="*")>  _
        Function TangenteAsync(ByVal nro As Integer) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Coseno", ReplyAction:="*")>  _
        Function Coseno(ByVal nro As Integer) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Coseno", ReplyAction:="*")>  _
        Function CosenoAsync(ByVal nro As Integer) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Seno", ReplyAction:="*")>  _
        Function Seno(ByVal nro As Integer) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Seno", ReplyAction:="*")>  _
        Function SenoAsync(ByVal nro As Integer) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Inverso", ReplyAction:="*")>  _
        Function Inverso(ByVal nro1 As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Inverso", ReplyAction:="*")>  _
        Function InversoAsync(ByVal nro1 As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Porcentaje", ReplyAction:="*")>  _
        Function Porcentaje(ByVal nro1 As Double, ByVal nro2 As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Porcentaje", ReplyAction:="*")>  _
        Function PorcentajeAsync(ByVal nro1 As Double, ByVal nro2 As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Logaritmo", ReplyAction:="*")>  _
        Function Logaritmo(ByVal nro As Integer) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Logaritmo", ReplyAction:="*")>  _
        Function LogaritmoAsync(ByVal nro As Integer) As System.Threading.Tasks.Task(Of Double)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface CalculadoraSoapChannel
        Inherits ServiceReference1.CalculadoraSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class CalculadoraSoapClient
        Inherits System.ServiceModel.ClientBase(Of ServiceReference1.CalculadoraSoap)
        Implements ServiceReference1.CalculadoraSoap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function Suma(ByVal nro1 As Double, ByVal nro2 As Double) As Double Implements ServiceReference1.CalculadoraSoap.Suma
            Return MyBase.Channel.Suma(nro1, nro2)
        End Function
        
        Public Function SumaAsync(ByVal nro1 As Double, ByVal nro2 As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.CalculadoraSoap.SumaAsync
            Return MyBase.Channel.SumaAsync(nro1, nro2)
        End Function
        
        Public Function Resta(ByVal nro1 As Double, ByVal nro2 As Double) As Double Implements ServiceReference1.CalculadoraSoap.Resta
            Return MyBase.Channel.Resta(nro1, nro2)
        End Function
        
        Public Function RestaAsync(ByVal nro1 As Double, ByVal nro2 As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.CalculadoraSoap.RestaAsync
            Return MyBase.Channel.RestaAsync(nro1, nro2)
        End Function
        
        Public Function Multiplicacion(ByVal nro1 As Double, ByVal nro2 As Double) As Double Implements ServiceReference1.CalculadoraSoap.Multiplicacion
            Return MyBase.Channel.Multiplicacion(nro1, nro2)
        End Function
        
        Public Function MultiplicacionAsync(ByVal nro1 As Double, ByVal nro2 As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.CalculadoraSoap.MultiplicacionAsync
            Return MyBase.Channel.MultiplicacionAsync(nro1, nro2)
        End Function
        
        Public Function Division(ByVal nro1 As Double, ByVal nro2 As Double) As Double Implements ServiceReference1.CalculadoraSoap.Division
            Return MyBase.Channel.Division(nro1, nro2)
        End Function
        
        Public Function DivisionAsync(ByVal nro1 As Double, ByVal nro2 As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.CalculadoraSoap.DivisionAsync
            Return MyBase.Channel.DivisionAsync(nro1, nro2)
        End Function
        
        Public Function Factorial(ByVal n As Integer) As Double Implements ServiceReference1.CalculadoraSoap.Factorial
            Return MyBase.Channel.Factorial(n)
        End Function
        
        Public Function FactorialAsync(ByVal n As Integer) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.CalculadoraSoap.FactorialAsync
            Return MyBase.Channel.FactorialAsync(n)
        End Function
        
        Public Function Potencia(ByVal nro1 As Integer, ByVal nro2 As Integer) As Double Implements ServiceReference1.CalculadoraSoap.Potencia
            Return MyBase.Channel.Potencia(nro1, nro2)
        End Function
        
        Public Function PotenciaAsync(ByVal nro1 As Integer, ByVal nro2 As Integer) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.CalculadoraSoap.PotenciaAsync
            Return MyBase.Channel.PotenciaAsync(nro1, nro2)
        End Function
        
        Public Function Tangente(ByVal nro As Integer) As Double Implements ServiceReference1.CalculadoraSoap.Tangente
            Return MyBase.Channel.Tangente(nro)
        End Function
        
        Public Function TangenteAsync(ByVal nro As Integer) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.CalculadoraSoap.TangenteAsync
            Return MyBase.Channel.TangenteAsync(nro)
        End Function
        
        Public Function Coseno(ByVal nro As Integer) As Double Implements ServiceReference1.CalculadoraSoap.Coseno
            Return MyBase.Channel.Coseno(nro)
        End Function
        
        Public Function CosenoAsync(ByVal nro As Integer) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.CalculadoraSoap.CosenoAsync
            Return MyBase.Channel.CosenoAsync(nro)
        End Function
        
        Public Function Seno(ByVal nro As Integer) As Double Implements ServiceReference1.CalculadoraSoap.Seno
            Return MyBase.Channel.Seno(nro)
        End Function
        
        Public Function SenoAsync(ByVal nro As Integer) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.CalculadoraSoap.SenoAsync
            Return MyBase.Channel.SenoAsync(nro)
        End Function
        
        Public Function Inverso(ByVal nro1 As Double) As Double Implements ServiceReference1.CalculadoraSoap.Inverso
            Return MyBase.Channel.Inverso(nro1)
        End Function
        
        Public Function InversoAsync(ByVal nro1 As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.CalculadoraSoap.InversoAsync
            Return MyBase.Channel.InversoAsync(nro1)
        End Function
        
        Public Function Porcentaje(ByVal nro1 As Double, ByVal nro2 As Double) As Double Implements ServiceReference1.CalculadoraSoap.Porcentaje
            Return MyBase.Channel.Porcentaje(nro1, nro2)
        End Function
        
        Public Function PorcentajeAsync(ByVal nro1 As Double, ByVal nro2 As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.CalculadoraSoap.PorcentajeAsync
            Return MyBase.Channel.PorcentajeAsync(nro1, nro2)
        End Function
        
        Public Function Logaritmo(ByVal nro As Integer) As Double Implements ServiceReference1.CalculadoraSoap.Logaritmo
            Return MyBase.Channel.Logaritmo(nro)
        End Function
        
        Public Function LogaritmoAsync(ByVal nro As Integer) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.CalculadoraSoap.LogaritmoAsync
            Return MyBase.Channel.LogaritmoAsync(nro)
        End Function
    End Class
End Namespace