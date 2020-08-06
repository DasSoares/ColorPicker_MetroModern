Public Class Form1

#Region " Declarações "
    Private idcor As Integer = 0
    Private idtema As Integer = 0
    Private bCapturarCor As Boolean = False

    Public Tema As New MetroFramework.MetroThemeStyle
    Public Cor As New MetroFramework.MetroColorStyle
#End Region

#Region " Form "
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Geral.EstiloForm(Me, sender)
        idcor = Geral.Cor_ID
        idtema = Geral.Tema_ID
        Me.cboCor.SelectedIndex = idcor
        Me.cboTema.SelectedIndex = idtema
        'AlteraCores(sender, Cor)
        'AlteraTema(sender, Tema)
        'Estilo(sender)
        ModelaForm()
        updateColor(trbRed.Value, trbGreen.Value, trbBlue.Value)
        cboTipos.SelectedIndex = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim bmp As New Bitmap(1, 1)

        Using g As Graphics = Graphics.FromImage(bmp)
            g.CopyFromScreen(Windows.Forms.Cursor.Position, New Point(0, 0), New Size(1, 1))
        End Using

        Dim pixel As Drawing.Color = bmp.GetPixel(0, 0)

        Dim red As String = bmp.GetPixel(0, 0).R.ToString
        Dim green As String = bmp.GetPixel(0, 0).G.ToString
        Dim blue As String = bmp.GetPixel(0, 0).B.ToString

        If cboTipos.SelectedIndex = 0 Then
            txtResult.Text = red & ", " & green & ", " & blue
        ElseIf cboTipos.SelectedIndex > 0 Then
            txtResult.Text = ColorTranslator.ToHtml(Color.FromArgb(pixel.R, pixel.G, pixel.B)).ToString
        End If

        Dim p As New Point()

        p.X = (Me.Width / 2) - (lblCor.Width / 2)
        p.Y = lblCor.Top
        lblCor.Location = p
        lblCor.BackColor = pixel
        Me.Invalidate()
    End Sub
#End Region

