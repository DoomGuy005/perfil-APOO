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
    /// Lógica interna para JogoWindow.xaml
    /// </summary>
    public partial class JogoWindow : Window
    {
        Partida partida;

        public JogoWindow(Partida partida)
        {
            this.partida = partida;
            InitializeComponent();
        }

        private void btnPalpite_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDica_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            IniciarWindow w = new IniciarWindow();
            w.Show();
            this.Close();
        }
    }
}
