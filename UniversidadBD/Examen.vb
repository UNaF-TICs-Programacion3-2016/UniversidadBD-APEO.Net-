Imports Oracle.DataAccess.Client
Public Class Examen
    Inherits Coneccion
    Private pFecha As Date
    Private pHora As Integer
    Private pMinuto As Integer
    Private pTipo As Boolean
    Private pLlamado As Integer
    Private pNumeroParcial As Integer
    Private pCondicion As Boolean
    'PROPIEDADES
    Public Property Fecha() As Date
        Get
            Return pFecha
        End Get
        Set(ByVal value As Date)
            pFecha = value
        End Set
    End Property
    Public Property Hora() As Integer
        Get
            Return pHora
        End Get
        Set(ByVal value As Integer)
            pHora = value
        End Set
    End Property
    Public Property Tipo() As String
        Get
            Return pTipo
        End Get
        Set(ByVal value As String)
            pTipo = value
        End Set
    End Property
    Public Property Condicion() As String
        Get
            Return pCondicion
        End Get
        Set(ByVal value As String)
            pCondicion = value
        End Set
    End Property
    Public Property Minuto() As Integer
        Get
            Return pMinuto
        End Get
        Set(ByVal value As Integer)
            pMinuto = value
        End Set
    End Property
    Public Property Llamado() As Integer
        Get
            Return pLlamado
        End Get
        Set(ByVal value As Integer)
            pLlamado = value
        End Set
    End Property
    Public Property NumeroParcial() As Integer
        Get
            Return pNumeroParcial
        End Get
        Set(ByVal value As Integer)
            pNumeroParcial = value
        End Set
    End Property
    'INSERTAR EXAMEN
    Friend Sub InsertarExamen()
        Try
            Dim Tabla As String = "EXAMEN"
            InsertarSQL(Tabla)
            Dim RELAMATERIA As String = F_Secundario.CMB_A_MateriaExamenFinal.SelectedValue
            Dim RELAHORA As String = F_Secundario.CMB_A_HoraExamen.SelectedValue
            Dim RELAMINUTO As String = F_Secundario.CMB_A_MinutoExamen.SelectedValue
            Dim RELAAULA As String = F_Secundario.CMB_A_AulaExamenFinal.SelectedValue
            Fila("EXAMEN_RELA_MATERIA") = RELAMATERIA
            Fila("EXAMEN_FECHA") = F_Secundario.Examen.Fecha
            Fila("EXAMEN_RELA_HORA") = RELAHORA
            If F_Secundario.Examen.Condicion = True Then
                Fila("EXAMEN_RELA_TIPO_EXAMEN") = 2
            Else
                Fila("EXAMEN_RELA_TIPO_EXAMEN") = 1
            End If
            Fila("EXAMEN_RELA_MINUTO") = RELAMINUTO
            Fila("EXAMEN_LLAMADO") = F_Secundario.NUD_A_LlamadoExamenFinal.Value
            Fila("EXAMEN_NUMERO_PARCIAL") = F_Secundario.NUD_A_NParcialExamenFinal.Value
            Fila("EXAMEN_RELA_AULA") = RELAAULA
            Insert(Tabla)
            Comando.Parameters.Clear()
            Comando.CommandText = "Insert Into Examen VALUES(:idexamen,:relamateria,:fecha,:hora,:tipo,:minuto,:llamado,:numeroparcial,:aula)"
            Comando.Parameters.Add(New OracleParameter(":idexamen", OracleDbType.Int64, 10, "ID_EXAMEN"))
            Comando.Parameters.Add(New OracleParameter(":relamateria", OracleDbType.Int64, 10, "EXAMEN_RELA_MATERIA"))
            Comando.Parameters.Add(New OracleParameter(":fecha", OracleDbType.Date, 0, "EXAMEN_FECHA"))
            Comando.Parameters.Add(New OracleParameter(":hora", OracleDbType.Int64, 10, "EXAMEN_RELA_HORA"))
            Comando.Parameters.Add(New OracleParameter(":tipo", OracleDbType.Int64, 10, "EXAMEN_RELA_TIPO_EXAMEN"))
            Comando.Parameters.Add(New OracleParameter(":minuto", OracleDbType.Int64, 10, "EXAMEN_RELA_MINUTO"))
            Comando.Parameters.Add(New OracleParameter(":llamado", OracleDbType.Int64, 2, "EXAMEN_LLAMADO"))
            Comando.Parameters.Add(New OracleParameter(":numeroparcial", OracleDbType.Int64, 2, "EXAMEN_NUMERO_PARCIAL"))
            Comando.Parameters.Add(New OracleParameter(":aula", OracleDbType.Int64, 10, "EXAMEN_RELA_AULA"))
            ActualizarSQL(Tabla)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
