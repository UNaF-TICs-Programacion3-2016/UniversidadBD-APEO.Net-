Imports Oracle.DataAccess.Client
Public Class Materia
    Inherits Coneccion
    Private pCarrera As Carrera
    Private pDescripcion As String
    Private pCodigo As String
    Private pDireccion As String
    Private pCorrelativa As Boolean
    Private pOptativa As Boolean
    Private pGrupo As String
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
    Public Property Direccion() As String
        Get
            Return pDireccion
        End Get
        Set(ByVal value As String)
            pDireccion = value
        End Set
    End Property
    Public Property Correlativa() As Boolean
        Get
            Return pCorrelativa
        End Get
        Set(ByVal value As Boolean)
            pCorrelativa = value
        End Set
    End Property
    Public Property Optativa() As Boolean
        Get
            Return pOptativa
        End Get
        Set(ByVal value As Boolean)
            pOptativa = value
        End Set
    End Property
    Public Property Carrera() As Carrera
        Get
            Return pCarrera
        End Get
        Set(ByVal value As Carrera)
            pCarrera = value
        End Set
    End Property
    Public Property Grupo() As String
        Get
            Return pGrupo
        End Get
        Set(ByVal value As String)
            pGrupo = value
        End Set
    End Property
    'INSERTAR LOS DATOS
    Friend Sub MateriaInsertar(Tabla As String)
        Try
            InsertarSQL(Tabla)
            Dim ID As String = CStr(F_Secundario.CMB_A_SeleccionarCarreraMateria.SelectedValue)
            Fila("MATERIA_DESCRIPCION") = F_Secundario.Materia.Descripcion
            Fila("MATERIA_CODIGO") = F_Secundario.Materia.Codigo
            Fila("MATERIA_RELA_CARRERA") = ID
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Materia VALUES (:idmateria,:descripcion,:codigo,:relacarrera,:relaoptativa)"
            Comando.Parameters.Add(New OracleParameter(":idmateria", OracleDbType.Int64, 10, "ID_MATERIA"))
            Comando.Parameters.Add(New OracleParameter(":descripcion", OracleDbType.Varchar2, 100, "MATERIA_DESCRIPCION"))
            Comando.Parameters.Add(New OracleParameter(":codigo", OracleDbType.Varchar2, 20, "MATERIA_CODIGO"))
            Comando.Parameters.Add(New OracleParameter(":relacarrera", OracleDbType.Int64, 10, "MATERIA_RELA_CARRERA"))
            Comando.Parameters.Add(New OracleParameter(":relaoptativa", OracleDbType.Int64, 10, "MATERIA_RELA_OPTATIVA"))
            ActualizarSQL(Tabla)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Friend Sub InsertarMateria()
        Dim Tabla As String = "MATERIA"
        Try
            If F_Secundario.Materia.Correlativa = False And F_Secundario.Materia.Optativa = False Then
                MateriaInsertar(Tabla)
            ElseIf F_Secundario.materia.Correlativa = True And F_Secundario.materia.Optativa = False Then
                MateriaInsertar(Tabla)
                InsertarSQL(Tabla)
                Dim Ultimo As Integer = (Almacenamiento.Tables("MATERIA").Rows.Count) - 1
                Dim ID As String = Almacenamiento.Tables("MATERIA").Rows(Ultimo)("ID_MATERIA").ToString
                Tabla = "CORRELATIVA"
                InsertarSQL(Tabla)
                Fila("CORRELATIVA_RELA_MATERIA") = ID
                Insert(Tabla)
                Comando.Parameters.Clear()
                Comando.CommandText = "Insert Into Correlativa VALUES(:idcorrelativa,:relamateria)"
                Comando.Parameters.Add(New OracleParameter(":idcorrelativa", OracleDbType.Int64, 10, "ID_CORRELATIVA"))
                Comando.Parameters.Add(New OracleParameter(":relamateria", OracleDbType.Int64, 10, "CORRELATIVA_RELA_MATERIA"))
                ActualizarSQL(Tabla)
                MessageBox.Show("Los datos se guardaron correctamente")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
