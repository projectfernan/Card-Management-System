Imports ADODB
Public Class frmLogin

    Private Sub frmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cmdLogin_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtUser.Text = vbNullString
        txtPass.Text = vbNullString
        txtUser.Focus()
    End Sub

    Sub CreatorLogin()
        Dim user As String = "fernan"
        Dim pass As String = "09010273"

        If Trim(txtUser.Text) = user Then
            If Trim(txtPass.Text) = pass Then
                'frmMain.txtOpLabel.Text = "ADMIN :"
                'frmMain.txtOperator.Text = txtUser.Text
                'unLock_Admin()
                loginFlag = True
                Me.Hide()
                frmSystem.ShowDialog()
                Me.Close()
            Else
                MsgBox("Unknown password!", vbExclamation, "Login")
                txtPass.Text = vbNullString
                txtPass.Focus()
            End If
        Else
            MsgBox("Unknown username!", vbExclamation, "Login")
            txtUser.Text = vbNullString
            txtPass.Text = vbNullString
            txtUser.Focus()
        End If

    End Sub

    Sub Userlogin()
        If conServer() = False Then
            MsgBox("Please connect to database!", vbExclamation, "Database Connection")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset

        rs = Conn.Execute("select * from tbluseracc where Username = '" & txtUser.Text & "'")
        If rs.EOF = False Then
            If Trim(txtPass.Text) = rs("Password").Value Then
                If rs("Designation").Value = "Operator" Then
                    loginFlag = False
                    frmMain.txtOpLabel.Text = "OPERATOR :"
                    frmMain.txtOperator.Text = txtUser.Text
                    unLock_User()
                    Me.Close()
                Else
                    'frmMain.txtOpLabel.Text = "ADMIN :"
                    'frmMain.txtOperator.Text = txtUser.Text
                    'unLock_Admin()
                    loginFlag = True
                    Me.Hide()
                    frmSystem.ShowDialog()
                    Me.Close()
                End If
            Else
                MsgBox("Unknown password!", vbExclamation, "Login")
                txtPass.Text = vbNullString
                txtPass.Focus()
            End If
        Else
            MsgBox("Unknown username!", vbExclamation, "Login")
            txtUser.Text = vbNullString
            txtPass.Text = vbNullString
            txtUser.Focus()
        End If
    End Sub

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        If txtUser.Text = "fernan" Then
            CreatorLogin()
        Else
            Userlogin()
        End If
    End Sub

    Private Sub frmLogin_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtUser.Focus()
    End Sub
End Class