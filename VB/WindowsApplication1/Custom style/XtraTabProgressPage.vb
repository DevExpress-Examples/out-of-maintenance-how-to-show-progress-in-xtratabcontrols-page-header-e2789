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

Namespace WindowsApplication1
	Public Class XtraTabProgressPage
		Inherits XtraTabPage

		Public Sub New()

		End Sub

		Private _Progress As Integer
		Public Property Progress() As Integer
			Get
				Return _Progress
			End Get
			Set(ByVal value As Integer)
				If value < 0 Then
					value = 0
				End If
				If value > 100 Then
					value = 100
				End If
				_Progress = value
				OnProgressChanged()
			End Set
		End Property
		Private Sub OnProgressChanged()
			Parent.Refresh()
		End Sub

		Public Overrides Property Text() As String
			Get
				Return String.Format("{0} ({1}%) ", MyBase.Text, Progress)
			End Get
			Set(ByVal value As String)
				MyBase.Text = value
			End Set
		End Property
	End Class
End Namespace
