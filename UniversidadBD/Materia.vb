Imports Oracle.DataAccess.Client
Public Class Materia
    Inherits Coneccion
    Private pDescripcion As String
    Private pCodigo As String
    Private pCorrelativa As String
    Private pOptativa As Boolean
    Private pDescripcionOP As String
    Private pCodigoOP As String
    Private pRelacion As String
    Private pCarrera As String
    Private pHistorial As String
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
    Public Property Correlativa() As String
        Get
            Return pCorrelativa
        End Get
        Set(ByVal value As String)
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
    Public Property DescripcionOP() As String
        Get
            Return pDescripcionOP
        End Get
        Set(ByVal value As String)
            pDescripcionOP = value
        End Set
    End Property
    Public Property CodigoOP() As String
        Get
            Return pCodigoOP
        End Get
        Set(ByVal value As String)
            pCodigoOP = value
        End Set
    End Property
    Public Property Relacion() As String
        Get
            Return pRelacion
        End Get
        Set(ByVal value As String)
            pRelacion = value
        End Set
    End Property
    Public Property Carrera() As String
        Get
            Return pCarrera
        End Get
        Set(ByVal value As String)
            pCarrera = value
        End Set
    End Property
    Public Property Historial() As String
        Get
            Return pHistorial
        End Get
        Set(ByVal value As String)
            pHistorial = value
        End Set
    End Property
    'INSERTAR MATERIA
    'Materias normales
    Friend Sub InsertarMateriaNormal(ID As String)
        Try
            InsertarSQL("MATERIA")
            Fila("MATERIA_DESCRIPCION") = pDescripcion
            Fila("MATERIA_CODIGO") = pCodigo
            Fila("MATERIA_RELA_CARRERA") = pCarrera
            If pOptativa = True Then
                Fila("MATERIA_RELA_OPTATIVA") = ID
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
    'Materias optativas
    Friend Sub InsertarMateriaOptativa()
        Dim Tabla As String = "OPTATIVA"
        Try
            InsertarSQL(Tabla)
            Fila("OPTATIVA_DESCRIPCION") = pDescripcionOP
            Fila("OPTATIVA_CODIGO") = pCodigoOP
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Optativa VALUES(:idoptativa,:descripcion,:codigo) RETURNING ID_OPTATIVA INTO :last_id"
            Comando.Parameters.Add(New OracleParameter(":idoptativa", OracleDbType.Int64, 10, "ID_OPTATIVA"))
            Comando.Parameters.Add(New OracleParameter(":descripcion", OracleDbType.Varchar2, 100, "OPTATIVA_DESCRIPCION"))
            Comando.Parameters.Add(New OracleParameter(":codigo", OracleDbType.Varchar2, 20, "OPTATIVA_CODIGO"))
            Comando.Parameters.Add(New OracleParameter(":last_id", OracleDbType.Int64, ParameterDirection.ReturnValue))
            ActualizarSQL(Tabla)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Dim ID As String = (Comando.Parameters(":last_id").Value).ToString
        InsertarMateriaNormal(ID)
    End Sub
    'Todas las materias
    Friend Sub InsertarMateria()
        Dim ID As String = ""
        Try
            If pOptativa = True Then
                InsertarMateriaOptativa()
            Else
                InsertarMateriaNormal(ID)
            End If
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Correlativa para cada materia
    Friend Sub RelacionarCorrelativa()
        Try
            Dim Tabla As String = "MATERIA_CORRELATIVA"
            InsertarSQL(Tabla)
            Fila("MATE_CORRE_RELA_MATERIA") = pRelacion
            Fila("MATE_CORRE_RELA_CORRELATIVA") = pCorrelativa
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Materia_Correlativa VALUES(:idmatecorre,:relamateria,:relacorrelativa)"
            Comando.Parameters.Add(New OracleParameter(":idmatecorre", OracleDbType.Long, 10, "ID_MATERIA_CORRELATIVA"))
            Comando.Parameters.Add(New OracleParameter(":relamateria", OracleDbType.Long, 10, "MATE_CORRE_RELA_MATERIA"))
            Comando.Parameters.Add(New OracleParameter(":relacorrelativa", OracleDbType.Long, 10, "MATE_CORRE_RELA_CORRELATIVA"))
            ActualizarSQL(Tabla)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'EDITAR MATERIA
    Friend Sub EditarMateria(ID As String)
        Try
            Comando.Connection = Conexion
            Comando.CommandText = "UPDATE MATERIA SET MATERIA_DESCRIPCION = '" & pDescripcion & "', MATERIA_CODIGO = '" & pCodigo & "', MATERIA_RELA_CARRERA = '" & pCarrera & "' WHERE ID_MATERIA = " & ID
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
            MessageBox.Show("Los datos han sido editados correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'ELIMINAR MATERIA
    Friend Sub EliminarMateria(ID As String)
        Try
            Comando.Connection = Conexion
            Comando.CommandText = "DELETE FROM MATERIA WHERE ID_MATERIA = " & ID
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
            MsgBox("Los datos han sido eliminados correctamente.")
        Catch ex As Exception
            MessageBox.Show("No se puede realizar la acción, primero elimine las dependencias de esta entidad.", "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
