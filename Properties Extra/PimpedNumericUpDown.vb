Public Class PimpedNumericUpDown
	Inherits NumericUpDown

	Public Property Slave As CheckBox

	Public ReadOnly Property ValueInt As Integer
		Get
			Return CInt(Me.Value)
		End Get
	End Property

	Private Sub Me_Enter(sender As Object, e As EventArgs) Handles Me.Enter
		Me.Select(0, Me.Text.Length)
	End Sub

	Private Sub gLastAccessHour_ValueChanged(sender As Object, e As EventArgs) Handles Me.ValueChanged
		If (MainForm.SuppressEarlyEvents) Then
			Exit Sub
		End If
		Slave.Checked = True
	End Sub

End Class
