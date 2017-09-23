<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MasterControl
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
        Me.tbcTools = New System.Windows.Forms.TabControl()
        Me.tpEventLogs = New System.Windows.Forms.TabPage()
        Me.dgvEvents = New System.Windows.Forms.DataGridView()
        Me.tpAdminAccManager = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAddAcc = New System.Windows.Forms.Button()
        Me.btnManage = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbAdmin = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbMaster = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbMaster = New System.Windows.Forms.TextBox()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbEmployeeID = New System.Windows.Forms.TextBox()
        Me.tbLastname = New System.Windows.Forms.TextBox()
        Me.tbFirstname = New System.Windows.Forms.TextBox()
        Me.tbMiddlename = New System.Windows.Forms.TextBox()
        Me.adminList = New System.Windows.Forms.DataGridView()
        Me.tpAdminTools = New System.Windows.Forms.TabPage()
        Me.tbcTools.SuspendLayout()
        Me.tpEventLogs.SuspendLayout()
        CType(Me.dgvEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAdminAccManager.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.adminList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcTools
        '
        Me.tbcTools.Controls.Add(Me.tpEventLogs)
        Me.tbcTools.Controls.Add(Me.tpAdminAccManager)
        Me.tbcTools.Controls.Add(Me.tpAdminTools)
        Me.tbcTools.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcTools.ItemSize = New System.Drawing.Size(66, 20)
        Me.tbcTools.Location = New System.Drawing.Point(0, 0)
        Me.tbcTools.Name = "tbcTools"
        Me.tbcTools.SelectedIndex = 0
        Me.tbcTools.Size = New System.Drawing.Size(844, 519)
        Me.tbcTools.TabIndex = 0
        '
        'tpEventLogs
        '
        Me.tpEventLogs.Controls.Add(Me.dgvEvents)
        Me.tpEventLogs.Location = New System.Drawing.Point(4, 24)
        Me.tpEventLogs.Name = "tpEventLogs"
        Me.tpEventLogs.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEventLogs.Size = New System.Drawing.Size(836, 491)
        Me.tpEventLogs.TabIndex = 0
        Me.tpEventLogs.Text = "Event Logs"
        Me.tpEventLogs.UseVisualStyleBackColor = True
        '
        'dgvEvents
        '
        Me.dgvEvents.AllowUserToAddRows = False
        Me.dgvEvents.AllowUserToDeleteRows = False
        Me.dgvEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEvents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEvents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEvents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvEvents.Location = New System.Drawing.Point(3, 3)
        Me.dgvEvents.MultiSelect = False
        Me.dgvEvents.Name = "dgvEvents"
        Me.dgvEvents.ReadOnly = True
        Me.dgvEvents.RowHeadersVisible = False
        Me.dgvEvents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEvents.Size = New System.Drawing.Size(830, 485)
        Me.dgvEvents.TabIndex = 1
        '
        'tpAdminAccManager
        '
        Me.tpAdminAccManager.Controls.Add(Me.TableLayoutPanel1)
        Me.tpAdminAccManager.Controls.Add(Me.Panel2)
        Me.tpAdminAccManager.Controls.Add(Me.adminList)
        Me.tpAdminAccManager.Location = New System.Drawing.Point(4, 24)
        Me.tpAdminAccManager.Name = "tpAdminAccManager"
        Me.tpAdminAccManager.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAdminAccManager.Size = New System.Drawing.Size(836, 491)
        Me.tpAdminAccManager.TabIndex = 1
        Me.tpAdminAccManager.Text = "Administrator Manager"
        Me.tpAdminAccManager.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnAddAcc, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnManage, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(241, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(592, 56)
        Me.TableLayoutPanel1.TabIndex = 23
        '
        'btnAddAcc
        '
        Me.btnAddAcc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAcc.Location = New System.Drawing.Point(3, 3)
        Me.btnAddAcc.Name = "btnAddAcc"
        Me.btnAddAcc.Size = New System.Drawing.Size(290, 50)
        Me.btnAddAcc.TabIndex = 1
        Me.btnAddAcc.Text = "Add Account"
        Me.btnAddAcc.UseVisualStyleBackColor = True
        '
        'btnManage
        '
        Me.btnManage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManage.Location = New System.Drawing.Point(299, 3)
        Me.btnManage.Name = "btnManage"
        Me.btnManage.Size = New System.Drawing.Size(290, 50)
        Me.btnManage.TabIndex = 0
        Me.btnManage.Text = "Manage Account"
        Me.btnManage.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.rbAdmin)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.rbMaster)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.tbMaster)
        Me.Panel2.Controls.Add(Me.tbUsername)
        Me.Panel2.Controls.Add(Me.tbPassword)
        Me.Panel2.Controls.Add(Me.tbEmployeeID)
        Me.Panel2.Controls.Add(Me.tbLastname)
        Me.Panel2.Controls.Add(Me.tbFirstname)
        Me.Panel2.Controls.Add(Me.tbMiddlename)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(241, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(592, 485)
        Me.Panel2.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(75, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 18)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Employee ID"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'rbAdmin
        '
        Me.rbAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.rbAdmin.AutoSize = True
        Me.rbAdmin.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAdmin.Location = New System.Drawing.Point(213, 321)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(66, 22)
        Me.rbAdmin.TabIndex = 19
        Me.rbAdmin.TabStop = True
        Me.rbAdmin.Text = "Admin"
        Me.rbAdmin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(75, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Middle Name"
        '
        'rbMaster
        '
        Me.rbMaster.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.rbMaster.AutoSize = True
        Me.rbMaster.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMaster.Location = New System.Drawing.Point(285, 321)
        Me.rbMaster.Name = "rbMaster"
        Me.rbMaster.Size = New System.Drawing.Size(74, 22)
        Me.rbMaster.TabIndex = 18
        Me.rbMaster.TabStop = True
        Me.rbMaster.Text = "Master"
        Me.rbMaster.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Last Name"
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEdit.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(213, 427)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(95, 29)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(75, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Password"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(415, 427)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(95, 29)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(75, 323)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 18)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Level"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(314, 427)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 29)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(75, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Master Key"
        '
        'tbMaster
        '
        Me.tbMaster.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tbMaster.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMaster.Location = New System.Drawing.Point(213, 361)
        Me.tbMaster.Name = "tbMaster"
        Me.tbMaster.Size = New System.Drawing.Size(297, 25)
        Me.tbMaster.TabIndex = 2
        '
        'tbUsername
        '
        Me.tbUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tbUsername.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsername.Location = New System.Drawing.Point(213, 134)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(297, 25)
        Me.tbUsername.TabIndex = 2
        '
        'tbPassword
        '
        Me.tbPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tbPassword.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(213, 282)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(297, 25)
        Me.tbPassword.TabIndex = 2
        '
        'tbEmployeeID
        '
        Me.tbEmployeeID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tbEmployeeID.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmployeeID.Location = New System.Drawing.Point(213, 97)
        Me.tbEmployeeID.Name = "tbEmployeeID"
        Me.tbEmployeeID.Size = New System.Drawing.Size(297, 25)
        Me.tbEmployeeID.TabIndex = 2
        '
        'tbLastname
        '
        Me.tbLastname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tbLastname.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLastname.Location = New System.Drawing.Point(213, 245)
        Me.tbLastname.Name = "tbLastname"
        Me.tbLastname.Size = New System.Drawing.Size(297, 25)
        Me.tbLastname.TabIndex = 2
        '
        'tbFirstname
        '
        Me.tbFirstname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tbFirstname.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFirstname.Location = New System.Drawing.Point(213, 171)
        Me.tbFirstname.Name = "tbFirstname"
        Me.tbFirstname.Size = New System.Drawing.Size(297, 25)
        Me.tbFirstname.TabIndex = 2
        '
        'tbMiddlename
        '
        Me.tbMiddlename.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tbMiddlename.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMiddlename.Location = New System.Drawing.Point(213, 208)
        Me.tbMiddlename.Name = "tbMiddlename"
        Me.tbMiddlename.Size = New System.Drawing.Size(297, 25)
        Me.tbMiddlename.TabIndex = 2
        '
        'adminList
        '
        Me.adminList.AllowUserToAddRows = False
        Me.adminList.AllowUserToDeleteRows = False
        Me.adminList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.adminList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.adminList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.adminList.Dock = System.Windows.Forms.DockStyle.Left
        Me.adminList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.adminList.Location = New System.Drawing.Point(3, 3)
        Me.adminList.MultiSelect = False
        Me.adminList.Name = "adminList"
        Me.adminList.ReadOnly = True
        Me.adminList.RowHeadersVisible = False
        Me.adminList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.adminList.Size = New System.Drawing.Size(238, 485)
        Me.adminList.TabIndex = 20
        '
        'tpAdminTools
        '
        Me.tpAdminTools.Location = New System.Drawing.Point(4, 24)
        Me.tpAdminTools.Name = "tpAdminTools"
        Me.tpAdminTools.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAdminTools.Size = New System.Drawing.Size(836, 491)
        Me.tpAdminTools.TabIndex = 2
        Me.tpAdminTools.Text = "Administrator Tools"
        Me.tpAdminTools.UseVisualStyleBackColor = True
        '
        'MasterControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbcTools)
        Me.Name = "MasterControl"
        Me.Size = New System.Drawing.Size(844, 519)
        Me.tbcTools.ResumeLayout(False)
        Me.tpEventLogs.ResumeLayout(False)
        CType(Me.dgvEvents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpAdminAccManager.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.adminList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcTools As TabControl
    Friend WithEvents tpEventLogs As TabPage
    Friend WithEvents tpAdminAccManager As TabPage
    Friend WithEvents tpAdminTools As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbMaster As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents tbLastname As TextBox
    Friend WithEvents tbMiddlename As TextBox
    Friend WithEvents tbFirstname As TextBox
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents tbEmployeeID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbMaster As RadioButton
    Friend WithEvents adminList As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnAddAcc As Button
    Friend WithEvents dgvEvents As DataGridView
    Friend WithEvents btnManage As Button
End Class
