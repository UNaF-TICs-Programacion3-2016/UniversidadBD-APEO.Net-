Imports Oracle.DataAccess.Client
Public Class Examen
    Inherits Coneccion
    Private pFecha As Date
    Private pHora As Integer
    Private pTipo As String
    Private pCondicion As String
    Private pMinuto As String
    Private pLlamado As Integer
    Private pNumeroParcial As Integer
    Private pAula As String
    Private pMateria As String
    Private pProfesor As String
    Private pAlumno As String
    Private pRelacion As String
    Private pNota As String
    'PROPIEDADES
    Public Property Fecha() As Date
        Get
            Return pFecha
        End Get
        Set(ByVal value As Date)
            pFecha = value
        End Set
    End Property
    Public Property Hora() As String
        Get
            Return pHora
        End Get
        Set(ByVal value As String)
            pHora = value
        End Set
    End Property
    Public Property Tipo() As String
        Get
            Return pTipo
        End Get
        Set(ByVal value As String)
            pTipo = value
        End Set
    End Property
    Public Property Condicion() As String
        Get
            Return pCondicion
        End Get
        Set(ByVal value As String)
            pCondicion = value
        End Set
    End Property
    Public Property Minuto() As String
        Get
            Return pMinuto
        End Get
        Set(ByVal value As String)
            pMinuto = value
        End Set
    End Property
    Public Property Llamado() As Integer
        Get
            Return pLlamado
        End Get
        Set(ByVal value As Integer)
            pLlamado = value
        End Set
    End Property
    Public Property NumeroParcial() As Integer
        Get
            Return pNumeroParcial
        End Get
        Set(ByVal value As Integer)
            pNumeroParcial = value
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
    Public Property Materia() As String
        Get
            Return pMateria
        End Get
        Set(ByVal value As String)
            pMateria = value
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
    Public Property Nota() As String
        Get
            Return pNota
        End Get
        Set(ByVal value As String)
            pNota = value
        End Set
    End Property
    'INSERTAR EXAMEN
    Friend Sub InsertarExamen()
        Try
            Dim Tabla As String = "EXAMEN"
            InsertarSQL(Tabla)
            Fila("EXAMEN_RELA_MATERIA") = pMateria
            Fila("EXAMEN_FECHA") = Fecha
            Fila("EXAMEN_RELA_HORA") = Hora
            If Tipo = True Then
                Fila("EXAMEN_RELA_TIPO_EXAMEN") = 2
            Else
                Fila("EXAMEN_RELA_TIPO_EXAMEN") = 1
            End If
            Fila("EXAMEN_RELA_MINUTO") = pMinuto
            Fila("EXAMEN_LLAMADO") = pLlamado
            Fila("EXAMEN_NUMERO_PARCIAL") = pNumeroParcial
            Fila("EXAMEN_RELA_AULA") = pAula
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Examen VALUES(:idexamen,:relamateria,:fecha,:hora,:tipo,:minuto,:llamado,:numeroparcial,:aula)"
            Comando.Parameters.Add(New OracleParameter(":idexamen", OracleDbType.Int64, 10, "ID_EXAMEN"))
            Comando.Parameters.Add(New OracleParameter(":relamateria", OracleDbType.Int64, 10, "EXAMEN_RELA_MATERIA"))
            Comando.Parameters.Add(New OracleParameter(":fecha", OracleDbType.Date, 0, "EXAMEN_FECHA"))
            Comando.Parameters.Add(New OracleParameter(":hora", OracleDbType.Int64, 10, "EXAMEN_RELA_HORA"))
            Comando.Parameters.Add(New OracleParameter(":tipo", OracleDbType.Int64, 10, "EXAMEN_RELA_TIPO_EXAMEN"))
            Comando.Parameters.Add(New OracleParameter(":minuto", OracleDbType.Int64, 10, "EXAMEN_RELA_MINUTO"))
            Comando.Parameters.Add(New OracleParameter(":llamado", OracleDbType.Int64, 2, "EXAMEN_LLAMADO"))
            Comando.Parameters.Add(New OracleParameter(":numeroparcial", OracleDbType.Int64, 2, "EXAMEN_NUMERO_PARCIAL"))
            Comando.Parameters.Add(New OracleParameter(":aula", OracleDbType.Int64, 10, "EXAMEN_RELA_AULA"))
            ActualizarSQL(Tabla)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Friend Sub InsertarProfesorExamen()
        Try
            Dim Tabla As String = "EXAMEN"
            InsertarSQL(Tabla)
            Dim Ultimo As Integer = (Almacenamiento.Tables(Tabla).Rows.Count) - 1
            Dim ID As Integer = Almacenamiento.Tables(Tabla).Rows(Ultimo)("ID_EXAMEN")
            Tabla = "EXAMEN_PROFESOR"
            InsertarSQL(Tabla)
            Fila("EXA_PROFE_RELA_EXAMEN") = ID
            Fila("EXA_PROFE_RELA_PROFESORES") = pProfesor
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Examen_Profesor VALUES(:idexaprofe,:relaexamen,:relaprofe)"
            Comando.Parameters.Add(New OracleParameter(":idexaprofe", OracleDbType.Long, 10, "ID_EXAMEN_PROFESOR"))
            Comando.Parameters.Add(New OracleParameter(":relaexamen", OracleDbType.Long, 10, "EXA_PROFE_RELA_EXAMEN"))
            Comando.Parameters.Add(New OracleParameter(":relaprofe", OracleDbType.Long, 10, "EXA_PROFE_RELA_PROFESORES"))
            ActualizarSQL(Tabla)
            F_Secundario.LTB_A_ProfesoresExamen.Items.Add(F_Secundario.CMB_A_ProfesoresExamen.Text)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Friend Sub InscripcionExamen()
        Try
            Dim Tabla As String = "ALUMNO_EXAMEN"
            InsertarSQL(Tabla)
            Fila("ALU_EXA_RELA_EXAMEN") = pRelacion
            Fila("ALU_EXA_RELA_ALUMNO") = pAlumno
            Fila("ALU_EXA_RELA_CONDICION") = pCondicion
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Alumno_Examen VALUES(:idexaalumno,:examen,:alumno,:condicion)"
            Comando.Parameters.Add(New OracleParameter(":idexaalumno", OracleDbType.Long, 10, "ID_ALUMNO_EXAMEN"))
            Comando.Parameters.Add(New OracleParameter(":examen", OracleDbType.Long, 10, "ALU_EXA_RELA_EXAMEN"))
            Comando.Parameters.Add(New OracleParameter(":alumno", OracleDbType.Long, 10, "ALU_EXA_RELA_ALUMNO"))
            Comando.Parameters.Add(New OracleParameter(":condicion", OracleDbType.Long, 10, "ALU_EXA_RELA_CONDICION"))
            ActualizarSQL(Tabla)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Friend Sub NotaExamenFinal()
        Try
            Dim Tabla As String = "NOTA"
            InsertarSQL(Tabla)
            Fila("NOTA_NOTA") = pNota
            Fila("NOTA_RELA_ALUMNO_EXAMEN") = pRelacion
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Nota VALUES(:idnota,:nota,:alumnoexa)"
            Comando.Parameters.Add(New OracleParameter(":idnota", OracleDbType.Long, 10, "ID_NOTA"))
            Comando.Parameters.Add(New OracleParameter(":nota", OracleDbType.Long, 10, "NOTA_NOTA"))
            Comando.Parameters.Add(New OracleParameter(":alumnoexa", OracleDbType.Long, 10, "NOTA_RELA_ALUMNO_EXAMEN"))
            ActualizarSQL(Tabla)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'ELIMINAR EXAMEN
    Friend Sub EliminarExamen()
        Try
            Dim ID = F_Secundario.CMB_S_SeleccionarFinalExamenFinal.SelectedValue
            Comando.Connection = Conexion
            Comando.CommandText = "DELETE FROM EXAMEN WHERE ID_EXAMEN=" & ID
            Conexion.Open()
            Comando.ExecuteNonQuery()
            Conexion.Close()
            MsgBox("Los datos han sido eliminados correctamente.")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
