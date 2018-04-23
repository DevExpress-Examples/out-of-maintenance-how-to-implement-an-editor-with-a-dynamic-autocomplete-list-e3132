Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.myLookUpEdit1 = New WindowsApplication1.MyLookUpEdit()
			CType(Me.myLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myLookUpEdit1
			' 
			Me.myLookUpEdit1.Location = New System.Drawing.Point(12, 12)
			Me.myLookUpEdit1.Name = "myLookUpEdit1"
			Me.myLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.myLookUpEdit1.Properties.DataSource = (CObj(resources.GetObject("myLookUpEdit1.Properties.DataSource")))
			Me.myLookUpEdit1.Properties.ImmediatePopup = True
			Me.myLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
'			Me.myLookUpEdit1.Properties.GetAutoCompleteList += New WindowsApplication1.GetAutoCompleteListEventHandler(Me.myLookUpEdit1_Properties_GetAutoCompleteList);
			Me.myLookUpEdit1.Size = New System.Drawing.Size(266, 22)
			Me.myLookUpEdit1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(374, 75)
			Me.Controls.Add(Me.myLookUpEdit1)
			Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.myLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents myLookUpEdit1 As MyLookUpEdit


	End Class
End Namespace

