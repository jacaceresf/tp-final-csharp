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

namespace MiAuto0KmWPF
{
    /// <summary>
    /// Interaction logic for w_Marca.xaml
    /// </summary>
    public partial class w_Marca : Window
    {
        cerokmdbEntities datos;
        public w_Marca()
        {
            InitializeComponent();
            datos = new cerokmdbEntities();
        }

        private void CargarDatosGrilla()
        {
            try
            {
                dgMarcas.ItemsSource = datos.Marca.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CargarDatosGrilla();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtId.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (dgMarcas.SelectedItem != null)
            {
                Marca m = (Marca)dgMarcas.SelectedItem;
                datos.Marca.Remove(m);
                datos.SaveChanges();
                CargarDatosGrilla();
            }
            else
                MessageBox.Show("Debe seleccionar una Artesania de la grilla para eliminar!");
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            if (dgMarcas.SelectedItem != null)
            {
                Marca m = (Marca)dgMarcas.SelectedItem;
                m.Nombre_Marca = txtNombre.Text;
                m.Descripcion_Marca = txtDescripcion.Text;
                datos.Entry(m).State = System.Data.Entity.EntityState.Modified;
                datos.SaveChanges();
                CargarDatosGrilla();
            }
            else
                MessageBox.Show("Debe seleccionar una Marca de la grilla para modificar!");
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Marca m = new Marca();
            m.Nombre_Marca = txtNombre.Text;
            m.Descripcion_Marca = txtDescripcion.Text;
            datos.Marca.Add(m);
            datos.SaveChanges();
            CargarDatosGrilla();
        }

        private void dgMarcas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
          if (dgMarcas.SelectedItem != null)
            {
                Marca m = (Marca)dgMarcas.SelectedItem;
                txtId.Text = m.ID_Marca.ToString();
                txtDescripcion.Text = m.Descripcion_Marca;
                txtNombre.Text = m.Nombre_Marca;
            }
            else
                MessageBox.Show("Debe seleccionar una Marca de la grilla para modificar!");
        }

        private void dgMarcas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
