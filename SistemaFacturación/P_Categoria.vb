﻿Imports System.Threading.Tasks

Public Class P_Categoria
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
    Private Sub CerrarApp_Click(sender As Object, e As EventArgs) Handles CerrarApp.Click
        If MsgBox("¿Desea cerra la aplicación?", vbOKCancel + vbQuestion, "Cerrar sistema") = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub BTN_RegresarCat_Click(sender As Object, e As EventArgs) Handles BTN_RegresarCat.Click
        M_Mantenimiento.Show()
        Me.Close()
    End Sub

    Private Sub P_Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
        REFRESCAR()
    End Sub

    Public Sub REFRESCAR()
        Task.Run(Sub()
                     Try
                         T.Tables.Clear()
                         MNU_ELIMINAR.Visible = False
                         MNU_MODIFICAR.Visible = False
                         SQL = "SELECT ID, codigo AS [Código], nombre AS [Nombre], color AS [Color] " &
                                  "FROM categoria " &
                                  "WHERE codigo LIKE '%" & TXT_BuscarCat.Text & "%' " &
                                  "OR nombre LIKE '%" & TXT_BuscarCat.Text & "%' " &
                                  ";"
                         Invoke(Sub()
                                    Cargar_Tabla(T, SQL)
                                    If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                        DGV_Categoria.Columns.Clear()
                                        Dim bin As New BindingSource
                                        bin.DataSource = T.Tables(0)
                                        DGV_Categoria.DataSource = bin
                                        If T.Tables(0).Rows.Count > 0 Then
                                            MNU_ELIMINAR.Visible = True
                                            MNU_MODIFICAR.Visible = True
                                        End If
                                    Else ' Limpiar la fuente de datos si no se cargaron datos
                                        DGV_Categoria.DataSource = Nothing
                                    End If
                                    AddHandler DGV_Categoria.DataBindingComplete, AddressOf DGV_Categoria_DataBindingComplete
                                    TXT_BuscarCat.Select()
                                End Sub)
                     Catch ex As Exception
                         Invoke(Sub()
                                    If DGV_Categoria.IsHandleCreated Then
                                        If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                                            ' Mostrar un mensaje de error genérico
                                            MsgBox("Error al cargar la lista de categorías: " & ex.Message, vbCritical + vbOKOnly, "Error")
                                        End If
                                    End If
                                End Sub)

                     End Try
                 End Sub)
    End Sub


    Private Sub DGV_Categoria_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_Categoria.DataBindingComplete
        Try
            For i As Integer = 0 To DGV_Categoria.Columns.Count - 1
                DGV_Categoria.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_Categoria.Columns(i).Width = 50
                    Case 2
                        DGV_Categoria.Columns(i).Width = 200
                    Case 3
                        DGV_Categoria.Columns(i).Width = 70
                End Select
            Next

            For i As Integer = 0 To DGV_Categoria.Rows.Count - 1
                If DGV_Categoria.Rows(i).Cells(3).Value IsNot Nothing Then
                    Dim col As String() = DGV_Categoria.Rows(i).Cells(3).Value.ToString().Split(","c)
                    ' Convertir los valores RGB a enteros
                    Dim r As Integer = Convert.ToInt32(col(0).Trim())
                    Dim g As Integer = Convert.ToInt32(col(1).Trim())
                    Dim b As Integer = Convert.ToInt32(col(2).Trim())

                    DGV_Categoria.Rows(i).Cells(3).Style.BackColor = Color.FromArgb(r, g, b)
                    DGV_Categoria.Rows(i).Cells(3).Style.ForeColor = Color.FromArgb(r, g, b)
                    DGV_Categoria.Rows(i).Cells(3).Style.SelectionBackColor = Color.FromArgb(r, g, b)
                    DGV_Categoria.Rows(i).Cells(3).Style.SelectionForeColor = Color.FromArgb(r, g, b)
                End If
            Next


            DGV_Categoria.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_Categoria.GridColor = Color.DarkGray
            DGV_Categoria.Columns(0).Visible = False
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
        End Try
    End Sub

    Private Sub TXT_BuscarCat_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarCat.TextChanged
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub BTN_NCat_Click(sender As Object, e As EventArgs) Handles BTN_NCat.Click
        E_NuevaCategoria.ModCat = False
        E_NuevaCategoria.Show()
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        E_NuevaCategoria.ModCat = True
        Try
            E_NuevaCategoria.CodigoPreMod = DGV_Categoria.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevaCategoria.idCat = DGV_Categoria.SelectedRows(0).Cells(0).Value.ToString()
            E_NuevaCategoria.TXT_CodCat.Text = DGV_Categoria.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevaCategoria.TXT_NombreCat.Text = DGV_Categoria.SelectedRows(0).Cells(2).Value.ToString()
            Dim rgbValues() = DGV_Categoria.SelectedRows(0).Cells(3).Value.ToString().Split(",")
            Dim red As Integer = Convert.ToInt32(rgbValues(0))
            Dim green As Integer = Convert.ToInt32(rgbValues(1))
            Dim blue As Integer = Convert.ToInt32(rgbValues(2))
            E_NuevaCategoria.BTN_Color.FillColor = Color.FromArgb(red, green, blue)
            E_NuevaCategoria.ColorDialog1.Color = Color.FromArgb(red, green, blue)
            E_NuevaCategoria.ColorCat = DGV_Categoria.SelectedRows(0).Cells(3).Value.ToString()
            E_NuevaCategoria.ModCat = True
            E_NuevaCategoria.Show()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
            E_NuevaCategoria.Show()
        End Try

    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        T1.Tables.Clear()
        Try
            If DGV_Categoria.SelectedRows.Count > 0 Then
                ' Se pregunta una confirmación para eliminar el tema
                If MsgBox("¿Desea eliminar la categoria: " & DGV_Categoria.SelectedRows(0).Cells(2).Value.ToString() & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idSucEliminar As Integer = Convert.ToInt32(DGV_Categoria.SelectedRows(0).Cells(0).Value.ToString())
                    ' Verificar si hay categorías asociadas
                    SQL = "SELECT COUNT(ID) FROM categoria WHERE ID = " & idSucEliminar
                    Cargar_Tabla(T, SQL)

                    If T.Tables(0).Rows(0).Item(0) <> 0 Then
                        'Se elimina
                        SQL = "DELETE FROM categoria WHERE ID = " & idSucEliminar
                        If EJECUTAR(SQL) Then
                            REFRESCAR()
                            MsgBox("La categoría fue eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
                        End If
                    Else
                        MsgBox("La categoria no existe", vbExclamation, "Error")
                    End If
                End If
            Else
                MsgBox("Seleccione una categoria para eliminar.", vbInformation + vbOKOnly, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar la categoria: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub
End Class