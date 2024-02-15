Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn Is Nothing Then
            Dim connectionString As String = "server=localhost;user=root;password=;database=phonebook"
            conn = New MySqlConnection(connectionString)
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button5.Enabled = False
            Try
                conn.Open()
                GetData()
                Button1.Enabled = True
                Button2.Enabled = True
                Button3.Enabled = True
                Button5.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Failed to connect to database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub GetData(Optional searchTerm As String = "")
        Try
            Dim query As String
            If String.IsNullOrEmpty(searchTerm) Then
                query = "SELECT * FROM contacts"
            Else
                query = "SELECT * FROM contacts WHERE first_name LIKE @searchTerm OR last_name LIKE @searchTerm OR phone LIKE @searchTerm OR gender LIKE @searchTerm OR address LIKE @searchTerm"
            End If

            Using cmd As New MySqlCommand(query, conn)
                If Not String.IsNullOrEmpty(searchTerm) Then
                    cmd.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ListView1.Items.Clear()
                    While reader.Read()
                        Dim item As New ListViewItem(reader("contact_id").ToString())
                        item.SubItems.Add(reader("first_name").ToString())
                        item.SubItems.Add(reader("last_name").ToString())
                        item.SubItems.Add(reader("phone").ToString())
                        item.SubItems.Add(reader("gender").ToString())
                        item.SubItems.Add(reader("address").ToString())
                        ListView1.Items.Add(item)
                    End While
                End Using
            End Using

            Dim nextId As Integer = GetNextContactId()
            TextBox1.Text = nextId.ToString()
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            TextBox1.Text = ListView1.SelectedItems(0).SubItems(0).Text
            TextBox2.Text = ListView1.SelectedItems(0).SubItems(1).Text
            TextBox3.Text = ListView1.SelectedItems(0).SubItems(2).Text
            TextBox6.Text = ListView1.SelectedItems(0).SubItems(3).Text
            ComboBox1.Text = ListView1.SelectedItems(0).SubItems(4).Text
            RichTextBox1.Text = ListView1.SelectedItems(0).SubItems(5).Text
        Catch ex As Exception
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox6.Text = ""
            ComboBox1.Text = ""
            RichTextBox1.Text = ""
        End Try
    End Sub

    Public Sub InsertContact(firstName As String, lastName As String, phone As String, gender As String, address As String)
        Try
            Dim query As String = "INSERT INTO contacts (first_name, last_name, phone, gender, address) VALUES (@firstName, @lastName, @phone, @gender, @address)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@firstName", firstName)
                cmd.Parameters.AddWithValue("@lastName", lastName)
                cmd.Parameters.AddWithValue("@phone", phone)
                cmd.Parameters.AddWithValue("@gender", gender)
                cmd.Parameters.AddWithValue("@address", address)
                cmd.ExecuteNonQuery()
            End Using
            GetData()
            MessageBox.Show("Successful create new contact : " & TextBox2.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox6.Text = ""
            ComboBox1.Text = ""
            RichTextBox1.Text = ""
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox2.Text) OrElse
           String.IsNullOrEmpty(TextBox3.Text) OrElse
           String.IsNullOrEmpty(TextBox6.Text) OrElse
           String.IsNullOrEmpty(ComboBox1.Text) OrElse
           String.IsNullOrEmpty(RichTextBox1.Text) Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        InsertContact(TextBox2.Text, TextBox3.Text, TextBox6.Text, ComboBox1.Text, RichTextBox1.Text)
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Function GetNextContactId() As Integer
        Dim query As String = "SELECT IFNULL(MAX(contact_id), 0) + 1 AS next_id FROM contacts"
        Using cmd As New MySqlCommand(query, conn)
            Dim nextId As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return nextId
        End Using
    End Function

    Public Sub DeleteContact(contactId As Integer)
        Try
            Dim query As String = "DELETE FROM contacts WHERE contact_id = @contactId"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@contactId", contactId)
                cmd.ExecuteNonQuery()
            End Using
            GetData()
            MessageBox.Show("Contact deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox6.Text = ""
            ComboBox1.Text = ""
            RichTextBox1.Text = ""
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub UpdateContact(contactId As Integer, firstName As String, lastName As String, phone As String, gender As String, address As String)
        Try
            Dim query As String = "UPDATE contacts SET first_name = @firstName, last_name = @lastName, phone = @phone, gender = @gender, address = @address WHERE contact_id = @contactId"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@firstName", firstName)
                cmd.Parameters.AddWithValue("@lastName", lastName)
                cmd.Parameters.AddWithValue("@phone", phone)
                cmd.Parameters.AddWithValue("@gender", gender)
                cmd.Parameters.AddWithValue("@address", address)
                cmd.Parameters.AddWithValue("@contactId", contactId)
                cmd.ExecuteNonQuery()
            End Using
            GetData()
            MessageBox.Show("Contact updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox6.Text = ""
            ComboBox1.Text = ""
            RichTextBox1.Text = ""
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Dim nextId As Integer = GetNextContactId()
            TextBox1.Text = nextId.ToString()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox6.Text = ""
        ComboBox1.Text = ""
        RichTextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this contact?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim contactId As Integer = Convert.ToInt32(ListView1.SelectedItems(0).SubItems(0).Text)
                DeleteContact(contactId)
            End If
        Else
            MessageBox.Show("Please select a contact to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this contact?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim contactId As Integer = Convert.ToInt32(ListView1.SelectedItems(0).SubItems(0).Text)
                UpdateContact(contactId, TextBox2.Text, TextBox3.Text, TextBox6.Text, ComboBox1.Text, RichTextBox1.Text)
            End If
        Else
            MessageBox.Show("Please select a contact to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Dim searchTerm As String = TextBox7.Text
        GetData(searchTerm)
    End Sub
End Class
