Imports System.IO

Public Partial Class MainForm

	Public Shared SuppressEarlyEvents As Boolean = True

	Private _OriginalExtension As String

	Private _CreatedDates As New Dictionary(Of Integer, DateTime)
	Private _ModifiedDates As New Dictionary(Of Integer, DateTime)
	Private _LastAccessDates As New Dictionary(Of Integer, DateTime)

	Private _EarliestCreatedDate As DateTime
	Private _EarliestModifiedDate As DateTime
	Private _EarliestLastAccessDate As DateTime

	Private _IsDistinctArray As Boolean
	Private _Files As String()

	Private Const _ClipboardInvalid As String = "The Clipboard does not contain a valid time stamp text."

	Private ReadOnly Property DataSource As String()
		Get
			If (_IsDistinctArray) Then
				Return _Files
			Else
				Return Environment.GetCommandLineArgs()
			End If
		End Get
	End Property

	Private ReadOnly Property FileCount As Integer
		Get
			If (_IsDistinctArray) Then
				Return _Files.GetUpperBound(0) + 1
			Else
				Return Environment.GetCommandLineArgs().GetUpperBound(0)
			End If
		End Get
	End Property

	Private Sub FetchFiles(path As String)
		_Files = Directory.GetFiles(path)
	End Sub

	Public Sub New()

		Me.InitializeComponent()

		Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)

		If (Environment.GetCommandLineArgs().GetUpperBound(0) < 1) Then
			Using dialog As New StartupForm()
				Dim result = dialog.ShowDialog(Me)
				If (result = Windows.Forms.DialogResult.Cancel) Then
					End
				End If
				_IsDistinctArray = True
				Me.FetchFiles(dialog.Path)
			End Using
		Else
		End If

		gFiles.Text = FileCount.ToString

		gExtension.Text = Me.DetermineExtension()
		_OriginalExtension = gExtension.Text

		Me.DetermineCreated()
		Me.DetermineModified()
		Me.DetermineLastAccess()

		WireUpMasterSlave()

	End Sub

	Private Sub WireUpMasterSlave()
		gCreatedHour.Slave = gSetCreated
		gCreatedMinute.Slave = gSetCreated
		gCreatedSecond.Slave = gSetCreated
		gCreatedMillisecond.Slave = gSetCreated

		gModifiedHour.Slave = gSetModified
		gModifiedMinute.Slave = gSetModified
		gModifiedSecond.Slave = gSetModified
		gModifiedMillisecond.Slave = gSetModified

		gLastAccessHour.Slave = gSetLastAccess
		gLastAccessMinute.Slave = gSetLastAccess
		gLastAccessSecond.Slave = gSetLastAccess
		gLastAccessMillisecond.Slave = gSetLastAccess
	End Sub

	Private Function DetermineExtension() As String

		Dim extension As String = Nothing

		Dim i As Integer
		For Each arg As String In Me.DataSource
			If (_IsDistinctArray OrElse i > 0) Then

				If (extension Is Nothing) Then
					extension = Path.GetExtension(arg)
				Else
					If (Path.GetExtension(arg) <> extension) Then
						Return "(mixed)"
					End If
				End If

			End If
			i += 1
		Next
		Return extension.Substring(1)
	End Function

	Private Enum ResultKind
		SingleFile
		AllEqual
		Mixed
	End Enum

	Private Sub DetermineCreated()
		Dim earliestDate As DateTime
		Dim resultKind As ResultKind
		DetermineFileDates(Function(filePath As String) File.GetCreationTime(filePath), _CreatedDates, earliestDate, resultKind)
		_EarliestCreatedDate = earliestDate
		gCreated.Value = earliestDate
		gCreatedHour.Value = earliestDate.Hour
		gCreatedMinute.Value = earliestDate.Minute
		gCreatedSecond.Value = earliestDate.Second
		gCreatedMillisecond.Value = earliestDate.Millisecond
		Select Case resultKind
			Case resultKind.SingleFile
				gCreatedLabel.Text = "Created"
			Case resultKind.AllEqual
				gCreatedLabel.Text = "Created (all equal)"
			Case resultKind.Mixed
				gCreatedLabel.Text = "Created (earliest)"
		End Select
	End Sub

	Private Sub DetermineLastAccess()
		Dim earliestDate As DateTime
		Dim resultKind As ResultKind
		DetermineFileDates(Function(filePath As String) File.GetLastAccessTime(filePath), _ModifiedDates, earliestDate, resultKind)
		_EarliestLastAccessDate = earliestDate
		gLastAccess.Value = earliestDate
		gLastAccessHour.Value = earliestDate.Hour
		gLastAccessMinute.Value = earliestDate.Minute
		gLastAccessSecond.Value = earliestDate.Second
		gLastAccessMillisecond.Value = earliestDate.Millisecond
		Select Case resultKind
			Case resultKind.SingleFile
				gLastAccessLabel.Text = "Last Access"
			Case resultKind.AllEqual
				gLastAccessLabel.Text = "Last Access (all equal)"
			Case resultKind.Mixed
				gLastAccessLabel.Text = "Last Access (earliest)"
		End Select
	End Sub

	Private Sub DetermineModified()
		Dim earliestDate As DateTime
		Dim resultKind As ResultKind
		DetermineFileDates(Function(filePath As String) File.GetLastWriteTime(filePath), _LastAccessDates, earliestDate, resultKind)
		_EarliestModifiedDate = earliestDate
		gModified.Value = earliestDate
		gModifiedHour.Value = earliestDate.Hour
		gModifiedMinute.Value = earliestDate.Minute
		gModifiedSecond.Value = earliestDate.Second
		gModifiedMillisecond.Value = earliestDate.Millisecond
		Select Case resultKind
			Case ResultKind.SingleFile
				gModifiedLabel.Text = "Modified"
			Case ResultKind.AllEqual
				gModifiedLabel.Text = "Modified (all equal)"
			Case ResultKind.Mixed
				gModifiedLabel.Text = "Modified (earliest)"
		End Select
	End Sub

	Private Sub DetermineFileDates(getSomeFileDate As Func(Of String, DateTime), datesDictionary As Dictionary(Of Integer, DateTime), ByRef earliestDate As DateTime, ByRef resultKind As ResultKind)
		Dim fileDate As DateTime = DateTime.MinValue
		earliestDate = DateTime.MaxValue
		Dim previousCycle As DateTime = Nothing
		Dim i As Integer

		If (Me.FileCount > 1) Then
			resultKind = resultKind.AllEqual
		Else
			resultKind = resultKind.SingleFile
		End If

		For Each arg As String In Me.DataSource
			If (_IsDistinctArray OrElse i > 0) Then
				fileDate = getSomeFileDate(arg)
				datesDictionary.Add(i, fileDate)
				If (fileDate < earliestDate) Then
					earliestDate = fileDate
				End If
				If (previousCycle <> Nothing AndAlso fileDate <> previousCycle) Then
					resultKind = resultKind.Mixed
				End If
			End If
			previousCycle = fileDate
			i += 1
		Next
	End Sub

	Sub GClose_Click(sender As Object, e As EventArgs) Handles gCloseButton.Click
		End
	End Sub

	Private Property CreatedDateTime As DateTime
		Get
			Return New DateTime(gCreated.Value.Year, gCreated.Value.Month, gCreated.Value.Day, gCreatedHour.ValueInt, gCreatedMinute.ValueInt, gCreatedSecond.ValueInt, gCreatedMillisecond.ValueInt)
		End Get
		Set(value As DateTime)
			gCreated.Value = value
			gCreatedHour.Value = value.Hour
			gCreatedMinute.Value = value.Minute
			gCreatedSecond.Value = value.Second
			gCreatedMillisecond.Value = value.Millisecond
		End Set
	End Property

	Private Property ModifiedDateTime As DateTime
		Get
			Return New DateTime(gModified.Value.Year, gModified.Value.Month, gModified.Value.Day, gModifiedHour.ValueInt, gModifiedMinute.ValueInt, gModifiedSecond.ValueInt, gModifiedMillisecond.ValueInt)
		End Get
		Set(value As DateTime)
			gModified.Value = value
			gModifiedHour.Value = value.Hour
			gModifiedMinute.Value = value.Minute
			gModifiedSecond.Value = value.Second
			gModifiedMillisecond.Value = value.Millisecond
		End Set
	End Property

	Private Property LastAccessDateTime As DateTime
		Get
			Return New DateTime(gLastAccess.Value.Year, gLastAccess.Value.Month, gLastAccess.Value.Day, gLastAccessHour.ValueInt, gLastAccessMinute.ValueInt, gLastAccessSecond.ValueInt, gLastAccessMillisecond.ValueInt)
		End Get
		Set(value As DateTime)
			gLastAccess.Value = value
			gLastAccessHour.Value = value.Hour
			gLastAccessMinute.Value = value.Minute
			gLastAccessSecond.Value = value.Second
			gLastAccessMillisecond.Value = value.Millisecond
		End Set
	End Property

	Private Sub ModifyFileProperties()
		Dim i As Integer

		Dim createdDelta As TimeSpan = CreatedDateTime.Subtract(_EarliestCreatedDate)
		Dim modifiedDelta As TimeSpan = ModifiedDateTime.Subtract(_EarliestModifiedDate)
		Dim lastAccessDelta As TimeSpan = LastAccessDateTime.Subtract(_EarliestLastAccessDate)

		For Each arg As String In Me.DataSource
			If (_IsDistinctArray OrElse i > 0) Then
				If (gSetExtension.Checked AndAlso gExtension.Text <> "(mixed)" AndAlso Path.GetExtension(arg) <> gExtension.Text) Then
					File.Move(
						arg,
						Path.Combine(
							Path.GetDirectoryName(arg),
							Path.GetFileNameWithoutExtension(arg) + "." + gExtension.Text
						)
					)
				End If
				If (gSetCreated.Checked) Then
					If (gAbsolute.Checked) Then
						File.SetCreationTime(arg, CreatedDateTime)
					Else
						Dim currentTime As DateTime = File.GetCreationTime(arg)
						File.SetCreationTime(arg, currentTime.Add(createdDelta))
					End If
				End If
				If (gSetModified.Checked) Then
					If (gAbsolute.Checked) Then
						File.SetLastWriteTime(arg, ModifiedDateTime)
					Else
						Dim currentTime As DateTime = File.GetLastWriteTime(arg)
						File.SetLastWriteTime(arg, currentTime.Add(modifiedDelta))
					End If
				End If
				If (gSetLastAccess.Checked) Then
					If (gAbsolute.Checked) Then
						File.SetLastAccessTime(arg, LastAccessDateTime)
					Else
						Dim currentTime As DateTime = File.GetLastAccessTime(arg)
						File.SetLastAccessTime(arg, currentTime.Add(lastAccessDelta))
					End If
				End If
			End If
			i += 1
		Next
	End Sub

	Sub GSetButton_Click(sender As Object, e As EventArgs) Handles gSetButton.Click
		ModifyFileProperties()
		End
	End Sub
	
	Private Sub gExtension_TextChanged(sender As Object, e As EventArgs) Handles gExtension.TextChanged
		If (SuppressEarlyEvents) Then
			Exit Sub
		End If
		gSetExtension.Checked = (gExtension.Text <> _OriginalExtension)
	End Sub

	Private Sub GCreated_ValueChanged(sender As Object, e As EventArgs) Handles gCreated.ValueChanged
		If (SuppressEarlyEvents) Then
			Exit Sub
		End If
		gSetCreated.Checked = True
	End Sub

	Private Sub GModified_ValueChanged(sender As Object, e As EventArgs) Handles gModified.ValueChanged
		If (SuppressEarlyEvents) Then
			Exit Sub
		End If
		gSetModified.Checked = True
	End Sub

	Private Sub GLastAccess_ValueChanged(sender As Object, e As EventArgs) Handles gLastAccess.ValueChanged
		If (SuppressEarlyEvents) Then
			Exit Sub
		End If
		gSetLastAccess.Checked = True
	End Sub

	Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
		SuppressEarlyEvents = False
	End Sub

	Private Sub GCopy_Click(sender As Object, e As EventArgs) Handles gCopyButton.Click
		'Me.CreatedDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff")
		Dim text As String = (
			Me.CreatedDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff") + Environment.NewLine +
			Me.ModifiedDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff") + Environment.NewLine +
			Me.LastAccessDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff")
		)
		Clipboard.SetText(text)
	End Sub

	Private Sub GPaste_Click(sender As Object, e As EventArgs) Handles gPasteButton.Click
		Dim lines As String() = Clipboard.GetText.Split(Environment.NewLine.ToCharArray, StringSplitOptions.RemoveEmptyEntries)
		If (lines.GetUpperBound(0) <> 2) Then
			GoTo Hell
		End If
		Dim parsedDateTime As DateTime
		If (Not Date.TryParse(lines(0), parsedDateTime)) Then
			GoTo hell
		End If
		Me.CreatedDateTime = DateTime.SpecifyKind(parsedDateTime, DateTimeKind.Local)
		If (Not Date.TryParse(lines(1), parsedDateTime)) Then
			GoTo hell
		End If
		Me.ModifiedDateTime = DateTime.SpecifyKind(parsedDateTime, DateTimeKind.Local)
		If (Not Date.TryParse(lines(2), parsedDateTime)) Then
			GoTo hell
		End If
		Me.LastAccessDateTime = DateTime.SpecifyKind(parsedDateTime, DateTimeKind.Local)

		Exit Sub
Hell:
		MessageBox.Show(_ClipboardInvalid)
	End Sub

	Private Sub gInfoLabel_Click(sender As Object, e As EventArgs) Handles gInfoLabel.Click
		MessageBox.Show(Versioning.Constants.License, Versioning.Constants.AppName + " " + Versioning.Constants.AppVersion)
	End Sub

End Class
