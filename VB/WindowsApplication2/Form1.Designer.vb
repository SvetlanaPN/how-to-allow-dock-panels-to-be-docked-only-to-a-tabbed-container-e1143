Namespace WindowsApplication2
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
            Me.barAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
            Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel2.SuspendLayout()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dockManager1
            ' 
            Me.dockManager1.Controller = Me.barAndDockingController1
            Me.dockManager1.Form = Me
            Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.dockPanel1, Me.dockPanel2})
            Me.dockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
            ' 
            ' dockPanel1
            ' 
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel1.ID = New System.Guid("ceec664a-9ee8-4f0d-ac3f-f7dde1ba82a6")
            Me.dockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel1.Size = New System.Drawing.Size(200, 431)
            Me.dockPanel1.Text = "dockPanel1"
            ' 
            ' dockPanel1_Container
            ' 
            Me.dockPanel1_Container.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(192, 404)
            Me.dockPanel1_Container.TabIndex = 0
            ' 
            ' dockPanel2
            ' 
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel2.ID = New System.Guid("1d795194-49f1-402f-87bb-8645166b5ba0")
            Me.dockPanel2.Location = New System.Drawing.Point(494, 0)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel2.Size = New System.Drawing.Size(200, 431)
            Me.dockPanel2.Text = "dockPanel2"
            ' 
            ' dockPanel2_Container
            ' 
            Me.dockPanel2_Container.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(192, 404)
            Me.dockPanel2_Container.TabIndex = 0
            ' 
            ' checkEdit1
            ' 
            Me.checkEdit1.Location = New System.Drawing.Point(269, 12)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "AllowDockToTabbedContainer"
            Me.checkEdit1.Size = New System.Drawing.Size(168, 19)
            Me.checkEdit1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(694, 431)
            Me.Controls.Add(Me.dockPanel1)
            Me.Controls.Add(Me.dockPanel2)
            Me.Controls.Add(Me.checkEdit1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel2.ResumeLayout(False)
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private barAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
        Private dockManager1 As DevExpress.XtraBars.Docking.DockManager
        Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Private dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit

    End Class
End Namespace

