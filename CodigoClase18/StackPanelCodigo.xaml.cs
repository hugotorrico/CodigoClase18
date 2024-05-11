using CodigoClase18.Controls;
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

namespace CodigoClase18
{
    /// <summary>
    /// Lógica de interacción para StackPanelCodigo.xaml
    /// </summary>
    public partial class StackPanelCodigo : Window
    {
        public StackPanelCodigo()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            StackPanel stackPanel = new StackPanel();
            TextBlock textBlock = new TextBlock { Text = "Nuevo" };
            Button button1 = new Button { Content = "Nuevo" };
            DatePicker datePicker= new DatePicker();
            stackPanel.Children.Add(textBlock);
            stackPanel.Children.Add(button1);
            stackPanel.Children.Add(datePicker);
            this.Content = stackPanel;

        }
    }
}
