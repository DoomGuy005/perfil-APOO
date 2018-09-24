using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Perfil_Marvel.Modelo;
using Perfil_Marvel.DAO;

namespace Perfil_Marvel.Visão
{
    /// <summary>
    /// Lógica interna para CRUDPerfis.xaml
    /// </summary>
    public partial class CRUDPerfis : Window
    {
        public CRUDPerfis()
        {
            InitializeComponent();
        }

        DAOPerfil dp = new DAOPerfil();
        Perfil p;
        List<Dica> dicas = new List<Dica>();
        int c = 0;
        bool editando = false;
        int index;

        private void btnAdicionarDica_Click(object sender, RoutedEventArgs e)
        {
            Dica d;
            lDicas.ItemsSource = null;
            if (txtDica.Text != "" && txtDica.Text != " ")
            {
                if (editando)
                {
                    dicas[index].texto = txtDica.Text;
                    editando = false;
                }
                else
                {
                    d = new Dica(p.nome, c, txtDica.Text);
                    dicas.Add(d);
                    c++;
                }
            }
          
            lDicas.ItemsSource = dicas;
            txtDica.Text = "";
        }

        private void btnEditarDica_Click(object sender, RoutedEventArgs e)
        {
            if (lDicas.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma dica para editar!");
            }
            else
            {
                txtDica.Text = ((Dica)lDicas.SelectedItem).ToStringSemNumero();
                editando = true;
                index = lDicas.SelectedIndex;
            }
        }

        private void lDicas_GotFocus(object sender, RoutedEventArgs e)
        {
            if (lDicas.SelectedItem != null)
            {
                btnEditarDica.IsEnabled = true;
            }
        }

        private void btnAdicionarPerfil_Click(object sender, RoutedEventArgs e)
        {
            if (txtNome.Text == "" || txtNome.Text == " ")
            {
                MessageBox.Show("Insira um nome para o perfil!");
            }
            else if (txtCategoria.Text == "" || txtCategoria.Text == " ")
            {
                MessageBox.Show("Insira uma categoria para o perfil!");
            }
            else if (lDicas.Items.Count < 10)
            {
                MessageBox.Show("Insira 10 dicas para o perfil!");

            }
            else{
                if (lDicas.Items.Count > 10)
                {
                    MessageBox.Show("Somente as 10 primeiras dicas serão inseridas!");
                    int rmv = dicas.Count - 10;
                    dicas.RemoveRange(10, rmv);
                }
                p = new Perfil(txtNome.Text, txtCategoria.Text, dicas);
                dp.Insert(p);
                MessageBox.Show("Perfil {0} inserido com sucesso!" +txtNome.Text);
                txtNome.Text = "";
                txtCategoria.Text = "";
                txtDica.Text = "";
                dicas.RemoveRange(0, 10);
                c = 0;
                editando = false;
                index = -1;
            }
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Close();
        }

        private void txtNome_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNome.Text != "" || txtNome.Text != " " ||
                txtCategoria.Text != "" || txtCategoria.Text != " ")
            {
                p = new Perfil(txtNome.Text, txtCategoria.Text, dicas);
            }
        }

        private void txtCategoria_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNome.Text != "" || txtNome.Text != " " || 
                txtCategoria.Text != "" || txtCategoria.Text != " ")
            {
                p = new Perfil(txtNome.Text, txtCategoria.Text, dicas);
            }
        }
    }
}
