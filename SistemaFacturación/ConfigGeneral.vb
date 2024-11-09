﻿Imports System.Configuration
Public Class ConfigGeneral
    Private Sub BTN_RegresarConfig_Click(sender As Object, e As EventArgs) Handles BTN_RegresarConfig.Click
        M_Inicio.Show()
        Me.Close()
    End Sub

    Private Sub BTN_RspaldoDB_Click(sender As Object, e As EventArgs) Handles BTN_RspaldoDB.Click
        If MsgBox("¿Desea hacer el respaldo de la base de datos?", vbOKCancel + vbQuestion, "Confirmación") = MsgBoxResult.Ok Then
            Md_BackupDB.exportarDB()
        End If
    End Sub

    Private Sub CerrarApp_Click(sender As Object, e As EventArgs) Handles CerrarApp.Click
        If MsgBox("¿Desea cerra la aplicación?", vbOKOnly + vbQuestion, "Cerrar sistema") = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub BTN_Importar_Click(sender As Object, e As EventArgs) Handles BTN_Importar.Click
        If MsgBox("¿Esta seguro de querer importar la base de datos? Se cambiará la información de la bd y no se podrá recuperar si hay un error", vbOKCancel + vbQuestion, "Confirmación") = MsgBoxResult.Ok Then
            If MsgBox("Esta verdaderamente seguro de querer hacer cambio? Esta accion no es reversible", vbOKCancel + vbQuestion, "Confirmación") = MsgBoxResult.Ok Then
                If MsgBox("Ultima comprobación, si presionas OK la base de datos será actualizada a lo que esté en el respaldo", vbOKCancel + vbQuestion, "Confirmación") = MsgBoxResult.Ok Then
                    If OFD_ImportarDB.ShowDialog() = DialogResult.OK Then
                        If Not OFD_ImportarDB.FileName = "" Then
                            Dim NuevaDB As String = OFD_ImportarDB.FileName
                            Md_BackupDB.importarDB(NuevaDB)
                            MsgBox("Se importó la base de datos correctamente", vbOKCancel + vbQuestion, "Importación completada")
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BTN_ModBackupDir_Click(sender As Object, e As EventArgs) Handles BTN_ModBackupDir.Click
        If OFD_ModBackUpDIr.ShowDialog() = DialogResult.OK Then
            Dim folderPath As String = IO.Path.GetDirectoryName(OFD_ModBackUpDIr.FileName)
            Md_Inicializacion.SetAppSetting("DirectorioRespaldo", folderPath)
            MessageBox.Show("Carpeta seleccionada: " & folderPath)
        End If
    End Sub

    Private Sub BTN_ModDirectorioDB_Click(sender As Object, e As EventArgs) Handles BTN_ModConnDB.Click
        OFD_ModDirDB.Title = "Seleccione un archivo de Access"
        OFD_ModDirDB.FileName = String.Empty ' Asegurarse de que FileName esté vacío inicialmente
        If OFD_ModDirDB.ShowDialog() = DialogResult.OK Then
            Dim folderPath As String = IO.Path.GetFullPath(OFD_ModDirDB.FileName)
            Md_Inicializacion.SetConnectionString("DbConnectionString", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & folderPath)
            MessageBox.Show("Conexión actualizada: " & folderPath)
        End If
    End Sub
End Class