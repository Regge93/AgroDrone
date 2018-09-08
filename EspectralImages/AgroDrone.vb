Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Imports System.Drawing.Imaging

Public Class AgroDrone

    Private cmd As New ManejoImages
    Private archivos() As String
    Private proc As Integer = 0
    Private tblmgs As TablaImages = New TablaImages

    Private Sub btnCargarImages_Click(sender As Object, e As EventArgs) Handles btnCargarImages.Click
        ofdImages.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*"
        ofdImages.Multiselect = True
        lblProcesos.Text = "Cargando imágenes"
        If ofdImages.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ManejoImages.lista.Clear()
            proc = 0
            archivos = ofdImages.FileNames
            Dim i As Integer
            For i = 0 To archivos.Length - 1
                ManejoImages.lista.Add(archivos(i))
            Next
            ManejoImages.totalElementos = ManejoImages.lista.Count
            lblProcesos.Text = "Procesando imágenes"
            ProcesarImages()
            lblProcesos.Text = "Datos adquiridos"
        Else
            lblProcesos.Text = "Esperando..."
        End If
        ofdImages.Dispose()
    End Sub

    Private Sub ProcesarImages()
        Application.DoEvents()

        ManejoImages.dt.Columns.Add("Nombre")
        ManejoImages.dt.Columns.Add("Latitud")
        ManejoImages.dt.Columns.Add("Longitud")
        ManejoImages.dt.Columns.Add("Altitud")

        Dim enumarator As IEnumerator = ManejoImages.lista.GetEnumerator

        While enumarator.MoveNext()
            Dim dr As DataRow = ManejoImages.dt.NewRow()
            Dim nombre As String
            nombre = New IO.FileInfo(ManejoImages.lista.Item(proc)).Name
            dr("Nombre") = nombre

            Dim data() As String = ObtenerDatos(Image.FromFile(ManejoImages.lista.Item(proc)))

            dr("Latitud") = data(0)
            dr("Longitud") = data(1)
            dr("Altitud") = data(2)

            ManejoImages.dt.Rows.Add(dr)
            proc += 1
        End While

        TablaImages.ShowDialog()
    End Sub

    Private Function ObtenerDatos(ByVal targetImg As Image) As String()
        Dim datos(3) As String

        Try
            Dim latitud As PropertyItem = targetImg.GetPropertyItem(2)
            Dim longitud As PropertyItem = targetImg.GetPropertyItem(4)
            Dim altitud As PropertyItem = targetImg.GetPropertyItem(6)

            datos(0) = CStr(cmd.Convertir(BitConverter.ToUInt32(latitud.Value, 0), BitConverter.ToUInt32(latitud.Value, 8), BitConverter.ToUInt32(latitud.Value, 16)))
            datos(1) = "-" + CStr(cmd.Convertir(BitConverter.ToUInt32(longitud.Value, 0), BitConverter.ToUInt32(longitud.Value, 8), BitConverter.ToUInt32(longitud.Value, 16)))
            datos(2) = CStr(CDbl(BitConverter.ToUInt32(altitud.Value, 0)) / 1000) + "m"
        Catch ex As Exception
            MsgBox(ex.ToString)
            datos(0) = "0"
            datos(1) = "0"
            datos(2) = "0"
        Finally
            targetImg.Dispose()
        End Try

        Return datos
    End Function

    Public Sub Geolocalizar()
        TablaImages.Hide()
        btnMapa.BackColor = Color.LightSeaGreen
        btnMapa.Enabled = True
        pMapa.Visible = True
        Application.DoEvents()
        Marcadores(Contar())
    End Sub

    Private Function Contar() As Double(,)
        Dim datos(ManejoImages.totalElementos, 2) As Double
        For i = 0 To ManejoImages.totalElementos - 1
            datos(i, 0) = TablaImages.tbl_images.Item(1, i).Value
            datos(i, 1) = TablaImages.tbl_images.Item(2, i).Value
        Next i
        Return datos
    End Function

    Public Sub Marcadores(ByVal coordenadas(,) As Double)
        lblProcesos.Text = "Geolocalizando"
        Application.DoEvents()
        mapa.MapProvider = MapProviders.BingHybridMapProvider.Instance
        GMaps.Instance.Mode = AccessMode.ServerOnly
        'mapa.Position = New PointLatLng(20.4561596388889, -97.1977513611111) 'Río Tecolutla
        mapa.Position = New PointLatLng(coordenadas(0, 0), coordenadas(0, 1))
        mapa.ShowCenter = False

        Dim markers As GMapOverlay = New GMapOverlay("markers")
        For i = 0 To coordenadas.GetUpperBound(0) - 1
            Dim latitud As Double = coordenadas(i, 0)
            Dim longitud As Double = coordenadas(i, 1)
            Dim marker As GMapMarker = New Markers.GMarkerGoogle(New PointLatLng(latitud, longitud), New Bitmap(Image.FromFile("red-circle.png"), 10, 10))
            'Dim marker As GMapMarker = New Markers.GMarkerGoogle(New PointLatLng(latitud, longitud), GMarkerGoogleType.red)
            markers.Markers.Add(marker)
        Next i
        mapa.Overlays.Add(markers)
        lblProcesos.Text = "Geolocalización finalizada"
    End Sub

    Private Sub btnCrearModelado_Click(sender As Object, e As EventArgs) Handles btnCrearModelado.Click
        btnAnalizar.Enabled = True
        btnAnalizar.BackColor = Color.LightSeaGreen
        btnMapa.BackColor = Color.Turquoise

        btnAnalizar.Enabled = True

        pMapa.Visible = False
        pAnalizar.Visible = True
        'panelPruebas.CreateGraphics.DrawEllipse(New Pen(Color.Red, 20), 50, 20, 5, 5)
    End Sub

    Private Sub btnObtenerDatos_Click(sender As Object, e As EventArgs) Handles btnObtenerDatos.Click
        btnAnalizar.BackColor = Color.Turquoise
        btnGraficas.BackColor = Color.LightSeaGreen

        btnGraficas.Enabled = True

        pAnalizar.Visible = False
        pGraficas.Visible = True
    End Sub

