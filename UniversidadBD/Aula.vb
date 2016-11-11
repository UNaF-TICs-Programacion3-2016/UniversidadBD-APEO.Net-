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
            Fila("AULAS_DESCRIPCION") = F_Secundario.oAula.Descripcion
            Fila("AULAS_RELA_FACULTAD") = ID
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Aula VALUES(:idaula,:descripcion,:relafacultad)"
            Comando.Parameters.Add(New OracleParameter(":idaula", OracleDbType.Int64, 10, "ID_AULA"))
            Comando.Parameters.Add(New OracleParameter(":descripcion", OracleDbType.Varchar2, 100, "AULAS_DESCRIPCION"))
            Comando.Parameters.Add(New OracleParameter(":relafacultad", OracleDbType.Int64, 10, "AULAS_RELA_FACULTAD"))
            ActualizarSQL(Tabla)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
