<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Data = New WindowsApp1.Data()
        Me.TblPatentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPatentsTableAdapter = New WindowsApp1.DataTableAdapters.tblPatentsTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IssueDate = New System.Windows.Forms.TextBox()
        Me.Title = New System.Windows.Forms.TextBox()
        Me.PublicationNumber = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPatentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TblPatentsBindingSource
        Me.ComboBox1.DisplayMember = "Publication Number"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(134, 73)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(161, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "Publication Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Look Up Patent"
        '
        'Data
        '
        Me.Data.DataSetName = "Data"
        Me.Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPatentsBindingSource
        '
        Me.TblPatentsBindingSource.DataMember = "tblPatents"
        Me.TblPatentsBindingSource.DataSource = Me.Data
        '
        'TblPatentsTableAdapter
        '
        Me.TblPatentsTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(376, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Issue Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(407, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Title"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(347, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Publication Number"
        '
        'IssueDate
        '
        Me.IssueDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatentsBindingSource, "Publication dates", True))
        Me.IssueDate.Location = New System.Drawing.Point(456, 171)
        Me.IssueDate.Name = "IssueDate"
        Me.IssueDate.Size = New System.Drawing.Size(182, 20)
        Me.IssueDate.TabIndex = 9
        '
        'Title
        '
        Me.Title.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatentsBindingSource, "Title", True))
        Me.Title.Location = New System.Drawing.Point(456, 121)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(182, 20)
        Me.Title.TabIndex = 8
        '
        'PublicationNumber
        '
        Me.PublicationNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatentsBindingSource, "Publication Number", True))
        Me.PublicationNumber.Location = New System.Drawing.Point(456, 74)
        Me.PublicationNumber.Name = "PublicationNumber"
        Me.PublicationNumber.Size = New System.Drawing.Size(182, 20)
        Me.PublicationNumber.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(459, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(209, 48)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "View full Title text"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IssueDate)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.PublicationNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPatentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Data As Data
    Friend WithEvents TblPatentsBindingSource As BindingSource
    Friend WithEvents TblPatentsTableAdapter As DataTableAdapters.tblPatentsTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents IssueDate As TextBox
    Friend WithEvents Title As TextBox
    Friend WithEvents PublicationNumber As TextBox
    Friend WithEvents Button1 As Button
End Class
