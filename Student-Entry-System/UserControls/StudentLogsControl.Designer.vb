<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentLogsControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.gridLogs = New System.Windows.Forms.DataGridView()
        CType(Me.gridLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridLogs
        '
        Me.gridLogs.AllowUserToAddRows = False
        Me.gridLogs.AllowUserToDeleteRows = False
        Me.gridLogs.AllowUserToResizeRows = False
        Me.gridLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridLogs.BackgroundColor = System.Drawing.SystemColors.Control
        Me.gridLogs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridLogs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridLogs.Location = New System.Drawing.Point(0, 0)
        Me.gridLogs.MultiSelect = False
        Me.gridLogs.Name = "gridLogs"
        Me.gridLogs.RowHeadersVisible = False
        Me.gridLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridLogs.Size = New System.Drawing.Size(694, 388)
        Me.gridLogs.TabIndex = 0
        '
        'StudentLogsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridLogs)
        Me.Name = "StudentLogsControl"
        Me.Size = New System.Drawing.Size(694, 388)
        CType(Me.gridLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gridLogs As DataGridView
End Class
