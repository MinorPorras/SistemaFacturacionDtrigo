﻿Imports System.Threading.Tasks

Public Class B_Proveedor
    Friend caso As String
    Private searchTimer As Timer

    ' Método para inicializar el temporizador y otros componentes necesarios
    Private Sub InicializarComponentes()
        ' Inicializar el temporizador
        searchTimer = New Timer()
        searchTimer.Interval = 100
        ' Medio segundo
        AddHandler searchTimer.Tick, AddressOf OnSearchTimerTick
    End Sub

    Private Sub OnSearchTimerTick(sender As Object, e As EventArgs)
        ' Detener el temporizador y ejecutar la búsqueda
        searchTimer.Stop()
        REFRESCAR()
    End Sub
    Public Sub REFRESCAR()
        Task.Run(Sub()
                     Try
                         T.Tables.Clear()
                         SQL = "SELECT ID, codigo as [Código], nombre as [Nombre]" &
                             " FROM proveedor where codigo LIKE '%" & TXT_BuscarProv.Text & "%' " &
                             "OR nombre LIKE '%" & TXT_BuscarProv.Text & "%'"
                         Invoke(Sub()
                                    Cargar_Tabla(T, SQL)
                                    If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                        Dim bin As New BindingSource
                                        bin.DataSource = T.Tables(0)
                                        DGV_BProv.DataSource = bin
                                    Else ' Limpiar la fuente de datos si no se cargaron datos
                                        DGV_BProv.DataSource = Nothing
                                    End If
                                    TXT_BuscarProv.Select()

                                End Sub)
                     Catch ex As Exception
                         Invoke(Sub()
                                    If DGV_BProv.IsHandleCreated Then
                                        If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                                            ' Mostrar un mensaje de error genérico
                                            MsgBox("Error al cargar la lista de categorías: " & ex.Message, vbCritical + vbOKOnly, "Error")
                                        End If
                                    End If
                                End Sub)
                     End Try
                 End Sub)
    End Sub



    Private Sub BTN_RegresarMarca_Click(sender As Object, e As EventArgs) Handles BTN_RegresarProv.Click
        Me.Close()
    End Sub

    Private Sub DGV_BProv_DataBindingComplete_1(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_BProv.DataBindingComplete
        Try
            For i As Integer = 0 To DGV_BProv.Columns.Count - 1
                DGV_BProv.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_BProv.Columns(i).Width = 50
                    Case 2
                        DGV_BProv.Columns(i).Width = 200
                    Case 3
                        DGV_BProv.Columns(i).Width = 70
                End Select
            Next
            DGV_BProv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_BProv.GridColor = Color.DarkGray
            DGV_BProv.Columns(0).Visible = False
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
        End Try
    End Sub


    Private Sub BTN_NMarca_Click(sender As Object, e As EventArgs) Handles BTN_SelectProv.Click
        Try
            Select Case caso
                Case "Prod"
                    P_Productos.TXT_BuscarProv.Text = TXT_Nombre.Text
                    P_Productos.REFRESCAR()
                Case "NProd"
                    E_NuevoProducto.TXT_Proveedor.Text = TXT_Nombre.Text
                    E_NuevoProducto.LBL_Prov.Text = DGV_BProv.SelectedRows(0).Cells(0).Value.ToString()
            End Select
            Me.Close()
        Catch ex As Exception
            P_Productos.TXT_BuscarProv.Text = ""
            P_Productos.REFRESCAR()
            Me.Close()
        End Try

    End Sub

    Private Sub TXT_BuscarMarca_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProv.TextChanged
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub B_Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
        REFRESCAR()
    End Sub


    Private Sub DGV_BProv_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_BProv.SelectionChanged
        Try
            TXT_codigo.Text = DGV_BProv.SelectedRows(0).Cells(1).Value.ToString()
            TXT_Nombre.Text = DGV_BProv.SelectedRows(0).Cells(2).Value.ToString()
        Catch ex As Exception
            TXT_codigo.Text = ""
            TXT_Nombre.Text = ""
        End Try
    End Sub
End Class