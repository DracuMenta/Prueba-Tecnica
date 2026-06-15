Imports MySql.Data.MySqlClient
Public Class Inicio
    'Variables de la conexion con la base de datos.
    Private myConn As MySqlConnection
    Private myCmd As MySqlCommand
    Private myReader As MySqlDataReader
    Private results As String
    'Variables de prestamos y devoluciones.
    Private ISBN_Prestamo As String
    Private ID_Usuario_Prestamo As String
    Private ISBN_Devolucion As String
    Private Observacion As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatosVerPrestamos()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPage1 Then
            MostrarDatosVerPrestamos()
        End If
    End Sub

    'Primera pestaña: Ver Prestamos
    'Se crean dos procedimientos de ayuda para agregar celdas al TableLayoutPanel, uno para encabezados y otro para datos.
    'encabezados
    Private Sub AgregarCeldaEncabezado(texto As String, columna As Integer, fila As Integer)
        Dim lbl As New Label()
        lbl.Text = texto
        lbl.Font = New Font(lbl.Font, FontStyle.Bold)
        lbl.AutoSize = True
        lbl.Dock = DockStyle.Fill
        TableLayoutPanel1.Controls.Add(lbl, columna, fila)
    End Sub

    'datos
    Private Sub AgregarCeldaDato(texto As String, columna As Integer, fila As Integer)
        Dim lbl As New Label()
        lbl.Text = texto
        lbl.AutoSize = True
        lbl.Dock = DockStyle.Fill
        TableLayoutPanel1.Controls.Add(lbl, columna, fila)
    End Sub

    'Cargar elementos de mi base de datos.

    Private Sub MostrarDatosVerPrestamos()

        'MYCONN es la variable de conexion de base de datos, dentro de esta va el servidor, la base de datos, el usuario
        'y la contraseña y mi CMD es la variable de comando, por dentro va la consulta pero como se usan procedimientos almacendos
        'se usa obtener_prestamos() que anteriormente se definio en la base de datos.
        myConn = New MySqlConnection("server=localhost; database=Biblioteca; uid=root; pwd= ")
        myCmd = New MySqlCommand("call obtener_prestamos()", myConn)

        'Limpiar la tabla antes de ingresar los datos nuevos
        TableLayoutPanel1.Controls.Clear()
        TableLayoutPanel1.RowStyles.Clear()
        TableLayoutPanel1.ColumnStyles.Clear()

        'Definimos el numero de columnas 
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.RowCount = 1 'Empezamos con la fila de encabezados


        'Agregamos los encabezados con el procedimiento creado anteriormente.
        AgregarCeldaEncabezado("Número de prestamo", 0, 0)
        AgregarCeldaEncabezado("Usuario al que se presto", 1, 0)
        AgregarCeldaEncabezado("Libro prestado", 2, 0)
        AgregarCeldaEncabezado("Fecha de prestamo", 3, 0)

        'Conectamos a la base de datos y leemos las filas con MySqlDataReader usando el comando creado anteriormente.
        Using myConn
            Using myCmd
                myConn.Open()

                Using lector As MySqlDataReader = myCmd.ExecuteReader()
                    Dim filaActual As Integer = 1 'Iniciamos después del encabezado

                    While lector.Read()
                        'Incrementamos el contador de filas del panel
                        TableLayoutPanel1.RowCount += 1

                        'Permitir que la fila se adapte al tamaño del texto
                        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.AutoSize))

                        'Extraer los datos del lector
                        Dim id As String = lector("Id").ToString()
                        Dim usuario As String = lector("Nombre").ToString()
                        Dim libro As String = lector("Titulo").ToString()
                        Dim fecha As Date = lector("Dia_Prestamos")

                        'Agregar los controles Label a cada celda de la fila actual
                        AgregarCeldaDato(id, 0, filaActual)
                        AgregarCeldaDato(usuario, 1, filaActual)
                        AgregarCeldaDato(libro, 2, filaActual)
                        AgregarCeldaDato(fecha, 3, filaActual)

                        filaActual += 1
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myConn = New MySqlConnection("server=localhost; database=Biblioteca; uid=root; pwd= ")
        myCmd = New MySqlCommand("crear_prestamo", myConn)
        ISBN_Prestamo = TextBox1.Text
        ID_Usuario_Prestamo = TextBox2.Text

        Using myConn
            Using myCmd
                myConn.Open()
                myCmd.CommandType = CommandType.StoredProcedure
                myCmd.Parameters.AddWithValue("ISBN_reg", ISBN_Prestamo)
                myCmd.Parameters.AddWithValue("ID_reg", ID_Usuario_Prestamo)
                myCmd.ExecuteNonQuery()
                MessageBox.Show("Libro entregado exitosamente.")

            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        myConn = New MySqlConnection("server=localhost; database=Biblioteca; uid=root; pwd= ")
        myCmd = New MySqlCommand("entregar_libro", myConn)

        Observacion = TextBox3.Text
        ISBN_Devolucion = TextBox4.Text
        Using myConn
            Using myCmd
                myConn.Open()
                myCmd.CommandType = CommandType.StoredProcedure
                myCmd.Parameters.AddWithValue("ISBN_reg", ISBN_Devolucion)
                myCmd.Parameters.AddWithValue("observacion_reg", Observacion)
                myCmd.ExecuteNonQuery()
                MessageBox.Show("Libro devuelto exitosamente.")

            End Using
        End Using
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub
End Class
