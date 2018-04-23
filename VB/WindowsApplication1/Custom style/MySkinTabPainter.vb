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
Imports DevExpress.Utils
Imports DevExpress.XtraTab.ViewInfo

Namespace WindowsApplication1
	Public Class MySkinTabPainter
		Inherits SkinTabPainter

		Public Sub New(ByVal tabControl As IXtraTab)
			MyBase.New(tabControl)

		End Sub

		Protected Overrides Sub DrawHeaderPage(ByVal e As TabDrawArgs, ByVal row As BaseTabRowViewInfo, ByVal pInfo As BaseTabPageViewInfo)
			MyBase.DrawHeaderPage(e, row, pInfo)
			Dim page As XtraTabProgressPage = TryCast(pInfo.Page, XtraTabProgressPage)
			If page Is Nothing Then
				Return
			End If
			If page.Progress = 0 Then
				Return
			End If

			Dim bounds As Rectangle = pInfo.Bounds
			bounds.Inflate(-2, -2)
			bounds.X += 2
			bounds.Width = bounds.Width * page.Progress / 100
			Dim progressColor As Color = Color.FromArgb(&HB1, &H21, &HC9, &H00)
			e.Graphics.FillRectangle(New SolidBrush(progressColor), bounds)
		End Sub

	End Class
End Namespace
