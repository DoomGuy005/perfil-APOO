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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Perfil_Marvel.Visão
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, RoutedEventArgs e)
        {
            IniciarWindow w = new IniciarWindow();
            w.Show();
            this.Close();
        }

        private void btnInserirPerfis_Click(object sender, RoutedEventArgs e)
        {
            CRUDPerfis w = new CRUDPerfis();
            w.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
