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
        Me.components = New System.ComponentModel.Container()
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.tbxAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.tbxCnum = New System.Windows.Forms.TextBox()
        Me.lblCnum = New System.Windows.Forms.Label()
        Me.tbxTemp = New System.Windows.Forms.TextBox()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.gbxGender = New System.Windows.Forms.GroupBox()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.gbxVacc = New System.Windows.Forms.GroupBox()
        Me.rad2booster = New System.Windows.Forms.RadioButton()
        Me.radNotyet = New System.Windows.Forms.RadioButton()
        Me.rad2dose = New System.Windows.Forms.RadioButton()
        Me.radBooster = New System.Windows.Forms.RadioButton()
        Me.rad1dose = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.cbxFever = New System.Windows.Forms.CheckBox()
        Me.gbxQuestion = New System.Windows.Forms.GroupBox()
        Me.cbxCoughs = New System.Windows.Forms.CheckBox()
        Me.cbxBreathComp = New System.Windows.Forms.CheckBox()
        Me.cbxColds = New System.Windows.Forms.CheckBox()
        Me.cbxSorethroat = New System.Windows.Forms.CheckBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cbxIdont = New System.Windows.Forms.CheckBox()
        Me.tbxDisplay = New System.Windows.Forms.TextBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.tbxFind = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.pictBxQRCapture = New System.Windows.Forms.PictureBox()
        Me.lblQrtext = New System.Windows.Forms.Label()
        Me.btnQRScan = New System.Windows.Forms.Button()
        Me.cbCamDevice = New System.Windows.Forms.ComboBox()
        Me.TimeScanner = New System.Windows.Forms.Timer(Me.components)
        Me.gbxGender.SuspendLayout()
        Me.gbxVacc.SuspendLayout()
        Me.gbxQuestion.SuspendLayout()
        CType(Me.pictBxQRCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbxName
        '
        Me.tbxName.Location = New System.Drawing.Point(139, 42)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(183, 27)
        Me.tbxName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblName.Location = New System.Drawing.Point(3, 45)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        '
        'tbxAddress
        '
        Me.tbxAddress.Location = New System.Drawing.Point(139, 86)
        Me.tbxAddress.Name = "tbxAddress"
        Me.tbxAddress.Size = New System.Drawing.Size(183, 27)
        Me.tbxAddress.TabIndex = 1
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAddress.Location = New System.Drawing.Point(3, 89)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(70, 20)
        Me.lblAddress.TabIndex = 1
        Me.lblAddress.Text = "Address:"
        '
        'tbxCnum
        '
        Me.tbxCnum.Location = New System.Drawing.Point(139, 136)
        Me.tbxCnum.Name = "tbxCnum"
        Me.tbxCnum.Size = New System.Drawing.Size(183, 27)
        Me.tbxCnum.TabIndex = 2
        '
        'lblCnum
        '
        Me.lblCnum.AutoSize = True
        Me.lblCnum.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCnum.Location = New System.Drawing.Point(3, 139)
        Me.lblCnum.Name = "lblCnum"
        Me.lblCnum.Size = New System.Drawing.Size(130, 20)
        Me.lblCnum.TabIndex = 1
        Me.lblCnum.Text = "Contact Number:"
        '
        'tbxTemp
        '
        Me.tbxTemp.Location = New System.Drawing.Point(139, 184)
        Me.tbxTemp.Name = "tbxTemp"
        Me.tbxTemp.Size = New System.Drawing.Size(183, 27)
        Me.tbxTemp.TabIndex = 3
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTemp.Location = New System.Drawing.Point(3, 184)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(103, 20)
        Me.lblTemp.TabIndex = 1
        Me.lblTemp.Text = "Temperature:"
        '
        'gbxGender
        '
        Me.gbxGender.BackColor = System.Drawing.Color.Violet
        Me.gbxGender.Controls.Add(Me.radFemale)
        Me.gbxGender.Controls.Add(Me.radMale)
        Me.gbxGender.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gbxGender.Location = New System.Drawing.Point(27, 240)
        Me.gbxGender.Name = "gbxGender"
        Me.gbxGender.Size = New System.Drawing.Size(294, 72)
        Me.gbxGender.TabIndex = 20
        Me.gbxGender.TabStop = False
        Me.gbxGender.Text = "Gender:"
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.radFemale.Location = New System.Drawing.Point(192, 26)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(78, 24)
        Me.radFemale.TabIndex = 5
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.radMale.Location = New System.Drawing.Point(87, 26)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(63, 24)
        Me.radMale.TabIndex = 4
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'gbxVacc
        '
        Me.gbxVacc.BackColor = System.Drawing.Color.Violet
        Me.gbxVacc.Controls.Add(Me.rad2booster)
        Me.gbxVacc.Controls.Add(Me.radNotyet)
        Me.gbxVacc.Controls.Add(Me.rad2dose)
        Me.gbxVacc.Controls.Add(Me.radBooster)
        Me.gbxVacc.Controls.Add(Me.rad1dose)
        Me.gbxVacc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gbxVacc.Location = New System.Drawing.Point(31, 335)
        Me.gbxVacc.Name = "gbxVacc"
        Me.gbxVacc.Size = New System.Drawing.Size(289, 118)
        Me.gbxVacc.TabIndex = 21
        Me.gbxVacc.TabStop = False
        Me.gbxVacc.Text = "Vaccination:"
        '
        'rad2booster
        '
        Me.rad2booster.AutoSize = True
        Me.rad2booster.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rad2booster.Location = New System.Drawing.Point(145, 53)
        Me.rad2booster.Name = "rad2booster"
        Me.rad2booster.Size = New System.Drawing.Size(110, 24)
        Me.rad2booster.TabIndex = 9
        Me.rad2booster.TabStop = True
        Me.rad2booster.Text = "2nd Booster"
        Me.rad2booster.UseVisualStyleBackColor = True
        '
        'radNotyet
        '
        Me.radNotyet.AutoSize = True
        Me.radNotyet.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.radNotyet.Location = New System.Drawing.Point(67, 83)
        Me.radNotyet.Name = "radNotyet"
        Me.radNotyet.Size = New System.Drawing.Size(79, 24)
        Me.radNotyet.TabIndex = 10
        Me.radNotyet.TabStop = True
        Me.radNotyet.Text = "Not yet"
        Me.radNotyet.UseVisualStyleBackColor = True
        '
        'rad2dose
        '
        Me.rad2dose.AutoSize = True
        Me.rad2dose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rad2dose.Location = New System.Drawing.Point(3, 53)
        Me.rad2dose.Name = "rad2dose"
        Me.rad2dose.Size = New System.Drawing.Size(93, 24)
        Me.rad2dose.TabIndex = 8
        Me.rad2dose.TabStop = True
        Me.rad2dose.Text = "2nd Dose"
        Me.rad2dose.UseVisualStyleBackColor = True
        '
        'radBooster
        '
        Me.radBooster.AutoSize = True
        Me.radBooster.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.radBooster.Location = New System.Drawing.Point(145, 23)
        Me.radBooster.Name = "radBooster"
        Me.radBooster.Size = New System.Drawing.Size(81, 24)
        Me.radBooster.TabIndex = 7
        Me.radBooster.TabStop = True
        Me.radBooster.Text = "Booster"
        Me.radBooster.UseVisualStyleBackColor = True
        '
        'rad1dose
        '
        Me.rad1dose.AutoSize = True
        Me.rad1dose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rad1dose.Location = New System.Drawing.Point(3, 23)
        Me.rad1dose.Name = "rad1dose"
        Me.rad1dose.Size = New System.Drawing.Size(87, 24)
        Me.rad1dose.TabIndex = 6
        Me.rad1dose.TabStop = True
        Me.rad1dose.Text = "1st Dose"
        Me.rad1dose.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSubmit.Location = New System.Drawing.Point(98, 639)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(99, 43)
        Me.btnSubmit.TabIndex = 24
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'cbxFever
        '
        Me.cbxFever.AutoSize = True
        Me.cbxFever.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbxFever.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbxFever.Location = New System.Drawing.Point(16, 26)
        Me.cbxFever.Name = "cbxFever"
        Me.cbxFever.Size = New System.Drawing.Size(66, 24)
        Me.cbxFever.TabIndex = 11
        Me.cbxFever.Text = "Fever"
        Me.cbxFever.UseVisualStyleBackColor = True
        '
        'gbxQuestion
        '
        Me.gbxQuestion.BackColor = System.Drawing.Color.Violet
        Me.gbxQuestion.Controls.Add(Me.cbxCoughs)
        Me.gbxQuestion.Controls.Add(Me.cbxBreathComp)
        Me.gbxQuestion.Controls.Add(Me.cbxColds)
        Me.gbxQuestion.Controls.Add(Me.cbxSorethroat)
        Me.gbxQuestion.Controls.Add(Me.cbxFever)
        Me.gbxQuestion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gbxQuestion.Location = New System.Drawing.Point(27, 467)
        Me.gbxQuestion.Name = "gbxQuestion"
        Me.gbxQuestion.Size = New System.Drawing.Size(294, 120)
        Me.gbxQuestion.TabIndex = 22
        Me.gbxQuestion.TabStop = False
        Me.gbxQuestion.Text = "Do you have any of these?"
        '
        'cbxCoughs
        '
        Me.cbxCoughs.AutoSize = True
        Me.cbxCoughs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbxCoughs.Location = New System.Drawing.Point(16, 56)
        Me.cbxCoughs.Name = "cbxCoughs"
        Me.cbxCoughs.Size = New System.Drawing.Size(80, 24)
        Me.cbxCoughs.TabIndex = 12
        Me.cbxCoughs.Text = "Coughs"
        Me.cbxCoughs.UseVisualStyleBackColor = True
        '
        'cbxBreathComp
        '
        Me.cbxBreathComp.AutoSize = True
        Me.cbxBreathComp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbxBreathComp.Location = New System.Drawing.Point(16, 86)
        Me.cbxBreathComp.Name = "cbxBreathComp"
        Me.cbxBreathComp.Size = New System.Drawing.Size(194, 24)
        Me.cbxBreathComp.TabIndex = 13
        Me.cbxBreathComp.Text = "Breathing Complications"
        Me.cbxBreathComp.UseVisualStyleBackColor = True
        '
        'cbxColds
        '
        Me.cbxColds.AutoSize = True
        Me.cbxColds.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbxColds.Location = New System.Drawing.Point(168, 56)
        Me.cbxColds.Name = "cbxColds"
        Me.cbxColds.Size = New System.Drawing.Size(68, 24)
        Me.cbxColds.TabIndex = 15
        Me.cbxColds.Text = "Colds"
        Me.cbxColds.UseVisualStyleBackColor = True
        '
        'cbxSorethroat
        '
        Me.cbxSorethroat.AutoSize = True
        Me.cbxSorethroat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbxSorethroat.Location = New System.Drawing.Point(168, 26)
        Me.cbxSorethroat.Name = "cbxSorethroat"
        Me.cbxSorethroat.Size = New System.Drawing.Size(108, 24)
        Me.cbxSorethroat.TabIndex = 14
        Me.cbxSorethroat.Text = "Sore Throat"
        Me.cbxSorethroat.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(62, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(224, 19)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "CONTACT TRACING FORM"
        '
        'cbxIdont
        '
        Me.cbxIdont.AutoSize = True
        Me.cbxIdont.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.cbxIdont.Location = New System.Drawing.Point(43, 593)
        Me.cbxIdont.Name = "cbxIdont"
        Me.cbxIdont.Size = New System.Drawing.Size(199, 24)
        Me.cbxIdont.TabIndex = 23
        Me.cbxIdont.Text = "I don't have any of these"
        Me.cbxIdont.UseVisualStyleBackColor = True
        '
        'tbxDisplay
        '
        Me.tbxDisplay.Location = New System.Drawing.Point(822, 100)
        Me.tbxDisplay.Multiline = True
        Me.tbxDisplay.Name = "tbxDisplay"
        Me.tbxDisplay.Size = New System.Drawing.Size(392, 447)
        Me.tbxDisplay.TabIndex = 25
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnView.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnView.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnView.Location = New System.Drawing.Point(957, 565)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(129, 38)
        Me.btnView.TabIndex = 26
        Me.btnView.Text = "VIEW"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'tbxFind
        '
        Me.tbxFind.Location = New System.Drawing.Point(938, 47)
        Me.tbxFind.Name = "tbxFind"
        Me.tbxFind.Size = New System.Drawing.Size(224, 27)
        Me.tbxFind.TabIndex = 27
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnFind.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFind.Location = New System.Drawing.Point(838, 45)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(94, 29)
        Me.btnFind.TabIndex = 28
        Me.btnFind.Text = "FIND"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'pictBxQRCapture
        '
        Me.pictBxQRCapture.Location = New System.Drawing.Point(373, 100)
        Me.pictBxQRCapture.Name = "pictBxQRCapture"
        Me.pictBxQRCapture.Size = New System.Drawing.Size(403, 338)
        Me.pictBxQRCapture.TabIndex = 29
        Me.pictBxQRCapture.TabStop = False
        '
        'lblQrtext
        '
        Me.lblQrtext.AutoSize = True
        Me.lblQrtext.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblQrtext.Location = New System.Drawing.Point(401, 22)
        Me.lblQrtext.Name = "lblQrtext"
        Me.lblQrtext.Size = New System.Drawing.Size(360, 26)
        Me.lblQrtext.TabIndex = 30
        Me.lblQrtext.Text = "Use QR Scanner to fiil the form"
        '
        'btnQRScan
        '
        Me.btnQRScan.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnQRScan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnQRScan.Location = New System.Drawing.Point(504, 444)
        Me.btnQRScan.Name = "btnQRScan"
        Me.btnQRScan.Size = New System.Drawing.Size(129, 38)
        Me.btnQRScan.TabIndex = 31
        Me.btnQRScan.Text = "QR SCAN"
        Me.btnQRScan.UseVisualStyleBackColor = False
        '
        'cbCamDevice
        '
        Me.cbCamDevice.FormattingEnabled = True
        Me.cbCamDevice.Location = New System.Drawing.Point(452, 58)
        Me.cbCamDevice.Name = "cbCamDevice"
        Me.cbCamDevice.Size = New System.Drawing.Size(232, 28)
        Me.cbCamDevice.TabIndex = 32
        '
        'TimeScanner
        '
        Me.TimeScanner.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(1251, 720)
        Me.Controls.Add(Me.cbCamDevice)
        Me.Controls.Add(Me.btnQRScan)
        Me.Controls.Add(Me.lblQrtext)
        Me.Controls.Add(Me.pictBxQRCapture)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.tbxFind)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.tbxDisplay)
        Me.Controls.Add(Me.cbxIdont)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.gbxQuestion)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.gbxVacc)
        Me.Controls.Add(Me.gbxGender)
        Me.Controls.Add(Me.lblTemp)
        Me.Controls.Add(Me.lblCnum)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.tbxTemp)
        Me.Controls.Add(Me.tbxCnum)
        Me.Controls.Add(Me.tbxAddress)
        Me.Controls.Add(Me.tbxName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contact Tracing QR Reader"
        Me.gbxGender.ResumeLayout(False)
        Me.gbxGender.PerformLayout()
        Me.gbxVacc.ResumeLayout(False)
        Me.gbxVacc.PerformLayout()
        Me.gbxQuestion.ResumeLayout(False)
        Me.gbxQuestion.PerformLayout()
        CType(Me.pictBxQRCapture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents tbxAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents tbxCnum As TextBox
    Friend WithEvents lblCnum As Label
    Friend WithEvents tbxTemp As TextBox
    Friend WithEvents lblTemp As Label
    Friend WithEvents gbxGender As GroupBox
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents gbxVacc As GroupBox
    Friend WithEvents rad2booster As RadioButton
    Friend WithEvents radNotyet As RadioButton
    Friend WithEvents rad2dose As RadioButton
    Friend WithEvents radBooster As RadioButton
    Friend WithEvents rad1dose As RadioButton
    Friend WithEvents btnSubmit As Button
    Friend WithEvents cbxFever As CheckBox
    Friend WithEvents gbxQuestion As GroupBox
    Friend WithEvents cbxCoughs As CheckBox
    Friend WithEvents cbxBreathComp As CheckBox
    Friend WithEvents cbxColds As CheckBox
    Friend WithEvents cbxSorethroat As CheckBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents cbxIdont As CheckBox
    Friend WithEvents tbxDisplay As TextBox
    Friend WithEvents btnView As Button
    Friend WithEvents tbxFind As TextBox
    Friend WithEvents btnFind As Button
    Friend WithEvents pictBxQRCapture As PictureBox
    Friend WithEvents lblQrtext As Label
    Friend WithEvents btnQRScan As Button
    Friend WithEvents cbCamDevice As ComboBox
    Friend WithEvents TimeScanner As Timer
End Class
