Imports Oracle.DataAccess.Client
Public NotInheritable Class Alumnos
    Inherits Persona
    Private pNumeroDeLegajo As String
    Private pFechaDeIngreso As Date
    'Propiedades especiales
    Friend Overrides Property Nombre As String
        Get
            Return MyBase.Nombre
        End Get
        Set(value As String)
            MyBase.Nombre = value
        End Set
    End Property
    Friend Property NumeroDeLegajo() As String
        Get
            Return pNumeroDeLegajo
        End Get
        Set(ByVal value As String)
            pNumeroDeLegajo = value
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
    'INSERTAR ALUMNO
    Friend Sub InsertarAlumno()
        Dim Tabla As String = "PERSONA"
        Try
            InsertarPersona()
            InsertarCorreo()
            InsertarTelefono()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            InsertarSQL(Tabla)
            Dim Ultimo As Integer = (Almacenamiento.Tables("PERSONA").Rows.Count) - 1
            Dim IDPERSONA As String = Almacenamiento.Tables("PERSONA").Rows(Ultimo)("ID_PERSONA").ToString
            Tabla = "ALUMNO"
            InsertarSQL(Tabla)
            Fila("ALUMNO_NUMERO_LEGAJO") = pNumeroDeLegajo
            Fila("ALUMNO_FECHA_INGRESO") = pFechaDeIngreso
            Fila("ALUMNO_RELA_PERSONA") = IDPERSONA
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Alumno VALUES(:idalumno,:numerolegajo,:fechaingreso,:relapersona) RETURNING id_Alumno INTO :Last_id"
            Comando.Parameters.Add(New OracleParameter(":idalumno", OracleDbType.Int64, 10, "ID_ALUMNO"))
            Comando.Parameters.Add(New OracleParameter(":numerolegajo", OracleDbType.Int64, 10, "ALUMNO_NUMERO_LEGAJO"))
            Comando.Parameters.Add(New OracleParameter(":fechaingreso", OracleDbType.Date, 0, "ALUMNO_FECHA_INGRESO"))
            Comando.Parameters.Add(New OracleParameter(":relapersona", OracleDbType.Int64, 10, "ALUMNO_RELA_PERSONA"))
            Comando.Parameters.Add(New OracleParameter(":Last_id", OracleDbType.Int64, ParameterDirection.ReturnValue))
            ActualizarSQL(Tabla)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            InsertarSQL(Tabla)
            Dim ULTIMOID As Integer = Integer.Parse((Comando.Parameters(":Last_id").ToString))
            'Dim IDALUMNO As String = Almacenamiento.Tables("ALUMNO").Rows(ULTIMOID)("ID_ALUMNO").ToString
            Tabla = "ALUMNO_CARRERA"
            InsertarSQL(Tabla)
            Dim RELACARRERA As Integer = F_Secundario.CMB_A_SeleccioneCarrreraAlumno.SelectedValue
            Fila("ALU_CARRE_RELA_ALUMNO") = ULTIMOID
            Fila("ALU_CARRE_RELA_CARRERA") = RELACARRERA
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Alumno_Carrera VALUES(:idalucarre,:relaalumno,:relacarrera)"
            Comando.Parameters.Add(New OracleParameter(":idalucarre", OracleDbType.Int64, 10, "ID_ALUMNO_CARRERA"))
            Comando.Parameters.Add(New OracleParameter(":relaalumno", OracleDbType.Int64, 10, "ALU_CARRE_RELA_ALUMNO"))
            Comando.Parameters.Add(New OracleParameter(":relacarrera", OracleDbType.Int64, 10, "ALU_CARRE_RELA_CARRERA"))
            ActualizarSQL(Tabla)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'ELIMINAR ALUMNO
    Friend Sub EliminarAlumno()
        Try
            Dim ID = F_Secundario.CMB_S_SeleccionarAlumno.SelectedValue
            Comando.Connection = Conexion
            Comando.CommandText = "DELETE FROM ALUMNO WHERE ID_ALUMNO=" & ID
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
            MsgBox("Los datos han sido eliminados correctamente.")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
