using Perfil_Marvel.Modelo;
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

namespace Perfil_Marvel.Visão
{
    /// <summary>
    /// Lógica interna para IniciarWindow.xaml
    /// </summary>
    public partial class IniciarWindow : Window
    {
        public IniciarWindow()
        {
            InitializeComponent();
        }

        /*Salva o número de jogadores e libera a inserção de
        nomes dos jogadores proporcionalmente ao escolhido*/
        private void btnConfNumJogadores_Click(object sender, RoutedEventArgs e)
        {
            txtJog1.IsEnabled = true;
            txtJog2.IsEnabled = true;

            if (rb3Jogadores.IsChecked == true)
            {
                txtJog3.IsEnabled = true;
            }
            if (rb4Jogadores.IsChecked == true)
            {
                txtJog3.IsEnabled = true;
                txtJog4.IsEnabled = true;
            }
        }

        private void btnJogar_Click(object sender, RoutedEventArgs e)
        {
            //DALPartida dalPartida = new DALPartida();

            //Padrão
            if ((txtJog1.Text == "") || (txtJog1.Text == " "))
            {
                MessageBox.Show("Verifique o nome dos Jogador 1! (Pss: lembre de inserir todos :)");
            }
            else if ((txtJog2.Text == "") || (txtJog2.Text == " "))
            {
                MessageBox.Show("Verifique o nome do Jogador 2! (Pss: lembre de inserir todos :)");
            }

            //Em caso de 3 jogadores
            else if (rb3Jogadores.IsChecked == true)
            {
                if ((txtJog3.Text == "") || (txtJog3.Text == " "))
                {
                    MessageBox.Show("Verifique o nome do Jogador 3! (Pss: lembre de inserir todos :)");
                }
            }

            //Em caso de 4 jogadores
            else if (rb4Jogadores.IsChecked == true)
            {
                if ((txtJog3.Text == "") || (txtJog3.Text == " "))
                {
                    MessageBox.Show("Verifique o nome do Jogador 3! (Pss: lembre de inserir todos :)");
                }
                if ((txtJog4.Text == "") || (txtJog4.Text == " "))
                {
                    MessageBox.Show("Verifique o nome do Jogador 4! (Pss: lembre de inserir todos :)");
                }
            }

            //Caso não haja erro
            else
            {
                Partida partida;
                List<Participante> participantes = new List<Participante>();

                Participante P1 = new Participante(txtJog1.Text);
                Participante P2 = new Participante(txtJog2.Text);
                participantes.Add(P1);
                participantes.Add(P2);

                if (rb3Jogadores.IsChecked == true)
                {
                    Participante P3 = new Participante(txtJog3.Text);
                    participantes.Add(P3);
                }
                if (rb4Jogadores.IsChecked == true)
                {
                    Participante P3 = new Participante(txtJog3.Text);
                    participantes.Add(P3);
                    Participante P4 = new Participante(txtJog4.Text);
                    participantes.Add(P4);
                }

                partida = new Partida(participantes);
                JogoWindow w = new JogoWindow(partida);
                w.Show();
                this.Close();
            }
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Close();
        }
    }
}

