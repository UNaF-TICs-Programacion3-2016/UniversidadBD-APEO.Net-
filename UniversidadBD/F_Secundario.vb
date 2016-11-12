Public Class F_Secundario
    Public Facultad As New Facultad()
    Public Carrera As New Carrera()
    Public Materia As New Materia()
    Private oConeccion As New Coneccion()
    Public Alumno As New Alumnos()
    Public Profesor As New Profesores()
    Public Persona As New Persona()
    Public oAula As New Aula()
    Public Otro As New Otros()
    Private oConfiguracion As New Configuracion()
    'CLICK PARA SIGUIENTE PANEL
    Private Sub BTN_A_MateriaSiguiente_Click_1(sender As Object, e As EventArgs) Handles BTN_A_MateriaSiguiente.Click
        Materia.Codigo = TXT_A_CodigoMateria.Text
        Materia.Descripcion = TXT_A_DescripcionMateria.Text
        Materia.Correlativa = RDB_A_CorrelativaMateria.Checked
        Materia.Optativa = CBX_A_OptativaMateria.Checked
        Materia.InsertarMateria()
        PNL_A_Materia.Visible = False
        oConfiguracion.EstablecerConfiguracion(Me, PNL_A_Correlativa, TabControl1)
    End Sub
    Private Sub BTN_A_AlumnoSiguiente_Click(sender As Object, e As EventArgs) Handles BTN_A_AlumnoSiguiente.Click
        PNL_A_Alumno.Visible = False
        oConfiguracion.EstablecerConfiguracion(Me, PNL_A_Alumno2, TabControl1)
    End Sub
    Private Sub BTN_E_ProfesorSiguiente_Click(sender As Object, e As EventArgs) Handles BTN_E_ProfesorSiguiente.Click
        PNL_E_Profesor.Visible = False
        oConfiguracion.EstablecerConfiguracion(Me, PNL_E_Profesor2, TabControl1)
    End Sub
    Private Sub BTN_E_AlumnoSiguiente_Click(sender As Object, e As EventArgs) Handles BTN_E_AlumnoSiguiente.Click
        PNL_E_Alumno.Visible = False
        oConfiguracion.EstablecerConfiguracion(Me, PNL_E_Alumno2, TabControl1)
    End Sub
    Private Sub BTN_A_ProfesorSiguiente_Click(sender As Object, e As EventArgs) Handles BTN_A_ProfesorSiguiente.Click
        PNL_A_Profesor.Visible = False
        oConfiguracion.EstablecerConfiguracion(Me, PNL_A_ProfesorMaterias, TabControl1)
    End Sub
    Private Sub BTN_A_CursoSiguiente_Click(sender As Object, e As EventArgs) Handles BTN_A_CursoSiguiente.Click
        PNL_A_Curso.Visible = False
        oConfiguracion.EstablecerConfiguracion(Me, PNL_A_Curso2, TabControl1)
    End Sub
    Private Sub BTN_E_CursoSiguiente_Click(sender As Object, e As EventArgs) Handles BTN_E_CursoSiguiente.Click
        PNL_E_Curso.Visible = False
        oConfiguracion.EstablecerConfiguracion(Me, PNL_E_Curso2, TabControl1)
    End Sub
    Private Sub BTN_A_FacultadAceptar_Click(sender As Object, e As EventArgs) Handles BTN_A_FacultadAceptar.Click
        Facultad.Codigo = TXT_A_CodigoFacultad.Text
        Facultad.Descripcion = TXT_A_DescripcionFacultad.Text
        Facultad.InsertarFacultad()
        Me.Close()
    End Sub
    'CLICK PARA ACEPTAR
    Private Sub BTN_A_CarreraAceptar_Click(sender As Object, e As EventArgs) Handles BTN_A_CarreraAceptar.Click
        Carrera.Codigo = TXT_A_CodigoCarrera.Text
        Carrera.Descripcion = TXT_A_DescripcionCarrera.Text
        Carrera.Duracion = TXT_A_DuracionCarrera.Text
        Carrera.InsertarCarrera()
        Me.Close()
    End Sub
    Private Sub BTN_A_AlumnoAceptar_Click(sender As Object, e As EventArgs) Handles BTN_A_AlumnoAceptar.Click
        Persona.Nombre = TXT_A_NombreAlumno.Text
        Persona.Apellido = TXT_A_ApellidoAlumno.Text
        Persona.CUIL = TXT_A_CUILAlumno.Text
        Persona.DNI = TXT_A_DNIAlumno.Text
        Persona.Telefono = TXT_A_TelefonoAlumno.Text
        Persona.Correo = TXT_A_CorreoAlumno.Text
        Alumno.FechaDeIngreso = DTP_A_FechaIngresoAlumno.Value
        Alumno.NumeroDeLegajo = TXT_A_NumeroLegajoAlumno.Text
        Alumno.InsertarAlumno()
        Me.Close()
    End Sub
    Private Sub BTN_A_CorrelativaAceptar_Click(sender As Object, e As EventArgs) Handles BTN_A_CorrelativaTerminar.Click
        Me.Close()
    End Sub
    Private Sub BTN_A_AulaAceptar_Click(sender As Object, e As EventArgs) Handles BTN_A_AulaAceptar.Click
        oAula.Codigo = TXT_A_CodigoAula.Text
        oAula.Descripcion = TXT_A_DescripcionAula.Text
        oAula.InsertarAula()
        Me.Close()
    End Sub
    Private Sub BTN_A_ProfesorAceptas_Click(sender As Object, e As EventArgs) Handles BTN_A_ProfesorAceptas.Click
        Persona.Nombre = TXT_A_NombreProfesor.Text
        Persona.Apellido = TXT_A_ApellidoProfesor.Text
        Persona.CUIL = TXT_A_CUILProfesor.Text
        Persona.DNI = TXT_A_DNIProfesor.Text
        Persona.Telefono = TXT_A_TelefonoProfesor.Text
        Persona.Correo = TXT_A_CorreoProfesor.Text
        Profesor.FechaDeIngreso = DTP_A_FechaIngresoProfesor.Value
        Profesor.Matricula = TXT_A_MatriculaProfesor.Text
        Profesor.InsertarProfesor()
        Me.Close()
    End Sub
    Private Sub BTN_A_OtroAceptar_Click(sender As Object, e As EventArgs) Handles BTN_A_OtroAceptar.Click
        Persona.Nombre = TXT_A_NombreOtro.Text
        Persona.Apellido = TXT_A_ApellidoOtro.Text
        Persona.CUIL = TXT_A_CUILOtro.Text
        Persona.DNI = TXT_A_DNIOtro.Text
        Persona.Correo = TXT_A_CorreoOtro.Text
        Persona.Telefono = TXT_A_TelefonoOtro.Text
        Otro.FechaDeIngreso = DTP_A_FechaIngresoOtro.Value
        Otro.InsertarOtro()
        Me.Close()
    End Sub
    'PANELES
    Private Sub PNL_E_Facultad_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_E_Facultad.VisibleChanged
        oConfiguracion.CargarComboBox(CMB_E_SeleccionarFacultad, PNL_E_Facultad, "FACULTAD", "DESCRIPCION")
    End Sub
    Private Sub PNL_A_Carrera_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_A_Carrera.VisibleChanged
        oConfiguracion.CargarComboBox(CMB_A_SeleccionarFacultadCarrera, PNL_A_Carrera, "FACULTAD", "DESCRIPCION")
    End Sub
    Private Sub PNL_A_Alumno2_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_A_Alumno2.VisibleChanged
        oConfiguracion.CargarComboBox(CMB_A_SeleccionarFacultadAlumno, PNL_A_Alumno2, "FACULTAD", "DESCRIPCION")
    End Sub
    Private Sub PNL_A_Materia_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_A_Materia.VisibleChanged
        oConfiguracion.CargarComboBox(CMB_A_SeleccionarCarreraMateria, PNL_A_Carrera, "CARRERA", "DESCRIPCION")
    End Sub
    Private Sub PNL_A_Aula_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_A_Aula.VisibleChanged
        oConfiguracion.CargarComboBox(CMB_A_SeleccionarAulaFacultad, PNL_A_Aula, "FACULTAD", "DESCRIPCION")
    End Sub
    Private Sub PNL_A_Otro_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_A_Otro.VisibleChanged
        oConfiguracion.CargarComboBox(CMB_A_FacultadOtro, PNL_A_Otro, "FACULTAD", "DESCRIPCION")
        oConfiguracion.CargarComboBox(CMB_A_OcupacionOtro, PNL_A_Otro, "PUESTO_ADMIN", "DESCRIPCION")
    End Sub
    Private Sub PNL_A_Usuario_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_A_Usuario.VisibleChanged
        oConfiguracion.CargarComboBox(CMB_A_FacultadUsuario, PNL_A_Usuario, "FACULTAD", "DESCRIPCION")
    End Sub
    Private Sub PNL_A_Correlativa_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_A_Correlativa.VisibleChanged
        oConfiguracion.CargarCombo(PNL_A_Correlativa)
    End Sub
    'COMBOBOX
    Private Sub CMB_E_SeleccionarFacultad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_E_SeleccionarFacultad.SelectedIndexChanged
        TXT_E_CodigoFacultad.Text = Facultad.Codigo
        TXT_E_DescripcionFacultad.Text = Facultad.Descripcion
    End Sub
    Private Sub CMB_A_SeleccionarFacultadAlumno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_A_SeleccionarFacultadAlumno.SelectedIndexChanged

    End Sub
    'CANCELAR
    Private Sub BTN_A_FacultadCancelar_Click(sender As Object, e As EventArgs) Handles BTN_A_FacultadCancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_A_AlumnoCancelar_Click(sender As Object, e As EventArgs) Handles BTN_A_AlumnoCancelar.Click
        Me.Close()
    End Sub
    Private Sub BTN_A_MateriaCancelar_Click(sender As Object, e As EventArgs) Handles BTN_A_MateriaCancelar.Click
        Me.Close()
    End Sub

End Class