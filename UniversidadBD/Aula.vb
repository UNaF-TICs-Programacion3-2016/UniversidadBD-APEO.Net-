Imports Oracle.DataAccess.Client

Public Class Aula
    Inherits Coneccion
    Private pFacultad As Facultad
    Private pCodigo As String
    Private pDescripcion As String

    'PROPIEDADES
    Public Property Facultad() As Facultad
        Get
            Return pFacultad
        End Get
        Set(ByVal value As Facultad)
            pFacultad = value
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

            InsertarSQL(Tabla)
            Dim Ultimo As Integer = (Almacenamiento.Tables("FACULTAD").Rows.Count) - 1
            Dim IDFACULTAD As String = Almacenamiento.Tables("FACULTAD").Rows(Ultimo)("ID_FACULTAD").ToString
            Tabla = "AULA"
            InsertarSQL(Tabla)
            Fila("AULAS_DESCRIPCION") = F_Secundario.oAula.Descripcion
            Fila("AULAS_RELA_FACULTAD") = IDFACULTAD

            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Profesor VALUES(:idaula,:descripcion,:relafacultad)"
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
