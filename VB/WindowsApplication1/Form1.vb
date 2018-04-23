Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTab.Registrator
Imports DevExpress.XtraTab.Drawing
Imports DevExpress.XtraTab
Imports System.Threading

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits XtraForm
		Private page As New XtraTabProgressPage()

		Public Sub New()
			InitializeComponent()
			PaintStyleCollection.DefaultPaintStyles.Add(New MyRegistrator())
			xtraTabControl1.PaintStyleName = "MyStyle"

			page.Text = "Progress"
			page.ImageIndex = 0
			xtraTabControl1.TabPages.Add(page)
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			For i As Integer = 0 To 99
				page.Progress = i
				Thread.Sleep(20)
			Next i
		End Sub
	End Class
End Namespace