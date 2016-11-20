Imports Oracle.DataAccess.Client
Public Class Facultad
    Inherits Coneccion
    Private pDescripcion As String
    Private pCodigo As String
    'PROPIEDADES
    Friend Property Descripcion() As String
        Get
            Return pDescripcion
        End Get
        Set(ByVal value As String)
            pDescripcion = value
        End Set
    End Property
    Friend Property Codigo() As String
        Get
            Return pCodigo
        End Get
        Set(ByVal value As String)
            pCodigo = value
        End Set
    End Property
    Friend Property ID() As String
    'INSERTAR FACULTAD
    Friend Sub InsertarFacultad()
        Try
            Dim Tabla As String = "FACULTAD"
            InsertarSQL(Tabla)
            Fila("FACULTAD_DESCRIPCION") = pDescripcion
            Fila("FACULTAD_CODIGO") = pCodigo
            Insert(Tabla)
            Comando.CommandText = "Insert Into Facultad VALUES(:idfacultad,:descripcion,:codigo)"
            Comando.Parameters.Add(New OracleParameter(":idpersona", OracleDbType.Int64, 10, "ID_FACULTAD"))
            Comando.Parameters.Add(New OracleParameter(":descripcion", OracleDbType.Varchar2, 100, "FACULTAD_DESCRIPCION"))
            Comando.Parameters.Add(New OracleParameter(":idpersona", OracleDbType.Varchar2, 20, "FACULTAD_CODIGO"))
            ActualizarSQL(Tabla)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'EDITAR FACULTAD
    Friend Sub EditarFacultad(ID As String)
        Try
            Comando.Connection = Conexion
            Comando.CommandText = "UPDATE FACULTAD SET FACULTAD_DESCRIPCION = '" & pDescripcion & "', FACULTAD_CODIGO = '" & pCodigo & "' WHERE ID_FACULTAD = " & ID
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
            MessageBox.Show("Los datos han sido editados correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'ELIMINAR FACULTAD
    Friend Sub EliminarFacultad()
        Try
            Dim ID As Integer = F_Secundario.CMB_S_FacultadSeleccionar.SelectedValue
            Comando.Connection = Conexion
            Comando.CommandText = "DELETE FROM FACULTAD WHERE ID_FACULTAD=" & ID
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
