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

        int posicionArray = 0;
        List<Superheroe> listaHeroes;
        public MainWindow()
        {
            InitializeComponent();

            listaHeroes = Superheroe.GetSamples();

            principalBorder.DataContext = listaHeroes[posicionArray];
        }

        private void MasClick(object sender, MouseButtonEventArgs e)
        {
            if (posicionArray < 2)
            {
                posicionArray++;
                principalBorder.DataContext = listaHeroes[posicionArray];
                PosicionTextBlock.Text = (posicionArray + 1).ToString() + "/3"; 
            }
        }

        private void MenosClick(object sender, MouseButtonEventArgs e)
        {
            if (posicionArray > 0)
            {
                posicionArray--;
                principalBorder.DataContext = listaHeroes[posicionArray];
                PosicionTextBlock.Text = (posicionArray + 1).ToString() + "/3";
            }
        }
    }
}
