<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tb_path = New System.Windows.Forms.TextBox()
        Me.L001 = New System.Windows.Forms.Label()
        Me.btn_make_updatePack = New System.Windows.Forms.Button()
        Me.tb_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl_working = New System.Windows.Forms.Panel()
        Me.lbl_task = New System.Windows.Forms.Label()
        Me.lbl_progress = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnl_finished = New System.Windows.Forms.Panel()
        Me.lbl_finished = New System.Windows.Forms.Label()
        Me.lbl_packagename = New System.Windows.Forms.Label()
        Me.tmr_finished = New System.Windows.Forms.Timer(Me.components)
        Me.rBtn_ver_normal = New System.Windows.Forms.RadioButton()
        Me.rBtn_ver_tesla = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numupdown_build = New System.Windows.Forms.NumericUpDown()
        Me.pnl_working.SuspendLayout()
        Me.pnl_finished.SuspendLayout()
        CType(Me.numupdown_build, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_path
        '
        Me.tb_path.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.tb_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_path.ForeColor = System.Drawing.Color.White
        Me.tb_path.Location = New System.Drawing.Point(12, 29)
        Me.tb_path.Name = "tb_path"
        Me.tb_path.Size = New System.Drawing.Size(522, 20)
        Me.tb_path.TabIndex = 0
        '
        'L001
        '
        Me.L001.AutoSize = True
        Me.L001.Location = New System.Drawing.Point(12, 11)
        Me.L001.Name = "L001"
        Me.L001.Size = New System.Drawing.Size(84, 13)
        Me.L001.TabIndex = 1
        Me.L001.Text = "Source directory"
        '
        'btn_make_updatePack
        '
        Me.btn_make_updatePack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_make_updatePack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_make_updatePack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_make_updatePack.Location = New System.Drawing.Point(416, 100)
        Me.btn_make_updatePack.Name = "btn_make_updatePack"
        Me.btn_make_updatePack.Size = New System.Drawing.Size(118, 23)
        Me.btn_make_updatePack.TabIndex = 2
        Me.btn_make_updatePack.Text = "Create update ZIP"
        Me.btn_make_updatePack.UseVisualStyleBackColor = True
        '
        'tb_name
        '
        Me.tb_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_name.ForeColor = System.Drawing.Color.White
        Me.tb_name.Location = New System.Drawing.Point(12, 73)
        Me.tb_name.MaxLength = 50
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Size = New System.Drawing.Size(200, 20)
        Me.tb_name.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'pnl_working
        '
        Me.pnl_working.Controls.Add(Me.lbl_task)
        Me.pnl_working.Controls.Add(Me.lbl_progress)
        Me.pnl_working.Controls.Add(Me.Label2)
        Me.pnl_working.Location = New System.Drawing.Point(0, 0)
        Me.pnl_working.Name = "pnl_working"
        Me.pnl_working.Size = New System.Drawing.Size(546, 136)
        Me.pnl_working.TabIndex = 4
        '
        'lbl_task
        '
        Me.lbl_task.ForeColor = System.Drawing.Color.DarkGray
        Me.lbl_task.Location = New System.Drawing.Point(66, 83)
        Me.lbl_task.Name = "lbl_task"
        Me.lbl_task.Size = New System.Drawing.Size(415, 23)
        Me.lbl_task.TabIndex = 5
        Me.lbl_task.Text = "<nothing>"
        Me.lbl_task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_progress
        '
        Me.lbl_progress.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lbl_progress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.lbl_progress.Location = New System.Drawing.Point(66, 55)
        Me.lbl_progress.Name = "lbl_progress"
        Me.lbl_progress.Size = New System.Drawing.Size(415, 23)
        Me.lbl_progress.TabIndex = 4
        Me.lbl_progress.Text = "0%"
        Me.lbl_progress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(66, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(415, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Please wait, while the update-package is being created..."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_finished
        '
        Me.pnl_finished.Controls.Add(Me.lbl_finished)
        Me.pnl_finished.Location = New System.Drawing.Point(0, 0)
        Me.pnl_finished.Name = "pnl_finished"
        Me.pnl_finished.Size = New System.Drawing.Size(546, 136)
        Me.pnl_finished.TabIndex = 5
        '
        'lbl_finished
        '
        Me.lbl_finished.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_finished.Location = New System.Drawing.Point(0, 0)
        Me.lbl_finished.Name = "lbl_finished"
        Me.lbl_finished.Size = New System.Drawing.Size(546, 136)
        Me.lbl_finished.TabIndex = 0
        Me.lbl_finished.Text = "Created update package successfully!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "File placed on your Desktop"
        Me.lbl_finished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_packagename
        '
        Me.lbl_packagename.AutoSize = True
        Me.lbl_packagename.Location = New System.Drawing.Point(12, 110)
        Me.lbl_packagename.Name = "lbl_packagename"
        Me.lbl_packagename.Size = New System.Drawing.Size(64, 13)
        Me.lbl_packagename.TabIndex = 1
        Me.lbl_packagename.Text = "<zip_name>"
        '
        'tmr_finished
        '
        Me.tmr_finished.Interval = 2500
        '
        'rBtn_ver_normal
        '
        Me.rBtn_ver_normal.AutoSize = True
        Me.rBtn_ver_normal.Location = New System.Drawing.Point(293, 77)
        Me.rBtn_ver_normal.Name = "rBtn_ver_normal"
        Me.rBtn_ver_normal.Size = New System.Drawing.Size(58, 17)
        Me.rBtn_ver_normal.TabIndex = 5
        Me.rBtn_ver_normal.TabStop = True
        Me.rBtn_ver_normal.Text = "Normal"
        Me.rBtn_ver_normal.UseVisualStyleBackColor = True
        '
        'rBtn_ver_tesla
        '
        Me.rBtn_ver_tesla.AutoSize = True
        Me.rBtn_ver_tesla.Location = New System.Drawing.Point(293, 100)
        Me.rBtn_ver_tesla.Name = "rBtn_ver_tesla"
        Me.rBtn_ver_tesla.Size = New System.Drawing.Size(51, 17)
        Me.rBtn_ver_tesla.TabIndex = 5
        Me.rBtn_ver_tesla.TabStop = True
        Me.rBtn_ver_tesla.Text = "Tesla"
        Me.rBtn_ver_tesla.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(290, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Versioning"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(215, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Build"
        '
        'numupdown_build
        '
        Me.numupdown_build.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.numupdown_build.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numupdown_build.ForeColor = System.Drawing.Color.White
        Me.numupdown_build.Location = New System.Drawing.Point(218, 73)
        Me.numupdown_build.Name = "numupdown_build"
        Me.numupdown_build.Size = New System.Drawing.Size(50, 20)
        Me.numupdown_build.TabIndex = 9
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(546, 135)
        Me.Controls.Add(Me.pnl_finished)
        Me.Controls.Add(Me.pnl_working)
        Me.Controls.Add(Me.btn_make_updatePack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_packagename)
        Me.Controls.Add(Me.L001)
        Me.Controls.Add(Me.tb_name)
        Me.Controls.Add(Me.tb_path)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rBtn_ver_tesla)
        Me.Controls.Add(Me.rBtn_ver_normal)
        Me.Controls.Add(Me.numupdown_build)
        Me.Controls.Add(Me.Label4)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Packer"
        Me.pnl_working.ResumeLayout(False)
        Me.pnl_finished.ResumeLayout(False)
        CType(Me.numupdown_build, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_path As TextBox
    Friend WithEvents L001 As Label
    Friend WithEvents btn_make_updatePack As Button
    Friend WithEvents tb_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnl_working As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_progress As Label
    Friend WithEvents lbl_task As Label
    Friend WithEvents lbl_packagename As Label
    Friend WithEvents tmr_finished As Timer
    Friend WithEvents pnl_finished As Panel
    Friend WithEvents lbl_finished As Label
    Friend WithEvents rBtn_ver_normal As RadioButton
    Friend WithEvents rBtn_ver_tesla As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents numupdown_build As NumericUpDown
End Class
