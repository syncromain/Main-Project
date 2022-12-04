Imports Guna.UI2.WinForms
Imports System.Data.OleDb

Public Class frmaddpatient
    Private Sub frmaddpatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetform()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        For disappear As Single = 1.0 To 0 Step -0.2
            Me.Opacity = disappear
            System.Threading.Thread.Sleep(50)
        Next
        frmmain.Visible = True
        resetform()
        Me.Close()
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

    Private Sub resetform()
        txtlastname.Text = Nothing
        txtfirstname.Text = Nothing
        txtmi.Text = Nothing
        cbsex.Text = Nothing
        dtpbirth.Text = "1/1/1900"
        txtaddress.Text = Nothing
        txtmartial.Text = Nothing
        txtcontact.Text = Nothing
    End Sub

    Private Function dtp_click(dtp As Guna2DateTimePicker)
        If dtp.BorderColor = System.Drawing.Color.Red Then
            dtp.BorderColor = System.Drawing.Color.WhiteSmoke
            dtp.BorderThickness = 1
        End If
        Return dtp
    End Function

    Private Function cbx_click(cbx As Guna2ComboBox)
        If cbx.BorderColor = System.Drawing.Color.Red Then
            cbx.BorderColor = System.Drawing.Color.WhiteSmoke
            cbx.BorderThickness = 1
        End If
        Return cbx
    End Function

    Private Function dtextchanged(dtp As Guna2DateTimePicker)
        If dtp.BorderColor = System.Drawing.Color.Red Then
            dtp.BorderColor = System.Drawing.Color.WhiteSmoke
            dtp.BorderThickness = 1
        End If
        Return dtp
    End Function

    Private Function ctextchanged(cbx As Guna2ComboBox)
        If cbx.BorderColor = System.Drawing.Color.Red Then
            cbx.BorderColor = System.Drawing.Color.WhiteSmoke
            cbx.BorderThickness = 1
        End If
        Return cbx
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

    Private Sub txtmi_MouseDown(sender As Object, e As EventArgs) Handles txtmi.TextChanged
        txtchanged(txtmi)
    End Sub

    Private Sub cbsex_MouseDown(sender As Object, e As EventArgs) Handles cbsex.Click, cbsex.Enter
        ctextchanged(cbsex)
    End Sub

    Private Sub dtpbirth_MouseDown(sender As Object, e As EventArgs) Handles dtpbirth.Click, dtpbirth.Enter
        dtextchanged(dtpbirth)
    End Sub

    Private Sub txtaddress_MouseDown(sender As Object, e As EventArgs) Handles txtaddress.TextChanged
        txtchanged(txtaddress)
    End Sub

    Private Sub txtmartial_MouseDown(sender As Object, e As EventArgs) Handles txtmartial.TextChanged
        txtchanged(txtmartial)
    End Sub

    Private Sub txtcontact_MouseDown(sender As Object, e As EventArgs) Handles txtcontact.TextChanged
        txtchanged(txtcontact)
    End Sub

    Private Sub btnsignup_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim empty As Boolean

        For Each ctrl As Control In Me.Controls
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
            ElseIf TypeOf ctrl Is Guna2DateTimePicker Then
                If CType(ctrl, Guna2DateTimePicker).Text = "1/1/1900" Then
                    CType(ctrl, Guna2DateTimePicker).BorderColor = System.Drawing.Color.Red
                    CType(ctrl, Guna2DateTimePicker).BorderThickness = 2
                    empty = True
                End If
            End If
        Next ctrl

        If empty = True Then
            lblwarning.Text = "Please complete all the information requested."
        Else
            If MsgBox("Are you sure to save this data?", vbYesNo + vbQuestion, Me.Text) = vbYes Then
                openCon()
                sql = "INSERT INTO tbl_patientrecords (lastname,firstname,mi,sex,birthdate,address,martialstatus,contact) VALUES ('" & txtlastname.Text & "','" & txtfirstname.Text & "','" & txtmi.Text & "','" & cbsex.Text & "','" & dtpbirth.Text & "','" & txtaddress.Text & "','" & txtmartial.Text & "','" & txtcontact.Text & "')"
                cmd = New OleDbCommand(sql, cn)
                cmd.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record Saved!", 64, Me.Text)
                resetform()
            End If
        End If
    End Sub

    Private Sub txtlastname_TextChanged(sender As Object, e As EventArgs) Handles txtlastname.TextChanged, txtfirstname.TextChanged, txtmi.TextChanged, cbsex.TextChanged, txtaddress.TextChanged, txtmartial.TextChanged, txtcontact.TextChanged
        lblwarning.Text = ""
    End Sub
End Class