<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.dgvIden = New System.Windows.Forms.DataGridView()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btnLaborablesSA = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnPlazoTX = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.PictureBox()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnSingle = New System.Windows.Forms.Button()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnListaClientes = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Panel_Contenedor = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        CType(Me.dgvIden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1310, 42)
        Me.Panel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(534, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(223, 36)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Reportes"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(305, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(223, 36)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Compras y Ventas"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1273, 4)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(33, 34)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 692)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1310, 45)
        Me.Panel2.TabIndex = 1
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.TextBox1)
        Me.panelMenu.Controls.Add(Me.dgvIden)
        Me.panelMenu.Controls.Add(Me.PictureBox5)
        Me.panelMenu.Controls.Add(Me.btnLaborablesSA)
        Me.panelMenu.Controls.Add(Me.PictureBox3)
        Me.panelMenu.Controls.Add(Me.btnPlazoTX)
        Me.panelMenu.Controls.Add(Me.btnSalir)
        Me.panelMenu.Controls.Add(Me.btnMenu)
        Me.panelMenu.Controls.Add(Me.pictureBox4)
        Me.panelMenu.Controls.Add(Me.btnSingle)
        Me.panelMenu.Controls.Add(Me.pictureBox2)
        Me.panelMenu.Controls.Add(Me.btnListaClientes)
        Me.panelMenu.Controls.Add(Me.pictureBox1)
        Me.panelMenu.Controls.Add(Me.button1)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 42)
        Me.panelMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(307, 650)
        Me.panelMenu.TabIndex = 11
        '
        'dgvIden
        '
        Me.dgvIden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIden.Location = New System.Drawing.Point(205, 546)
        Me.dgvIden.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvIden.Name = "dgvIden"
        Me.dgvIden.Size = New System.Drawing.Size(98, 93)
        Me.dgvIden.TabIndex = 18
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Red
        Me.PictureBox5.Location = New System.Drawing.Point(0, 278)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(3, 49)
        Me.PictureBox5.TabIndex = 17
        Me.PictureBox5.TabStop = False
        '
        'btnLaborablesSA
        '
        Me.btnLaborablesSA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLaborablesSA.FlatAppearance.BorderSize = 0
        Me.btnLaborablesSA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnLaborablesSA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnLaborablesSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaborablesSA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaborablesSA.ForeColor = System.Drawing.Color.Silver
        Me.btnLaborablesSA.Image = CType(resources.GetObject("btnLaborablesSA.Image"), System.Drawing.Image)
        Me.btnLaborablesSA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaborablesSA.Location = New System.Drawing.Point(1, 279)
        Me.btnLaborablesSA.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLaborablesSA.Name = "btnLaborablesSA"
        Me.btnLaborablesSA.Size = New System.Drawing.Size(307, 49)
        Me.btnLaborablesSA.TabIndex = 16
        Me.btnLaborablesSA.Text = "     DASHBOARD"
        Me.btnLaborablesSA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLaborablesSA.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Red
        Me.PictureBox3.Location = New System.Drawing.Point(0, 224)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(3, 49)
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'btnPlazoTX
        '
        Me.btnPlazoTX.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlazoTX.FlatAppearance.BorderSize = 0
        Me.btnPlazoTX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnPlazoTX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnPlazoTX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlazoTX.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlazoTX.ForeColor = System.Drawing.Color.Silver
        Me.btnPlazoTX.Image = CType(resources.GetObject("btnPlazoTX.Image"), System.Drawing.Image)
        Me.btnPlazoTX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlazoTX.Location = New System.Drawing.Point(4, 224)
        Me.btnPlazoTX.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPlazoTX.Name = "btnPlazoTX"
        Me.btnPlazoTX.Size = New System.Drawing.Size(307, 49)
        Me.btnPlazoTX.TabIndex = 14
        Me.btnPlazoTX.Text = "     USUARIO"
        Me.btnPlazoTX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlazoTX.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(8, 593)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(57, 46)
        Me.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.TabStop = False
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.Location = New System.Drawing.Point(241, 2)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(57, 46)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnMenu.TabIndex = 12
        Me.btnMenu.TabStop = False
        '
        'pictureBox4
        '
        Me.pictureBox4.BackColor = System.Drawing.Color.Red
        Me.pictureBox4.Location = New System.Drawing.Point(0, 169)
        Me.pictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(3, 49)
        Me.pictureBox4.TabIndex = 5
        Me.pictureBox4.TabStop = False
        '
        'btnSingle
        '
        Me.btnSingle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSingle.FlatAppearance.BorderSize = 0
        Me.btnSingle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnSingle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSingle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSingle.ForeColor = System.Drawing.Color.Silver
        Me.btnSingle.Image = CType(resources.GetObject("btnSingle.Image"), System.Drawing.Image)
        Me.btnSingle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSingle.Location = New System.Drawing.Point(1, 169)
        Me.btnSingle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSingle.Name = "btnSingle"
        Me.btnSingle.Size = New System.Drawing.Size(307, 49)
        Me.btnSingle.TabIndex = 4
        Me.btnSingle.Text = "     INVENTARIO"
        Me.btnSingle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSingle.UseVisualStyleBackColor = True
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Red
        Me.pictureBox2.Location = New System.Drawing.Point(0, 113)
        Me.pictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(3, 49)
        Me.pictureBox2.TabIndex = 3
        Me.pictureBox2.TabStop = False
        '
        'btnListaClientes
        '
        Me.btnListaClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListaClientes.FlatAppearance.BorderSize = 0
        Me.btnListaClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnListaClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListaClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListaClientes.ForeColor = System.Drawing.Color.Silver
        Me.btnListaClientes.Image = CType(resources.GetObject("btnListaClientes.Image"), System.Drawing.Image)
        Me.btnListaClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListaClientes.Location = New System.Drawing.Point(1, 113)
        Me.btnListaClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListaClientes.Name = "btnListaClientes"
        Me.btnListaClientes.Size = New System.Drawing.Size(307, 49)
        Me.btnListaClientes.TabIndex = 2
        Me.btnListaClientes.Text = "     VENTAS"
        Me.btnListaClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnListaClientes.UseVisualStyleBackColor = True
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Red
        Me.pictureBox1.Location = New System.Drawing.Point(0, 57)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(3, 49)
        Me.pictureBox1.TabIndex = 1
        Me.pictureBox1.TabStop = False
        '
        'button1
        '
        Me.button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.button1.FlatAppearance.BorderSize = 0
        Me.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.Silver
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.Location = New System.Drawing.Point(4, 55)
        Me.button1.Margin = New System.Windows.Forms.Padding(4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(307, 49)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Colección"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button1.UseVisualStyleBackColor = True
        '
        'Panel_Contenedor
        '
        Me.Panel_Contenedor.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Contenedor.Location = New System.Drawing.Point(307, 42)
        Me.Panel_Contenedor.Name = "Panel_Contenedor"
        Me.Panel_Contenedor.Size = New System.Drawing.Size(1003, 650)
        Me.Panel_Contenedor.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 335)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Visible = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1310, 737)
        Me.Controls.Add(Me.Panel_Contenedor)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenu.PerformLayout()
        CType(Me.dgvIden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Private WithEvents btnCerrar As Button
    Friend WithEvents Panel2 As Panel
    Private WithEvents panelMenu As Panel
    Friend WithEvents dgvIden As DataGridView
    Private WithEvents PictureBox5 As PictureBox
    Private WithEvents btnLaborablesSA As Button
    Private WithEvents PictureBox3 As PictureBox
    Private WithEvents btnPlazoTX As Button
    Private WithEvents btnSalir As PictureBox
    Private WithEvents btnMenu As PictureBox
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents btnSingle As Button
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents btnListaClientes As Button
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel_Contenedor As Panel
    Friend WithEvents TextBox1 As TextBox
End Class
