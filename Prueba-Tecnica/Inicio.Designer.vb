<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        Panel2 = New Panel()
        Button2 = New Button()
        TextBox3 = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        TextBox4 = New TextBox()
        Label11 = New Label()
        Panel1 = New Panel()
        Button1 = New Button()
        TextBox2 = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        TextBox1 = New TextBox()
        Label6 = New Label()
        TabPage4 = New TabPage()
        Panel3 = New Panel()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label13 = New Label()
        ComboBox1 = New ComboBox()
        TextBox10 = New TextBox()
        TextBox9 = New TextBox()
        TextBox8 = New TextBox()
        TextBox7 = New TextBox()
        Button3 = New Button()
        Label12 = New Label()
        TextBox6 = New TextBox()
        Label14 = New Label()
        TabPage5 = New TabPage()
        TabPage6 = New TabPage()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TabPage2.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        TabPage4.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Controls.Add(TabPage6)
        TabControl1.Location = New Point(2, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(814, 437)
        TabControl1.TabIndex = 0
        TabControl1.UseWaitCursor = True
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(TableLayoutPanel1)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(806, 404)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Ver Préstamos"
        TabPage1.UseVisualStyleBackColor = True
        TabPage1.UseWaitCursor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        TableLayoutPanel1.ColumnCount = 5
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.Controls.Add(Label5, 4, 0)
        TableLayoutPanel1.Controls.Add(Label4, 3, 0)
        TableLayoutPanel1.Controls.Add(Label3, 2, 0)
        TableLayoutPanel1.Controls.Add(Label2, 1, 0)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Location = New Point(3, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.Size = New Size(798, 399)
        TableLayoutPanel1.TabIndex = 0
        TableLayoutPanel1.UseWaitCursor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(579, 1)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 20)
        Label5.TabIndex = 4
        Label5.Text = "Observación"
        Label5.UseWaitCursor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(448, 1)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 20)
        Label4.TabIndex = 3
        Label4.Text = "Dia del prestamo"
        Label4.UseWaitCursor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(335, 1)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 20)
        Label3.TabIndex = 2
        Label3.Text = "Libro prestado"
        Label3.UseWaitCursor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(161, 1)
        Label2.Name = "Label2"
        Label2.Size = New Size(167, 20)
        Label2.TabIndex = 1
        Label2.Text = "Usuario al que se presta"
        Label2.UseWaitCursor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(4, 1)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 20)
        Label1.TabIndex = 0
        Label1.Text = "Número de Préstamo"
        Label1.UseWaitCursor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Panel2)
        TabPage2.Controls.Add(Panel1)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(806, 404)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Prestamos y devoluciones"
        TabPage2.UseVisualStyleBackColor = True
        TabPage2.UseWaitCursor = True
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(Label11)
        Panel2.Location = New Point(434, 19)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(325, 361)
        Panel2.TabIndex = 6
        Panel2.UseWaitCursor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(9, 199)
        Button2.Name = "Button2"
        Button2.Size = New Size(149, 29)
        Button2.TabIndex = 5
        Button2.Text = "Confirmar"
        Button2.UseVisualStyleBackColor = True
        Button2.UseWaitCursor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(9, 143)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(219, 27)
        TextBox3.TabIndex = 4
        TextBox3.UseWaitCursor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(9, 117)
        Label9.Name = "Label9"
        Label9.Size = New Size(108, 23)
        Label9.TabIndex = 3
        Label9.Text = "Observación:"
        Label9.UseWaitCursor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(3, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(183, 31)
        Label10.TabIndex = 2
        Label10.Text = "Entrega de libro:"
        Label10.UseWaitCursor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(9, 73)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(219, 27)
        TextBox4.TabIndex = 1
        TextBox4.UseWaitCursor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(9, 47)
        Label11.Name = "Label11"
        Label11.Size = New Size(190, 23)
        Label11.TabIndex = 0
        Label11.Text = "ISBN del libro prestado:"
        Label11.UseWaitCursor = True
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(32, 19)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(329, 363)
        Panel1.TabIndex = 1
        Panel1.UseWaitCursor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(9, 199)
        Button1.Name = "Button1"
        Button1.Size = New Size(149, 29)
        Button1.TabIndex = 5
        Button1.Text = "Confirmar"
        Button1.UseVisualStyleBackColor = True
        Button1.UseWaitCursor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(9, 143)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(219, 27)
        TextBox2.TabIndex = 4
        TextBox2.UseWaitCursor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(9, 117)
        Label8.Name = "Label8"
        Label8.Size = New Size(120, 23)
        Label8.TabIndex = 3
        Label8.Text = "ID del usuario:"
        Label8.UseWaitCursor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(201, 31)
        Label7.TabIndex = 2
        Label7.Text = "Realizar préstamo:"
        Label7.UseWaitCursor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(9, 73)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(219, 27)
        TextBox1.TabIndex = 1
        TextBox1.UseWaitCursor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(9, 47)
        Label6.Name = "Label6"
        Label6.Size = New Size(202, 23)
        Label6.TabIndex = 0
        Label6.Text = "ISBN del libro entregado:"
        Label6.UseWaitCursor = True
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(Panel3)
        TabPage4.Location = New Point(4, 29)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(806, 404)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Registrar usuario"
        TabPage4.UseVisualStyleBackColor = True
        TabPage4.UseWaitCursor = True
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Label17)
        Panel3.Controls.Add(Label16)
        Panel3.Controls.Add(Label15)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(ComboBox1)
        Panel3.Controls.Add(TextBox10)
        Panel3.Controls.Add(TextBox9)
        Panel3.Controls.Add(TextBox8)
        Panel3.Controls.Add(TextBox7)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(TextBox6)
        Panel3.Controls.Add(Label14)
        Panel3.Location = New Point(19, 15)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(469, 378)
        Panel3.TabIndex = 2
        Panel3.UseWaitCursor = True
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(10, 274)
        Label17.Name = "Label17"
        Label17.Size = New Size(85, 23)
        Label17.TabIndex = 14
        Label17.Text = "Dirección:"
        Label17.UseWaitCursor = True
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(9, 222)
        Label16.Name = "Label16"
        Label16.Size = New Size(68, 23)
        Label16.TabIndex = 13
        Label16.Text = "Ciudad:"
        Label16.UseWaitCursor = True
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(9, 170)
        Label15.Name = "Label15"
        Label15.Size = New Size(43, 23)
        Label15.TabIndex = 12
        Label15.Text = "País:"
        Label15.UseWaitCursor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(9, 118)
        Label13.Name = "Label13"
        Label13.Size = New Size(31, 23)
        Label13.TabIndex = 11
        Label13.Text = "ID:"
        Label13.UseWaitCursor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"TI", "CC", "CE", "PPT", "Pasaporte"})
        ComboBox1.Location = New Point(194, 66)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(219, 28)
        ComboBox1.TabIndex = 10
        ComboBox1.UseWaitCursor = True
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(194, 270)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(219, 27)
        TextBox10.TabIndex = 9
        TextBox10.UseWaitCursor = True
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(194, 218)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(219, 27)
        TextBox9.TabIndex = 8
        TextBox9.UseWaitCursor = True
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(194, 166)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(219, 27)
        TextBox8.TabIndex = 7
        TextBox8.UseWaitCursor = True
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(194, 114)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(219, 27)
        TextBox7.TabIndex = 6
        TextBox7.UseWaitCursor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(3, 342)
        Button3.Name = "Button3"
        Button3.Size = New Size(149, 29)
        Button3.TabIndex = 5
        Button3.Text = "Confirmar"
        Button3.UseVisualStyleBackColor = True
        Button3.UseWaitCursor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(9, 71)
        Label12.Name = "Label12"
        Label12.Size = New Size(69, 23)
        Label12.TabIndex = 3
        Label12.Text = "Tipo ID:"
        Label12.UseWaitCursor = True
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(194, 18)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(219, 27)
        TextBox6.TabIndex = 1
        TextBox6.UseWaitCursor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(9, 22)
        Label14.Name = "Label14"
        Label14.Size = New Size(77, 23)
        Label14.TabIndex = 0
        Label14.Text = "Nombre:"
        Label14.UseWaitCursor = True
        ' 
        ' TabPage5
        ' 
        TabPage5.Location = New Point(4, 29)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(806, 404)
        TabPage5.TabIndex = 4
        TabPage5.Text = "Registrar libro"
        TabPage5.UseVisualStyleBackColor = True
        TabPage5.UseWaitCursor = True
        ' 
        ' TabPage6
        ' 
        TabPage6.Location = New Point(4, 29)
        TabPage6.Name = "TabPage6"
        TabPage6.Padding = New Padding(3)
        TabPage6.Size = New Size(806, 404)
        TabPage6.TabIndex = 5
        TabPage6.Text = "Historial préstamos"
        TabPage6.UseVisualStyleBackColor = True
        TabPage6.UseWaitCursor = True
        ' 
        ' Inicio
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(814, 446)
        Controls.Add(TabControl1)
        Name = "Inicio"
        Text = "Inicio"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TabPage2.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabPage4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Protected WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label

End Class
