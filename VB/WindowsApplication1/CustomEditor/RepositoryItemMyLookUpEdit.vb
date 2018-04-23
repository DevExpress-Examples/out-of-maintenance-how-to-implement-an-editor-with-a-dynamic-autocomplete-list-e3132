Imports System
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports System.Collections.Generic

Namespace WindowsApplication1
	Public Delegate Sub GetAutoCompleteListEventHandler(ByVal sender As Object, ByVal e As AutoCompleteListEventArgs)

	<System.ComponentModel.DesignerCategory(""), UserRepositoryItem("Register")>
	Public Class RepositoryItemMyLookUpEdit
		Inherits RepositoryItemLookUpEdit

		Private Shared ReadOnly getAutoCompleteListObj As New Object()

		Public Custom Event GetAutoCompleteList As GetAutoCompleteListEventHandler
			AddHandler(ByVal value As GetAutoCompleteListEventHandler)
				Events.AddHandler(getAutoCompleteListObj, value)
				OnPropertiesChanged()
			End AddHandler
			RemoveHandler(ByVal value As GetAutoCompleteListEventHandler)
				Events.RemoveHandler(getAutoCompleteListObj, value)
				OnPropertiesChanged()
			End RemoveHandler
			RaiseEvent(ByVal sender As Object, ByVal e As AutoCompleteListEventArgs)
			End RaiseEvent
		End Event


		''' <summary>
		''' Triggers the GetAutoCompleteList event.
		''' </summary>
		Public Overridable Sub RaiseGetAutoCompleteList(ByVal ea As AutoCompleteListEventArgs)
			Dim handler As GetAutoCompleteListEventHandler = CType(Events(getAutoCompleteListObj), GetAutoCompleteListEventHandler)
			If handler IsNot Nothing Then
				handler(GetEventSender(), ea)
			End If
		End Sub


		Shared Sub New()
			Register()
		End Sub
		Public Sub New()
			DataSource = New List(Of String)()
			ImmediatePopup = True
			TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
		End Sub
		Friend Const EditorName As String = "MyLookUpEdit"

        Public Shared Sub Register()
            Dim img As Image = Nothing
            Dim editorClassInfo As Object = New EditorClassInfo(EditorName, GetType(MyLookUpEdit), GetType(RepositoryItemMyLookUpEdit), GetType(DevExpress.XtraEditors.ViewInfo.LookUpEditViewInfo), New DevExpress.XtraEditors.Drawing.ButtonEditPainter(), True, img)
            EditorRegistrationInfo.Default.Editors.Add(editorClassInfo)
        End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property
		Public Sub UpdateDataSource(ByVal autoSearchText As String)
			Dim items As List(Of String) = TryCast(DataAdapter.DataSource, List(Of String))
			RaiseGetAutoCompleteList(New AutoCompleteListEventArgs(autoSearchText, items))
		End Sub
		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			BeginUpdate()
			Try
				MyBase.Assign(item)
				Dim source As RepositoryItemMyLookUpEdit = TryCast(item, RepositoryItemMyLookUpEdit)
				If source Is Nothing Then
					Return
				End If
				Events.AddHandler(getAutoCompleteListObj, source.Events(getAutoCompleteListObj))
			Finally
				EndUpdate()
			End Try
		End Sub
	End Class
End Namespace
