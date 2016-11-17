Imports Oracle.DataAccess.Client
Public NotInheritable Class Otros
    Inherits Persona
    Private pFechaDeIngreso As Date
    Private pPuesto As String
    'Propiedades especiales
    Friend Property FechaDeIngreso() As Date
        Get
            Return pFechaDeIngreso
        End Get
        Set(ByVal value As Date)
            pFechaDeIngreso = value
        End Set
    End Property
    Friend Property Puesto() As String
        Get
            Return pPuesto
        End Get
        Set(ByVal value As String)
            pPuesto = value
        End Set
    End Property
    'INSERTAR OTRO
    Friend Sub InsertarOtro()
        Dim Tabla As String = "ADMINISTRACION"
        Try
            InsertarPersona()
            InsertarTelefono()
            InsertarCorreo()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Tabla = "PERSONA"
            InsertarSQL(Tabla)
            Dim Ultimo As Integer = (Almacenamiento.Tables("PERSONA").Rows.Count) - 1
            Dim IDPERSONA As String = Almacenamiento.Tables("PERSONA").Rows(Ultimo)("ID_PERSONA").ToString
            Tabla = "ADMINISTRACION"
            InsertarSQL(Tabla)
            Dim IDFACULTAD As Integer = F_Secundario.CMB_A_FacultadOtro.SelectedValue
            Fila("ADMIN_FECHA_INGRESO") = pFechaDeIngreso
            Fila("ADMIN_RELA_PERSONA") = IDPERSONA
            Fila("ADMIN_RELA_PUESTO") = pPuesto
            Fila("ADMIN_RELA_FACULTAD") = IDFACULTAD
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Administracion VALUES(:idadministracion,:fechaingreso,:relapersona,:puesto,:facultad)"
            Comando.Parameters.Add(New OracleParameter(":idadministracion", OracleDbType.Int64, 10, "ID_ADMINISTRACION"))
            Comando.Parameters.Add(New OracleParameter(":fechaingreso", OracleDbType.Date, 0, "ADMIN_FECHA_INGRESO"))
            Comando.Parameters.Add(New OracleParameter(":relapersona", OracleDbType.Int64, 10, "ADMIN_RELA_PERSONA"))
            Comando.Parameters.Add(New OracleParameter(":puesto", OracleDbType.Int64, 10, "ADMIN_RELA_PUESTO"))
            Comando.Parameters.Add(New OracleParameter(":facultad", OracleDbType.Int64, 10, "ADMIN_RELA_FACULTAD"))
            ActualizarSQL(Tabla)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'ELIMINAR OTRO
    Friend Sub EliminarOtro()
        Try
            Dim ID = F_Secundario.CMB_S_SeleccionePersonaOtro.SelectedValue
            Comando.Connection = Conexion
            Comando.CommandText = "DELETE FROM ADMINISTRACION WHERE ID_ADMINISTRACION=" & ID
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
            MsgBox("Los datos han sido eliminados correctamente.")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
