Namespace Forms.MasterForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmNewConsultant
#Region "Windows Form Designer generated code "
        <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
            MyBase.New()
            'This call is required by the Windows Form Designer.
            InitializeComponent()
        End Sub
        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
            If Disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(Disposing)
        End Sub
        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer
        Public ToolTip1 As System.Windows.Forms.ToolTip
        Public WithEvents optExaminer As System.Windows.Forms.RadioButton
        Public WithEvents optCons As System.Windows.Forms.RadioButton
        Public WithEvents txtPhone As System.Windows.Forms.TextBox
        Public WithEvents txtZipCode As System.Windows.Forms.TextBox
        Public WithEvents txtCity As System.Windows.Forms.TextBox
        Public WithEvents txtLastName1 As System.Windows.Forms.TextBox
        Public WithEvents txtName As System.Windows.Forms.TextBox
        Public WithEvents txtLastName2 As System.Windows.Forms.TextBox
        Public WithEvents cmdCancel As System.Windows.Forms.Button
        Public WithEvents cmdOK As System.Windows.Forms.Button
        Public WithEvents Frame1 As System.Windows.Forms.GroupBox
        Public WithEvents txtAddress As System.Windows.Forms.TextBox
        Public WithEvents Image1 As System.Windows.Forms.PictureBox
        Public WithEvents Label3 As System.Windows.Forms.Label
        Public WithEvents Label7 As System.Windows.Forms.Label
        Public WithEvents Label6 As System.Windows.Forms.Label
        Public WithEvents Label4 As System.Windows.Forms.Label
        Public WithEvents Label2 As System.Windows.Forms.Label
        Public WithEvents Label1 As System.Windows.Forms.Label
        Public WithEvents Label8 As System.Windows.Forms.Label
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewConsultant))
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.optExaminer = New System.Windows.Forms.RadioButton()
            Me.optCons = New System.Windows.Forms.RadioButton()
            Me.txtPhone = New System.Windows.Forms.TextBox()
            Me.txtZipCode = New System.Windows.Forms.TextBox()
            Me.txtCity = New System.Windows.Forms.TextBox()
            Me.txtLastName1 = New System.Windows.Forms.TextBox()
            Me.txtName = New System.Windows.Forms.TextBox()
            Me.txtLastName2 = New System.Windows.Forms.TextBox()
            Me.Frame1 = New System.Windows.Forms.GroupBox()
            Me.cmdCancel = New System.Windows.Forms.Button()
            Me.cmdOK = New System.Windows.Forms.Button()
            Me.txtAddress = New System.Windows.Forms.TextBox()
            Me.Image1 = New System.Windows.Forms.PictureBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Frame1.SuspendLayout()
            CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'optExaminer
            '
            Me.optExaminer.BackColor = System.Drawing.SystemColors.Control
            Me.optExaminer.Cursor = System.Windows.Forms.Cursors.Default
            Me.optExaminer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.optExaminer.ForeColor = System.Drawing.SystemColors.ControlText
            Me.optExaminer.Location = New System.Drawing.Point(112, 32)
            Me.optExaminer.Name = "optExaminer"
            Me.optExaminer.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.optExaminer.Size = New System.Drawing.Size(121, 18)
            Me.optExaminer.TabIndex = 18
            Me.optExaminer.TabStop = True
            Me.optExaminer.Text = "Examiner"
            Me.optExaminer.UseVisualStyleBackColor = False
            '
            'optCons
            '
            Me.optCons.BackColor = System.Drawing.SystemColors.Control
            Me.optCons.Checked = True
            Me.optCons.Cursor = System.Windows.Forms.Cursors.Default
            Me.optCons.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.optCons.ForeColor = System.Drawing.SystemColors.ControlText
            Me.optCons.Location = New System.Drawing.Point(112, 8)
            Me.optCons.Name = "optCons"
            Me.optCons.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.optCons.Size = New System.Drawing.Size(121, 18)
            Me.optCons.TabIndex = 17
            Me.optCons.TabStop = True
            Me.optCons.Text = "Consultant"
            Me.optCons.UseVisualStyleBackColor = False
            '
            'txtPhone
            '
            Me.txtPhone.AcceptsReturn = True
            Me.txtPhone.BackColor = System.Drawing.SystemColors.Window
            Me.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtPhone.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPhone.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtPhone.Location = New System.Drawing.Point(20, 333)
            Me.txtPhone.MaxLength = 0
            Me.txtPhone.Name = "txtPhone"
            Me.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtPhone.Size = New System.Drawing.Size(137, 20)
            Me.txtPhone.TabIndex = 6
            Me.txtPhone.Tag = "Validate Phone -InvalidValueMsg Invalid Phone number."
            '
            'txtZipCode
            '
            Me.txtZipCode.AcceptsReturn = True
            Me.txtZipCode.BackColor = System.Drawing.SystemColors.Window
            Me.txtZipCode.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtZipCode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtZipCode.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtZipCode.Location = New System.Drawing.Point(156, 285)
            Me.txtZipCode.MaxLength = 0
            Me.txtZipCode.Name = "txtZipCode"
            Me.txtZipCode.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtZipCode.Size = New System.Drawing.Size(89, 20)
            Me.txtZipCode.TabIndex = 5
            Me.txtZipCode.Tag = "Validate ZipCode -InvalidValueMsg Invalid Zip-Code."
            '
            'txtCity
            '
            Me.txtCity.AcceptsReturn = True
            Me.txtCity.BackColor = System.Drawing.SystemColors.Window
            Me.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtCity.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCity.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtCity.Location = New System.Drawing.Point(20, 285)
            Me.txtCity.MaxLength = 0
            Me.txtCity.Name = "txtCity"
            Me.txtCity.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtCity.Size = New System.Drawing.Size(129, 20)
            Me.txtCity.TabIndex = 4
            '
            'txtLastName1
            '
            Me.txtLastName1.AcceptsReturn = True
            Me.txtLastName1.BackColor = System.Drawing.SystemColors.Window
            Me.txtLastName1.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtLastName1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtLastName1.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtLastName1.Location = New System.Drawing.Point(104, 120)
            Me.txtLastName1.MaxLength = 0
            Me.txtLastName1.Name = "txtLastName1"
            Me.txtLastName1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtLastName1.Size = New System.Drawing.Size(145, 20)
            Me.txtLastName1.TabIndex = 1
            Me.txtLastName1.Tag = "Validate Text -Required -AllowAccentuation -AllowLetters -AllowWhiteSpaces -Requi" & _
                                  "redMsg Last Name 1 is a required field! -InvalidValueMsg Last Name 1 field doesn" & _
                                  "'t allow digits or special characters."
            '
            'txtName
            '
            Me.txtName.AcceptsReturn = True
            Me.txtName.BackColor = System.Drawing.SystemColors.Window
            Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtName.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtName.Location = New System.Drawing.Point(104, 80)
            Me.txtName.MaxLength = 0
            Me.txtName.Name = "txtName"
            Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtName.Size = New System.Drawing.Size(145, 20)
            Me.txtName.TabIndex = 0
            Me.txtName.Tag = "Validate Text -Required -AllowAccentuation -AllowLetters -AllowWhiteSpaces -Requi" & _
                             "redMsg Name is a required field! -InvalidValueMsg Name field doesn't allow digit" & _
                             "s or special characters."
            '
            'txtLastName2
            '
            Me.txtLastName2.AcceptsReturn = True
            Me.txtLastName2.BackColor = System.Drawing.SystemColors.Window
            Me.txtLastName2.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtLastName2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtLastName2.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtLastName2.Location = New System.Drawing.Point(104, 160)
            Me.txtLastName2.MaxLength = 0
            Me.txtLastName2.Name = "txtLastName2"
            Me.txtLastName2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtLastName2.Size = New System.Drawing.Size(145, 20)
            Me.txtLastName2.TabIndex = 2
            Me.txtLastName2.Tag = "Validate Text -AllowAccentuation -AllowLetters -AllowWhiteSpaces -RequiredMsg Las" & _
                                  "t Name 2 is a required field! -InvalidValueMsg Last Name 2 field doesn't allow d" & _
                                  "igits or special characters."
            '
            'Frame1
            '
            Me.Frame1.BackColor = System.Drawing.SystemColors.Control
            Me.Frame1.Controls.Add(Me.cmdCancel)
            Me.Frame1.Controls.Add(Me.cmdOK)
            Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Frame1.Location = New System.Drawing.Point(-96, 360)
            Me.Frame1.Name = "Frame1"
            Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
            Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Frame1.Size = New System.Drawing.Size(425, 65)
            Me.Frame1.TabIndex = 13
            Me.Frame1.TabStop = False
            Me.Frame1.Text = "Frame1"
            '
            'cmdCancel
            '
            Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
            Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdCancel.Location = New System.Drawing.Point(288, 16)
            Me.cmdCancel.Name = "cmdCancel"
            Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdCancel.Size = New System.Drawing.Size(81, 25)
            Me.cmdCancel.TabIndex = 16
            Me.cmdCancel.Text = "&Cancel"
            Me.cmdCancel.UseVisualStyleBackColor = False
            '
            'cmdOK
            '
            Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
            Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdOK.Location = New System.Drawing.Point(200, 16)
            Me.cmdOK.Name = "cmdOK"
            Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdOK.Size = New System.Drawing.Size(81, 25)
            Me.cmdOK.TabIndex = 15
            Me.cmdOK.Text = "&OK"
            Me.cmdOK.UseVisualStyleBackColor = False
            '
            'txtAddress
            '
            Me.txtAddress.AcceptsReturn = True
            Me.txtAddress.BackColor = System.Drawing.SystemColors.Window
            Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtAddress.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtAddress.Location = New System.Drawing.Point(16, 200)
            Me.txtAddress.MaxLength = 0
            Me.txtAddress.Multiline = True
            Me.txtAddress.Name = "txtAddress"
            Me.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtAddress.Size = New System.Drawing.Size(233, 59)
            Me.txtAddress.TabIndex = 3
            '
            'Image1
            '
            Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
            Me.Image1.Location = New System.Drawing.Point(24, 8)
            Me.Image1.Name = "Image1"
            Me.Image1.Size = New System.Drawing.Size(32, 32)
            Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.Image1.TabIndex = 19
            Me.Image1.TabStop = False
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.SystemColors.Control
            Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label3.Location = New System.Drawing.Point(-12, 317)
            Me.Label3.Name = "Label3"
            Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label3.Size = New System.Drawing.Size(65, 17)
            Me.Label3.TabIndex = 14
            Me.Label3.Text = "Phone"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.SystemColors.Control
            Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label7.Location = New System.Drawing.Point(156, 269)
            Me.Label7.Name = "Label7"
            Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label7.Size = New System.Drawing.Size(65, 17)
            Me.Label7.TabIndex = 12
            Me.Label7.Text = "Zip-Code"
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.SystemColors.Control
            Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label6.Location = New System.Drawing.Point(-12, 269)
            Me.Label6.Name = "Label6"
            Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label6.Size = New System.Drawing.Size(49, 17)
            Me.Label6.TabIndex = 11
            Me.Label6.Text = "City"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.SystemColors.Control
            Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label4.Location = New System.Drawing.Point(8, 184)
            Me.Label4.Name = "Label4"
            Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label4.Size = New System.Drawing.Size(49, 17)
            Me.Label4.TabIndex = 10
            Me.Label4.Text = "Address"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.SystemColors.Control
            Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label2.Location = New System.Drawing.Point(104, 104)
            Me.Label2.Name = "Label2"
            Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label2.Size = New System.Drawing.Size(65, 17)
            Me.Label2.TabIndex = 9
            Me.Label2.Text = "Last Name 1"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.SystemColors.Control
            Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label1.Location = New System.Drawing.Point(104, 64)
            Me.Label1.Name = "Label1"
            Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label1.Size = New System.Drawing.Size(73, 17)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "Name"
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.SystemColors.Control
            Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label8.Location = New System.Drawing.Point(104, 144)
            Me.Label8.Name = "Label8"
            Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label8.Size = New System.Drawing.Size(65, 17)
            Me.Label8.TabIndex = 7
            Me.Label8.Text = "Last Name 2"
            '
            'frmNewConsultant
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(280, 406)
            Me.Controls.Add(Me.optExaminer)
            Me.Controls.Add(Me.optCons)
            Me.Controls.Add(Me.txtPhone)
            Me.Controls.Add(Me.txtZipCode)
            Me.Controls.Add(Me.txtCity)
            Me.Controls.Add(Me.txtLastName1)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.txtLastName2)
            Me.Controls.Add(Me.Frame1)
            Me.Controls.Add(Me.txtAddress)
            Me.Controls.Add(Me.Image1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label8)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Location = New System.Drawing.Point(3, 22)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmNewConsultant"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Examiner"
            Me.Frame1.ResumeLayout(False)
            CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region
    End Class
End Namespace