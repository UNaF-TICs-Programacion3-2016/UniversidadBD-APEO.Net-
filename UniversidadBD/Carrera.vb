Imports Oracle.DataAccess.Client
Public Class Carrera
    Inherits Coneccion
    Private pDescripcion As String
    Private pCodigo As String
    Private pDuracion As Integer
    Private pFacultad As String
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
    Public Property Facultad() As String
        Get
            Return pFacultad
        End Get
        Set(ByVal value As String)
            pFacultad = value
        End Set
    End Property
    'INSERTAR CARRERA
    Friend Sub InsertarCarrera()
        Dim Tabla As String = "CARRERA"
        Try
            InsertarSQL(Tabla)
            Fila("CARRERA_DESCRIPCION") = pDescripcion
            Fila("CARRERA_DURACION") = pDuracion
            Fila("CARRERA_CODIGO") = pCodigo
            Fila("CARRERA_RELA_FACULTAD") = pFacultad
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
    Friend Sub EditarCarrera(ID As String)
        Try
            Comando.Connection = Conexion
            Comando.CommandText = "UPDATE CARRERA SET CARRERA_DESCRIPCION = '" & pDescripcion & "', CARRERA_DURACION = '" & pDuracion & "', CARRERA_CODIGO = '" & pCodigo & "', CARRERA_RELA_FACULTAD = '" & pFacultad & "' WHERE ID_CARRERA = " & ID
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
            MessageBox.Show("Los datos han sido editados correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'ELIMINAR CARRERA
    Friend Sub EliminarCarrera(ID As String)
        Try
            Comando.Connection = Conexion
            Comando.CommandText = "DELETE FROM CARRERA WHERE ID_CARRERA = " & ID
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
            MsgBox("Los datos han sido eliminados correctamente.")
        Catch ex As Exception
            MessageBox.Show("No se puede realizar la acción, primero elimine las dependencias de esta entidad.", "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
