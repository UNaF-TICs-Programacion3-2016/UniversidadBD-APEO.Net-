Imports Oracle.DataAccess.Client
Public Class Aula
    Inherits Coneccion
    Private pCodigo As String
    Private pDescripcion As String
    'PROPIEDADES
    Public Property Codigo() As String
        Get
            Return pCodigo
        End Get
        Set(ByVal value As String)
            pCodigo = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return pDescripcion
        End Get
        Set(ByVal value As String)
            pDescripcion = value
        End Set
    End Property
    'INSERTAR AULA
    Friend Sub InsertarAula()
        Dim Tabla As String = "AULA"
        Try
            Dim ID As String = CStr(F_Secundario.CMB_A_SeleccionarAulaFacultad.SelectedValue)
            InsertarSQL(Tabla)
            Fila("AULA_DESCRIPCION") = F_Secundario.oAula.Descripcion
            Fila("AULA_RELA_FACULTAD") = ID
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
    Friend Sub EditarAula()
        Try
            Dim ID As Integer = F_Secundario.CMB_E_SeleccionarAulaAula.SelectedValue
            Dim ID2 As Integer = F_Secundario.CMB_E_SeleccionarFacultadAula.SelectedValue
            Comando.Connection = Conexion
            Comando.CommandText = "UPDATE AULA SET AULA_DESCRIPCION = '" & pDescripcion & "', AULA_RELA_FACULTAD = '" & ID2 & "' WHERE ID_AULA = " & ID
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'ELIMINAR AULA
    Friend Sub EliminarAula()
        Try
            Dim ID = F_Secundario.CMB_S_SeleccionarAulaAula.SelectedValue
            Comando.Connection = Conexion
            Comando.CommandText = "DELETE FROM AULA WHERE ID_AULA=" & ID
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
            MsgBox("Los datos han sido eliminados correctamente.")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
