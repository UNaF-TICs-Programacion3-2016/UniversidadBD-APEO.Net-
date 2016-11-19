Imports Oracle.DataAccess.Client
Public NotInheritable Class Otros
    Inherits Persona
    Private pFechaDeIngreso As Date
    Private pPuesto As String
    Private pFacultad As String
    'PROPIEDADES HEREDADAS
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
            Return MyBase.Correo
        End Get
        Set(value As String)
            MyBase.Correo = value
        End Set
    End Property
    'PROPIEDADES ESPECIALES
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
    Friend Property Facultad() As String
        Get
            Return pFacultad
        End Get
        Set(value As String)
            pFacultad = value
        End Set
    End Property
    'METODOS HEREDADOS
    Protected Overrides Function InsertarPersona() As String
        Return MyBase.InsertarPersona()
    End Function
    Protected Overrides Sub InsertarTelefono(ID As String)
        MyBase.InsertarTelefono(ID)
    End Sub
    Protected Overrides Sub InsertarCorreo(ID As String)
        MyBase.InsertarCorreo(ID)
    End Sub
    'INSERTAR OTRO
    Friend Sub InsertarOtro()
        Dim Tabla As String = "ADMINISTRACION"
        Dim ID As String = InsertarPersona()
        Try
            InsertarSQL(Tabla)
            Fila("ADMIN_FECHA_INGRESO") = pFechaDeIngreso
            Fila("ADMIN_RELA_PERSONA") = ID
            Fila("ADMIN_RELA_PUESTO") = pPuesto
            Fila("ADMIN_RELA_FACULTAD") = pFacultad
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
