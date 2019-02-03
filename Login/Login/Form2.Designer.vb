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
        Me.DataBaseDataSet = New Login.DataBaseDataSet()
        Me.DataBaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataBaseDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataBaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBaseDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataBaseDataSet
        '
        Me.DataBaseDataSet.DataSetName = "DataBaseDataSet"
        Me.DataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataBaseDataSetBindingSource
        '
        Me.DataBaseDataSetBindingSource.DataSource = Me.DataBaseDataSet
        Me.DataBaseDataSetBindingSource.Position = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.DataBaseDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(381, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(430, 348)
        Me.DataGridView1.TabIndex = 0
        '
        'DataBaseDataSetBindingSource1
        '
        Me.DataBaseDataSetBindingSource1.DataSource = Me.DataBaseDataSet
        Me.DataBaseDataSetBindingSource1.Position = 0
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 443)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataBaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBaseDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataBaseDataSet As Login.DataBaseDataSet
    Friend WithEvents DataBaseDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataBaseDataSetBindingSource1 As System.Windows.Forms.BindingSource
End Class
