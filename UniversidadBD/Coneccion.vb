Imports Oracle.DataAccess.Client
Public Class Coneccion
    Protected Conexion As New OracleConnection()
    Protected Comando As New OracleCommand()
    Protected Almacenamiento As New DataSet()
    Protected Transaccion As OracleTransaction
    Protected Fila As DataRow
    Protected Tabla As DataTable
    Sub New()
        Conexion.ConnectionString = "Data Source=localhost;" + "User Id=TPBD;" + "Password=balditofc42;"
        Almacenamiento.Tables.Clear()
        Comando.Parameters.Clear()
    End Sub
    Public Sub Conectarse()
        Try
            Conexion.Open()
            F_Principal.ToolStripLabel1.Text = "CONECTADO"
            Conexion.Close()
        Catch ex As Exception
            F_Principal.ToolStripLabel1.Text = "DESCONECTADO"
        End Try
    End Sub
    'COMANDOS
    Protected Sub InsertarSQL(Tabla As String)
        Dim Adaptador = New OracleDataAdapter("Select * From " & Tabla, Conexion)
        Almacenamiento.Tables.Clear()
        Adaptador.Fill(Almacenamiento, Tabla)
        Fila = Almacenamiento.Tables(Tabla).NewRow()
    End Sub
    Protected Sub CargarFilaSQL(Tabla As String, Columna As String, Combo As ComboBox)
        Dim Adaptador = New OracleDataAdapter("Select * From " & Tabla, Conexion)
        Almacenamiento.Tables.Clear()
        Adaptador.Fill(Almacenamiento, Tabla)
        Combo.ValueMember = "ID_" & Tabla
        Combo.DataSource = Almacenamiento.Tables(Tabla)
        Combo.DisplayMember = Columna
    End Sub
    Protected Sub ActualizarSQL(Tabla As String)
        Dim Adaptador = New OracleDataAdapter()
        Adaptador.InsertCommand = Comando
        Adaptador.Update(Almacenamiento, Tabla)
        Almacenamiento.Tables.Clear()
    End Sub
    Protected Sub Insert(Tabla As String)
        Almacenamiento.Tables(Tabla).Rows.Add(Fila)
        Comando.Connection = Conexion
    End Sub
    Protected Sub InsertarSQLC(Tabla As String, Columna As String, Condicion As String, Combo As ComboBox, Referencia As ComboBox)
        Dim ID As Integer = Referencia.SelectedValue
        Dim Adaptador = New OracleDataAdapter("Select * From " & Tabla & " Where " & Condicion & " = " & ID, Conexion)
        Almacenamiento.Tables.Clear()
        Adaptador.Fill(Almacenamiento, Tabla)
        Combo.ValueMember = "ID_" & Tabla
        Combo.DataSource = Almacenamiento.Tables(Tabla)
        Combo.DisplayMember = Columna
    End Sub
    Protected Sub InsertarSQLE(Combo As ComboBox, Tabla As String, Columna As String, Valor As String, Condicion As String)
        Dim Adaptador = New OracleDataAdapter("Select * From " & Tabla & " Where " & Condicion, Conexion)
        Almacenamiento.Tables.Clear()
        Adaptador.Fill(Almacenamiento, Tabla)
        Combo.ValueMember = Valor
        Combo.DataSource = Almacenamiento.Tables(Tabla)
        Combo.DisplayMember = Columna
    End Sub
    Protected Sub CargarSinRepetir(Combo As ComboBox, Tabla As String, Columna As String, Valor As String)
        Dim Adaptador = New OracleDataAdapter("Select Distinct " & Columna & " From " & Tabla, Conexion)
        Almacenamiento.Tables.Clear()
        Adaptador.Fill(Almacenamiento, Tabla)
        Combo.ValueMember = Valor
        Combo.DataSource = Almacenamiento.Tables(Tabla)
        Combo.DisplayMember = Columna
    End Sub
    Protected Sub CargarSinRepetirC(Combo As ComboBox, Tabla As String, Columna As String, Valor As String, Condicion As String)
        Dim Adaptador = New OracleDataAdapter("Select Distinct " & Columna & " From " & Tabla & " Where " & Condicion, Conexion)
        Almacenamiento.Tables.Clear()
        Adaptador.Fill(Almacenamiento, Tabla)
        Combo.ValueMember = Valor
        Combo.DataSource = Almacenamiento.Tables(Tabla)
        Combo.DisplayMember = Columna
    End Sub
    Public Sub EditarSQL(Tabla As String, Columna As String, Valor As String, Condicion As String, Referencia As String)
        Dim Adaptador = New OracleDataAdapter("Update " & Tabla & " Set " & Columna & " = " & Valor & " Where " & Condicion & " = " & Referencia, Conexion)
        Almacenamiento.Tables.Clear()
        Adaptador.Fill(Almacenamiento, Tabla)
        ActualizarSQL(Tabla)
    End Sub
End Class