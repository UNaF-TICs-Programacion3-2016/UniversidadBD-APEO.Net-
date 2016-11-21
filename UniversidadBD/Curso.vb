Imports Oracle.DataAccess.Client
Public Class Cursos
    Inherits Coneccion
    Private pMateria As String
    Private pComision As String
    Private pMinutoD As String
    Private pHoraD As String
    Private pHoraH As String
    Private pMinutoH As String
    Private pDia As String
    Private pAula As String
    Private pProfesor As String
    Private pRelacion As String
    Private pAlumno As String
    Private pID As String
    'PROPIEDADES
    Public Property Materia() As String
        Get
            Return pMateria
        End Get
        Set(ByVal value As String)
            pMateria = value
        End Set
    End Property
    Public Property Comision() As String
        Get
            Return pComision
        End Get
        Set(ByVal value As String)
            pComision = value
        End Set
    End Property
    Public Property MinutoD() As String
        Get
            Return pMinutoD
        End Get
        Set(ByVal value As String)
            pMinutoD = value
        End Set
    End Property
    Public Property HoraD() As String
        Get
            Return pHoraD
        End Get
        Set(ByVal value As String)
            pHoraD = value
        End Set
    End Property
    Public Property MinutoH() As String
        Get
            Return pMinutoH
        End Get
        Set(ByVal value As String)
            pMinutoH = value
        End Set
    End Property
    Public Property HoraH() As String
        Get
            Return pHoraH
        End Get
        Set(ByVal value As String)
            pHoraH = value
        End Set
    End Property
    Public Property Dia() As String
        Get
            Return pDia
        End Get
        Set(ByVal value As String)
            pDia = value
        End Set
    End Property
    Public Property Aula() As String
        Get
            Return pAula
        End Get
        Set(ByVal value As String)
            pAula = value
        End Set
    End Property
    Public Property Profesor() As String
        Get
            Return pProfesor
        End Get
        Set(ByVal value As String)
            pProfesor = value
        End Set
    End Property
    Public Property Relacion() As String
        Get
            Return pRelacion
        End Get
        Set(ByVal value As String)
            pRelacion = value
        End Set
    End Property
    Public Property Alumno() As String
        Get
            Return pAlumno
        End Get
        Set(ByVal value As String)
            pAlumno = value
        End Set
    End Property
    Public Property ID() As String
        Get
            Return pID
        End Get
        Set(ByVal value As String)
            pID = value
        End Set
    End Property
    'INSERTAR CURSO
    Friend Sub InsertarCursada()
        Dim Tabla As String = "CURSADA"
        Try
            InsertarSQL(Tabla)
            Fila("CURSADA_RELA_MATERIA") = pMateria
            Fila("CURSADA_COMISION") = pComision
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Cursada VALUES(:idcursada,:materia,:comision) RETURNING ID_CURSADA INTO :last_id"
            Comando.Parameters.Add(New OracleParameter(":idcursada", OracleDbType.Long, 10, "ID_CURSADA"))
            Comando.Parameters.Add(New OracleParameter(":materia", OracleDbType.Long, 10, "CURSADA_RELA_MATERIA"))
            Comando.Parameters.Add(New OracleParameter(":comision", OracleDbType.Long, 10, "CURSADA_COMISION"))
            Comando.Parameters.Add(New OracleParameter(":last_id", OracleDbType.Int32, ParameterDirection.ReturnValue))
            ActualizarSQL(Tabla)
            Dim ID As String = (Comando.Parameters(":last_id").Value).ToString
            pID = ID
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Friend Sub InsertarHorario()
        Dim Tabla As String = "HORARIO"
        Try
            InsertarSQL(Tabla)
            Fila("HORARIO_RELA_CURSADA") = pID
            Fila("HORARIO_RELA_HORA_DESDE") = pHoraD
            Fila("HORARIO_RELA_MINUTO_DESDE") = pMinutoD
            Fila("HORARIO_RELA_HORA_HASTA") = pHoraH
            Fila("HORARIO_RELA_MINUTO_HASTA") = pMinutoH
            Fila("HORARIO_RELA_DIA") = pDia
            Fila("HORARIO_RELA_AULA") = pAula
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Horario VALUES(:idhorario,:cursada,:horad,:minutod,:horah,:minutoh,:dia,:aula)"
            Comando.Parameters.Add(New OracleParameter(":idhorario", OracleDbType.Long, 10, "ID_HORARIO"))
            Comando.Parameters.Add(New OracleParameter(":cursada", OracleDbType.Long, 10, "HORARIO_RELA_CURSADA"))
            Comando.Parameters.Add(New OracleParameter(":horad", OracleDbType.Long, 10, "HORARIO_RELA_HORA_DESDE"))
            Comando.Parameters.Add(New OracleParameter(":minutod", OracleDbType.Long, 10, "HORARIO_RELA_MINUTO_DESDE"))
            Comando.Parameters.Add(New OracleParameter(":horah", OracleDbType.Long, 10, "HORARIO_RELA_HORA_HASTA"))
            Comando.Parameters.Add(New OracleParameter(":minutoh", OracleDbType.Long, 10, "HORARIO_RELA_MINUTO_HASTA"))
            Comando.Parameters.Add(New OracleParameter(":dia", OracleDbType.Long, 10, "HORARIO_RELA_DIA"))
            Comando.Parameters.Add(New OracleParameter(":aula", OracleDbType.Long, 10, "HORARIO_RELA_AULA"))
            ActualizarSQL(Tabla)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Friend Sub InsertarProfesorCursada()
        Dim Tabla As String = "CURSADA_PROFESOR"
        Try
            InsertarSQL(Tabla)
            Fila("CUR_PROFE_RELA_PROFESOR") = pProfesor
            Fila("CUR_PROFE_RELA_CURSADA") = pID
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Cursada_Profesor VALUES(:idcursoprofe,:relaprofe,:relacomision)"
            Comando.Parameters.Add(New OracleParameter(":idcursoprofe", OracleDbType.Long, 10, "ID_CUR_PROFE"))
            Comando.Parameters.Add(New OracleParameter(":relaprofe", OracleDbType.Long, 10, "CUR_PROFE_RELA_PROFESOR"))
            Comando.Parameters.Add(New OracleParameter(":relacomision", OracleDbType.Long, 10, "CUR_PROFE_RELA_CURSADA"))
            ActualizarSQL(Tabla)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Friend Sub InsertarAlumnoCursada()
        Dim Tabla As String = "CURSADA_ALUMNO"
        Try
            InsertarSQL(Tabla)
            Fila("CUR_ALU_RELA_ALUMNO") = pAlumno
            Fila("CUR_ALU_RELA_CURSADA") = pRelacion
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Cursada_Alumno VALUES(:idalucurso,:alumno,:comision)"
            Comando.Parameters.Add(New OracleParameter(":idalucurso", OracleDbType.Long, 10, "ID_CUR_ALU"))
            Comando.Parameters.Add(New OracleParameter(":alumno", OracleDbType.Long, 10, "CUR_ALU_RELA_ALUMNO"))
            Comando.Parameters.Add(New OracleParameter(":comision", OracleDbType.Long, 10, "CUR_ALU_RELA_CURSADA"))
            ActualizarSQL(Tabla)
            MessageBox.Show("Los datos han sido guardados correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'ELIMINAR CURSO
    Friend Sub EliminarCurso()
        Try
            Dim ID = F_Secundario.CMB_S_ComisionCurso.SelectedValue
            Comando.Connection = Conexion
            Comando.CommandText = "DELETE FROM CURSO WHERE ID_CURSO=" & ID
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
            MsgBox("Los datos han sido eliminados correctamente.")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
