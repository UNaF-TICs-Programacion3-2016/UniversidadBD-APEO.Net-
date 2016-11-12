Imports Oracle.DataAccess.Client
Public NotInheritable Class Alumnos
    Inherits Persona
    Private pNumeroDeLegajo As String
    Private pFechaDeIngreso As Date
    'Propiedades heredadas
    Friend Overrides Property Nombre As String
        Get
            Return MyBase.Nombre
        End Get
        Set(value As String)
            MyBase.Nombre = value
        End Set
    End Property
    Friend Overrides Property Apellido As String
        Get
            Return MyBase.Apellido
        End Get
        Set(value As String)
            MyBase.Apellido = value
        End Set
    End Property
    Friend Overrides Property CUIL As String
        Get
            Return MyBase.CUIL
        End Get
        Set(value As String)
            MyBase.CUIL = value
        End Set
    End Property
    Friend Overrides Property DNI As String
        Get
            Return MyBase.DNI
        End Get
        Set(value As String)
            MyBase.DNI = value
        End Set
    End Property
    Friend Overrides Property Correo As String
        Get
            Return MyBase.Correo
        End Get
        Set(value As String)
            MyBase.Correo = value
        End Set
    End Property
    Friend Overrides Property Telefono As String
        Get
            Return MyBase.Telefono
        End Get
        Set(value As String)
            MyBase.Telefono = value
        End Set
    End Property
    'Propiedades especiales
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
            Fila("ALUMNO_NUMERO_LEGAJO") = F_Secundario.Alumno.NumeroDeLegajo
            Fila("ALUMNO_FECHA_INGRESO") = F_Secundario.Alumno.FechaDeIngreso
            Fila("ALUMNO_RELA_PERSONA") = IDPERSONA
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Alumno VALUES(:idalumno,:numerolegajo,:fechaingreso,:relapersona)"
            Comando.Parameters.Add(New OracleParameter(":idalumno", OracleDbType.Int64, 10, "ID_ALUMNO"))
            Comando.Parameters.Add(New OracleParameter(":numerolegajo", OracleDbType.Int64, 10, "ALUMNO_NUMERO_LEGAJO"))
            Comando.Parameters.Add(New OracleParameter(":fechaingreso", OracleDbType.Date, 0, "ALUMNO_FECHA_INGRESO"))
            Comando.Parameters.Add(New OracleParameter(":relapersona", OracleDbType.Int64, 10, "ALUMNO_RELA_PERSONA"))
            ActualizarSQL(Tabla)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'METODO QUE NO SIRVE
    Friend Sub InsertAlumno()
        Dim IDPERSONA As Long
        Try
            Conexion.Open()
            Transaccion = Conexion.BeginTransaction(IsolationLevel.ReadCommitted)
            Comando.Connection = Conexion
            Comando.Transaction = Transaccion
            With Comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "INSERT_PERSONA"
                .Parameters.Clear()
                '.Parameters.Add(New OracleParameter(":idpersona", OracleDbType.Long, 10, "ID_PERSONA"))
                .Parameters.Add(New OracleParameter("nombre", OracleDbType.Varchar2) With {.Value = F_Secundario.Persona.Nombre("PERSONA_NOMBRE")})
                .Parameters.Add(New OracleParameter("apellido", OracleDbType.Varchar2) With {.Value = F_Secundario.Persona.Apellido("PERSONA_APELLIDO")})
                .Parameters.Add(New OracleParameter("cuil", OracleDbType.Long) With {.Value = F_Secundario.Persona.CUIL("PERSONA_CUIL")})
                .Parameters.Add(New OracleParameter("dni", OracleDbType.Long) With {.Value = F_Secundario.Persona.DNI("PERSONA_DNI")})
                .Parameters.Add(New OracleParameter("last_id", OracleDbType.Long, ParameterDirection.Output))
                .ExecuteNonQuery()
                IDPERSONA = Long.Parse(.Parameters("last_id").Value.ToString)
                .CommandType = CommandType.Text
                .Parameters.Clear()
                .CommandText = "Insert Into Alumno VALUES(:idalumno,:numerolegajo,:fechaingreso,:relapersona)"
                .Parameters.Add(New OracleParameter(":idalumno", OracleDbType.Long) With {.Value = -1})
                .Parameters.Add(New OracleParameter(":numerolegajo", OracleDbType.Long) With {.Value = pNumeroDeLegajo})
                .Parameters.Add(New OracleParameter(":fechaingreso", OracleDbType.Date) With {.Value = pFechaDeIngreso})
                .Parameters.Add(New OracleParameter(":relapersona", OracleDbType.Long) With {.Value = IDPERSONA})
                .ExecuteNonQuery()
            End With
            Transaccion.Commit()
        Catch ex As Exception
            Transaccion.Rollback()
            MsgBox(ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Sub
    Friend Sub InsertarFacultadAlumno()
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
