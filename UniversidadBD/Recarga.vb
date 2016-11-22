Public Class Recarga
    Private Shared Configuracion As New Configuracion()
    Private Shared Tabla As String
    Private Shared Columna As String
    Private Shared Valor As String
    Private Shared Condicion As String
    'FACULTAD
    Public Shared Sub CargarFacultad(Combo As ComboBox, Panel As Panel)
        Tabla = "FACULTAD"
        Columna = "DESCRIPCION"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna)
    End Sub
    Public Shared Sub CargarFacultadAlumnos(Lista As ListBox, Panel As Panel, DNI As String)
        Tabla = "FACULTAD, CARRERA, PERSONA, ALUMNO, ALUMNO_CARRERA"
        Columna = "FACULTAD_DESCRIPCION"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI & " AND ID_ALUMNO = ALU_CARRE_RELA_ALUMNO AND ID_FACULTAD = CARRERA_RELA_FACULTAD AND ID_CARRERA = ALU_CARRE_RELA_CARRERA"
        Configuracion.CargarListBox(Lista, Panel, Tabla, Columna, Condicion)
    End Sub
    'CARRERA
    Public Shared Sub CargarCarrera(Combo As ComboBox, Panel As Panel)
        Tabla = "CARRERA"
        Columna = "DESCRIPCION"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna)
    End Sub
    Public Shared Sub CargarCarrera(Combo As ComboBox, Panel As Panel, Facultad As ComboBox)
        Tabla = "CARRERA"
        Columna = "DESCRIPCION"
        Condicion = "RELA_FACULTAD"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Condicion, Facultad)
    End Sub
    Public Shared Sub CargarCarreraAlumnos(Lista As ListBox, Panel As Panel, DNI As String)
        Tabla = "PERSONA, ALUMNO, CARRERA, ALUMNO_CARRERA"
        Columna = "CARRERA_DESCRIPCION"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI & " AND ID_ALUMNO = ALU_CARRE_RELA_ALUMNO AND ID_CARRERA = ALU_CARRE_RELA_CARRERA"
        Configuracion.CargarListBox(Lista, Panel, Tabla, Columna, Condicion)
    End Sub
    'AULA
    Public Shared Sub CargarAula(Combo As ComboBox, Panel As Panel)
        Tabla = "AULA"
        Columna = "DESCRIPCION"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna)
    End Sub
    Public Shared Sub CargarAula(Combo As ComboBox, Panel As Panel, Facultad As ComboBox)
        Tabla = "AULA"
        Columna = "DESCRIPCION"
        Condicion = "RELA_FACULTAD"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Condicion, Facultad)
    End Sub
    Public Shared Sub CargarAulaYHorariosCursada(Datos As DataGridView, Panel As Panel, Cursada As Integer)
        Tabla = "HORARIO, HORA, MINUTO, DIA, AULA"
        Columna = "HORA_NUMERO, MINUTO_NUMERO, DIA_DESCRIPCION, AULA_DESCRIPCION"
        Condicion = "HORARIO_RELA_CURSADA = " & Cursada & " AND ID_HORA = HORARIO_RELA_HORA_DESDE AND ID_MINUTO = HORARIO_RELA_MINUTO_DESDE AND ID_DIA = HORARIO_RELA_DIA AND ID_AULA = HORARIO_RELA_AULA"
        Configuracion.CargarDGV(Datos, Panel, Tabla, Columna, Condicion)
    End Sub
    'MATERIA
    Public Shared Sub CargarMateria(Combo As ComboBox, Panel As Panel)
        Tabla = "MATERIA"
        Columna = "DESCRIPCION"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna)
    End Sub
    Public Shared Sub CargarMateria(Combo As ComboBox, Panel As Panel, Carrera As ComboBox)
        Tabla = "MATERIA"
        Columna = "DESCRIPCION"
        Condicion = "RELA_CARRERA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Condicion, Carrera)
    End Sub
    Public Shared Sub CargarMateriaExamen(Combo As ComboBox, Panel As Panel, Materia As Integer)
        Tabla = "MATERIA, EXAMEN"
        Columna = "MATERIA_DESCRIPCION"
        Valor = "ID_MATERIA"
        Condicion = "MATERIA_RELA_CARRERA = " & Materia & " AND EXAMEN_RELA_MATERIA = ID_MATERIA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarMateriaAprobadaAlumno(Lista As ListBox, Panel As Panel, DNI As String)
        Tabla = "PERSONA, ALUMNO, MATERIA, EXAMEN, ALUMNO_EXAMEN, NOTA"
        Columna = "MATERIA_DESCRIPCION"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI & " AND ID_MATERIA = EXAMEN_RELA_MATERIA AND EXAMEN_RELA_TIPO_EXAMEN = 2 AND ALU_EXA_RELA_EXAMEN = ID_EXAMEN AND ALU_EXA_RELA_ALUMNO = ID_ALUMNO AND ID_ALUMNO_EXAMEN = NOTA_RELA_ALUMNO_EXAMEN AND NOTA_NOTA > 5"
        Configuracion.CargarListBox(Lista, Panel, Tabla, Columna, Condicion)
    End Sub
    Public Shared Sub CargarMateriaCursada(Lista As ListBox, Panel As Panel, Carrera As String)
        Tabla = "MATERIA, CURSADA"
        Columna = "MATERIA_DESCRIPCION"
        Condicion = "MATERIA_RELA_CARRERA = " & Carrera & " AND ID_MATERIA = CURSADA_RELA_MATERIA"
        Configuracion.EliminarRepetidos(Lista, Panel, Tabla, Columna, Condicion)
    End Sub
    'CURSADA
    Public Shared Sub CargarCursada(Combo As ComboBox, Panel As Panel)
        Tabla = "MATERIA, CURSADA"
        Columna = "MATERIA_DESCRIPCION"
        Valor = "ID_CURSADA"
        Condicion = "ID_MATERIA = CURSADA_RELA_MATERIA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarCursada(Combo As ComboBox, Panel As Panel, Carrera As Integer, Comision As String)
        Tabla = "MATERIA, CURSADA"
        Columna = "MATERIA_DESCRIPCION"
        Valor = "ID_CURSADA"
        Condicion = "MATERIA_RELA_CARRERA = " & Carrera & " AND ID_MATERIA = CURSADA_RELA_MATERIA AND CURSADA_COMISION = " & Comision
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarCursada(Combo As ComboBox, Panel As Panel, Carrera As Integer)
        Tabla = "MATERIA, CURSADA"
        Columna = "MATERIA_DESCRIPCION"
        Valor = "ID_CURSADA"
        Condicion = "MATERIA_RELA_CARRERA = " & Carrera & " AND ID_MATERIA = CURSADA_RELA_MATERIA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarCursadaAlumno(Lista As ListBox, Panel As Panel, DNI As String)
        Tabla = "PERSONA, ALUMNO, MATERIA, CURSADA, CURSADA_ALUMNO"
        Columna = "MATERIA_DESCRIPCION"
        Condicion = "PERSONA_DNI = " & DNI & " AND ID_PERSONA = ALUMNO_RELA_PERSONA AND ID_ALUMNO = CUR_ALU_RELA_ALUMNO AND ID_MATERIA = CURSADA_RELA_MATERIA AND ID_CURSADA = CUR_ALU_RELA_CURSADA"
        Configuracion.CargarListBox(Lista, Panel, Tabla, Columna, Condicion)
    End Sub
    'EXAMENES
    Public Shared Sub CargarExamen(Combo As ComboBox, Panel As Panel, Carrera As Integer)
        Tabla = "EXAMEN, MATERIA"
        Columna = "MATERIA_DESCRIPCION"
        Valor = "ID_EXAMEN"
        Condicion = "MATERIA_RELA_CARRERA = " & Carrera & " AND ID_MATERIA = EXAMEN_RELA_MATERIA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarExamen(Combo As ComboBox, Panel As Panel, Carrera As Integer, Llamado As Integer)
        Tabla = "MATERIA, EXAMEN"
        Columna = "MATERIA_DESCRIPCION"
        Valor = "ID_EXAMEN"
        Condicion = "MATERIA_RELA_CARRERA = " & Carrera & " AND EXAMEN_RELA_MATERIA = ID_MATERIA AND EXAMEN_LLAMADO = " & Llamado & " AND EXAMEN_RELA_TIPO_EXAMEN = 2"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarLlamado(Combo As ComboBox, Panel As Panel, Examen As Integer)
        Tabla = "EXAMEN"
        Columna = "EXAMEN_LLAMADO"
        Valor = "ID_EXAMEN"
        Condicion = "EXAMEN_RELA_MATERIA = " & Examen & " AND EXAMEN_RELA_TIPO_EXAMEN = 2"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarLlamado(Combo As ComboBox, Panel As Panel)
        Tabla = "EXAMEN"
        Columna = "EXAMEN_LLAMADO"
        Valor = "EXAMEN_LLAMADO"
        Condicion = "EXAMEN_RELA_TIPO_EXAMEN = 2 AND EXAMEN_LLAMADO <> 0"
        Configuracion.EliminarRepetidos(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarFechaExamen(Lista As ListBox, Panel As Panel, Examen As Integer)
        Tabla = "EXAMEN"
        Columna = "EXAMEN_FECHA"
        Condicion = "ID_EXAMEN = " & Examen
        Configuracion.CargarListBox(Lista, Panel, Tabla, Columna, Condicion)
    End Sub
    Public Shared Sub CargarHoraExamen(Lista As ListBox, Panel As Panel, Examen As Integer)
        Tabla = "EXAMEN, HORA"
        Columna = "HORA_NUMERO"
        Condicion = "ID_HORA = EXAMEN_RELA_HORA AND ID_EXAMEN = " & Examen
        Configuracion.CargarListBox(Lista, Panel, Tabla, Columna, Condicion)
    End Sub
    Public Shared Sub CargarInscripcionesExamenAlumno(Lista As ListBox, Panel As Panel, DNI As String)
        Tabla = "PERSONA, ALUMNO, MATERIA, EXAMEN, ALUMNO_EXAMEN"
        Columna = "MATERIA_DESCRIPCION"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI & " AND ID_MATERIA = EXAMEN_RELA_MATERIA AND EXAMEN_RELA_TIPO_EXAMEN = 2 AND ALU_EXA_RELA_EXAMEN = ID_EXAMEN AND ALU_EXA_RELA_ALUMNO = ID_ALUMNO AND EXAMEN_FECHA > CURRENT_DATE"
        Configuracion.CargarListBox(Lista, Panel, Tabla, Columna, Condicion)
    End Sub
    'ALUMNOS
    Public Shared Sub BuscarAlumno(Combo As ComboBox, Panel As Panel, DNI As String)
        Tabla = "PERSONA, ALUMNO"
        Columna = "PERSONA_APELLIDO"
        Valor = "ID_ALUMNO"
        Condicion = "PERSONA_DNI = " & DNI & " AND ID_PERSONA = ALUMNO_RELA_PERSONA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub BuscarAlumnoPersona(Combo As ComboBox, Panel As Panel, DNI As String)
        Tabla = "PERSONA, ALUMNO"
        Columna = "PERSONA_APELLIDO"
        Valor = "ID_PERSONA"
        Condicion = "PERSONA_DNI = " & DNI & " AND ID_PERSONA = ALUMNO_RELA_PERSONA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarAlumno(Combo As ComboBox, Panel As Panel)
        Tabla = "ALUMNO,PERSONA"
        Columna = "PERSONA_APELLIDO"
        Valor = "ID_ALUMNO"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarAlumnoExamen(Combo As ComboBox, Panel As Panel, Examen As Integer)
        Tabla = "PERSONA, ALUMNO, ALUMNO_EXAMEN"
        Columna = "PERSONA_APELLIDO"
        Valor = "ID_ALUMNO_EXAMEN"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA AND ID_ALUMNO = ALU_EXA_RELA_ALUMNO AND ALU_EXA_RELA_EXAMEN = " & Examen
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarAlumnoNotaExamen(Datos As DataGridView, Panel As Panel, Examen As Integer)
        Tabla = "PERSONA, ALUMNO, EXAMEN, CONDICION, NOTA, ALUMNO_EXAMEN"
        Columna = "PERSONA_NOMBRE, PERSONA_APELLIDO, CONDICION_DESCRIPCION, NOTA_NOTA"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA AND ID_ALUMNO = ALU_EXA_RELA_ALUMNO AND ID_CONDICION = ALU_EXA_RELA_CONDICION AND ID_EXAMEN = " & Examen & " AND ALU_EXA_RELA_EXAMEN = ID_EXAMEN AND NOTA_RELA_ALUMNO_EXAMEN = ID_ALUMNO_EXAMEN"
        Configuracion.CargarDGV(Datos, Panel, Tabla, Columna, Condicion)
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
    Public Shared Sub CargarAlumnosInscriptosExamen(Datos As DataGridView, Panel As Panel, Examen As Integer)
        Tabla = "PERSONA, ALUMNO, ALUMNO_EXAMEN, CONDICION"
        Columna = "PERSONA_NOMBRE, PERSONA_APELLIDO, CONDICION_DESCRIPCION"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA AND ID_CONDICION = ALU_EXA_RELA_CONDICION AND ID_ALUMNO = ALU_EXA_RELA_ALUMNO AND ALU_EXA_RELA_EXAMEN = " & Examen
        Configuracion.CargarDGV(Datos, Panel, Tabla, Columna, Condicion)
    End Sub
    Public Shared Sub CargarAlumnoCursada(Datos As DataGridView, Panel As Panel, Cursada As Integer)
        Tabla = "PERSONA, ALUMNO, CURSADA_ALUMNO"
        Columna = "PERSONA_NOMBRE, PERSONA_APELLIDO"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA AND ID_ALUMNO = CUR_ALU_RELA_ALUMNO AND CUR_ALU_RELA_CURSADA = " & Cursada
        Configuracion.CargarDGV(Datos, Panel, Tabla, Columna, Condicion)
    End Sub
    Public Shared Sub CargarNotaAlumno(Datos As DataGridView, Panel As Panel, DNI As String)
        Tabla = "PERSONA, ALUMNO, EXAMEN, MATERIA, ALUMNO_EXAMEN, NOTA, CONDICION"
        Columna = "MATERIA_DESCRIPCION, NOTA_NOTA, EXAMEN_FECHA, CONDICION_DESCRIPCION"
        Condicion = "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI & " AND ID_MATERIA = EXAMEN_RELA_MATERIA AND ID_CONDICION = ALU_EXA_RELA_CONDICION AND EXAMEN_RELA_TIPO_EXAMEN = 2 AND ID_EXAMEN = ALU_EXA_RELA_EXAMEN AND ID_ALUMNO = ALU_EXA_RELA_ALUMNO AND ID_ALUMNO_EXAMEN = NOTA_RELA_ALUMNO_EXAMEN"
        Configuracion.CargarDGV(Datos, Panel, Tabla, Columna, Condicion)
    End Sub
    'PROFESORES
    Public Shared Sub BuscarProfesor(Combo As ComboBox, Panel As Panel, DNI As String)
        Tabla = "PERSONA, PROFESOR"
        Columna = "PERSONA_APELLIDO"
        Valor = "ID_PERSONA"
        Condicion = "PERSONA_DNI = " & DNI & " AND ID_PERSONA = PROFESOR_RELA_PERSONA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarProfesor(Combo As ComboBox, Panel As Panel)
        Tabla = "PERSONA, PROFESOR"
        Columna = "PERSONA_APELLIDO"
        Valor = "ID_PROFESOR"
        Condicion = "ID_PERSONA = PROFESOR_RELA_PERSONA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarProfesorPersona(Combo As ComboBox, Panel As Panel)
        Tabla = "PERSONA, PROFESOR"
        Columna = "PERSONA_APELLIDO"
        Valor = "ID_PERSONA"
        Condicion = "ID_PERSONA = PROFESOR_RELA_PERSONA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarProfesorCursada(Datos As DataGridView, Panel As Panel, Materia As Integer)
        Tabla = "PERSONA, PROFESOR, CURSADA_PROFESOR"
        Columna = "PERSONA_NOMBRE, PERSONA_APELLIDO"
        Condicion = "ID_PERSONA = PROFESOR_RELA_PERSONA AND ID_PROFESOR = CUR_PROFE_RELA_PROFESOR AND CUR_PROFE_RELA_CURSADA = " & Materia
        Configuracion.CargarDGV(Datos, Panel, Tabla, Columna, Condicion)
    End Sub
    Public Shared Sub CargarProfesorExamenFinal(Lista As ListBox, Panel As Panel, Examen As Integer)
        Tabla = "PERSONA, PROFESOR, EXAMEN_PROFESOR"
        Columna = "PERSONA_APELLIDO"
        Condicion = "ID_PERSONA = PROFESOR_RELA_PERSONA AND ID_PROFESOR = EXA_PROFE_RELA_PROFESORES AND EXA_PROFE_RELA_EXAMEN = " & Examen
        Configuracion.CargarListBox(Lista, Panel, Tabla, Columna, Condicion)
    End Sub
    'TIEMPO
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
    Public Shared Sub CargarDia(Combo As ComboBox, Panel As Panel)
        Tabla = "DIA"
        Columna = "DESCRIPCION"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna)
    End Sub
    'OTRAS CONSULTAS GENERALES
    Public Shared Sub CargarCondicion(Combo As ComboBox, Panel As Panel)
        Tabla = "CONDICION"
        Columna = "DESCRIPCION"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna)
    End Sub
    Public Shared Sub CargarOtroPersona(Combo As ComboBox, Panel As Panel)
        Tabla = "PERSONA, ADMINISTRACION"
        Columna = "PERSONA_APELLIDO"
        Valor = "ID_PERSONA"
        Condicion = "ID_PERSONA=ADMIN_RELA_PERSONA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub BuscarOtro(Combo As ComboBox, Panel As Panel, DNI As String)
        Tabla = "PERSONA, ADMINISTRACION"
        Columna = "PERSONA_APELLIDO"
        Valor = "ID_PERSONA"
        Condicion = "PERSONA_DNI = " & DNI & " AND ID_PERSONA = ADMIN_RELA_PERSONA"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna, Valor, Condicion)
    End Sub
    Public Shared Sub CargarPuesto(Combo As ComboBox, Panel As Panel)
        Tabla = "PUESTO_ADMIN"
        Columna = "DESCRIPCION"
        Configuracion.CargarComboBox(Combo, Panel, Tabla, Columna)
    End Sub
    Public Shared Sub CargarComision(Combo As ComboBox, Panel As Panel)
        Tabla = "CURSADA"
        Columna = "CURSADA_COMISION"
        Valor = "CURSADA_COMISION"
        Configuracion.EliminarRepetidos(Combo, Panel, Tabla, Columna, Valor)
    End Sub
End Class
