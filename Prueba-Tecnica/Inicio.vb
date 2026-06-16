Imports System.Data.SqlClient
Public Class Inicio
    'Variable de conexion a la base de datos, se define el servidor, la base de datos y la seguridad integrada.
    Private ReadOnly StringConn As String = "server=localhost; database=Biblioteca; Integrated Security=SSPI;"
    'Variables de la conexion con la base de datos.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    'Variables de prestamos y devoluciones.
    Private ISBN_Prestamo As String
    Private ID_Usuario_Prestamo As String
    Private ISBN_Devolucion As String
    Private Observacion As String
    'Variables de Registro de Usuario
    Private Nombre_Usuario As String
    Private Tipo_ID As String
    Private ID As String
    Private Pais As String
    Private Ciudad As String
    Private Direccion As String
    'Variables de Registro de Autor
    Private Nombre_Autor As String
    Private ID_Autor As String
    Private Pais_Origen As String
    'Variables de Registro de Libro
    Private Titulo As String
    Private Fecha_Publicacion As String
    Private ISBN As String
    Private ID_Autor_Libro As String
    'Variables de Manejo de Usuarios
    Private ID_Usuario As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatosVerPrestamos()

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPage1 Then
            MostrarDatosVerPrestamos()
        ElseIf TabControl1.SelectedTab Is TabPage6 Then
            MostrarDatosHistorial()
        ElseIf TabControl1.SelectedTab Is TabPage3 Then
            MostrarEstadosUsuario()
        End If
    End Sub

    'Primera pestaña: Ver Prestamos
    'Se crean dos procedimientos de ayuda para agregar celdas al TableLayoutPanel, uno para encabezados y otro para datos.
    'encabezados
    Private Sub AgregarCeldaEncabezado(panel As TableLayoutPanel, texto As String, columna As Integer, fila As Integer)
        Dim lbl As New Label()
        lbl.Text = texto
        lbl.Font = New Font(lbl.Font, FontStyle.Bold)
        lbl.AutoSize = True
        lbl.Dock = DockStyle.Fill
        panel.Controls.Add(lbl, columna, fila)
    End Sub

    'datos
    Private Sub AgregarCeldaDato(panel As TableLayoutPanel, texto As String, columna As Integer, fila As Integer)
        Dim lbl As New Label()
        lbl.Text = texto
        lbl.AutoSize = True
        lbl.Dock = DockStyle.Fill
        panel.Controls.Add(lbl, columna, fila)
    End Sub

    'Cargar elementos de mi base de datos.

    Private Sub MostrarDatosVerPrestamos()

        'MYCONN es la variable de conexion de base de datos, dentro de esta va el servidor, la base de datos, el usuario
        'y la contraseña y mi CMD es la variable de comando, por dentro va la consulta pero como se usan procedimientos almacendos
        'se usa obtener_prestamos() que anteriormente se definio en la base de datos.
        myConn = New SqlConnection(StringConn)
        myCmd = New SqlCommand("exec obtener_prestamos", myConn)

        'Limpiar la tabla antes de ingresar los datos nuevos
        TableLayoutPanel1.Controls.Clear()
        TableLayoutPanel1.RowStyles.Clear()
        TableLayoutPanel1.ColumnStyles.Clear()

        'Definimos el numero de columnas 
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.RowCount = 1 'Empezamos con la fila de encabezados


        'Agregamos los encabezados con el procedimiento creado anteriormente.
        AgregarCeldaEncabezado(TableLayoutPanel1, "Número de prestamo", 0, 0)
        AgregarCeldaEncabezado(TableLayoutPanel1, "Usuario al que se presto", 1, 0)
        AgregarCeldaEncabezado(TableLayoutPanel1, "Libro prestado", 2, 0)
        AgregarCeldaEncabezado(TableLayoutPanel1, "Fecha de prestamo", 3, 0)

        'Conectamos a la base de datos y leemos las filas con MySqlDataReader usando el comando creado anteriormente.
        Using myConn
            Using myCmd
                myConn.Open()

                Using lector As SqlDataReader = myCmd.ExecuteReader()
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
                        AgregarCeldaDato(TableLayoutPanel1, id, 0, filaActual)
                        AgregarCeldaDato(TableLayoutPanel1, usuario, 1, filaActual)
                        AgregarCeldaDato(TableLayoutPanel1, libro, 2, filaActual)
                        AgregarCeldaDato(TableLayoutPanel1, fecha, 3, filaActual)

                        filaActual += 1
                    End While
                End Using
            End Using
        End Using
    End Sub

    'Cuando se clickea el boton de prestar libro, se conecta a la base de datos y se ejecuta el procedimiento almacenado
    '"crear_prestamo" con los parametros del ISBN y el ID del usuario, que se obtienen de los TextBox correspondientes.
    'Luego se muestra un mensaje de confirmacion.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myConn = New SqlConnection(StringConn)
        myCmd = New SqlCommand("exec crear_prestamo @ISBN_reg, @ID_reg", myConn)
        ISBN_Prestamo = TextBox1.Text
        ID_Usuario_Prestamo = TextBox2.Text

        Using myConn
            Using myCmd
                myConn.Open()
                myCmd.CommandType = CommandType.Text
                myCmd.Parameters.AddWithValue("@ISBN_reg", ISBN_Prestamo)
                myCmd.Parameters.AddWithValue("@ID_reg", ID_Usuario_Prestamo)
                myCmd.ExecuteNonQuery()
                MessageBox.Show("Libro entregado exitosamente.")

            End Using
        End Using
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    'Cuando se clickea el boton de devolver libro, se conecta a la base de datos y se ejecuta el procedimiento almacenado de
    '"entregar_libro" con los parametros del ISBN y la observacion, que se obtienen de los TextBox correspondientes.
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        myConn = New SqlConnection(StringConn)
        myCmd = New SqlCommand("exec entregar_libro @ISBN_reg, @observacion_reg", myConn)

        Observacion = TextBox3.Text
        ISBN_Devolucion = TextBox4.Text
        Using myConn
            Using myCmd
                myConn.Open()
                myCmd.CommandType = CommandType.Text
                myCmd.Parameters.AddWithValue("@ISBN_reg", ISBN_Devolucion)
                myCmd.Parameters.AddWithValue("@observacion_reg", Observacion)
                myCmd.ExecuteNonQuery()
                MessageBox.Show("Libro devuelto exitosamente.")

            End Using
        End Using
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    'Cuando se clickea obtiene los valores del formulario creado y los envia al procedimiento de registrar_usuario.
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        myConn = New SqlConnection(StringConn)
        myCmd = New SqlCommand("exec registrar_usuario @nombre_reg, @tipo_id_reg, @id_reg, @pais_reg, @ciudad_reg, @direccion_reg", myConn)

        Nombre_Usuario = TextBox6.Text
        Tipo_ID = ComboBox1.Text
        ID = TextBox7.Text
        Pais = TextBox8.Text
        Ciudad = TextBox9.Text
        Direccion = TextBox10.Text
        Using myConn
            Using myCmd
                myConn.Open()
                myCmd.CommandType = CommandType.Text
                myCmd.Parameters.AddWithValue("@nombre_reg", Nombre_Usuario)
                myCmd.Parameters.AddWithValue("@tipo_id_reg", Tipo_ID)
                myCmd.Parameters.AddWithValue("@id_reg", ID)
                myCmd.Parameters.AddWithValue("@pais_reg", Pais)
                myCmd.Parameters.AddWithValue("@ciudad_reg", Ciudad)
                myCmd.Parameters.AddWithValue("@direccion_reg", Direccion)
                myCmd.ExecuteNonQuery()
                MessageBox.Show("Usuario registrado exitosamente.")

            End Using
        End Using
        TextBox6.Text = ""
        ComboBox1.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
    End Sub

    'Cuando se clickea obtiene los valores del formulario creado y los envia al procedimiento de registrar_autor.
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        myConn = New SqlConnection(StringConn)
        myCmd = New SqlCommand("exec registrar_autor @nombre_reg, @id_reg, @pais_reg", myConn)

        Nombre_Autor = TextBox14.Text
        ID_Autor = TextBox13.Text
        Pais_Origen = TextBox12.Text
        Using myConn
            Using myCmd
                myConn.Open()
                myCmd.CommandType = CommandType.Text
                myCmd.Parameters.AddWithValue("@nombre_reg", Nombre_Autor)
                myCmd.Parameters.AddWithValue("@id_reg", ID_Autor)
                myCmd.Parameters.AddWithValue("@pais_reg", Pais_Origen)
                myCmd.ExecuteNonQuery()
                MessageBox.Show("Autor Registrado exitosamente.")

            End Using
        End Using
        TextBox14.Text = ""
        TextBox13.Text = ""
        TextBox12.Text = ""
    End Sub

    'Revisa si el TextBox tiene el texto difuminado, si es asi, lo borra y pone el color negro
    'Asi revisamos que el usuario ingrese bien el formato de fecha.
    Private Sub TextBox11_Enter(sender As Object, e As EventArgs) Handles TextBox11.Enter
        ' Al hacer clic en el TextBox, si tiene el texto difuminado, lo borramos y ponemos el color a negro
        If (TextBox11.Text = "AAAAMMDD") Then
            TextBox11.Text = ""
            TextBox11.ForeColor = Color.Black
        End If
    End Sub

    'Obtiene los valores del formulario creado y los envia al procedimiento de registrar_libro.
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        myConn = New SqlConnection(StringConn)
        myCmd = New SqlCommand("exec registrar_libro @titulo_reg, @fecha_publicacion_reg, @isbn_reg, @id_autor_reg", myConn)

        Titulo = TextBox15.Text
        Fecha_Publicacion = TextBox11.Text
        ISBN = TextBox5.Text
        ID_Autor_Libro = TextBox16.Text
        Using myConn
            Using myCmd
                myConn.Open()
                myCmd.CommandType = CommandType.Text
                myCmd.Parameters.AddWithValue("@titulo_reg", Titulo)
                myCmd.Parameters.AddWithValue("@fecha_publicacion_reg", Fecha_Publicacion)
                myCmd.Parameters.AddWithValue("@isbn_reg", ISBN)
                myCmd.Parameters.AddWithValue("@id_autor_reg", ID_Autor_Libro)
                myCmd.ExecuteNonQuery()
                MessageBox.Show("Libro Registrado exitosamente.")

            End Using
        End Using
        TextBox15.Text = ""
        TextBox11.Text = "AAAAMMDD"
        TextBox11.ForeColor = Color.Gray
        TextBox5.Text = ""
        TextBox16.Text = ""
    End Sub

    Private Sub MostrarDatosHistorial()

        'MYCONN es la variable de conexion de base de datos, dentro de esta va el servidor, la base de datos, el usuario
        'y la contraseña y mi CMD es la variable de comando, por dentro va la consulta pero como se usan procedimientos almacendos
        'se usa historial_prestamos() que anteriormente se definio en la base de datos.
        myConn = New SqlConnection(StringConn)
        myCmd = New SqlCommand("exec historial_prestamos", myConn)

        'Limpiar la tabla antes de ingresar los datos nuevos
        TableLayoutPanel2.Controls.Clear()
        TableLayoutPanel2.RowStyles.Clear()
        TableLayoutPanel2.ColumnStyles.Clear()

        'Definimos el numero de columnas 
        TableLayoutPanel2.ColumnCount = 6
        TableLayoutPanel2.RowCount = 1 'Empezamos con la fila de encabezados


        'Agregamos los encabezados con el procedimiento creado anteriormente.
        AgregarCeldaEncabezado(TableLayoutPanel2, "Número", 0, 0)
        AgregarCeldaEncabezado(TableLayoutPanel2, "Usuario al que se presto", 1, 0)
        AgregarCeldaEncabezado(TableLayoutPanel2, "Libro prestado", 2, 0)
        AgregarCeldaEncabezado(TableLayoutPanel2, "Fecha de prestamo", 3, 0)
        AgregarCeldaEncabezado(TableLayoutPanel2, "Fecha de devolucion", 4, 0)
        AgregarCeldaEncabezado(TableLayoutPanel2, "Observacion", 5, 0)

        'Conectamos a la base de datos y leemos las filas con MySqlDataReader usando el comando creado anteriormente.
        Using myConn
            Using myCmd
                myConn.Open()

                Using lector As SqlDataReader = myCmd.ExecuteReader()
                    Dim filaActual As Integer = 1 'Iniciamos después del encabezado

                    While lector.Read()
                        'Incrementamos el contador de filas del panel
                        TableLayoutPanel2.RowCount += 1

                        'Permitir que la fila se adapte al tamaño del texto
                        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.AutoSize))

                        'Extraer los datos del lector
                        Dim id As String = lector("ID").ToString()
                        Dim usuario As String = lector("Nombre").ToString()
                        Dim libro As String = lector("Titulo").ToString()
                        Dim fecha As Date = lector("Dia_Prestamos")
                        Dim fecha_prestamo As Date = lector("Dia_Devolucion")
                        Dim observacion As String = lector("Observacion").ToString()

                        'Agregar los controles Label a cada celda de la fila actual
                        AgregarCeldaDato(TableLayoutPanel2, id, 0, filaActual)
                        AgregarCeldaDato(TableLayoutPanel2, usuario, 1, filaActual)
                        AgregarCeldaDato(TableLayoutPanel2, libro, 2, filaActual)
                        AgregarCeldaDato(TableLayoutPanel2, fecha, 3, filaActual)
                        AgregarCeldaDato(TableLayoutPanel2, fecha_prestamo, 4, filaActual)
                        AgregarCeldaDato(TableLayoutPanel2, observacion, 5, filaActual)

                        filaActual += 1
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub MostrarEstadosUsuario()

        'MYCONN es la variable de conexion de base de datos, dentro de esta va el servidor, la base de datos, el usuario
        'y la contraseña y mi CMD es la variable de comando, por dentro va la consulta pero como se usan procedimientos almacendos
        'se usa historial_prestamos() que anteriormente se definio en la base de datos.
        myConn = New SqlConnection(StringConn)
        myCmd = New SqlCommand("exec estado_usuarios", myConn)

        'Limpiar la tabla antes de ingresar los datos nuevos
        TableLayoutPanel3.Controls.Clear()
        TableLayoutPanel3.RowStyles.Clear()
        TableLayoutPanel3.ColumnStyles.Clear()

        'Definimos el numero de columnas 
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.RowCount = 1 'Empezamos con la fila de encabezados


        'Agregamos los encabezados con el procedimiento creado anteriormente.
        AgregarCeldaEncabezado(TableLayoutPanel3, "Estado", 0, 0)
        AgregarCeldaEncabezado(TableLayoutPanel3, "ID del usuario", 1, 0)
        AgregarCeldaEncabezado(TableLayoutPanel3, "Nombre", 2, 0)

        'Conectamos a la base de datos y leemos las filas con MySqlDataReader usando el comando creado anteriormente.
        Using myConn
            Using myCmd
                myConn.Open()

                Using lector As SqlDataReader = myCmd.ExecuteReader()
                    Dim filaActual As Integer = 1 'Iniciamos después del encabezado

                    While lector.Read()
                        'Incrementamos el contador de filas del panel
                        TableLayoutPanel2.RowCount += 1

                        'Permitir que la fila se adapte al tamaño del texto
                        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.AutoSize))

                        'Extraer los datos del lector
                        Dim nombre As String = lector("Estado").ToString()
                        Dim id_del_usuario As String = lector("ID_Usuario").ToString()
                        Dim nombre_usuario As String = lector("Nombre").ToString()

                        'Agregar los controles Label a cada celda de la fila actual
                        AgregarCeldaDato(TableLayoutPanel3, nombre, 0, filaActual)
                        AgregarCeldaDato(TableLayoutPanel3, id_del_usuario, 1, filaActual)
                        AgregarCeldaDato(TableLayoutPanel3, nombre_usuario, 2, filaActual)

                        filaActual += 1
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        myConn = New SqlConnection(StringConn)
        myCmd = New SqlCommand("exec cambio_estado @id_reg", myConn)

        ID_Usuario = TextBox17.Text
        Using myConn
            Using myCmd
                myConn.Open()
                myCmd.CommandType = CommandType.Text
                myCmd.Parameters.AddWithValue("@id_reg", ID_Usuario)
                myCmd.ExecuteNonQuery()
                MessageBox.Show("Cambio de estado exitoso.")

            End Using
        End Using
        MostrarEstadosUsuario()
        TextBox17.Text = ""
    End Sub

End Class