#Region " Controles "
    Private Sub trbRed_Scroll(sender As Object, e As ScrollEventArgs) Handles trbRed.Scroll
        updateColor(trbRed.Value, trbGreen.Value, trbBlue.Value)
    End Sub

    Private Sub trbGreen_Scroll(sender As Object, e As ScrollEventArgs) Handles trbGreen.Scroll
        updateColor(trbRed.Value, trbGreen.Value, trbBlue.Value)
    End Sub

    Private Sub trbBlue_Scroll(sender As Object, e As ScrollEventArgs) Handles trbBlue.Scroll
        updateColor(trbRed.Value, trbGreen.Value, trbBlue.Value)
    End Sub

    Private Sub txtRed_TextChanged(sender As Object, e As EventArgs) Handles txtRed.TextChanged
        Dim v As Integer = Val(Me.txtRed.Text)

        If v.ToString.Length > 3 Then Exit Sub

        Try
            Me.trbRed.Value = v
            Me.lblRed.Text = v.ToString
            updateColor(v, trbGreen.Value, trbBlue.Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtGreen_TextChanged(sender As Object, e As EventArgs) Handles txtGreen.TextChanged
        Dim v As Integer = Val(Me.txtGreen.Text)

        If v.ToString.Length > 3 Then Exit Sub

        Try
            Me.trbGreen.Value = v
            Me.lblGreen.Text = v.ToString
            updateColor(trbRed.Value, v, trbBlue.Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBlue_TextChanged(sender As Object, e As EventArgs) Handles txtBlue.TextChanged
        Dim v As Integer = Val(Me.txtBlue.Text)

        If v.ToString.Length > 3 Then Exit Sub

        Try
            Me.trbBlue.Value = v
            Me.lblBlue.Text = v.ToString
            updateColor(trbRed.Value, trbGreen.Value, v)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkEstilo_Click(sender As Object, e As EventArgs) Handles chkEstilo.Click
        ModelaForm()
    End Sub

    Private Sub cboCor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCor.SelectedIndexChanged
        Estilo(sender)
    End Sub

    Private Sub cboTema_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTema.SelectedIndexChanged
        Estilo(sender)
    End Sub

    Private Sub picPegaCor_Click(sender As Object, e As EventArgs) Handles picPegaCor.Click
        If bCapturarCor = False Then
            bCapturarCor = True
            Me.Timer1.Start()
        Else
            bCapturarCor = False
            Me.Timer1.Stop()
        End If
    End Sub
#End Region

#Region " Funções "
    Private Sub updateColor(r As Integer, g As Integer, b As Integer)
        Me.lblRed.Text = trbRed.Value.ToString
        Me.lblGreen.Text = trbGreen.Value.ToString
        Me.lblBlue.Text = trbBlue.Value.ToString
        Dim idtipo As Integer = Me.cboTipos.SelectedIndex

        Try
            lblCor.BackColor = Color.FromArgb(r, g, b)

        Catch ex As Exception

        End Try

        If idtipo = 1 Then
            Me.txtResult.Text = ColorTranslator.ToHtml(Color.FromArgb(r, g, b))
        Else
            Me.txtResult.Text = r.ToString & ", " & g.ToString & ", " & b.ToString
        End If

    End Sub

    Private Function VerificaTamanho(i As Integer) As Boolean
        Dim b As Boolean = False

        'If i <= 9 Then
        '    If i.ToString.Length > 1 Then b = True
        'ElseIf i <= 9 AndAlso i.ToString.Length = 2 Then
        '    If i.ToString.Length > 2 Then b = True
        'End If

        Return b
    End Function

    Private Sub ModelaForm()
        If Me.chkEstilo.Checked = False Then
            Me.chkEstilo.Checked = False
            panEstilo.Height = 0
            panEstilo.Visible = False
            Me.Height = 464
            Me.Width = 314
        Else
            Me.chkEstilo.Checked = True
            panEstilo.Height = 64
            panEstilo.Visible = True
            Me.Height = 552
            Me.Width = 314
        End If
    End Sub
#End Region

#Region " Tema & Cor "
    Public Sub AlteraTema(sender As Object, theme As MetroFramework.MetroThemeStyle)
        'Função recursiva
        For Each obj As Object In sender.Controls
            Try
                obj.Theme = theme
                lblCor.UseCustomBackColor = True
                obj.Refresh()
            Catch ex As Exception

            End Try

            If TipoObjeto(obj) Then
                AlteraTema(obj, theme)
            End If
        Next
    End Sub

    Public Sub AlteraCores(sender As Object, cor As MetroFramework.MetroColorStyle)
        'Função recursiva
        For Each obj As Object In sender.Controls
            Try
                obj.Style = cor
                Me.Style = cor
                lblCor.UseCustomBackColor = True
                obj.Refresh()
            Catch ex As Exception

            End Try

            If TipoObjeto(obj) Then
                AlteraCores(obj, cor)
            End If
        Next

        Me.Refresh()
    End Sub

    Public Function TipoObjeto(ByRef controle As Object) As Boolean
        Dim b As Boolean = False

        If TypeOf controle Is MetroFramework.Controls.MetroButton Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroCheckBox Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroComboBox Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroContextMenu Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroDataGridHelper Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroDateTime Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroGrid Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroLabel Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroLink Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroListView Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroPanel Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroProgressBar Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroProgressSpinner Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroRadioButton Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroScrollBar Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroTabControl Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroTabPage Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroTextBox Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroTile Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroToggle Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroTrackBar Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroUserControl Then b = True

        Return b
    End Function

    Private Sub Estilo(sender As Object)
        Dim idcorSelected As Integer = Me.cboCor.SelectedIndex
        Dim idtemaSelected As Integer = Me.cboTema.SelectedIndex

        If idcorSelected = 1 AndAlso idtemaSelected = 2 Then
            idcorSelected = 0
        End If

        If idcorSelected = 2 AndAlso idtemaSelected = 1 Then
            idcorSelected = 0
        End If

        Try
            Me.Style = Geral.SelecionaCor(idcorSelected)
            Me.Theme = Geral.SelecionaTema(idtemaSelected)

            AlteraTema(Me, Me.Theme)
            AlteraCores(Me, Me.Style)
            Geral.EstiloXMLSalvar(idcorSelected, idtemaSelected)
        Catch ex As Exception

        End Try

        Me.cboCor.SelectedIndex = idcorSelected
    End Sub
#End Region

End Class
