Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking

Namespace WindowsApplication2
    Public Class DockHelper
        Private manager As DockManager

        Public Sub New(ByVal manager As DockManager)
            Me.manager = manager
        End Sub

        Public WriteOnly Property AllowDockToTabbedContainer() As Boolean
            Set(ByVal value As Boolean)
                RemoveHandler manager.Docking, AddressOf OnDockManagerDocking
                If value Then
                    AddHandler manager.Docking, AddressOf OnDockManagerDocking
                End If
            End Set
        End Property

        Private Sub OnDockManagerDocking(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking.DockingEventArgs)
            If e.TargetPanel Is Nothing Then
                For Each p As DockPanel In manager.Panels
                    If p.Dock = e.Dock Then
                        e.Cancel = True
                        Return
                    End If
                Next p
            Else
                e.Cancel = e.Dock <> DockingStyle.Fill
            End If
        End Sub


    End Class
End Namespace
