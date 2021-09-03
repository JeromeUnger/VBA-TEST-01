<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.TblPatentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Data = New WindowsApp1.Data()
        Me.TblPatentsTableAdapter = New WindowsApp1.DataTableAdapters.tblPatentsTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.TblPatentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblPatentsBindingSource
        '
        Me.TblPatentsBindingSource.DataMember = "tblPatents"
        Me.TblPatentsBindingSource.DataSource = Me.Data
        '
        'Data
        '
        Me.Data.DataSetName = "Data"
        Me.Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPatentsTableAdapter
        '
        Me.TblPatentsTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Title"
        '
        'Title
        '
        Me.Title.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatentsBindingSource, "Title", True))
        Me.Title.Location = New System.Drawing.Point(157, 12)
        Me.Title.Multiline = True
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(342, 450)
        Me.Title.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(581, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 48)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.TblPatentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Data As Data
    Friend WithEvents TblPatentsBindingSource As BindingSource
    Friend WithEvents TblPatentsTableAdapter As DataTableAdapters.tblPatentsTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Title As TextBox
    Friend WithEvents Button1 As Button
End Class
