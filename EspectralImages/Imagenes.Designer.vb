﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Imagenes
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
        Me.pbPruebas = New System.Windows.Forms.PictureBox()
        CType(Me.pbPruebas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbPruebas
        '
        Me.pbPruebas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbPruebas.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbPruebas.Location = New System.Drawing.Point(12, 12)
        Me.pbPruebas.Name = "pbPruebas"
        Me.pbPruebas.Size = New System.Drawing.Size(564, 356)
        Me.pbPruebas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPruebas.TabIndex = 0
        Me.pbPruebas.TabStop = False
        '
        'Imagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 380)
        Me.Controls.Add(Me.pbPruebas)
        Me.Name = "Imagenes"
        Me.Text = "Imagenes"
        CType(Me.pbPruebas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbPruebas As System.Windows.Forms.PictureBox
End Class
