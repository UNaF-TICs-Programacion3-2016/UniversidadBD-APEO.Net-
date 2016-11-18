Imports Oracle.DataAccess.Client
Public Class F_Secundario
    Public Facultad As New Facultad()
    Public Carrera As New Carrera()
    Public Materia As New Materia()
    Public Examen As New Examen()
    Public Alumno As New Alumnos()
    Public Profesor As New Profesores()
    Public Persona As New Persona()
    Public Aula As New Aula()
    Public Curso As New Cursos()
    Public Otro As New Otros()
    Private oConfiguracion As New Configuracion()
    'FORM
    Private Sub F_Secundario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RDB_A_FinalExamenFinal.Checked = True
    End Sub
    'CLICK PARA SIGUIENTE/ANTERIOR PANEL
    Private Sub BTN_E_CursoSiguiente_Click(sender As Object, e As EventArgs) Handles BTN_E_CursoSiguiente.Click
        PNL_E_Curso.Visible = False
        Configuracion.EstablecerConfiguracion(Me, PNL_E_Curso2, TabControl1)
    End Sub
    Private Sub BTN_A_EditarCorrelativasMateria_Click(sender As Object, e As EventArgs) Handles BTN_A_EditarCorrelativasMateria.Click
        PNL_A_Materia.Visible = False
        Configuracion.EstablecerConfiguracion(Me, PNL_A_Correlativa, TabControl1)
    End Sub
    Private Sub BTN_A_AlumnoSiguiente_Click_1(sender As Object, e As EventArgs) Handles BTN_A_AlumnoSiguiente.Click
        PNL_A_Alumno.Visible = False
        Configuracion.EstablecerConfiguracion(Me, PNL_A_Alumno2, TabControl1)
    End Sub
    Private Sub BTN_A_CursoSiguiente_Click_1(sender As Object, e As EventArgs) Handles BTN_A_CursoSiguiente.Click
        PNL_A_Curso.Visible = False
        Configuracion.EstablecerConfiguracion(Me, PNL_A_Curso2, TabControl1)
    End Sub
    Private Sub BTN_A_AlumnoAtras_Click(sender As Object, e As EventArgs) Handles BTN_A_AlumnoAtras.Click
        PNL_A_Alumno2.Visible = False
        Configuracion.EstablecerConfiguracion(Me, PNL_A_Alumno, TabControl1)
    End Sub
    Private Sub BTN_A_CursoFinalizar_Click(sender As Object, e As EventArgs) Handles BTN_A_CursoFinalizar.Click
        PNL_A_Curso2.Visible = False
        Configuracion.EstablecerConfiguracion(Me, PNL_A_Curso, TabControl1)
    End Sub
    'CLICK PARA ACEPTAR
    Private Sub BTN_A_FacultadAceptar_Click_1(sender As Object, e As EventArgs) Handles BTN_A_FacultadAceptar.Click
        With Facultad
            .Codigo = TXT_A_CodigoFacultad.Text
            .Descripcion = TXT_A_DescripcionFacultad.Text
            .InsertarFacultad()
        End With
        Me.Close()
    End Sub
    Private Sub BTN_A_CarreraAceptar_Click_1(sender As Object, e As EventArgs) Handles BTN_A_CarreraAceptar.Click
        With Carrera
            .Codigo = TXT_A_CodigoCarrera.Text
            .Descripcion = TXT_A_DescripcionCarrera.Text
            .Duracion = TXT_A_DuracionCarrera.Text
            .InsertarCarrera()
        End With
        Me.Close()
    End Sub
    Private Sub BTN_A_MateriaSiguiente_Click(sender As Object, e As EventArgs) Handles BTN_A_MateriaSiguiente.Click
        With Materia
            .DescripcionOP = TXT_A_DescripcionOptativaMateria.Text
            .CodigoOP = TXT_A_CodigoOptativaMateria.Text
            .Codigo = TXT_A_CodigoMateria.Text
            .Descripcion = TXT_A_DescripcionMateria.Text
            .InsertarMateria()
        End With
        Me.Close()
    End Sub
    Private Sub BTN_A_MateriaAgregar_Click_1(sender As Object, e As EventArgs) Handles BTN_A_MateriaAgregar.Click
        With Materia
            .Relacion = CMB_A_SeleccioneMateriasCorrelativa.SelectedValue
            .Correlativa = CMB_A_SeleccioneCorrelativasCorrelativa.SelectedValue
            .RelacionarCorrelativa()
        End With
    End Sub
    Private Sub BTN_A_ProfesorSiguiente_Click_1(sender As Object, e As EventArgs) Handles BTN_A_ProfesorSiguiente.Click
        With Persona
            .Nombre = TXT_A_NombreProfesor.Text
            .Apellido = TXT_A_ApellidoProfesor.Text
            .CUIL = TXT_A_CUILProfesor.Text
            .DNI = TXT_A_DNIProfesor.Text
            .Telefono = TXT_A_TelefonoProfesor.Text
            .Correo = TXT_A_CorreoProfesor.Text
        End With
        With Profesor
            .FechaDeIngreso = DTP_A_FechaIngresoProfesor.Value
            .Matricula = TXT_A_MatriculaProfesor.Text
            .InsertarProfesor()
        End With
        Me.Close()
    End Sub
    Private Sub BTN_A_AulaAceptar_Click_1(sender As Object, e As EventArgs) Handles BTN_A_AulaAceptar.Click
        With Aula
            .Descripcion = TXT_A_DescripcionAula.Text
            .InsertarAula()
        End With
        Me.Close()
    End Sub
    Private Sub BTN_A_AlumnoAceptar_Click_1(sender As Object, e As EventArgs) Handles BTN_A_AlumnoAceptar.Click
        With Persona
            .Nombre = TXT_A_NombreAlumno.Text
            .Apellido = TXT_A_ApellidoAlumno.Text
            .CUIL = TXT_A_CUILAlumno.Text
            .DNI = TXT_A_DNIAlumno.Text
            .Telefono = TXT_A_TelefonoAlumno.Text
            .Correo = TXT_A_CorreoAlumno.Text
        End With
        With Alumno
            .FechaDeIngreso = DTP_A_FechaIngresoAlumno.Value
            .NumeroDeLegajo = TXT_A_NumeroLegajoAlumno.Text
            .InsertarAlumno()
        End With
        Me.Close()
    End Sub
    Private Sub BTN_A_OtroAceptar_Click_1(sender As Object, e As EventArgs) Handles BTN_A_OtroAceptar.Click
        With Persona
            .Nombre = TXT_A_NombreOtro.Text
            .Apellido = TXT_A_ApellidoOtro.Text
            .CUIL = TXT_A_CUILOtro.Text
            .DNI = TXT_A_DNIOtro.Text
            .Correo = TXT_A_CorreoOtro.Text
            .Telefono = TXT_A_TelefonoOtro.Text
        End With
        With Otro
            .FechaDeIngreso = DTP_A_FechaIngresoOtro.Value
            .Puesto = CMB_A_OcupacionOtro.SelectedValue
            .InsertarOtro()
        End With
        Me.Close()
    End Sub
    Private Sub BTN_A_ExamenFinalAceptar_Click_1(sender As Object, e As EventArgs) Handles BTN_A_ExamenFinalAceptar.Click
        With Examen
            .Materia = CMB_A_MateriaExamenFinal.SelectedValue
            .Aula = CMB_A_AulaExamenFinal.SelectedValue
            .Llamado = NUD_A_LlamadoExamenFinal.Value
            .NumeroParcial = NUD_A_NParcialExamenFinal.Value
            .Fecha = DTP_A_FechaExamenFinal.Value.Date
            .Tipo = RDB_A_FinalExamenFinal.Checked
            .Hora = CMB_A_HoraExamen.SelectedValue
            .Minuto = CMB_A_MinutoExamen.SelectedValue
            .InsertarExamen()
        End With
    End Sub
    Private Sub BTN_A_ExamenAgregar_Click(sender As Object, e As EventArgs) Handles BTN_A_ExamenAgregar.Click
        With Examen
            .Profesor = CMB_A_ProfesoresExamen.SelectedValue
            .InsertarProfesorExamen()
        End With
    End Sub
    Private Sub BTN_A_CursoAgregar_Click(sender As Object, e As EventArgs) Handles BTN_A_CursoAgregar.Click
        With Curso
            .Materia = CMB_A_MateriaCurso.SelectedValue
            .HoraD = CMB_A_DesdeHoraCurso.SelectedValue
            .MinutoD = CMB_A_DesdeMinutosCurso.SelectedValue
            .HoraH = CMB_A_HastaHoraCurso.SelectedValue
            .MinutoH = CMB_A_HastaMinutosCurso.SelectedValue
            .Dia = CMB_A_DiaCurso.SelectedValue
            .Aula = CMB_A_AulaCurso.SelectedValue
            .Comision = TXT_A_ComisionCurso.Text
            .InsertarCurso()
        End With
    End Sub
    Private Sub BTN_A_AgregarProfesorCurso_Click(sender As Object, e As EventArgs) Handles BTN_A_AgregarProfesorCurso.Click
        With Curso
            .Profesor = CMB_A_ProfesoresCurso.SelectedValue
            .InsertarProfesorCurso()
        End With
    End Sub
    Private Sub BTN_A_ExamenBuscar_Click(sender As Object, e As EventArgs) Handles BTN_A_ExamenBuscar.Click
        Recarga.BuscarAlumno(CMB_A_AlumnoExamen, PNL_A_Inscripcion, TXT_BuscarExamen.Text)
    End Sub
    Private Sub BTN_A_ExamenAceptar_Click(sender As Object, e As EventArgs) Handles BTN_A_ExamenAceptar.Click
        With Examen
            .Relacion = CMB_A_LlamadoExamen.SelectedValue
            .Alumno = CMB_A_AlumnoExamen.SelectedValue
            .Condicion = CMB_A_CondiciónExamen.SelectedValue
            .InscripcionExamen()
        End With
        Me.Close()
    End Sub
    Private Sub BTN_A_BuscarIC_Click(sender As Object, e As EventArgs) Handles BTN_A_BuscarIC.Click
        Recarga.BuscarAlumno(CMB_A_AlumnoIC, PNL_A_InscripcionCursadas, TXT_A_BuscarIC.Text)
    End Sub
    Private Sub BTN_A_InscribirIC_Click(sender As Object, e As EventArgs) Handles BTN_A_InscribirIC.Click
        With Curso
            .Relacion = CMB_A_CursoIC.SelectedValue
            .Alumno = CMB_A_AlumnoIC.SelectedValue
            .InsertarAlumnoCurso()
        End With
        Me.Close()
    End Sub
    Private Sub BTN_E_FacultadAceptar_Click(sender As Object, e As EventArgs) Handles BTN_E_FacultadAceptar.Click
        With Facultad
            .Codigo = TXT_E_CodigoFacultad.Text
            .Descripcion = TXT_E_DescripcionFacultad.Text
            .EditarFacultad()
        End With
    End Sub
    Private Sub BTN_E_CarreraAceptar_Click(sender As Object, e As EventArgs) Handles BTN_E_CarreraAceptar.Click
        With Carrera
            .Descripcion = TXT_E_DescripcionCarrera.Text
            .Duracion = TXT_E_DuracionCarrera.Text
            .Codigo = TXT_E_CodigoCarrera.Text
            .EditarCarrera()
        End With
    End Sub
    Private Sub BTN_E_MateriaAceptar_Click(sender As Object, e As EventArgs) Handles BTN_E_MateriaAceptar.Click
        With Materia
            .Codigo = TXT_E_CodigoMateria.Text
            .Descripcion = TXT_E_DescripcionMateria.Text
            .EditarMateria()
        End With
    End Sub
    Private Sub BTN_E_ProfesorAceptar2_Click(sender As Object, e As EventArgs) Handles BTN_E_ProfesorAceptar2.Click
        With Profesor
            .CUIL = TXT_E_CUILProfesor.Text
            .Nombre = TXT_E_NombreProfesor.Text
            .Apellido = TXT_E_ApellidoProfesor.Text
            .EditarProfesor()
        End With
    End Sub
    Private Sub BTN_E_AulaAceptar_Click(sender As Object, e As EventArgs) Handles BTN_E_AulaAceptar.Click
        With Aula
            .Descripcion = TXT_E_DescripcionAula.Text
            .EditarAula()
        End With
    End Sub
    Private Sub BTN_S_FacultadBorrar_Click(sender As Object, e As EventArgs) Handles BTN_S_FacultadBorrar.Click
        Facultad.EliminarFacultad()
        Me.Close()
    End Sub
    Private Sub BTN_S_CarreraBorrar_Click(sender As Object, e As EventArgs) Handles BTN_S_CarreraBorrar.Click
        Carrera.EliminarCarrera()
    End Sub
    Private Sub BTN_S_AlumnoBorrar_Click(sender As Object, e As EventArgs) Handles BTN_S_AlumnoBorrar.Click
        Alumno.EliminarAlumno()
    End Sub
    Private Sub BTN_S_OtroEliminar_Click(sender As Object, e As EventArgs) Handles BTN_S_OtroEliminar.Click
        Otro.EliminarOtro()
    End Sub
    Private Sub BTN_S_MateriaBorrar_Click(sender As Object, e As EventArgs) Handles BTN_S_MateriaBorrar.Click
        Materia.EliminarMateria()
    End Sub
    Private Sub BTN_S_ExamenFinalBorrar_Click(sender As Object, e As EventArgs) Handles BTN_S_ExamenFinalBorrar.Click
        Examen.EliminarExamen()
    End Sub
    Private Sub BTN_S_AulaBorrar_Click(sender As Object, e As EventArgs) Handles BTN_S_AulaBorrar.Click
        Aula.EliminarAula()
    End Sub
    Private Sub BTN_S_CursoBorrar_Click(sender As Object, e As EventArgs) Handles BTN_S_CursoBorrar.Click
        Curso.EliminarCurso()
    End Sub
    Private Sub BTN_S_ProfesorBorrar_Click(sender As Object, e As EventArgs) Handles BTN_S_ProfesorBorrar.Click
        Profesor.EliminarProfesor()
    End Sub
    'PANELES
    Private Sub PNL_S_Materia_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_S_Materia.VisibleChanged
        Recarga.CargarCarrera(CMB_S_SeleccionarCarreraMateria, PNL_S_Materia)
    End Sub
    Private Sub PNL_S_ExamenFinal_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_S_ExamenFinal.VisibleChanged
        Recarga.CargarFacultad(CMB_S_FacultadExamenFinal, PNL_S_ExamenFinal)
    End Sub
    Private Sub PNL_S_Aula_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_S_Aula.VisibleChanged
        Recarga.CargarAula(CMB_S_SeleccionarAulaAula, PNL_S_Aula)
    End Sub
    Private Sub PNL_S_Facultad_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_S_Facultad.VisibleChanged
        Recarga.CargarFacultad(CMB_S_FacultadSeleccionar, PNL_S_Facultad)
    End Sub
    Private Sub PNL_S_Carrera_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_S_Carrera.VisibleChanged
        Recarga.CargarCarrera(CMB_S_SeleccionarCarreraCarrera, PNL_S_Carrera)
    End Sub
    Private Sub PNL_S_Alumno_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_S_Alumno.VisibleChanged
        Recarga.CargarAlumno(CMB_S_SeleccionarAlumno, PNL_S_Alumno)
    End Sub
    Private Sub PNL_S_Otro_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_S_Otro.VisibleChanged
        Recarga.CargarOtro(CMB_S_SeleccionePersonaOtro, PNL_S_Otro)
    End Sub
    Private Sub PNL_S_Profesor_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_S_Profesor.VisibleChanged
        Recarga.CargarProfesor(CMB_S_SeleccionarProfesorProfesor, PNL_S_Profesor)
    End Sub
    Private Sub PNL_S_Curso_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_S_Curso.VisibleChanged
        Recarga.CargarFacultad(CMB_S_SeleccionarFacultadCurso, PNL_S_Curso)
    End Sub
    Private Sub PNL_E_Facultad_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_E_Facultad.VisibleChanged
        Recarga.CargarFacultad(CMB_E_SeleccionarFacultad, PNL_E_Facultad)
    End Sub
    Private Sub PNL_E_Carrera_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_E_Carrera.VisibleChanged
        Recarga.CargarCarrera(CMB_E_SeleccionarCarreraCarrera, PNL_E_Carrera)
        Recarga.CargarFacultad(CMB_E_SeleccionarFacultadCarrera, PNL_E_Carrera)
    End Sub
    Private Sub PNL_E_Materia_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_E_Materia.VisibleChanged
        Recarga.CargarMateria(CMB_E_SeleccionarMateriaMateria, PNL_E_Materia)
    End Sub
    Private Sub PNL_E_Profesor_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_E_Profesor.VisibleChanged
        oConfiguracion.CargarComboBox(CMB_E_SeleccionarProfesorProfesor, PNL_E_Profesor, "PERSONA, PROFESOR", "PERSONA_APELLIDO", "ID_PERSONA", "ID_PERSONA = PROFESOR_RELA_PERSONA")
    End Sub
    Private Sub PNL_E_Aula_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_E_Aula.VisibleChanged
        Recarga.CargarAula(CMB_E_SeleccionarAulaAula, PNL_E_Aula)
        Recarga.CargarFacultad(CMB_E_SeleccionarFacultadAula, PNL_E_Aula)
    End Sub
    Private Sub PNL_A_Carrera_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_A_Carrera.VisibleChanged
        Recarga.CargarFacultad(CMB_A_SeleccionarFacultadCarrera, PNL_A_Carrera)
    End Sub
    Private Sub CMB_A_FacultadExamenFinal_VisibleChanged(sender As Object, e As EventArgs) Handles CMB_A_FacultadExamenFinal.VisibleChanged
        Recarga.CargarCarrera(CMB_A_SeleccionarCarreraMateria, PNL_A_Materia)
    End Sub
    Private Sub PNL_A_Aula_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_A_Aula.VisibleChanged
        Recarga.CargarFacultad(CMB_A_SeleccionarAulaFacultad, PNL_A_Aula)
    End Sub
    Private Sub PNL_A_Alumno2_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_A_Alumno2.VisibleChanged
        Recarga.CargarFacultad(CMB_A_SeleccionarFacultadAlumno, PNL_A_Alumno2)
    End Sub
    Private Sub PNL_A_ExamenFinal_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_A_ExamenFinal.VisibleChanged
        Recarga.CargarFacultad(CMB_A_FacultadExamenFinal, PNL_A_ExamenFinal)
        Recarga.CargarCarrera(CMB_A_CarreraExamenFinal, PNL_A_ExamenFinal)
        Recarga.CargarMateria(CMB_A_MateriaExamenFinal, PNL_A_ExamenFinal)
        Recarga.CargarAula(CMB_A_AulaExamenFinal, PNL_A_ExamenFinal)
        Recarga.CargarHora(CMB_A_HoraExamen, PNL_A_ExamenFinal)
        Recarga.CargarMinuto(CMB_A_MinutoExamen, PNL_A_ExamenFinal)
        Recarga.CargarProfesor(CMB_A_ProfesoresExamen, PNL_A_ExamenFinal)
    End Sub
    Private Sub PNL_A_Curso_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_A_Curso.VisibleChanged
        Recarga.CargarFacultad(CMB_A_FacultadCurso, PNL_A_Curso)
        Recarga.CargarCarrera(CMB_A_CarreraCurso, PNL_A_Curso)
        Recarga.CargarMateria(CMB_A_MateriaCurso, PNL_A_Curso)
    End Sub
    Private Sub PNL_A_Curso2_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_A_Curso2.VisibleChanged
        Recarga.CargarHora(CMB_A_DesdeHoraCurso, PNL_A_Curso2)
        Recarga.CargarMinuto(CMB_A_DesdeMinutosCurso, PNL_A_Curso2)
        Recarga.CargarHora(CMB_A_HastaHoraCurso, PNL_A_Curso2)
        Recarga.CargarMinuto(CMB_A_HastaMinutosCurso, PNL_A_Curso2)
        Recarga.CargarDia(CMB_A_DiaCurso, PNL_A_Curso2)
        Recarga.CargarAula(CMB_A_AulaCurso, PNL_A_Curso2, CMB_A_FacultadCurso)
        Recarga.AgregarProfesor(CMB_A_ProfesoresCurso, PNL_A_Curso2)
    End Sub
    Private Sub PNL_A_Inscripcion_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_A_Inscripcion.VisibleChanged
        Recarga.CargarFacultad(CMB_A_FacultadExamen, PNL_A_Inscripcion)
        Recarga.CargarCarrera(CMB_A_CarreraExamen, PNL_A_Inscripcion)
        Recarga.CargarCondicion(CMB_A_CondiciónExamen, PNL_A_Inscripcion)
    End Sub
    Private Sub Panel1_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_A_InscripcionCursadas.VisibleChanged
        Recarga.CargarFacultad(CMB_A_FacultadIC, PNL_A_InscripcionCursadas)
        Recarga.CargarCarrera(CMB_A_CarreraIC, PNL_A_InscripcionCursadas)
    End Sub
    Private Sub PNL_A_Materia_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_A_Materia.VisibleChanged
        Recarga.CargarCarrera(CMB_A_SeleccionarCarreraMateria, PNL_A_Carrera)
    End Sub
    Private Sub PNL_A_Correlativa_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_A_Correlativa.VisibleChanged
        Recarga.CargarMateria(CMB_A_SeleccioneMateriasCorrelativa, PNL_A_Correlativa)
        Recarga.CargarMateria(CMB_A_SeleccioneCorrelativasCorrelativa, PNL_A_Correlativa)
        Recarga.CargarCarrera(CMB_A_SeleccioneCarreraCorrelativa, PNL_A_Correlativa)
    End Sub
    Private Sub PNL_A_Otro_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_A_Otro.VisibleChanged
        Recarga.CargarFacultad(CMB_A_FacultadOtro, PNL_A_Otro)
        Recarga.CargarPuesto(CMB_A_OcupacionOtro, PNL_A_Otro)
    End Sub
    'COMBOBOX
    Private Sub CMB_S_FacultadExamenFinal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_S_FacultadExamenFinal.SelectedIndexChanged
        Recarga.CargarCarrera(CMB_S_CarreraExamenFinal, PNL_S_ExamenFinal, CMB_S_FacultadExamenFinal)
    End Sub
    Private Sub CMB_S_CarreraExamenFinal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_S_CarreraExamenFinal.SelectedIndexChanged
        Recarga.CargarExamen(CMB_S_SeleccionarFinalExamenFinal, PNL_S_ExamenFinal, CMB_S_CarreraExamenFinal.SelectedValue)
    End Sub
    Private Sub CMB_S_SeleccionarMateriaCurso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_S_SeleccionarMateriaCurso.SelectedIndexChanged
        Recarga.CargarComisiones(CMB_S_ComisionCurso, PNL_S_Curso)
    End Sub
    Private Sub CMB_S_SeleccionarCarreraCurso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_S_SeleccionarCarreraCurso.SelectedIndexChanged
        Recarga.CargarCurso(CMB_S_SeleccionarMateriaCurso, PNL_S_Curso)
    End Sub
    Private Sub CMB_S_SeleccionarFacultadCurso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_S_SeleccionarFacultadCurso.SelectedIndexChanged
        Recarga.CargarCarrera(CMB_S_SeleccionarCarreraCurso, PNL_S_Curso, CMB_S_SeleccionarFacultadCurso)
    End Sub
    Private Sub CMB_S_SeleccionarCarreraMateria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_S_SeleccionarCarreraMateria.SelectedIndexChanged
        Recarga.CargarMateria(CMB_S_SeleccionarMateriaMateria, PNL_S_Materia, CMB_S_SeleccionarCarreraMateria)
    End Sub
    Private Sub CMB_E_SeleccionarFacultad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_E_SeleccionarFacultad.SelectedIndexChanged
        TXT_E_CodigoFacultad.Text = Facultad.Codigo
        TXT_E_DescripcionFacultad.Text = Facultad.Descripcion
    End Sub
    Private Sub CMB_A_SeleccionarFacultadAlumno_SelectedIndexChanged(sender As Object, e As EventArgs)
        Recarga.CargarCarrera(CMB_A_SeleccioneCarrreraAlumno, PNL_A_Alumno2, CMB_A_SeleccionarFacultadAlumno)
    End Sub
    Private Sub CMB_A_FacultadExamenFinal_SelectedIndexChanged(sender As Object, e As EventArgs)
        Recarga.CargarCarrera(CMB_A_CarreraExamenFinal, PNL_A_ExamenFinal, CMB_A_FacultadExamenFinal)
        Recarga.CargarAula(CMB_A_AulaExamenFinal, PNL_A_ExamenFinal, CMB_A_FacultadExamenFinal)
    End Sub
    Private Sub CMB_A_CarreraExamenFinal_SelectedIndexChanged(sender As Object, e As EventArgs)
        Recarga.CargarMateria(CMB_A_MateriaExamenFinal, PNL_A_ExamenFinal, CMB_A_CarreraExamenFinal)
    End Sub
    Private Sub CMB_A_SeleccionarFacultadAlumno_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CMB_A_SeleccionarFacultadAlumno.SelectedIndexChanged
        Recarga.CargarCarrera(CMB_A_SeleccioneCarrreraAlumno, PNL_A_Alumno2, CMB_A_SeleccionarFacultadAlumno)
    End Sub
    Private Sub CMB_A_SeleccioneCarreraCorrelativa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_A_SeleccioneCarreraCorrelativa.SelectedIndexChanged
        Recarga.CargarMateria(CMB_A_SeleccioneMateriasCorrelativa, PNL_A_Correlativa, CMB_A_SeleccioneCarreraCorrelativa)
        Recarga.CargarMateria(CMB_A_SeleccioneCorrelativasCorrelativa, PNL_A_Correlativa, CMB_A_SeleccioneCarreraCorrelativa)
    End Sub
    Private Sub CMB_A_FacultadExamenFinal_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CMB_A_FacultadExamenFinal.SelectedIndexChanged
        Recarga.CargarCarrera(CMB_A_CarreraExamenFinal, PNL_A_ExamenFinal, CMB_A_FacultadExamenFinal)
        Recarga.CargarAula(CMB_A_AulaExamenFinal, PNL_A_ExamenFinal, CMB_A_FacultadExamenFinal)
    End Sub
    Private Sub CMB_A_CarreraExamenFinal_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CMB_A_CarreraExamenFinal.SelectedIndexChanged
        Recarga.CargarMateria(CMB_A_MateriaExamenFinal, PNL_A_ExamenFinal, CMB_A_CarreraExamenFinal)
    End Sub
    Private Sub CMB_A_FacultadCurso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_A_FacultadCurso.SelectedIndexChanged
        Recarga.CargarCarrera(CMB_A_CarreraCurso, PNL_A_Curso, CMB_A_FacultadCurso)
    End Sub
    Private Sub CMB_A_CarreraCurso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_A_CarreraCurso.SelectedIndexChanged
        Recarga.CargarMateria(CMB_A_MateriaCurso, PNL_A_Curso, CMB_A_CarreraCurso)
    End Sub
    Private Sub CMB_A_CarreraExamen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_A_CarreraExamen.SelectedIndexChanged
        Recarga.CargarMateria(CMB_A_ExamenExamen, PNL_A_Inscripcion, CMB_A_CarreraExamen.SelectedValue)
    End Sub
    Private Sub CMB_A_ExamenExamen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_A_ExamenExamen.SelectedIndexChanged
        Recarga.CargarExamenLlamado(CMB_A_LlamadoExamen, PNL_A_Inscripcion, CMB_A_ExamenExamen.SelectedValue)
    End Sub
    Private Sub CMB_A_FacultadExamen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_A_FacultadExamen.SelectedIndexChanged
        Recarga.CargarCarrera(CMB_A_CarreraExamen, PNL_A_Inscripcion, CMB_A_FacultadExamen)
    End Sub
    Private Sub CMB_A_FacultadIC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_A_FacultadIC.SelectedIndexChanged
        Recarga.CargarCarrera(CMB_A_CarreraIC, PNL_A_InscripcionCursadas, CMB_A_FacultadIC)
    End Sub
    Private Sub CMB_A_ComisionIC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_A_ComisionIC.SelectedIndexChanged
        Recarga.CargarCurso(CMB_A_CursoIC, PNL_A_InscripcionCursadas, CMB_A_CarreraIC.SelectedValue, CMB_A_ComisionIC.Text)
    End Sub
    Private Sub CMB_A_CarreraIC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_A_CarreraIC.SelectedIndexChanged
        Recarga.CargarComisiones(CMB_A_ComisionIC, PNL_A_InscripcionCursadas)
    End Sub
    'CANCELAR
    Private Sub BTN_S_CarreraCancelar_Click(sender As Object, e As EventArgs) Handles BTN_S_CarreraCancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_S_AlumnoCancelar_Click(sender As Object, e As EventArgs) Handles BTN_S_AlumnoCancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_S_Cancelar_Click(sender As Object, e As EventArgs) Handles BTN_S_Cancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_S_MateriaCancelar_Click(sender As Object, e As EventArgs) Handles BTN_S_MateriaCancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_S_ProfesorCancelar_Click(sender As Object, e As EventArgs) Handles BTN_S_ProfesorCancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_S_CursoCancelar_Click(sender As Object, e As EventArgs) Handles BTN_S_CursoCancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_S_AulaCancelar_Click(sender As Object, e As EventArgs) Handles BTN_S_AulaCancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_S_ExamenFinalCancelar_Click(sender As Object, e As EventArgs) Handles BTN_S_ExamenFinalCancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_S_FacultadCancelar_Click(sender As Object, e As EventArgs) Handles BTN_S_FacultadCancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_A_ExamenFinalCancelar_Click_1(sender As Object, e As EventArgs) Handles BTN_A_ExamenFinalCancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_A_CancelarOtro_Click(sender As Object, e As EventArgs) Handles BTN_A_CancelarOtro.Click
        Me.Close()
    End Sub
    Private Sub BTN_A_AlumnoCancelar2_Click_1(sender As Object, e As EventArgs) Handles BTN_A_AlumnoCancelar2.Click
        Me.Close()
    End Sub
    Private Sub BTN_A_AlumnoCancelar_Click_1(sender As Object, e As EventArgs) Handles BTN_A_AlumnoCancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_A_AulaCancelar_Click(sender As Object, e As EventArgs) Handles BTN_A_AulaCancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_A_ProfesorCancelar2_Click(sender As Object, e As EventArgs) Handles BTN_A_ProfesorCancelar2.Click
        Me.Close()
    End Sub
    Private Sub BTN_A_MateriaCancelar_Click_1(sender As Object, e As EventArgs) Handles BTN_A_MateriaCancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_A_FacultadCancelar_Click_1(sender As Object, e As EventArgs) Handles BTN_A_FacultadCancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_A_CarreraCancelar_Click(sender As Object, e As EventArgs) Handles BTN_A_CarreraCancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_A_CursoCancelar_Click(sender As Object, e As EventArgs) Handles BTN_A_CursoCancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_A_CursoCancelar2_Click(sender As Object, e As EventArgs) Handles BTN_A_CursoCancelar2.Click
        Me.Close()
    End Sub
    Private Sub BTN_A_ExamenCancelar_Click(sender As Object, e As EventArgs) Handles BTN_A_ExamenCancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_A_CorrelativaSalir_Click_1(sender As Object, e As EventArgs) Handles BTN_A_CorrelativaSalir.Click
        Me.Close()
    End Sub
    Private Sub BTN_A_CorrelativaAceptar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub BTN_A_TerminarIC_Click(sender As Object, e As EventArgs) Handles BTN_A_TerminarIC.Click
        Me.Close()
    End Sub
    Private Sub BTN_E_FacultadCancelar_Click(sender As Object, e As EventArgs) Handles BTN_E_FacultadCancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_E_MateriaCancelar_Click(sender As Object, e As EventArgs) Handles BTN_E_MateriaCancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_E_ProfesorCancelar_Click(sender As Object, e As EventArgs) Handles BTN_E_ProfesorCancelar.Click
        Me.Close()
    End Sub
End Class