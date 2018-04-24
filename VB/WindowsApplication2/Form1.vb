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
        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged
            Dim check As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
            If check IsNot Nothing Then
                helper.AllowDockToTabbedContainer = check.Checked
            End If
        End Sub
    End Class
End Namespace