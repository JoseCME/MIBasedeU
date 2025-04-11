using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIBasedeU.Clases;

namespace MIBasedeU
{
    public partial class Form1 : Form
    {
        Crud crud = new Crud();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
           MessageBox.Show("Bienvenido a la seccion tareas");
            Form2 form2 = new Form2();
            form2.ShowDialog();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnseccion.Items.Add("A");
            btnseccion.Items.Add("B");
            btnseccion.Items.Add("C");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textnombre.Text = crud.mostrarinfo(textcarnet.Text);
            MessageBox.Show(textnombre.Text);
        }

        private void textcarnet_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttoncrear_Click(object sender, EventArgs e)
        {
            string nombre = textnombre.Text;
            string carnet = textcarnet.Text;
            string email = textcorreo.Text;
            string seccion = btnseccion.Text;
           
             string respuesta =   crud.agregaralumno(carnet, nombre, email, seccion);
                MessageBox.Show(respuesta);
            textnombre.Clear();
            textcarnet.Clear();
            textcorreo.Clear();
            btnseccion.Text = "";   

        }
      
        private void button1_Click_2(object sender, EventArgs e)
        {
            string nombre = textnombre.Text;
            string carnet = textcarnet.Text;
            try {
                crud.Actulizaralumno(carnet, nombre);
                MessageBox.Show("Alumno actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
           this.Close();
            
        }
    }
}
