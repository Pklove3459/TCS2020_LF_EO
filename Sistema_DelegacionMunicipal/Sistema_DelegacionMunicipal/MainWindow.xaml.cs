﻿using System;
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
using Sistema_DelegacionMunicipal.ViewController;

namespace Sistema_DelegacionMunicipal
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int botonSeleccionado = 5;

        Chat chat = new Chat();
        Conductor conductor = new Conductor();
        HistorialReportes historialReportes = new HistorialReportes();
        LevantarReporte levantarReporte = new LevantarReporte();
        Inicio inicio = new Inicio();

        public MainWindow()
        {
            InitializeComponent();
            GridPrincipal.Children.Add(inicio);
            btnInicio.Background = Brushes.White;
        }


        private void BtnConductores_Click(object sender, RoutedEventArgs e)
        {
            if (botonSeleccionado != 1)
            {
                cambiarBoton(1);
                GridPrincipal.Children.Clear();
                GridPrincipal.Children.Add(conductor);
            }
        }

        private void BtnLevantarReporte_Click(object sender, RoutedEventArgs e)
        {
            if (botonSeleccionado != 2)
            {
                cambiarBoton(2);
                GridPrincipal.Children.Clear();
                GridPrincipal.Children.Add(levantarReporte);
            }
        }

        private void BtnHistorialReportes_Click(object sender, RoutedEventArgs e)
        {
            if (botonSeleccionado != 3)
            {
                cambiarBoton(3);
                GridPrincipal.Children.Clear();
                GridPrincipal.Children.Add(historialReportes);
            }
        }

        private void btnChat_Click(object sender, RoutedEventArgs e)
        {
            if (botonSeleccionado != 4)
            {
                cambiarBoton(4);
                GridPrincipal.Children.Clear();
                GridPrincipal.Children.Add(chat);
            }
        }

        private void BtnInicio_Click(object sender, RoutedEventArgs e)
        {
            if (botonSeleccionado != 5)
            {
                cambiarBoton(5);
                GridPrincipal.Children.Clear();
                GridPrincipal.Children.Add(inicio);
            }
        }


        public void MostrarAgregarConductor()
        {
            GridPrincipal.Children.Clear();
            GridPrincipal.Children.Add(new AgregarConductor());
        }



        private void cambiarBoton(int seleccionado)
        {
            btnConductores.Background = Brushes.Transparent;
            btnLevantarReporte.Background = Brushes.Transparent;
            btnHistorialReportes.Background = Brushes.Transparent;
            btnChat.Background = Brushes.Transparent;
            btnInicio.Background = Brushes.Transparent;

            switch (seleccionado)
            {
                case (0):

                    break;

                case (1):
                    botonSeleccionado = 1;
                    btnConductores.Background = Brushes.White;
                    break;

                case (2):
                    botonSeleccionado = 2;
                    btnLevantarReporte.Background = Brushes.White;
                    break;

                case (3):
                    botonSeleccionado = 3;
                    btnHistorialReportes.Background = Brushes.White;
                    break;

                case (4):
                    botonSeleccionado = 4;
                    btnChat.Background = Brushes.White;
                    break;

                case (5):
                    botonSeleccionado = 5;
                    btnInicio.Background = Brushes.White;
                    break;
            }

        }

        
    }
}