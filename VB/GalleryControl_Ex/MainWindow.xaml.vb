Imports System.Windows
Imports System.Windows.Controls

Namespace GalleryControl_Ex

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Gallery_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.GalleryItemEventArgs)
            MessageBox.Show("The " & e.Item.Caption & " item has been clicked")
        End Sub
    End Class
End Namespace
