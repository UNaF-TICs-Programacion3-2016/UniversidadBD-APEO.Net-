Imports Oracle.DataAccess.Client
Public Class Configuracion
    Inherits Coneccion
    Private X As Integer
    Private Y As Integer
    Private Alto As Integer
    Private Ancho As Integer
    Sub EstablecerConfiguracion(Formulario As Form, Panel As Panel, Pestañas As TabControl)
        Formulario.Width = 587
        Formulario.Height = 485
        Panel.Width = 532
        Panel.Height = 390
        Panel.Top = 6
        Panel.Left = 6
        Pestañas.Width = 552
        Pestañas.Height = 428
        Formulario.Show()
        Panel.Visible = True
    End Sub
    Sub EstablecerPanel(Panel As Panel)
        Panel.Left = 3
        Panel.Top = 68
        Panel.Width = 1069
        Panel.Height = 488
        Panel.Visible = True
    End Sub
    Sub CargarComboBox(Combo As ComboBox, Panel As Panel, Tabla As String, Columna As String)
        If Panel.Visible = True Then
            Try
                CargarFilaSQL(Tabla, Tabla & "_" & Columna, Combo)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Friend Sub SeleccionarCorrelativas()
        Try
            Dim ID As Integer = F_Secundario.CMB_A_SeleccionarCarreraMateria.SelectedValue
            Dim Tabla As String = "MATERIA"
            Dim Condicion As String = "MATERIA_RELA_CARRERA = ID"
            InsertarSQLC(Tabla, Condicion)
            F_Secundario.CMB_A_SeleccioneCorrelativasCorrelativa.ValueMember = "ID_MATERIA"
            F_Secundario.CMB_A_SeleccioneCorrelativasCorrelativa.DataSource = Almacenamiento.Tables(Tabla)
            F_Secundario.CMB_A_SeleccioneCorrelativasCorrelativa.DisplayMember = "MATERIA_DESCRIPCION"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub CargarCombo(Panel As Panel)
        If Panel.Visible = True Then
            Try
                SeleccionarCorrelativas()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class
