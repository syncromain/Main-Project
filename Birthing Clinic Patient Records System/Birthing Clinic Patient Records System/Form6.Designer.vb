<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_editing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_editing))
        Me.pnl_border = New System.Windows.Forms.Panel()
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lblpatientid = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbsex = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcontact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmartial = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtaddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtpbirth = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtfirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtlastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnsubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.pnl_border.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_border
        '
        Me.pnl_border.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnl_border.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnl_border.Controls.Add(Me.btnminimize)
        Me.pnl_border.Controls.Add(Me.btnclose)
        Me.pnl_border.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_border.Location = New System.Drawing.Point(0, 0)
        Me.pnl_border.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_border.Name = "pnl_border"
        Me.pnl_border.Size = New System.Drawing.Size(567, 19)
        Me.pnl_border.TabIndex = 16
        '
        'btnminimize
        '
        Me.btnminimize.BackColor = System.Drawing.Color.Transparent
        Me.btnminimize.BackgroundImage = CType(resources.GetObject("btnminimize.BackgroundImage"), System.Drawing.Image)
        Me.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnminimize.FlatAppearance.BorderSize = 0
        Me.btnminimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnminimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimize.Font = New System.Drawing.Font("Berlin Sans FB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnminimize.ForeColor = System.Drawing.Color.Black
        Me.btnminimize.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnminimize.Location = New System.Drawing.Point(524, 0)
        Me.btnminimize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(19, 19)
        Me.btnminimize.TabIndex = 11
        Me.btnminimize.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.BackgroundImage = CType(resources.GetObject("btnclose.BackgroundImage"), System.Drawing.Image)
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Berlin Sans FB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.Black
        Me.btnclose.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnclose.Location = New System.Drawing.Point(545, 0)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(19, 19)
        Me.btnclose.TabIndex = 12
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'lblpatientid
        '
        Me.lblpatientid.AutoEllipsis = True
        Me.lblpatientid.BackColor = System.Drawing.Color.Transparent
        Me.lblpatientid.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblpatientid.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblpatientid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblpatientid.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpatientid.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblpatientid.Location = New System.Drawing.Point(0, 19)
        Me.lblpatientid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpatientid.Name = "lblpatientid"
        Me.lblpatientid.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.lblpatientid.Size = New System.Drawing.Size(567, 32)
        Me.lblpatientid.TabIndex = 62
        Me.lblpatientid.Text = "Patient ID: "
        Me.lblpatientid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(18, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 15)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Sex"
        '
        'cbsex
        '
        Me.cbsex.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female"})
        Me.cbsex.BackColor = System.Drawing.Color.Transparent
        Me.cbsex.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.cbsex.BorderRadius = 14
        Me.cbsex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsex.Enabled = False
        Me.cbsex.FillColor = System.Drawing.Color.WhiteSmoke
        Me.cbsex.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbsex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbsex.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbsex.ForeColor = System.Drawing.Color.Black
        Me.cbsex.ItemHeight = 24
        Me.cbsex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbsex.Location = New System.Drawing.Point(17, 141)
        Me.cbsex.Name = "cbsex"
        Me.cbsex.Size = New System.Drawing.Size(145, 30)
        Me.cbsex.StartIndex = 0
        Me.cbsex.TabIndex = 71
        Me.cbsex.TextOffset = New System.Drawing.Point(2, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(18, 332)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Mobile"
        '
        'txtcontact
        '
        Me.txtcontact.Animated = True
        Me.txtcontact.AutoRoundedCorners = True
        Me.txtcontact.BackColor = System.Drawing.Color.Transparent
        Me.txtcontact.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtcontact.BorderRadius = 14
        Me.txtcontact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcontact.DefaultText = ""
        Me.txtcontact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcontact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcontact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcontact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcontact.Enabled = False
        Me.txtcontact.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtcontact.FocusedState.BorderColor = System.Drawing.Color.White
        Me.txtcontact.Font = New System.Drawing.Font("Segoe UI", 9.2!)
        Me.txtcontact.ForeColor = System.Drawing.Color.Black
        Me.txtcontact.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtcontact.IconLeftSize = New System.Drawing.Size(0, 0)
        Me.txtcontact.IconRightSize = New System.Drawing.Size(18, 18)
        Me.txtcontact.Location = New System.Drawing.Point(18, 349)
        Me.txtcontact.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcontact.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtcontact.PlaceholderText = "Contact Number"
        Me.txtcontact.SelectedText = ""
        Me.txtcontact.ShadowDecoration.BorderRadius = 10
        Me.txtcontact.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtcontact.ShadowDecoration.Depth = 10
        Me.txtcontact.ShadowDecoration.Enabled = True
        Me.txtcontact.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.txtcontact.Size = New System.Drawing.Size(175, 30)
        Me.txtcontact.TabIndex = 75
        Me.txtcontact.TextOffset = New System.Drawing.Point(2, -1)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(18, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Martial Status"
        '
        'txtmartial
        '
        Me.txtmartial.Animated = True
        Me.txtmartial.AutoRoundedCorners = True
        Me.txtmartial.BackColor = System.Drawing.Color.Transparent
        Me.txtmartial.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtmartial.BorderRadius = 14
        Me.txtmartial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmartial.DefaultText = ""
        Me.txtmartial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtmartial.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtmartial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmartial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmartial.Enabled = False
        Me.txtmartial.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtmartial.FocusedState.BorderColor = System.Drawing.Color.White
        Me.txtmartial.Font = New System.Drawing.Font("Segoe UI", 9.2!)
        Me.txtmartial.ForeColor = System.Drawing.Color.Black
        Me.txtmartial.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtmartial.IconLeftSize = New System.Drawing.Size(0, 0)
        Me.txtmartial.IconRightSize = New System.Drawing.Size(18, 18)
        Me.txtmartial.Location = New System.Drawing.Point(18, 298)
        Me.txtmartial.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmartial.Name = "txtmartial"
        Me.txtmartial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmartial.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtmartial.PlaceholderText = "Martial Status"
        Me.txtmartial.SelectedText = ""
        Me.txtmartial.ShadowDecoration.BorderRadius = 10
        Me.txtmartial.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtmartial.ShadowDecoration.Depth = 10
        Me.txtmartial.ShadowDecoration.Enabled = True
        Me.txtmartial.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.txtmartial.Size = New System.Drawing.Size(175, 30)
        Me.txtmartial.TabIndex = 74
        Me.txtmartial.TextOffset = New System.Drawing.Point(2, -1)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(18, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Address"
        '
        'txtaddress
        '
        Me.txtaddress.Animated = True
        Me.txtaddress.AutoRoundedCorners = True
        Me.txtaddress.BackColor = System.Drawing.Color.Transparent
        Me.txtaddress.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtaddress.BorderRadius = 14
        Me.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtaddress.DefaultText = ""
        Me.txtaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtaddress.Enabled = False
        Me.txtaddress.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtaddress.FocusedState.BorderColor = System.Drawing.Color.White
        Me.txtaddress.Font = New System.Drawing.Font("Segoe UI", 9.2!)
        Me.txtaddress.ForeColor = System.Drawing.Color.Black
        Me.txtaddress.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtaddress.IconLeftSize = New System.Drawing.Size(0, 0)
        Me.txtaddress.IconRightSize = New System.Drawing.Size(18, 18)
        Me.txtaddress.Location = New System.Drawing.Point(18, 246)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaddress.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtaddress.PlaceholderText = "Address"
        Me.txtaddress.SelectedText = ""
        Me.txtaddress.ShadowDecoration.BorderRadius = 10
        Me.txtaddress.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtaddress.ShadowDecoration.Depth = 10
        Me.txtaddress.ShadowDecoration.Enabled = True
        Me.txtaddress.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.txtaddress.Size = New System.Drawing.Size(466, 30)
        Me.txtaddress.TabIndex = 73
        Me.txtaddress.TextOffset = New System.Drawing.Point(2, -1)
        '
        'dtpbirth
        '
        Me.dtpbirth.Animated = True
        Me.dtpbirth.BackColor = System.Drawing.Color.Transparent
        Me.dtpbirth.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.dtpbirth.BorderRadius = 14
        Me.dtpbirth.BorderThickness = 1
        Me.dtpbirth.Checked = True
        Me.dtpbirth.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtpbirth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpbirth.Enabled = False
        Me.dtpbirth.FillColor = System.Drawing.Color.White
        Me.dtpbirth.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpbirth.ForeColor = System.Drawing.Color.Black
        Me.dtpbirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpbirth.HoverState.FillColor = System.Drawing.Color.Silver
        Me.dtpbirth.HoverState.ForeColor = System.Drawing.Color.Black
        Me.dtpbirth.Location = New System.Drawing.Point(18, 194)
        Me.dtpbirth.MaxDate = New Date(2022, 1, 1, 0, 0, 0, 0)
        Me.dtpbirth.MinDate = New Date(1800, 1, 1, 0, 0, 0, 0)
        Me.dtpbirth.Name = "dtpbirth"
        Me.dtpbirth.ShadowDecoration.BorderRadius = 10
        Me.dtpbirth.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.dtpbirth.ShadowDecoration.Depth = 10
        Me.dtpbirth.ShadowDecoration.Enabled = True
        Me.dtpbirth.Size = New System.Drawing.Size(212, 30)
        Me.dtpbirth.TabIndex = 72
        Me.dtpbirth.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(17, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 15)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Birth Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(17, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Name"
        '
        'txtmi
        '
        Me.txtmi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtmi.Animated = True
        Me.txtmi.AutoRoundedCorners = True
        Me.txtmi.BackColor = System.Drawing.Color.Transparent
        Me.txtmi.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtmi.BorderRadius = 14
        Me.txtmi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmi.DefaultText = ""
        Me.txtmi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtmi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtmi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmi.Enabled = False
        Me.txtmi.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtmi.FocusedState.BorderColor = System.Drawing.Color.White
        Me.txtmi.Font = New System.Drawing.Font("Segoe UI", 9.2!)
        Me.txtmi.ForeColor = System.Drawing.Color.Black
        Me.txtmi.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtmi.IconLeftSize = New System.Drawing.Size(0, 0)
        Me.txtmi.IconRightSize = New System.Drawing.Size(18, 18)
        Me.txtmi.Location = New System.Drawing.Point(446, 89)
        Me.txtmi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmi.Name = "txtmi"
        Me.txtmi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmi.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtmi.PlaceholderText = "MI"
        Me.txtmi.SelectedText = ""
        Me.txtmi.ShadowDecoration.BorderRadius = 10
        Me.txtmi.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtmi.ShadowDecoration.Depth = 10
        Me.txtmi.ShadowDecoration.Enabled = True
        Me.txtmi.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.txtmi.Size = New System.Drawing.Size(104, 30)
        Me.txtmi.TabIndex = 70
        Me.txtmi.TextOffset = New System.Drawing.Point(2, -1)
        '
        'txtfirstname
        '
        Me.txtfirstname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtfirstname.Animated = True
        Me.txtfirstname.AutoRoundedCorners = True
        Me.txtfirstname.BackColor = System.Drawing.Color.Transparent
        Me.txtfirstname.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtfirstname.BorderRadius = 14
        Me.txtfirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfirstname.DefaultText = ""
        Me.txtfirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtfirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtfirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfirstname.Enabled = False
        Me.txtfirstname.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtfirstname.FocusedState.BorderColor = System.Drawing.Color.White
        Me.txtfirstname.Font = New System.Drawing.Font("Segoe UI", 9.2!)
        Me.txtfirstname.ForeColor = System.Drawing.Color.Black
        Me.txtfirstname.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtfirstname.IconLeftSize = New System.Drawing.Size(0, 0)
        Me.txtfirstname.IconRightSize = New System.Drawing.Size(18, 18)
        Me.txtfirstname.Location = New System.Drawing.Point(231, 89)
        Me.txtfirstname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfirstname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtfirstname.PlaceholderText = "Firstname"
        Me.txtfirstname.SelectedText = ""
        Me.txtfirstname.ShadowDecoration.BorderRadius = 10
        Me.txtfirstname.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtfirstname.ShadowDecoration.Depth = 10
        Me.txtfirstname.ShadowDecoration.Enabled = True
        Me.txtfirstname.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.txtfirstname.Size = New System.Drawing.Size(212, 30)
        Me.txtfirstname.TabIndex = 69
        Me.txtfirstname.TextOffset = New System.Drawing.Point(2, -1)
        '
        'txtlastname
        '
        Me.txtlastname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtlastname.Animated = True
        Me.txtlastname.AutoRoundedCorners = True
        Me.txtlastname.BackColor = System.Drawing.Color.Transparent
        Me.txtlastname.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtlastname.BorderRadius = 14
        Me.txtlastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlastname.DefaultText = ""
        Me.txtlastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtlastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtlastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlastname.Enabled = False
        Me.txtlastname.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtlastname.FocusedState.BorderColor = System.Drawing.Color.White
        Me.txtlastname.Font = New System.Drawing.Font("Segoe UI", 9.2!)
        Me.txtlastname.ForeColor = System.Drawing.Color.Black
        Me.txtlastname.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtlastname.IconLeftSize = New System.Drawing.Size(0, 0)
        Me.txtlastname.IconRightSize = New System.Drawing.Size(18, 18)
        Me.txtlastname.Location = New System.Drawing.Point(16, 89)
        Me.txtlastname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlastname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtlastname.PlaceholderText = "Lastname"
        Me.txtlastname.SelectedText = ""
        Me.txtlastname.ShadowDecoration.BorderRadius = 10
        Me.txtlastname.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtlastname.ShadowDecoration.Depth = 10
        Me.txtlastname.ShadowDecoration.Enabled = True
        Me.txtlastname.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.txtlastname.Size = New System.Drawing.Size(212, 30)
        Me.txtlastname.TabIndex = 68
        Me.txtlastname.TextOffset = New System.Drawing.Point(2, -1)
        '
        'btnsubmit
        '
        Me.btnsubmit.Animated = True
        Me.btnsubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnsubmit.BorderColor = System.Drawing.Color.Transparent
        Me.btnsubmit.BorderRadius = 5
        Me.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsubmit.FillColor = System.Drawing.Color.Lime
        Me.btnsubmit.FocusedColor = System.Drawing.Color.Transparent
        Me.btnsubmit.Font = New System.Drawing.Font("Segoe UI", 9.2!, System.Drawing.FontStyle.Bold)
        Me.btnsubmit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnsubmit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsubmit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsubmit.Location = New System.Drawing.Point(419, 403)
        Me.btnsubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.ShadowDecoration.BorderRadius = 5
        Me.btnsubmit.ShadowDecoration.Color = System.Drawing.Color.ForestGreen
        Me.btnsubmit.ShadowDecoration.Depth = 20
        Me.btnsubmit.ShadowDecoration.Enabled = True
        Me.btnsubmit.Size = New System.Drawing.Size(132, 30)
        Me.btnsubmit.TabIndex = 82
        Me.btnsubmit.Text = "Close"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Orange
        Me.Guna2Button1.FocusedColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.2!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button1.Location = New System.Drawing.Point(281, 403)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.BorderRadius = 5
        Me.Guna2Button1.ShadowDecoration.Color = System.Drawing.Color.ForestGreen
        Me.Guna2Button1.ShadowDecoration.Depth = 20
        Me.Guna2Button1.ShadowDecoration.Enabled = True
        Me.Guna2Button1.Size = New System.Drawing.Size(132, 30)
        Me.Guna2Button1.TabIndex = 83
        Me.Guna2Button1.Text = "Edit"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.AnimationInterval = 200
        Me.Guna2BorderlessForm1.BorderRadius = 10
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockForm = False
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragForm = False
        Me.Guna2BorderlessForm1.ShadowColor = System.Drawing.Color.DarkGreen
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'frm_editing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Birthing_Clinic_Patient_Records_System.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(567, 450)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbsex)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtmartial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.dtpbirth)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtmi)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.lblpatientid)
        Me.Controls.Add(Me.pnl_border)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_editing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Floresca Birthing Clinic Registration"
        Me.pnl_border.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnl_border As Panel
    Friend WithEvents btnminimize As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents lblpatientid As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbsex As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcontact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmartial As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtaddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpbirth As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtmi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtfirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtlastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnsubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
