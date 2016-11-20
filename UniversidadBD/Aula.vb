Imports Oracle.DataAccess.Client
Public Class Aula
    Inherits Coneccion
    Private pDescripcion As String
    Private pFacultad As String
    'PROPIEDADES
    Friend Property Descripcion() As String
        Get
            Return pDescripcion
        End Get
        Set(ByVal value As String)
            pDescripcion = value
        End Set
    End Property
    Friend Property Facultad() As String
        Get
            Return pFacultad
        End Get
        Set(value As String)
            pFacultad = value
        End Set
    End Property
    'INSERTAR AULA
    Friend Sub InsertarAula()
        Dim Tabla As String = "AULA"
        Try
            InsertarSQL(Tabla)
            Fila("AULA_DESCRIPCION") = pDescripcion
            Fila("AULA_RELA_FACULTAD") = pFacultad
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Aula VALUES(:idaula,:descripcion,:relafacultad)"
            Comando.Parameters.Add(New OracleParameter(":idaula", OracleDbType.Int64, 10, "ID_AULA"))
            Comando.Parameters.Add(New OracleParameter(":descripcion", OracleDbType.Varchar2, 100, "AULA_DESCRIPCION"))
            Comando.Parameters.Add(New OracleParameter(":relafacultad", OracleDbType.Int64, 10, "AULA_RELA_FACULTAD"))
            ActualizarSQL(Tabla)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'EDITAR AULA
    Friend Sub EditarAula(ID As String)
        Try
            Comando.Connection = Conexion
            Comando.CommandText = "UPDATE AULA SET AULA_DESCRIPCION = '" & pDescripcion & "', AULA_RELA_FACULTAD = '" & pFacultad & "' WHERE ID_AULA = " & ID
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
            MessageBox.Show("Los datos han sido editados correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'ELIMINAR AULA
    Friend Sub EliminarAula(ID As String)
        Try
            Comando.Connection = Conexion
            Comando.CommandText = "DELETE FROM AULA WHERE ID_AULA = " & ID
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
            MsgBox("Los datos han sido eliminados correctamente.")
        Catch ex As Exception
            MessageBox.Show("No se puede realizar la acción, primero elimine las dependencias de esta entidad.", "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
