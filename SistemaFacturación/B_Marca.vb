﻿Imports System.Threading.Tasks

Public Class B_Marca
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
                             " FROM marca where codigo LIKE '%" & TXT_BuscarMarca.Text & "%'" &
                             " OR nombre LIKE '%" & TXT_BuscarMarca.Text & "%' ORDER BY Val(codigo) ASC"
                         Invoke(Sub()
                                    Cargar_Tabla(T, SQL)
                                    If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                        Dim bin As New BindingSource
                                        bin.DataSource = T.Tables(0)
                                        DGV_BMarca.DataSource = bin
                                    Else ' Limpiar la fuente de datos si no se cargaron datos
                                        DGV_BMarca.DataSource = Nothing
                                    End If
                                    TXT_BuscarMarca.Select()
                                End Sub)
                     Catch ex As Exception
                         Invoke(Sub()
                                    If DGV_BMarca.IsHandleCreated Then
                                        If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                                            ' Mostrar un mensaje de error genérico
                                            MsgBox("Error al cargar la lista de categorías: " & ex.Message, vbCritical + vbOKOnly, "Error")
                                        End If
                                    End If
                                End Sub)
                     End Try
                 End Sub)
    End Sub

    Private Sub DGV_BMarca_DataBindingComplete_1(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_BMarca.DataBindingComplete
        Try
            For i As Integer = 0 To DGV_BMarca.Columns.Count - 1
                DGV_BMarca.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_BMarca.Columns(i).Width = 50
                    Case 2
                        DGV_BMarca.Columns(i).Width = 200
                    Case 3
                        DGV_BMarca.Columns(i).Width = 70
                End Select
            Next
            DGV_BMarca.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_BMarca.GridColor = Color.DarkGray
            DGV_BMarca.Columns(0).Visible = False
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_RegresarMarca_Click(sender As Object, e As EventArgs) Handles BTN_RegresarMarca.Click
        Me.Close()
    End Sub

    Private Sub BTN_NMarca_Click(sender As Object, e As EventArgs) Handles BTN_SelectMarca.Click
        Try
            Select Case caso
                Case "Prod"
                    P_Productos.TXT_BuscarMarca.Text = TXT_Nombre.Text
                    P_Productos.REFRESCAR()
                Case "NProd"
                    E_NuevoProducto.TXT_Marca.Text = TXT_Nombre.Text
                    E_NuevoProducto.LBL_IDMarca.Text = DGV_BMarca.SelectedRows(0).Cells(0).Value.ToString()

            End Select

            Me.Close()
        Catch ex As Exception
            P_Productos.TXT_BuscarMarca.Text = ""
            P_Productos.REFRESCAR()
            Me.Close()
        End Try
    End Sub

    Private Sub TXT_BuscarMarca_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarMarca.TextChanged
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub B_Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
        REFRESCAR()
    End Sub

    Private Sub DGV_BMarca_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_BMarca.SelectionChanged
        Try
            TXT_codigo.Text = DGV_BMarca.SelectedRows(0).Cells(1).Value.ToString()
            TXT_Nombre.Text = DGV_BMarca.SelectedRows(0).Cells(2).Value.ToString()
        Catch ex As Exception
            TXT_codigo.Text = ""
            TXT_Nombre.Text = ""
        End Try
    End Sub
End Class