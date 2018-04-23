Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private random As New Random()

		Private Function RandomString(ByVal size As Integer, ByVal lowerCase As Boolean) As String
			Dim builder As New StringBuilder()
			Dim ch As Char
			For i As Integer = 0 To size - 1
				ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)))
				builder.Append(ch)
			Next i
			If lowerCase Then
				Return builder.ToString().ToLower()
			End If
			Return builder.ToString()
		End Function


		Private Sub myLookUpEdit1_Properties_GetAutoCompleteList(ByVal sender As Object, ByVal e As AutoCompleteListEventArgs) Handles myLookUpEdit1.Properties.GetAutoCompleteList
			GetAutoCompleteList(e)
		End Sub

		Private Sub repositoryItemMyLookUpEdit1_GetAutoCompleteList(ByVal sender As Object, ByVal e As AutoCompleteListEventArgs) Handles repositoryItemMyLookUpEdit1.GetAutoCompleteList
			GetAutoCompleteList(e)
		End Sub
		Public Sub GetAutoCompleteList(ByVal e As AutoCompleteListEventArgs)
			e.AutoCompleteList.Clear()
			For i As Integer = 0 To 9
				e.AutoCompleteList.Add(String.Format("{0}{1}", e.AutoSearchText, RandomString(5, True)))
			Next i
		End Sub
	End Class
End Namespace
