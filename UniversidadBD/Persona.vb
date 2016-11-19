Imports Oracle.DataAccess.Client
Public Class Persona
    Inherits Coneccion
    Protected pNombre As String
    Private pApellido As String
    Private pCUIL As String
    Private pDNI As String
    Private pTelefono As String
    Private pCorreo As String
    'PROPIEDADES
    Friend Overridable Property Nombre() As String
        Get
            Return pNombre
        End Get
        Set(ByVal value As String)
            pNombre = value
        End Set
    End Property
    Friend Property Apellido() As String
        Get
            Return pApellido
        End Get
        Set(value As String)
            pApellido = value
        End Set
    End Property
    Friend Property CUIL() As String
        Get
            Return pCUIL
        End Get
        Set(value As String)
            pCUIL = value
        End Set
    End Property
    Friend Property DNI() As String
        Get
            Return pDNI
        End Get
        Set(value As String)
            pDNI = value
        End Set
    End Property
    Friend Property Telefono() As String
        Get
            Return pTelefono
        End Get
        Set(value As String)
            pTelefono = value
        End Set
    End Property
    Friend Property Correo() As String
        Get
            Return pCorreo
        End Get
        Set(value As String)
            pCorreo = value
        End Set
    End Property
    'METODOS
    Friend Sub InsertarPersona()
        Dim Tabla As String = "PERSONA"
        InsertarSQL(Tabla)
        Fila("PERSONA_NOMBRE") = F_Secundario.TXT_A_NombreAlumno.Text
        Fila("PERSONA_APELLIDO") = F_Secundario.TXT_A_ApellidoAlumno.Text
        Fila("PERSONA_CUIL") = F_Secundario.TXT_A_CUILAlumno.Text
        Fila("PERSONA_DNI") = F_Secundario.TXT_A_DNIAlumno.Text
        Insert(Tabla)
        Comando.Parameters.Clear()
        Comando.CommandText = "Insert Into Persona VALUES(:idpersona,:nombre,:apellido,:cuil,:dni)"
        Comando.Parameters.Add(New OracleParameter(":idpersona", OracleDbType.Int64, 10, "ID_PERSONA"))
        Comando.Parameters.Add(New OracleParameter(":nombre", OracleDbType.Varchar2, 100, "PERSONA_NOMBRE"))
        Comando.Parameters.Add(New OracleParameter(":apellido", OracleDbType.Varchar2, 100, "PERSONA_APELLIDO"))
        Comando.Parameters.Add(New OracleParameter(":cuil", OracleDbType.Int64, 11, "PERSONA_CUIL"))
        Comando.Parameters.Add(New OracleParameter(":dni", OracleDbType.Int64, 10, "PERSONA_DNI"))
        ActualizarSQL(Tabla)
    End Sub
    Friend Sub InsertarPersonaProfesor()
        Dim Tabla As String = "PERSONA"
        InsertarSQL(Tabla)
        Fila("PERSONA_NOMBRE") = F_Secundario.TXT_A_NombreProfesor.Text
        Fila("PERSONA_APELLIDO") = F_Secundario.TXT_A_ApellidoProfesor.Text
        Fila("PERSONA_CUIL") = F_Secundario.TXT_A_CUILProfesor.Text
        Fila("PERSONA_DNI") = F_Secundario.TXT_A_DNIProfesor.Text
        Insert(Tabla)
        Comando.Parameters.Clear()
        Comando.CommandText = "Insert Into Persona VALUES(:idpersona,:nombre,:apellido,:cuil,:dni)"
        Comando.Parameters.Add(New OracleParameter(":idpersona", OracleDbType.Int64, 10, "ID_PERSONA"))
        Comando.Parameters.Add(New OracleParameter(":nombre", OracleDbType.Varchar2, 100, "PERSONA_NOMBRE"))
        Comando.Parameters.Add(New OracleParameter(":apellido", OracleDbType.Varchar2, 100, "PERSONA_APELLIDO"))
        Comando.Parameters.Add(New OracleParameter(":cuil", OracleDbType.Int64, 11, "PERSONA_CUIL"))
        Comando.Parameters.Add(New OracleParameter(":dni", OracleDbType.Int64, 10, "PERSONA_DNI"))
        ActualizarSQL(Tabla)
    End Sub
    Friend Sub InsertarTelefonoProfesor()
        Dim Tabla As String = "PERSONA"
        Try
            InsertarSQL(Tabla)
            Dim Ultimo As Integer = Almacenamiento.Tables(Tabla).Rows.Count - 1
            Dim ID As String = Almacenamiento.Tables(Tabla).Rows(Ultimo)("ID_PERSONA").ToString
            Tabla = "TELEFONO"
            InsertarSQL(Tabla)
            Fila("TELEFONO_NUMERO") = F_Secundario.TXT_A_TelefonoProfesor.Text
            Fila("TELEFONO_RELA_PERSONA") = ID
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Telefono VALUES(:idtelefono,:numero,:relapersona)"
            Comando.Parameters.Add(New OracleParameter(":idtelefono", OracleDbType.Int64, 10, "ID_TELEFONO"))
            Comando.Parameters.Add(New OracleParameter(":numero", OracleDbType.Int64, 20, "TELEFONO_NUMERO"))
            Comando.Parameters.Add(New OracleParameter(":relapersona", OracleDbType.Int64, 10, "TELEFONO_RELA_PERSONA"))
            ActualizarSQL(Tabla)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Friend Sub InsertarTelefono()
        Dim Tabla As String = "PERSONA"
        Try
            InsertarSQL(Tabla)
            Dim Ultimo As Integer = Almacenamiento.Tables(Tabla).Rows.Count - 1
            Dim ID As String = Almacenamiento.Tables(Tabla).Rows(Ultimo)("ID_PERSONA").ToString
            Tabla = "TELEFONO"
            InsertarSQL(Tabla)
            Fila("TELEFONO_NUMERO") = F_Secundario.TXT_A_TelefonoAlumno.Text
            Fila("TELEFONO_RELA_PERSONA") = ID
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Telefono VALUES(:idtelefono,:numero,:relapersona)"
            Comando.Parameters.Add(New OracleParameter(":idtelefono", OracleDbType.Int64, 10, "ID_TELEFONO"))
            Comando.Parameters.Add(New OracleParameter(":numero", OracleDbType.Int64, 20, "TELEFONO_NUMERO"))
            Comando.Parameters.Add(New OracleParameter(":relapersona", OracleDbType.Int64, 10, "TELEFONO_RELA_PERSONA"))
            ActualizarSQL(Tabla)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Friend Sub InsertarCorreo()
        Dim Tabla As String = "PERSONA"
        Try
            InsertarSQL(Tabla)
            Dim Ultimo As Integer = Almacenamiento.Tables(Tabla).Rows.Count - 1
            Dim ID As String = Almacenamiento.Tables(Tabla).Rows(Ultimo)("ID_PERSONA").ToString
            Tabla = "CORREO"
            InsertarSQL(Tabla)
            Fila("CORREO_DESCRIPCION") = F_Secundario.TXT_A_CorreoAlumno.Text
            Fila("CORREO_RELA_PERSONA") = ID
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Correo VALUES(:idcorreo,:descripcion,:relapersona)"
            Comando.Parameters.Add(New OracleParameter(":idcorreo", OracleDbType.Int64, 10, "ID_CORREO"))
            Comando.Parameters.Add(New OracleParameter(":descripcion", OracleDbType.Varchar2, 100, "CORREO_DESCRIPCION"))
            Comando.Parameters.Add(New OracleParameter(":relapersona", OracleDbType.Int64, 10, "CORREO_RELA_PERSONA"))
            ActualizarSQL(Tabla)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Friend Sub InsertarCorreoProfesor()
        Dim Tabla As String = "PERSONA"
        Try
            InsertarSQL(Tabla)
            Dim Ultimo As Integer = Almacenamiento.Tables(Tabla).Rows.Count - 1
            Dim ID As String = Almacenamiento.Tables(Tabla).Rows(Ultimo)("ID_PERSONA").ToString
            Tabla = "CORREO"
            InsertarSQL(Tabla)
            Fila("CORREO_DESCRIPCION") = F_Secundario.TXT_A_CorreoProfesor.Text
            Fila("CORREO_RELA_PERSONA") = ID
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Correo VALUES(:idcorreo,:descripcion,:relapersona)"
            Comando.Parameters.Add(New OracleParameter(":idcorreo", OracleDbType.Int64, 10, "ID_CORREO"))
            Comando.Parameters.Add(New OracleParameter(":descripcion", OracleDbType.Varchar2, 100, "CORREO_DESCRIPCION"))
            Comando.Parameters.Add(New OracleParameter(":relapersona", OracleDbType.Int64, 10, "CORREO_RELA_PERSONA"))
            ActualizarSQL(Tabla)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
