Imports Oracle.DataAccess.Client
Public MustInherit Class Persona
    Inherits Coneccion
    Protected pNombre As String
    Protected pApellido As String
    Protected pCUIL As String
    Protected pDNI As String
    Protected pTelefono As String
    Protected pTipoTelefono As String
    'PROPIEDADES
    Friend Overridable Property Nombre() As String
        Get
            Return pNombre
        End Get
        Set(ByVal value As String)
            pNombre = value
        End Set
    End Property
    Friend Overridable Property Apellido() As String
        Get
            Return pApellido
        End Get
        Set(value As String)
            pApellido = value
        End Set
    End Property
    Friend Overridable Property CUIL() As String
        Get
            Return pCUIL
        End Get
        Set(value As String)
            pCUIL = value
        End Set
    End Property
    Friend Overridable Property DNI() As String
        Get
            Return pDNI
        End Get
        Set(value As String)
            pDNI = value
        End Set
    End Property
    Friend Overridable Property Telefono() As String
        Get
            Return pTelefono
        End Get
        Set(value As String)
            pTelefono = value
        End Set
    End Property
    Friend Overridable Property TipoTelefono() As String
        Get
            Return pTipoTelefono
        End Get
        Set(value As String)
            pTipoTelefono = value
        End Set
    End Property
    'METODOS
    Friend Sub InsertarPersona(Tabla As String)
        InsertarSQL(Tabla)
        Fila("PERSONA_NOMBRE") = F_Secundario.Alumno.Nombre
        Fila("PERSONA_APELLIDO") = F_Secundario.Alumno.Apellido
        Fila("PERSONA_CUIL") = F_Secundario.Alumno.CUIL
        Fila("PERSONA_DNI") = F_Secundario.Alumno.DNI
        Insert(Tabla)
        Comando.CommandText = "Insert Into Persona VALUES(:idpersona,:nombre,:apellido,:cuil,:dni)"
        Comando.Parameters.Add(New OracleParameter(":idpersona", OracleDbType.Int64, 10, "ID_PERSONA"))
        Comando.Parameters.Add(New OracleParameter(":nombre", OracleDbType.Varchar2, 100, "PERSONA_NOMBRE"))
        Comando.Parameters.Add(New OracleParameter(":apellido", OracleDbType.Varchar2, 100, "PERSONA_APELLIDO"))
        Comando.Parameters.Add(New OracleParameter(":cuil", OracleDbType.Int64, 11, "PERSONA_CUIL"))
        Comando.Parameters.Add(New OracleParameter(":dni", OracleDbType.Int64, 10, "PERSONA_DNI"))
        ActualizarSQL(Tabla)
    End Sub
End Class
