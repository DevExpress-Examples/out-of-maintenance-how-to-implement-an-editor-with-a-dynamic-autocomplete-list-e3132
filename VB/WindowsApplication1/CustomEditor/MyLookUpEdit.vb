Imports System
Imports System.ComponentModel
Imports DevExpress.XtraEditors

Namespace WindowsApplication1
	<System.ComponentModel.DesignerCategory("")>
	Public Class MyLookUpEdit
		Inherits LookUpEdit

		Shared Sub New()
			RepositoryItemMyLookUpEdit.Register()
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMyLookUpEdit.EditorName
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyLookUpEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemMyLookUpEdit)
			End Get
		End Property


		Protected Overrides Sub ProcessFindItem(ByVal helper As DevExpress.XtraEditors.Controls.KeyPressHelper, ByVal pressedKey As Char)
			AssignDataSource(AutoSearchText)
			MyBase.ProcessFindItem(helper, pressedKey)
		End Sub

		Private Sub AssignDataSource(ByVal autoSearchText As String)
			Properties.UpdateDataSource(autoSearchText)
		End Sub
	End Class
End Namespace
