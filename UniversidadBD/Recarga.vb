Public Class Recarga
    Private Shared Configuracion As New Configuracion()
    Private Shared Tabla As String
    Private Shared Columna As String
    Private Shared Valor As String
    Private Shared Condicion As String
    Public Shared Sub BuscarAlumno(Combo As ComboBox, Panel As Panel, DNI As String)
        Tabla = "PERSONA, ALUMNO"
        Columna = "PERSONA_APELLIDO"
        Valor = "ID_ALUMNO"
        Condicion = "PERSONA_DNI = " & DNI & " AND ID_PERSONA = ALUMNO_RELA_PERSONA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarCarrera(Combo As ComboBox, Panel As Panel)
        Tabla = "CARRERA"
        Columna = "DESCRIPCION"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna)
    End Sub
    Public Shared Sub CargarFacultad(Combo As ComboBox, Panel As Panel)
        Tabla = "FACULTAD"
        Columna = "DESCRIPCION"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna)
    End Sub
    Public Shared Sub CargarAula(Combo As ComboBox, Panel As Panel)
        Tabla = "AULA"
        Columna = "DESCRIPCION"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna)
    End Sub
    Public Shared Sub CargarMateria(Combo As ComboBox, Panel As Panel)
        Tabla = "MATERIA"
        Columna = "DESCRIPCION"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna)
    End Sub
    Public Shared Sub CargarHora(Combo As ComboBox, Panel As Panel)
        Tabla = "HORA"
        Columna = "NUMERO"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna)
    End Sub
    Public Shared Sub CargarMinuto(Combo As ComboBox, Panel As Panel)
        Tabla = "MINUTO"
        Columna = "NUMERO"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna)
    End Sub
    Public Shared Sub CargarProfesor(Combo As ComboBox, Panel As Panel)
        Tabla = "PERSONA, PROFESOR"
        Columna = "PERSONA_APELLIDO"
        Valor = "ID_PROFESOR"
        Condicion = "ID_PERSONA = PROFESOR_RELA_PERSONA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarDia(Combo As ComboBox, Panel As Panel)
        Tabla = "DIA"
        Columna = "DESCRIPCION"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna)
    End Sub
    Public Shared Sub CargarAula(Combo As ComboBox, Panel As Panel, Referencia As ComboBox)
        Tabla = "AULA"
        Columna = "DESCRIPCION"
        Condicion = "RELA_FACULTAD"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Condicion, Referencia)
    End Sub
    Public Shared Sub AgregarProfesor(Combo As ComboBox, Panel As Panel)
        Tabla = "PERSONA, PROFESOR"
        Columna = "PERSONA_APELLIDO"
        Valor = "ID_PROFESOR"
        Condicion = "ID_PERSONA= PROFESOR_RELA_PERSONA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)

    End Sub
    Public Shared Sub CargarCondicion(Combo As ComboBox, Panel As Panel)
        Tabla = "CONDICION"
        Columna = "DESCRIPCION"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna)
    End Sub
    Public Shared Sub CargarAlumno(Combo As ComboBox, Panel As Panel)
        Tabla = "ALUMNO,PERSONA"
        Columna = "PERSONA_APELLIDO"
        Valor = "ID_ALUMNO"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarOtro(Combo As ComboBox, Panel As Panel)
        Tabla = "PERSONA, ADMINISTRACION"
        Columna = "PERSONA_APELLIDO"
        Valor = "ID_ADMINISTRACION"
        Condicion = "ID_PERSONA=ADMIN_RELA_PERSONA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarPuesto(Combo As ComboBox, Panel As Panel)
        Tabla = "PUESTO_ADMIN"
        Columna = "DESCRIPCION"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna)
    End Sub
    Public Shared Sub CargarCarrera(Combo As ComboBox, Panel As Panel, Referencia As ComboBox)
        Tabla = "CARRERA"
        Columna = "DESCRIPCION"
        Condicion = "RELA_FACULTAD"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Condicion, Referencia)
    End Sub
    Public Shared Sub CargarExamen(Combo As ComboBox, Panel As Panel, Carrera As Integer)
        Tabla = "EXAMEN, MATERIA"
        Columna = "MATERIA_DESCRIPCION"
        Valor = "ID_EXAMEN"
        Condicion = "MATERIA_RELA_CARRERA=" & Carrera & " AND ID_MATERIA = EXAMEN_RELA_MATERIA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarComisiones(Combo As ComboBox, Panel As Panel)
        Tabla = "CURSO"
        Columna = "CURSO_N_COMISION"
        Valor = "CURSO_N_COMISION"
        Configuracion.EliminarRepetidos(Combo, Panel, Tabla, Columna, Valor)
    End Sub
    Public Shared Sub CargarCurso(Combo As ComboBox, Panel As Panel)
        Tabla = "MATERIA, CURSO"
        Columna = "MATERIA_DESCRIPCION"
        Valor = "ID_CURSO"
        Condicion = "ID_MATERIA = CURSO_RELA_MATERIA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarMateria(Combo As ComboBox, Panel As Panel, Referencia As ComboBox)
        Tabla = "MATERIA"
        Columna = "DESCRIPCION"
        Condicion = "RELA_CARRERA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Condicion, Referencia)
    End Sub
    Public Shared Sub CargarMateria(Combo As ComboBox, Panel As Panel, ID As Integer)
        Tabla = "MATERIA, EXAMEN"
        Columna = "MATERIA_DESCRIPCION"
        Valor = "ID_MATERIA"
        Condicion = "MATERIA_RELA_CARRERA = " & ID & " AND EXAMEN_RELA_MATERIA = ID_MATERIA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarExamenLlamado(Combo As ComboBox, Panel As Panel, ID As Integer)
        Tabla = "EXAMEN"
        Columna = "EXAMEN_LLAMADO"
        Valor = "ID_EXAMEN"
        Condicion = "EXAMEN_RELA_MATERIA = " & ID & " AND EXAMEN_RELA_TIPO_EXAMEN <> 1"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarCurso(Combo As ComboBox, Panel As Panel, ID As Integer, Comision As String)
        Tabla = "MATERIA, CURSO"
        Columna = "MATERIA_DESCRIPCION"
        Valor = "ID_CURSO"
        Condicion = "MATERIA_RELA_CARRERA = " & ID & " AND ID_MATERIA = CURSO_RELA_MATERIA AND CURSO_N_COMISION = " & Comision
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarLlamados(Combo As ComboBox, Panel As Panel)
        Tabla = "EXAMEN"
        Columna = "EXAMEN_LLAMADO"
        Valor = "EXAMEN_LLAMADO"
        Condicion = "EXAMEN_LLAMADO <> 0"
        Configuracion.EliminarRepetidos(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarExamenLlamado(Combo As ComboBox, Panel As Panel)
        Tabla = "EXAMEN"
        Columna = "EXAMEN_LLAMADO"
        Valor = "EXAMEN_LLAMADO"
        Condicion = "EXAMEN_RELA_TIPO_EXAMEN = 2"
        Configuracion.EliminarRepetidos(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarExamen(Combo As ComboBox, Panel As Panel, Carrera As Integer, Llamado As Integer)
        Tabla = "MATERIA, EXAMEN"
        Columna = "MATERIA_DESCRIPCION"
        Valor = "ID_EXAMEN"
        Condicion = "MATERIA_RELA_CARRERA = " & Carrera & " AND EXAMEN_RELA_MATERIA = ID_MATERIA AND EXAMEN_LLAMADO = " & Llamado & " AND EXAMEN_RELA_TIPO_EXAMEN = 2"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarAlumnoExamen(Combo As ComboBox, Panel As Panel, Examen As Integer)
        Tabla = "PERSONA, ALUMNO, ALUMNO_EXAMEN"
        Columna = "PERSONA_APELLIDO"
        Valor = "ID_ALUMNO_EXAMEN"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA AND ID_ALUMNO = ALU_EXA_RELA_ALUMNO AND ALU_EXA_RELA_EXAMEN = " & Examen
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarMateriasCurso(Lista As ListBox, Panel As Panel, Carrera As String, Referencia As ComboBox)
        Tabla = "MATERIA, CURSO"
        Columna = "MATERIA_DESCRIPCION"
        Condicion = "MATERIA_RELA_CARRERA = " & Carrera & " AND ID_MATERIA = CURSO_RELA_MATERIA"
        Configuracion.CargarListBox(Lista, Panel, Tabla, Columna, Condicion)
    End Sub
    Public Shared Sub CargarCurso1(Combo As ComboBox, Panel As Panel, Carrera As Integer, Comision As Integer)
        Tabla = "MATERIA, CURSO"
        Columna = "MATERIA_DESCRIPCION"
        Valor = "ID_CURSO"
        Condicion = "MATERIA_RELA_CARRERA = " & Carrera & " AND ID_MATERIA = CURSO_RELA_MATERIA AND CURSO_N_COMISION = " & Comision
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarExamenLlamado(Combo As ComboBox, Panel As Panel, Carrera As Integer, Llamado As Integer)
        Tabla = "MATERIA, EXAMEN"
        Columna = "MATERIA_DESCRIPCION"
        Valor = "ID_EXAMEN"
        Condicion = "MATERIA_RELA_CARRERA = " & Carrera & " AND ID_MATERIA = EXAMEN_RELA_MATERIA AND EXAMEN_LLAMADO = " & Llamado
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarFiltroPersonas(L_Alumno As ListBox, L_Profesor As ListBox, Panel As Panel, Materia As Integer, Comision As Integer, Referencia As ComboBox)
        Referencia.ValueMember = "ID_CURSO"
        Tabla = "PERSONA, ALUMNO, CURSO_ALUMNO"
        Columna = "PERSONA_APELLIDO"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA AND ID_ALUMNO = CUR_ALU_RELA_ALUMNO AND CUR_ALU_RELA_CURSO = " & Materia
        Configuracion.CargarListBox(L_Alumno, Panel, Tabla, Columna, Condicion)
        Tabla = "PERSONA, PROFESOR, CURSO_PROFESOR"
        Columna = "PERSONA_APELLIDO"
        Condicion = "ID_PERSONA = PROFESOR_RELA_PERSONA AND ID_PROFESOR = CURSO_PROFESOR_RELA_PROFESOR AND CURSO_PROFESOR_RELA_CURSO = " & Materia
        Configuracion.CargarListBox(L_Profesor, Panel, Tabla, Columna, Condicion)
    End Sub
    Public Shared Sub CargarAulaYHorarios(Datos As DataGridView, Panel As Panel, Materia As Integer, Comision As Integer, Referencia As ComboBox)
        Referencia.ValueMember = "ID_MATERIA"
        Tabla = "CURSO, HORA, MINUTO, DIA, AULA"
        Columna = "HORA_NUMERO, MINUTO_NUMERO, DIA_DESCRIPCION, AULA_DESCRIPCION"
        Condicion = "CURSO_RELA_MATERIA = " & Materia & " AND CURSO_N_COMISION = " & Comision & " AND ID_HORA = CURSO_RELA_HORA_DESDE AND ID_MINUTO = CURSO_RELA_MINUTO_DESDE AND ID_DIA = CURSO_RELA_DIA AND ID_AULA = CURSO_RELA_AULA"
        Configuracion.CargarDGV(Datos, Panel, Tabla, Columna, Condicion)
    End Sub
    Public Shared Sub CargarProfeExamenFinal(Lista As ListBox, Panel As Panel, Materia As Integer)
        Tabla = "PERSONA, PROFESOR, EXAMEN_PROFESOR"
        Columna = "PERSONA_APELLIDO"
        Condicion = "ID_PERSONA = PROFESOR_RELA_PERSONA AND ID_PROFESOR = EXA_PROFE_RELA_PROFESORES AND EXA_PROFE_RELA_EXAMEN = " & Materia
        Configuracion.CargarListBox(Lista, Panel, Tabla, Columna, Condicion)
    End Sub
    Public Shared Sub CargarAlumnosInscriptosEF(Datos As DataGridView, Panel As Panel, Materia As Integer)
        Tabla = "PERSONA, ALUMNO, EXAMEN, CONDICION, NOTA, ALUMNO_EXAMEN"
        Columna = "PERSONA_APELLIDO, CONDICION_DESCRIPCION, NOTA_NOTA"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA AND ID_ALUMNO = ALU_EXA_RELA_ALUMNO AND ID_CONDICION = ALU_EXA_RELA_CONDICION AND ID_EXAMEN = " & Materia & " AND ALU_EXA_RELA_EXAMEN = ID_EXAMEN AND NOTA_RELA_ALUMNO_EXAMEN = ID_ALUMNO_EXAMEN"
        Configuracion.CargarDGV(Datos, Panel, Tabla, Columna, Condicion)
    End Sub
    Public Shared Sub CargarExamenFecha(Lista As ListBox, Panel As Panel, Materia As Integer)
        Tabla = "EXAMEN"
        Columna = "EXAMEN_FECHA"
        Condicion = "ID_EXAMEN = " & Materia
        Configuracion.CargarListBox(Lista, Panel, Tabla, Columna, Condicion)
    End Sub
    Public Shared Sub CargarExamenHora(Lista As ListBox, Panel As Panel, Materia As Integer)
        Tabla = "EXAMEN, HORA"
        Columna = "HORA_NUMERO"
        Condicion = "ID_HORA = EXAMEN_RELA_HORA AND ID_EXAMEN = " & Materia
        Configuracion.CargarListBox(Lista, Panel, Tabla, Columna, Condicion)
    End Sub
    Public Shared Sub DatosAlumno(L_Nombre As ListBox, L_Apellido As ListBox, L_CUIL As ListBox, L_NLegajo As ListBox, Panel As Panel, DNI As String)
        Tabla = "PERSONA, ALUMNO"
        Columna = "PERSONA_NOMBRE"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI
        Configuracion.CargarListBox(L_Nombre, Panel, Tabla, Columna, Condicion)
        Columna = "PERSONA_APELLIDO"
        Configuracion.CargarListBox(L_Apellido, Panel, Tabla, Columna, Condicion)
        Columna = "PERSONA_CUIL"
        Configuracion.CargarListBox(L_CUIL, Panel, Tabla, Columna, Condicion)
        Columna = "ALUMNO_NUMERO_LEGAJO"
        Configuracion.CargarListBox(L_NLegajo, Panel, Tabla, Columna, Condicion)
    End Sub
    Public Shared Sub CargarFacultadAlumnos(Lista As ListBox, Panel As Panel, DNI As String)
        Tabla = "FACULTAD, CARRERA, PERSONA, ALUMNO, ALUMNO_CARRERA"
        Columna = "FACULTAD_DESCRIPCION"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI & " AND ID_ALUMNO = ALU_CARRE_RELA_ALUMNO AND ID_FACULTAD = CARRERA_RELA_FACULTAD AND ID_CARRERA = ALU_CARRE_RELA_CARRERA"
        Configuracion.CargarListBox(Lista, Panel, Tabla, Columna, Condicion)
    End Sub
    Public Shared Sub CargarCarreraAlumnos(Lista As ListBox, Panel As Panel, DNI As String)
        Tabla = "PERSONA, ALUMNO, CARRERA, ALUMNO_CARRERA"
        Columna = "CARRERA_DESCRIPCION"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI & " AND ID_ALUMNO = ALU_CARRE_RELA_ALUMNO AND ID_CARRERA = ALU_CARRE_RELA_CARRERA"
        Configuracion.CargarListBox(Lista, Panel, Tabla, Columna, Condicion)
    End Sub
    Public Shared Sub CargarMateriasCurso(Lista As ListBox, Panel As Panel, DNI As String)
        Tabla = "PERSONA, ALUMNO, MATERIA, CURSO, CURSO_ALUMNO"
        Columna = "MATERIA_DESCRIPCION"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI & " AND ID_MATERIA = CURSO_RELA_MATERIA AND ID_CURSO = CUR_ALU_RELA_CURSO AND ID_ALUMNO = CUR_ALU_RELA_ALUMNO"
        Configuracion.CargarListBox(Lista, Panel, Tabla, Columna, Condicion)
    End Sub
    Public Shared Sub CargarMateriasAprobadas(Lista As ListBox, Panel As Panel, DNI As String)
        Tabla = "PERSONA, ALUMNO, MATERIA, EXAMEN, ALUMNO_EXAMEN, NOTA"
        Columna = "MATERIA_DESCRIPCION"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI & " AND ID_MATERIA = EXAMEN_RELA_MATERIA AND EXAMEN_RELA_TIPO_EXAMEN = 2 AND ALU_EXA_RELA_EXAMEN = ID_EXAMEN AND ALU_EXA_RELA_ALUMNO = ID_ALUMNO AND ID_ALUMNO_EXAMEN = NOTA_RELA_ALUMNO_EXAMEN AND NOTA_NOTA > 5"
        Configuracion.CargarListBox(Lista, Panel, Tabla, Columna, Condicion)
    End Sub
    Public Shared Sub CargarInscripcionesExamen(Lista As ListBox, Panel As Panel, DNI As String)
        Tabla = "PERSONA, ALUMNO, MATERIA, EXAMEN, ALUMNO_EXAMEN"
        Columna = "MATERIA_DESCRIPCION"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI & " AND ID_MATERIA = EXAMEN_RELA_MATERIA AND EXAMEN_RELA_TIPO_EXAMEN = 2 AND ALU_EXA_RELA_EXAMEN = ID_EXAMEN AND ALU_EXA_RELA_ALUMNO = ID_ALUMNO AND EXAMEN_FECHA > CURRENT_DATE"
        Configuracion.CargarListBox(Lista, Panel, Tabla, Columna, Condicion)
    End Sub
    Public Shared Sub CargarNotas(Datos As DataGridView, Panel As Panel, DNI As String)
        Tabla = "PERSONA, ALUMNO, EXAMEN, MATERIA, ALUMNO_EXAMEN, NOTA, CONDICION"
        Columna = "MATERIA_DESCRIPCION, NOTA_NOTA, EXAMEN_FECHA, CONDICION_DESCRIPCION"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI & " AND ID_MATERIA = EXAMEN_RELA_MATERIA AND ID_CONDICION = ALU_EXA_RELA_CONDICION AND EXAMEN_RELA_TIPO_EXAMEN = 2 AND ID_EXAMEN = ALU_EXA_RELA_EXAMEN AND ID_ALUMNO = ALU_EXA_RELA_ALUMNO AND ID_ALUMNO_EXAMEN = NOTA_RELA_ALUMNO_EXAMEN"
        Configuracion.CargarDGV(Datos, Panel, Tabla, Columna, Condicion)
    End Sub
End Class
