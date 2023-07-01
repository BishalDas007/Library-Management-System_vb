Imports System.Data.OleDb
Public Class frmCustomer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cnn As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Library.mdb")
        Dim cmd As OleDbCommand = New OleDbCommand("Select * From customer where CustomerId='" + TextBox6.Text + "'")
        cmd.CommandType = CommandType.Text
        cmd.Connection = cnn
        cnn.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        Dim kk As Integer = sdr.Read()
        If kk <> 0 Then
            TextBox1.Text = sdr("CustomerId").ToString()
            TextBox2.Text = sdr("Customername").ToString()
            TextBox3.Text = sdr("Phone").ToString()
            TextBox4.Text = sdr("Add").ToString()
            TextBox5.Text = sdr("BookId").ToString()
            TextBox7.Text = sdr("Bookname").ToString()
            cnn.Close()
        Else
            MessageBox.Show("Not Found!!")
        End If
    End Sub

    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As String
        Dim cnn As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Library.mdb")
        cnn.Open()
        a = "Select * From customer"
        Dim b As OleDbDataAdapter = New OleDbDataAdapter(a, cnn)
        Dim c As DataSet = New DataSet()
        b.Fill(c, "emp")
        DataGridView1.DataSource = c
        DataGridView1.DataMember = "emp"
        cnn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As String
        Dim cnn As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Library.mdb")
        cnn.Open()
        x = "Insert into customer Values('" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "', '" + TextBox5.Text + "', '" + TextBox7.Text + "')"
        Dim cmd As OleDbCommand = New OleDbCommand(x, cnn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Your Data is Inserted Successfully..!!")
        cnn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cnn As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Library.mdb")
        Dim cmd As OleDbCommand = New OleDbCommand("delete * from customer where CustomerId='" + TextBox1.Text + "'", cnn)
        cnn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Record Deleted Successfully..!!")
        cnn.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cnn As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Library.mdb")
        Dim sql As String = "UPDATE customer SET Customername='" + TextBox2.Text + "', Phone='" + TextBox3.Text + "', Add='" + TextBox4.Text + "', BookId='" + TextBox5.Text + "', Bookname='" + TextBox7.Text + "' where CustomerId='" + TextBox1.Text + "'"
        cnn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(sql, cnn)
        cmd.ExecuteNonQuery()
        MsgBox("New Record Has Been Updated..!!")
        cnn.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub
End Class