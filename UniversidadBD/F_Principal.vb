Public Class F_Principal
    Private oConfiguracion As New Configuracion
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
        oConfiguracion.EstablecerPanel(PNL_C_Cursos)
    End Sub
    'CONSULTA DE EXAMENES FINALES
    Private Sub FinalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinalesToolStripMenuItem.Click
        PNL_C_Cursos.Visible = False
        PNL_C_ExamenesParciales.Visible = False
        PNL_C_NotasExamen.Visible = False
        oConfiguracion.EstablecerPanel(PNL_C_ExamenesFinales)
    End Sub
    'CONSULTA DE EXAMENES PARCIALES
    Private Sub ParcialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParcialesToolStripMenuItem.Click
        PNL_C_Cursos.Visible = False
        PNL_C_ExamenesFinales.Visible = False
        PNL_C_NotasExamen.Visible = False
        oConfiguracion.EstablecerPanel(PNL_C_ExamenesParciales)
    End Sub
    'NOTAS
    Private Sub NotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotasToolStripMenuItem.Click
        PNL_C_Cursos.Visible = False
        PNL_C_ExamenesFinales.Visible = False
        PNL_C_ExamenesParciales.Visible = False
        oConfiguracion.EstablecerPanel(PNL_C_NotasExamen)
    End Sub
    'FORM
    Private Sub F_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Conectarse()
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
        oConfiguracion.CargarComboEspecifico(CMB_C_SeleccioneMateriaCursos, PNL_C_Cursos, "MATERIA, CURSO", "MATERIA_DESCRIPCION", "ID_MATERIA", "MATERIA_RELA_CARRERA = " & Carrera & " AND ID_MATERIA = CURSO_RELA_MATERIA AND CURSO_N_COMISION = " & Comision)
    End Sub
    'BOTONES ACEPTAR
    Private Sub BTN_C_NotasExamenFinalCargar_Click(sender As Object, e As EventArgs) Handles BTN_C_NotasExamenFinalCargar.Click
        F_Secundario.Examen.NotaExamenFinal()
    End Sub
    Private Sub CMB_C_SeleccioneFacultadCursosFP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccioneFacultadCursosFP.SelectedIndexChanged
        oConfiguracion.CargarCombo(CMB_C_SeleccioneCarreraCursosFP, PNL_C_Cursos, "CARRERA", "DESCRIPCION", "RELA_FACULTAD", CMB_C_SeleccioneFacultadCursosFP)
    End Sub
    Private Sub BTN_C_CursosCargarFP_Click(sender As Object, e As EventArgs) Handles BTN_C_CursosCargarFP.Click
        Dim Materia As Integer = CMB_C_SeleccioneMateriaCursos.SelectedValue
        Dim Comision As Integer = CMB_C_SeleccioneComisiónCursos.SelectedValue
        oConfiguracion.CargarListaCondicion(LTB_C_AlumnosInscriptosCursos, PNL_C_Cursos, "PERSONA, ALUMNO, CURSO_ALUMNO", "PERSONA_APELLIDO", "ID_PERSONA = ALUMNO_RELA_PERSONA AND ID_ALUMNO = CUR_ALU_RELA_ALUMNO AND CUR_ALU_RELA_CURSO = " & Materia)
        oConfiguracion.CargarListaCondicion(LTB_C_ProfesoresCursoCursos, PNL_C_Cursos, "PERSONA, PROFESOR, CURSO_PROFESOR", "PERSONA_APELLIDO", "ID_PERSONA = PROFESOR_RELA_PERSONA AND ID_PROFESOR = CURSO_PROFESOR_RELA_PROFESOR AND CURSO_PROFESOR_RELA_CURSO = " & Materia)
        oConfiguracion.CargarDGVCondicion(DGV_C_HyACursos, PNL_C_Cursos, "CURSO, HORA, MINUTO, DIA, AULA", "HORA_NUMERO, MINUTO_NUMERO, DIA_DESCRIPCION, AULA_DESCRIPCION", "CURSO_RELA_MATERIA = " & Materia & " AND CURSO_N_COMISION = " & Comision & " AND ID_HORA = CURSO_RELA_HORA_DESDE AND ID_MINUTO = CURSO_RELA_MINUTO_DESDE AND ID_DIA = CURSO_RELA_DIA AND ID_AULA = CURSO_RELA_AULA")
    End Sub
End Class