<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        TextBox6 = New TextBox()
        RichTextBox1 = New RichTextBox()
        Label7 = New Label()
        TextBox7 = New TextBox()
        ListView1 = New ListView()
        contact_id = New ColumnHeader()
        first_name = New ColumnHeader()
        last_name = New ColumnHeader()
        phone = New ColumnHeader()
        gender = New ColumnHeader()
        address = New ColumnHeader()
        Button1 = New Button()
        Button5 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        ComboBox1 = New ComboBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(295, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(106, 87)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(349, 39)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(415, 37)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Enabled = False
        TextBox1.Font = New Font("Segoe UI", 12.0F)
        TextBox1.Location = New Point(129, 146)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 29)
        TextBox1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label1.Location = New Point(36, 150)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 21)
        Label1.TabIndex = 3
        Label1.Text = "ContactID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label2.Location = New Point(36, 186)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 21)
        Label2.TabIndex = 5
        Label2.Text = "First Name"
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Segoe UI", 12.0F)
        TextBox2.Location = New Point(129, 186)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Input first name"
        TextBox2.Size = New Size(200, 22)
        TextBox2.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label3.Location = New Point(36, 227)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 21)
        Label3.TabIndex = 7
        Label3.Text = "Last Name"
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Segoe UI", 12.0F)
        TextBox3.Location = New Point(129, 227)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Input last name"
        TextBox3.Size = New Size(200, 22)
        TextBox3.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label5.Location = New Point(36, 308)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 21)
        Label5.TabIndex = 11
        Label5.Text = "Gender"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label6.Location = New Point(36, 267)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 21)
        Label6.TabIndex = 9
        Label6.Text = "Phone"
        ' 
        ' TextBox6
        ' 
        TextBox6.BorderStyle = BorderStyle.None
        TextBox6.Font = New Font("Segoe UI", 12.0F)
        TextBox6.Location = New Point(129, 267)
        TextBox6.Name = "TextBox6"
        TextBox6.PlaceholderText = "Input phone"
        TextBox6.Size = New Size(200, 22)
        TextBox6.TabIndex = 8
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Location = New Point(129, 348)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(200, 127)
        RichTextBox1.TabIndex = 14
        RichTextBox1.Text = ""
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label7.Location = New Point(36, 348)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 21)
        Label7.TabIndex = 15
        Label7.Text = "Address"
        ' 
        ' TextBox7
        ' 
        TextBox7.BorderStyle = BorderStyle.None
        TextBox7.Font = New Font("Segoe UI", 12.0F)
        TextBox7.Location = New Point(407, 149)
        TextBox7.Name = "TextBox7"
        TextBox7.PlaceholderText = "Search contact"
        TextBox7.Size = New Size(676, 22)
        TextBox7.TabIndex = 16
        ' 
        ' ListView1
        ' 
        ListView1.AllowColumnReorder = True
        ListView1.AllowDrop = True
        ListView1.Columns.AddRange(New ColumnHeader() {contact_id, first_name, last_name, phone, gender, address})
        ListView1.FullRowSelect = True
        ListView1.HeaderStyle = ColumnHeaderStyle.Nonclickable
        ListView1.Location = New Point(407, 186)
        ListView1.MultiSelect = False
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(676, 289)
        ListView1.TabIndex = 17
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' contact_id
        ' 
        contact_id.Tag = "contact_id"
        contact_id.Text = "Contact ID"
        contact_id.Width = 80
        ' 
        ' first_name
        ' 
        first_name.Text = "First Name"
        first_name.Width = 90
        ' 
        ' last_name
        ' 
        last_name.Text = "Last Name"
        last_name.Width = 90
        ' 
        ' phone
        ' 
        phone.Text = "Phone Number"
        phone.Width = 120
        ' 
        ' gender
        ' 
        gender.DisplayIndex = 5
        gender.Text = "Gender"
        gender.Width = 90
        ' 
        ' address
        ' 
        address.DisplayIndex = 4
        address.Text = "Address"
        address.Width = 200
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button1.Font = New Font("Segoe UI", 10.0F, FontStyle.Italic)
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(305, 502)
        Button1.Name = "Button1"
        Button1.Size = New Size(130, 32)
        Button1.TabIndex = 18
        Button1.Text = "Create"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button5.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button5.Font = New Font("Segoe UI", 10.0F, FontStyle.Italic)
        Button5.ForeColor = SystemColors.ButtonFace
        Button5.Location = New Point(450, 502)
        Button5.Name = "Button5"
        Button5.Size = New Size(130, 32)
        Button5.TabIndex = 22
        Button5.Text = "Update"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button2.Font = New Font("Segoe UI", 10.0F, FontStyle.Italic)
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(595, 502)
        Button2.Name = "Button2"
        Button2.Size = New Size(130, 32)
        Button2.TabIndex = 23
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button3.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button3.Font = New Font("Segoe UI", 10.0F, FontStyle.Italic)
        Button3.ForeColor = SystemColors.ButtonFace
        Button3.Location = New Point(741, 502)
        Button3.Name = "Button3"
        Button3.Size = New Size(130, 32)
        Button3.TabIndex = 24
        Button3.Text = "Clear"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI", 12.0F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Male", "Female"})
        ComboBox1.Location = New Point(129, 307)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(200, 29)
        ComboBox1.TabIndex = 25
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1133, 559)
        Controls.Add(ComboBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button5)
        Controls.Add(Button1)
        Controls.Add(ListView1)
        Controls.Add(TextBox7)
        Controls.Add(Label7)
        Controls.Add(RichTextBox1)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(TextBox6)
        Controls.Add(Label3)
        Controls.Add(TextBox3)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        Text = "Chairil Fauzi Firmansyah - 230401010024"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents contact_id As ColumnHeader
    Friend WithEvents first_name As ColumnHeader
    Friend WithEvents last_name As ColumnHeader
    Friend WithEvents phone As ColumnHeader
    Friend WithEvents address As ColumnHeader
    Friend WithEvents gender As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox

End Class
