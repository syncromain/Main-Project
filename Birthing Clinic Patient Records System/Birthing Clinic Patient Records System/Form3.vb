Imports System.Runtime.CompilerServices
Imports System.Data.OleDb
Imports Guna.UI2.WinForms

Public Class frmmain
    Dim newFont As New Font("Segoe UI", 9.2, FontStyle.Underline)
    Dim newFont2 As New Font("Segoe UI", 9.2)
    Dim hided = False
    Dim pop As Boolean
    Public selected As String

    Private Property MoveForm As Boolean

    Private Property MoveForm_MousePosition As Point

    Private Sub PopListView()
        dgv_records.Rows.Clear()
        openCon()
        sql = "Select * from tbl_patientrecords order by patient_id"
        cmd = New OleDb.OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()

        Do While dr.Read() = True
            dgv_records.Rows.Add(dr.Item("patient_id").ToString, dr.Item("lastname").ToString, dr.Item("firstname").ToString, dr.Item("mi").ToString)
        Loop
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
        Application.Exit()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        For disapper As Single = 1.0! To 0 Step -0.2!
            Me.Opacity = disapper
            System.Threading.Thread.Sleep(50)
        Next
        Me.Opacity = 1.0!
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnslidepanel_Click(sender As Object, e As EventArgs) Handles btnslidepanel.Click

        If hided = False Then


            btnslidepanel.Image = Nothing
            While (sc.SplitterDistance > 40)
                sc.SplitterDistance -= 4
                btnslidepanel.Width -= 2
                sc.Panel2.Refresh()
            End While

            While (btnslidepanel.Width < 51)
                btnslidepanel.Width += 1
            End While

            btnhome.BorderRadius = 8
            btncontrol.BorderRadius = 8

            btnhome.Width = sc.SplitterDistance - 4
            btnrecords.Width = sc.SplitterDistance - 4
            btnnotifi.Width = sc.SplitterDistance - 4
            btncalendar.Width = sc.SplitterDistance - 4
            btnhelp.Width = sc.SplitterDistance - 4
            btncontrol.Width = sc.SplitterDistance - 4
            btnaccount.Width = sc.SplitterDistance - 4
            btnsetting.Width = sc.SplitterDistance - 4
            btnabout.Width = sc.SplitterDistance - 4
            btnlogout.Width = sc.SplitterDistance - 4

            hided = True
            btnslidepanel.Image = My.Resources.iconslideshow
            btnhome.Text = Nothing
            btnrecords.Text = Nothing
            btnnotifi.Text = Nothing
            btncalendar.Text = Nothing
            btnhelp.Text = Nothing
            btncontrol.Text = Nothing
            btnaccount.Text = Nothing
            btnsetting.Text = Nothing
            btnabout.Text = Nothing
            btnlogout.Text = Nothing

            btnhome.Image = My.Resources.iconhome
            btnrecords.Image = My.Resources.iconrecords
            btnnotifi.Image = My.Resources.iconnotifi
            btncalendar.Image = My.Resources.iconcalendar
            btnhelp.Image = My.Resources.iconhelp
            btncontrol.Image = My.Resources.iconcontrol
            btnlogout.Image = My.Resources.iconlogout

        ElseIf hided = True Then

            btnhome.BorderRadius = 0
            btncontrol.BorderRadius = 0

            btnhome.Image = Nothing
            btnrecords.Image = Nothing
            btnnotifi.Image = Nothing
            btncalendar.Image = Nothing
            btnhelp.Image = Nothing
            btncontrol.Image = Nothing
            btnlogout.Image = Nothing

            btnhome.Text = "Home"
            btnrecords.Text = "Patients record"
            btnnotifi.Text = "Notification"
            btncalendar.Text = "Calendar"
            btnhelp.Text = "Help and Tips"
            btncontrol.Text = "Accounts Control"
            btnaccount.Text = "Account"
            btnsetting.Text = "Setting"
            btnabout.Text = "About"
            btnlogout.Text = "Logout"

            btnhome.Width = 116
            btnrecords.Width = 116
            btnnotifi.Width = 116
            btncalendar.Width = 116
            btnhelp.Width = 116
            btncontrol.Width = 116
            btnaccount.Width = 116
            btnsetting.Width = 116
            btnabout.Width = 116
            btnlogout.Width = 116

            btnslidepanel.Image = Nothing
            While (sc.SplitterDistance < 120)
                sc.SplitterDistance += 4
                btnslidepanel.Width -= 2
                sc.Panel1.Refresh()
                sc.Panel2.Refresh()
            End While

            While (btnslidepanel.Width < 51)
                btnslidepanel.Width += 1
            End While

            hided = False
            btnslidepanel.Image = My.Resources.iconslidehide
        End If
    End Sub

    Private Sub close_sub()
        If pnl_home.Enabled = True Then
            btnhome.Checked = False
            pnl_home.Visible = False
            pnl_home.Enabled = False
        ElseIf pnl_records.Enabled = True Then
            btnrecords.Checked = False
            pnl_records.Visible = False
            pnl_records.Enabled = False
        End If
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
        Application.Restart()
    End Sub

    Private Sub btnrecords_Click(sender As Object, e As EventArgs) Handles btnrecords.Click
        btnrecords.Checked = True
        If pnl_records.Enabled = False Then
            close_sub()
            btnadd.BackColor = System.Drawing.Color.Green
            btnslidepanel.BackColor = System.Drawing.Color.Green
            pnl_records.Enabled = True
            pnl_records.Visible = True
            txtsearch.Enabled = True
            txtsearch.Visible = True
            PopListView()
        End If
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        btnhome.Checked = True
        If pnl_home.Enabled = False Then
            close_sub()
            btnadd.BackColor = System.Drawing.Color.Transparent
            btnslidepanel.BackColor = System.Drawing.Color.Transparent
            pnl_home.Enabled = True
            pnl_home.Visible = True
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Me.Visible = False
        frmaddpatient.ShowDialog(Me)
    End Sub

    Private Sub search()
        Dim check As Boolean

        openCon()
        sql = "Select * from tbl_patientrecords where lastname like '%" & txtsearch.Text & "%'"
        cmd = New OleDb.OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()
        dgv_records.Rows.Clear()

        Do While dr.Read() = True
            dgv_records.Rows.Add(dr.Item("patient_id").ToString, dr.Item("lastname").ToString, dr.Item("firstname").ToString, dr.Item("mi").ToString)
        Loop

        sql = "Select * from tbl_patientrecords where firstname like '%" & txtsearch.Text & "%'"
        cmd = New OleDb.OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()

        Do While dr.Read() = True
            For Each row In dgv_records.Rows
                If row.Cells("Column1").Value = dr.Item("patient_id").ToString Then
                    check = True
                    Exit For
                End If
            Next
            If check = False Then
                dgv_records.Rows.Add(dr.Item("patient_id").ToString, dr.Item("lastname").ToString, dr.Item("firstname").ToString, dr.Item("mi").ToString)
            End If
        Loop

        sql = "Select * from tbl_patientrecords where patient_id like '%" & txtsearch.Text & "%'"
        cmd = New OleDb.OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()

        Do While dr.Read() = True
            For Each row In dgv_records.Rows
                If row.Cells("Column1").Value = dr.Item("patient_id").ToString Then
                    check = True
                    Exit For
                End If
            Next
            If check = False Then
                dgv_records.Rows.Add(dr.Item("patient_id").ToString, dr.Item("lastname").ToString, dr.Item("firstname").ToString, dr.Item("mi").ToString)
            End If
        Loop
        dr.Close()
        cn.Close()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        If txtsearch.Text = "" And pop = True Then
            PopListView()
        ElseIf txtsearch.Text IsNot "" Then
            search()
            pop = True
        End If
    End Sub

    Private Sub dgv_records_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_records.CellContentClick
        selected = (dgv_records.Rows(e.RowIndex).Cells(0).Value).ToString

        If IsDBNull(selected) Then
        Else
            frm_editing.ShowDialog(Me)
        End If
    End Sub

    Private Sub btnnotifi_Click(sender As Object, e As EventArgs) Handles btnnotifi.Click

    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub
End Class