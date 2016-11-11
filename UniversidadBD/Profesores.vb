Imports Oracle.DataAccess.Client
Public NotInheritable Class Profesores
    Inherits Persona
    Private pMatricula As String
    Private pFechaDeIngreso As Date
    Private pFechaDeBaja As Date
    Private pAntiguedad As Integer
    Private pCorreo As String
    Private pTipoCorreo As String
    Private pProfesion As String
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
    Friend Overrides Property TipoTelefono As String
        Get
            Return MyBase.TipoTelefono
        End Get
        Set(value As String)
            MyBase.TipoTelefono = value
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
    Friend Property FechaDeBaja() As Date
        Get
            Return pFechaDeBaja
        End Get
        Set(ByVal value As Date)
            pFechaDeBaja = value
        End Set
    End Property
    Friend Property Antiguedad() As Integer
        Get
            Return pAntiguedad
        End Get
        Set(ByVal value As Integer)
            pAntiguedad = value
        End Set
    End Property
    Friend Property Correo() As String
        Get
            Return pCorreo
        End Get
        Set(ByVal value As String)
            pCorreo = value
        End Set
    End Property
    Friend Property TipoCorreo() As String
        Get
            Return pTipoCorreo
        End Get
        Set(value As String)
            pTipoCorreo = value
        End Set
    End Property
    Friend Property Profesion() As String
        Get
            Return pProfesion
        End Get
        Set(ByVal value As String)
            pProfesion = value
        End Set
    End Property
    'INSERTAR PROFESOR
    Friend Sub InsertarProfesor()
        Dim Tabla As String = "PERSONA"
        Try
            InsertarPersona(Tabla)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            InsertarSQL(Tabla)
            Dim Ultimo As Integer = (Almacenamiento.Tables("PERSONA").Rows.Count) - 1
            Dim IDPERSONA As String = Almacenamiento.Tables("PERSONA").Rows(Ultimo)("ID_PERSONA").ToString

            Tabla = "PROFESOR"
            InsertarSQL(Tabla)
            Fila("PROFESOR_ANTIGUEDAD") = F_Secundario.Profesor.Antiguedad
            Fila("PROFESOR_FECHA_ALTA") = F_Secundario.Profesor.FechaDeIngreso
            Fila("PROFESOR_FECHA_BAJA") = F_Secundario.Profesor.FechaDeBaja
            Fila("PROFESOR_RELA_PERSONA") = IDPERSONA
            Fila("PROFESOR_RELA_PROFESION") = IDPROFESION
            Fila("PROFESOR_RELA_CORREO") = IDCORREO
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Profesor VALUES(:idprofesor,:antiguedad,:fechaalta,:fechabaja,:relapersona,:relaprofesion,:relacorreo)"
            Comando.Parameters.Add(New OracleParameter(":idprofesor", OracleDbType.Int64, 10, "ID_PROFESOR"))
            Comando.Parameters.Add(New OracleParameter(":antiguedad", OracleDbType.Varchar2, 50, "PROFESOR_ANTIGUEDAD"))
            Comando.Parameters.Add(New OracleParameter(":fechaalta", OracleDbType.Date, 0, "PROFESOR_FECHA_ALTA"))
            Comando.Parameters.Add(New OracleParameter(":fechabaja", OracleDbType.Date, 0, "PROFESOR_FECHA_BAJA"))
            Comando.Parameters.Add(New OracleParameter(":relapersona", OracleDbType.Int64, 10, "PROFESOR_RELA_PERSONA"))
            Comando.Parameters.Add(New OracleParameter(":relaprofesion", OracleDbType.Int64, 10, "PROFESOR_RELA_PROFESION"))
            Comando.Parameters.Add(New OracleParameter(":relacorreo", OracleDbType.Int64, 10, "PROFESOR_RELA_CORREO"))

            ActualizarSQL(Tabla)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
