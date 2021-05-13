using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVentas.VISTA
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }
        public string usu;

        public void DesactivarResaltado()
        {
            //verificando que el boton actual sea diferente de nulo
            if (btnEnUso != null)
            {
                //RETORNANDO A LAS CONFIGURACIONES POR DEFECTO
                //retornando el color por defecto del boton
                btnEnUso.BackColor = Color.FromArgb(15, 159, 191);
                //Aliniando el texto al centro
                btnEnUso.TextAlign = ContentAlignment.MiddleCenter;
                //cambiado relacion de texto a imagen antes de texto
                btnEnUso.TextImageRelation = TextImageRelation.ImageBeforeText;
                //Aliniando el icono a la izquierda
                btnEnUso.ImageAlign = ContentAlignment.MiddleCenter;
                btnEnUso.FlatAppearance.BorderSize = 0;
            }
        }

        Button btnEnUso = new Button();
        //Metodo void para resaltar el botón activo
        public void BotonActivo(object btnActivo)
        {
            //verificando que el botón sea diferente de nulo
            if (btnActivo != null)
            {
                //invocando el método de desactivar resaltado para desactivar el resaltado
                //en el boton anterior
                DesactivarResaltado();
                //BOTÓN
                btnEnUso = (Button)btnActivo;
                //cambiando el color de fondo del color
                btnEnUso.BackColor = Color.FromArgb(242, 208, 107);
                //Aliniando el texto al centro
                btnEnUso.TextAlign = ContentAlignment.MiddleCenter;
                //cambiado relacion de texto a texto antes de imagen
                btnEnUso.TextImageRelation = TextImageRelation.TextBeforeImage;
                //Aliniando el icono a la derecha
                btnEnUso.ImageAlign = ContentAlignment.MiddleRight;
                btnEnUso.FlatAppearance.BorderSize = 3;


                ////BORDE IZQUIERDO DEL BOTON
                ////se cambia el borde izquierdo de acuerdo al parámetro color de método
                //bordeIzquierdoDelBoton.BackColor = Color.FromArgb(67, 194, 243);
                ////nueva ubicacion en el eje x y obteniedo la ubicacion en el eje y del boton actual
                //bordeIzquierdoDelBoton.Location = new Point(0, btnEnUso.Location.Y);
                ////visibilidad en verdader
                //bordeIzquierdoDelBoton.Visible = true;
                ////trayendo al frente
                //bordeIzquierdoDelBoton.BringToFront();
            }
        }
        private Form formulario;
        private void AbrirFormEnPanel<Miform>() where Miform : Form, new()
        {
            if (formulario != null)
            {
                formulario.Close();
            }

            formulario = pnlPadre.Controls.OfType<Miform>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Miform();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                pnlPadre.Controls.Add(formulario);
                pnlPadre.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }

            else
            {
                formulario.BringToFront();
            }
        }
        private void pnlUsuarioIngresado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlPadre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
           //lblUsuarioIngresado.Text = usu;
        }

        private void btbPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<FrmClientes>();
            BotonActivo(btnClientes);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (formulario != null)
            {
                formulario.Close();
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<FrmProductos>();
            BotonActivo(btnProductos);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<FrmVenta>();
            BotonActivo(btnVentas);
        }

        private void btnDocumentos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<FrmDocumentos>();
            BotonActivo(btnDocumentos);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<FrmUsuarios>();
            BotonActivo(btnUsuarios);
        }

        private void btnActividad_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel<FrmClientes>();
            BotonActivo(btnActividad);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
