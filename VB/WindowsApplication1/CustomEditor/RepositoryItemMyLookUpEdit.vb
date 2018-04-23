Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
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
	Public Delegate Sub GetAutoCompleteListEventHandler(ByVal sender As Object, ByVal e As AutoCompleteListEventArgs)

	<System.ComponentModel.DesignerCategory(""), UserRepositoryItem("Register")> _
	Public Class RepositoryItemMyLookUpEdit
		Inherits RepositoryItemLookUpEdit

        Private Shared ReadOnly getAutoCompleteListEvent As Object = New Object()

		Public Custom Event GetAutoCompleteList As GetAutoCompleteListEventHandler
			AddHandler(ByVal value As GetAutoCompleteListEventHandler)
                Events.AddHandler(getAutoCompleteListEvent, value)
				OnPropertiesChanged()
			End AddHandler
			RemoveHandler(ByVal value As GetAutoCompleteListEventHandler)
                Me.Events.RemoveHandler(getAutoCompleteListEvent, value)
				OnPropertiesChanged()
			End RemoveHandler
			RaiseEvent(ByVal sender As Object, ByVal e As AutoCompleteListEventArgs)
			End RaiseEvent
		End Event

		#Region "OnGetAutoCompleteList"
		''' <summary>
		''' Triggers the GetAutoCompleteList event.
		''' </summary>
		Public Overridable Sub RaiseGetAutoCompleteList(ByVal ea As AutoCompleteListEventArgs)
            Dim handler As GetAutoCompleteListEventHandler = CType(Events(getAutoCompleteListEvent), GetAutoCompleteListEventHandler)
			If handler IsNot Nothing Then
				handler(GetEventSender(), ea)
			End If
		End Sub
		#End Region

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
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(MyLookUpEdit), GetType(RepositoryItemMyLookUpEdit), GetType(DevExpress.XtraEditors.ViewInfo.LookUpEditViewInfo), New DevExpress.XtraEditors.Drawing.ButtonEditPainter(), True))
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
	End Class
End Namespace
