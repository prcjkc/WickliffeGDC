﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pbSurface = New System.Windows.Forms.PictureBox()
        CType(Me.pbSurface, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbSurface
        '
        Me.pbSurface.BackColor = System.Drawing.Color.Black
        Me.pbSurface.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbSurface.Location = New System.Drawing.Point(0, 0)
        Me.pbSurface.Name = "pbSurface"
        Me.pbSurface.Size = New System.Drawing.Size(284, 261)
        Me.pbSurface.TabIndex = 0
        Me.pbSurface.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.pbSurface)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbSurface, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbSurface As PictureBox
End Class
