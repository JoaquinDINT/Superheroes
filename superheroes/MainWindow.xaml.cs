using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;


namespace superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowVM vm = new MainWindowVM();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void MasClick(object sender, MouseButtonEventArgs e)
        {
            vm.Avanza();
        }

        private void MenosClick(object sender, MouseButtonEventArgs e)
        {
            vm.Retrocede();
        }
    }
}
