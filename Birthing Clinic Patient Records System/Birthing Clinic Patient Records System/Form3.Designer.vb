<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmmain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmain))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_border = New System.Windows.Forms.Panel()
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.sc = New System.Windows.Forms.SplitContainer()
        Me.btnabout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnlogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnsetting = New Guna.UI2.WinForms.Guna2Button()
        Me.btnaccount = New Guna.UI2.WinForms.Guna2Button()
        Me.btncontrol = New Guna.UI2.WinForms.Guna2Button()
        Me.btnhelp = New Guna.UI2.WinForms.Guna2Button()
        Me.btncalendar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnnotifi = New Guna.UI2.WinForms.Guna2Button()
        Me.btnrecords = New Guna.UI2.WinForms.Guna2Button()
        Me.btnhome = New Guna.UI2.WinForms.Guna2Button()
        Me.pnl_records = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgv_records = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnslidepanel = New Guna.UI2.WinForms.Guna2Button()
        Me.pnl_home = New Guna.UI2.WinForms.Guna2Panel()
        Me.hr = New Guna.UI2.WinForms.Guna2Shapes()
        Me.pnl_title = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.pnl_border.SuspendLayout()
        CType(Me.sc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sc.Panel1.SuspendLayout()
        Me.sc.Panel2.SuspendLayout()
        Me.sc.SuspendLayout()
        Me.pnl_records.SuspendLayout()
        CType(Me.dgv_records, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_home.SuspendLayout()
        Me.pnl_title.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnl_border.Size = New System.Drawing.Size(800, 19)
        Me.pnl_border.TabIndex = 12
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
        Me.btnminimize.Location = New System.Drawing.Point(758, 0)
        Me.btnminimize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(19, 19)
        Me.btnminimize.TabIndex = 12
        Me.btnminimize.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.BackgroundImage = CType(resources.GetObject("btnclose.BackgroundImage"), System.Drawing.Image)
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Berlin Sans FB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.Black
        Me.btnclose.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnclose.Location = New System.Drawing.Point(779, 0)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(19, 19)
        Me.btnclose.TabIndex = 13
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'sc
        '
        Me.sc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sc.IsSplitterFixed = True
        Me.sc.Location = New System.Drawing.Point(0, 19)
        Me.sc.Name = "sc"
        '
        'sc.Panel1
        '
        Me.sc.Panel1.BackColor = System.Drawing.Color.Green
        Me.sc.Panel1.Controls.Add(Me.btnabout)
        Me.sc.Panel1.Controls.Add(Me.btnlogout)
        Me.sc.Panel1.Controls.Add(Me.btnsetting)
        Me.sc.Panel1.Controls.Add(Me.btnaccount)
        Me.sc.Panel1.Controls.Add(Me.btncontrol)
        Me.sc.Panel1.Controls.Add(Me.btnhelp)
        Me.sc.Panel1.Controls.Add(Me.btncalendar)
        Me.sc.Panel1.Controls.Add(Me.btnnotifi)
        Me.sc.Panel1.Controls.Add(Me.btnrecords)
        Me.sc.Panel1.Controls.Add(Me.btnhome)
        Me.sc.Panel1.Padding = New System.Windows.Forms.Padding(2)
        '
        'sc.Panel2
        '
        Me.sc.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sc.Panel2.Controls.Add(Me.pnl_records)
        Me.sc.Panel2.Controls.Add(Me.btnslidepanel)
        Me.sc.Panel2.Controls.Add(Me.pnl_home)
        Me.sc.Size = New System.Drawing.Size(800, 431)
        Me.sc.SplitterDistance = 120
        Me.sc.TabIndex = 13
        '
        'btnabout
        '
        Me.btnabout.BackColor = System.Drawing.Color.Transparent
        Me.btnabout.BorderColor = System.Drawing.Color.Transparent
        Me.btnabout.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnabout.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnabout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnabout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnabout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnabout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnabout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnabout.FillColor = System.Drawing.Color.Transparent
        Me.btnabout.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnabout.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnabout.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnabout.Location = New System.Drawing.Point(2, 328)
        Me.btnabout.Name = "btnabout"
        Me.btnabout.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnabout.ShadowDecoration.Depth = 0
        Me.btnabout.Size = New System.Drawing.Size(116, 31)
        Me.btnabout.TabIndex = 7
        Me.btnabout.Text = "About"
        '
        'btnlogout
        '
        Me.btnlogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnlogout.BackColor = System.Drawing.Color.Transparent
        Me.btnlogout.BorderColor = System.Drawing.Color.Transparent
        Me.btnlogout.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlogout.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnlogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnlogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnlogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnlogout.FillColor = System.Drawing.Color.Transparent
        Me.btnlogout.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnlogout.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnlogout.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlogout.Location = New System.Drawing.Point(2, 396)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlogout.ShadowDecoration.Depth = 0
        Me.btnlogout.Size = New System.Drawing.Size(116, 31)
        Me.btnlogout.TabIndex = 9
        Me.btnlogout.Text = "Logout"
        '
        'btnsetting
        '
        Me.btnsetting.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnsetting.BackColor = System.Drawing.Color.Transparent
        Me.btnsetting.BorderColor = System.Drawing.Color.Transparent
        Me.btnsetting.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsetting.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsetting.FillColor = System.Drawing.Color.Transparent
        Me.btnsetting.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnsetting.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnsetting.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsetting.Location = New System.Drawing.Point(2, 362)
        Me.btnsetting.Name = "btnsetting"
        Me.btnsetting.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsetting.ShadowDecoration.Depth = 0
        Me.btnsetting.Size = New System.Drawing.Size(116, 31)
        Me.btnsetting.TabIndex = 8
        Me.btnsetting.Text = "Setting"
        '
        'btnaccount
        '
        Me.btnaccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnaccount.BackColor = System.Drawing.Color.Transparent
        Me.btnaccount.BorderColor = System.Drawing.Color.Transparent
        Me.btnaccount.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnaccount.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnaccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnaccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnaccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnaccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnaccount.FillColor = System.Drawing.Color.Transparent
        Me.btnaccount.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnaccount.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnaccount.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnaccount.Location = New System.Drawing.Point(2, 294)
        Me.btnaccount.Name = "btnaccount"
        Me.btnaccount.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnaccount.ShadowDecoration.Depth = 0
        Me.btnaccount.Size = New System.Drawing.Size(116, 31)
        Me.btnaccount.TabIndex = 6
        Me.btnaccount.Text = "Account"
        '
        'btncontrol
        '
        Me.btncontrol.BackColor = System.Drawing.Color.Transparent
        Me.btncontrol.BorderColor = System.Drawing.Color.DarkGreen
        Me.btncontrol.BorderThickness = 1
        Me.btncontrol.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncontrol.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncontrol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncontrol.CustomizableEdges.TopLeft = False
        Me.btncontrol.CustomizableEdges.TopRight = False
        Me.btncontrol.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btncontrol.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btncontrol.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btncontrol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btncontrol.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncontrol.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btncontrol.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btncontrol.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncontrol.Location = New System.Drawing.Point(2, 157)
        Me.btncontrol.Name = "btncontrol"
        Me.btncontrol.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncontrol.ShadowDecoration.Depth = 0
        Me.btncontrol.Size = New System.Drawing.Size(116, 31)
        Me.btncontrol.TabIndex = 5
        Me.btncontrol.Text = "Account Control"
        '
        'btnhelp
        '
        Me.btnhelp.BackColor = System.Drawing.Color.Transparent
        Me.btnhelp.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnhelp.BorderThickness = 1
        Me.btnhelp.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhelp.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhelp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnhelp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnhelp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnhelp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnhelp.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhelp.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnhelp.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnhelp.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhelp.Location = New System.Drawing.Point(2, 126)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhelp.ShadowDecoration.Depth = 0
        Me.btnhelp.Size = New System.Drawing.Size(116, 31)
        Me.btnhelp.TabIndex = 4
        Me.btnhelp.Text = "Help and Tips"
        '
        'btncalendar
        '
        Me.btncalendar.BackColor = System.Drawing.Color.Transparent
        Me.btncalendar.BorderColor = System.Drawing.Color.DarkGreen
        Me.btncalendar.BorderThickness = 1
        Me.btncalendar.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncalendar.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncalendar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncalendar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btncalendar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btncalendar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btncalendar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btncalendar.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncalendar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btncalendar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btncalendar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncalendar.Location = New System.Drawing.Point(2, 95)
        Me.btncalendar.Name = "btncalendar"
        Me.btncalendar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncalendar.ShadowDecoration.Depth = 0
        Me.btncalendar.Size = New System.Drawing.Size(116, 31)
        Me.btncalendar.TabIndex = 3
        Me.btncalendar.Text = "Calendar"
        '
        'btnnotifi
        '
        Me.btnnotifi.BackColor = System.Drawing.Color.Transparent
        Me.btnnotifi.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnnotifi.BorderThickness = 1
        Me.btnnotifi.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnnotifi.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnnotifi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnotifi.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnnotifi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnnotifi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnnotifi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnnotifi.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnnotifi.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnnotifi.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnnotifi.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnnotifi.Location = New System.Drawing.Point(2, 64)
        Me.btnnotifi.Name = "btnnotifi"
        Me.btnnotifi.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnnotifi.ShadowDecoration.Depth = 0
        Me.btnnotifi.Size = New System.Drawing.Size(116, 31)
        Me.btnnotifi.TabIndex = 2
        Me.btnnotifi.Text = "Notification"
        '
        'btnrecords
        '
        Me.btnrecords.BackColor = System.Drawing.Color.Transparent
        Me.btnrecords.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnrecords.BorderThickness = 1
        Me.btnrecords.Checked = True
        Me.btnrecords.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnrecords.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnrecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrecords.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnrecords.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnrecords.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnrecords.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnrecords.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnrecords.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnrecords.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnrecords.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnrecords.ImageOffset = New System.Drawing.Point(1, 0)
        Me.btnrecords.Location = New System.Drawing.Point(2, 33)
        Me.btnrecords.Name = "btnrecords"
        Me.btnrecords.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnrecords.ShadowDecoration.Depth = 0
        Me.btnrecords.Size = New System.Drawing.Size(116, 31)
        Me.btnrecords.TabIndex = 1
        Me.btnrecords.Text = "Patients' Records"
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.Transparent
        Me.btnhome.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnhome.BorderThickness = 1
        Me.btnhome.Checked = True
        Me.btnhome.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhome.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhome.CustomizableEdges.BottomLeft = False
        Me.btnhome.CustomizableEdges.BottomRight = False
        Me.btnhome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnhome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnhome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnhome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnhome.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhome.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnhome.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnhome.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhome.Location = New System.Drawing.Point(2, 2)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhome.ShadowDecoration.Depth = 0
        Me.btnhome.Size = New System.Drawing.Size(116, 31)
        Me.btnhome.TabIndex = 0
        Me.btnhome.Text = "Home"
        '
        'pnl_records
        '
        Me.pnl_records.Controls.Add(Me.dgv_records)
        Me.pnl_records.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_records.Enabled = False
        Me.pnl_records.Location = New System.Drawing.Point(0, 0)
        Me.pnl_records.Name = "pnl_records"
        Me.pnl_records.Size = New System.Drawing.Size(676, 431)
        Me.pnl_records.TabIndex = 29
        Me.pnl_records.Visible = False
        '
        'dgv_records
        '
        Me.dgv_records.AllowUserToAddRows = False
        Me.dgv_records.AllowUserToDeleteRows = False
        Me.dgv_records.AllowUserToResizeColumns = False
        Me.dgv_records.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_records.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_records.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        Me.dgv_records.BackgroundColor = System.Drawing.Color.DarkGreen
        Me.dgv_records.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_records.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_records.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_records.ColumnHeadersHeight = 30
        Me.dgv_records.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_records.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_records.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgv_records.Location = New System.Drawing.Point(3, 2)
        Me.dgv_records.Name = "dgv_records"
        Me.dgv_records.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_records.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_records.RowHeadersVisible = False
        Me.dgv_records.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_records.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_records.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Green
        Me.dgv_records.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_records.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_records.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgv_records.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgv_records.RowTemplate.ReadOnly = True
        Me.dgv_records.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_records.Size = New System.Drawing.Size(670, 426)
        Me.dgv_records.TabIndex = 2
        Me.dgv_records.TabStop = False
        Me.dgv_records.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_records.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_records.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_records.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_records.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv_records.ThemeStyle.BackColor = System.Drawing.Color.DarkGreen
        Me.dgv_records.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgv_records.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_records.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgv_records.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_records.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_records.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_records.ThemeStyle.HeaderStyle.Height = 30
        Me.dgv_records.ThemeStyle.ReadOnly = True
        Me.dgv_records.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_records.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_records.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_records.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv_records.ThemeStyle.RowsStyle.Height = 22
        Me.dgv_records.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_records.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.HeaderText = "Patient ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 166
        '
        'Column2
        '
        Me.Column2.HeaderText = "Lastname"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 167
        '
        'Column3
        '
        Me.Column3.HeaderText = "Firstname"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 168
        '
        'Column4
        '
        Me.Column4.HeaderText = "MI"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 167
        '
        'btnslidepanel
        '
        Me.btnslidepanel.Animated = True
        Me.btnslidepanel.BackColor = System.Drawing.Color.Transparent
        Me.btnslidepanel.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnslidepanel.BorderRadius = 10
        Me.btnslidepanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnslidepanel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnslidepanel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnslidepanel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnslidepanel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnslidepanel.FillColor = System.Drawing.Color.DarkGreen
        Me.btnslidepanel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnslidepanel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnslidepanel.HoverState.FillColor = System.Drawing.Color.DarkGreen
        Me.btnslidepanel.Image = Global.Birthing_Clinic_Patient_Records_System.My.Resources.Resources.iconslidehide
        Me.btnslidepanel.ImageOffset = New System.Drawing.Point(7, 0)
        Me.btnslidepanel.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnslidepanel.Location = New System.Drawing.Point(-31, 1)
        Me.btnslidepanel.Name = "btnslidepanel"
        Me.btnslidepanel.ShadowDecoration.BorderRadius = 10
        Me.btnslidepanel.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnslidepanel.ShadowDecoration.Enabled = True
        Me.btnslidepanel.Size = New System.Drawing.Size(51, 35)
        Me.btnslidepanel.TabIndex = 21
        '
        'pnl_home
        '
        Me.pnl_home.Controls.Add(Me.hr)
        Me.pnl_home.Controls.Add(Me.pnl_title)
        Me.pnl_home.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_home.Location = New System.Drawing.Point(0, 0)
        Me.pnl_home.Name = "pnl_home"
        Me.pnl_home.Size = New System.Drawing.Size(676, 431)
        Me.pnl_home.TabIndex = 29
        '
        'hr
        '
        Me.hr.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hr.BorderColor = System.Drawing.Color.Gray
        Me.hr.FillColor = System.Drawing.Color.DimGray
        Me.hr.LineEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.hr.LineThickness = 2
        Me.hr.Location = New System.Drawing.Point(11, 160)
        Me.hr.Name = "hr"
        Me.hr.PolygonSides = 2
        Me.hr.PolygonSkip = 1
        Me.hr.Rotate = 0!
        Me.hr.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line
        Me.hr.Size = New System.Drawing.Size(650, 3)
        Me.hr.TabIndex = 28
        Me.hr.Text = "Guna2Shapes1"
        Me.hr.Zoom = 100
        '
        'pnl_title
        '
        Me.pnl_title.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.pnl_title.Controls.Add(Me.Label4)
        Me.pnl_title.Controls.Add(Me.Label1)
        Me.pnl_title.Controls.Add(Me.Label2)
        Me.pnl_title.Controls.Add(Me.PictureBox1)
        Me.pnl_title.FillColor = System.Drawing.Color.WhiteSmoke
        Me.pnl_title.Location = New System.Drawing.Point(84, 21)
        Me.pnl_title.Name = "pnl_title"
        Me.pnl_title.Size = New System.Drawing.Size(487, 121)
        Me.pnl_title.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AllowDrop = True
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(123, 43)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 32)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "BIRTHING CLINIC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(122, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 41)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "FLORESCA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(126, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(357, 40)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Block 91 Lot 92 Barangay Cristo Rey Capas, Tarlac" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contact Nos: 0920-977-1152/091" &
    "8-920-3276"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Birthing_Clinic_Patient_Records_System.My.Resources.Resources.gray_picture
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Global.Birthing_Clinic_Patient_Records_System.My.Resources.Resources.gray_picture
        Me.PictureBox1.Location = New System.Drawing.Point(9, 9)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 105)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.BorderRadius = 10
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragForm = False
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.ShadowColor = System.Drawing.Color.DarkGreen
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImage = Global.Birthing_Clinic_Patient_Records_System.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.sc)
        Me.Controls.Add(Me.pnl_border)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Floresca Birthing Clinic"
        Me.pnl_border.ResumeLayout(False)
        Me.sc.Panel1.ResumeLayout(False)
        Me.sc.Panel2.ResumeLayout(False)
        CType(Me.sc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sc.ResumeLayout(False)
        Me.pnl_records.ResumeLayout(False)
        CType(Me.dgv_records, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_home.ResumeLayout(False)
        Me.pnl_title.ResumeLayout(False)
        Me.pnl_title.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_border As Panel
    Friend WithEvents btnminimize As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents sc As SplitContainer
    Friend WithEvents btnslidepanel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnaccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btncontrol As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnhelp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btncalendar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnnotifi As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnrecords As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnhome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnlogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnsetting As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnabout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pnl_title As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents hr As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents pnl_home As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnl_records As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgv_records As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
