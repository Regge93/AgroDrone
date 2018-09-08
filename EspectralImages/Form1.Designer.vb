<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCargarImagenes = New System.Windows.Forms.Button()
        Me.tablaImagenes = New System.Windows.Forms.DataGridView()
        Me.ofdAbrirImage = New System.Windows.Forms.OpenFileDialog()
        Me.btnGeolocalizar = New System.Windows.Forms.Button()
        Me.mapa = New GMap.NET.WindowsForms.GMapControl()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblProcesos = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.tablaImagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCargarImagenes
        '
        Me.btnCargarImagenes.Location = New System.Drawing.Point(12, 12)
        Me.btnCargarImagenes.Name = "btnCargarImagenes"
        Me.btnCargarImagenes.Size = New System.Drawing.Size(107, 23)
        Me.btnCargarImagenes.TabIndex = 0
        Me.btnCargarImagenes.Text = "Cargar Imágenes"
        Me.btnCargarImagenes.UseVisualStyleBackColor = True
        '
        'tablaImagenes
        '
        Me.tablaImagenes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tablaImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaImagenes.Location = New System.Drawing.Point(12, 41)
        Me.tablaImagenes.Name = "tablaImagenes"
        Me.tablaImagenes.Size = New System.Drawing.Size(469, 358)
        Me.tablaImagenes.TabIndex = 1
        '
        'ofdAbrirImage
        '
        Me.ofdAbrirImage.FileName = "OpenFileDialog1"
        '
        'btnGeolocalizar
        '
        Me.btnGeolocalizar.Location = New System.Drawing.Point(125, 12)
        Me.btnGeolocalizar.Name = "btnGeolocalizar"
        Me.btnGeolocalizar.Size = New System.Drawing.Size(107, 23)
        Me.btnGeolocalizar.TabIndex = 3
        Me.btnGeolocalizar.Text = "Geolocalizar"
        Me.btnGeolocalizar.UseVisualStyleBackColor = True
        '
        'mapa
        '
        Me.mapa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mapa.Bearing = 0.0!
        Me.mapa.CanDragMap = True
        Me.mapa.EmptyTileColor = System.Drawing.Color.Navy
        Me.mapa.GrayScaleMode = False
        Me.mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.mapa.LevelsKeepInMemmory = 5
        Me.mapa.Location = New System.Drawing.Point(487, 41)
        Me.mapa.MarkersEnabled = True
        Me.mapa.MaxZoom = 18
        Me.mapa.MinZoom = 2
        Me.mapa.MouseWheelZoomEnabled = True
        Me.mapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.mapa.Name = "mapa"
        Me.mapa.NegativeMode = False
        Me.mapa.PolygonsEnabled = True
        Me.mapa.RetryLoadTile = 0
        Me.mapa.RoutesEnabled = True
        Me.mapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.mapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.mapa.ShowTileGridLines = False
        Me.mapa.Size = New System.Drawing.Size(475, 358)
        Me.mapa.TabIndex = 4
        Me.mapa.Visible = False
        Me.mapa.Zoom = 17.0R
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(487, 12)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(475, 23)
        Me.ProgressBar1.TabIndex = 5
        '
        'lblProcesos
        '
        Me.lblProcesos.AutoSize = True
        Me.lblProcesos.Location = New System.Drawing.Point(310, 17)
        Me.lblProcesos.Name = "lblProcesos"
        Me.lblProcesos.Size = New System.Drawing.Size(67, 13)
        Me.lblProcesos.TabIndex = 6
        Me.lblProcesos.Text = "Esperando..."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(238, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Geolocalizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 411)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblProcesos)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.mapa)
        Me.Controls.Add(Me.btnGeolocalizar)
        Me.Controls.Add(Me.tablaImagenes)
        Me.Controls.Add(Me.btnCargarImagenes)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.tablaImagenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCargarImagenes As System.Windows.Forms.Button
    Friend WithEvents tablaImagenes As System.Windows.Forms.DataGridView
    Friend WithEvents ofdAbrirImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnGeolocalizar As System.Windows.Forms.Button
    Friend WithEvents mapa As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblProcesos As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
