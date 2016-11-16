Imports Oracle.DataAccess.Client
Public Class Cursos
    Inherits Coneccion
    Private pComision As String
    'PROPIEDADES
    Public Property Comision() As String
        Get
            Return pComision
        End Get
        Set(ByVal value As String)
            pComision = value
        End Set
    End Property
    'INSERTAR CURSO
    Friend Sub InsertarCurso()
        Try
            Dim Tabla As String = "CURSO"
            Dim Materia As String = F_Secundario.CMB_A_MateriaCurso.SelectedValue
            Dim HoraD As String = F_Secundario.CMB_A_DesdeHoraCurso.SelectedValue
            Dim MinutoD As String = F_Secundario.CMB_A_DesdeMinutosCurso.SelectedValue
            Dim HoraH As String = F_Secundario.CMB_A_HastaHoraCurso.SelectedValue
            Dim MinutoH As String = F_Secundario.CMB_A_HastaMinutosCurso.SelectedValue
            Dim Dia As String = F_Secundario.CMB_A_DiaCurso.SelectedValue
            Dim Aula As String = F_Secundario.CMB_A_AulaCurso.SelectedValue
            InsertarSQL(Tabla)
            Fila("CURSO_RELA_MATERIA") = Materia
            Fila("CURSO_N_COMISION") = F_Secundario.Curso.Comision
            Fila("CURSO_RELA_HORA_DESDE") = HoraD
            Fila("CURSO_RELA_MINUTO_DESDE") = MinutoD
            Fila("CURSO_RELA_DIA") = Dia
            Fila("CURSO_RELA_AULA") = Aula
            Fila("CURSO_RELA_HORA_HASTA") = HoraH
            Fila("CURSO_RELA_MINUTO_HASTA") = MinutoH
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Curso VALUES(:idcurso,:relamateria,:comision,:horadesde,:minutodesde,:dia,:aula,:horahasta,:minutohasta)"
            Comando.Parameters.Add(New OracleParameter(":idcurso", OracleDbType.Long, 10, "ID_CURSO"))
            Comando.Parameters.Add(New OracleParameter(":relamateria", OracleDbType.Long, 10, "CURSO_RELA_MATERIA"))
            Comando.Parameters.Add(New OracleParameter(":comision", OracleDbType.Varchar2, 10, "CURSO_N_COMISION"))
            Comando.Parameters.Add(New OracleParameter(":horadesde", OracleDbType.Long, 10, "CURSO_RELA_HORA_DESDE"))
            Comando.Parameters.Add(New OracleParameter(":minutodesde", OracleDbType.Long, 10, "CURSO_RELA_MINUTO_DESDE"))
            Comando.Parameters.Add(New OracleParameter(":dia", OracleDbType.Long, 10, "CURSO_RELA_DIA"))
            Comando.Parameters.Add(New OracleParameter(":aula", OracleDbType.Long, 10, "CURSO_RELA_AULA"))
            Comando.Parameters.Add(New OracleParameter(":horahasta", OracleDbType.Long, 10, "CURSO_RELA_HORA_HASTA"))
            Comando.Parameters.Add(New OracleParameter(":minutohasta", OracleDbType.Long, 10, "CURSO_RELA_MINUTO_HASTA"))
            ActualizarSQL(Tabla)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Friend Sub InsertarProfesorCurso()
        Try
            Dim Tabla As String = "CURSO"
            InsertarSQL(Tabla)
            Dim Ultimo As Integer = (Almacenamiento.Tables(Tabla).Rows.Count) - 1
            Dim ID As String = Almacenamiento.Tables(Tabla).Rows(Ultimo)("ID_CURSO").ToString
            Dim Profesor As String = F_Secundario.CMB_A_ProfesoresCurso.SelectedValue
            Tabla = "CURSO_PROFESOR"
            InsertarSQL(Tabla)
            Fila("CURSO_PROFESOR_RELA_CURSO") = ID
            Fila("CURSO_PROFESOR_RELA_PROFESOR") = Profesor
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Curso_Profesor VALUES(:idcursoprofe,:relacurso,:relaprofe)"
            Comando.Parameters.Add(New OracleParameter(":idcursoprofe", OracleDbType.Long, 10, "ID_CURSO_PROFESOR"))
            Comando.Parameters.Add(New OracleParameter(":relacurso", OracleDbType.Long, 10, "CURSO_PROFESOR_RELA_CURSO"))
            Comando.Parameters.Add(New OracleParameter(":relaprofe", OracleDbType.Long, 10, "CURSO_PROFESOR_RELA_PROFESOR"))
            ActualizarSQL(Tabla)
            F_Secundario.LTB_A_ProfesoresCurso.Items.Add(F_Secundario.CMB_A_ProfesoresCurso.Text)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Friend Sub InsertarAlumnoCurso()
        Try
            Dim Tabla As String = "CURSO_ALUMNO"
            Dim Curso As String = F_Secundario.CMB_A_CursoIC.SelectedValue
            Dim Alumno As String = F_Secundario.CMB_A_AlumnoIC.SelectedValue
            InsertarSQL(Tabla)
            Fila("CUR_ALU_RELA_CURSO") = Curso
            Fila("CUR_ALU_RELA_ALUMNO") = Alumno
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
