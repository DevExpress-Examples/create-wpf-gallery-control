Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace GalleryControl_Ex
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Gallery_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.GalleryItemEventArgs)
			MessageBox.Show("The " & e.Item.Caption & " item has been clicked")
		End Sub
	End Class
End Namespace
