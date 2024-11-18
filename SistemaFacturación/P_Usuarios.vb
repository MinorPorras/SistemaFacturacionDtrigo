﻿
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class P_Usuarios
    Private Sub P_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RDB_BuscarNombre.Checked = True
        REFRESCAR()
    End Sub

    Private Sub CerrarApp_Click(sender As Object, e As EventArgs) Handles CerrarApp.Click
        If MsgBox("¿Desea cerra la aplicación?", vbOKCancel + vbQuestion, "Cerrar sistema") = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub
    Public Sub REFRESCAR()
        Try
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False
            T.Tables.Clear()

            If RDB_BuscarCodigo.Checked = True Then
                SQL = "SELECT u.ID, u.codigo as [Código], u.usuario as [Cajero], u.clave, " &
                      "IIf(u.tipo=0, 'Cajero', IIf(u.tipo=1, 'Administrador', 'Desconocido')) AS [Tipo], u.color as [Color] " &
                      "FROM usuario u WHERE u.codigo LIKE '%" & TXT_BuscarUsuario.Text & "%' ORDER BY Val(u.codigo) ASC;"
            Else
                SQL = "SELECT u.ID, u.codigo as [Código], u.usuario as [Cajero], u.clave, " &
                      "IIf(u.tipo=0, 'Cajero', IIf(u.tipo=1, 'Administrador', 'Desconocido')) AS [Tipo], u.color as [Color] " &
                      "FROM usuario u WHERE u.usuario LIKE '%" & TXT_BuscarUsuario.Text & "%' ORDER BY Val(u.codigo) ASC;"
            End If

            Cargar_Tabla(T, SQL)
            Dim bin As New BindingSource
            bin.DataSource = T.Tables(0)
            DGV_Cajero.DataSource = bin

            ' Añadir el manejador del evento DataBindingComplete antes de cargar los datos
            AddHandler DGV_Cajero.DataBindingComplete, AddressOf DGV_Cajero_DataBindingComplete

            If T.Tables(0).Rows.Count > 0 Then
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If

            TXT_BuscarUsuario.Select()

        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de categorías: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try
    End Sub


    Private Sub DGV_Cajero_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_Cajero.DataBindingComplete
        Try
            For i As Integer = 0 To DGV_Cajero.Columns.Count - 1
                DGV_Cajero.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_Cajero.Columns(i).Width = 20
                    Case 2
                        DGV_Cajero.Columns(i).Width = 100
                    Case 4
                        DGV_Cajero.Columns(i).Width = 100
                    Case 5
                        DGV_Cajero.Columns(i).Width = 200
                End Select
            Next

            For Each row As DataGridViewRow In DGV_Cajero.Rows
                If row.Cells(5).Value IsNot Nothing Then
                    Dim col As String() = row.Cells(5).Value.ToString().Split(","c)
                    If col.Length = 3 Then
                        ' Convertir los valores RGB a enteros
                        Dim r As Integer = Convert.ToInt32(col(0).Trim())
                        Dim g As Integer = Convert.ToInt32(col(1).Trim())
                        Dim b As Integer = Convert.ToInt32(col(2).Trim())

                        row.Cells(5).Style.BackColor = Color.FromArgb(r, g, b)
                        row.Cells(5).Style.ForeColor = Color.FromArgb(r, g, b)
                        row.Cells(5).Style.SelectionBackColor = Color.FromArgb(r, g, b)
                        row.Cells(5).Style.SelectionForeColor = Color.FromArgb(r, g, b)
                    End If
                End If
            Next

            DGV_Cajero.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_Cajero.GridColor = Color.DarkGray
            DGV_Cajero.Columns(0).Visible = False
            DGV_Cajero.Columns(3).Visible = False
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
        End Try
    End Sub



    Private Sub BTN_RegresarUsu_Click(sender As Object, e As EventArgs) Handles BTN_RegresarUsu.Click
        M_Mantenimiento.Show()
        Me.Close()
    End Sub

    Private Sub BTN_NUsuario_Click(sender As Object, e As EventArgs) Handles BTN_NUsuario.Click
        E_NuevoUsuario.ModUsu = False
        E_NuevoUsuario.Show()
    End Sub

    Private Sub TXT_BuscarUsuario_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarUsuario.TextChanged
        REFRESCAR()
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        T1.Tables.Clear()
        Try
            If DGV_Cajero.SelectedRows.Count > 0 Then
                ' Se pregunta una confirmación para eliminar el tema
                If MsgBox("¿Desea eliminar el usuario: " & DGV_Cajero.SelectedRows(0).Cells(2).Value.ToString() & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idSucEliminar As Integer = Convert.ToInt32(DGV_Cajero.SelectedRows(0).Cells(0).Value.ToString())
                    ' Verificar si hay categorías asociadas
                    SQL = "SELECT COUNT(ID) FROM usuario WHERE ID = " & idSucEliminar
                    Cargar_Tabla(T, SQL)

                    If T.Tables(0).Rows(0).Item(0) <> 0 Then
                        'Se elimina
                        SQL = "DELETE FROM usuario WHERE ID = " & idSucEliminar
                        EJECUTAR(SQL)
                        REFRESCAR()
                        MsgBox("El usuario fue eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
                    Else
                        MsgBox("El usuario no existe", vbExclamation, "Error")
                    End If
                End If
            Else
                MsgBox("Seleccione un usuario para eliminar.", vbInformation + vbOKOnly, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar El usuario: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            E_NuevoUsuario.idUsuario = DGV_Cajero.SelectedRows(0).Cells(0).Value.ToString()
            E_NuevoUsuario.TXT_CodUsuario.Text = DGV_Cajero.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevoUsuario.TXT_NombreUsuario.Text = DGV_Cajero.SelectedRows(0).Cells(2).Value.ToString()
            E_NuevoUsuario.TXT_ClaveUsuario.Text = DGV_Cajero.SelectedRows(0).Cells(3).Value.ToString()
            If DGV_Cajero.SelectedRows(0).Cells(4).Value = "Administrador" Then
                E_NuevoUsuario.CBX_tipoCuenta.SelectedIndex = 1
            Else
                E_NuevoUsuario.CBX_tipoCuenta.SelectedIndex = 0
            End If

            Dim rgbValues() = DGV_Cajero.SelectedRows(0).Cells(5).Value.ToString().Split(",")
            Dim red As Integer = Convert.ToInt32(rgbValues(0))
            Dim green As Integer = Convert.ToInt32(rgbValues(1))
            Dim blue As Integer = Convert.ToInt32(rgbValues(2))
            E_NuevoUsuario.BTN_Color.FillColor = Color.FromArgb(red, green, blue)
            E_NuevoUsuario.ColorDialog1.Color = Color.FromArgb(red, green, blue)
            E_NuevoUsuario.ColorUsuario = DGV_Cajero.SelectedRows(0).Cells(5).Value.ToString()
            If String.IsNullOrEmpty(DGV_Cajero.SelectedRows(0).Cells(3).Value.ToString()) Then
                E_NuevoUsuario.CBK_NoClaveUsu.Checked = True
            Else
                E_NuevoUsuario.CBK_NoClaveUsu.Checked = False
            End If
            E_NuevoUsuario.ModUsu = True
            E_NuevoUsuario.CodigoPreMod = DGV_Cajero.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevoUsuario.Show()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub RDB_BuscarNombre_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarNombre.CheckedChanged
        REFRESCAR()
        TXT_BuscarUsuario.Focus()
    End Sub

    Private Sub RDB_BuscarCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarCodigo.CheckedChanged
        REFRESCAR()
        TXT_BuscarUsuario.Focus()
    End Sub
End Class