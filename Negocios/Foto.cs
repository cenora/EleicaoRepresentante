//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Negocios
//{
//    class Foto
//    {

//        int codCliente = 123;

//        // caminho onde será salvo a imagem
//        string imagem = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + codCliente + "_1" + ".jpg";

//               if (File.Exists(imagem))
//               {
//                  Bitmap bit = new Bitmap(imagem);

//        pictureBox1.Image = bit;
//               }
//    private void btnP1_Click(object sender, EventArgs e)
//    {
//        if (txtMatrPaciente.Text == "")
//        {
//            MessageBox.Show("Entre com a matrícula do paciente.", "Advertência", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
//            txtMatrPaciente.Focus();
//        }
//        else
//        {

//            int segundos = DateTime.Now.Second;
//            int dia = DateTime.Now.Day;

//            if (openFileDialog1.ShowDialog() == DialogResult.OK)
//            {
//                this.pictureBox1.ImageLocation = openFileDialog1.FileName;

//                // caminho onde será salvo a imagem
//                String Imagem = Application.StartupPath + @"\imagens\" + txtMatrPaciente.Text + "_" + dia.ToString() + segundos.ToString() + Path.GetExtension(openFileDialog1.FileName);

//                if (File.Exists(Imagem))
//                {
//                    MessageBox.Show("Imagem já existente, Por Favor Tente Novamente!");
//                }
//                else
//                {
//                    // aqui ele pega a sua imagem e copia
//                    File.Copy(openFileDialog1.FileName, Imagem);

//                }
//            }

//        }
//    }
//    using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Windows.Forms;
//using System.IO;
//using System.Data.SqlClient;
//namespace Camera
//    {
//        public partial class Alterando : Form
//        {

//            private String strconn;
//            private SqlConnection conn;

//            public Alterando()

//            {
//                InitializeComponent();
//                // strconn = @"Server =.\SQLEXPRESS;Initial Catalog=banco;User ID=sa;Password=**** ";
//                //conn = new SqlConnection(strconn);


//            }

//            //item abaixo serve para recuperar a imagem do banco de dados
//            SqlConnection conn = new SqlConnection(strconn);
//            SqlCommand comand = new SqlCommand("Select foto from Membros where id =" + label20.Text, conn);//desde que o id seja igual
//            conn.Open();
//            SqlDataReader reader = comand.ExecuteReader(); // isso traz o resultado do meu select
//            Image imagem = null;
//            if (reader.Read())
//            {
//                byte[] foto = (byte[])reader["foto"];
//            MemoryStream ms = new MemoryStream(foto);
//            imagem = Image.FromStream(ms);

//            }

//        pictureBox1.Image = imagem; // aqui vc coloca a imagem armazenada do banco no picturebox
//            conn.Close();

//             int codCliente = 123;

//        // caminho onde será salvo a imagem
//        string imagem = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + codCliente + "_1" + ".jpg";


//        // aqui ele pega a sua imagem que esta no picturebox, então substitua o caminho por "picturebox1.image"
//        Bitmap imagemdopicturebox = new Bitmap(@"C:\\nn.JPG");

//        pictureBox1.Image = imagemdopicturebox;

//            pictureBox1.Image.Save(imagem);

//            private void btnP1_Click(object sender, EventArgs e)
//        {
//            if (txtMatrPaciente.Text == "")
//            {
//                MessageBox.Show("Entre com a matrícula do paciente.", "Advertência", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
//                txtMatrPaciente.Focus();
//            }
//            else
//            {

//                int segundos = DateTime.Now.Second;
//                int dia = DateTime.Now.Day;

//                if (openFileDialog1.ShowDialog() == DialogResult.OK)
//                {
//                    this.pictureBox1.ImageLocation = openFileDialog1.FileName;

//                    // caminho onde será salvo a imagem
//                    String Imagem = Application.StartupPath + @"\imagens\" + txtMatrPaciente.Text + "_" + dia.ToString() + segundos.ToString() + Path.GetExtension(openFileDialog1.FileName);

//                    if (File.Exists(Imagem))
//                    {
//                        MessageBox.Show("Imagem já existente, Por Favor Tente Novamente!");
//                    }
//                    else
//                    {
//                        // aqui ele pega a sua imagem e copia
//                        File.Copy(openFileDialog1.FileName, Imagem);

//                    }
//                }

//            }
//        }
//    }
//}


//http://www.codeproject.com/Questions/658424/Save-image-in-local-Folder-from-sql-database
//https://www.ibm.com/developerworks/community/blogs/fd26864d-cb41-49cf-b719-d89c6b072893/entry/cadastro_de_alunos_com_foto_em_c_com_xml2?lang=en