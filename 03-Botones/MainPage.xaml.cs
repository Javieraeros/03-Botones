using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _03_Botones
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        
        /// <summary>
        /// Acción de cargar la página con un bóton que hemos creado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Button boton3 = new Button();
            boton3.Name = "Boton3";
            boton3.Content = "Boton3";
            boton3.HorizontalContentAlignment =HorizontalAlignment.Center;
            boton3.VerticalContentAlignment = VerticalAlignment.Center;
            boton3.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Blue);
            boton3.Width = 200;
            boton3.Height = 70;
            boton3.FontFamily = new FontFamily("Verdana");
            boton3.FontSize = 16;
            boton3.FontWeight= FontWeights.Bold;
            boton3.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Yellow) ;
           
            boton3.Click += Boton3_Click;
            misp.Children.Add(boton3);
        }
        /// <summary>
        /// Al clickar en el botón 3 se nos abre una ventana que nos dice Hola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Boton3_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog md = new MessageDialog("Hola Fernando");
           // md.ShowAsync
        }
    }
}
