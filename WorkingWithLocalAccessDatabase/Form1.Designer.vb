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
        Me.CustomerRecordCountButton = New System.Windows.Forms.Button()
        Me.AddRecordsButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RemoveCurrentButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerRecordCountButton
        '
        Me.CustomerRecordCountButton.Location = New System.Drawing.Point(12, 16)
        Me.CustomerRecordCountButton.Name = "CustomerRecordCountButton"
        Me.CustomerRecordCountButton.Size = New System.Drawing.Size(126, 23)
        Me.CustomerRecordCountButton.TabIndex = 0
        Me.CustomerRecordCountButton.Text = "Customer record count"
        Me.CustomerRecordCountButton.UseVisualStyleBackColor = True
        '
        'AddRecordsButton
        '
        Me.AddRecordsButton.Location = New System.Drawing.Point(204, 16)
        Me.AddRecordsButton.Name = "AddRecordsButton"
        Me.AddRecordsButton.Size = New System.Drawing.Size(126, 23)
        Me.AddRecordsButton.TabIndex = 1
        Me.AddRecordsButton.Text = "Add records"
        Me.AddRecordsButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RemoveCurrentButton)
        Me.Panel1.Controls.Add(Me.CustomerRecordCountButton)
        Me.Panel1.Controls.Add(Me.AddRecordsButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 268)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 58)
        Me.Panel1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(560, 268)
        Me.DataGridView1.TabIndex = 3
        '
        'RemoveCurrentButton
        '
        Me.RemoveCurrentButton.Location = New System.Drawing.Point(422, 16)
        Me.RemoveCurrentButton.Name = "RemoveCurrentButton"
        Me.RemoveCurrentButton.Size = New System.Drawing.Size(126, 23)
        Me.RemoveCurrentButton.TabIndex = 2
        Me.RemoveCurrentButton.Text = "Remove current"
        Me.RemoveCurrentButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 326)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Local MS-Access database"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CustomerRecordCountButton As Button
    Friend WithEvents AddRecordsButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RemoveCurrentButton As Button
End Class
