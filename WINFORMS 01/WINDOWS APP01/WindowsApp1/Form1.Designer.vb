<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Data = New WindowsApp1.Data()
        Me.TblPatentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPatentsTableAdapter = New WindowsApp1.DataTableAdapters.tblPatentsTableAdapter()
        Me.IntPatentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublicationNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublicationKindCodesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImagesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OriginalDocumentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventorsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentStandardizedAssigneesInventorsRemovedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbstractDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherAbstractDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublicationDatesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApplicationDatesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrantDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IPCInternationalClassificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StrCountryCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StrCountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlatformDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPatentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IntPatentIDDataGridViewTextBoxColumn, Me.PublicationNumberDataGridViewTextBoxColumn, Me.PublicationKindCodesDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.OtherTitleDataGridViewTextBoxColumn, Me.ImagesDataGridViewTextBoxColumn, Me.OriginalDocumentDataGridViewTextBoxColumn, Me.InventorsDataGridViewTextBoxColumn, Me.CurrentStandardizedAssigneesInventorsRemovedDataGridViewTextBoxColumn, Me.AbstractDataGridViewTextBoxColumn, Me.OtherAbstractDataGridViewTextBoxColumn, Me.PublicationDatesDataGridViewTextBoxColumn, Me.ApplicationDatesDataGridViewTextBoxColumn, Me.GrantDateDataGridViewTextBoxColumn, Me.IPCInternationalClassificationDataGridViewTextBoxColumn, Me.StrCountryCodeDataGridViewTextBoxColumn, Me.StrCountryDataGridViewTextBoxColumn, Me.PlatformDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblPatentsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(810, 389)
        Me.DataGridView1.TabIndex = 1
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
        'IntPatentIDDataGridViewTextBoxColumn
        '
        Me.IntPatentIDDataGridViewTextBoxColumn.DataPropertyName = "intPatentID"
        Me.IntPatentIDDataGridViewTextBoxColumn.HeaderText = "intPatentID"
        Me.IntPatentIDDataGridViewTextBoxColumn.Name = "IntPatentIDDataGridViewTextBoxColumn"
        Me.IntPatentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PublicationNumberDataGridViewTextBoxColumn
        '
        Me.PublicationNumberDataGridViewTextBoxColumn.DataPropertyName = "Publication Number"
        Me.PublicationNumberDataGridViewTextBoxColumn.HeaderText = "Publication Number"
        Me.PublicationNumberDataGridViewTextBoxColumn.Name = "PublicationNumberDataGridViewTextBoxColumn"
        '
        'PublicationKindCodesDataGridViewTextBoxColumn
        '
        Me.PublicationKindCodesDataGridViewTextBoxColumn.DataPropertyName = "Publication kind codes"
        Me.PublicationKindCodesDataGridViewTextBoxColumn.HeaderText = "Publication kind codes"
        Me.PublicationKindCodesDataGridViewTextBoxColumn.Name = "PublicationKindCodesDataGridViewTextBoxColumn"
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'OtherTitleDataGridViewTextBoxColumn
        '
        Me.OtherTitleDataGridViewTextBoxColumn.DataPropertyName = "Other title"
        Me.OtherTitleDataGridViewTextBoxColumn.HeaderText = "Other title"
        Me.OtherTitleDataGridViewTextBoxColumn.Name = "OtherTitleDataGridViewTextBoxColumn"
        '
        'ImagesDataGridViewTextBoxColumn
        '
        Me.ImagesDataGridViewTextBoxColumn.DataPropertyName = "Images"
        Me.ImagesDataGridViewTextBoxColumn.HeaderText = "Images"
        Me.ImagesDataGridViewTextBoxColumn.Name = "ImagesDataGridViewTextBoxColumn"
        '
        'OriginalDocumentDataGridViewTextBoxColumn
        '
        Me.OriginalDocumentDataGridViewTextBoxColumn.DataPropertyName = "Original document"
        Me.OriginalDocumentDataGridViewTextBoxColumn.HeaderText = "Original document"
        Me.OriginalDocumentDataGridViewTextBoxColumn.Name = "OriginalDocumentDataGridViewTextBoxColumn"
        '
        'InventorsDataGridViewTextBoxColumn
        '
        Me.InventorsDataGridViewTextBoxColumn.DataPropertyName = "Inventors"
        Me.InventorsDataGridViewTextBoxColumn.HeaderText = "Inventors"
        Me.InventorsDataGridViewTextBoxColumn.Name = "InventorsDataGridViewTextBoxColumn"
        '
        'CurrentStandardizedAssigneesInventorsRemovedDataGridViewTextBoxColumn
        '
        Me.CurrentStandardizedAssigneesInventorsRemovedDataGridViewTextBoxColumn.DataPropertyName = "Current standardized assignees - inventors removed"
        Me.CurrentStandardizedAssigneesInventorsRemovedDataGridViewTextBoxColumn.HeaderText = "Current standardized assignees - inventors removed"
        Me.CurrentStandardizedAssigneesInventorsRemovedDataGridViewTextBoxColumn.Name = "CurrentStandardizedAssigneesInventorsRemovedDataGridViewTextBoxColumn"
        '
        'AbstractDataGridViewTextBoxColumn
        '
        Me.AbstractDataGridViewTextBoxColumn.DataPropertyName = "Abstract"
        Me.AbstractDataGridViewTextBoxColumn.HeaderText = "Abstract"
        Me.AbstractDataGridViewTextBoxColumn.Name = "AbstractDataGridViewTextBoxColumn"
        '
        'OtherAbstractDataGridViewTextBoxColumn
        '
        Me.OtherAbstractDataGridViewTextBoxColumn.DataPropertyName = "Other abstract"
        Me.OtherAbstractDataGridViewTextBoxColumn.HeaderText = "Other abstract"
        Me.OtherAbstractDataGridViewTextBoxColumn.Name = "OtherAbstractDataGridViewTextBoxColumn"
        '
        'PublicationDatesDataGridViewTextBoxColumn
        '
        Me.PublicationDatesDataGridViewTextBoxColumn.DataPropertyName = "Publication dates"
        Me.PublicationDatesDataGridViewTextBoxColumn.HeaderText = "Publication dates"
        Me.PublicationDatesDataGridViewTextBoxColumn.Name = "PublicationDatesDataGridViewTextBoxColumn"
        '
        'ApplicationDatesDataGridViewTextBoxColumn
        '
        Me.ApplicationDatesDataGridViewTextBoxColumn.DataPropertyName = "Application dates"
        Me.ApplicationDatesDataGridViewTextBoxColumn.HeaderText = "Application dates"
        Me.ApplicationDatesDataGridViewTextBoxColumn.Name = "ApplicationDatesDataGridViewTextBoxColumn"
        '
        'GrantDateDataGridViewTextBoxColumn
        '
        Me.GrantDateDataGridViewTextBoxColumn.DataPropertyName = "Grant date"
        Me.GrantDateDataGridViewTextBoxColumn.HeaderText = "Grant date"
        Me.GrantDateDataGridViewTextBoxColumn.Name = "GrantDateDataGridViewTextBoxColumn"
        '
        'IPCInternationalClassificationDataGridViewTextBoxColumn
        '
        Me.IPCInternationalClassificationDataGridViewTextBoxColumn.DataPropertyName = "IPC - International classification"
        Me.IPCInternationalClassificationDataGridViewTextBoxColumn.HeaderText = "IPC - International classification"
        Me.IPCInternationalClassificationDataGridViewTextBoxColumn.Name = "IPCInternationalClassificationDataGridViewTextBoxColumn"
        '
        'StrCountryCodeDataGridViewTextBoxColumn
        '
        Me.StrCountryCodeDataGridViewTextBoxColumn.DataPropertyName = "strCountryCode"
        Me.StrCountryCodeDataGridViewTextBoxColumn.HeaderText = "strCountryCode"
        Me.StrCountryCodeDataGridViewTextBoxColumn.Name = "StrCountryCodeDataGridViewTextBoxColumn"
        '
        'StrCountryDataGridViewTextBoxColumn
        '
        Me.StrCountryDataGridViewTextBoxColumn.DataPropertyName = "strCountry"
        Me.StrCountryDataGridViewTextBoxColumn.HeaderText = "strCountry"
        Me.StrCountryDataGridViewTextBoxColumn.Name = "StrCountryDataGridViewTextBoxColumn"
        '
        'PlatformDataGridViewTextBoxColumn
        '
        Me.PlatformDataGridViewTextBoxColumn.DataPropertyName = "Platform"
        Me.PlatformDataGridViewTextBoxColumn.HeaderText = "Platform"
        Me.PlatformDataGridViewTextBoxColumn.Name = "PlatformDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPatentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Data As Data
    Friend WithEvents TblPatentsBindingSource As BindingSource
    Friend WithEvents TblPatentsTableAdapter As DataTableAdapters.tblPatentsTableAdapter
    Friend WithEvents IntPatentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PublicationNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PublicationKindCodesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtherTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImagesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OriginalDocumentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InventorsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrentStandardizedAssigneesInventorsRemovedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbstractDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtherAbstractDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PublicationDatesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApplicationDatesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GrantDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IPCInternationalClassificationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StrCountryCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StrCountryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlatformDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