#Region "Botones superiores"
    Private Sub btnMapa_Click(sender As Object, e As EventArgs) Handles btnMapa.Click
        btnMapa.BackColor = Color.LightSeaGreen
        btnAnalizar.BackColor = Color.Turquoise
        btnGraficas.BackColor = Color.Turquoise
        pAnalizar.Visible = False
        pGraficas.Visible = False
        pMapa.Visible = True
    End Sub

    Private Sub btnAnalizar_Click(sender As Object, e As EventArgs) Handles btnAnalizar.Click
        btnMapa.BackColor = Color.Turquoise
        btnAnalizar.BackColor = Color.LightSeaGreen
        btnGraficas.BackColor = Color.Turquoise
        pMapa.Visible = False
        pGraficas.Visible = False
        pAnalizar.Visible = True
    End Sub

    Private Sub btnGraficas_Click(sender As Object, e As EventArgs) Handles btnGraficas.Click
        btnMapa.BackColor = Color.Turquoise
        btnAnalizar.BackColor = Color.Turquoise
        btnGraficas.BackColor = Color.LightSeaGreen
        pMapa.Visible = False
        pAnalizar.Visible = False
        pGraficas.Visible = True
    End Sub
#End Region

    Private Sub AgroDrone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim widthPanel As Integer = panelPrincipal.Width - 20
        Dim heightPanel As Integer = panelPrincipal.Height - 10
        Dim punto As New Point(10, 5)
        Dim tamanio As New Drawing.Size(widthPanel, heightPanel)

        pMapa.Size = tamanio
        pMapa.Location = punto
        pMapa.Visible = False

        pAnalizar.Size = tamanio
        pAnalizar.Location = punto
        pAnalizar.Visible = False

        pGraficas.Size = tamanio
        pGraficas.Location = punto
        pGraficas.Visible = False
    End Sub

    Private Sub AgroDrone_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim x As Integer = (panelPrincipal.Width / 2) - (btnCargarImages.Width / 2)
        Dim y As Integer = (panelPrincipal.Height / 2) - (btnCargarImages.Height / 2)

        btnCargarImages.Location = New Point(x, y)
    End Sub
End Class