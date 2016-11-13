Imports Oracle.DataAccess.Client
Public Class Materia
    Inherits Coneccion
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
    Public Property Grupo() As String
        Get
            Return pGrupo
        End Get
        Set(ByVal value As String)
            pGrupo = value
        End Set
    End Property
    'INSERTAR LOS DATOS
    Friend Sub InsertarMateriaNormal()
        Dim Ultimo As Integer = 0
        Dim RELAOPTATIVA As String = ""
        Try
            If F_Secundario.Materia.Optativa = True Then
                InsertarSQL("OPTATIVA")
                Ultimo = (Almacenamiento.Tables("OPTATIVA").Rows.Count) - 1
                RELAOPTATIVA = Almacenamiento.Tables("OPTATIVA").Rows(Ultimo)("ID_OPTATIVA").ToString
            End If
            InsertarSQL("MATERIA")
            Dim ID As String = CStr(F_Secundario.CMB_A_SeleccionarCarreraMateria.SelectedValue)
            Fila("MATERIA_DESCRIPCION") = F_Secundario.Materia.Descripcion
            Fila("MATERIA_CODIGO") = F_Secundario.Materia.Codigo
            Fila("MATERIA_RELA_CARRERA") = ID
            If F_Secundario.Materia.Optativa = True Then
                Fila("MATERIA_RELA_OPTATIVA") = RELAOPTATIVA
            End If
            Insert("MATERIA")
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Materia VALUES (:idmateria,:descripcion,:codigo,:relacarrera,:relaoptativa)"
            Comando.Parameters.Add(New OracleParameter(":idmateria", OracleDbType.Int64, 10, "ID_MATERIA"))
            Comando.Parameters.Add(New OracleParameter(":descripcion", OracleDbType.Varchar2, 100, "MATERIA_DESCRIPCION"))
            Comando.Parameters.Add(New OracleParameter(":codigo", OracleDbType.Varchar2, 20, "MATERIA_CODIGO"))
            Comando.Parameters.Add(New OracleParameter(":relacarrera", OracleDbType.Int64, 10, "MATERIA_RELA_CARRERA"))
            Comando.Parameters.Add(New OracleParameter(":relaoptativa", OracleDbType.Int64, 10, "MATERIA_RELA_OPTATIVA"))
            ActualizarSQL("MATERIA")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Friend Sub InsertarMateriaCorrelativa()
        Try
            InsertarSQL("MATERIA")
            Dim Ultimo As Integer = (Almacenamiento.Tables("MATERIA").Rows.Count) - 1
            Dim ID As String = Almacenamiento.Tables("MATERIA").Rows(Ultimo)("ID_MATERIA").ToString
            InsertarSQL("CORRELATIVA")
            Fila("CORRELATIVA_RELA_MATERIA") = ID
            Insert("CORRELATIVA")
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Correlativa VALUES(:idcorrelativa,:relamateria)"
            Comando.Parameters.Add(New OracleParameter(":idcorrelativa", OracleDbType.Int64, 10, "ID_CORRELATIVA"))
            Comando.Parameters.Add(New OracleParameter(":relamateria", OracleDbType.Int64, 10, "CORRELATIVA_RELA_MATERIA"))
            ActualizarSQL("CORRELATIVA")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Friend Sub InsertarMateriaOptativa()
        Try
            InsertarSQL("OPTATIVA")
            Fila("OPTATIVA_DESCRIPCION") = F_Secundario.TXT_A_DescripcionOptativaMateria.Text
            Fila("OPTATIVA_CODIGO") = F_Secundario.TXT_A_CodigoOptativaMateria.Text
            Insert("OPTATIVA")
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Optativa VALUES(:idoptativa,:descripcion,:codigo)"
            Comando.Parameters.Add(New OracleParameter(":idoptativa", OracleDbType.Int64, 10, "ID_OPTATIVA"))
            Comando.Parameters.Add(New OracleParameter(":descripcion", OracleDbType.Varchar2, 100, "OPTATIVA_DESCRIPCION"))
            Comando.Parameters.Add(New OracleParameter(":codigo", OracleDbType.Varchar2, 20, "OPTATIVA_CODIGO"))
            ActualizarSQL("OPTATIVA")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Friend Sub InsertarMateria()
        Try
            If F_Secundario.Materia.Correlativa = False And F_Secundario.Materia.Optativa = False Then
                InsertarMateriaNormal()
            ElseIf F_Secundario.Materia.Correlativa = True And F_Secundario.Materia.Optativa = False Then
                InsertarMateriaNormal()
                InsertarMateriaCorrelativa()
            ElseIf F_Secundario.Materia.Correlativa = True And F_Secundario.Materia.Optativa = True Then
                InsertarMateriaOptativa()
                InsertarMateriaNormal()
                InsertarMateriaCorrelativa()
            ElseIf F_Secundario.Materia.Correlativa = False And F_Secundario.Materia.Optativa = True Then
                InsertarMateriaOptativa()
                InsertarMateriaNormal()
            End If
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Friend Sub RelacionarCorrelativa()
        Try
            Dim Tabla As String = "MATERIA_CORRELATIVA"
            Dim MATERIA As Integer = F_Secundario.CMB_A_SeleccioneMateriasCorrelativa.SelectedValue
            Dim CORRELATIVA As String = F_Secundario.CMB_A_SeleccioneCorrelativasCorrelativa.SelectedValue
            InsertarSQL(Tabla)
            Fila("MATE_CORRE_RELA_MATERIA") = MATERIA
            Fila("MATE_CORRE_RELA_CORRELATIVA") = CORRELATIVA
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Materia_Correlativa VALUES(:idmatecorre,:relamateria,:relacorrelativa)"
            Comando.Parameters.Add(New OracleParameter(":idmatecorre", OracleDbType.Long, 10, "ID_MATERIA_CORRELATIVA"))
            Comando.Parameters.Add(New OracleParameter(":relamateria", OracleDbType.Long, 10, "MATE_CORRE_RELA_MATERIA"))
            Comando.Parameters.Add(New OracleParameter(":relacorrelativa", OracleDbType.Long, 10, "MATE_CORRE_RELA_CORRELATIVA"))
            ActualizarSQL(Tabla)
            F_Secundario.LBX_A_CorrelativasMateria.Items.Add(F_Secundario.CMB_A_SeleccioneCorrelativasCorrelativa.Text)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
