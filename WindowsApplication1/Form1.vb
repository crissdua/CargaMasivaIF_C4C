Imports OASP_C.ExBodegaService
Imports System.Linq
Imports System.Net
Imports System.Text
Imports System.Windows.Forms
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.IO
Imports System.Xml.Linq
Imports System.Xml
Imports System.Collections
Imports System
Imports System.Net.Security
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Security.Cryptography.X509Certificates

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button1.Enabled = False
        Button2.Enabled = False
        Dim objetoEscribir2 As New C4C_SaldoClientesB.CreateResponse
        Dim leerrequest2 As New C4C_SaldoClientesB.CreateRequest

        Dim objetoEscribir As New C4C_SaldoClientesV.CreateResponse
        Dim leerrequest As New C4C_SaldoClientesV.CreateRequest

        Dim request As IF_SaldoClientesV.SaldoClientesVType = New IF_SaldoClientesV.SaldoClientesVType
        Dim response As IF_SaldoClientesV.SaldoClientesVResponseType = New IF_SaldoClientesV.SaldoClientesVResponseType
        Dim cliente As New IF_SaldoClientesV.ipostep_vP001sap0003in_WCSX_comsapb1ivplatformruntime_INB_WS_CALL_SYNC_XPT_INB_WS_CALL_SYNC_XPTipo_procClient
        cliente.ClientCredentials.UserName.UserName = "B1iRuntime"
        cliente.ClientCredentials.UserName.Password = "Welcome08"

        response = cliente.ZSaldoClientesV(request)
        leerrequest2.ClientesBClientesBCreateRequest_sync = New C4C_SaldoClientesB.ClientesBClientesBCreateRequestMessage_sync
        leerrequest2.ClientesBClientesBCreateRequest_sync.ClientesB = New C4C_SaldoClientesB.ClientesBClientesBCreateRequest
        objetoEscribir2.ClientesBClientesBCreateConfirmation_sync = New C4C_SaldoClientesB.ClientesBClientesBCreateConfirmationMessage_sync
        leerrequest2.ClientesBClientesBCreateRequest_sync.ClientesB.Nombre = New C4C_SaldoClientesB.Text
        leerrequest2.ClientesBClientesBCreateRequest_sync.ClientesB.Saldo = New C4C_SaldoClientesB.Text


        leerrequest.ClientesVClientesVCreateRequest_sync = New C4C_SaldoClientesV.ClientesVClientesVCreateRequestMessage_sync
        leerrequest.ClientesVClientesVCreateRequest_sync.ClientesV = New C4C_SaldoClientesV.ClientesVClientesVCreateRequest
        objetoEscribir.ClientesVClientesVCreateConfirmation_sync = New C4C_SaldoClientesV.ClientesVClientesVCreateConfirmationMessage_sync
        leerrequest.ClientesVClientesVCreateRequest_sync.ClientesV.Nombre = New C4C_SaldoClientesV.Text
        leerrequest.ClientesVClientesVCreateRequest_sync.ClientesV.Saldo = New C4C_SaldoClientesV.Quantity


        Dim cliente2 As New C4C_SaldoClientesV.Y0ZJU4DVY_ClientesVClient
        cliente2.ClientCredentials.UserName.UserName = "_VIEWS"
        cliente2.ClientCredentials.UserName.Password = "Welcome08"

        Dim cliente3 As New C4C_SaldoClientesB.Y0ZJU4DVY_ClientesBClient
        cliente3.ClientCredentials.UserName.UserName = "_VIEWS"
        cliente3.ClientCredentials.UserName.Password = "Welcome08"
        Try

            For Each a As IF_SaldoClientesV.SaldoClientesVResponseTypeRow In response.SaldoClientesVResult
                leerrequest.ClientesVClientesVCreateRequest_sync.ClientesV.Entry = a.CardCode
                leerrequest.ClientesVClientesVCreateRequest_sync.ClientesV.Nombre.Value = a.CardName
                leerrequest.ClientesVClientesVCreateRequest_sync.ClientesV.Saldo.Value = a.Balance
                objetoEscribir.ClientesVClientesVCreateConfirmation_sync = cliente2.Create(leerrequest.ClientesVClientesVCreateRequest_sync)
                DataGridView1.Rows.Add(New String() {a.CardCode, a.CardName, a.Balance})
                If a.Balance > 0 Then
                    leerrequest2.ClientesBClientesBCreateRequest_sync.ClientesB.Entry = a.CardCode
                    leerrequest2.ClientesBClientesBCreateRequest_sync.ClientesB.Nombre.Value = a.CardName
                    leerrequest2.ClientesBClientesBCreateRequest_sync.ClientesB.Saldo.Value = "TRUE"
                    objetoEscribir2.ClientesBClientesBCreateConfirmation_sync = cliente3.Create(leerrequest2.ClientesBClientesBCreateRequest_sync)
                Else
                    leerrequest2.ClientesBClientesBCreateRequest_sync.ClientesB.Entry = a.CardCode
                    leerrequest2.ClientesBClientesBCreateRequest_sync.ClientesB.Nombre.Value = a.CardName
                    leerrequest2.ClientesBClientesBCreateRequest_sync.ClientesB.Saldo.Value = "FALSE"
                    objetoEscribir2.ClientesBClientesBCreateConfirmation_sync = cliente3.Create(leerrequest2.ClientesBClientesBCreateRequest_sync)
                End If

            Next
            Button2.Enabled = Enabled
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
