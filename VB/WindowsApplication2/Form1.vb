Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking

Namespace WindowsApplication2
	Partial Public Class Form1
		Inherits Form
		Private helper As DockHelper

		Public Sub New()
			InitializeComponent()
			helper = New DockHelper(dockManager1)
            helper.AllowDockToTabbedContainer = True
        End Sub


        Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
            MyBase.OnFormClosing(e)
            helper.AllowDockToTabbedContainer = False
        End Sub
	End Class
End Namespace