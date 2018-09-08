Public Class Imagenes
    Private Sub Imagenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'combinarImages()
        'combinar()
    End Sub

    'Private Sub combinarImages()
    '    Dim PicColor1, PicColor2 As Color
    '    Dim r, g, b As Integer
    '    Try
    '        Dim image1 As Image = Image.FromFile(ManejoImages.lista.Item(0))
    '        Dim image2 As Image = Image.FromFile(ManejoImages.lista.Item(1))

    '        Dim imgTemp1 As New Bitmap(image1, image1.Width, image1.Height)
    '        Dim imgTemp2 As New Bitmap(image2, image2.Width, image2.Height)
    '        Dim imgTempFinal As New Bitmap(image1.Width, image1.Height)

    '        For y = 0 To image1.Height - 1
    '            For x = 0 To image1.Width - 1
    '                PicColor1 = imgTemp1.GetPixel(x, y)
    '                PicColor2 = imgTemp2.GetPixel(x, y)
    '                r = (CInt(PicColor1.R) + CInt(PicColor2.R)) / 2
    '                g = (CInt(PicColor1.G) + CInt(PicColor2.G)) / 2
    '                b = (CInt(PicColor1.B) + CInt(PicColor2.B)) / 2
    '                imgTempFinal.SetPixel(x, y, Color.FromArgb(r, g, b))
    '            Next
    '        Next
    '        pbPruebas.Image = imgTempFinal
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try
    'End Sub

    Private Sub combinar()
        Dim r, g, b, desplazoX As Integer
        desplazoX = 0

        Dim empezo As Boolean = False

        Dim imagen1 As Image = Image.FromFile(ManejoImages.lista.Item(0))
        Dim imagen2 As Image = Image.FromFile(ManejoImages.lista.Item(1))

        Dim imgTemp1 As New Bitmap(imagen1, imagen1.Width, imagen1.Height)
        Dim imgTemp2 As New Bitmap(imagen2, imagen2.Width, imagen2.Height)

        Dim matriz1(imagen1.Height) As Color
        Dim matriz2(imagen2.Height) As Color

        For x = 0 To imagen1.Width - 1
            Dim valoracion As Integer = 0
            If empezo = False Then
                For y = 0 To imagen1.Height - 1
                    matriz1(y) = imgTemp1.GetPixel(x, y)
                    If x = 0 Then
                        matriz2(y) = imgTemp2.GetPixel(0, y)
                    End If
                Next

                For i = 0 To matriz1.Length - 1
                    Dim num1 As Double = Math.Round(matriz1(i).ToArgb / 100000, 1)
                    Dim num2 As Double = Math.Round(matriz2(i).ToArgb / 100000, 1)

                    If num1 = num2 Then
                        valoracion += 1
                    End If
                Next

                If valoracion < 180 Then
                    desplazoX += 1
                Else
                    empezo = True
                End If
                MsgBox(valoracion.ToString + " --- " + x.ToString)
            End If


            'If matriz1.SequenceEqual(matriz2) Then
            'Else
            '    desplazoX += 1
            'End If
            'Dim salida As String = "x:" + x.ToString _
            '                       + vbLf + matriz1(0).ToArgb.ToString + " : " + matriz2(0).ToArgb.ToString _
            '                       + vbLf + matriz1(1).ToArgb.ToString + " : " + matriz2(1).ToArgb.ToString _
            '                       + vbLf + matriz1(2).ToArgb.ToString + " : " + matriz2(2).ToArgb.ToString _
            '                       + vbLf + matriz1(3).ToArgb.ToString + " : " + matriz2(3).ToArgb.ToString _
            '                       + vbLf + matriz1(4).ToArgb.ToString + " : " + matriz2(4).ToArgb.ToString _
            '                       + vbLf + matriz1(5).ToArgb.ToString + " : " + matriz2(5).ToArgb.ToString _
            '                       + vbLf + matriz1(6).ToArgb.ToString + " : " + matriz2(6).ToArgb.ToString _
            '                       + vbLf + matriz1(7).ToArgb.ToString + " : " + matriz2(7).ToArgb.ToString _
            '                       + vbLf + matriz1(8).ToArgb.ToString + " : " + matriz2(8).ToArgb.ToString _
            '                       + vbLf + matriz1(9).ToArgb.ToString + " : " + matriz2(9).ToArgb.ToString _
            '                       + vbLf + matriz1(10).ToArgb.ToString + " : " + matriz2(10).ToArgb.ToString _
            '                       + vbLf + matriz1(11).ToArgb.ToString + " : " + matriz2(11).ToArgb.ToString
            'MsgBox(salida)
        Next

        Dim width As Integer = imagen2.Width + desplazoX
        Dim imgTempFinal As New Bitmap(width, imagen1.Height)

        Dim color1, color2 As Color

        For y = 0 To imagen1.Height - 1
            For x = 0 To width - 1
                Try
                    If x < desplazoX Then
                        imgTempFinal.SetPixel(x, y, imgTemp1.GetPixel(x, y))
                    Else
                        If x < imagen1.Width Then
                            color1 = imgTemp1.GetPixel(x, y)
                            color2 = imgTemp2.GetPixel(x - desplazoX, y)
                            r = (CInt(color1.R) + CInt(color2.R)) / 2
                            g = (CInt(color1.G) + CInt(color2.G)) / 2
                            b = (CInt(color1.B) + CInt(color2.B)) / 2
                            imgTempFinal.SetPixel(x, y, Color.FromArgb(r, g, b))
                        Else
                            imgTempFinal.SetPixel(x, y, imgTemp2.GetPixel(x - desplazoX, y))
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString + vbLf + "x:" + x.ToString + " y:" + y.ToString)
                End Try
            Next
        Next
        pbPruebas.Image = imgTempFinal
    End Sub

End Class