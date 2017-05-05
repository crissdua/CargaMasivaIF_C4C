Imports System.Net
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports System

Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSaldo.Click

        BtnSaldo.Enabled = False
        BtnExBodega.Enabled = False
        BtnHistServ.Enabled = False
        BtnUsoMaq.Enabled = False
        BtnSalir.Enabled = False

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
            BtnSaldo.Enabled = True
            BtnExBodega.Enabled = True
            BtnHistServ.Enabled = True
            BtnUsoMaq.Enabled = True
            BtnSalir.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            BtnSaldo.Enabled = True
            BtnExBodega.Enabled = True
            BtnHistServ.Enabled = True
            BtnUsoMaq.Enabled = True
            BtnSalir.Enabled = True
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnExBodega.Click
        BtnSaldo.Enabled = False
        BtnExBodega.Enabled = False
        BtnHistServ.Enabled = False
        BtnUsoMaq.Enabled = False
        BtnSalir.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnUsoMaq.Click

        BtnSaldo.Enabled = False
        BtnExBodega.Enabled = False
        BtnHistServ.Enabled = False
        BtnUsoMaq.Enabled = False
        BtnSalir.Enabled = False

        Dim objetoEscribir As New C4C_UsoMaquina.CreateResponse
        Dim leerrequest As New C4C_UsoMaquina.CreateRequest
        Dim cliente2 As New C4C_UsoMaquina.Y0ZJU4DVY_UsoMaquinaClient
        cliente2.ClientCredentials.UserName.UserName = "_VIEWS"
        cliente2.ClientCredentials.UserName.Password = "Welcome08"

        Dim request As IF_UsoMaquina.GetUsoMaquinaType = New IF_UsoMaquina.GetUsoMaquinaType
        Dim response As IF_UsoMaquina.GetUsoMaquinaResponseType = New IF_UsoMaquina.GetUsoMaquinaResponseType
        Dim cliente As New IF_UsoMaquina.ipostep_vP001sap0003in_WCSX_comsapb1ivplatformruntime_INB_WS_CALL_SYNC_XPT_INB_WS_CALL_SYNC_XPTipo_procClient
        cliente.ClientCredentials.UserName.UserName = "B1iRuntime"
        cliente.ClientCredentials.UserName.Password = "Welcome08"

        response = cliente.ZUsoMaquina(request)

        leerrequest.UsoMaquinaUsoMaquinaCreateRequest_sync = New C4C_UsoMaquina.UsoMaquinaUsoMaquinaCreateRequestMessage_sync
        leerrequest.UsoMaquinaUsoMaquinaCreateRequest_sync.UsoMaquina = New C4C_UsoMaquina.UsoMaquinaUsoMaquinaCreateRequest
        objetoEscribir.UsoMaquinaUsoMaquinaCreateConfirmation_sync = New C4C_UsoMaquina.UsoMaquinaUsoMaquinaCreateConfirmationMessage_sync
        leerrequest.UsoMaquinaUsoMaquinaCreateRequest_sync.UsoMaquina.ItemName = New C4C_UsoMaquina.Text
        leerrequest.UsoMaquinaUsoMaquinaCreateRequest_sync.UsoMaquina.Odometro = New C4C_UsoMaquina.Text

        Try

            For Each a As IF_UsoMaquina.GetUsoMaquinaResponseTypeRow In response.GetUsoMaquinaResult
                leerrequest.UsoMaquinaUsoMaquinaCreateRequest_sync.UsoMaquina.Entry = a.Serie
                leerrequest.UsoMaquinaUsoMaquinaCreateRequest_sync.UsoMaquina.ItemName.Value = a.ItemName
                leerrequest.UsoMaquinaUsoMaquinaCreateRequest_sync.UsoMaquina.Odometro.Value = a.Odometro
                objetoEscribir.UsoMaquinaUsoMaquinaCreateConfirmation_sync = cliente2.Create(leerrequest.UsoMaquinaUsoMaquinaCreateRequest_sync)
            Next
            BtnSaldo.Enabled = True
            BtnExBodega.Enabled = True
            BtnHistServ.Enabled = True
            BtnUsoMaq.Enabled = True
            BtnSalir.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            BtnSaldo.Enabled = True
            BtnExBodega.Enabled = True
            BtnHistServ.Enabled = True
            BtnUsoMaq.Enabled = True
            BtnSalir.Enabled = True
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnHistServ.Click
        BtnSaldo.Enabled = False
        BtnExBodega.Enabled = False
        BtnHistServ.Enabled = False
        BtnUsoMaq.Enabled = False
        BtnSalir.Enabled = False

        Dim objetoEscribir As New C4C_HistServ.CreateResponse
        Dim leerrequest As New C4C_HistServ.CreateRequest

        Dim request As IF_HistServ.HistorialDeServType = New IF_HistServ.HistorialDeServType
        Dim response As IF_HistServ.HistorialDeServResponseType = New IF_HistServ.HistorialDeServResponseType
        Dim cliente As New IF_HistServ.ipostep_vP001sap0003in_WCSX_comsapb1ivplatformruntime_INB_WS_CALL_SYNC_XPT_INB_WS_CALL_SYNC_XPTipo_procClient
        cliente.ClientCredentials.UserName.UserName = "B1iRuntime"
        cliente.ClientCredentials.UserName.Password = "Welcome08"

        response = cliente.ZHistorialDeServ(request)
        leerrequest.HistServHistServCreateRequest_sync = New C4C_HistServ.HistServHistServCreateRequestMessage_sync
        leerrequest.HistServHistServCreateRequest_sync.HistServ = New C4C_HistServ.HistServHistServCreateRequest
        objetoEscribir.HistServHistServCreateConfirmation_sync = New C4C_HistServ.HistServHistServCreateConfirmationMessage_sync
        leerrequest.HistServHistServCreateRequest_sync.HistServ.CodCliente = New C4C_HistServ.Text
        leerrequest.HistServHistServCreateRequest_sync.HistServ.NomCliente = New C4C_HistServ.Text
        leerrequest.HistServHistServCreateRequest_sync.HistServ.CodMaquina = New C4C_HistServ.Text
        leerrequest.HistServHistServCreateRequest_sync.HistServ.DesMaquina = New C4C_HistServ.Text
        leerrequest.HistServHistServCreateRequest_sync.HistServ.CodItem = New C4C_HistServ.Text
        leerrequest.HistServHistServCreateRequest_sync.HistServ.DesItem = New C4C_HistServ.Text
        leerrequest.HistServHistServCreateRequest_sync.HistServ.CantItem = New C4C_HistServ.Text
        leerrequest.HistServHistServCreateRequest_sync.HistServ.NumFactura = New C4C_HistServ.Text
        leerrequest.HistServHistServCreateRequest_sync.HistServ.FechaFactura = New C4C_HistServ.Text
        Dim cliente2 As New C4C_HistServ.Y0ZJU4DVY_HistServClient
        cliente2.ClientCredentials.UserName.UserName = "_VIEWS"
        cliente2.ClientCredentials.UserName.Password = "Welcome08"

        Try
            For Each a As IF_HistServ.HistorialDeServResponseTypeRow In response.HistorialDeServResult
                leerrequest.HistServHistServCreateRequest_sync.HistServ.Entry = a.Entry
                leerrequest.HistServHistServCreateRequest_sync.HistServ.CodCliente.Value = a.CardCode
                leerrequest.HistServHistServCreateRequest_sync.HistServ.NomCliente.Value = a.CardName
                leerrequest.HistServHistServCreateRequest_sync.HistServ.CodMaquina.Value = a.Serie
                leerrequest.HistServHistServCreateRequest_sync.HistServ.DesMaquina.Value = a.Dscription
                leerrequest.HistServHistServCreateRequest_sync.HistServ.CodItem.Value = a.ItemCode
                leerrequest.HistServHistServCreateRequest_sync.HistServ.DesItem.Value = a.ItemName
                leerrequest.HistServHistServCreateRequest_sync.HistServ.CantItem.Value = a.Quantity
                leerrequest.HistServHistServCreateRequest_sync.HistServ.NumFactura.Value = a.DocNum
                leerrequest.HistServHistServCreateRequest_sync.HistServ.FechaFactura.Value = a.DocDate
                objetoEscribir.HistServHistServCreateConfirmation_sync = cliente2.Create(leerrequest.HistServHistServCreateRequest_sync)
            Next
            BtnSaldo.Enabled = True
            BtnExBodega.Enabled = True
            BtnHistServ.Enabled = True
            BtnUsoMaq.Enabled = True
            BtnSalir.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            BtnSaldo.Enabled = True
            BtnExBodega.Enabled = True
            BtnHistServ.Enabled = True
            BtnUsoMaq.Enabled = True
            BtnSalir.Enabled = True
        End Try
    End Sub
End Class
