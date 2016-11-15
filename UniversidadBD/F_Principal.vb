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
    'USUARIO
    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Usuario, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Usuario, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Usuario, F_Secundario.TabControl1)
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
        oConfiguracion.CargarComboBox(CMB_C_SeleccionarCarreraNotasExamen, PNL_C_NotasExamen, "CARRERA", "DESCRIPCION")
        oConfiguracion.CargarComboBox(CMB_C_SeleccionarFacultadNotasExamenP, PNL_C_NotasExamen, "FACULTAD", "DESCRIPCION")
        oConfiguracion.CargarComboBox(CMB_C_SeleccionarCarreraNotasExamenP, PNL_C_NotasExamen, "CARRERA", "DESCRIPCION")
    End Sub
    'COMBOS
    Private Sub CMB_C_SeleccionarCarreraNotasExamen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccionarCarreraNotasExamen.SelectedIndexChanged
        Dim ID As Integer = CMB_C_SeleccionarCarreraNotasExamen.SelectedValue
        oConfiguracion.CargarComboEspecifico(CMB_C_SeleccionarMateriaNotasExamen, PNL_C_NotasExamen, "MATERIA, EXAMEN", "MATERIA_DESCRIPCION", "ID_MATERIA", "MATERIA_RELA_CARRERA = " & ID & " AND EXAMEN_RELA_MATERIA = ID_MATERIA")
    End Sub
    Private Sub CMB_C_SeleccionarFacultadNotasExamen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccionarFacultadNotasExamen.SelectedIndexChanged
        oConfiguracion.CargarCombo(CMB_C_SeleccionarCarreraNotasExamen, PNL_C_NotasExamen, "CARRERA", "DESCRIPCION", "RELA_FACULTAD", CMB_C_SeleccionarFacultadNotasExamen)
    End Sub
    Private Sub CMB_C_SeleccionarMateriaNotasExamen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccionarMateriaNotasExamen.SelectedIndexChanged
        Dim ID As Integer = CMB_C_SeleccionarMateriaNotasExamen.SelectedValue
        oConfiguracion.CargarComboEspecifico(CMB_C_SeleccionarLlamadoNotasExamen, PNL_C_NotasExamen, "EXAMEN", "EXAMEN_LLAMADO", "ID_EXAMEN", "EXAMEN_RELA_MATERIA = " & ID & " AND EXAMEN_RELA_TIPO_EXAMEN <> 1")
        Dim Examen As Integer = CMB_C_SeleccionarLlamadoNotasExamen.SelectedValue
        oConfiguracion.CargarComboEspecifico(CMB_C_SeleccionarAlumnoNotasExamen, PNL_C_NotasExamen, "PERSONA, ALUMNO, ALUMNO_EXAMEN", "PERSONA_NOMBRE", "ID_ALUMNO_EXAMEN", "ID_PERSONA = ALUMNO_RELA_PERSONA AND ID_ALUMNO = ALU_EXA_RELA_ALUMNO AND ALU_EXA_RELA_EXAMEN = " & Examen)
    End Sub
    Private Sub CMB_C_SeleccionarMateriaNotasExamenP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccionarMateriaNotasExamenP.SelectedIndexChanged
        Dim ID As Integer = CMB_C_SeleccionarMateriaNotasExamenP.SelectedValue
        oConfiguracion.CargarComboEspecifico(CMB_C_NParcialNotasExamen, PNL_C_NotasExamen, "EXAMEN", "EXAMEN_NUMERO_PARCIAL", "ID_EXAMEN", "EXAMEN_RELA_MATERIA = " & ID & " AND EXAMEN_RELA_TIPO_EXAMEN <> 2")
        Dim Examen As Integer = CMB_C_SeleccionarMateriaNotasExamenP.SelectedValue
        oConfiguracion.CargarComboEspecifico(CMB_C_SeleccionarAlumnoNotasExamenP, PNL_C_NotasExamen, "PERSONA, ALUMNO, ALUMNO_EXAMEN", "PERSONA_NOMBRE", "ID_ALUMNO_EXAMEN", "ID_PERSONA = ALUMNO_RELA_PERSONA AND ID_ALUMNO = ALU_EXA_RELA_ALUMNO AND ALU_EXA_RELA_EXAMEN = " & Examen)
    End Sub
    Private Sub CMB_C_SeleccionarFacultadNotasExamenP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccionarFacultadNotasExamenP.SelectedIndexChanged
        oConfiguracion.CargarCombo(CMB_C_SeleccionarCarreraNotasExamenP, PNL_C_NotasExamen, "CARRERA", "DESCRIPCION", "RELA_FACULTAD", CMB_C_SeleccionarFacultadNotasExamenP)
    End Sub
    Private Sub CMB_C_SeleccionarCarreraNotasExamenP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_C_SeleccionarCarreraNotasExamenP.SelectedIndexChanged
        Dim ID As Integer = CMB_C_SeleccionarCarreraNotasExamenP.SelectedValue
        oConfiguracion.CargarComboEspecifico(CMB_C_SeleccionarMateriaNotasExamenP, PNL_C_NotasExamen, "MATERIA, EXAMEN", "MATERIA_DESCRIPCION", "ID_MATERIA", "MATERIA_RELA_CARRERA = " & ID & " AND EXAMEN_RELA_MATERIA = ID_MATERIA")
    End Sub
    'BOTONES ACEPTAR
    Private Sub BTN_C_NotasExamenFinalCargar_Click(sender As Object, e As EventArgs) Handles BTN_C_NotasExamenFinalCargar.Click
        F_Secundario.Examen.NotaExamenFinal()
    End Sub
    Private Sub BTN_C_NotasExamenParcialCargar_Click(sender As Object, e As EventArgs) Handles BTN_C_NotasExamenParcialCargar.Click
        F_Secundario.Examen.NotaExamenParcial()
    End Sub
End Class