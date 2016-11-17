Imports Oracle.DataAccess.Client
Public NotInheritable Class Profesores
    Inherits Persona
    Private pMatricula As String
    Private pFechaDeIngreso As Date
    'Propiedades especiales
    Friend Property Matricula() As String
        Get
            Return pMatricula
        End Get
        Set(ByVal value As String)
            pMatricula = value
        End Set
    End Property
    Friend Property FechaDeIngreso() As Date
        Get
            Return pFechaDeIngreso
        End Get
        Set(ByVal value As Date)
            pFechaDeIngreso = value
        End Set
    End Property
    'INSERTAR PROFESOR
    Friend Sub InsertarProfesor()
        Dim Tabla As String = "PERSONA"
        Try
            InsertarPersona()
            InsertarCorreo()
            InsertarTelefono()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            InsertarSQL(Tabla)
            Dim Ultimo As Integer = (Almacenamiento.Tables("PERSONA").Rows.Count) - 1
            Dim IDPERSONA As String = Almacenamiento.Tables("PERSONA").Rows(Ultimo)("ID_PERSONA").ToString
            Tabla = "PROFESOR"
            InsertarSQL(Tabla)
            Fila("PROFESOR_FECHA_INGRESO") = pFechaDeIngreso
            Fila("PROFESOR_RELA_PERSONA") = IDPERSONA
            Fila("PROFESOR_MATRICULA") = pMatricula
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Profesor VALUES(:idprofesor,:fechaingreso,:relapersona,:matricula)"
            Comando.Parameters.Add(New OracleParameter(":idprofesor", OracleDbType.Int64, 10, "ID_PROFESOR"))
            Comando.Parameters.Add(New OracleParameter(":fechaingreso", OracleDbType.Date, 0, "PROFESOR_FECHA_INGRESO"))
            Comando.Parameters.Add(New OracleParameter(":relapersona", OracleDbType.Int64, 10, "PROFESOR_RELA_PERSONA"))
            Comando.Parameters.Add(New OracleParameter(":matricula", OracleDbType.Int64, 10, "PROFESOR_MATRICULA"))
            ActualizarSQL(Tabla)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'ELIMINAR PROFESOR
    Friend Sub EliminarProfesor()
        Try
            Dim ID = F_Secundario.CMB_S_SeleccionarProfesorProfesor.SelectedValue
            Comando.Connection = Conexion
            Comando.CommandText = "DELETE FROM PROFESOR WHERE ID_PROFESOR=" & ID
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
            MsgBox("Los datos han sido eliminados correctamente.")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'EDITAR PROFESOR
    Friend Sub EditarProfesor()
        Try
            Dim ID As Integer = F_Secundario.CMB_E_SeleccionarProfesorProfesor.SelectedValue
            Comando.Connection = Conexion
            Comando.CommandText = "UPDATE PERSONA SET PERSONA_CUIL = '" & pCUIL & "', PERSONA_NOMBRE = '" & pNombre & "',PERSONA_APELLIDO = '" & pApellido & "' WHERE ID_PERSONA = '" & ID & "'"
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
            MessageBox.Show("Los datos se editaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
End Class
