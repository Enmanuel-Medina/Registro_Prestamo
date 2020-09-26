using Registro_Pago.Entidades;
using Registro_Pago.UI.Prestamo;
using System.Windows;

namespace Registro_Pago
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
         
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Prestamo pre = new Prestamo();
            pre.show();

        }
    }
}
