Imports Oracle.DataAccess.Client
Public MustInherit Class Persona
    Inherits Coneccion
    Protected pNombre As String
    Protected pApellido As String
    Protected pCUIL As String
    Protected pDNI As String
    Protected pTelefono As String
    Protected pCorreo As String
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
    Friend Overridable Property Correo() As String
        Get
            Return pCorreo
        End Get
        Set(value As String)
            pCorreo = value
        End Set
    End Property
    'METODOS INSERTAR
    Protected Overridable Function InsertarPersona() As String
        Try
            Dim Tabla As String = "PERSONA"
            InsertarSQL(Tabla)
            Fila("PERSONA_NOMBRE") = pNombre
            Fila("PERSONA_APELLIDO") = pApellido
            Fila("PERSONA_CUIL") = pCUIL
            Fila("PERSONA_DNI") = pDNI
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Persona VALUES(:idpersona,:nombre,:apellido,:cuil,:dni) RETURNING ID_PERSONA INTO :last_id"
            Comando.Parameters.Add(New OracleParameter(":idpersona", OracleDbType.Int64, 10, "ID_PERSONA"))
            Comando.Parameters.Add(New OracleParameter(":nombre", OracleDbType.Varchar2, 100, "PERSONA_NOMBRE"))
            Comando.Parameters.Add(New OracleParameter(":apellido", OracleDbType.Varchar2, 100, "PERSONA_APELLIDO"))
            Comando.Parameters.Add(New OracleParameter(":cuil", OracleDbType.Int64, 11, "PERSONA_CUIL"))
            Comando.Parameters.Add(New OracleParameter(":dni", OracleDbType.Int64, 10, "PERSONA_DNI"))
            Comando.Parameters.Add(New OracleParameter(":last_id", OracleDbType.Int32, ParameterDirection.ReturnValue))
            ActualizarSQL(Tabla)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Dim ID As String = (Comando.Parameters(":last_id").Value).ToString
        InsertarTelefono(ID)
        InsertarCorreo(ID)
        Return ID
    End Function
    Protected Overridable Sub InsertarTelefono(ID As String)
        Dim Tabla As String = "TELEFONO"
        Try
            InsertarSQL(Tabla)
            Fila("TELEFONO_NUMERO") = pTelefono
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
    Protected Overridable Sub InsertarCorreo(ID As String)
        Dim Tabla As String = "CORREO"
        Try
            InsertarSQL(Tabla)
            Fila("CORREO_DESCRIPCION") = pCorreo
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
    'METODOS EDITAR
    Protected Overridable Sub EditarPersona(ID As String)
        Try
            Comando.Connection = Conexion
            Comando.CommandText = "UPDATE PERSONA SET PERSONA_CUIL = '" & pCUIL & "', PERSONA_NOMBRE = '" & pNombre & "', PERSONA_APELLIDO = '" & pApellido & "', PERSONA_DNI = '" & pDNI & "' WHERE ID_PERSONA = '" & ID & "'"
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Protected Overridable Sub EditarTelefono(ID As String)
        Try
            Comando.CommandText = "UPDATE TELEFONO SET TELEFONO_NUMERO = '" & pTelefono & "' WHERE TELEFONO_RELA_PERSONA = '" & ID & "'"
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Protected Overridable Sub EditarCorreo(ID As String)
        Try
            Comando.CommandText = "UPDATE CORREO SET CORREO_DESCRIPCION = '" & pCorreo & "' WHERE CORREO_RELA_PERSONA = '" & ID & "'"
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
