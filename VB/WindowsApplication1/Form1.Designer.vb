Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemMyLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.formAssistant1 = New DevExpress.XtraBars.FormAssistant()
            CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMyLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'LookUpEdit1
            '
            Me.LookUpEdit1.Location = New System.Drawing.Point(78, 106)
            Me.LookUpEdit1.Margin = New System.Windows.Forms.Padding(2)
            Me.LookUpEdit1.Name = "LookUpEdit1"
            Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.LookUpEdit1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
            Me.LookUpEdit1.Size = New System.Drawing.Size(281, 20)
            Me.LookUpEdit1.TabIndex = 0
            '
            'bar2
            '
            Me.bar2.BarName = "Main menu"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem1)})
            Me.bar2.OptionsBar.MultiLine = True
            Me.bar2.OptionsBar.UseWholeRow = True
            Me.bar2.Text = "Main menu"
            '
            'barEditItem1
            '
            Me.barEditItem1.Caption = "barEditItem1"
            Me.barEditItem1.Edit = Me.repositoryItemMyLookUpEdit1
            Me.barEditItem1.EditWidth = 200
            Me.barEditItem1.Id = 0
            Me.barEditItem1.Name = "barEditItem1"
            '
            'repositoryItemMyLookUpEdit1
            '
            Me.repositoryItemMyLookUpEdit1.AutoHeight = False
            Me.repositoryItemMyLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemMyLookUpEdit1.DataSource = CType(resources.GetObject("repositoryItemMyLookUpEdit1.DataSource"), Object)
            Me.repositoryItemMyLookUpEdit1.ImmediatePopup = True
            Me.repositoryItemMyLookUpEdit1.Name = "repositoryItemMyLookUpEdit1"
            Me.repositoryItemMyLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Nothing
            Me.barDockControlTop.Size = New System.Drawing.Size(453, 0)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 264)
            Me.barDockControlBottom.Manager = Nothing
            Me.barDockControlBottom.Size = New System.Drawing.Size(453, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Nothing
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 264)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(453, 0)
            Me.barDockControlRight.Manager = Nothing
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 264)
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(453, 264)
            Me.Controls.Add(Me.LookUpEdit1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMyLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private WithEvents LookUpEdit1 As LookUpEdit
        Private barManager1 As DevExpress.XtraBars.BarManager
        Private bar2 As DevExpress.XtraBars.Bar
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private formAssistant1 As DevExpress.XtraBars.FormAssistant
        Private barEditItem1 As DevExpress.XtraBars.BarEditItem
        Private WithEvents repositoryItemLookUpEdit1 As RepositoryItemLookUpEdit
        Private WithEvents repositoryItemMyLookUpEdit1 As RepositoryItemLookUpEdit

    End Class
End Namespace

