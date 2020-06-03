Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Threading.Tasks

Namespace WindowsApplication1
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub LookUpEdit1_AutoSuggest(sender As Object, e As DevExpress.XtraEditors.Controls.LookUpEditAutoSuggestEventArgs) Handles LookUpEdit1.AutoSuggest
            e.QuerySuggestions = Task.Run(Function() GetData())
        End Sub

        Private Function GetData() As ICollection
            Dim list = New List(Of String)()
            For i As Integer = 0 To 9
                list.Add(RandomString(5, True))
            Next i
            Return list
        End Function

        Private ReadOnly random As New Random()
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
    End Class
End Namespace
