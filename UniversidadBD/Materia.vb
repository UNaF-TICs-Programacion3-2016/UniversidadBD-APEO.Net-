﻿Imports Oracle.DataAccess.Client
Public Class Materia
    Inherits Coneccion
    Private pDescripcion As String
    Private pCodigo As String
    Private pCorrelativa As Boolean
    Private pOptativa As Boolean
    Private pDescripcionOP As String
    Private pCodigoOP As String
    Private pRelacion As String
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
    'INSERTAR LOS DATOS
    Friend Sub InsertarMateriaNormal()
        Dim Ultimo As Integer = 0
        Dim RELAOPTATIVA As String = ""
        Try
            If pOptativa = True Then
                InsertarSQL("OPTATIVA")
                Ultimo = (Almacenamiento.Tables("OPTATIVA").Rows.Count) - 1
                RELAOPTATIVA = Almacenamiento.Tables("OPTATIVA").Rows(Ultimo)("ID_OPTATIVA").ToString
            End If
            InsertarSQL("MATERIA")
            Dim ID As String = CStr(F_Secundario.CMB_A_SeleccionarCarreraMateria.SelectedValue)
            Fila("MATERIA_DESCRIPCION") = pDescripcion
            Fila("MATERIA_CODIGO") = pCodigo
            Fila("MATERIA_RELA_CARRERA") = ID
            If pOptativa = True Then
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
    Friend Sub InsertarMateriaOptativa()
        Try
            InsertarSQL("OPTATIVA")
            Fila("OPTATIVA_DESCRIPCION") = pDescripcionOP
            Fila("OPTATIVA_CODIGO") = pCodigoOP
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
            If Optativa = True Then
                InsertarMateriaOptativa()
                InsertarMateriaNormal()
            Else
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
            F_Secundario.LBX_A_CorrelativasMateria.Items.Add(F_Secundario.CMB_A_SeleccioneCorrelativasCorrelativa.Text)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'ELIMINAR MATERIA
    Friend Sub EliminarMateria()
        Try
            Dim ID = F_Secundario.CMB_S_SeleccionarMateriaMateria.SelectedValue
            Comando.Connection = Conexion
            Comando.CommandText = "DELETE FROM MATERIA WHERE ID_MATERIA=" & ID
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
            MsgBox("Los datos han sido eliminados correctamente.")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'EDITAR MATERIA
    Friend Sub EditarMateria()

        Try
            Dim ID As Integer = F_Secundario.CMB_E_SeleccionarMateriaMateria.SelectedValue
            Comando.Connection = Conexion
            Comando.CommandText = "UPDATE MATERIA SET MATERIA_DESCRIPCION = '" & pDescripcion & "', MATERIA_CODIGO = '" & pCodigo & "' WHERE ID_MATERIA = " & ID
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
            MessageBox.Show("Los datos se editaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
