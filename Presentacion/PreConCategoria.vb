Imports Entidad
Imports Logica
Public Class PreConCategoria
    Dim ObjLogCategoria As New LogCategoria
    Dim g As String = "N"
    Dim Boton(1) As Button

    Private Sub PreConCategoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dg.DataSource = ObjLogCategoria.buscar("")
        CargarBotones()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        g = "N"
        ErrDatos.Clear()
        LimpiarGroupbox(GBox)
        TxtCodigo.Text = ObjLogCategoria.MaxCodigo()
        ControlBotones(Boton, New [Boolean]() {True, False})
    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        ErrDatos.Clear()
        If MessageBox.Show("Desea Guardar los Datos", "Sistema Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If ValidaEntrada(ErrDatos, GBox) Then
                If g = "N" Then
                    ObjLogCategoria.ingresar(New EntCategoria(Val(TxtCodigo.Text), TxtDescripcion.Text))
                Else
                    ObjLogCategoria.modificar(New EntCategoria(Val(TxtCodigo.Text), TxtDescripcion.Text))
                End If
                LimpiarGroupbox(GBox)
                LimpiarGroupbox(GBoxBuscar)
                ControlBotones(Boton, New [Boolean]() {False, False})
            Else
                MessageBox.Show("Error. Llene los campos")
            End If
        End If
        Dg.DataSource = ObjLogCategoria.buscar("")
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        ErrDatos.Clear()
        If MessageBox.Show("Desea Guardar los Datos", "Sistema Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            ObjLogCategoria.eliminar(New EntCategoria(Val(TxtCodigo.Text), TxtDescripcion.Text))
            Dg.DataSource = ObjLogCategoria.buscar("")
            LimpiarGroupbox(GBox)
            LimpiarGroupbox(GBoxBuscar)
            ControlBotones(Boton, New [Boolean]() {False, False})
        End If
    End Sub


    Public Sub LimpiarGroupbox(ByVal Grp As GroupBox)
        For Each C In Grp.Controls
            If TypeOf C Is TextBox Then C.Text = ""
        Next
    End Sub
    Public Function ValidaEntrada(ByVal err As ErrorProvider, ByVal grp As GroupBox) As Boolean
        Dim er As Boolean = True
        For Each C In grp.Controls 'For que se lo utiliza para leer colecciones
            If TypeOf C Is TextBox And C.Text = "" Then 'TypeOf = tipo
                err.SetError(C, "No ha ingresado informacion en: " + C.Name)
                er = False
            End If
        Next
        Return er
    End Function

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Dg_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg.CellDoubleClick
        ErrDatos.Clear()
        Try
            TxtCodigo.Text = Dg.Rows(Dg.CurrentRow.Index).Cells(0).Value
            TxtDescripcion.Text = Dg.Rows(Dg.CurrentRow.Index).Cells(1).Value
        Catch ex As Exception
            MessageBox.Show("Error Mensaje:--> " + ex.Message.ToString)
        End Try
        g = "M"
        ControlBotones(Boton, New [Boolean]() {True, True})
    End Sub

    Private Sub TxtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscar.TextChanged
        Dim ca As New EntCategoria
        Try
            If (TxtBuscar.Text <> "") Then
                If (RbCod.Checked = True) Then
                    ca = ObjLogCategoria.buscarCodigo(Val(TxtBuscar.Text))
                    Dim lista As New List(Of EntCategoria)
                    lista.Add(ca)
                    Dg.DataSource = lista
                Else
                    If (RbDesc.Checked = True) Then
                        Dg.DataSource = ObjLogCategoria.buscar(TxtBuscar.Text)
                    End If
                End If
            Else
                Dg.DataSource = ObjLogCategoria.buscar("")
            End If
        Catch ex As Exception
            Dg.DataSource = ObjLogCategoria.buscar(-1)
            MessageBox.Show("Error Mensaje:--> " + ex.Message.ToString)
        End Try
    End Sub
    Public Sub CargarBotones()
        Boton(0) = BtnGrabar
        Boton(1) = BtnEliminar
    End Sub
    Public Sub ControlBotones(ByVal boton() As Button, ByVal opciones() As Boolean)
        Boton(0).Enabled = opciones(0)
        Boton(1).Enabled = opciones(1)
    End Sub
End Class