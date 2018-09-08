Public Class TablaImages

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        AgroDrone.Geolocalizar()
    End Sub

    Private Sub TablaImages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbl_images.DataSource = ManejoImages.dt
        ManejoImages.dt.Dispose()
    End Sub
End Class