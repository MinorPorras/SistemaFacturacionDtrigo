Imports System.Configuration

Module Md_Inicializacion
    Friend Sub main()
        Dim rutaRaiz As String = AppDomain.CurrentDomain.BaseDirectory
        If Not (ConfigurationManager.AppSettings("DirectorioRespaldo") = rutaRaiz + "bd\backupDB\") Then
            SetAppSetting("DirectorioRespaldo", rutaRaiz + "bd\backupDB\")
        End If
        'If Not (ConfigurationManager.ConnectionStrings("DbConnectionString").ToString() = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaRaiz + "bd\dbSistemaFactiracion.accdb") Then
        '    SetConnectionString("DbConnectionString", rutaRaiz + "bd\dbSistemaFactiracion.accdb")
        'End If
    End Sub

    Sub SetAppSetting(key As String, value As String)
        ' Abrir el archivo de configuración
        Dim config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

        ' Modificar el valor de la clave especificada
        If config.AppSettings.Settings(key) IsNot Nothing Then
            config.AppSettings.Settings(key).Value = value
        Else
            config.AppSettings.Settings.Add(key, value)
        End If

        ' Guardar los cambios y refrescar la sección
        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("appSettings")
    End Sub

    Sub SetConnectionString(name As String, connectionString As String)
        ' Abrir el archivo de configuración
        Dim config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

        ' Modificar el valor del connection string especificado
        If config.ConnectionStrings.ConnectionStrings(name) IsNot Nothing Then
            config.ConnectionStrings.ConnectionStrings(name).ConnectionString = connectionString
        Else
            config.ConnectionStrings.ConnectionStrings.Add(New ConnectionStringSettings(name, connectionString))
        End If

        ' Guardar los cambios y refrescar la sección
        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("connectionStrings")
    End Sub

End Module
