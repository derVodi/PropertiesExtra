'
' Created by SharpDevelop.
' User: Zappa
' Date: 03.03.2013
' Time: 21:58
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.gExtensionLabel = New System.Windows.Forms.Label()
		Me.gExtension = New System.Windows.Forms.TextBox()
		Me.gModifiedLabel = New System.Windows.Forms.Label()
		Me.gCreatedLabel = New System.Windows.Forms.Label()
		Me.gModified = New System.Windows.Forms.DateTimePicker()
		Me.gCreated = New System.Windows.Forms.DateTimePicker()
		Me.gLastAccessLabel = New System.Windows.Forms.Label()
		Me.gLastAccess = New System.Windows.Forms.DateTimePicker()
		Me.gCloseButton = New System.Windows.Forms.Button()
		Me.gSetButton = New System.Windows.Forms.Button()
		Me.gSetCreated = New System.Windows.Forms.CheckBox()
		Me.gSetModified = New System.Windows.Forms.CheckBox()
		Me.gSetLastAccess = New System.Windows.Forms.CheckBox()
		Me.gSetExtension = New System.Windows.Forms.CheckBox()
		Me.gFilesLabel = New System.Windows.Forms.Label()
		Me.gFiles = New System.Windows.Forms.Label()
		Me.gModeLabel = New System.Windows.Forms.Label()
		Me.gRelative = New System.Windows.Forms.RadioButton()
		Me.gAbsolute = New System.Windows.Forms.RadioButton()
		Me.gToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.gCopyButton = New System.Windows.Forms.Button()
		Me.gPasteButton = New System.Windows.Forms.Button()
		Me.gTimeStampsLabel = New System.Windows.Forms.Label()
		Me.gCreatedHour = New Properties_Extra.PimpedNumericUpDown()
		Me.gCreatedMinute = New Properties_Extra.PimpedNumericUpDown()
		Me.gCreatedSecond = New Properties_Extra.PimpedNumericUpDown()
		Me.gCreatedMillisecond = New Properties_Extra.PimpedNumericUpDown()
		Me.gModifiedHour = New Properties_Extra.PimpedNumericUpDown()
		Me.gModifiedMinute = New Properties_Extra.PimpedNumericUpDown()
		Me.gModifiedSecond = New Properties_Extra.PimpedNumericUpDown()
		Me.gModifiedMillisecond = New Properties_Extra.PimpedNumericUpDown()
		Me.gLastAccessHour = New Properties_Extra.PimpedNumericUpDown()
		Me.gLastAccessMinute = New Properties_Extra.PimpedNumericUpDown()
		Me.gLastAccessSecond = New Properties_Extra.PimpedNumericUpDown()
		Me.gLastAccessMillisecond = New Properties_Extra.PimpedNumericUpDown()
		Me.gInfoLabel = New System.Windows.Forms.Label()
		CType(Me.gCreatedHour, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gCreatedMinute, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gCreatedSecond, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gCreatedMillisecond, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gModifiedHour, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gModifiedMinute, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gModifiedSecond, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gModifiedMillisecond, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gLastAccessHour, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gLastAccessMinute, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gLastAccessSecond, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gLastAccessMillisecond, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'gExtensionLabel
		'
		Me.gExtensionLabel.Location = New System.Drawing.Point(9, 36)
		Me.gExtensionLabel.Name = "gExtensionLabel"
		Me.gExtensionLabel.Size = New System.Drawing.Size(100, 23)
		Me.gExtensionLabel.TabIndex = 2
		Me.gExtensionLabel.Text = "Extension"
		Me.gExtensionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'gExtension
		'
		Me.gExtension.Location = New System.Drawing.Point(121, 38)
		Me.gExtension.Name = "gExtension"
		Me.gExtension.Size = New System.Drawing.Size(359, 21)
		Me.gExtension.TabIndex = 3
		'
		'gModifiedLabel
		'
		Me.gModifiedLabel.AutoSize = True
		Me.gModifiedLabel.Location = New System.Drawing.Point(9, 94)
		Me.gModifiedLabel.Name = "gModifiedLabel"
		Me.gModifiedLabel.Size = New System.Drawing.Size(47, 13)
		Me.gModifiedLabel.TabIndex = 12
		Me.gModifiedLabel.Text = "Modified"
		Me.gModifiedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'gCreatedLabel
		'
		Me.gCreatedLabel.AutoSize = True
		Me.gCreatedLabel.Location = New System.Drawing.Point(9, 68)
		Me.gCreatedLabel.Name = "gCreatedLabel"
		Me.gCreatedLabel.Size = New System.Drawing.Size(46, 13)
		Me.gCreatedLabel.TabIndex = 5
		Me.gCreatedLabel.Text = "Created"
		Me.gCreatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'gModified
		'
		Me.gModified.Location = New System.Drawing.Point(121, 90)
		Me.gModified.Name = "gModified"
		Me.gModified.Size = New System.Drawing.Size(200, 21)
		Me.gModified.TabIndex = 13
		'
		'gCreated
		'
		Me.gCreated.Location = New System.Drawing.Point(121, 64)
		Me.gCreated.Name = "gCreated"
		Me.gCreated.Size = New System.Drawing.Size(200, 21)
		Me.gCreated.TabIndex = 6
		'
		'gLastAccessLabel
		'
		Me.gLastAccessLabel.AutoSize = True
		Me.gLastAccessLabel.Location = New System.Drawing.Point(9, 120)
		Me.gLastAccessLabel.Name = "gLastAccessLabel"
		Me.gLastAccessLabel.Size = New System.Drawing.Size(62, 13)
		Me.gLastAccessLabel.TabIndex = 19
		Me.gLastAccessLabel.Text = "Last access"
		'
		'gLastAccess
		'
		Me.gLastAccess.Location = New System.Drawing.Point(121, 116)
		Me.gLastAccess.Name = "gLastAccess"
		Me.gLastAccess.Size = New System.Drawing.Size(200, 21)
		Me.gLastAccess.TabIndex = 20
		'
		'gCloseButton
		'
		Me.gCloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.gCloseButton.Location = New System.Drawing.Point(439, 165)
		Me.gCloseButton.Name = "gCloseButton"
		Me.gCloseButton.Size = New System.Drawing.Size(75, 23)
		Me.gCloseButton.TabIndex = 33
		Me.gCloseButton.Text = "Cancel"
		Me.gCloseButton.UseVisualStyleBackColor = True
		'
		'gSetButton
		'
		Me.gSetButton.Location = New System.Drawing.Point(358, 166)
		Me.gSetButton.Name = "gSetButton"
		Me.gSetButton.Size = New System.Drawing.Size(75, 23)
		Me.gSetButton.TabIndex = 32
		Me.gSetButton.Text = "Set"
		Me.gSetButton.UseVisualStyleBackColor = True
		'
		'gSetCreated
		'
		Me.gSetCreated.Location = New System.Drawing.Point(486, 64)
		Me.gSetCreated.Name = "gSetCreated"
		Me.gSetCreated.Size = New System.Drawing.Size(47, 24)
		Me.gSetCreated.TabIndex = 11
		Me.gSetCreated.Text = "Set"
		Me.gSetCreated.UseVisualStyleBackColor = True
		'
		'gSetModified
		'
		Me.gSetModified.Location = New System.Drawing.Point(486, 90)
		Me.gSetModified.Name = "gSetModified"
		Me.gSetModified.Size = New System.Drawing.Size(47, 24)
		Me.gSetModified.TabIndex = 18
		Me.gSetModified.Text = "Set"
		Me.gSetModified.UseVisualStyleBackColor = True
		'
		'gSetLastAccess
		'
		Me.gSetLastAccess.Location = New System.Drawing.Point(486, 116)
		Me.gSetLastAccess.Name = "gSetLastAccess"
		Me.gSetLastAccess.Size = New System.Drawing.Size(47, 24)
		Me.gSetLastAccess.TabIndex = 25
		Me.gSetLastAccess.Text = "Set"
		Me.gSetLastAccess.UseVisualStyleBackColor = True
		'
		'gSetExtension
		'
		Me.gSetExtension.Location = New System.Drawing.Point(486, 38)
		Me.gSetExtension.Name = "gSetExtension"
		Me.gSetExtension.Size = New System.Drawing.Size(47, 24)
		Me.gSetExtension.TabIndex = 4
		Me.gSetExtension.Text = "Set"
		Me.gSetExtension.UseVisualStyleBackColor = True
		'
		'gFilesLabel
		'
		Me.gFilesLabel.Location = New System.Drawing.Point(9, 9)
		Me.gFilesLabel.Name = "gFilesLabel"
		Me.gFilesLabel.Size = New System.Drawing.Size(100, 23)
		Me.gFilesLabel.TabIndex = 0
		Me.gFilesLabel.Text = "Files"
		Me.gFilesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'gFiles
		'
		Me.gFiles.Location = New System.Drawing.Point(121, 9)
		Me.gFiles.Name = "gFiles"
		Me.gFiles.Size = New System.Drawing.Size(100, 23)
		Me.gFiles.TabIndex = 1
		Me.gFiles.Text = "<gFiles>"
		Me.gFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'gModeLabel
		'
		Me.gModeLabel.Location = New System.Drawing.Point(9, 169)
		Me.gModeLabel.Name = "gModeLabel"
		Me.gModeLabel.Size = New System.Drawing.Size(108, 23)
		Me.gModeLabel.TabIndex = 29
		Me.gModeLabel.Text = "Date Changing Mode"
		Me.gModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'gRelative
		'
		Me.gRelative.AutoSize = True
		Me.gRelative.Checked = True
		Me.gRelative.Location = New System.Drawing.Point(124, 172)
		Me.gRelative.Name = "gRelative"
		Me.gRelative.Size = New System.Drawing.Size(64, 17)
		Me.gRelative.TabIndex = 30
		Me.gRelative.TabStop = True
		Me.gRelative.Text = "Relative"
		Me.gToolTip.SetToolTip(Me.gRelative, resources.GetString("gRelative.ToolTip"))
		Me.gRelative.UseVisualStyleBackColor = True
		'
		'gAbsolute
		'
		Me.gAbsolute.AutoSize = True
		Me.gAbsolute.Location = New System.Drawing.Point(194, 172)
		Me.gAbsolute.Name = "gAbsolute"
		Me.gAbsolute.Size = New System.Drawing.Size(67, 17)
		Me.gAbsolute.TabIndex = 31
		Me.gAbsolute.Text = "Absolute"
		Me.gToolTip.SetToolTip(Me.gAbsolute, "All files will get the date entered above." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Afterwards they will all have the sam" &
				"e date" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- destroying the initial time line.")
		Me.gAbsolute.UseVisualStyleBackColor = True
		'
		'gToolTip
		'
		Me.gToolTip.AutoPopDelay = 30000
		Me.gToolTip.InitialDelay = 500
		Me.gToolTip.ReshowDelay = 100
		'
		'gCopyButton
		'
		Me.gCopyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.gCopyButton.Location = New System.Drawing.Point(121, 143)
		Me.gCopyButton.Name = "gCopyButton"
		Me.gCopyButton.Size = New System.Drawing.Size(75, 23)
		Me.gCopyButton.TabIndex = 27
		Me.gCopyButton.Text = "Copy"
		Me.gCopyButton.UseVisualStyleBackColor = True
		'
		'gPasteButton
		'
		Me.gPasteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.gPasteButton.Location = New System.Drawing.Point(202, 143)
		Me.gPasteButton.Name = "gPasteButton"
		Me.gPasteButton.Size = New System.Drawing.Size(75, 23)
		Me.gPasteButton.TabIndex = 28
		Me.gPasteButton.Text = "Paste"
		Me.gPasteButton.UseVisualStyleBackColor = True
		'
		'gTimeStampsLabel
		'
		Me.gTimeStampsLabel.Location = New System.Drawing.Point(9, 143)
		Me.gTimeStampsLabel.Name = "gTimeStampsLabel"
		Me.gTimeStampsLabel.Size = New System.Drawing.Size(100, 23)
		Me.gTimeStampsLabel.TabIndex = 26
		Me.gTimeStampsLabel.Text = "Time Stamps"
		Me.gTimeStampsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'gCreatedHour
		'
		Me.gCreatedHour.Location = New System.Drawing.Point(323, 64)
		Me.gCreatedHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
		Me.gCreatedHour.Name = "gCreatedHour"
		Me.gCreatedHour.Size = New System.Drawing.Size(36, 21)
		Me.gCreatedHour.Slave = Nothing
		Me.gCreatedHour.TabIndex = 7
		'
		'gCreatedMinute
		'
		Me.gCreatedMinute.Location = New System.Drawing.Point(360, 64)
		Me.gCreatedMinute.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
		Me.gCreatedMinute.Name = "gCreatedMinute"
		Me.gCreatedMinute.Size = New System.Drawing.Size(36, 21)
		Me.gCreatedMinute.Slave = Nothing
		Me.gCreatedMinute.TabIndex = 8
		'
		'gCreatedSecond
		'
		Me.gCreatedSecond.Location = New System.Drawing.Point(397, 64)
		Me.gCreatedSecond.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
		Me.gCreatedSecond.Name = "gCreatedSecond"
		Me.gCreatedSecond.Size = New System.Drawing.Size(36, 21)
		Me.gCreatedSecond.Slave = Nothing
		Me.gCreatedSecond.TabIndex = 9
		'
		'gCreatedMillisecond
		'
		Me.gCreatedMillisecond.Location = New System.Drawing.Point(438, 64)
		Me.gCreatedMillisecond.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
		Me.gCreatedMillisecond.Name = "gCreatedMillisecond"
		Me.gCreatedMillisecond.Size = New System.Drawing.Size(42, 21)
		Me.gCreatedMillisecond.Slave = Nothing
		Me.gCreatedMillisecond.TabIndex = 10
		'
		'gModifiedHour
		'
		Me.gModifiedHour.Location = New System.Drawing.Point(323, 90)
		Me.gModifiedHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
		Me.gModifiedHour.Name = "gModifiedHour"
		Me.gModifiedHour.Size = New System.Drawing.Size(36, 21)
		Me.gModifiedHour.Slave = Nothing
		Me.gModifiedHour.TabIndex = 14
		'
		'gModifiedMinute
		'
		Me.gModifiedMinute.Location = New System.Drawing.Point(360, 90)
		Me.gModifiedMinute.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
		Me.gModifiedMinute.Name = "gModifiedMinute"
		Me.gModifiedMinute.Size = New System.Drawing.Size(36, 21)
		Me.gModifiedMinute.Slave = Nothing
		Me.gModifiedMinute.TabIndex = 15
		'
		'gModifiedSecond
		'
		Me.gModifiedSecond.Location = New System.Drawing.Point(397, 90)
		Me.gModifiedSecond.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
		Me.gModifiedSecond.Name = "gModifiedSecond"
		Me.gModifiedSecond.Size = New System.Drawing.Size(36, 21)
		Me.gModifiedSecond.Slave = Nothing
		Me.gModifiedSecond.TabIndex = 16
		'
		'gModifiedMillisecond
		'
		Me.gModifiedMillisecond.Location = New System.Drawing.Point(438, 90)
		Me.gModifiedMillisecond.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
		Me.gModifiedMillisecond.Name = "gModifiedMillisecond"
		Me.gModifiedMillisecond.Size = New System.Drawing.Size(42, 21)
		Me.gModifiedMillisecond.Slave = Nothing
		Me.gModifiedMillisecond.TabIndex = 17
		'
		'gLastAccessHour
		'
		Me.gLastAccessHour.Location = New System.Drawing.Point(323, 116)
		Me.gLastAccessHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
		Me.gLastAccessHour.Name = "gLastAccessHour"
		Me.gLastAccessHour.Size = New System.Drawing.Size(36, 21)
		Me.gLastAccessHour.Slave = Nothing
		Me.gLastAccessHour.TabIndex = 21
		'
		'gLastAccessMinute
		'
		Me.gLastAccessMinute.Location = New System.Drawing.Point(360, 116)
		Me.gLastAccessMinute.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
		Me.gLastAccessMinute.Name = "gLastAccessMinute"
		Me.gLastAccessMinute.Size = New System.Drawing.Size(36, 21)
		Me.gLastAccessMinute.Slave = Nothing
		Me.gLastAccessMinute.TabIndex = 22
		'
		'gLastAccessSecond
		'
		Me.gLastAccessSecond.Location = New System.Drawing.Point(397, 116)
		Me.gLastAccessSecond.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
		Me.gLastAccessSecond.Name = "gLastAccessSecond"
		Me.gLastAccessSecond.Size = New System.Drawing.Size(36, 21)
		Me.gLastAccessSecond.Slave = Nothing
		Me.gLastAccessSecond.TabIndex = 23
		'
		'gLastAccessMillisecond
		'
		Me.gLastAccessMillisecond.Location = New System.Drawing.Point(438, 116)
		Me.gLastAccessMillisecond.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
		Me.gLastAccessMillisecond.Name = "gLastAccessMillisecond"
		Me.gLastAccessMillisecond.Size = New System.Drawing.Size(42, 21)
		Me.gLastAccessMillisecond.Slave = Nothing
		Me.gLastAccessMillisecond.TabIndex = 24
		'
		'gInfoLabel
		'
		Me.gInfoLabel.Cursor = System.Windows.Forms.Cursors.Hand
		Me.gInfoLabel.ForeColor = System.Drawing.Color.Blue
		Me.gInfoLabel.Location = New System.Drawing.Point(487, 9)
		Me.gInfoLabel.Name = "gInfoLabel"
		Me.gInfoLabel.Size = New System.Drawing.Size(30, 23)
		Me.gInfoLabel.TabIndex = 34
		Me.gInfoLabel.Text = "Info"
		Me.gInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'MainForm
		'
		Me.AcceptButton = Me.gSetButton
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.gCloseButton
		Me.ClientSize = New System.Drawing.Size(536, 200)
		Me.Controls.Add(Me.gFilesLabel)
		Me.Controls.Add(Me.gFiles)
		Me.Controls.Add(Me.gInfoLabel)
		Me.Controls.Add(Me.gExtensionLabel)
		Me.Controls.Add(Me.gExtension)
		Me.Controls.Add(Me.gSetExtension)
		Me.Controls.Add(Me.gCreatedLabel)
		Me.Controls.Add(Me.gCreated)
		Me.Controls.Add(Me.gCreatedHour)
		Me.Controls.Add(Me.gCreatedMinute)
		Me.Controls.Add(Me.gCreatedSecond)
		Me.Controls.Add(Me.gCreatedMillisecond)
		Me.Controls.Add(Me.gSetCreated)
		Me.Controls.Add(Me.gModifiedLabel)
		Me.Controls.Add(Me.gModified)
		Me.Controls.Add(Me.gModifiedHour)
		Me.Controls.Add(Me.gModifiedMinute)
		Me.Controls.Add(Me.gModifiedSecond)
		Me.Controls.Add(Me.gModifiedMillisecond)
		Me.Controls.Add(Me.gSetModified)
		Me.Controls.Add(Me.gLastAccessLabel)
		Me.Controls.Add(Me.gLastAccess)
		Me.Controls.Add(Me.gLastAccessHour)
		Me.Controls.Add(Me.gLastAccessMinute)
		Me.Controls.Add(Me.gLastAccessSecond)
		Me.Controls.Add(Me.gLastAccessMillisecond)
		Me.Controls.Add(Me.gSetLastAccess)
		Me.Controls.Add(Me.gTimeStampsLabel)
		Me.Controls.Add(Me.gCopyButton)
		Me.Controls.Add(Me.gPasteButton)
		Me.Controls.Add(Me.gModeLabel)
		Me.Controls.Add(Me.gRelative)
		Me.Controls.Add(Me.gAbsolute)
		Me.Controls.Add(Me.gSetButton)
		Me.Controls.Add(Me.gCloseButton)
		Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "MainForm"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Properties Extra"
		CType(Me.gCreatedHour, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gCreatedMinute, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gCreatedSecond, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gCreatedMillisecond, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gModifiedHour, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gModifiedMinute, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gModifiedSecond, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gModifiedMillisecond, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gLastAccessHour, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gLastAccessMinute, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gLastAccessSecond, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gLastAccessMillisecond, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Private gSetLastAccess As System.Windows.Forms.CheckBox
	Private gSetModified As System.Windows.Forms.CheckBox
	Private gSetCreated As System.Windows.Forms.CheckBox
	Private WithEvents gSetButton As System.Windows.Forms.Button
	Private WithEvents gCloseButton As System.Windows.Forms.Button
	Private WithEvents gLastAccess As System.Windows.Forms.DateTimePicker
	Private gLastAccessLabel As System.Windows.Forms.Label
	Private WithEvents gCreated As System.Windows.Forms.DateTimePicker
	Private WithEvents gModified As System.Windows.Forms.DateTimePicker
	Private gCreatedLabel As System.Windows.Forms.Label
	Private gModifiedLabel As System.Windows.Forms.Label
	Private WithEvents gExtension As System.Windows.Forms.TextBox
	Private gExtensionLabel As System.Windows.Forms.Label
	Private WithEvents gSetExtension As System.Windows.Forms.CheckBox
	Private WithEvents gFilesLabel As System.Windows.Forms.Label
	Private WithEvents gFiles As System.Windows.Forms.Label
	Private WithEvents gModeLabel As System.Windows.Forms.Label
	Friend WithEvents gRelative As System.Windows.Forms.RadioButton
	Friend WithEvents gAbsolute As System.Windows.Forms.RadioButton
	Friend WithEvents gCreatedHour As PimpedNumericUpDown
	Friend WithEvents gCreatedMinute As PimpedNumericUpDown
	Friend WithEvents gCreatedSecond As PimpedNumericUpDown
	Friend WithEvents gCreatedMillisecond As PimpedNumericUpDown
	Friend WithEvents gModifiedHour As PimpedNumericUpDown
	Friend WithEvents gModifiedMinute As PimpedNumericUpDown
	Friend WithEvents gModifiedSecond As PimpedNumericUpDown
	Friend WithEvents gModifiedMillisecond As PimpedNumericUpDown
	Friend WithEvents gLastAccessHour As PimpedNumericUpDown
	Friend WithEvents gLastAccessMinute As PimpedNumericUpDown
	Friend WithEvents gLastAccessSecond As PimpedNumericUpDown
	Friend WithEvents gLastAccessMillisecond As PimpedNumericUpDown
	Friend WithEvents gToolTip As System.Windows.Forms.ToolTip
	Private WithEvents gCopyButton As System.Windows.Forms.Button
	Private WithEvents gPasteButton As System.Windows.Forms.Button
	Private WithEvents gTimeStampsLabel As System.Windows.Forms.Label
	Private WithEvents gInfoLabel As Label
End Class
