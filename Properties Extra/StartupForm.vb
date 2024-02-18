Public Class StartupForm

	Public Property Path As String

	Private _IsInitialized As Boolean

	Protected Overrides Sub OnActivated(e As EventArgs)
		MyBase.OnActivated(e)
		If (Not _IsInitialized) Then
			_IsInitialized = True
		End If
	End Sub

	Public Sub New()

		InitializeComponent()

		Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)

		Me.Text = Versioning.Constants.AppName + " " + Versioning.Constants.AppVersion

		Me.gCheckBox.Checked = RegistryAccessor.GetContextMenuState

		Me.gCheckBox.Enabled = RegistryAccessor.IsElevatedAdministrator

	End Sub

	Private Sub PathRequester_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
		Me.Path = gPath.Text
	End Sub

	Private Sub gPickerButton_Click(sender As Object, e As EventArgs) Handles gPickerButton.Click
		Dim result As DialogResult
		Dim path As String

		'Using dialog = New FolderBrowserDialog
		'	result = dialog.ShowDialog(Owner)
		'	directory = dialog.SelectedPath
		'End Using

		Using dialog = New OpenFileDialog
			result = dialog.ShowDialog(Owner)
			path = dialog.FileName
		End Using

		If (result = Windows.Forms.DialogResult.OK) Then
			gPath.Text = path
		End If

	End Sub

	Private Sub GCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles gCheckBox.CheckedChanged
		If (Not _IsInitialized) Then
			Exit Sub
		End If
		RegistryAccessor.SetContextMenuState(Me.gCheckBox.Checked)
	End Sub

	Private Sub gPath_TextChanged(sender As Object, e As EventArgs) Handles gPath.TextChanged
		gContinueButton.Enabled = (System.IO.Directory.Exists(gPath.Text) OrElse System.IO.File.Exists(gPath.Text))
	End Sub

End Class