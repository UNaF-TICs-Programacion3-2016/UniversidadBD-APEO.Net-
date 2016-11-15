Imports Oracle.DataAccess.Client
Public Class Carrera
    Inherits Coneccion
    Private pFacultad As Facultad
    Private pDescripcion As String
    Private pCodigo As String
    Private pDuracion As Integer
    'PROPIEDADES
    Public Property Descripcion() As String
        Get
            Return pDescripcion
        End Get
        Set(ByVal value As String)
            pDescripcion = value
        End Set
    End Property
    Public Property Codigo() As String
        Get
            Return pCodigo
        End Get
        Set(ByVal value As String)
            pCodigo = value
        End Set
    End Property
    Public Property Duracion() As Integer
        Get
            Return pDuracion
        End Get
        Set(ByVal value As Integer)
            pDuracion = value
        End Set
    End Property
    Public Property Facultad() As Facultad
        Get
            Return pFacultad
        End Get
        Set(ByVal value As Facultad)
            pFacultad = value
        End Set
    End Property
    'INSERTAR CARRERA
    Friend Sub InsertarCarrera()
        Dim Tabla As String = "CARRERA"
        Dim ID As String = CStr(F_Secundario.CMB_A_SeleccionarFacultadCarrera.SelectedValue)
        Try
            InsertarSQL(Tabla)
            Fila("CARRERA_DESCRIPCION") = F_Secundario.Carrera.Descripcion
            Fila("CARRERA_DURACION") = F_Secundario.Carrera.Duracion
            Fila("CARRERA_CODIGO") = F_Secundario.Carrera.Codigo
            Fila("CARRERA_RELA_FACULTAD") = ID
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Carrera VALUES(:idcarrera,:descripcion,:duracion,:codigo,:relafacultad)"
            Comando.Parameters.Add(New OracleParameter(":idcarrera", OracleDbType.Int64, 10, "ID_CARRERA"))
            Comando.Parameters.Add(New OracleParameter(":descripcion", OracleDbType.Varchar2, 100, "CARRERA_DESCRIPCION"))
            Comando.Parameters.Add(New OracleParameter(":duracion", OracleDbType.Varchar2, 50, "CARRERA_DURACION"))
            Comando.Parameters.Add(New OracleParameter(":codigo", OracleDbType.Varchar2, 20, "CARRERA_CODIGO"))
            Comando.Parameters.Add(New OracleParameter(":relafacultad", OracleDbType.Int64, 10, "CARRERA_RELA_FACULTAD"))
            ActualizarSQL(Tabla)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'EDITAR CARRERA
    Friend Sub EditarCarrera()
        Try
            Dim ID As Integer = F_Secundario.CMB_E_SeleccionarCarreraCarrera.SelectedValue
            Dim ID2 As Integer = F_Secundario.CMB_E_SeleccionarFacultadCarrera.SelectedValue
            Comando.Connection = Conexion
            Comando.CommandText = "UPDATE CARRERA SET CARRERA_DESCRIPCION = '" & pDescripcion & "', CARRERA_DURACION = '" & pDuracion & "', CARRERA_CODIGO = '" & pCodigo & "', CARRERA_RELA_FACULTAD = '" & ID2 & "' WHERE ID_CARRERA = " & ID
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
