<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgroDrone
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgroDrone))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGraficas = New System.Windows.Forms.Button()
        Me.btnAnalizar = New System.Windows.Forms.Button()
        Me.btnMapa = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCargarImages = New System.Windows.Forms.Button()
        Me.panelPrincipal = New System.Windows.Forms.Panel()
        Me.pGraficas = New System.Windows.Forms.Panel()
        Me.pAnalizar = New System.Windows.Forms.Panel()
        Me.btnObtenerDatos = New System.Windows.Forms.Button()
        Me.pbCollage = New System.Windows.Forms.PictureBox()
        Me.pMapa = New System.Windows.Forms.Panel()
        Me.btnCrearModelado = New System.Windows.Forms.Button()
        Me.mapa = New GMap.NET.WindowsForms.GMapControl()
        Me.ofdImages = New System.Windows.Forms.OpenFileDialog()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pbProcesos = New System.Windows.Forms.ProgressBar()
        Me.lblProcesos = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.pbInfectados = New System.Windows.Forms.PictureBox()
        Me.pbHidratacion = New System.Windows.Forms.PictureBox()
        Me.pAnalisis1 = New System.Windows.Forms.Panel()
        Me.pAnalisis2 = New System.Windows.Forms.Panel()
        Me.lblInfectados = New System.Windows.Forms.Label()
        Me.lblHidratacion = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPrincipal.SuspendLayout()
        Me.pGraficas.SuspendLayout()
        Me.pAnalizar.SuspendLayout()
        CType(Me.pbCollage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pMapa.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pbInfectados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHidratacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pAnalisis1.SuspendLayout()
        Me.pAnalisis2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Turquoise
        Me.Panel1.Controls.Add(Me.btnGraficas)
        Me.Panel1.Controls.Add(Me.btnAnalizar)
        Me.Panel1.Controls.Add(Me.btnMapa)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(975, 71)
        Me.Panel1.TabIndex = 0
        '
        'btnGraficas
        '
        Me.btnGraficas.BackColor = System.Drawing.Color.Turquoise
        Me.btnGraficas.Enabled = False
        Me.btnGraficas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGraficas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnGraficas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine
        Me.btnGraficas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraficas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGraficas.Location = New System.Drawing.Point(352, -4)
        Me.btnGraficas.Name = "btnGraficas"
        Me.btnGraficas.Size = New System.Drawing.Size(110, 75)
        Me.btnGraficas.TabIndex = 5
        Me.btnGraficas.Text = "Análisis"
        Me.btnGraficas.UseVisualStyleBackColor = False
        '
        'btnAnalizar
        '
        Me.btnAnalizar.BackColor = System.Drawing.Color.Turquoise
        Me.btnAnalizar.Enabled = False
        Me.btnAnalizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAnalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnAnalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine
        Me.btnAnalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnalizar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAnalizar.Location = New System.Drawing.Point(243, -4)
        Me.btnAnalizar.Name = "btnAnalizar"
        Me.btnAnalizar.Size = New System.Drawing.Size(110, 75)
        Me.btnAnalizar.TabIndex = 4
        Me.btnAnalizar.Text = "Modelo 2D"
        Me.btnAnalizar.UseVisualStyleBackColor = False
        '
        'btnMapa
        '
        Me.btnMapa.BackColor = System.Drawing.Color.Turquoise
        Me.btnMapa.Enabled = False
        Me.btnMapa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMapa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnMapa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine
        Me.btnMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMapa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMapa.Location = New System.Drawing.Point(134, -4)
        Me.btnMapa.Name = "btnMapa"
        Me.btnMapa.Size = New System.Drawing.Size(110, 75)
        Me.btnMapa.TabIndex = 3
        Me.btnMapa.Text = "Geolocalización"
        Me.btnMapa.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(32, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(136, 501)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnCargarImages
        '
        Me.btnCargarImages.AutoSize = True
        Me.btnCargarImages.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCargarImages.Location = New System.Drawing.Point(343, 158)
        Me.btnCargarImages.Name = "btnCargarImages"
        Me.btnCargarImages.Size = New System.Drawing.Size(126, 49)
        Me.btnCargarImages.TabIndex = 2
        Me.btnCargarImages.Text = "Cargar Imágenes"
        Me.btnCargarImages.UseVisualStyleBackColor = False
        '
        'panelPrincipal
        '
        Me.panelPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.panelPrincipal.BackgroundImage = CType(resources.GetObject("panelPrincipal.BackgroundImage"), System.Drawing.Image)
        Me.panelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelPrincipal.Controls.Add(Me.pGraficas)
        Me.panelPrincipal.Controls.Add(Me.pAnalizar)
        Me.panelPrincipal.Controls.Add(Me.pMapa)
        Me.panelPrincipal.Controls.Add(Me.btnCargarImages)
        Me.panelPrincipal.Location = New System.Drawing.Point(210, 138)
        Me.panelPrincipal.Name = "panelPrincipal"
        Me.panelPrincipal.Size = New System.Drawing.Size(690, 343)
        Me.panelPrincipal.TabIndex = 3
        '
        'pGraficas
        '
        Me.pGraficas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pGraficas.BackColor = System.Drawing.Color.Transparent
        Me.pGraficas.Controls.Add(Me.pAnalisis2)
        Me.pGraficas.Controls.Add(Me.pAnalisis1)
        Me.pGraficas.Location = New System.Drawing.Point(7, 3)
        Me.pGraficas.Name = "pGraficas"
        Me.pGraficas.Size = New System.Drawing.Size(399, 268)
        Me.pGraficas.TabIndex = 6
        Me.pGraficas.Visible = False
        '
        'pAnalizar
        '
        Me.pAnalizar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pAnalizar.BackColor = System.Drawing.Color.Transparent
        Me.pAnalizar.Controls.Add(Me.btnObtenerDatos)
        Me.pAnalizar.Controls.Add(Me.pbCollage)
        Me.pAnalizar.Location = New System.Drawing.Point(174, 3)
        Me.pAnalizar.Name = "pAnalizar"
        Me.pAnalizar.Size = New System.Drawing.Size(265, 337)
        Me.pAnalizar.TabIndex = 4
        Me.pAnalizar.Visible = False
        '
        'btnObtenerDatos
        '
        Me.btnObtenerDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnObtenerDatos.AutoSize = True
        Me.btnObtenerDatos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnObtenerDatos.Location = New System.Drawing.Point(92, 290)
        Me.btnObtenerDatos.Name = "btnObtenerDatos"
        Me.btnObtenerDatos.Size = New System.Drawing.Size(116, 31)
        Me.btnObtenerDatos.TabIndex = 5
        Me.btnObtenerDatos.Text = "Obtener Datos"
        Me.btnObtenerDatos.UseVisualStyleBackColor = False
        '
        'pbCollage
        '
        Me.pbCollage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbCollage.BackgroundImage = CType(resources.GetObject("pbCollage.BackgroundImage"), System.Drawing.Image)
        Me.pbCollage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbCollage.Image = CType(resources.GetObject("pbCollage.Image"), System.Drawing.Image)
        Me.pbCollage.Location = New System.Drawing.Point(92, 10)
        Me.pbCollage.Name = "pbCollage"
        Me.pbCollage.Size = New System.Drawing.Size(79, 274)
        Me.pbCollage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCollage.TabIndex = 0
        Me.pbCollage.TabStop = False
        '
        'pMapa
        '
        Me.pMapa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pMapa.BackColor = System.Drawing.Color.Transparent
        Me.pMapa.Controls.Add(Me.btnCrearModelado)
        Me.pMapa.Controls.Add(Me.mapa)
        Me.pMapa.Location = New System.Drawing.Point(445, 3)
        Me.pMapa.Name = "pMapa"
        Me.pMapa.Size = New System.Drawing.Size(233, 337)
        Me.pMapa.TabIndex = 3
        Me.pMapa.Visible = False
        '
        'btnCrearModelado
        '
        Me.btnCrearModelado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCrearModelado.AutoSize = True
        Me.btnCrearModelado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCrearModelado.Location = New System.Drawing.Point(110, 299)
        Me.btnCrearModelado.Name = "btnCrearModelado"
        Me.btnCrearModelado.Size = New System.Drawing.Size(116, 31)
        Me.btnCrearModelado.TabIndex = 4
        Me.btnCrearModelado.Text = "Crear Modelado 2D"
        Me.btnCrearModelado.UseVisualStyleBackColor = False
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
        Me.mapa.Location = New System.Drawing.Point(50, 10)
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
        Me.mapa.Size = New System.Drawing.Size(138, 274)
        Me.mapa.TabIndex = 0
        Me.mapa.Zoom = 16.0R
        '
        'ofdImages
        '
        Me.ofdImages.FileName = "OpenFileDialog1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.pbProcesos)
        Me.Panel3.Controls.Add(Me.lblProcesos)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(136, 538)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(839, 34)
        Me.Panel3.TabIndex = 4
        '
        'pbProcesos
        '
        Me.pbProcesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbProcesos.Location = New System.Drawing.Point(276, 5)
        Me.pbProcesos.Name = "pbProcesos"
        Me.pbProcesos.Size = New System.Drawing.Size(556, 23)
        Me.pbProcesos.TabIndex = 1
        Me.pbProcesos.Visible = False
        '
        'lblProcesos
        '
        Me.lblProcesos.AutoSize = True
        Me.lblProcesos.Location = New System.Drawing.Point(6, 9)
        Me.lblProcesos.Name = "lblProcesos"
        Me.lblProcesos.Size = New System.Drawing.Size(67, 13)
        Me.lblProcesos.TabIndex = 0
        Me.lblProcesos.Text = "Esperando..."
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(136, 71)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(839, 34)
        Me.Panel4.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(136, 504)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(839, 34)
        Me.Panel5.TabIndex = 6
        '
        'pbInfectados
        '
        Me.pbInfectados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbInfectados.Image = CType(resources.GetObject("pbInfectados.Image"), System.Drawing.Image)
        Me.pbInfectados.Location = New System.Drawing.Point(10, 35)
        Me.pbInfectados.Name = "pbInfectados"
        Me.pbInfectados.Size = New System.Drawing.Size(150, 80)
        Me.pbInfectados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbInfectados.TabIndex = 0
        Me.pbInfectados.TabStop = False
        '
        'pbHidratacion
        '
        Me.pbHidratacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbHidratacion.Image = CType(resources.GetObject("pbHidratacion.Image"), System.Drawing.Image)
        Me.pbHidratacion.Location = New System.Drawing.Point(35, 35)
        Me.pbHidratacion.Name = "pbHidratacion"
        Me.pbHidratacion.Size = New System.Drawing.Size(150, 80)
        Me.pbHidratacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHidratacion.TabIndex = 1
        Me.pbHidratacion.TabStop = False
        '
        'pAnalisis1
        '
        Me.pAnalisis1.Controls.Add(Me.lblInfectados)
        Me.pAnalisis1.Controls.Add(Me.pbInfectados)
        Me.pAnalisis1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pAnalisis1.Location = New System.Drawing.Point(0, 0)
        Me.pAnalisis1.Name = "pAnalisis1"
        Me.pAnalisis1.Size = New System.Drawing.Size(195, 268)
        Me.pAnalisis1.TabIndex = 2
        '
        'pAnalisis2
        '
        Me.pAnalisis2.Controls.Add(Me.lblHidratacion)
        Me.pAnalisis2.Controls.Add(Me.pbHidratacion)
        Me.pAnalisis2.Dock = System.Windows.Forms.DockStyle.Right
        Me.pAnalisis2.Location = New System.Drawing.Point(204, 0)
        Me.pAnalisis2.Name = "pAnalisis2"
        Me.pAnalisis2.Size = New System.Drawing.Size(195, 268)
        Me.pAnalisis2.TabIndex = 3
        '
        'lblInfectados
        '
        Me.lblInfectados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInfectados.AutoSize = True
        Me.lblInfectados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfectados.Location = New System.Drawing.Point(7, 141)
        Me.lblInfectados.Name = "lblInfectados"
        Me.lblInfectados.Size = New System.Drawing.Size(149, 15)
        Me.lblInfectados.TabIndex = 2
        Me.lblInfectados.Text = "Árboles infectados: 35"
        '
        'lblHidratacion
        '
        Me.lblHidratacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblHidratacion.AutoSize = True
        Me.lblHidratacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHidratacion.Location = New System.Drawing.Point(32, 141)
        Me.lblHidratacion.Name = "lblHidratacion"
        Me.lblHidratacion.Size = New System.Drawing.Size(173, 15)
        Me.lblHidratacion.TabIndex = 3
        Me.lblHidratacion.Text = "Nivel de Hidratación: 80%"
        '
        'AgroDrone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(975, 572)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.panelPrincipal)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AgroDrone"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgroDrone"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPrincipal.ResumeLayout(False)
        Me.panelPrincipal.PerformLayout()
        Me.pGraficas.ResumeLayout(False)
        Me.pAnalizar.ResumeLayout(False)
        Me.pAnalizar.PerformLayout()
        CType(Me.pbCollage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pMapa.ResumeLayout(False)
        Me.pMapa.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pbInfectados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHidratacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pAnalisis1.ResumeLayout(False)
        Me.pAnalisis1.PerformLayout()
        Me.pAnalisis2.ResumeLayout(False)
        Me.pAnalisis2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMapa As System.Windows.Forms.Button
    Friend WithEvents btnCargarImages As System.Windows.Forms.Button
    Friend WithEvents panelPrincipal As System.Windows.Forms.Panel
    Friend WithEvents btnGraficas As System.Windows.Forms.Button
    Friend WithEvents btnAnalizar As System.Windows.Forms.Button
    Friend WithEvents ofdImages As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblProcesos As System.Windows.Forms.Label
    Friend WithEvents pbProcesos As System.Windows.Forms.ProgressBar
    Friend WithEvents pMapa As System.Windows.Forms.Panel
    Friend WithEvents mapa As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents btnCrearModelado As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents pAnalizar As System.Windows.Forms.Panel
    Friend WithEvents pbCollage As System.Windows.Forms.PictureBox
    Friend WithEvents btnObtenerDatos As System.Windows.Forms.Button
    Friend WithEvents pGraficas As System.Windows.Forms.Panel
    Friend WithEvents pAnalisis2 As System.Windows.Forms.Panel
    Friend WithEvents pbHidratacion As System.Windows.Forms.PictureBox
    Friend WithEvents pAnalisis1 As System.Windows.Forms.Panel
    Friend WithEvents pbInfectados As System.Windows.Forms.PictureBox
    Friend WithEvents lblHidratacion As System.Windows.Forms.Label
    Friend WithEvents lblInfectados As System.Windows.Forms.Label
End Class
