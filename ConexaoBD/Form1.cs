using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Npgsql;

namespace teste
{
    public partial class Form1 : Form
    {
      
        string Connection = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;
        NpgsqlConnection con = null;

        public void abrirConexao()
        {
            try
            {
                con = new NpgsqlConnection(Connection);
                con.Open();
                MessageBox.Show("banco de dados conectado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops falha ao conectar ao banco de dado " + ex.Message);
            }
        }

 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirConexao();
        }
    }
}
