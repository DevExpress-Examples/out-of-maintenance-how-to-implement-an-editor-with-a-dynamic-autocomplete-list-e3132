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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.myLookUpEdit1 = New WindowsApplication1.MyLookUpEdit()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar2 = New DevExpress.XtraBars.Bar()
			Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemMyLookUpEdit1 = New WindowsApplication1.RepositoryItemMyLookUpEdit()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.formAssistant1 = New DevExpress.XtraBars.FormAssistant()
			DirectCast(Me.myLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.repositoryItemMyLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myLookUpEdit1
			' 
			Me.myLookUpEdit1.Location = New System.Drawing.Point(96, 127)
			Me.myLookUpEdit1.Margin = New System.Windows.Forms.Padding(2)
			Me.myLookUpEdit1.Name = "myLookUpEdit1"
			Me.myLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.myLookUpEdit1.Properties.DataSource = (DirectCast(resources.GetObject("myLookUpEdit1.Properties.DataSource"), Object))
			Me.myLookUpEdit1.Properties.ImmediatePopup = True
			Me.myLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
'			Me.myLookUpEdit1.Properties.GetAutoCompleteList += New WindowsApplication1.GetAutoCompleteListEventHandler(Me.myLookUpEdit1_Properties_GetAutoCompleteList)
			Me.myLookUpEdit1.Size = New System.Drawing.Size(200, 20)
			Me.myLookUpEdit1.TabIndex = 0
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar2})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barEditItem1})
			Me.barManager1.MainMenu = Me.bar2
			Me.barManager1.MaxItemId = 1
			Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMyLookUpEdit1})
			' 
			' bar2
			' 
			Me.bar2.BarName = "Main menu"
			Me.bar2.DockCol = 0
			Me.bar2.DockRow = 0
			Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem1)})
			Me.bar2.OptionsBar.MultiLine = True
			Me.bar2.OptionsBar.UseWholeRow = True
			Me.bar2.Text = "Main menu"
			' 
			' barEditItem1
			' 
			Me.barEditItem1.Caption = "barEditItem1"
			Me.barEditItem1.Edit = Me.repositoryItemMyLookUpEdit1
			Me.barEditItem1.Id = 0
			Me.barEditItem1.Name = "barEditItem1"
			Me.barEditItem1.Width = 200
			' 
			' repositoryItemMyLookUpEdit1
			' 
			Me.repositoryItemMyLookUpEdit1.AutoHeight = False
			Me.repositoryItemMyLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemMyLookUpEdit1.DataSource = (DirectCast(resources.GetObject("repositoryItemMyLookUpEdit1.DataSource"), Object))
			Me.repositoryItemMyLookUpEdit1.ImmediatePopup = True
			Me.repositoryItemMyLookUpEdit1.Name = "repositoryItemMyLookUpEdit1"
			Me.repositoryItemMyLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
'			Me.repositoryItemMyLookUpEdit1.GetAutoCompleteList += New WindowsApplication1.GetAutoCompleteListEventHandler(Me.repositoryItemMyLookUpEdit1_GetAutoCompleteList)
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(453, 20)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 264)
			Me.barDockControlBottom.Size = New System.Drawing.Size(453, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 244)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(453, 20)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 244)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(453, 264)
			Me.Controls.Add(Me.myLookUpEdit1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
			DirectCast(Me.myLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.repositoryItemMyLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents myLookUpEdit1 As MyLookUpEdit
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private bar2 As DevExpress.XtraBars.Bar
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private formAssistant1 As DevExpress.XtraBars.FormAssistant
		Private barEditItem1 As DevExpress.XtraBars.BarEditItem
		Private WithEvents repositoryItemMyLookUpEdit1 As RepositoryItemMyLookUpEdit


	End Class
End Namespace

