﻿Public Class F_Principal
    Private Examen As New Examen()
    Private oConfiguracion As New Configuracion()
    Private Conexion As New Coneccion()
    'FACULTAD
    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Facultad, F_Secundario.TabControl1)
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Facultad, F_Secundario.TabControl1)
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Facultad, F_Secundario.TabControl1)
    End Sub
    'CARRERA
    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Carrera, F_Secundario.TabControl1)
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Carrera, F_Secundario.TabControl1)
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Carrera, F_Secundario.TabControl1)
    End Sub
    'MATERIA
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Materia, F_Secundario.TabControl1)
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Materia, F_Secundario.TabControl1)
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Materia, F_Secundario.TabControl1)
    End Sub
    'AULA
    Private Sub TSM_Salir_Click(sender As Object, e As EventArgs) Handles TSM_Salir.Click
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Aula, F_Secundario.TabControl1)
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Aula, F_Secundario.TabControl1)
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Aula, F_Secundario.TabControl1)
    End Sub
    'SALIR
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        F_IniciarSesion.Close()
    End Sub
    'PROFESOR
    Private Sub AgregarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem1.Click
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Profesor, F_Secundario.TabControl1)
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Profesor, F_Secundario.TabControl1)
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Profesor, F_Secundario.TabControl1)
    End Sub
    'ALUMNO
    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Alumno, F_Secundario.TabControl1)
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Alumno, F_Secundario.TabControl1)
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Alumno, F_Secundario.TabControl1)
    End Sub
    'OTRO
    Private Sub EliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem1.Click
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Otro, F_Secundario.TabControl1)
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Otro, F_Secundario.TabControl1)
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Otro, F_Secundario.TabControl1)
    End Sub
    'GESTION DE ALUMNOS
    Private Sub GestiónDeAlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        F_GestionAlumnos.Show()
    End Sub
    'CURSO
    Private Sub CuatrimestreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuatrimestreToolStripMenuItem.Click
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Curso, F_Secundario.TabControl1)
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Curso, F_Secundario.TabControl1)
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Curso, F_Secundario.TabControl1)
    End Sub
    'EXAMEN FINAL
    Private Sub ExamenFinalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExamenFinalToolStripMenuItem.Click
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_ExamenFinal, F_Secundario.TabControl1)
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_ExamenFinal, F_Secundario.TabControl1)
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_ExamenFinal, F_Secundario.TabControl1)
    End Sub
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'CONSULTA DE CURSOS
    Private Sub InscripcionesAMateriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InscripcionesAMateriasToolStripMenuItem.Click
        PNL_C_ExamenesFinales.Visible = False
        PNL_C_ExamenesParciales.Visible = False
        PNL_C_NotasExamen.Visible = False
        PNL_P_Principal.Visible = False
        Configuracion.EstablecerPanel(PNL_C_Cursos)
    End Sub
    'CONSULTA DE EXAMENES FINALES
    Private Sub InscripcionesAExamenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InscripcionesAExamenesToolStripMenuItem.Click
        PNL_C_Cursos.Visible = False
        PNL_C_ExamenesParciales.Visible = False
        PNL_C_NotasExamen.Visible = False
        PNL_P_Principal.Visible = False
        Configuracion.EstablecerPanel(PNL_C_ExamenesFinales)
    End Sub
    'NOTAS
    Private Sub NotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotasToolStripMenuItem.Click
        PNL_C_Cursos.Visible = False
        PNL_C_ExamenesFinales.Visible = False
        PNL_C_ExamenesParciales.Visible = False
        PNL_P_Principal.Visible = False
        Configuracion.EstablecerPanel(PNL_C_NotasExamen)
    End Sub
    'FORM
    Private Sub F_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Conectarse()
        Me.Width = 1104
        Me.Height = 627
        Configuracion.EstablecerPanel(PNL_P_Principal)
    End Sub
    'INSCRIPCIONES
    Private Sub InscripcionesAExamenesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InscripcionesAExamenesToolStripMenuItem1.Click
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Inscripcion, F_Secundario.TabControl1)
    End Sub
    'INSCRIPCIONES A CURSOS
    Private Sub InscripcionesACursosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InscripcionesACursosToolStripMenuItem.Click
        Configuracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_InscripcionCursadas, F_Secundario.TabControl1)
    End Sub
    'PANELES
    Private Sub PNL_C_NotasExamen_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_C_NotasExamen.VisibleChanged
        Recarga.CargarFacultad(CMB_C_SeleccionarFacultadNotasExamen, PNL_C_NotasExamen)
        Recarga.CargarLlamado(CMB_C_SeleccionarLlamadoNotasExamen, PNL_C_NotasExamen)
    End Sub
    Private Sub PNL_C_Cursos_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_C_Cursos.VisibleChanged
        Recarga.CargarFacultad(CMB_C_SeleccioneFacultadCursos, PNL_C_Cursos)
        Recarga.CargarFacultad(CMB_C_SeleccioneFacultadCursosFP, PNL_C_Cursos)
    End Sub
    Private Sub PNL_C_ExamenesFinales_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_C_ExamenesFinales.VisibleChanged
        Recarga.CargarFacultad(CMB_C_SeleccioneFacultadExamenesFinales, PNL_C_ExamenesFinales)
        Recarga.CargarLlamado(CMB_C_SeleccioneLlamado, PNL_C_ExamenesFinales)
    End Sub
    'COMBOS
    Private Sub CMB_C_SeleccionarFacultadNotasExamen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccionarFacultadNotasExamen.SelectedIndexChanged
        Recarga.CargarCarrera(CMB_C_SeleccionarCarreraNotasExamen, PNL_C_NotasExamen, CMB_C_SeleccionarFacultadNotasExamen)
    End Sub
    Private Sub CMB_C_SeleccionarLlamadoNotasExamen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccionarLlamadoNotasExamen.SelectedIndexChanged
        Recarga.CargarExamen(CMB_C_SeleccionarMateriaNotasExamen, PNL_C_NotasExamen, CMB_C_SeleccionarCarreraNotasExamen.SelectedValue, CMB_C_SeleccionarLlamadoNotasExamen.SelectedValue)
    End Sub
    Private Sub CMB_C_SeleccionarMateriaNotasExamen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccionarMateriaNotasExamen.SelectedIndexChanged
        Recarga.CargarAlumnoExamen(CMB_C_SeleccionarAlumnoNotasExamen, PNL_C_NotasExamen, CMB_C_SeleccionarMateriaNotasExamen.SelectedValue)
    End Sub
    Private Sub CMB_C_SeleccioneFacultadCursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccioneFacultadCursos.SelectedIndexChanged
        Recarga.CargarCarrera(CMB_C_SeleccioneCarreraCursos, PNL_C_Cursos, CMB_C_SeleccioneFacultadCursos)
    End Sub
    Private Sub CMB_C_SeleccioneCarreraCursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccioneCarreraCursos.SelectedIndexChanged
        Recarga.CargarMateriaCursada(LTB_C_CursosActivosCursos, PNL_C_Cursos, CMB_C_SeleccioneCarreraCursos.SelectedValue)
    End Sub
    Private Sub CMB_C_SeleccioneComisiónCursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccioneComisiónCursos.SelectedIndexChanged
        Recarga.CargarCursada(CMB_C_SeleccioneMateriaCursos, PNL_C_Cursos, CMB_C_SeleccioneCarreraCursosFP.SelectedValue, CMB_C_SeleccioneComisiónCursos.SelectedValue)
    End Sub
    Private Sub CMB_C_SeleccioneFacultadCursosFP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccioneFacultadCursosFP.SelectedIndexChanged
        Recarga.CargarCarrera(CMB_C_SeleccioneCarreraCursosFP, PNL_C_Cursos, CMB_C_SeleccioneFacultadCursosFP)
    End Sub
    Private Sub CMB_C_SeleccioneFacultadExamenesFinales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccioneFacultadExamenesFinales.SelectedIndexChanged
        Recarga.CargarCarrera(CMB_C_SeleccioneCarreraExamenesFinales, PNL_C_ExamenesFinales, CMB_C_SeleccioneFacultadExamenesFinales)
    End Sub
    Private Sub CMB_C_SeleccioneCarreraExamenesFinales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccioneCarreraExamenesFinales.SelectedIndexChanged
        Recarga.CargarExamen(CMB_C_SeleccioneMateriaExamenesFinales, PNL_C_ExamenesFinales, CMB_C_SeleccioneCarreraExamenesFinales.SelectedValue, CMB_C_SeleccioneLlamado.SelectedValue)
    End Sub
    Private Sub CMB_C_SeleccioneLlamado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccioneLlamado.SelectedIndexChanged
        Recarga.CargarExamen(CMB_C_SeleccioneMateriaExamenesFinales, PNL_C_ExamenesFinales, CMB_C_SeleccioneCarreraExamenesFinales.SelectedValue, CMB_C_SeleccioneLlamado.SelectedValue)
    End Sub
    Private Sub CMB_C_SeleccioneCarreraCursosFP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccioneCarreraCursosFP.SelectedIndexChanged
        Recarga.CargarComision(CMB_C_SeleccioneComisiónCursos, PNL_C_Cursos)
    End Sub
    Private Sub CMB_C_SeleccioneMateriaCursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccioneMateriaCursos.SelectedIndexChanged
        Dim Materia As Integer = CMB_C_SeleccioneMateriaCursos.SelectedValue
        Recarga.CargarAlumnoCursada(DGV_C_AlumnosInscriptosCursos, PNL_C_Cursos, Materia)
        Recarga.CargarProfesorCursada(DGV_C_ProfesorCursada, PNL_C_Cursos, Materia)
        Recarga.CargarAulaYHorariosCursada(DGV_C_HyACursos, PNL_C_Cursos, Materia)
    End Sub
    'BOTONES ACEPTAR
    Private Sub BTN_C_ExamenesFinalesCargar_Click(sender As Object, e As EventArgs) Handles BTN_C_ExamenesFinalesCargar.Click
        Recarga.CargarProfesorExamenFinal(LTB_C_ProfesoresExamenesFinales, PNL_C_ExamenesFinales, CMB_C_SeleccioneMateriaExamenesFinales.SelectedValue)
        Recarga.CargarAlumnoNotaExamen(DGV_C_AlumnosInscriptosExamenesFinales, PNL_C_ExamenesFinales, CMB_C_SeleccioneMateriaExamenesFinales.SelectedValue)
        Recarga.CargarFechaExamen(LBX_C_FechaExamenExamen, PNL_C_ExamenesFinales, CMB_C_SeleccioneMateriaExamenesFinales.SelectedValue)
        Recarga.CargarHoraExamen(LBX_C_HoraExamen, PNL_C_ExamenesFinales, CMB_C_SeleccioneMateriaExamenesFinales.SelectedValue)
        Recarga.CargarAlumnosInscriptosExamen(DGV_C_AluInscrip, PNL_C_ExamenesFinales, CMB_C_SeleccioneMateriaExamenesFinales.SelectedValue)
    End Sub
    Private Sub BTN_C_NotasExamenFinalCargar_Click(sender As Object, e As EventArgs) Handles BTN_C_NotasExamenFinalCargar.Click
        With Examen
            .Nota = NUD_C_NotaNotasExamen.Value
            .Relacion = CMB_C_SeleccionarAlumnoNotasExamen.SelectedValue
            .NotaExamenFinal()
        End With
    End Sub
    Private Sub TSBTN_P_Buscar_Click(sender As Object, e As EventArgs) Handles TSBTN_P_Buscar.Click
        Recarga.DatosAlumno(LBX_P_Nombre, LBX_P_Apellido, LBX_P_CUIL, LBX_P_NLegajo, PNL_P_Principal, TSTXT_P_DNIAlumno.Text)
        Recarga.CargarFacultadAlumnos(LBX_P_Facultad, PNL_P_Principal, TSTXT_P_DNIAlumno.Text)
        Recarga.CargarCarreraAlumnos(LBX_P_Carrera, PNL_P_Principal, TSTXT_P_DNIAlumno.Text)
        Recarga.CargarCursadaAlumno(LBX_P_MateriasCurso, PNL_P_Principal, TSTXT_P_DNIAlumno.Text)
        Recarga.CargarMateriaAprobadaAlumno(LBX_P_MateriasAprobadas, PNL_P_Principal, TSTXT_P_DNIAlumno.Text)
        Recarga.CargarInscripcionesExamenAlumno(LBX_P_InscripcionesExamen, PNL_P_Principal, TSTXT_P_DNIAlumno.Text)
        Recarga.CargarNotaAlumno(DGV_P_Notas, PNL_P_Principal, TSTXT_P_DNIAlumno.Text)
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        PNL_C_Cursos.Visible = False
        PNL_C_ExamenesParciales.Visible = False
        PNL_C_NotasExamen.Visible = False
        PNL_P_Principal.Visible = False
        PNL_C_ExamenesFinales.Visible = False
        Configuracion.EstablecerPanel(PNL_P_Principal)
    End Sub
End Class