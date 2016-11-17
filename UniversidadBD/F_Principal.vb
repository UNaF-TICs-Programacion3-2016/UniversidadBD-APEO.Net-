Public Class F_Principal
    Private Examen As New Examen()
    Private oConfiguracion As New Configuracion()
    Private Conexion As New Coneccion()
    'FACULTAD
    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Facultad, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Facultad, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Facultad, F_Secundario.TabControl1)
    End Sub
    'CARRERA
    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Carrera, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Carrera, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Carrera, F_Secundario.TabControl1)
    End Sub
    'MATERIA
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Materia, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Materia, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Materia, F_Secundario.TabControl1)
    End Sub
    'AULA
    Private Sub TSM_Salir_Click(sender As Object, e As EventArgs) Handles TSM_Salir.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Aula, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Aula, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Aula, F_Secundario.TabControl1)
    End Sub
    'SALIR
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        F_IniciarSesion.Close()
    End Sub
    'PROFESOR
    Private Sub AgregarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem1.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Profesor, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Profesor, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Profesor, F_Secundario.TabControl1)
    End Sub
    'ALUMNO
    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Alumno, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Alumno, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Alumno, F_Secundario.TabControl1)
    End Sub
    'OTRO
    Private Sub EliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem1.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Otro, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Otro, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Otro, F_Secundario.TabControl1)
    End Sub
    'GESTION DE ALUMNOS
    Private Sub GestiónDeAlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeAlumnosToolStripMenuItem.Click
        F_GestionAlumnos.Show()
    End Sub
    'CURSO
    Private Sub CuatrimestreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuatrimestreToolStripMenuItem.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Curso, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Curso, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Curso, F_Secundario.TabControl1)
    End Sub
    'EXAMEN FINAL
    Private Sub ExamenFinalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExamenFinalToolStripMenuItem.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_ExamenFinal, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_ExamenFinal, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_ExamenFinal, F_Secundario.TabControl1)
    End Sub
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'CONSULTA DE CURSOS
    Private Sub InscripcionesAMateriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InscripcionesAMateriasToolStripMenuItem.Click
        PNL_C_ExamenesFinales.Visible = False
        PNL_C_ExamenesParciales.Visible = False
        PNL_C_NotasExamen.Visible = False
        PNL_P_Principal.Visible = False
        oConfiguracion.EstablecerPanel(PNL_C_Cursos)
    End Sub
    'CONSULTA DE EXAMENES FINALES
    Private Sub InscripcionesAExamenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InscripcionesAExamenesToolStripMenuItem.Click
        PNL_C_Cursos.Visible = False
        PNL_C_ExamenesParciales.Visible = False
        PNL_C_NotasExamen.Visible = False
        PNL_P_Principal.Visible = False
        oConfiguracion.EstablecerPanel(PNL_C_ExamenesFinales)
    End Sub
    'NOTAS
    Private Sub NotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotasToolStripMenuItem.Click
        PNL_C_Cursos.Visible = False
        PNL_C_ExamenesFinales.Visible = False
        PNL_C_ExamenesParciales.Visible = False
        PNL_P_Principal.Visible = False
        oConfiguracion.EstablecerPanel(PNL_C_NotasExamen)
    End Sub
    'FORM
    Private Sub F_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Conectarse()
        oConfiguracion.EstablecerPanel(PNL_P_Principal)
    End Sub
    'INSCRIPCIONES
    Private Sub InscripcionesAExamenesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InscripcionesAExamenesToolStripMenuItem1.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Inscripcion, F_Secundario.TabControl1)
    End Sub
    'INSCRIPCIONES A CURSOS
    Private Sub InscripcionesACursosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InscripcionesACursosToolStripMenuItem.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_InscripcionCursadas, F_Secundario.TabControl1)
    End Sub
    'PANELES
    Private Sub PNL_C_NotasExamen_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_C_NotasExamen.VisibleChanged
        oConfiguracion.CargarComboBox(CMB_C_SeleccionarFacultadNotasExamen, PNL_C_NotasExamen, "FACULTAD", "DESCRIPCION")
        oConfiguracion.CargarComboSinRepetirC(CMB_C_SeleccionarLlamadoNotasExamen, PNL_C_NotasExamen, "EXAMEN", "EXAMEN_LLAMADO", "EXAMEN_LLAMADO", "EXAMEN_LLAMADO <> 0")
    End Sub
    Private Sub PNL_C_Cursos_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_C_Cursos.VisibleChanged
        oConfiguracion.CargarComboBox(CMB_C_SeleccioneFacultadCursos, PNL_C_Cursos, "FACULTAD", "DESCRIPCION")
        oConfiguracion.CargarComboBox(CMB_C_SeleccioneFacultadCursosFP, PNL_C_Cursos, "FACULTAD", "DESCRIPCION")
        oConfiguracion.CargarComboSinRepetir(CMB_C_SeleccioneComisiónCursos, PNL_C_Cursos, "CURSO", "CURSO_N_COMISION", "CURSO_N_COMISION")
    End Sub
    Private Sub PNL_C_ExamenesFinales_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_C_ExamenesFinales.VisibleChanged
        oConfiguracion.CargarComboBox(CMB_C_SeleccioneFacultadExamenesFinales, PNL_C_ExamenesFinales, "FACULTAD", "DESCRIPCION")
        oConfiguracion.CargarComboSinRepetirC(CMB_C_SeleccioneLlamado, PNL_C_ExamenesFinales, "EXAMEN", "EXAMEN_LLAMADO", "EXAMEN_LLAMADO", "EXAMEN_RELA_TIPO_EXAMEN = 2")
    End Sub
    'COMBOS
    Private Sub CMB_C_SeleccionarFacultadNotasExamen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccionarFacultadNotasExamen.SelectedIndexChanged
        oConfiguracion.CargarCombo(CMB_C_SeleccionarCarreraNotasExamen, PNL_C_NotasExamen, "CARRERA", "DESCRIPCION", "RELA_FACULTAD", CMB_C_SeleccionarFacultadNotasExamen)
    End Sub
    Private Sub CMB_C_SeleccionarLlamadoNotasExamen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccionarLlamadoNotasExamen.SelectedIndexChanged
        Dim Carrera As Integer = CMB_C_SeleccionarCarreraNotasExamen.SelectedValue
        Dim Llamado As Integer = CMB_C_SeleccionarLlamadoNotasExamen.SelectedValue
        oConfiguracion.CargarComboEspecifico(CMB_C_SeleccionarMateriaNotasExamen, PNL_C_NotasExamen, "MATERIA, EXAMEN", "MATERIA_DESCRIPCION", "ID_EXAMEN", "MATERIA_RELA_CARRERA = " & Carrera & " AND EXAMEN_RELA_MATERIA = ID_MATERIA AND EXAMEN_LLAMADO = " & Llamado & " AND EXAMEN_RELA_TIPO_EXAMEN = 2")
    End Sub
    Private Sub CMB_C_SeleccionarMateriaNotasExamen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccionarMateriaNotasExamen.SelectedIndexChanged
        Dim Examen As Integer = CMB_C_SeleccionarMateriaNotasExamen.SelectedValue
        oConfiguracion.CargarComboEspecifico(CMB_C_SeleccionarAlumnoNotasExamen, PNL_C_NotasExamen, "PERSONA, ALUMNO, ALUMNO_EXAMEN", "PERSONA_APELLIDO", "ID_ALUMNO_EXAMEN", "ID_PERSONA = ALUMNO_RELA_PERSONA AND ID_ALUMNO = ALU_EXA_RELA_ALUMNO AND ALU_EXA_RELA_EXAMEN = " & Examen)
    End Sub
    Private Sub CMB_C_SeleccioneFacultadCursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccioneFacultadCursos.SelectedIndexChanged
        oConfiguracion.CargarCombo(CMB_C_SeleccioneCarreraCursos, PNL_C_Cursos, "CARRERA", "DESCRIPCION", "RELA_FACULTAD", CMB_C_SeleccioneFacultadCursos)
    End Sub
    Private Sub CMB_C_SeleccioneCarreraCursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccioneCarreraCursos.SelectedIndexChanged
        Dim Carrera As String = CMB_C_SeleccioneCarreraCursos.SelectedValue
        oConfiguracion.CargarListaSinRepetirC(LTB_C_CursosActivosCursos, PNL_C_Cursos, "MATERIA, CURSO", "MATERIA_DESCRIPCION", "MATERIA_RELA_CARRERA = " & Carrera & " AND ID_MATERIA = CURSO_RELA_MATERIA", CMB_C_SeleccioneCarreraCursos)
    End Sub
    Private Sub CMB_C_SeleccioneComisiónCursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccioneComisiónCursos.SelectedIndexChanged
        Dim Carrera As Integer = CMB_C_SeleccioneCarreraCursosFP.SelectedValue
        Dim Comision As Integer = CMB_C_SeleccioneComisiónCursos.SelectedValue
        oConfiguracion.CargarComboEspecifico(CMB_C_SeleccioneMateriaCursos, PNL_C_Cursos, "MATERIA, CURSO", "MATERIA_DESCRIPCION", "ID_CURSO", "MATERIA_RELA_CARRERA = " & Carrera & " AND ID_MATERIA = CURSO_RELA_MATERIA AND CURSO_N_COMISION = " & Comision)
    End Sub
    Private Sub CMB_C_SeleccioneFacultadCursosFP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccioneFacultadCursosFP.SelectedIndexChanged
        oConfiguracion.CargarCombo(CMB_C_SeleccioneCarreraCursosFP, PNL_C_Cursos, "CARRERA", "DESCRIPCION", "RELA_FACULTAD", CMB_C_SeleccioneFacultadCursosFP)
    End Sub
    Private Sub CMB_C_SeleccioneFacultadExamenesFinales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccioneFacultadExamenesFinales.SelectedIndexChanged
        oConfiguracion.CargarCombo(CMB_C_SeleccioneCarreraExamenesFinales, PNL_C_ExamenesFinales, "CARRERA", "DESCRIPCION", "RELA_FACULTAD", CMB_C_SeleccioneFacultadExamenesFinales)
    End Sub
    Private Sub CMB_C_SeleccioneCarreraExamenesFinales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccioneCarreraExamenesFinales.SelectedIndexChanged
        Dim Carrera As Integer = CMB_C_SeleccioneCarreraExamenesFinales.SelectedValue
        Dim Llamado As Integer = CMB_C_SeleccioneLlamado.SelectedValue
        oConfiguracion.CargarComboEspecifico(CMB_C_SeleccioneMateriaExamenesFinales, PNL_C_ExamenesFinales, "MATERIA, EXAMEN", "MATERIA_DESCRIPCION", "ID_EXAMEN", "MATERIA_RELA_CARRERA = " & Carrera & " AND ID_MATERIA = EXAMEN_RELA_MATERIA AND EXAMEN_LLAMADO = " & Llamado)
    End Sub
    Private Sub CMB_C_SeleccioneLlamado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccioneLlamado.SelectedIndexChanged
        Dim Carrera As Integer = CMB_C_SeleccioneCarreraExamenesFinales.SelectedValue
        Dim Llamado As Integer = CMB_C_SeleccioneLlamado.SelectedValue
        oConfiguracion.CargarComboEspecifico(CMB_C_SeleccioneMateriaExamenesFinales, PNL_C_ExamenesFinales, "MATERIA, EXAMEN", "MATERIA_DESCRIPCION", "ID_EXAMEN", "MATERIA_RELA_CARRERA = " & Carrera & " AND ID_MATERIA = EXAMEN_RELA_MATERIA AND EXAMEN_LLAMADO = " & Llamado)
    End Sub
    'BOTONES ACEPTAR
    Private Sub BTN_C_CursosCargarFP_Click(sender As Object, e As EventArgs) Handles BTN_C_CursosCargarFP.Click
        CMB_C_SeleccioneMateriaCursos.ValueMember = "ID_CURSO"
        Dim Materia As Integer = CMB_C_SeleccioneMateriaCursos.SelectedValue
        Dim Comision As Integer = CMB_C_SeleccioneComisiónCursos.SelectedValue
        oConfiguracion.CargarListaCondicion(LTB_C_AlumnosInscriptosCursos, PNL_C_Cursos, "PERSONA, ALUMNO, CURSO_ALUMNO", "PERSONA_APELLIDO", "ID_PERSONA = ALUMNO_RELA_PERSONA AND ID_ALUMNO = CUR_ALU_RELA_ALUMNO AND CUR_ALU_RELA_CURSO = " & Materia)
        oConfiguracion.CargarListaCondicion(LTB_C_ProfesoresCursoCursos, PNL_C_Cursos, "PERSONA, PROFESOR, CURSO_PROFESOR", "PERSONA_APELLIDO", "ID_PERSONA = PROFESOR_RELA_PERSONA AND ID_PROFESOR = CURSO_PROFESOR_RELA_PROFESOR AND CURSO_PROFESOR_RELA_CURSO = " & Materia)
        CMB_C_SeleccioneMateriaCursos.ValueMember = "ID_MATERIA"
        Materia = CMB_C_SeleccioneMateriaCursos.SelectedValue
        oConfiguracion.CargarDGVCondicion(DGV_C_HyACursos, PNL_C_Cursos, "CURSO, HORA, MINUTO, DIA, AULA", "HORA_NUMERO, MINUTO_NUMERO, DIA_DESCRIPCION, AULA_DESCRIPCION", "CURSO_RELA_MATERIA = " & Materia & " AND CURSO_N_COMISION = " & Comision & " AND ID_HORA = CURSO_RELA_HORA_DESDE AND ID_MINUTO = CURSO_RELA_MINUTO_DESDE AND ID_DIA = CURSO_RELA_DIA AND ID_AULA = CURSO_RELA_AULA")
    End Sub
    Private Sub BTN_C_ExamenesFinalesCargar_Click(sender As Object, e As EventArgs) Handles BTN_C_ExamenesFinalesCargar.Click
        Dim Materia As Integer = CMB_C_SeleccioneMateriaExamenesFinales.SelectedValue
        oConfiguracion.CargarListaCondicion(LTB_C_ProfesoresExamenesFinales, PNL_C_ExamenesFinales, "PERSONA, PROFESOR, EXAMEN_PROFESOR", "PERSONA_APELLIDO", "ID_PERSONA = PROFESOR_RELA_PERSONA AND ID_PROFESOR = EXA_PROFE_RELA_PROFESORES AND EXA_PROFE_RELA_EXAMEN = " & Materia)
        oConfiguracion.CargarDGVCondicion(DGV_C_AlumnosInscriptosExamenesFinales, PNL_C_ExamenesFinales, "PERSONA, ALUMNO, EXAMEN, CONDICION, NOTA, ALUMNO_EXAMEN", "PERSONA_APELLIDO, CONDICION_DESCRIPCION, NOTA_NOTA", "ID_PERSONA = ALUMNO_RELA_PERSONA AND ID_ALUMNO = ALU_EXA_RELA_ALUMNO AND ID_CONDICION = ALU_EXA_RELA_CONDICION AND ID_EXAMEN = " & Materia & " AND ALU_EXA_RELA_EXAMEN = ID_EXAMEN AND NOTA_RELA_ALUMNO_EXAMEN = ID_ALUMNO_EXAMEN")
        oConfiguracion.CargarListaCondicion(LBX_C_FechaExamenExamen, PNL_C_ExamenesFinales, "EXAMEN", "EXAMEN_FECHA", "ID_EXAMEN = " & Materia)
        oConfiguracion.CargarListaCondicion(LBX_C_HoraExamen, PNL_C_ExamenesFinales, "EXAMEN, HORA", "HORA_NUMERO", "ID_HORA = EXAMEN_RELA_HORA AND ID_EXAMEN = " & Materia)
    End Sub
    Private Sub BTN_C_NotasExamenFinalCargar_Click(sender As Object, e As EventArgs) Handles BTN_C_NotasExamenFinalCargar.Click
        With Examen
            .Nota = NUD_C_NotaNotasExamen.Value
            .Relacion = CMB_C_SeleccionarAlumnoNotasExamen.SelectedValue
            .NotaExamenFinal()
        End With
    End Sub
    Private Sub TSBTN_P_Buscar_Click(sender As Object, e As EventArgs) Handles TSBTN_P_Buscar.Click
        Dim DNI As String = TSTXT_P_DNIAlumno.Text
        Dim FechaActual As Date = Date.Now
        oConfiguracion.CargarListaCondicion(LBX_P_Nombre, PNL_P_Principal, "PERSONA, ALUMNO", "PERSONA_NOMBRE", "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI)
        oConfiguracion.CargarListaCondicion(LBX_P_Apellido, PNL_P_Principal, "PERSONA, ALUMNO", "PERSONA_APELLIDO", "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI)
        oConfiguracion.CargarListaCondicion(LBX_P_CUIL, PNL_P_Principal, "PERSONA, ALUMNO", "PERSONA_CUIL", "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI)
        oConfiguracion.CargarListaCondicion(LBX_P_NLegajo, PNL_P_Principal, "PERSONA, ALUMNO", "ALUMNO_NUMERO_LEGAJO", "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI)
        '''''''''''''''''''''
        oConfiguracion.CargarListaCondicion(LBX_P_Facultad, PNL_P_Principal, "FACULTAD, CARRERA, PERSONA, ALUMNO, ALUMNO_CARRERA", "FACULTAD_DESCRIPCION", "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI & " AND ID_ALUMNO = ALU_CARRE_RELA_ALUMNO AND ID_FACULTAD = CARRERA_RELA_FACULTAD AND ID_CARRERA = ALU_CARRE_RELA_CARRERA")
        oConfiguracion.CargarListaCondicion(LBX_P_Carrera, PNL_P_Principal, "PERSONA, ALUMNO, CARRERA, ALUMNO_CARRERA", "CARRERA_DESCRIPCION", "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI & " AND ID_ALUMNO = ALU_CARRE_RELA_ALUMNO AND ID_CARRERA = ALU_CARRE_RELA_CARRERA")
        '''''''''''''''''''''
        oConfiguracion.CargarListaCondicion(LBX_P_MateriasCurso, PNL_P_Principal, "PERSONA, ALUMNO, MATERIA, CURSO, CURSO_ALUMNO", "MATERIA_DESCRIPCION", "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI & " AND ID_MATERIA = CURSO_RELA_MATERIA AND ID_CURSO = CUR_ALU_RELA_CURSO AND ID_ALUMNO = CUR_ALU_RELA_ALUMNO")
        oConfiguracion.CargarListaCondicion(LBX_P_MateriasAprobadas, PNL_P_Principal, "PERSONA, ALUMNO, MATERIA, EXAMEN, ALUMNO_EXAMEN, NOTA", "MATERIA_DESCRIPCION", "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI & " AND ID_MATERIA = EXAMEN_RELA_MATERIA AND EXAMEN_RELA_TIPO_EXAMEN = 2 AND ALU_EXA_RELA_EXAMEN = ID_EXAMEN AND ALU_EXA_RELA_ALUMNO = ID_ALUMNO AND ID_ALUMNO_EXAMEN = NOTA_RELA_ALUMNO_EXAMEN AND NOTA_NOTA > 5")
        oConfiguracion.CargarListaCondicion(LBX_P_InscripcionesExamen, PNL_P_Principal, "PERSONA, ALUMNO, MATERIA, EXAMEN, ALUMNO_EXAMEN", "MATERIA_DESCRIPCION", "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI & " AND ID_MATERIA = EXAMEN_RELA_MATERIA AND EXAMEN_RELA_TIPO_EXAMEN = 2 AND ALU_EXA_RELA_EXAMEN = ID_EXAMEN AND ALU_EXA_RELA_ALUMNO = ID_ALUMNO AND EXAMEN_FECHA > CURRENT_DATE")
        oConfiguracion.CargarDGVCondicion(DGV_P_Notas, PNL_P_Principal, "PERSONA, ALUMNO, EXAMEN, MATERIA, ALUMNO_EXAMEN, NOTA, CONDICION", "MATERIA_DESCRIPCION, NOTA_NOTA, EXAMEN_FECHA, CONDICION_DESCRIPCION", "ID_PERSONA = ALUMNO_RELA_PERSONA AND PERSONA_DNI = " & DNI & " AND ID_MATERIA = EXAMEN_RELA_MATERIA AND ID_CONDICION = ALU_EXA_RELA_CONDICION AND EXAMEN_RELA_TIPO_EXAMEN = 2 AND ID_EXAMEN = ALU_EXA_RELA_EXAMEN AND ID_ALUMNO = ALU_EXA_RELA_ALUMNO AND ID_ALUMNO_EXAMEN = NOTA_RELA_ALUMNO_EXAMEN")
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        PNL_C_Cursos.Visible = False
        PNL_C_ExamenesParciales.Visible = False
        PNL_C_NotasExamen.Visible = False
        PNL_P_Principal.Visible = False
        PNL_C_ExamenesFinales.Visible = False
        oConfiguracion.EstablecerPanel(PNL_P_Principal)
    End Sub
End Class