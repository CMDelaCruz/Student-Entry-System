<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainControl
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdminTools = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnAccManager = New System.Windows.Forms.Button()
        Me.btnLogs = New System.Windows.Forms.Button()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.controlPanel = New System.Windows.Forms.Panel()
        Me.studentInformationPanel = New System.Windows.Forms.Panel()
        Me.studentPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEditStudent = New System.Windows.Forms.Button()
        Me.btnRegisterStudent = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.controlPanel.SuspendLayout()
        Me.studentInformationPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnAdminTools)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.btnAccManager)
        Me.Panel1.Controls.Add(Me.btnLogs)
        Me.Panel1.Controls.Add(Me.btnRecords)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 542)
        Me.Panel1.TabIndex = 0
        '
        'btnAdminTools
        '
        Me.btnAdminTools.BackColor = System.Drawing.Color.Transparent
        Me.btnAdminTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAdminTools.FlatAppearance.BorderSize = 0
        Me.btnAdminTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminTools.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminTools.ForeColor = System.Drawing.Color.White
        Me.btnAdminTools.Location = New System.Drawing.Point(0, 150)
        Me.btnAdminTools.Name = "btnAdminTools"
        Me.btnAdminTools.Size = New System.Drawing.Size(238, 50)
        Me.btnAdminTools.TabIndex = 4
        Me.btnAdminTools.Text = "Administrator Tools"
        Me.btnAdminTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdminTools.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Location = New System.Drawing.Point(0, 492)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(238, 50)
        Me.btnLogOut.TabIndex = 3
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnAccManager
        '
        Me.btnAccManager.BackColor = System.Drawing.Color.Transparent
        Me.btnAccManager.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccManager.FlatAppearance.BorderSize = 0
        Me.btnAccManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccManager.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccManager.ForeColor = System.Drawing.Color.White
        Me.btnAccManager.Location = New System.Drawing.Point(0, 100)
        Me.btnAccManager.Name = "btnAccManager"
        Me.btnAccManager.Size = New System.Drawing.Size(238, 50)
        Me.btnAccManager.TabIndex = 1
        Me.btnAccManager.Text = "My Account"
        Me.btnAccManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccManager.UseVisualStyleBackColor = False
        '
        'btnLogs
        '
        Me.btnLogs.BackColor = System.Drawing.Color.Transparent
        Me.btnLogs.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogs.FlatAppearance.BorderSize = 0
        Me.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogs.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogs.ForeColor = System.Drawing.Color.White
        Me.btnLogs.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnLogs.Location = New System.Drawing.Point(0, 50)
        Me.btnLogs.Name = "btnLogs"
        Me.btnLogs.Size = New System.Drawing.Size(238, 50)
        Me.btnLogs.TabIndex = 2
        Me.btnLogs.Text = "Student Logs"
        Me.btnLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogs.UseVisualStyleBackColor = False
        '
        'btnRecords
        '
        Me.btnRecords.BackColor = System.Drawing.Color.Transparent
        Me.btnRecords.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRecords.FlatAppearance.BorderSize = 0
        Me.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecords.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecords.ForeColor = System.Drawing.Color.White
        Me.btnRecords.Location = New System.Drawing.Point(0, 0)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(238, 50)
        Me.btnRecords.TabIndex = 0
        Me.btnRecords.Text = "Student Information Records"
        Me.btnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecords.UseVisualStyleBackColor = False
        '
        'controlPanel
        '
        Me.controlPanel.Controls.Add(Me.studentInformationPanel)
        Me.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.controlPanel.Location = New System.Drawing.Point(238, 0)
        Me.controlPanel.Name = "controlPanel"
        Me.controlPanel.Size = New System.Drawing.Size(724, 542)
        Me.controlPanel.TabIndex = 1
        '
        'studentInformationPanel
        '
        Me.studentInformationPanel.Controls.Add(Me.studentPanel)
        Me.studentInformationPanel.Controls.Add(Me.Panel2)
        Me.studentInformationPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.studentInformationPanel.Location = New System.Drawing.Point(0, 0)
        Me.studentInformationPanel.Name = "studentInformationPanel"
        Me.studentInformationPanel.Size = New System.Drawing.Size(724, 542)
        Me.studentInformationPanel.TabIndex = 0
        '
        'studentPanel
        '
        Me.studentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.studentPanel.Location = New System.Drawing.Point(121, 0)
        Me.studentPanel.Name = "studentPanel"
        Me.studentPanel.Size = New System.Drawing.Size(603, 542)
        Me.studentPanel.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnEditStudent)
        Me.Panel2.Controls.Add(Me.btnRegisterStudent)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(121, 542)
        Me.Panel2.TabIndex = 1
        '
        'btnEditStudent
        '
        Me.btnEditStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnEditStudent.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEditStudent.FlatAppearance.BorderSize = 0
        Me.btnEditStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditStudent.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditStudent.ForeColor = System.Drawing.Color.White
        Me.btnEditStudent.Location = New System.Drawing.Point(0, 50)
        Me.btnEditStudent.Name = "btnEditStudent"
        Me.btnEditStudent.Size = New System.Drawing.Size(121, 50)
        Me.btnEditStudent.TabIndex = 0
        Me.btnEditStudent.Text = "Student List"
        Me.btnEditStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditStudent.UseVisualStyleBackColor = False
        '
        'btnRegisterStudent
        '
        Me.btnRegisterStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnRegisterStudent.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegisterStudent.FlatAppearance.BorderSize = 0
        Me.btnRegisterStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegisterStudent.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisterStudent.ForeColor = System.Drawing.Color.White
        Me.btnRegisterStudent.Location = New System.Drawing.Point(0, 0)
        Me.btnRegisterStudent.Name = "btnRegisterStudent"
        Me.btnRegisterStudent.Size = New System.Drawing.Size(121, 50)
        Me.btnRegisterStudent.TabIndex = 0
        Me.btnRegisterStudent.Text = "Add Student"
        Me.btnRegisterStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegisterStudent.UseVisualStyleBackColor = False
        '
        'MainControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.controlPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MainControl"
        Me.Size = New System.Drawing.Size(962, 542)
        Me.Panel1.ResumeLayout(False)
        Me.controlPanel.ResumeLayout(False)
        Me.studentInformationPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnLogs As Button
    Friend WithEvents btnAccManager As Button
    Friend WithEvents btnRecords As Button
    Friend WithEvents controlPanel As Panel
    Friend WithEvents studentInformationPanel As Panel
    Friend WithEvents btnEditStudent As Button
    Friend WithEvents btnRegisterStudent As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents studentPanel As Panel
    Friend WithEvents btnAdminTools As Button
End Class
