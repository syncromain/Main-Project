Imports System.Data.OleDb
Imports System.Drawing.Text

Public Class frm_editing

    Private Property MoveForm As Boolean

    Private Property MoveForm_MousePosition As Point

    Private Sub frm_editing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopInfo()
    End Sub

    Private Sub PopInfo()
        openCon()
        sql = "Select * from tbl_patientrecords where patient_id=" & frmmain.selected
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()


        dr.Read()

        lblpatientid.Text += dr("patient_id").ToString
        txtlastname.Text = dr("lastname")
        txtfirstname.Text = dr("firstname")
        txtmi.Text = dr("mi")
        cbsex.Text = dr("sex")
        dtpbirth.Text = dr("birthdate")
        txtaddress.Text = dr("address")
        txtmartial.Text = dr("martialstatus")
        txtcontact.Text = dr("contact")

        dr.Close()
        cn.Close()
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
        For disapper As Single = 1.0! To 0 Step -0.2!
            Me.Opacity = disapper
            System.Threading.Thread.Sleep(50)
        Next
        Me.Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        For disapper As Single = 1.0! To 0 Step -0.2!
            Me.Opacity = disapper
            System.Threading.Thread.Sleep(50)
        Next
        Me.Opacity = 1.0!
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class