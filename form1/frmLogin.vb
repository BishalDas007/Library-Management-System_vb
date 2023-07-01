Imports System.Data.OleDb
Public Class frmLogin


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Len(Trim(cmbusertype.Text)) = 0 Then
            MessageBox.Show("Please select UserType", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbusertype.Focus()
            Exit Sub
        End If
        If Len(Trim(txtusername.Text)) = 0 Then
            MessageBox.Show("Please Enter Username", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtusername.Focus()
            Exit Sub
        End If
        If Len(Trim(txtpassword.Text)) = 0 Then
            MessageBox.Show("Please Enter Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtpassword.Focus()
            Exit Sub
        End If
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Library.mdb")
        Dim cmd As New OleDbCommand("Select * From register where Designation='" + cmbusertype.Text + "' and Username='" + txtusername.Text + "' and Password='" + txtpassword.Text + "'", con)
        con.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            Me.Hide()
            frmMain.Show()
        Else
            MessageBox.Show("Wrong UserName or Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbusertype.SelectedIndex = -1
            txtusername.Clear()
            txtpassword.Clear()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cmbusertype.SelectedIndex = -1
        txtusername.Clear()
        txtpassword.Clear()
        Me.Hide()
    End Sub
End Class