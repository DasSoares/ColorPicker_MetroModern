<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    'Inherits System.Windows.Forms.Form
    Inherits MetroFramework.Forms.MetroForm

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.txtResult = New MetroFramework.Controls.MetroTextBox()
        Me.cboTipos = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txtBlue = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtGreen = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtRed = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lblBlue = New MetroFramework.Controls.MetroLabel()
        Me.trbBlue = New MetroFramework.Controls.MetroTrackBar()
        Me.lblGreen = New MetroFramework.Controls.MetroLabel()
        Me.trbGreen = New MetroFramework.Controls.MetroTrackBar()
        Me.lblRed = New MetroFramework.Controls.MetroLabel()
        Me.trbRed = New MetroFramework.Controls.MetroTrackBar()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.chkEstilo = New MetroFramework.Controls.MetroCheckBox()
        Me.panEstilo = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.cboTema = New MetroFramework.Controls.MetroComboBox()
        Me.cboCor = New MetroFramework.Controls.MetroComboBox()
        Me.lblCor = New MetroFramework.Controls.MetroLabel()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.picExibirLista = New System.Windows.Forms.PictureBox()
        Me.picPegaCor = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lsbCores = New System.Windows.Forms.ListBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.picLupa = New System.Windows.Forms.PictureBox()
        Me.tlZoomWidth = New MetroFramework.Controls.MetroTile()
        Me.tlZoomHeight = New MetroFramework.Controls.MetroTile()
        Me.dgvCores = New MetroFramework.Controls.MetroGrid()
        Me.panEstilo.SuspendLayout()
        CType(Me.picExibirLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPegaCor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLupa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.Location = New System.Drawing.Point(15, 339)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(285, 1)
        Me.MetroTile2.TabIndex = 37
        Me.MetroTile2.Text = "MetroTile1"
        Me.MetroTile2.UseSelectable = True
        '
        'txtResult
        '
        '
        '
        '
        Me.txtResult.CustomButton.Image = Nothing
        Me.txtResult.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtResult.CustomButton.Location = New System.Drawing.Point(115, 1)
        Me.txtResult.CustomButton.Name = ""
        Me.txtResult.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtResult.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtResult.CustomButton.TabIndex = 1
        Me.txtResult.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtResult.CustomButton.UseSelectable = True
        Me.txtResult.CustomButton.Visible = False
        Me.txtResult.Lines = New String(-1) {}
        Me.txtResult.Location = New System.Drawing.Point(155, 397)
        Me.txtResult.MaxLength = 1000
        Me.txtResult.Name = "txtResult"
        Me.txtResult.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResult.PromptText = "Result"
        Me.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtResult.SelectedText = ""
        Me.txtResult.SelectionLength = 0
        Me.txtResult.SelectionStart = 0
        Me.txtResult.ShortcutsEnabled = True
        Me.txtResult.Size = New System.Drawing.Size(137, 23)
        Me.txtResult.TabIndex = 36
        Me.txtResult.UseSelectable = True
        Me.txtResult.WaterMark = "Result"
        Me.txtResult.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtResult.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cboTipos
        '
        Me.cboTipos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboTipos.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cboTipos.FormattingEnabled = True
        Me.cboTipos.ItemHeight = 19
        Me.cboTipos.Items.AddRange(New Object() {"RGB", "HTML"})
        Me.cboTipos.Location = New System.Drawing.Point(23, 396)
        Me.cboTipos.Name = "cboTipos"
        Me.cboTipos.Size = New System.Drawing.Size(126, 25)
        Me.cboTipos.TabIndex = 35
        Me.cboTipos.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(218, 360)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(24, 19)
        Me.MetroLabel6.TabIndex = 34
        Me.MetroLabel6.Text = "B: "
        '
        'txtBlue
        '
        '
        '
        '
        Me.txtBlue.CustomButton.Image = Nothing
        Me.txtBlue.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtBlue.CustomButton.Location = New System.Drawing.Point(27, 1)
        Me.txtBlue.CustomButton.Name = ""
        Me.txtBlue.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBlue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBlue.CustomButton.TabIndex = 1
        Me.txtBlue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBlue.CustomButton.UseSelectable = True
        Me.txtBlue.CustomButton.Visible = False
        Me.txtBlue.Lines = New String(-1) {}
        Me.txtBlue.Location = New System.Drawing.Point(243, 359)
        Me.txtBlue.MaxLength = 3
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBlue.PromptText = "Blue"
        Me.txtBlue.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBlue.SelectedText = ""
        Me.txtBlue.SelectionLength = 0
        Me.txtBlue.SelectionStart = 0
        Me.txtBlue.ShortcutsEnabled = True
        Me.txtBlue.Size = New System.Drawing.Size(49, 23)
        Me.txtBlue.TabIndex = 33
        Me.txtBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBlue.UseSelectable = True
        Me.txtBlue.WaterMark = "Blue"
        Me.txtBlue.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBlue.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(120, 360)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(26, 19)
        Me.MetroLabel3.TabIndex = 32
        Me.MetroLabel3.Text = "G: "
        '
        'txtGreen
        '
        '
        '
        '
        Me.txtGreen.CustomButton.Image = Nothing
        Me.txtGreen.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtGreen.CustomButton.Location = New System.Drawing.Point(27, 1)
        Me.txtGreen.CustomButton.Name = ""
        Me.txtGreen.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtGreen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGreen.CustomButton.TabIndex = 1
        Me.txtGreen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGreen.CustomButton.UseSelectable = True
        Me.txtGreen.CustomButton.Visible = False
        Me.txtGreen.Lines = New String(-1) {}
        Me.txtGreen.Location = New System.Drawing.Point(147, 358)
        Me.txtGreen.MaxLength = 3
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGreen.PromptText = "Green"
        Me.txtGreen.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGreen.SelectedText = ""
        Me.txtGreen.SelectionLength = 0
        Me.txtGreen.SelectionStart = 0
        Me.txtGreen.ShortcutsEnabled = True
        Me.txtGreen.Size = New System.Drawing.Size(49, 23)
        Me.txtGreen.TabIndex = 31
        Me.txtGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtGreen.UseSelectable = True
        Me.txtGreen.WaterMark = "Green"
        Me.txtGreen.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGreen.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 359)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(24, 19)
        Me.MetroLabel2.TabIndex = 30
        Me.MetroLabel2.Text = "R: "
        '
        'txtRed
        '
        '
        '
        '
        Me.txtRed.CustomButton.Image = Nothing
        Me.txtRed.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtRed.CustomButton.Location = New System.Drawing.Point(27, 1)
        Me.txtRed.CustomButton.Name = ""
        Me.txtRed.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtRed.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRed.CustomButton.TabIndex = 1
        Me.txtRed.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRed.CustomButton.UseSelectable = True
        Me.txtRed.CustomButton.Visible = False
        Me.txtRed.Lines = New String(-1) {}
        Me.txtRed.Location = New System.Drawing.Point(49, 358)
        Me.txtRed.MaxLength = 3
        Me.txtRed.Name = "txtRed"
        Me.txtRed.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRed.PromptText = "Red"
        Me.txtRed.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRed.SelectedText = ""
        Me.txtRed.SelectionLength = 0
        Me.txtRed.SelectionStart = 0
        Me.txtRed.ShortcutsEnabled = True
        Me.txtRed.Size = New System.Drawing.Size(49, 23)
        Me.txtRed.TabIndex = 29
        Me.txtRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtRed.UseSelectable = True
        Me.txtRed.WaterMark = "Red"
        Me.txtRed.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRed.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 290)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(35, 19)
        Me.MetroLabel5.TabIndex = 28
        Me.MetroLabel5.Text = "Blue"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 239)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel4.TabIndex = 27
        Me.MetroLabel4.Text = "Green"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 187)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(32, 19)
        Me.MetroLabel1.TabIndex = 26
        Me.MetroLabel1.Text = "Red"
        '
        'lblBlue
        '
        Me.lblBlue.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblBlue.Location = New System.Drawing.Point(233, 287)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(60, 19)
        Me.lblBlue.TabIndex = 25
        Me.lblBlue.Text = "0"
        Me.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'trbBlue
        '
        Me.trbBlue.BackColor = System.Drawing.Color.Transparent
        Me.trbBlue.Location = New System.Drawing.Point(23, 312)
        Me.trbBlue.Maximum = 255
        Me.trbBlue.Name = "trbBlue"
        Me.trbBlue.Size = New System.Drawing.Size(270, 23)
        Me.trbBlue.TabIndex = 24
        Me.trbBlue.Text = "MetroTrackBar3"
        Me.trbBlue.Value = 245
        '
        'lblGreen
        '
        Me.lblGreen.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblGreen.Location = New System.Drawing.Point(233, 239)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(60, 19)
        Me.lblGreen.TabIndex = 23
        Me.lblGreen.Text = "0"
        Me.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'trbGreen
        '
        Me.trbGreen.BackColor = System.Drawing.Color.Transparent
        Me.trbGreen.Location = New System.Drawing.Point(23, 261)
        Me.trbGreen.Maximum = 255
        Me.trbGreen.Name = "trbGreen"
        Me.trbGreen.Size = New System.Drawing.Size(270, 23)
        Me.trbGreen.TabIndex = 22
        Me.trbGreen.Text = "MetroTrackBar2"
        Me.trbGreen.Value = 80
        '
        'lblRed
        '
        Me.lblRed.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblRed.Location = New System.Drawing.Point(233, 187)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(60, 19)
        Me.lblRed.TabIndex = 21
        Me.lblRed.Text = "0"
        Me.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'trbRed
        '
        Me.trbRed.BackColor = System.Drawing.Color.Transparent
        Me.trbRed.Location = New System.Drawing.Point(23, 209)
        Me.trbRed.Maximum = 255
        Me.trbRed.Name = "trbRed"
        Me.trbRed.Size = New System.Drawing.Size(270, 23)
        Me.trbRed.TabIndex = 20
        Me.trbRed.Text = "MetroTrackBar1"
        Me.trbRed.Value = 40
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Location = New System.Drawing.Point(15, 433)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(285, 1)
        Me.MetroTile1.TabIndex = 39
        Me.MetroTile1.Text = "MetroTile1"
        Me.MetroTile1.UseSelectable = True
        '
        'chkEstilo
        '
        Me.chkEstilo.AutoSize = True
        Me.chkEstilo.Location = New System.Drawing.Point(23, 440)
        Me.chkEstilo.Name = "chkEstilo"
        Me.chkEstilo.Size = New System.Drawing.Size(104, 15)
        Me.chkEstilo.TabIndex = 40
        Me.chkEstilo.Text = "MUDAR ESTILO"
        Me.chkEstilo.UseSelectable = True
        '
        'panEstilo
        '
        Me.panEstilo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panEstilo.Controls.Add(Me.MetroLabel7)
        Me.panEstilo.Controls.Add(Me.MetroLabel8)
        Me.panEstilo.Controls.Add(Me.cboTema)
        Me.panEstilo.Controls.Add(Me.cboCor)
        Me.panEstilo.HorizontalScrollbarBarColor = True
        Me.panEstilo.HorizontalScrollbarHighlightOnWheel = False
        Me.panEstilo.HorizontalScrollbarSize = 10
        Me.panEstilo.Location = New System.Drawing.Point(23, 468)
        Me.panEstilo.Name = "panEstilo"
        Me.panEstilo.Size = New System.Drawing.Size(269, 64)
        Me.panEstilo.TabIndex = 41
        Me.panEstilo.VerticalScrollbarBarColor = True
        Me.panEstilo.VerticalScrollbarHighlightOnWheel = False
        Me.panEstilo.VerticalScrollbarSize = 10
        Me.panEstilo.Visible = False
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.Location = New System.Drawing.Point(153, 9)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(35, 15)
        Me.MetroLabel7.TabIndex = 10
        Me.MetroLabel7.Text = "Tema"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel8.Location = New System.Drawing.Point(14, 9)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(26, 15)
        Me.MetroLabel8.TabIndex = 9
        Me.MetroLabel8.Text = "Cor"
        '
        'cboTema
        '
        Me.cboTema.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cboTema.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.cboTema.FormattingEnabled = True
        Me.cboTema.ItemHeight = 19
        Me.cboTema.Items.AddRange(New Object() {"Default", "Light", "Dark"})
        Me.cboTema.Location = New System.Drawing.Point(153, 25)
        Me.cboTema.Name = "cboTema"
        Me.cboTema.Size = New System.Drawing.Size(105, 25)
        Me.cboTema.TabIndex = 3
        Me.cboTema.UseSelectable = True
        '
        'cboCor
        '
        Me.cboCor.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cboCor.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.cboCor.FormattingEnabled = True
        Me.cboCor.ItemHeight = 19
        Me.cboCor.Items.AddRange(New Object() {"Default", "Black", "White", "Silver", "Blue", "Green", "Lime", "Teal", "Orange", "Brown", "Pink", "Magenta", "Purple", "Red", "Yellow"})
        Me.cboCor.Location = New System.Drawing.Point(14, 25)
        Me.cboCor.Name = "cboCor"
        Me.cboCor.Size = New System.Drawing.Size(133, 25)
        Me.cboCor.TabIndex = 2
        Me.cboCor.UseSelectable = True
        '
        'lblCor
        '
        Me.lblCor.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCor.Location = New System.Drawing.Point(15, 60)
        Me.lblCor.Name = "lblCor"
        Me.lblCor.Size = New System.Drawing.Size(141, 118)
        Me.lblCor.TabIndex = 42
        Me.lblCor.UseCustomBackColor = True
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.[Default]
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.[Default]
        '
        'picExibirLista
        '
        Me.picExibirLista.Image = Global.ColorPicker_MetroModern.My.Resources.Resources.arrow_16
        Me.picExibirLista.Location = New System.Drawing.Point(276, 41)
        Me.picExibirLista.Name = "picExibirLista"
        Me.picExibirLista.Size = New System.Drawing.Size(16, 16)
        Me.picExibirLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExibirLista.TabIndex = 45
        Me.picExibirLista.TabStop = False
        Me.MetroToolTip1.SetToolTip(Me.picExibirLista, "CAPUTRAR COR")
        '
        'picPegaCor
        '
        Me.picPegaCor.Image = Global.ColorPicker_MetroModern.My.Resources.Resources.color_dropper_16
        Me.picPegaCor.Location = New System.Drawing.Point(243, 41)
        Me.picPegaCor.Name = "picPegaCor"
        Me.picPegaCor.Size = New System.Drawing.Size(16, 16)
        Me.picPegaCor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPegaCor.TabIndex = 43
        Me.picPegaCor.TabStop = False
        Me.MetroToolTip1.SetToolTip(Me.picPegaCor, "CAPUTRAR COR")
        '
        'Timer1
        '
        '
        'lsbCores
        '
        Me.lsbCores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsbCores.FormattingEnabled = True
        Me.lsbCores.ItemHeight = 16
        Me.lsbCores.Location = New System.Drawing.Point(545, 60)
        Me.lsbCores.Name = "lsbCores"
        Me.lsbCores.Size = New System.Drawing.Size(183, 356)
        Me.lsbCores.TabIndex = 46
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10
        '
        'picLupa
        '
        Me.picLupa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLupa.Location = New System.Drawing.Point(162, 60)
        Me.picLupa.Name = "picLupa"
        Me.picLupa.Size = New System.Drawing.Size(138, 118)
        Me.picLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLupa.TabIndex = 47
        Me.picLupa.TabStop = False
        '
        'tlZoomWidth
        '
        Me.tlZoomWidth.ActiveControl = Nothing
        Me.tlZoomWidth.Location = New System.Drawing.Point(162, 119)
        Me.tlZoomWidth.Name = "tlZoomWidth"
        Me.tlZoomWidth.Size = New System.Drawing.Size(138, 1)
        Me.tlZoomWidth.TabIndex = 48
        Me.tlZoomWidth.Text = "MetroTile3"
        Me.tlZoomWidth.UseSelectable = True
        '
        'tlZoomHeight
        '
        Me.tlZoomHeight.ActiveControl = Nothing
        Me.tlZoomHeight.Location = New System.Drawing.Point(231, 60)
        Me.tlZoomHeight.Name = "tlZoomHeight"
        Me.tlZoomHeight.Size = New System.Drawing.Size(1, 118)
        Me.tlZoomHeight.TabIndex = 49
        Me.tlZoomHeight.Text = "MetroTile4"
        Me.tlZoomHeight.UseSelectable = True
        '
        'dgvCores
        '
        Me.dgvCores.AllowUserToAddRows = False
        Me.dgvCores.AllowUserToDeleteRows = False
        Me.dgvCores.AllowUserToResizeRows = False
        Me.dgvCores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCores.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCores.EnableHeadersVisualStyles = False
        Me.dgvCores.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvCores.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCores.Location = New System.Drawing.Point(323, 60)
        Me.dgvCores.Name = "dgvCores"
        Me.dgvCores.ReadOnly = True
        Me.dgvCores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCores.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCores.RowHeadersVisible = False
        Me.dgvCores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCores.Size = New System.Drawing.Size(183, 356)
        Me.dgvCores.TabIndex = 50
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 552)
        Me.Controls.Add(Me.dgvCores)
        Me.Controls.Add(Me.tlZoomHeight)
        Me.Controls.Add(Me.tlZoomWidth)
        Me.Controls.Add(Me.picLupa)
        Me.Controls.Add(Me.lsbCores)
        Me.Controls.Add(Me.picExibirLista)
        Me.Controls.Add(Me.picPegaCor)
        Me.Controls.Add(Me.lblCor)
        Me.Controls.Add(Me.panEstilo)
        Me.Controls.Add(Me.chkEstilo)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.cboTipos)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.txtBlue)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtGreen)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txtRed)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.trbBlue)
        Me.Controls.Add(Me.lblGreen)
        Me.Controls.Add(Me.trbGreen)
        Me.Controls.Add(Me.lblRed)
        Me.Controls.Add(Me.trbRed)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(558, 552)
        Me.MinimumSize = New System.Drawing.Size(314, 464)
        Me.Name = "Form1"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Seletor de Cores"
        Me.panEstilo.ResumeLayout(False)
        Me.panEstilo.PerformLayout()
        CType(Me.picExibirLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPegaCor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLupa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents txtResult As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cboTipos As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtBlue As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtGreen As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtRed As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblBlue As MetroFramework.Controls.MetroLabel
    Friend WithEvents trbBlue As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents lblGreen As MetroFramework.Controls.MetroLabel
    Friend WithEvents trbGreen As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents lblRed As MetroFramework.Controls.MetroLabel
    Friend WithEvents trbRed As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents chkEstilo As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents panEstilo As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboTema As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cboCor As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblCor As MetroFramework.Controls.MetroLabel
    Friend WithEvents picPegaCor As PictureBox
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picExibirLista As PictureBox
    Friend WithEvents lsbCores As ListBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents picLupa As PictureBox
    Friend WithEvents tlZoomWidth As MetroFramework.Controls.MetroTile
    Friend WithEvents tlZoomHeight As MetroFramework.Controls.MetroTile
    Friend WithEvents dgvCores As MetroFramework.Controls.MetroGrid
End Class
