<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogCalculator
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LoggedOffTime = New System.Windows.Forms.DateTimePicker()
        Me.Break2OffTime = New System.Windows.Forms.DateTimePicker()
        Me.Break2OnTime = New System.Windows.Forms.DateTimePicker()
        Me.LunchOffTime = New System.Windows.Forms.DateTimePicker()
        Me.LunchOnTime = New System.Windows.Forms.DateTimePicker()
        Me.Break1OffTime = New System.Windows.Forms.DateTimePicker()
        Me.Break1OnTime = New System.Windows.Forms.DateTimePicker()
        Me.LoggedOff = New System.Windows.Forms.Label()
        Me.Break2 = New System.Windows.Forms.Label()
        Me.Lunch = New System.Windows.Forms.Label()
        Me.Break1 = New System.Windows.Forms.Label()
        Me.LoggedOn = New System.Windows.Forms.Label()
        Me.LoggedOnTime = New System.Windows.Forms.DateTimePicker()
        Me.blnBreak1 = New System.Windows.Forms.CheckBox()
        Me.blnLunch = New System.Windows.Forms.CheckBox()
        Me.blnBreak2 = New System.Windows.Forms.CheckBox()
        Me.TotalHours = New System.Windows.Forms.Label()
        Me.lblBreak = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.34375!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.65625!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LoggedOffTime, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Break2OffTime, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Break2OnTime, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LunchOffTime, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LunchOnTime, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Break1OnTime, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LoggedOff, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Break2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Lunch, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Break1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LoggedOn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.blnBreak1, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.blnLunch, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.blnBreak2, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LoggedOnTime, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Break1OffTime, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(28, 50)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(480, 268)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LoggedOffTime
        '
        Me.LoggedOffTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoggedOffTime.CustomFormat = "HH:mm"
        Me.LoggedOffTime.Location = New System.Drawing.Point(275, 226)
        Me.LoggedOffTime.Name = "LoggedOffTime"
        Me.LoggedOffTime.ShowUpDown = True
        Me.LoggedOffTime.Size = New System.Drawing.Size(128, 26)
        Me.LoggedOffTime.TabIndex = 7
        '
        'Break2OffTime
        '
        Me.Break2OffTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Break2OffTime.CustomFormat = "HH:mm"
        Me.Break2OffTime.Location = New System.Drawing.Point(275, 170)
        Me.Break2OffTime.Name = "Break2OffTime"
        Me.Break2OffTime.ShowUpDown = True
        Me.Break2OffTime.Size = New System.Drawing.Size(128, 26)
        Me.Break2OffTime.TabIndex = 11
        '
        'Break2OnTime
        '
        Me.Break2OnTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Break2OnTime.CustomFormat = "HH:mm"
        Me.Break2OnTime.Location = New System.Drawing.Point(145, 170)
        Me.Break2OnTime.Name = "Break2OnTime"
        Me.Break2OnTime.ShowUpDown = True
        Me.Break2OnTime.Size = New System.Drawing.Size(124, 26)
        Me.Break2OnTime.TabIndex = 10
        '
        'LunchOffTime
        '
        Me.LunchOffTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LunchOffTime.CustomFormat = "HH:mm"
        Me.LunchOffTime.Location = New System.Drawing.Point(275, 115)
        Me.LunchOffTime.Name = "LunchOffTime"
        Me.LunchOffTime.ShowUpDown = True
        Me.LunchOffTime.Size = New System.Drawing.Size(128, 26)
        Me.LunchOffTime.TabIndex = 9
        '
        'LunchOnTime
        '
        Me.LunchOnTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LunchOnTime.CustomFormat = "HH:mm"
        Me.LunchOnTime.Location = New System.Drawing.Point(145, 115)
        Me.LunchOnTime.Name = "LunchOnTime"
        Me.LunchOnTime.ShowUpDown = True
        Me.LunchOnTime.Size = New System.Drawing.Size(124, 26)
        Me.LunchOnTime.TabIndex = 8
        '
        'Break1OffTime
        '
        Me.Break1OffTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Break1OffTime.CustomFormat = "HH:mm"
        Me.Break1OffTime.Location = New System.Drawing.Point(275, 62)
        Me.Break1OffTime.Name = "Break1OffTime"
        Me.Break1OffTime.ShowUpDown = True
        Me.Break1OffTime.Size = New System.Drawing.Size(128, 26)
        Me.Break1OffTime.TabIndex = 7
        '
        'Break1OnTime
        '
        Me.Break1OnTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Break1OnTime.CustomFormat = "HH:mm"
        Me.Break1OnTime.Location = New System.Drawing.Point(145, 62)
        Me.Break1OnTime.Name = "Break1OnTime"
        Me.Break1OnTime.ShowUpDown = True
        Me.Break1OnTime.Size = New System.Drawing.Size(124, 26)
        Me.Break1OnTime.TabIndex = 6
        '
        'LoggedOff
        '
        Me.LoggedOff.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoggedOff.AutoSize = True
        Me.LoggedOff.Location = New System.Drawing.Point(26, 229)
        Me.LoggedOff.Name = "LoggedOff"
        Me.LoggedOff.Size = New System.Drawing.Size(89, 20)
        Me.LoggedOff.TabIndex = 4
        Me.LoggedOff.Text = "Logged Off"
        Me.LoggedOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Break2
        '
        Me.Break2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Break2.AutoSize = True
        Me.Break2.Location = New System.Drawing.Point(34, 173)
        Me.Break2.Name = "Break2"
        Me.Break2.Size = New System.Drawing.Size(73, 20)
        Me.Break2.TabIndex = 3
        Me.Break2.Text = "Break #2"
        Me.Break2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lunch
        '
        Me.Lunch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lunch.AutoSize = True
        Me.Lunch.Location = New System.Drawing.Point(44, 118)
        Me.Lunch.Name = "Lunch"
        Me.Lunch.Size = New System.Drawing.Size(53, 20)
        Me.Lunch.TabIndex = 2
        Me.Lunch.Text = "Lunch"
        Me.Lunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Break1
        '
        Me.Break1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Break1.AutoSize = True
        Me.Break1.Location = New System.Drawing.Point(34, 65)
        Me.Break1.Name = "Break1"
        Me.Break1.Size = New System.Drawing.Size(73, 20)
        Me.Break1.TabIndex = 1
        Me.Break1.Text = "Break #1"
        Me.Break1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoggedOn
        '
        Me.LoggedOn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoggedOn.AutoSize = True
        Me.LoggedOn.Location = New System.Drawing.Point(27, 15)
        Me.LoggedOn.Name = "LoggedOn"
        Me.LoggedOn.Size = New System.Drawing.Size(88, 20)
        Me.LoggedOn.TabIndex = 0
        Me.LoggedOn.Text = "Logged On"
        Me.LoggedOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoggedOnTime
        '
        Me.LoggedOnTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoggedOnTime.CustomFormat = "HH:mm"
        Me.LoggedOnTime.Location = New System.Drawing.Point(275, 12)
        Me.LoggedOnTime.Name = "LoggedOnTime"
        Me.LoggedOnTime.ShowUpDown = True
        Me.LoggedOnTime.Size = New System.Drawing.Size(128, 26)
        Me.LoggedOnTime.TabIndex = 5
        '
        'blnBreak1
        '
        Me.blnBreak1.AutoSize = True
        Me.blnBreak1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.blnBreak1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.blnBreak1.Location = New System.Drawing.Point(409, 53)
        Me.blnBreak1.Name = "blnBreak1"
        Me.blnBreak1.Size = New System.Drawing.Size(68, 44)
        Me.blnBreak1.TabIndex = 12
        Me.blnBreak1.UseVisualStyleBackColor = True
        '
        'blnLunch
        '
        Me.blnLunch.AutoSize = True
        Me.blnLunch.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.blnLunch.Checked = True
        Me.blnLunch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.blnLunch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.blnLunch.Location = New System.Drawing.Point(409, 103)
        Me.blnLunch.Name = "blnLunch"
        Me.blnLunch.Size = New System.Drawing.Size(68, 50)
        Me.blnLunch.TabIndex = 13
        Me.blnLunch.UseVisualStyleBackColor = True
        '
        'blnBreak2
        '
        Me.blnBreak2.AutoSize = True
        Me.blnBreak2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.blnBreak2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.blnBreak2.Location = New System.Drawing.Point(409, 159)
        Me.blnBreak2.Name = "blnBreak2"
        Me.blnBreak2.Size = New System.Drawing.Size(68, 48)
        Me.blnBreak2.TabIndex = 14
        Me.blnBreak2.UseVisualStyleBackColor = True
        '
        'TotalHours
        '
        Me.TotalHours.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalHours.AutoSize = True
        Me.TotalHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalHours.Location = New System.Drawing.Point(36, 348)
        Me.TotalHours.Name = "TotalHours"
        Me.TotalHours.Size = New System.Drawing.Size(131, 25)
        Me.TotalHours.TabIndex = 1
        Me.TotalHours.Text = "Total Hours:"
        '
        'lblBreak
        '
        Me.lblBreak.AutoSize = True
        Me.lblBreak.Location = New System.Drawing.Point(435, 27)
        Me.lblBreak.Name = "lblBreak"
        Me.lblBreak.Size = New System.Drawing.Size(70, 20)
        Me.lblBreak.TabIndex = 2
        Me.lblBreak.Text = "Include?"
        '
        'LogCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(548, 406)
        Me.Controls.Add(Me.lblBreak)
        Me.Controls.Add(Me.TotalHours)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "LogCalculator"
        Me.Text = "LogCalculator"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
    Friend WithEvents LoggedOff As Windows.Forms.Label
    Friend WithEvents Break2 As Windows.Forms.Label
    Friend WithEvents Lunch As Windows.Forms.Label
    Friend WithEvents Break1 As Windows.Forms.Label
    Friend WithEvents LoggedOn As Windows.Forms.Label
    Friend WithEvents TotalHours As Windows.Forms.Label
    Friend WithEvents LoggedOnTime As Windows.Forms.DateTimePicker
    Friend WithEvents LoggedOffTime As Windows.Forms.DateTimePicker
    Friend WithEvents Break2OffTime As Windows.Forms.DateTimePicker
    Friend WithEvents Break2OnTime As Windows.Forms.DateTimePicker
    Friend WithEvents LunchOffTime As Windows.Forms.DateTimePicker
    Friend WithEvents LunchOnTime As Windows.Forms.DateTimePicker
    Friend WithEvents Break1OffTime As Windows.Forms.DateTimePicker
    Friend WithEvents Break1OnTime As Windows.Forms.DateTimePicker
    Friend WithEvents blnBreak1 As Windows.Forms.CheckBox
    Friend WithEvents blnLunch As Windows.Forms.CheckBox
    Friend WithEvents blnBreak2 As Windows.Forms.CheckBox
    Friend WithEvents lblBreak As Windows.Forms.Label
End Class
