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
End Class
