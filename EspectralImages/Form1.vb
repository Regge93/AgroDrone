Imports System.Text
Imports System.Drawing.Imaging
Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers

Public Class Form1

    Private cmd As New ManejoImages
    Private archivos() As String
    Private proc As Integer = 0

    Private Sub btnCargarImagenes_Click(sender As Object, e As EventArgs) Handles btnCargarImagenes.Click
        ofdAbrirImage.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*"
        ofdAbrirImage.Multiselect = True
        lblProcesos.Text = "Cargando imágenes"
        If ofdAbrirImage.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ManejoImages.lista.Clear()
            proc = 0
            archivos = ofdAbrirImage.FileNames
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
        ofdAbrirImage.Dispose()
    End Sub

    Private Sub ProcesarImages()
        Application.DoEvents()
        Dim dt As New DataTable
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Latitud")
        dt.Columns.Add("Longitud")
        dt.Columns.Add("Altitud")

        Dim enumarator As IEnumerator = ManejoImages.lista.GetEnumerator

        While enumarator.MoveNext()
            Dim dr As DataRow = dt.NewRow()
            Dim nombre As String
            nombre = New IO.FileInfo(ManejoImages.lista.Item(proc)).Name
            dr("Nombre") = nombre

            Dim data() As String = ObtenerDatos(Image.FromFile(ManejoImages.lista.Item(proc)))

            dr("Latitud") = data(0)
            dr("Longitud") = data(1)
            dr("Altitud") = data(2)

            dt.Rows.Add(dr)
            proc += 1
        End While
        tablaImagenes.DataSource = dt
        dt.Dispose()
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

    Private Sub btnGeolocalizar_Click(sender As Object, e As EventArgs) Handles btnGeolocalizar.Click
        mapa.Visible = True
        Marcadores(Contar())
    End Sub

    Private Function Contar() As Double(,)
        Dim datos(ManejoImages.totalElementos, 2) As Double
        For i = 0 To ManejoImages.totalElementos - 1
            datos(i, 0) = tablaImagenes.Item(1, i).Value
            datos(i, 1) = tablaImagenes.Item(2, i).Value
        Next i
        Return datos
    End Function

    Public Sub Marcadores(ByVal coordenadas(,) As Double)
        lblProcesos.Text = "Geolocalizando"
        Application.DoEvents()
        mapa.MapProvider = MapProviders.GoogleHybridMapProvider.Instance
        GMaps.Instance.Mode = AccessMode.ServerOnly
        'mapa.Position = New PointLatLng(20.4561596388889, -97.1977513611111) 'Río Tecolutla
        mapa.Position = New PointLatLng(coordenadas(0, 0), coordenadas(0, 1))
        mapa.ShowCenter = False

        Dim markers As GMapOverlay = New GMapOverlay("markers")
        For i = 0 To coordenadas.GetUpperBound(0) - 1
            Dim latitud As Double = coordenadas(i, 0)
            Dim longitud As Double = coordenadas(i, 1)
            Dim marker As GMapMarker = New Markers.GMarkerGoogle(New PointLatLng(latitud, longitud), GMarkerGoogleType.red)
            markers.Markers.Add(marker)
        Next i
        mapa.Overlays.Add(markers)
        lblProcesos.Text = "Geolocalización finalizada"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Imagenes.Show()
        'cmd.Distancia()
        cmd.graficar()
    End Sub
End Class
