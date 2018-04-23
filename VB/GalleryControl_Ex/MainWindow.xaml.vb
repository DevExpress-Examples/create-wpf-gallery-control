Class MainWindow 

    Private Sub Gallery_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.Xpf.Bars.GalleryItemEventArgs)
        MessageBox.Show("The " + e.Item.Caption + " item has been clicked")
    End Sub
End Class
