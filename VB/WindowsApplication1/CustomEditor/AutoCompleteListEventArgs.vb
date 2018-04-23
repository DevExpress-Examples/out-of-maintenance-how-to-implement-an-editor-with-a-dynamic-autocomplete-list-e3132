Imports System
Imports System.Collections.Generic

Namespace WindowsApplication1
	Public Class AutoCompleteListEventArgs
		Inherits EventArgs

		Public Sub New(ByVal autoSearchText As String, ByVal list As List(Of String))
			_AutoCompleteList = list
			_AutoSearchText = autoSearchText
		End Sub
		Private _AutoCompleteList As List(Of String)

		Private _AutoSearchText As String
		Public ReadOnly Property AutoSearchText() As String
			Get
				Return _AutoSearchText
			End Get
		End Property


		Public ReadOnly Property AutoCompleteList() As List(Of String)
			Get
				Return _AutoCompleteList
			End Get
		End Property
	End Class
End Namespace
