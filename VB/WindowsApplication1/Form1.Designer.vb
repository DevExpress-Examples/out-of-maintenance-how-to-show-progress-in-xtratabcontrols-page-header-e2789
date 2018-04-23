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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.xtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			Me.xtraTabPage2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Images = Me.imageCollection1
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(967, 473)
			Me.xtraTabControl1.TabIndex = 0
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2, Me.xtraTabPage3, Me.xtraTabPage4, Me.xtraTabPage5, Me.xtraTabPage6})
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageSize = New System.Drawing.Size(48, 48)
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.Images.SetKeyName(0, "Checkmark.png")
			Me.imageCollection1.Images.SetKeyName(1, "Clock.png")
			Me.imageCollection1.Images.SetKeyName(2, "Config.png")
			Me.imageCollection1.Images.SetKeyName(3, "Exclamation.png")
			Me.imageCollection1.Images.SetKeyName(4, "Lifesaver.png")
			Me.imageCollection1.Images.SetKeyName(5, "Paper-pencil.png")
			Me.imageCollection1.Images.SetKeyName(6, "Piechart.png")
			Me.imageCollection1.Images.SetKeyName(7, "Screen.png")
			Me.imageCollection1.Images.SetKeyName(8, "Search.png")
			Me.imageCollection1.Images.SetKeyName(9, "World.png")
			Me.imageCollection1.Images.SetKeyName(10, "X.png")
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.groupControl1)
			Me.xtraTabPage1.ImageIndex = 0
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(961, 412)
			Me.xtraTabPage1.Text = "Protection status"
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.simpleButton1)
			Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.groupControl1.Location = New System.Drawing.Point(0, 0)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(961, 412)
			Me.groupControl1.TabIndex = 0
			Me.groupControl1.Text = "groupControl1"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(105, 70)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(322, 143)
			Me.simpleButton1.TabIndex = 0
			Me.simpleButton1.Text = "Test"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.simpleButton2)
			Me.xtraTabPage2.ImageIndex = 8
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(960, 410)
			Me.xtraTabPage2.Text = "Computer scan"
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(243, 156)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton2.TabIndex = 1
			Me.simpleButton2.Text = "simpleButton2"
			' 
			' xtraTabPage3
			' 
			Me.xtraTabPage3.ImageIndex = 9
			Me.xtraTabPage3.Name = "xtraTabPage3"
			Me.xtraTabPage3.Size = New System.Drawing.Size(960, 410)
			Me.xtraTabPage3.Text = "Update"
			' 
			' xtraTabPage4
			' 
			Me.xtraTabPage4.ImageIndex = 2
			Me.xtraTabPage4.Name = "xtraTabPage4"
			Me.xtraTabPage4.Size = New System.Drawing.Size(960, 410)
			Me.xtraTabPage4.Text = "Setup"
			' 
			' xtraTabPage5
			' 
			Me.xtraTabPage5.ImageIndex = 3
			Me.xtraTabPage5.Name = "xtraTabPage5"
			Me.xtraTabPage5.Size = New System.Drawing.Size(960, 410)
			Me.xtraTabPage5.Text = "Tools"
			' 
			' xtraTabPage6
			' 
			Me.xtraTabPage6.ImageIndex = 4
			Me.xtraTabPage6.Name = "xtraTabPage6"
			Me.xtraTabPage6.Size = New System.Drawing.Size(960, 410)
			Me.xtraTabPage6.Text = "Help"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(967, 473)
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.xtraTabPage2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private xtraTabPage3 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage4 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage5 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage6 As DevExpress.XtraTab.XtraTabPage
		Private imageCollection1 As DevExpress.Utils.ImageCollection
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton

	End Class
End Namespace

