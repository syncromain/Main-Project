Imports System.Windows.Media
Imports System.Data.OleDb
Imports System.Text
Imports System.Security.Cryptography
Imports System.Security.Policy
Imports System.Linq.Expressions
Imports Guna.UI2.WinForms

Public Class frmlogin
    Private Const SaltSize As Integer = 31
    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point

    Dim newFont As New Font("Segoe UI", 9.2, FontStyle.Underline)
    Dim newFont2 As New Font("Segoe UI", 9.2)
    Dim ByteHash() As Byte
    Dim ByteSourceText() As Byte
    Dim user As String
    Dim pwd As String
    Dim userLC As String
    Dim passLC As String
    Dim rSalt = CreateNewSalt(SaltSize)
    Dim Showpwd As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusername.PlaceholderText = "Username"
        txtpassword.PlaceholderText = "Password"
        If My.MySettings.Default.RememberMe = True Then
            txtusername.Text = My.MySettings.Default.Username
            txtpassword.Text = My.MySettings.Default.Password
            tgremember.Checked = My.MySettings.Default.RememberMe
        End If
    End Sub

    Private Sub reset_form()
        txtusername.Text = My.MySettings.Default.Username
        txtpassword.Text = My.MySettings.Default.Password
        tgremember.Checked = My.MySettings.Default.RememberMe
    End Sub

    Private Sub BorderPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles pnl_border.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Private Sub BorderPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles pnl_border.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub BorderPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles pnl_border.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        For disappear As Single = 1.0 To 0 Step -0.2
            Me.Opacity = disappear
            System.Threading.Thread.Sleep(50)
        Next
        Application.Exit()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        For disappear As Single = 1.0 To 0 Step -0.2
            Me.Opacity = disappear
            System.Threading.Thread.Sleep(50)
        Next
        Me.Opacity = 1.0
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Function mouse_hover(lbl As Label)
        lbl.Font = newFont
        lbl.ForeColor = System.Drawing.Color.Silver
        Return lbl
    End Function

    Private Function mouse_leave(lbl As Label)
        lbl.Font = newFont2
        lbl.ForeColor = System.Drawing.Color.WhiteSmoke
        Return lbl
    End Function

    Private Function mouse_up(lbl As Label)
        lbl.ForeColor = System.Drawing.Color.Silver
        Return lbl
    End Function

    Private Function mouse_down(lbl As Label)
        lbl.ForeColor = System.Drawing.Color.WhiteSmoke
        Return lbl
    End Function

    Private Sub lblforgot_MouseLeave(sender As Object, e As EventArgs) Handles lblforgot.MouseLeave
        mouse_leave(lblforgot)
    End Sub

    Private Sub lblremember_MouseLeave(sender As Object, e As EventArgs) Handles lblRemember.MouseLeave, tgremember.MouseLeave
        mouse_leave(lblRemember)
    End Sub

    Private Sub lblcreate_MouseLeave(sender As Object, e As EventArgs) Handles lblcreate.MouseLeave
        mouse_leave(lblcreate)
    End Sub

    Private Sub lblforgot_MouseHover(sender As Object, e As EventArgs) Handles lblforgot.MouseHover
        mouse_hover(lblforgot)
    End Sub

    Private Sub lblremember_MouseHover(sender As Object, e As EventArgs) Handles lblRemember.MouseHover, tgremember.MouseHover
        mouse_hover(lblRemember)
    End Sub

    Private Sub lblcreate_MouseHover(sender As Object, e As EventArgs) Handles lblcreate.MouseHover
        mouse_hover(lblcreate)
    End Sub


    Private Sub lblcreate_MouseUp(sender As Object, e As MouseEventArgs) Handles lblcreate.MouseUp
        mouse_up(lblcreate)
    End Sub

    Private Sub lblforgot_MouseUp(sender As Object, e As MouseEventArgs) Handles lblforgot.MouseUp
        mouse_up(lblforgot)
    End Sub

    Private Sub lblremember_MouseUp(sender As Object, e As MouseEventArgs) Handles lblRemember.MouseUp, tgremember.MouseUp
        mouse_up(lblRemember)
    End Sub

    Private Sub lblcreate_MouseDown(sender As Object, e As MouseEventArgs) Handles lblcreate.MouseDown
        mouse_down(lblcreate)
    End Sub

    Private Sub lblforgot_MouseDown(sender As Object, e As MouseEventArgs) Handles lblforgot.MouseDown
        mouse_down(lblforgot)
    End Sub

    Private Sub lblremember_MouseDown(sender As Object, e As MouseEventArgs) Handles lblRemember.MouseDown, tgremember.MouseDown
        mouse_down(lblRemember)
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        lblwarning.Text = ""
        If txtusername.Text = "" Then
            lblwarning.ForeColor = System.Drawing.Color.Red
            lblwarning.Text += "Please enter username." + Environment.NewLine
            txtusername.BorderColor = System.Drawing.Color.Red
            txtusername.BorderThickness = 2
        End If
        If txtpassword.Text = "" Then
            lblwarning.ForeColor = System.Drawing.Color.Red
            lblwarning.Text += "Please enter password." + Environment.NewLine
            txtpassword.BorderColor = System.Drawing.Color.Red
            txtpassword.BorderThickness = 2
        End If
        If lblwarning.Text = "" Then
            userLC = txtusername.Text.ToLowerInvariant
            passLC = txtpassword.Text.ToLowerInvariant
            Dim strPass As String
            Dim strUser As String
            Dim access As Boolean

            Using hasher As MD5 = MD5.Create()
                Dim dbytes1 As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(userLC))
                strUser = Convert.ToBase64String(dbytes1)
            End Using

            openCon()
            sql = "Select username,password from tbl_accounts"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader()

            Do While dr.Read()
                Dim split = dr("password").split(":")
                Using hasher As MD5 = MD5.Create()
                    Dim check As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(passLC & split(0)))
                    strPass = Convert.ToBase64String(check)
                End Using

                If strUser = dr("username") And strPass = split(1) Then
                    If tgremember.Checked = True Then
                        My.MySettings.Default.Username = txtusername.Text
                        My.MySettings.Default.Password = txtpassword.Text
                        My.MySettings.Default.RememberMe = True
                        My.MySettings.Default.Save()
                    End If
                    reset_form()
                    Me.Visible = False
                    frmmain.ShowDialog(Me)
                    Me.Close()
                    access = True
                    Exit Do
                End If
            Loop
            dr.Close()
            cn.Close()
            If access = False Then
                lblwarning.ForeColor = System.Drawing.Color.Red
                lblwarning.Text = "Wrong Username or Password!" + Environment.NewLine + "Invalid Account"
            End If
        End If
    End Sub

    Private Sub txtpassword_IconRightClick(sender As Object, e As EventArgs) Handles txtpassword.IconRightClick
        If Showpwd = True Then
            If txtpassword.UseSystemPasswordChar = True Then
                txtpassword.UseSystemPasswordChar = False
                txtpassword.PasswordChar = ""
                txtpassword.IconRight = My.Resources.iconvisible
            ElseIf txtpassword.UseSystemPasswordChar = False Then
                txtpassword.UseSystemPasswordChar = True
                txtpassword.PasswordChar = "●"
                txtpassword.IconRight = My.Resources.iconinvisible
            End If
        End If
    End Sub

    Private Function CreateNewSalt(SaltSize As Integer) As String
        Using rng As New RNGCryptoServiceProvider
            Dim data(If(SaltSize < 7, 7, SaltSize)) As Byte
            rng.GetBytes(data)
            Return Convert.ToBase64String(data)
        End Using
    End Function

    Private Sub lblcreate_Click(sender As Object, e As EventArgs) Handles lblcreate.Click
        reset_form()
        Me.Opacity = 0.6
        Me.Enabled = False
        frmregistration.ShowDialog(Me)
    End Sub

    Private Sub cbremember_CheckedChanged(sender As Object, e As EventArgs)
        If tgremember.Checked = False Then
            My.MySettings.Default.Username = Nothing
            My.MySettings.Default.Password = Nothing
            My.MySettings.Default.RememberMe = False
            My.MySettings.Default.Save()
        End If
    End Sub

    Private Sub close_sub()
        If pnl_login.Enabled = True Then
            btnlog.Checked = False
            reset_form()
            pnl_login.Visible = False
            pnl_login.Enabled = False
        ElseIf pnl_contact.Enabled = True Then
            btncontact.Checked = False
            lblcontact1.Text = ""
            lblemail1.Text = ""
            pnl_contact.Visible = False
            pnl_contact.Enabled = False
        ElseIf pnl_terms.Enabled = True Then
            btnterms.Checked = False
            pnl_terms.Visible = False
            pnl_terms.Enabled = False
        ElseIf pnl_help.Enabled = True Then
            btnhelp.Checked = False
            pnl_help.Visible = False
            pnl_help.Enabled = False
            lbltitle1.Visible = True
            lbltitle2.Visible = True
            lbltitle3.Visible = True
            pblogo.Visible = True
        ElseIf pnl_about.Enabled = True Then
            btnabout.Checked = False
            pnl_about.Visible = False
            pnl_about.Enabled = False
        End If
    End Sub

    Private Sub btnhelp_Click(sender As Object, e As EventArgs) Handles btnhelp.Click
        btnhelp.Checked = True
        If pnl_help.Enabled = False Then
            close_sub()
            pnl_help.Enabled = True
            pnl_help.Visible = True
        End If
    End Sub

    Private Sub btnterms_Click(sender As Object, e As EventArgs) Handles btnterms.Click
        btnterms.Checked = True
        If pnl_terms.Enabled = False Then
            close_sub()
            pnl_terms.Enabled = True
            pnl_terms.Visible = True
        End If
    End Sub

    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        btnlog.Checked = True
        If pnl_login.Enabled = False Then
            close_sub()
            pnl_login.Enabled = True
            pnl_login.Visible = True
        End If
    End Sub

    Private Sub btnabout_Click(sender As Object, e As EventArgs) Handles btnabout.Click
        btnabout.Checked = True
        If pnl_about.Enabled = False Then
            close_sub()
            pnl_about.Enabled = True
            pnl_about.Visible = True
        End If
    End Sub

    Private Sub btncontact_Click(sender As Object, e As EventArgs) Handles btncontact.Click
        btncontact.Checked = True
        If pnl_contact.Enabled = False Then
            close_sub()
            pnl_contact.Enabled = True
            pnl_contact.Visible = True
            openCon()
            sql = "Select contact, email from tbl_contact"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader()

            Do While dr.Read()
                lblcontact1.Text += ((dr("contact").ToString) + Environment.NewLine)
                lblemail1.Text += (dr("email") + Environment.NewLine)

            Loop
            dr.Close()
            cn.Close()
        End If
    End Sub

    Private Sub lblRemember_Click(sender As Object, e As EventArgs) Handles lblRemember.Click
        If tgremember.Checked = False Then
            tgremember.Checked = True
        Else
            tgremember.Checked = False
        End If
    End Sub

    Private Sub tgremember_CheckedChanged(sender As Object, e As EventArgs) Handles tgremember.CheckedChanged
        If tgremember.Checked = False Then
            My.MySettings.Default.Username = Nothing
            My.MySettings.Default.Password = Nothing
            My.MySettings.Default.RememberMe = tgremember.Checked
        End If
    End Sub

    Private Sub txt_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged, txtpassword.TextChanged
        If lblwarning.ForeColor = System.Drawing.Color.Red Then
            lblwarning.ForeColor = System.Drawing.Color.WhiteSmoke
            lblwarning.Text = "Please Sign....."
        End If
    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        If txtpassword.Text = "" Then
            Showpwd = True
        ElseIf txtpassword.BorderThickness = 2 Then
            txtpassword.BorderColor = System.Drawing.Color.WhiteSmoke
            txtpassword.BorderThickness = 1
        End If
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged
        If txtusername.BorderThickness = 2 And txtusername.Text IsNot "" Then
            txtusername.BorderColor = System.Drawing.Color.WhiteSmoke
            txtusername.BorderThickness = 1
        End If
    End Sub

    Private Sub lblforgot_Click(sender As Object, e As EventArgs) Handles lblforgot.Click
        MsgBox("Contact your admin and they are the one who will be able to reset your account in Account Control Panel.")
    End Sub
End Class
