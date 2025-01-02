Imports System.Configuration
Imports System.IO

Module Md_Inicializacion
    Public Sub CheckForUpdates()
        ' Ruta completa del archivo setup.exe
        Dim setupFile As String = "C:\SisFactUtilidades\SisFactIntaller\setup.exe"

        ' Verificar si existe el archivo setup.exe en la ruta de actualización
        If File.Exists(setupFile) Then
            ' Obtener la versión actual de la aplicación
            Dim currentVersion As Version = New Version(Application.ProductVersion)
            ' Obtener la versión del archivo setup.exe
            Dim setupFileInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(setupFile)
            Dim setupFileVersion As String = setupFileInfo.FileVersion

            ' Validar que la cadena de versión sea válida
            Dim updateVersion As Version = Nothing
            If Version.TryParse(setupFileVersion, updateVersion) Then
                ' Comparar versiones para determinar si hay una nueva versión disponible
                If updateVersion > currentVersion Then
                    ' Preguntar al usuario si desea actualizar
                    If MessageBox.Show("Hay una nueva versión disponible. ¿Deseas actualizar?", "Actualización Disponible", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        ApplyUpdate(setupFile)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ApplyUpdate(setupFile As String)
        ' Ejecutar el instalador de la nueva versión
        Process.Start(setupFile)

        ' Cerrar la aplicación actual para permitir la actualización
        Application.Exit()
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

    Function GetAppSetting(key As String) As String
        ' Obtener el valor de la clave especificada
        Dim value As String = ConfigurationManager.AppSettings.Get(key)
        Return value
    End Function


    Sub SetConnectionString(name As String, connectionString As String)
        ' Abrir el archivo de configuración
        Dim config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

        ' Modificar el valor del connection string especificado
        If config.ConnectionStrings.ConnectionStrings("conexionString") IsNot Nothing Then
            config.ConnectionStrings.ConnectionStrings("conexionString").ConnectionString = connectionString
        Else
            config.ConnectionStrings.ConnectionStrings.Add(New ConnectionStringSettings("conexionString", connectionString))
        End If

        ' Guardar los cambios y refrescar la sección
        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("connectionStrings")
    End Sub

    Function ObtenerConnectionString(name As String) As String
        ' Acceder a la conexión desde el archivo de configuración
        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("conexionString")

        ' Comprobar si existe la configuración
        If settings IsNot Nothing Then
            Return settings.ConnectionString
        Else
            Return String.Empty ' O devolver un mensaje de error o valor por defecto
        End If
    End Function

    Public Sub entrarConfig(index As Integer)
        ConfigGeneral.Show()
        ConfigGeneral.Select()
        ConfigGeneral.TCO_Config.SelectedIndex = index
    End Sub
End Module
