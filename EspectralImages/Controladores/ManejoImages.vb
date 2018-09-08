Imports System.Math

Public Class ManejoImages

    Public Shared totalElementos As Integer
    Public Shared lista As ArrayList = New ArrayList(totalElementos)
    Public Shared dt As New DataTable

    'radio de la Tierra
    Private R As Double = 6367000

    Public Function Convertir(ByVal grados As Integer, ByVal minutos As Integer, ByVal segundos As Integer) As Double
        Dim seg As Double = CDbl(segundos)
        seg = seg / 10000
        Dim res As Double = grados + (minutos / 60) + (seg / 3600)
        Return res
    End Function

    Public Sub combinarImages()
        Dim PicColor1, PicColor2 As Color
        Dim r, g, b As Integer
        Try
            Dim image1 As Image = Image.FromFile(lista.Item(0))
            Dim image2 As Image = Image.FromFile(lista.Item(1))

            Dim imgTemp1 As New Bitmap(image1, image1.Width, image1.Height)
            Dim imgTemp2 As New Bitmap(image2, image2.Width, image2.Height)
            Dim imgTempFinal As New Bitmap(image1.Width, image1.Height)

            For y = 0 To image1.Height - 1
                For x = 0 To image1.Width - 1
                    PicColor1 = imgTemp1.GetPixel(x, y)
                    PicColor2 = imgTemp2.GetPixel(x, y)
                    r = (CInt(PicColor1.R) + CInt(PicColor2.R)) / 2
                    g = (CInt(PicColor1.G) + CInt(PicColor2.G)) / 2
                    b = (CInt(PicColor1.B) + CInt(PicColor2.B)) / 2
                    imgTempFinal.SetPixel(x, y, Color.FromArgb(r, g, b))
                Next
            Next
            Imagenes.pbPruebas.Image = imgTempFinal
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub Distancia()
        Dim latitud1 As Double = (PI / 180) * CDbl(Form1.tablaImagenes.Item(1, 0).Value)
        Dim latitud2 As Double = (PI / 180) * CDbl(Form1.tablaImagenes.Item(1, 1).Value)
        Dim longitud1 As Double = (PI / 180) * CDbl(Form1.tablaImagenes.Item(2, 0).Value)
        Dim longitud2 As Double = (PI / 180) * CDbl(Form1.tablaImagenes.Item(2, 1).Value)

        Dim dlon As Double = longitud2 - longitud1
        Dim dlat As Double = latitud2 - latitud1
        Dim a As Double = Sin2(dlat / 2) + Cos(latitud1) * Cos(latitud2) * Sin2(dlon / 2)
        Dim c As Double = 2 * Asin(Min(1, Sqrt(a)))
        Dim distancia As Double = Round(R * c, 2)

        MsgBox(distancia)
    End Sub

    Private Function Sin2(ByVal x As Double) As Double
        'sen^2(x) = 1/2 - 1/2 cos(2x)
        Dim res As Double = 1 / 2 - 1 / 2 * Cos(2 * x)
        Return res
    End Function

    Public Sub graficar()
        Dim maxLat, minLat, maxLon, minLon As Double
        For x = 0 To Form1.tablaImagenes.Rows.Count - 2
            Dim lat As Double = Form1.tablaImagenes.Item(1, x).Value
            If maxLat < lat Then
                maxLat = lat
            End If
            If minLat > lat Or minLat = 0 Then
                minLat = lat
            End If

            Dim lon As Double = Form1.tablaImagenes.Item(2, x).Value
            If maxLon < lon Or maxLon = 0 Then
                maxLon = lon
            End If
            If minLon > lon Then
                minLon = lon
            End If
        Next

        'Dim mitad As Double = (maxLat + minLat) / 2
        Dim xU As Integer = Math.Round((((maxLat + minLat) / 2) + maxLat) * 100, 2)
        Dim yU As Integer = Math.Round((((maxLon + minLon) / 2) + maxLon) * 100, 2)

        Imagenes.Show()
        Imagenes.pbPruebas.Width = 200
        Imagenes.pbPruebas.Height = 200

        Imagenes.pbPruebas.CreateGraphics.DrawEllipse(New Pen(Color.Red, 20), 50, 20, 20, 20)
        Imagenes.pbPruebas.CreateGraphics.DrawEllipse(Pens.LimeGreen, 100, 100, 30, 30)
    End Sub

End Class
