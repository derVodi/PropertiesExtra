Imports System.Security.Principal
Imports Microsoft.Win32

Public Class RegistryAccessor

	Public Shared ReadOnly Property IsElevatedAdministrator() As Boolean
		Get
			Dim identity As WindowsIdentity = WindowsIdentity.GetCurrent()
			Dim principal As WindowsPrincipal = New WindowsPrincipal(identity)
			Return principal.IsInRole(WindowsBuiltInRole.Administrator)
		End Get
	End Property

	Public Shared Function GetContextMenuState() As Boolean
		Dim myRegistryKey As RegistryKey = Registry.ClassesRoot.OpenSubKey("*", False).OpenSubKey("shell", False).OpenSubKey("Properties Extra")
		Return (myRegistryKey IsNot Nothing)
	End Function

	Public Shared Sub SetContextMenuState(state As Boolean)

		Dim shellRegistryKey As RegistryKey = Registry.ClassesRoot.OpenSubKey("*", True).OpenSubKey("shell", True)

		If (state) Then
			Dim myRegistryKey = shellRegistryKey.CreateSubKey("Properties Extra")
			Dim commandKey = myRegistryKey.CreateSubKey("command")
			commandKey.SetValue("", """" + Application.ExecutablePath + """ ""%1""") ' empty key sets the "(Standard)"
		Else
			shellRegistryKey.DeleteSubKeyTree("Properties Extra")
		End If
	End Sub

End Class
