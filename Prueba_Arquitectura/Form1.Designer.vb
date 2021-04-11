<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnl_izquierda = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_acercade = New System.Windows.Forms.Button()
        Me.pnl_perfil = New System.Windows.Forms.Panel()
        Me.btn_perfil = New System.Windows.Forms.Button()
        Me.pnl_conta = New System.Windows.Forms.Panel()
        Me.btn_conta = New System.Windows.Forms.Button()
        Me.pnl_inve = New System.Windows.Forms.Panel()
        Me.btn_inve = New System.Windows.Forms.Button()
        Me.pnl_arriba = New System.Windows.Forms.Panel()
        Me.pnl_acercade = New System.Windows.Forms.Panel()
        Me.btn_minimi = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.pnl_izquierda.SuspendLayout()
        Me.pnl_arriba.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_izquierda
        '
        Me.pnl_izquierda.BackColor = System.Drawing.Color.LightGray
        Me.pnl_izquierda.Controls.Add(Me.Panel1)
        Me.pnl_izquierda.Controls.Add(Me.btn_acercade)
        Me.pnl_izquierda.Controls.Add(Me.pnl_perfil)
        Me.pnl_izquierda.Controls.Add(Me.btn_perfil)
        Me.pnl_izquierda.Controls.Add(Me.pnl_conta)
        Me.pnl_izquierda.Controls.Add(Me.btn_conta)
        Me.pnl_izquierda.Controls.Add(Me.pnl_inve)
        Me.pnl_izquierda.Controls.Add(Me.btn_inve)
        Me.pnl_izquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_izquierda.Location = New System.Drawing.Point(0, 0)
        Me.pnl_izquierda.Name = "pnl_izquierda"
        Me.pnl_izquierda.Size = New System.Drawing.Size(233, 500)
        Me.pnl_izquierda.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Location = New System.Drawing.Point(0, 298)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 42)
        Me.Panel1.TabIndex = 8
        '
        'btn_acercade
        '
        Me.btn_acercade.FlatAppearance.BorderSize = 0
        Me.btn_acercade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_acercade.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_acercade.ForeColor = System.Drawing.Color.Black
        Me.btn_acercade.Image = Global.Prueba_Arquitectura.My.Resources.Resources.info
        Me.btn_acercade.Location = New System.Drawing.Point(0, 298)
        Me.btn_acercade.Name = "btn_acercade"
        Me.btn_acercade.Size = New System.Drawing.Size(233, 42)
        Me.btn_acercade.TabIndex = 7
        Me.btn_acercade.Text = "     Acerca de"
        Me.btn_acercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_acercade.UseVisualStyleBackColor = True
        '
        'pnl_perfil
        '
        Me.pnl_perfil.BackColor = System.Drawing.Color.DimGray
        Me.pnl_perfil.Location = New System.Drawing.Point(0, 230)
        Me.pnl_perfil.Name = "pnl_perfil"
        Me.pnl_perfil.Size = New System.Drawing.Size(10, 42)
        Me.pnl_perfil.TabIndex = 6
        '
        'btn_perfil
        '
        Me.btn_perfil.FlatAppearance.BorderSize = 0
        Me.btn_perfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_perfil.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_perfil.ForeColor = System.Drawing.Color.Black
        Me.btn_perfil.Image = Global.Prueba_Arquitectura.My.Resources.Resources.perfil1
        Me.btn_perfil.Location = New System.Drawing.Point(0, 230)
        Me.btn_perfil.Name = "btn_perfil"
        Me.btn_perfil.Size = New System.Drawing.Size(233, 42)
        Me.btn_perfil.TabIndex = 5
        Me.btn_perfil.Text = "     Perfil"
        Me.btn_perfil.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_perfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_perfil.UseVisualStyleBackColor = True
        '
        'pnl_conta
        '
        Me.pnl_conta.BackColor = System.Drawing.Color.DimGray
        Me.pnl_conta.Location = New System.Drawing.Point(0, 165)
        Me.pnl_conta.Name = "pnl_conta"
        Me.pnl_conta.Size = New System.Drawing.Size(10, 42)
        Me.pnl_conta.TabIndex = 4
        '
        'btn_conta
        '
        Me.btn_conta.FlatAppearance.BorderSize = 0
        Me.btn_conta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_conta.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_conta.ForeColor = System.Drawing.Color.Black
        Me.btn_conta.Image = Global.Prueba_Arquitectura.My.Resources.Resources.conta
        Me.btn_conta.Location = New System.Drawing.Point(0, 165)
        Me.btn_conta.Name = "btn_conta"
        Me.btn_conta.Size = New System.Drawing.Size(233, 42)
        Me.btn_conta.TabIndex = 3
        Me.btn_conta.Text = "    Contabilidad"
        Me.btn_conta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_conta.UseVisualStyleBackColor = True
        '
        'pnl_inve
        '
        Me.pnl_inve.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.pnl_inve.Location = New System.Drawing.Point(0, 100)
        Me.pnl_inve.Name = "pnl_inve"
        Me.pnl_inve.Size = New System.Drawing.Size(10, 42)
        Me.pnl_inve.TabIndex = 2
        '
        'btn_inve
        '
        Me.btn_inve.FlatAppearance.BorderSize = 0
        Me.btn_inve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inve.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_inve.ForeColor = System.Drawing.Color.Black
        Me.btn_inve.Image = Global.Prueba_Arquitectura.My.Resources.Resources.inventario
        Me.btn_inve.Location = New System.Drawing.Point(0, 100)
        Me.btn_inve.Name = "btn_inve"
        Me.btn_inve.Size = New System.Drawing.Size(233, 42)
        Me.btn_inve.TabIndex = 0
        Me.btn_inve.Text = "    Inventario"
        Me.btn_inve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_inve.UseVisualStyleBackColor = True
        '
        'pnl_arriba
        '
        Me.pnl_arriba.BackColor = System.Drawing.Color.Gainsboro
        Me.pnl_arriba.Controls.Add(Me.pnl_acercade)
        Me.pnl_arriba.Controls.Add(Me.btn_minimi)
        Me.pnl_arriba.Controls.Add(Me.btn_close)
        Me.pnl_arriba.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_arriba.Location = New System.Drawing.Point(233, 0)
        Me.pnl_arriba.Name = "pnl_arriba"
        Me.pnl_arriba.Size = New System.Drawing.Size(607, 33)
        Me.pnl_arriba.TabIndex = 1
        '
        'pnl_acercade
        '
        Me.pnl_acercade.Location = New System.Drawing.Point(1, 32)
        Me.pnl_acercade.Name = "pnl_acercade"
        Me.pnl_acercade.Size = New System.Drawing.Size(603, 466)
        Me.pnl_acercade.TabIndex = 2
        '
        'btn_minimi
        '
        Me.btn_minimi.Image = Global.Prueba_Arquitectura.My.Resources.Resources.minimize1
        Me.btn_minimi.Location = New System.Drawing.Point(547, 0)
        Me.btn_minimi.Name = "btn_minimi"
        Me.btn_minimi.Size = New System.Drawing.Size(32, 33)
        Me.btn_minimi.TabIndex = 1
        Me.btn_minimi.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.Image = Global.Prueba_Arquitectura.My.Resources.Resources.close
        Me.btn_close.Location = New System.Drawing.Point(575, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(32, 33)
        Me.btn_close.TabIndex = 0
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 500)
        Me.Controls.Add(Me.pnl_arriba)
        Me.Controls.Add(Me.pnl_izquierda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnl_izquierda.ResumeLayout(False)
        Me.pnl_arriba.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_izquierda As Panel
    Friend WithEvents pnl_inve As Panel
    Friend WithEvents btn_inve As Button
    Friend WithEvents pnl_arriba As Panel
    Friend WithEvents pnl_conta As Panel
    Friend WithEvents btn_conta As Button
    Friend WithEvents pnl_perfil As Panel
    Friend WithEvents btn_perfil As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_acercade As Button
    Friend WithEvents btn_minimi As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents pnl_acercade As Panel
End Class
