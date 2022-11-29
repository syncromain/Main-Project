Imports System.Runtime.CompilerServices

Public Class frmmain
    Dim newFont As New Font("Segoe UI", 9.2, FontStyle.Underline)
    Dim newFont2 As New Font("Segoe UI", 9.2)
    Dim hided = False

    Private Property MoveForm As Boolean

    Private Property MoveForm_MousePosition As Point

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
        Me.Opacity = 1.0!
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

    Private Sub sc_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles sc.Panel2.Paint

    End Sub

    Private Sub btnsetting_Click(sender As Object, e As EventArgs) Handles btnsetting.Click

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click

    End Sub
End Class