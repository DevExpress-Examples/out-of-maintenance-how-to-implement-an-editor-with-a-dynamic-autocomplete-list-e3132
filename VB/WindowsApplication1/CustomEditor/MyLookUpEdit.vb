Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator

Namespace WindowsApplication1
	<System.ComponentModel.DesignerCategory("")> _
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
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
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
