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

namespace Examen_de_manejo_LectO.Pages
{
    /// <summary>
    /// Interaction logic for Pag_Home.xaml
    /// </summary>
    public partial class Pag_Home : Page
    {
        public string nombreApellido;
        public string documento;

        public Pag_Home()
        {
            InitializeComponent();
            Task.Run(Cuestionario.UpdateDB).Wait();
        }

        private void btnEmpezar_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombreApellido.Text.Length > 0 && txtDocumento.Text.Length > 0)
            {
                nombreApellido = txtNombreApellido.Text;
                documento = txtDocumento.Text;
                NavigationService.Navigate(new Pag_Preguntas(this));
            }
            else
            {
                MessageBox.Show("Por favor, complete los campos antes de comenzar");
            }
        }
    }
}
