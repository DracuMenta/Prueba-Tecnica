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
        Panel1 = New Panel()
        Label6 = New Label()
        TabPage4 = New TabPage()
        TabPage5 = New TabPage()
        TabPage6 = New TabPage()
        TextBox1 = New TextBox()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TabPage2.SuspendLayout()
        Panel1.SuspendLayout()
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
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(6, 6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(286, 298)
        Panel1.TabIndex = 1
        Panel1.UseWaitCursor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(3, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(219, 28)
        Label6.TabIndex = 0
        Label6.Text = "ISBN del libro prestado:"
        Label6.UseWaitCursor = True
        ' 
        ' TabPage4
        ' 
        TabPage4.Location = New Point(4, 29)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(806, 404)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Registrar usuario"
        TabPage4.UseVisualStyleBackColor = True
        TabPage4.UseWaitCursor = True
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
        ' TextBox1
        ' 
        TextBox1.Location = New Point(3, 50)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(219, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Inicio
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
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
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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

End Class
