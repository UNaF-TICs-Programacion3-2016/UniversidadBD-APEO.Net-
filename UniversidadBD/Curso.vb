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
    Friend Sub InsertarCurso()
        Try
            Dim Tabla As String = "CURSO"
            InsertarSQL(Tabla)
            Fila("CURSO_RELA_MATERIA") = pMateria
            Fila("CURSO_N_COMISION") = pComision
            Fila("CURSO_RELA_HORA_DESDE") = pHoraD
            Fila("CURSO_RELA_MINUTO_DESDE") = pMinutoD
            Fila("CURSO_RELA_DIA") = pDia
            Fila("CURSO_RELA_AULA") = pAula
            Fila("CURSO_RELA_HORA_HASTA") = pHoraH
            Fila("CURSO_RELA_MINUTO_HASTA") = pMinutoH
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Curso VALUES(:idcurso,:relamateria,:comision,:horadesde,:minutodesde,:dia,:aula,:horahasta,:minutohasta) RETURNING ID_CURSO INTO :last_id"
            Comando.Parameters.Add(New OracleParameter(":idcurso", OracleDbType.Long, 10, "ID_CURSO"))
            Comando.Parameters.Add(New OracleParameter(":relamateria", OracleDbType.Long, 10, "CURSO_RELA_MATERIA"))
            Comando.Parameters.Add(New OracleParameter(":comision", OracleDbType.Varchar2, 10, "CURSO_N_COMISION"))
            Comando.Parameters.Add(New OracleParameter(":horadesde", OracleDbType.Long, 10, "CURSO_RELA_HORA_DESDE"))
            Comando.Parameters.Add(New OracleParameter(":minutodesde", OracleDbType.Long, 10, "CURSO_RELA_MINUTO_DESDE"))
            Comando.Parameters.Add(New OracleParameter(":dia", OracleDbType.Long, 10, "CURSO_RELA_DIA"))
            Comando.Parameters.Add(New OracleParameter(":aula", OracleDbType.Long, 10, "CURSO_RELA_AULA"))
            Comando.Parameters.Add(New OracleParameter(":horahasta", OracleDbType.Long, 10, "CURSO_RELA_HORA_HASTA"))
            Comando.Parameters.Add(New OracleParameter(":minutohasta", OracleDbType.Long, 10, "CURSO_RELA_MINUTO_HASTA"))
            Comando.Parameters.Add(New OracleParameter(":last_id", OracleDbType.Int64, 10, ParameterDirection.ReturnValue))
            ActualizarSQL(Tabla)
            Dim ID As String = (Comando.Parameters(":last_id").Value).ToString
            Me.pID = ID
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Friend Sub InsertarProfesorCurso()
        Dim Tabla As String = "CURSO_PROFESOR"
        Try
            InsertarSQL(Tabla)
            Fila("CURSO_PROFESOR_RELA_CURSO") = pID
            Fila("CURSO_PROFESOR_RELA_PROFESOR") = pProfesor
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Curso_Profesor VALUES(:idcursoprofe,:relacurso,:relaprofe)"
            Comando.Parameters.Add(New OracleParameter(":idcursoprofe", OracleDbType.Long, 10, "ID_CURSO_PROFESOR"))
            Comando.Parameters.Add(New OracleParameter(":relacurso", OracleDbType.Long, 10, "CURSO_PROFESOR_RELA_CURSO"))
            Comando.Parameters.Add(New OracleParameter(":relaprofe", OracleDbType.Long, 10, "CURSO_PROFESOR_RELA_PROFESOR"))
            ActualizarSQL(Tabla)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Friend Sub InsertarAlumnoCurso()
        Dim Tabla As String = "CURSO_ALUMNO"
        Try
            InsertarSQL(Tabla)
            Fila("CUR_ALU_RELA_CURSO") = pRelacion
            Fila("CUR_ALU_RELA_ALUMNO") = pAlumno
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Curso_Alumno VALUES(:idalucurso,:curso,:alumno)"
            Comando.Parameters.Add(New OracleParameter(":idalucurso", OracleDbType.Long, 10, "ID_CURSO_ALUMNO"))
            Comando.Parameters.Add(New OracleParameter(":curso", OracleDbType.Long, 10, "CUR_ALU_RELA_CURSO"))
            Comando.Parameters.Add(New OracleParameter(":alumno", OracleDbType.Long, 10, "CUR_ALU_RELA_ALUMNO"))
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
