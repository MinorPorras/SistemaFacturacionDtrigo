Imports System.Configuration

Module Md_VARIABLES_GLOBALES
    'Variables necesarias para guardar informaicón importante en todo el proyecto
    Public SQL As String
    Public T As New DataSet
    Public T1 As New DataSet
    Public T2 As New DataSet
    Public T3 As New DataSet
    Public T4 As New DataSet
    Public T5 As New DataSet

    Public Sub ActConfig(key As String, value As String)
        ' Load the configuration file
        Dim config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

        ' Se actualiza el valor de la config al nuevo
        If config.AppSettings.Settings(key) IsNot Nothing Then
            config.AppSettings.Settings(key).Value = value
        Else
            config.AppSettings.Settings.Add(key, value)
        End If

        'Se guarda y modifica el archivo
        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("appSettings")
    End Sub
End Module
