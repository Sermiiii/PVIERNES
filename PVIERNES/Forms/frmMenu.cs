using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVIERNES
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private Button botonActivoMenu = null; // PARA SABER QUE BOTON ESTA ACTIVO
        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // ACTIVAMOS LAS TECLAS DE FUNCIONES
            this.Text = "Menu";    // CAMBIAMOS EL TITULO AL FORMULARIO

            lblNombre.Text = cnn.miNombre;
            lblUsuario.Text = cnn.miUsuario;



            // ASEGURA QUE EL SUBMENU PERTENECE AL FORMULARIO BASE
            panelSubMenu.Dock = DockStyle.None;

            if(this.Controls.Contains(panelSubMenu) == false) 
            {
                Control panelPadreAnterior = panelSubMenu.Parent; 
                if(panelPadreAnterior != null)
                {
                    panelPadreAnterior.Controls.Remove(panelSubMenu);
                }
                this.Controls.Add(panelSubMenu);
            }

            panelSubMenu.Visible = false; 
        }

        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)  // AQUI PREGUNTA SI PRESIONASTE LA TECLA ESCAPE
            {
                Application.Exit();  // AQUI CIERRA LA APLICACION COMPLETA
            }
        }

        // --------------------------------------------------------------------------------------
        // METODOS
        //---------------------------------------------------------------------------------------

        private void Mover_y_Mostrar_SubMenu(Button botonPadre)
        {
            // BUSCAMOS EN EL CONTENEDOR IZQUERDO EL BOTON
            Control panelIzquierdo = botonPadre.Parent;

            int posisicionX = panelIzquierdo.Width;
            int posisicionY = panelIzquierdo.Location.Y + botonPadre.Location.Y;

            panelSubMenu.Location = new Point(posisicionX, posisicionY);
            panelSubMenu.BringToFront();
            panelSubMenu.Visible = true;
        }

        private void ConfigurarBotonesInternos(string nombreBoton)
        {
            if (nombreBoton == "btnUNO")
            {
                btnOPUNO.Text = "formulario uno";
                btnOPDOS.Text = "formulario dos";
                btnOPTRES.Text = "formulario tres";
            }
            else if (nombreBoton == "btnDOS")
            {
                btnOPUNO.Text = "consulta uno";
                btnOPDOS.Text = "consulta dos";
                btnOPTRES.Text = "consulta tres";
            }
            else if (nombreBoton == "btnTRES")
            {
                btnOPUNO.Text = "reporte uno";
                btnOPDOS.Text = "reporte dos";
                btnOPTRES.Text = "reporte tres";
            }
        }

        private void btnUNO_Click(object sender, EventArgs e)
        {
            // SI YA ESTA ABIERTO EL SUBMENU LO OCULTAMOS
            if (panelSubMenu.Visible && botonActivoMenu == btnUNO)
            {
                panelSubMenu.Visible = false;
                botonActivoMenu = null;
                return;
            }

            botonActivoMenu = btnUNO;
            ConfigurarBotonesInternos("btonUNO");
            Mover_y_Mostrar_SubMenu(btnUNO);
        }

        private void btnDOS_Click(object sender, EventArgs e)
        {
            // SI YA ESTA ABIERTO EL SUBMENU LO OCULTAMOS
            if (panelSubMenu.Visible && botonActivoMenu == btnDOS)
            {
                panelSubMenu.Visible = false;
                botonActivoMenu = null;
                return;
            }

            botonActivoMenu = btnDOS;
            ConfigurarBotonesInternos("btonDOS");
            Mover_y_Mostrar_SubMenu(btnDOS);
        }

        private void btnTRES_Click(object sender, EventArgs e)
        {
            // SI YA ESTA ABIERTO EL SUBMENU LO OCULTAMOS
            if (panelSubMenu.Visible && botonActivoMenu == btnTRES)
            {
                panelSubMenu.Visible = false;
                botonActivoMenu = null;
                return;
            }

            botonActivoMenu = btnTRES;
            ConfigurarBotonesInternos("btonTRES");
            Mover_y_Mostrar_SubMenu(btnTRES);
        }

        private void btnOPUNO_Click(object sender, EventArgs e)
        {
            if (botonActivoMenu == null ) return; 

            if (botonActivoMenu == btnUNO)
            {
                MessageBox.Show("Abriendo Formulario");
            }
            else if (botonActivoMenu == btnDOS)
            {
                MessageBox.Show("Abriendo Formulario");
            }
            else if (botonActivoMenu == btnTRES)
            {
                MessageBox.Show("Abriendo Formulario");
            }
        }
    }
}
