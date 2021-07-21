﻿Imports ADODB
Public Class frmLogo

    Private Sub frmLogo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If chk() = False Then
            PicLogo.Image = Logo_Image()
        End If
    End Sub

    Sub BrowsePath()

        OpenPath.Filter = "JPEG Images (*.jpg,*.jpeg)|*.jpg;*.jpeg"
        OpenPath.InitialDirectory = "C:\"
        OpenPath.FileName = vbNullString

        If OpenPath.ShowDialog = Windows.Forms.DialogResult.OK Then
            pathFrm = vbNullString
            pathFrm = OpenPath.FileName
        End If

        PicLogo.Image = Image.FromFile(pathFrm)

        cmdBrowse.Visible = False
        cmdUpdate.Visible = True
    End Sub

    Function chk() As Boolean
        If conServer() = False Then Return True
        Dim rs As New Recordset
        rs = New Recordset

        rs = Conn.Execute("select * from tblLogo")
        If rs.EOF = False Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub SaveLogo()
        If conServer() = False Then Exit Sub
        Dim rs As New Recordset
        Dim pathsave As String = getpicLogo(pathFrm)
        rs = New Recordset

        rs.Open("select * from tblLogo", Conn, 1, 2)
        rs.AddNew()
        Dim strem As New Stream
        strem.Type = StreamTypeEnum.adTypeBinary
        strem.Open()
        strem.LoadFromFile(pathsave)
        rs("Logo").Value = strem.Read
        rs.Update()

    End Sub

    Public Sub deleteLogo()
        If conServer() = False Then Exit Sub
        Dim rs As New Recordset
        Dim pathsave As String = getpicLogo(pathFrm)
        rs = New Recordset

        rs = Conn.Execute("delete from tblLogo")
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        deleteLogo()
        SaveLogo()
        Delete_Logo()
    
        MsgBox("System logo successfully saved!    ", vbInformation, "System Logo")
        cmdBrowse.Visible = True
        cmdUpdate.Visible = False
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        BrowsePath()
        cmdUpdate.Visible = True
        cmdBrowse.Visible = False
    End Sub
End Class