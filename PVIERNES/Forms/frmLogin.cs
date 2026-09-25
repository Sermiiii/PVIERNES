using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace PVIERNES
{
    
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string password;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // ACTIVAMOS LAS TECLAS DE FUNCIONES
            this.Text = "Login";    // CAMBIAMOS EL TITULO AL FORMULARIO
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)  // AQUI PREGUNTA SI PRESIONASTE LA TECLA ESCAPE
            {
                Application.Exit();  // AQUI CIERRA LA APLICACION COMPLETA
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) // AQUI PREGUNTA SI PRESIONASTE LA TECLA ENTER
            {
                e.Handled = true;  // EL TRIM LIMPIA LOS ESPACIOS EN BLANCO DEL INICIO Y FINAL DEL TEXTO
                if (txtUsuario.Text.Trim() != string.Empty) // AQUI PREGUNTA SI EL TEXTBOX DE USUARIO NO ESTA VACIO
                {
                    txtPassword.Focus(); // Mueve el cursor hacia el siguiente textbox (txtPassword)
                }
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != string.Empty) // AQUI PREGUNTA SI EL TEXTBOX DE USUARIO NO ESTA VACIO
            {
                BuscarUsuario(txtUsuario.Text);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == (int)Keys.Enter) // AQUI PREGUNTA SI PRESIONASTE LA TECLA ENTER
            {
                e.Handled = true;  // EL TRIM LIMPIA LOS ESPACIOS EN BLANCO DEL INICIO Y FINAL DEL TEXTO
                if (txtPassword.Text.Trim() != string.Empty) // AQUI PREGUNTA SI EL TEXTBOX DE USUARIO NO ESTA VACIO
                {
                    btnEntrar.Focus(); // Mueve el cursor hacia el siguiente textbox (txtPassword)
                }
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() != string.Empty) // AQUI PREGUNTA SI EL TEXTBOX DE USUARIO NO ESTA VACIO
            {
                btnEntrar.PerformClick();  // AQUI EJECUTURA EL EVENTO DEL BOTON BTNENTRAR
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != string.Empty) // AQUI PREGUNTA SI EL TEXTBOX DE USUARIO NO ESTA VACIO
            {
                if (txtPassword.Text.Trim() != string.Empty) // AQUI PREGUNTA SI EL TEXTBOX DE USUARIO NO ESTA VACIO
                {
                    if (txtPassword.Text.Trim() == password) // AQUI PREGUNTA SI EL TEXTBOX es igual al valor del archivo 
                    {
                        this.Hide(); // EL LOGIN ESTARA INVISIBLE O ESCONDIDO PARA EL USUARIO

                        frmMenu frm = new frmMenu();
                        frm.ShowDialog();

                        txtPassword.Clear(); // LIMPIA EL TEXTO DEL TEXTBOX DE PASSWORD
                        txtUsuario.Clear(); // LIMPIA EL TEXTO DEL TEXTBOX DE USUARIO
                        password = string.Empty; // LIMPIA EL VALOR DE LA VARIABLE PASSWORD

                        this.Show(); // MUESTRA EL LOGIN NUEVAMENTE CUANDO SE CIERRA EL MENU
                    }
                    else
                    {
                        MessageBox.Show("Clave Incorrecta", "miAPP", MessageBoxButtons.OK, MessageBoxIcon.Information); // MENSAJE DE ERROR SI EL PASSWORD ES INCORRECTO
                    }
                }
                else
                {
                    MessageBox.Show("Clave Incorrecta", "miAPP", MessageBoxButtons.OK, MessageBoxIcon.Information); // MENSAJE DE ERROR SI EL PASSWORD ES INCORRECTO
                }

            }
            else
            {
                MessageBox.Show("Usuario Incorrecto", "miAPP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // AQUI CIERRA LA APLICACION COMPLETA
        }

        // -------------------------------------------------------------

        private void BuscarUsuario(string _usuario)
        {
            password = "";

            cnn.miUsuario = "";
            cnn.miNombre = "";
            cnn.miApellido = "";

            // VAMOS A VALIDAR QUE EL ARCHIVO SOLICITADO EXISTA
            if (!File.Exists(cnn.rutaArchivo))
            {
                MessageBox.Show("No se encontró el archivo de usuario", "miAPP", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // CREAMOS UN CONTENEDOR (UN ARREGLO) 
            string[] contenedor = File.ReadAllLines(cnn.rutaArchivo);   

            foreach (string _linea in contenedor)
            {
                // VAMOS A PREGUNTAR QUE SI LA PRIMERA LINEA ESTA VACIA
                if (string.IsNullOrEmpty(_linea)) continue;

                string[] datos = _linea.Split('|'); // SEPARAMOS LOS DATOS POR EL CARACTER '|'

                if (datos.Length >= 5)
                {
                    string usuarioArchivo = datos[0].Trim(); // AQUI TOMAMOS EL USUARIO 

                    if (string.Equals(usuarioArchivo, _usuario, StringComparison.OrdinalIgnoreCase))
                    {
                        string usuarioActivo = datos[2].Trim(); 

                        if (string.Equals(usuarioActivo, "Inactivo", StringComparison.OrdinalIgnoreCase))
                        {
                            password = "Inactivo"; 
                        }
                        else
                        {
                            password = datos[1].Trim(); // TOMAMOS EL PASSWORD DEL ARCHIVO

                            cnn.miUsuario = _usuario; // ASIGNAMOS EL USUARIO DEL TEXTBOX
                            cnn.miNombre = datos[3].Trim(); // ASIGNA EL NOMBRE QUE VIENE DEL ARCHIVO
                            cnn.miApellido = datos[4].Trim(); // ASIGNA EL APELLIDO QUE VIENE DEL ARCHIVO
                        }

                        break; 
                    }
                }
            }
        }
    }
}
