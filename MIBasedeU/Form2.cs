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
using static MIBasedeU.Clases.CrudTareas;

namespace MIBasedeU
{
    public partial class Form2 : Form
    {
        CrudTareas CrudTareas = new CrudTareas();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

       

        private void brnbuscar_Click(object sender, EventArgs e)
        {
           var notas = CrudTareas.BuscarTareas(txtboxcarnet.Text);
            if (notas != null)
            {
                txtboxnota1.Text = notas.Nota1;
                txtboxnota2.Text = notas.Nota2;
                txtboxnota3.Text = notas.Nota3;
                txtboxnota4.Text = notas.Nota4;
            }
            else
            {
                MessageBox.Show("No se encontraron notas para ese carnet.");
                txtboxnota1.Clear();
                txtboxnota2.Clear();
                txtboxnota3.Clear();
                txtboxnota4.Clear();
            }
        }

        private void txtboxnota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string carnet = txtboxcarnet.Text;
            string nota1 = txtboxnota1.Text;
            string nota2 = txtboxnota2.Text;
            string nota3 = txtboxnota3.Text;
            string nota4 = txtboxnota4.Text;

            string respuesta = CrudTareas.agregartarea(carnet, nota1, nota2, nota3,nota4);
            MessageBox.Show(respuesta);
            txtboxcarnet.Clear();
            txtboxnota1.Clear();
            txtboxnota2.Clear();
            txtboxnota3.Clear();
            txtboxnota4.Clear();
        }
    }
}
