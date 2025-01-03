Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data.SQLite
Imports System.Threading.Tasks
Imports System.Windows.Forms

Module Md_CONEXION

#Region "Conexion"

    Private db As SQLiteConnection
    Public T As New DataSet
    Public T1 As New DataSet
    Public T2 As New DataSet
    Public T3 As New DataSet
    Public T4 As New DataSet
    Public T5 As New DataSet
    Public idUsuActual As Integer
    Public nomUsuActual As String
    Public CuentaAdmin As Boolean
    Public SQL As String
    Public stringConexion As String

    Public Sub CONECTAR()
        Try
            Dim stringConexion As String = ConfigurationManager.ConnectionStrings("conexionString").ConnectionString
            db = New SQLiteConnection(stringConexion)
            If db Is Nothing Or db.State = ConnectionState.Closed Then
                db.Open()
            End If
            Console.WriteLine("Conexión abierta. Ruta de la base de datos: " & db.DataSource)
        Catch ex As Exception
            Console.WriteLine("Error al conectarse a la base de datos: " & ex.Message)
        End Try
    End Sub

    Public Sub DESCONECTAR()
        Try
            If db IsNot Nothing AndAlso db.State = ConnectionState.Open Then
                db.Close()
                Console.WriteLine("Conexión cerrada correctamente.")
            Else
                Console.WriteLine("La conexión ya está cerrada o no fue inicializada.")
            End If
        Catch ex As Exception
            Console.WriteLine("Error al desconectar: " & ex.Message & " StackTrace: " & ex.StackTrace)
        End Try
    End Sub


#End Region

#Region "Interaccion"
    Public Sub CargarTablaParam(ByVal t As DataSet, ByVal consulta As String, ByVal parametros As List(Of SQLiteParameter))
        CONECTAR()
        Using cmd As New SQLiteCommand(consulta, db)
            If parametros IsNot Nothing Then
                For Each param As SQLiteParameter In parametros
                    cmd.Parameters.Add(param)
                    Console.WriteLine("Parámetro añadido: " & param.ParameterName & " = " & param.Value)
                Next
            End If
            Console.WriteLine("Ejecutando consulta: " & consulta)
            Using da As New SQLiteDataAdapter(cmd)
                da.Fill(t)
            End Using
        End Using
        Console.WriteLine("Datos cargados: " & t.Tables(0).Rows.Count & " filas.")
        DESCONECTAR()
    End Sub

    Public Sub Cargar_Tabla(ByVal t As DataSet, ByVal consulta As String)
        Try
            CONECTAR()
            Using cmd As New SQLiteCommand(consulta, db)
                Console.WriteLine("Ejecutando consulta: " & consulta)
                Using da As New SQLiteDataAdapter(cmd)
                    da.Fill(t)
                End Using
            End Using
            Console.WriteLine("Datos cargados: " & t.Tables(0).Rows(0).Item(0) & " filas.")
            DESCONECTAR()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            DESCONECTAR()
        End Try
    End Sub

    Public Function EJECUTAR(ByVal SQL As String) As Boolean
        Try
            CONECTAR()
            Dim cmd As New SQLiteCommand(SQL, db)
            cmd.ExecuteNonQuery()
            DESCONECTAR()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            DESCONECTAR()
            Return False
        End Try
    End Function
#End Region

    Friend Sub modConexionString(rutaNueva As String)
        ' Modificar App.config para actualizar la cadena de conexión
        Dim config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        config.ConnectionStrings.ConnectionStrings("DbConnectionString").ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & rutaNueva
        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("connectionStrings")

        ' Actualizar la variable conexiónString
        stringConexion = config.ConnectionStrings.ConnectionStrings("DbConnectionString").ConnectionString
    End Sub

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
