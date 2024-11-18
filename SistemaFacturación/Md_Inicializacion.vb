Imports System.Configuration

Module Md_Inicializacion

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

    Function ObtenerConnectionString(name As String) As String
        ' Acceder a la conexión desde el archivo de configuración
        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings(name)

        ' Comprobar si existe la configuración
        If settings IsNot Nothing Then
            Return settings.ConnectionString
        Else
            Return String.Empty ' O devolver un mensaje de error o valor por defecto
        End If
    End Function


End Module
