<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartupForm
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
		Me.gPath = New System.Windows.Forms.TextBox()
		Me.gPickerButton = New System.Windows.Forms.Button()
		Me.gContinueButton = New System.Windows.Forms.Button()
		Me.gCancelButton = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.gCheckBox = New System.Windows.Forms.CheckBox()
		Me.SuspendLayout()
		'
		'gPath
		'
		Me.gPath.Location = New System.Drawing.Point(12, 25)
		Me.gPath.Name = "gPath"
		Me.gPath.Size = New System.Drawing.Size(495, 21)
		Me.gPath.TabIndex = 1
		'
		'gPickerButton
		'
		Me.gPickerButton.Location = New System.Drawing.Point(510, 24)
		Me.gPickerButton.Name = "gPickerButton"
		Me.gPickerButton.Size = New System.Drawing.Size(27, 23)
		Me.gPickerButton.TabIndex = 2
		Me.gPickerButton.Text = "..."
		Me.gPickerButton.UseVisualStyleBackColor = True
		'
		'gContinueButton
		'
		Me.gContinueButton.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.gContinueButton.Enabled = False
		Me.gContinueButton.Location = New System.Drawing.Point(381, 54)
		Me.gContinueButton.Name = "gContinueButton"
		Me.gContinueButton.Size = New System.Drawing.Size(75, 23)
		Me.gContinueButton.TabIndex = 4
		Me.gContinueButton.Text = "Continue"
		Me.gContinueButton.UseVisualStyleBackColor = True
		'
		'gCancelButton
		'
		Me.gCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.gCancelButton.Location = New System.Drawing.Point(462, 54)
		Me.gCancelButton.Name = "gCancelButton"
		Me.gCancelButton.Size = New System.Drawing.Size(75, 23)
		Me.gCancelButton.TabIndex = 5
		Me.gCancelButton.Text = "Exit"
		Me.gCancelButton.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(184, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Choose a File to Show the Properties"
		'
		'gCheckBox
		'
		Me.gCheckBox.AutoSize = True
		Me.gCheckBox.Location = New System.Drawing.Point(12, 58)
		Me.gCheckBox.Name = "gCheckBox"
		Me.gCheckBox.Size = New System.Drawing.Size(247, 17)
		Me.gCheckBox.TabIndex = 3
		Me.gCheckBox.Text = "Context Menu Entry (need to ""Run as Admin"")"
		Me.gCheckBox.UseVisualStyleBackColor = True
		'
		'StartupForm
		'
		Me.AcceptButton = Me.gContinueButton
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.gCancelButton
		Me.ClientSize = New System.Drawing.Size(547, 89)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.gPath)
		Me.Controls.Add(Me.gPickerButton)
		Me.Controls.Add(Me.gCheckBox)
		Me.Controls.Add(Me.gContinueButton)
		Me.Controls.Add(Me.gCancelButton)
		Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "StartupForm"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Properties Extra"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents gPath As System.Windows.Forms.TextBox
	Friend WithEvents gPickerButton As System.Windows.Forms.Button
	Friend WithEvents gContinueButton As System.Windows.Forms.Button
	Friend WithEvents gCancelButton As System.Windows.Forms.Button
	Friend WithEvents Label1 As Label
	Friend WithEvents gCheckBox As CheckBox
End Class
