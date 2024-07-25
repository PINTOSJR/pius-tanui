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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 20)
        Label1.TabIndex = 0
        Label1.Text = "Title"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 1
        Label2.Text = "Author"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 20)
        Label3.TabIndex = 2
        Label3.Text = "Year published"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 161)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 20)
        Label4.TabIndex = 3
        Label4.Text = "Genre"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(188, 21)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 4
        TextBox1.Text = "txtTitle"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(188, 71)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 5
        TextBox2.Text = "txtAuthor"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(188, 161)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 6
        TextBox3.Text = "txtGenre"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(188, 120)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 7
        TextBox4.Text = "txtYearpublished"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(31, 253)
        Button1.Name = "Button1"
        Button1.Size = New Size(90, 32)
        Button1.TabIndex = 8
        Button1.Text = "btnADD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(156, 253)
        Button2.Name = "Button2"
        Button2.Size = New Size(90, 32)
        Button2.TabIndex = 9
        Button2.Text = "btnUPDATE"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(272, 253)
        Button3.Name = "Button3"
        Button3.Size = New Size(90, 32)
        Button3.TabIndex = 10
        Button3.Text = "btnDELETE"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(398, 253)
        Button4.Name = "Button4"
        Button4.Size = New Size(90, 32)
        Button4.TabIndex = 11
        Button4.Text = "btnCLEAR"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridView1.Location = New Point(340, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(448, 247)
        DataGridView1.TabIndex = 12
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Column1"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Column2"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Column3"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn

End Class
