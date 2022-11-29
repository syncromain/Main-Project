<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.pnl_border = New System.Windows.Forms.Panel()
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnlogin = New Guna.UI2.WinForms.Guna2Button()
        Me.txtpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtusername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblcreate = New System.Windows.Forms.Label()
        Me.lblforgot = New System.Windows.Forms.Label()
        Me.pnl_navbutton = New System.Windows.Forms.Panel()
        Me.btncontact = New Guna.UI2.WinForms.Guna2Button()
        Me.btnabout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnlog = New Guna.UI2.WinForms.Guna2Button()
        Me.btnterms = New Guna.UI2.WinForms.Guna2Button()
        Me.btnhelp = New Guna.UI2.WinForms.Guna2Button()
        Me.lbltitle3 = New System.Windows.Forms.Label()
        Me.lbltitle2 = New System.Windows.Forms.Label()
        Me.lbltitle1 = New System.Windows.Forms.Label()
        Me.pblogo = New System.Windows.Forms.PictureBox()
        Me.pnl_login = New System.Windows.Forms.Panel()
        Me.lblRemember = New System.Windows.Forms.Label()
        Me.tgremember = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.lblwarning = New System.Windows.Forms.Label()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.lblcontact1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnl_contact = New System.Windows.Forms.Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblemail1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnl_terms = New System.Windows.Forms.Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pnl_help = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnl_about = New System.Windows.Forms.Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnl_border.SuspendLayout()
        Me.pnl_navbutton.SuspendLayout()
        CType(Me.pblogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_login.SuspendLayout()
        Me.pnl_contact.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.pnl_terms.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.pnl_help.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.pnl_about.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
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
        Me.pnl_border.Size = New System.Drawing.Size(564, 19)
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
        'btnlogin
        '
        Me.btnlogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnlogin.Animated = True
        Me.btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.btnlogin.BorderColor = System.Drawing.Color.Transparent
        Me.btnlogin.BorderRadius = 5
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnlogin.FillColor = System.Drawing.Color.Lime
        Me.btnlogin.FocusedColor = System.Drawing.Color.Transparent
        Me.btnlogin.Font = New System.Drawing.Font("Segoe UI", 9.2!, System.Drawing.FontStyle.Bold)
        Me.btnlogin.ForeColor = System.Drawing.Color.DimGray
        Me.btnlogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlogin.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlogin.Location = New System.Drawing.Point(85, 164)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.ShadowDecoration.BorderRadius = 5
        Me.btnlogin.ShadowDecoration.Color = System.Drawing.Color.ForestGreen
        Me.btnlogin.ShadowDecoration.Depth = 20
        Me.btnlogin.ShadowDecoration.Enabled = True
        Me.btnlogin.Size = New System.Drawing.Size(166, 30)
        Me.btnlogin.TabIndex = 4
        Me.btnlogin.Text = "Login"
        '
        'txtpassword
        '
        Me.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtpassword.Animated = True
        Me.txtpassword.AutoRoundedCorners = True
        Me.txtpassword.BackColor = System.Drawing.Color.Transparent
        Me.txtpassword.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtpassword.BorderRadius = 14
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.DefaultText = ""
        Me.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassword.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtpassword.FocusedState.BorderColor = System.Drawing.Color.White
        Me.txtpassword.Font = New System.Drawing.Font("Segoe UI", 9.2!)
        Me.txtpassword.ForeColor = System.Drawing.Color.Black
        Me.txtpassword.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtpassword.IconLeft = CType(resources.GetObject("txtpassword.IconLeft"), System.Drawing.Image)
        Me.txtpassword.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtpassword.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtpassword.IconRight = CType(resources.GetObject("txtpassword.IconRight"), System.Drawing.Image)
        Me.txtpassword.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtpassword.IconRightSize = New System.Drawing.Size(18, 18)
        Me.txtpassword.Location = New System.Drawing.Point(22, 100)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtpassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtpassword.PlaceholderText = "Password"
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.ShadowDecoration.BorderRadius = 5
        Me.txtpassword.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtpassword.ShadowDecoration.Enabled = True
        Me.txtpassword.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.txtpassword.Size = New System.Drawing.Size(293, 30)
        Me.txtpassword.TabIndex = 1
        Me.txtpassword.TextOffset = New System.Drawing.Point(5, 0)
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtusername
        '
        Me.txtusername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtusername.Animated = True
        Me.txtusername.AutoRoundedCorners = True
        Me.txtusername.BackColor = System.Drawing.Color.Transparent
        Me.txtusername.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtusername.BorderRadius = 14
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.DefaultText = ""
        Me.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtusername.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtusername.FocusedState.BorderColor = System.Drawing.Color.White
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI", 9.2!)
        Me.txtusername.ForeColor = System.Drawing.Color.Black
        Me.txtusername.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtusername.IconLeft = CType(resources.GetObject("txtusername.IconLeft"), System.Drawing.Image)
        Me.txtusername.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtusername.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtusername.IconRightSize = New System.Drawing.Size(18, 18)
        Me.txtusername.Location = New System.Drawing.Point(22, 65)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtusername.PlaceholderText = "Username"
        Me.txtusername.SelectedText = ""
        Me.txtusername.ShadowDecoration.BorderRadius = 5
        Me.txtusername.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtusername.ShadowDecoration.Enabled = True
        Me.txtusername.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.txtusername.Size = New System.Drawing.Size(293, 30)
        Me.txtusername.TabIndex = 0
        Me.txtusername.TextOffset = New System.Drawing.Point(5, 0)
        '
        'lblcreate
        '
        Me.lblcreate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblcreate.AutoSize = True
        Me.lblcreate.BackColor = System.Drawing.Color.Transparent
        Me.lblcreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblcreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblcreate.Font = New System.Drawing.Font("Segoe UI", 9.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcreate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblcreate.Location = New System.Drawing.Point(105, 199)
        Me.lblcreate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcreate.Name = "lblcreate"
        Me.lblcreate.Size = New System.Drawing.Size(126, 17)
        Me.lblcreate.TabIndex = 5
        Me.lblcreate.Text = "Create New Account"
        '
        'lblforgot
        '
        Me.lblforgot.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblforgot.AutoSize = True
        Me.lblforgot.BackColor = System.Drawing.Color.Transparent
        Me.lblforgot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblforgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblforgot.Font = New System.Drawing.Font("Segoe UI", 9.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblforgot.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblforgot.Location = New System.Drawing.Point(218, 134)
        Me.lblforgot.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblforgot.Name = "lblforgot"
        Me.lblforgot.Size = New System.Drawing.Size(113, 17)
        Me.lblforgot.TabIndex = 3
        Me.lblforgot.Text = "Forgot Password?"
        '
        'pnl_navbutton
        '
        Me.pnl_navbutton.BackColor = System.Drawing.Color.Transparent
        Me.pnl_navbutton.Controls.Add(Me.btncontact)
        Me.pnl_navbutton.Controls.Add(Me.btnabout)
        Me.pnl_navbutton.Controls.Add(Me.btnlog)
        Me.pnl_navbutton.Controls.Add(Me.btnterms)
        Me.pnl_navbutton.Controls.Add(Me.btnhelp)
        Me.pnl_navbutton.Location = New System.Drawing.Point(10, 403)
        Me.pnl_navbutton.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_navbutton.Name = "pnl_navbutton"
        Me.pnl_navbutton.Size = New System.Drawing.Size(542, 33)
        Me.pnl_navbutton.TabIndex = 7
        '
        'btncontact
        '
        Me.btncontact.BackColor = System.Drawing.Color.Transparent
        Me.btncontact.BorderColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncontact.BorderRadius = 15
        Me.btncontact.BorderThickness = 1
        Me.btncontact.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncontact.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncontact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncontact.CustomizableEdges.BottomLeft = False
        Me.btncontact.CustomizableEdges.BottomRight = False
        Me.btncontact.CustomizableEdges.TopLeft = False
        Me.btncontact.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btncontact.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btncontact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btncontact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btncontact.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncontact.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btncontact.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btncontact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncontact.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncontact.Location = New System.Drawing.Point(433, 2)
        Me.btncontact.Name = "btncontact"
        Me.btncontact.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncontact.ShadowDecoration.Depth = 10
        Me.btncontact.ShadowDecoration.Enabled = True
        Me.btncontact.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1)
        Me.btncontact.Size = New System.Drawing.Size(106, 29)
        Me.btncontact.TabIndex = 10
        Me.btncontact.Text = "Contact"
        '
        'btnabout
        '
        Me.btnabout.BackColor = System.Drawing.Color.Transparent
        Me.btnabout.BorderColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnabout.BorderRadius = 15
        Me.btnabout.BorderThickness = 1
        Me.btnabout.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnabout.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnabout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnabout.CustomizableEdges.BottomLeft = False
        Me.btnabout.CustomizableEdges.BottomRight = False
        Me.btnabout.CustomizableEdges.TopLeft = False
        Me.btnabout.CustomizableEdges.TopRight = False
        Me.btnabout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnabout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnabout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnabout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnabout.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnabout.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnabout.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnabout.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnabout.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnabout.Location = New System.Drawing.Point(325, 2)
        Me.btnabout.Name = "btnabout"
        Me.btnabout.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnabout.ShadowDecoration.Depth = 10
        Me.btnabout.ShadowDecoration.Enabled = True
        Me.btnabout.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1)
        Me.btnabout.Size = New System.Drawing.Size(106, 29)
        Me.btnabout.TabIndex = 9
        Me.btnabout.Text = "About"
        '
        'btnlog
        '
        Me.btnlog.BackColor = System.Drawing.Color.Transparent
        Me.btnlog.BorderColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlog.BorderRadius = 15
        Me.btnlog.BorderThickness = 1
        Me.btnlog.Checked = True
        Me.btnlog.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlog.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlog.CustomizableEdges.BottomLeft = False
        Me.btnlog.CustomizableEdges.BottomRight = False
        Me.btnlog.CustomizableEdges.TopLeft = False
        Me.btnlog.CustomizableEdges.TopRight = False
        Me.btnlog.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnlog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnlog.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnlog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnlog.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlog.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnlog.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnlog.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlog.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlog.Location = New System.Drawing.Point(218, 0)
        Me.btnlog.Name = "btnlog"
        Me.btnlog.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlog.ShadowDecoration.Depth = 10
        Me.btnlog.ShadowDecoration.Enabled = True
        Me.btnlog.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1)
        Me.btnlog.Size = New System.Drawing.Size(106, 31)
        Me.btnlog.TabIndex = 8
        Me.btnlog.Text = "Login"
        '
        'btnterms
        '
        Me.btnterms.BackColor = System.Drawing.Color.Transparent
        Me.btnterms.BorderColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnterms.BorderRadius = 15
        Me.btnterms.BorderThickness = 1
        Me.btnterms.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnterms.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnterms.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnterms.CustomizableEdges.BottomLeft = False
        Me.btnterms.CustomizableEdges.BottomRight = False
        Me.btnterms.CustomizableEdges.TopLeft = False
        Me.btnterms.CustomizableEdges.TopRight = False
        Me.btnterms.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnterms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnterms.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnterms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnterms.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnterms.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnterms.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnterms.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnterms.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnterms.Location = New System.Drawing.Point(111, 2)
        Me.btnterms.Name = "btnterms"
        Me.btnterms.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnterms.ShadowDecoration.Depth = 10
        Me.btnterms.ShadowDecoration.Enabled = True
        Me.btnterms.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1)
        Me.btnterms.Size = New System.Drawing.Size(106, 29)
        Me.btnterms.TabIndex = 7
        Me.btnterms.Text = "Terms"
        '
        'btnhelp
        '
        Me.btnhelp.BackColor = System.Drawing.Color.Transparent
        Me.btnhelp.BorderColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhelp.BorderRadius = 15
        Me.btnhelp.BorderThickness = 1
        Me.btnhelp.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhelp.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhelp.CustomizableEdges.BottomLeft = False
        Me.btnhelp.CustomizableEdges.BottomRight = False
        Me.btnhelp.CustomizableEdges.TopRight = False
        Me.btnhelp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnhelp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnhelp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnhelp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnhelp.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhelp.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnhelp.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnhelp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhelp.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhelp.Location = New System.Drawing.Point(4, 2)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhelp.ShadowDecoration.Depth = 10
        Me.btnhelp.ShadowDecoration.Enabled = True
        Me.btnhelp.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1)
        Me.btnhelp.Size = New System.Drawing.Size(106, 29)
        Me.btnhelp.TabIndex = 6
        Me.btnhelp.Text = "Help and Tips"
        '
        'lbltitle3
        '
        Me.lbltitle3.AutoSize = True
        Me.lbltitle3.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbltitle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbltitle3.Location = New System.Drawing.Point(152, 92)
        Me.lbltitle3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltitle3.Name = "lbltitle3"
        Me.lbltitle3.Size = New System.Drawing.Size(357, 20)
        Me.lbltitle3.TabIndex = 14
        Me.lbltitle3.Text = "Block 91 Lot 92 Barangay Cristo Rey Capas, Tarlac"
        '
        'lbltitle2
        '
        Me.lbltitle2.AllowDrop = True
        Me.lbltitle2.AutoSize = True
        Me.lbltitle2.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle2.ForeColor = System.Drawing.Color.Lime
        Me.lbltitle2.Location = New System.Drawing.Point(149, 61)
        Me.lbltitle2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltitle2.Name = "lbltitle2"
        Me.lbltitle2.Size = New System.Drawing.Size(213, 32)
        Me.lbltitle2.TabIndex = 13
        Me.lbltitle2.Text = "BIRTHING CLINIC"
        '
        'lbltitle1
        '
        Me.lbltitle1.AutoSize = True
        Me.lbltitle1.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle1.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbltitle1.Location = New System.Drawing.Point(148, 24)
        Me.lbltitle1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltitle1.Name = "lbltitle1"
        Me.lbltitle1.Size = New System.Drawing.Size(164, 41)
        Me.lbltitle1.TabIndex = 12
        Me.lbltitle1.Text = "FLORESCA"
        '
        'pblogo
        '
        Me.pblogo.BackColor = System.Drawing.Color.Transparent
        Me.pblogo.BackgroundImage = Global.Birthing_Clinic_Patient_Records_System.My.Resources.Resources.yellowgreen_picture
        Me.pblogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pblogo.Location = New System.Drawing.Point(48, 27)
        Me.pblogo.Margin = New System.Windows.Forms.Padding(2)
        Me.pblogo.Name = "pblogo"
        Me.pblogo.Size = New System.Drawing.Size(96, 84)
        Me.pblogo.TabIndex = 7
        Me.pblogo.TabStop = False
        '
        'pnl_login
        '
        Me.pnl_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnl_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnl_login.Controls.Add(Me.lblRemember)
        Me.pnl_login.Controls.Add(Me.tgremember)
        Me.pnl_login.Controls.Add(Me.btnlogin)
        Me.pnl_login.Controls.Add(Me.txtpassword)
        Me.pnl_login.Controls.Add(Me.txtusername)
        Me.pnl_login.Controls.Add(Me.lblcreate)
        Me.pnl_login.Controls.Add(Me.lblwarning)
        Me.pnl_login.Controls.Add(Me.lblforgot)
        Me.pnl_login.Location = New System.Drawing.Point(118, 139)
        Me.pnl_login.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_login.Name = "pnl_login"
        Me.pnl_login.Size = New System.Drawing.Size(336, 247)
        Me.pnl_login.TabIndex = 0
        '
        'lblRemember
        '
        Me.lblRemember.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRemember.AutoSize = True
        Me.lblRemember.BackColor = System.Drawing.Color.Transparent
        Me.lblRemember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRemember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRemember.Font = New System.Drawing.Font("Segoe UI", 9.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemember.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblRemember.Location = New System.Drawing.Point(59, 134)
        Me.lblRemember.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRemember.Name = "lblRemember"
        Me.lblRemember.Size = New System.Drawing.Size(95, 17)
        Me.lblRemember.TabIndex = 2
        Me.lblRemember.Text = "Remember Me"
        '
        'tgremember
        '
        Me.tgremember.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tgremember.Animated = True
        Me.tgremember.BackColor = System.Drawing.Color.Transparent
        Me.tgremember.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tgremember.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tgremember.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.tgremember.CheckedState.InnerColor = System.Drawing.Color.White
        Me.tgremember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tgremember.Location = New System.Drawing.Point(24, 134)
        Me.tgremember.Name = "tgremember"
        Me.tgremember.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tgremember.Size = New System.Drawing.Size(35, 20)
        Me.tgremember.TabIndex = 7
        Me.tgremember.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.tgremember.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.tgremember.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.tgremember.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'lblwarning
        '
        Me.lblwarning.AutoEllipsis = True
        Me.lblwarning.BackColor = System.Drawing.Color.Transparent
        Me.lblwarning.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblwarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblwarning.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwarning.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblwarning.Location = New System.Drawing.Point(3, 7)
        Me.lblwarning.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblwarning.Name = "lblwarning"
        Me.lblwarning.Size = New System.Drawing.Size(331, 47)
        Me.lblwarning.TabIndex = 3
        Me.lblwarning.Text = "Please Sign....."
        Me.lblwarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.BorderRadius = 10
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragForm = False
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'lblcontact1
        '
        Me.lblcontact1.AutoSize = True
        Me.lblcontact1.BackColor = System.Drawing.Color.Transparent
        Me.lblcontact1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblcontact1.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblcontact1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblcontact1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontact1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblcontact1.Location = New System.Drawing.Point(0, 19)
        Me.lblcontact1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcontact1.Name = "lblcontact1"
        Me.lblcontact1.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.lblcontact1.Size = New System.Drawing.Size(30, 19)
        Me.lblcontact1.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(35, 26)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Contact Us"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Contact No:"
        '
        'pnl_contact
        '
        Me.pnl_contact.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnl_contact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnl_contact.Controls.Add(Me.Guna2Panel2)
        Me.pnl_contact.Controls.Add(Me.Guna2Panel1)
        Me.pnl_contact.Controls.Add(Me.Label7)
        Me.pnl_contact.Enabled = False
        Me.pnl_contact.Location = New System.Drawing.Point(33, 127)
        Me.pnl_contact.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_contact.Name = "pnl_contact"
        Me.pnl_contact.Size = New System.Drawing.Size(492, 259)
        Me.pnl_contact.TabIndex = 7
        Me.pnl_contact.Visible = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.lblemail1)
        Me.Guna2Panel2.Controls.Add(Me.Label6)
        Me.Guna2Panel2.Location = New System.Drawing.Point(69, 149)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(339, 89)
        Me.Guna2Panel2.TabIndex = 10
        '
        'lblemail1
        '
        Me.lblemail1.AutoSize = True
        Me.lblemail1.BackColor = System.Drawing.Color.Transparent
        Me.lblemail1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblemail1.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblemail1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblemail1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblemail1.Location = New System.Drawing.Point(0, 19)
        Me.lblemail1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblemail1.Name = "lblemail1"
        Me.lblemail1.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.lblemail1.Size = New System.Drawing.Size(30, 19)
        Me.lblemail1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Email:"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.lblcontact1)
        Me.Guna2Panel1.Controls.Add(Me.Label8)
        Me.Guna2Panel1.Location = New System.Drawing.Point(69, 54)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(339, 89)
        Me.Guna2Panel1.TabIndex = 9
        '
        'pnl_terms
        '
        Me.pnl_terms.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnl_terms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnl_terms.Controls.Add(Me.Guna2Panel4)
        Me.pnl_terms.Controls.Add(Me.Label12)
        Me.pnl_terms.Enabled = False
        Me.pnl_terms.Location = New System.Drawing.Point(31, 129)
        Me.pnl_terms.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_terms.Name = "pnl_terms"
        Me.pnl_terms.Size = New System.Drawing.Size(492, 259)
        Me.pnl_terms.TabIndex = 11
        Me.pnl_terms.Visible = False
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Controls.Add(Me.Label11)
        Me.Guna2Panel4.Location = New System.Drawing.Point(42, 54)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(398, 182)
        Me.Guna2Panel4.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 19)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "(Terms)"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(210, 20)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 25)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Terms"
        '
        'pnl_help
        '
        Me.pnl_help.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnl_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnl_help.Controls.Add(Me.Label9)
        Me.pnl_help.Controls.Add(Me.Guna2Panel3)
        Me.pnl_help.Enabled = False
        Me.pnl_help.Location = New System.Drawing.Point(31, 31)
        Me.pnl_help.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_help.Name = "pnl_help"
        Me.pnl_help.Size = New System.Drawing.Size(492, 357)
        Me.pnl_help.TabIndex = 15
        Me.pnl_help.Visible = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(167, 21)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 25)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Helps and Tips"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.AutoScroll = True
        Me.Guna2Panel3.Controls.Add(Me.Label3)
        Me.Guna2Panel3.Location = New System.Drawing.Point(42, 65)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(398, 366)
        Me.Guna2Panel3.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "(Helps and Tips)"
        '
        'pnl_about
        '
        Me.pnl_about.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnl_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnl_about.Controls.Add(Me.Guna2Panel5)
        Me.pnl_about.Controls.Add(Me.Label2)
        Me.pnl_about.Enabled = False
        Me.pnl_about.Location = New System.Drawing.Point(29, 131)
        Me.pnl_about.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_about.Name = "pnl_about"
        Me.pnl_about.Size = New System.Drawing.Size(492, 259)
        Me.pnl_about.TabIndex = 12
        Me.pnl_about.Visible = False
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Controls.Add(Me.Label1)
        Me.Guna2Panel5.Location = New System.Drawing.Point(42, 54)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(398, 182)
        Me.Guna2Panel5.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "(About)"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(210, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "About"
        '
        'frmlogin
        '
        Me.AcceptButton = Me.btnlogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.Green
        Me.BackgroundImage = Global.Birthing_Clinic_Patient_Records_System.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(564, 437)
        Me.Controls.Add(Me.lbltitle3)
        Me.Controls.Add(Me.lbltitle2)
        Me.Controls.Add(Me.lbltitle1)
        Me.Controls.Add(Me.pblogo)
        Me.Controls.Add(Me.pnl_navbutton)
        Me.Controls.Add(Me.pnl_border)
        Me.Controls.Add(Me.pnl_login)
        Me.Controls.Add(Me.pnl_terms)
        Me.Controls.Add(Me.pnl_help)
        Me.Controls.Add(Me.pnl_about)
        Me.Controls.Add(Me.pnl_contact)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Floresca Birthing Clinic"
        Me.pnl_border.ResumeLayout(False)
        Me.pnl_navbutton.ResumeLayout(False)
        CType(Me.pblogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_login.ResumeLayout(False)
        Me.pnl_login.PerformLayout()
        Me.pnl_contact.ResumeLayout(False)
        Me.pnl_contact.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.pnl_terms.ResumeLayout(False)
        Me.pnl_terms.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.pnl_help.ResumeLayout(False)
        Me.pnl_help.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.pnl_about.ResumeLayout(False)
        Me.pnl_about.PerformLayout()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl_border As Panel
    Friend WithEvents btnclose As Button
    Friend WithEvents pnl_navbutton As Panel
    Friend WithEvents pblogo As PictureBox
    Friend WithEvents lbltitle3 As Label
    Friend WithEvents lbltitle2 As Label
    Friend WithEvents lbltitle1 As Label
    Friend WithEvents lblforgot As Label
    Friend WithEvents lblcreate As Label
    Friend WithEvents txtusername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnlogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnminimize As Button
    Friend WithEvents pnl_login As Panel
    Friend WithEvents btnhelp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnterms As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btncontact As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnabout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnlog As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents tgremember As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents lblRemember As Label
    Friend WithEvents pnl_contact As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblcontact1 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblemail1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pnl_terms As Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents pnl_help As Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents pnl_about As Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblwarning As Label
End Class
