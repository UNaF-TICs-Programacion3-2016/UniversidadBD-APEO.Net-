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
End Class
