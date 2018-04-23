Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication1
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
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.applicationMenu1 = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.DropDownButton1 = New DevExpress.XtraEditors.DropDownButton()
            Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.applicationMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ribbonControl1
            '
            Me.ribbonControl1.ApplicationButtonDropDownControl = Me.applicationMenu1
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barButtonItem4, Me.barButtonItem5, Me.barButtonItem6, Me.barButtonItem7, Me.barButtonItem8, Me.barButtonItem9, Me.barButtonItem10, Me.barButtonItem11, Me.barButtonItem12, Me.barButtonItem13, Me.barButtonItem14, Me.barButtonItem15})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 18
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemTextEdit1})
            Me.ribbonControl1.Size = New System.Drawing.Size(726, 144)
            '
            'applicationMenu1
            '
            Me.applicationMenu1.ItemLinks.Add(Me.barButtonItem1)
            Me.applicationMenu1.ItemLinks.Add(Me.barButtonItem2)
            Me.applicationMenu1.ItemLinks.Add(Me.barButtonItem3)
            Me.applicationMenu1.ItemLinks.Add(Me.barButtonItem4)
            Me.applicationMenu1.ItemLinks.Add(Me.barButtonItem5)
            Me.applicationMenu1.ItemLinks.Add(Me.barButtonItem6)
            Me.applicationMenu1.ItemLinks.Add(Me.barButtonItem7)
            Me.applicationMenu1.ItemLinks.Add(Me.barButtonItem8)
            Me.applicationMenu1.ItemLinks.Add(Me.barButtonItem9)
            Me.applicationMenu1.ItemLinks.Add(Me.barButtonItem10)
            Me.applicationMenu1.ItemLinks.Add(Me.barButtonItem11)
            Me.applicationMenu1.ItemLinks.Add(Me.barButtonItem12)
            Me.applicationMenu1.ItemLinks.Add(Me.barButtonItem13)
            Me.applicationMenu1.ItemLinks.Add(Me.barButtonItem14)
            Me.applicationMenu1.ItemLinks.Add(Me.barButtonItem15)
            Me.applicationMenu1.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.SmallImagesText
            Me.applicationMenu1.Name = "applicationMenu1"
            Me.applicationMenu1.Ribbon = Me.ribbonControl1
            '
            'barButtonItem1
            '
            Me.barButtonItem1.Caption = "New"
            Me.barButtonItem1.Id = 1
            Me.barButtonItem1.Name = "barButtonItem1"
            '
            'barButtonItem2
            '
            Me.barButtonItem2.Caption = "Open"
            Me.barButtonItem2.Id = 2
            Me.barButtonItem2.Name = "barButtonItem2"
            '
            'barButtonItem3
            '
            Me.barButtonItem3.Caption = "Save"
            Me.barButtonItem3.Id = 3
            Me.barButtonItem3.Name = "barButtonItem3"
            '
            'barButtonItem4
            '
            Me.barButtonItem4.Caption = "Save as ...."
            Me.barButtonItem4.Id = 4
            Me.barButtonItem4.Name = "barButtonItem4"
            '
            'barButtonItem5
            '
            Me.barButtonItem5.Caption = "Export to Excel"
            Me.barButtonItem5.Id = 5
            Me.barButtonItem5.Name = "barButtonItem5"
            '
            'barButtonItem6
            '
            Me.barButtonItem6.Caption = "Export to PDF"
            Me.barButtonItem6.Id = 6
            Me.barButtonItem6.Name = "barButtonItem6"
            '
            'barButtonItem7
            '
            Me.barButtonItem7.Caption = "Export to TXT"
            Me.barButtonItem7.Id = 7
            Me.barButtonItem7.Name = "barButtonItem7"
            '
            'barButtonItem8
            '
            Me.barButtonItem8.Caption = "Import from Excel"
            Me.barButtonItem8.Id = 8
            Me.barButtonItem8.Name = "barButtonItem8"
            '
            'barButtonItem9
            '
            Me.barButtonItem9.Caption = "Import from PDF"
            Me.barButtonItem9.Id = 9
            Me.barButtonItem9.Name = "barButtonItem9"
            '
            'barButtonItem10
            '
            Me.barButtonItem10.Caption = "Import from TXT"
            Me.barButtonItem10.Id = 10
            Me.barButtonItem10.Name = "barButtonItem10"
            '
            'barButtonItem11
            '
            Me.barButtonItem11.Caption = "Log out"
            Me.barButtonItem11.Id = 11
            Me.barButtonItem11.Name = "barButtonItem11"
            '
            'barButtonItem12
            '
            Me.barButtonItem12.Caption = "Log in"
            Me.barButtonItem12.Id = 12
            Me.barButtonItem12.Name = "barButtonItem12"
            '
            'barButtonItem13
            '
            Me.barButtonItem13.Caption = "View on WEB"
            Me.barButtonItem13.Id = 13
            Me.barButtonItem13.Name = "barButtonItem13"
            '
            'barButtonItem14
            '
            Me.barButtonItem14.Caption = "Print"
            Me.barButtonItem14.Id = 14
            Me.barButtonItem14.Name = "barButtonItem14"
            '
            'barButtonItem15
            '
            Me.barButtonItem15.Caption = "Exit"
            Me.barButtonItem15.Id = 15
            Me.barButtonItem15.Name = "barButtonItem15"
            '
            'ribbonPage1
            '
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "ribbonPage1"
            '
            'ribbonPageGroup1
            '
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
            '
            'repositoryItemTextEdit1
            '
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            '
            'DropDownButton1
            '
            Me.DropDownButton1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide
            Me.DropDownButton1.DropDownControl = Me.PopupMenu1
            Me.DropDownButton1.Location = New System.Drawing.Point(12, 168)
            Me.DropDownButton1.MenuManager = Me.ribbonControl1
            Me.DropDownButton1.Name = "DropDownButton1"
            Me.DropDownButton1.Size = New System.Drawing.Size(225, 33)
            Me.DropDownButton1.TabIndex = 1
            Me.DropDownButton1.Text = "Click here to display popup menu"
            '
            'PopupMenu1
            '
            Me.PopupMenu1.ItemLinks.Add(Me.barButtonItem1)
            Me.PopupMenu1.ItemLinks.Add(Me.barButtonItem2)
            Me.PopupMenu1.ItemLinks.Add(Me.barButtonItem3)
            Me.PopupMenu1.ItemLinks.Add(Me.barButtonItem4)
            Me.PopupMenu1.ItemLinks.Add(Me.barButtonItem5)
            Me.PopupMenu1.ItemLinks.Add(Me.barButtonItem6)
            Me.PopupMenu1.ItemLinks.Add(Me.barButtonItem7)
            Me.PopupMenu1.ItemLinks.Add(Me.barButtonItem8)
            Me.PopupMenu1.ItemLinks.Add(Me.barButtonItem9)
            Me.PopupMenu1.ItemLinks.Add(Me.barButtonItem10)
            Me.PopupMenu1.ItemLinks.Add(Me.barButtonItem11)
            Me.PopupMenu1.ItemLinks.Add(Me.barButtonItem12)
            Me.PopupMenu1.ItemLinks.Add(Me.barButtonItem13)
            Me.PopupMenu1.ItemLinks.Add(Me.barButtonItem14)
            Me.PopupMenu1.ItemLinks.Add(Me.barButtonItem15)
            Me.PopupMenu1.Name = "PopupMenu1"
            Me.PopupMenu1.Ribbon = Me.ribbonControl1
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(726, 620)
            Me.Controls.Add(Me.DropDownButton1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Ribbon = Me.ribbonControl1
            Me.Text = "Form1"
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.applicationMenu1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem4 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem5 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem6 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem7 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem8 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem9 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem10 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem11 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem12 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem13 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem14 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem15 As DevExpress.XtraBars.BarButtonItem
		Private applicationMenu1 As DevExpress.XtraBars.Ribbon.ApplicationMenu
        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Friend WithEvents DropDownButton1 As DevExpress.XtraEditors.DropDownButton
        Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
	End Class
End Namespace

