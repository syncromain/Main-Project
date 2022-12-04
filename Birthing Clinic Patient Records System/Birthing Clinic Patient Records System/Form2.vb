Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Imports Guna.UI2.WinForms
Imports Microsoft.VisualBasic.ApplicationServices

Public Class frmregistration
    Private Const SaltSize As Integer = 31
    Dim userLC As String
    Dim passLC As String
    Dim rSalt = CreateNewSalt(SaltSize)

    Private Sub reset_form()
        txtlastname.Text = Nothing
        txtfirstname.Text = Nothing
        txtusername.Text = Nothing
        txtnewpassword.Text = Nothing
        txtconfirmpassword.Text = Nothing
        cbusertype.Text = Nothing
        lblwarning.ForeColor = System.Drawing.Color.WhiteSmoke
    End Sub
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        reset_form()
        For disappear As Single = 1.0 To 0 Step -0.2
            Me.Opacity = disappear
            System.Threading.Thread.Sleep(50)
        Next
        Me.Close()
        frmlogin.Opacity = 1.0
        frmlogin.Enabled = True
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click

        For disappear As Single = 1.0 To 0 Step -0.2
            Me.Opacity = disappear
            frmlogin.Opacity = disappear
            System.Threading.Thread.Sleep(50)
        Next
        Me.Opacity = 1.0
        Me.WindowState = FormWindowState.Minimized
        frmlogin.Enabled = True
        frmlogin.WindowState = FormWindowState.Minimized
    End Sub

    Private Function ctextchanged(txt As Guna2ComboBox)
        If txt.BorderColor = System.Drawing.Color.Red Then
            txt.BorderColor = System.Drawing.Color.WhiteSmoke
            txt.BorderThickness = 1
        End If
        Return txt
    End Function

    Private Function txtchanged(txt As Guna2TextBox)
        If txt.BorderColor = System.Drawing.Color.Red Then
            txt.BorderColor = System.Drawing.Color.WhiteSmoke
            txt.BorderThickness = 1
        End If
        Return txt
    End Function

    Private Sub txtlastname_MouseDown(sender As Object, e As EventArgs) Handles txtlastname.TextChanged
        txtchanged(txtlastname)
    End Sub

    Private Sub txtfirstname_MouseDown(sender As Object, e As EventArgs) Handles txtfirstname.TextChanged
        txtchanged(txtfirstname)
    End Sub

    Private Sub txtusername_MouseDown(sender As Object, e As EventArgs) Handles txtusername.TextChanged
        txtchanged(txtusername)
    End Sub

    Private Sub txtnewpassword_MouseDown(sender As Object, e As EventArgs) Handles txtnewpassword.TextChanged
        txtchanged(txtnewpassword)
    End Sub

    Private Sub txtconfirmpassword_MouseDown(sender As Object, e As EventArgs) Handles txtconfirmpassword.TextChanged
        txtchanged(txtconfirmpassword)
    End Sub

    Private Sub cbusertype_MouseDown(sender As Object, e As EventArgs) Handles cbusertype.Click, cbusertype.Enter
        ctextchanged(cbusertype)
    End Sub

    Private Sub lblsignin_Click(sender As Object, e As EventArgs) Handles lblsignin.Click
        reset_form()
        Me.Close()
        frmlogin.Opacity = 1.0
        frmlogin.Enabled = True
    End Sub

    Private Sub txtnewpassword_IconRightClick(sender As Object, e As EventArgs) Handles txtnewpassword.IconRightClick
        If txtnewpassword.UseSystemPasswordChar = True Then
            txtnewpassword.UseSystemPasswordChar = False
            txtnewpassword.PasswordChar = ""
            txtnewpassword.IconRight = My.Resources.iconvisible
        ElseIf txtnewpassword.UseSystemPasswordChar = False Then
            txtnewpassword.UseSystemPasswordChar = True
            txtnewpassword.PasswordChar = "●"
            txtnewpassword.IconRight = My.Resources.iconinvisible
        End If
    End Sub

    Private Sub txtconfirmpassword_IconRightClick(sender As Object, e As EventArgs) Handles txtconfirmpassword.IconRightClick
        If txtconfirmpassword.UseSystemPasswordChar = True Then
            txtconfirmpassword.UseSystemPasswordChar = False
            txtconfirmpassword.PasswordChar = ""
            txtconfirmpassword.IconRight = My.Resources.iconvisible
        ElseIf txtconfirmpassword.UseSystemPasswordChar = False Then
            txtconfirmpassword.UseSystemPasswordChar = True
            txtconfirmpassword.PasswordChar = "●"
            txtconfirmpassword.IconRight = My.Resources.iconinvisible
        End If
    End Sub

    Private Sub btnsignup_Click(sender As Object, e As EventArgs) Handles btnsignup.Click
        Dim empty As Boolean
        userLC = txtusername.Text.ToLowerInvariant
        passLC = txtnewpassword.Text.ToLowerInvariant
        Dim strPass As String
        Dim strUser As String
        Using hasher As MD5 = MD5.Create()
            Dim dbytes1 As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(userLC))
            Dim dbytes2 As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(passLC & rSalt))
            strUser = Convert.ToBase64String(dbytes1)
            strPass = Convert.ToBase64String(dbytes2)
        End Using

        For Each ctrl As Control In Me.PanelRegistration.Controls
            If TypeOf ctrl Is Guna2TextBox Then
                If CType(ctrl, Guna2TextBox).Text = "" Then
                    CType(ctrl, Guna2TextBox).BorderColor = System.Drawing.Color.Red
                    CType(ctrl, Guna2TextBox).BorderThickness = 2
                    empty = True
                End If
            ElseIf TypeOf ctrl Is Guna2ComboBox Then
                If CType(ctrl, Guna2ComboBox).Text = "" Then
                    CType(ctrl, Guna2ComboBox).BorderColor = System.Drawing.Color.Red
                    CType(ctrl, Guna2ComboBox).BorderThickness = 2
                    empty = True
                End If
            End If
        Next ctrl

        If empty = True Then
            lblwarning.ForeColor = System.Drawing.Color.Red
            lblwarning.Text = "Please complete all the information requested."
        Else
            Dim access As Boolean

            openCon()
            sql = "Select username from tbl_accounts"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader()

            Do While dr.Read()
                If txtusername.Text = dr("username") Then
                    MsgBox("")
                    lblwarning.Text = "Username already exists"
                    txtusername.BorderColor = System.Drawing.Color.Red
                    txtusername.BorderThickness = 2
                    access = True
                    Exit Do
                End If
            Loop
            dr.Close()
            cn.Close()
            If access = False Then
                If MsgBox("Are you sure to register?", vbYesNo + vbQuestion, Me.Text) = vbYes Then

                    'openCon()
                    'sql = "INSERT INTO tbl_accountrequests(username,usertype,[password],lastname,firstname) Values ('" & txtusername.Text & "','" & cbusertype.Text & "','" & txtnewpassword.Text & "','" & txtlastname.Text & "','" & txtfirstname.Text & "')"
                    'cmd = New OleDbCommand(sql, cn)
                    'cmd.ExecuteNonQuery()
                    'cn.Close()
                    'MsgBox("Record Saved!", 64, Me.Text)
                    'Me.Close()
                    'frmlogin.Opacity = 1.0
                    'frmlogin.Enabled = True
                    openCon()
                    sql = "INSERT INTO tbl_accounts(username,usertype,[password],lastname,firstname) Values ('" & strUser & "','" & cbusertype.Text & "','" & String.Format("{0}:{1}", rSalt, strPass) & "','" & txtlastname.Text & "','" & txtfirstname.Text & "')"
                    cmd = New OleDbCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Record Saved!!", 64, Me.Text)
                    Me.Close()
                    frmlogin.Opacity = 1.0
                    frmlogin.Enabled = True
                    reset_form()

                End If
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

    Private Sub text_changed(sender As Object, e As EventArgs) Handles txtlastname.TextChanged, txtfirstname.TextChanged, txtusername.TextChanged, txtnewpassword.TextChanged, txtconfirmpassword.TextChanged, cbusertype.SelectedIndexChanged
        lblwarning.Text = ""
    End Sub
End Class