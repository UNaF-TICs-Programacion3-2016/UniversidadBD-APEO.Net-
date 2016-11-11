Imports Oracle.DataAccess.Client
Public NotInheritable Class Profesores
    Inherits Persona
    Private pMatricula As String
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
    Friend Overrides Property Telefono As String
        Get
            Return MyBase.Telefono
        End Get
        Set(value As String)
            MyBase.Telefono = value
        End Set
    End Property
    Friend Overrides Property Correo As String
        Get
            Return MyBase.pCorreo
        End Get
        Set(value As String)
            MyBase.pCorreo = value
        End Set
    End Property
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
            Fila("PROFESOR_FECHA_INGRESO") = F_Secundario.Profesor.FechaDeIngreso
            Fila("PROFESOR_RELA_PERSONA") = IDPERSONA
            Fila("PROFESOR_MATRICULA") = F_Secundario.Profesor.Matricula
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
End Class
