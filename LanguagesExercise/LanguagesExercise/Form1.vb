Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Label2.Visible = True

        Select Case ListBox1.SelectedItem
            Case "Português"
                Label2.Text = "Olá! Bem-Vindo a Portugal!"
                PictureBox1.Image = Image.FromFile("C:\Users\35196\source\repos\Tarefaidiomas\Tarefaidiomas\portugal.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\35196\source\repos\Tarefaidiomas\Tarefaidiomas\pt.jpg")

            Case "Inglês"
                Label2.Text = "Hello! Welcome to England!"
                PictureBox1.Image = Image.FromFile("C:\Users\35196\source\repos\Tarefaidiomas\Tarefaidiomas\unitedki.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\35196\source\repos\Tarefaidiomas\Tarefaidiomas\uk.jpg")

            Case "Espanhol"
                Label2.Text = "Hola! Bienvenido a Espanã!"
                PictureBox1.Image = Image.FromFile("C:\Users\35196\source\repos\Tarefaidiomas\Tarefaidiomas\espanha.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\35196\source\repos\Tarefaidiomas\Tarefaidiomas\spain.jpg")

            Case "Italiano"
                Label2.Text = "Ciao! Benvenuto in Italia!"
                PictureBox1.Image = Image.FromFile("C:\Users\35196\source\repos\Tarefaidiomas\Tarefaidiomas\24884919.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\35196\source\repos\Tarefaidiomas\Tarefaidiomas\it.jpg")


            Case "Alemão"
                Label2.Text = "Hallo! Willkommen in DE! "
                PictureBox1.Image = Image.FromFile("C:\Users\35196\source\repos\Tarefaidiomas\Tarefaidiomas\gr.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\35196\source\repos\Tarefaidiomas\Tarefaidiomas\alm.jpg")

            Case "Francês"
                Label2.Text = "Salut!  Bienvenue a France!"
                PictureBox1.Image = Image.FromFile("C:\Users\35196\source\repos\Tarefaidiomas\Tarefaidiomas\frança.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\35196\source\repos\Tarefaidiomas\Tarefaidiomas\fr.jpg")

        End Select
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
