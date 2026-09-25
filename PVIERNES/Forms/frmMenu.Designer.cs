using System.Windows.Forms;
namespace PVIERNES
{
    partial class frmMenu : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCINCO = new System.Windows.Forms.Button();
            this.btnCUATRO = new System.Windows.Forms.Button();
            this.btnTRES = new System.Windows.Forms.Button();
            this.btnDOS = new System.Windows.Forms.Button();
            this.btnUNO = new System.Windows.Forms.Button();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.btnOPTRES = new System.Windows.Forms.Button();
            this.btnOPDOS = new System.Windows.Forms.Button();
            this.btnOPUNO = new System.Windows.Forms.Button();
            this.picApp = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picApp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Controls.Add(this.panel5);
            this.panelHeader.Controls.Add(this.panel2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1029, 48);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(195, 27);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Menu General";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(240, 47);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 176);
            this.panel5.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 409);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 0);
            this.panel3.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnCINCO);
            this.panelMenu.Controls.Add(this.btnCUATRO);
            this.panelMenu.Controls.Add(this.btnTRES);
            this.panelMenu.Controls.Add(this.btnDOS);
            this.panelMenu.Controls.Add(this.btnUNO);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 48);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(241, 461);
            this.panelMenu.TabIndex = 2;
            // 
            // btnCINCO
            // 
            this.btnCINCO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCINCO.Location = new System.Drawing.Point(0, 180);
            this.btnCINCO.Name = "btnCINCO";
            this.btnCINCO.Size = new System.Drawing.Size(241, 45);
            this.btnCINCO.TabIndex = 4;
            this.btnCINCO.Text = "Menu Cinco";
            this.btnCINCO.UseVisualStyleBackColor = true;
            // 
            // btnCUATRO
            // 
            this.btnCUATRO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCUATRO.Location = new System.Drawing.Point(0, 135);
            this.btnCUATRO.Name = "btnCUATRO";
            this.btnCUATRO.Size = new System.Drawing.Size(241, 45);
            this.btnCUATRO.TabIndex = 3;
            this.btnCUATRO.Text = "Menu Cuatro";
            this.btnCUATRO.UseVisualStyleBackColor = true;
            // 
            // btnTRES
            // 
            this.btnTRES.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTRES.Location = new System.Drawing.Point(0, 90);
            this.btnTRES.Name = "btnTRES";
            this.btnTRES.Size = new System.Drawing.Size(241, 45);
            this.btnTRES.TabIndex = 2;
            this.btnTRES.Text = "Menu Tres";
            this.btnTRES.UseVisualStyleBackColor = true;
            this.btnTRES.Click += new System.EventHandler(this.btnTRES_Click);
            // 
            // btnDOS
            // 
            this.btnDOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDOS.Location = new System.Drawing.Point(0, 45);
            this.btnDOS.Name = "btnDOS";
            this.btnDOS.Size = new System.Drawing.Size(241, 45);
            this.btnDOS.TabIndex = 1;
            this.btnDOS.Text = "Menu Dos";
            this.btnDOS.UseVisualStyleBackColor = true;
            this.btnDOS.Click += new System.EventHandler(this.btnDOS_Click);
            // 
            // btnUNO
            // 
            this.btnUNO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUNO.Location = new System.Drawing.Point(0, 0);
            this.btnUNO.Name = "btnUNO";
            this.btnUNO.Size = new System.Drawing.Size(241, 45);
            this.btnUNO.TabIndex = 0;
            this.btnUNO.Text = "Menu Uno";
            this.btnUNO.UseVisualStyleBackColor = true;
            this.btnUNO.Click += new System.EventHandler(this.btnUNO_Click);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.Controls.Add(this.btnOPTRES);
            this.panelSubMenu.Controls.Add(this.btnOPDOS);
            this.panelSubMenu.Controls.Add(this.btnOPUNO);
            this.panelSubMenu.Location = new System.Drawing.Point(241, 48);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(260, 209);
            this.panelSubMenu.TabIndex = 3;
            // 
            // btnOPTRES
            // 
            this.btnOPTRES.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOPTRES.Location = new System.Drawing.Point(0, 90);
            this.btnOPTRES.Name = "btnOPTRES";
            this.btnOPTRES.Size = new System.Drawing.Size(260, 45);
            this.btnOPTRES.TabIndex = 4;
            this.btnOPTRES.Text = "Tres";
            this.btnOPTRES.UseVisualStyleBackColor = true;
            // 
            // btnOPDOS
            // 
            this.btnOPDOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOPDOS.Location = new System.Drawing.Point(0, 45);
            this.btnOPDOS.Name = "btnOPDOS";
            this.btnOPDOS.Size = new System.Drawing.Size(260, 45);
            this.btnOPDOS.TabIndex = 4;
            this.btnOPDOS.Text = "Dos";
            this.btnOPDOS.UseVisualStyleBackColor = true;
            // 
            // btnOPUNO
            // 
            this.btnOPUNO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOPUNO.Location = new System.Drawing.Point(0, 0);
            this.btnOPUNO.Name = "btnOPUNO";
            this.btnOPUNO.Size = new System.Drawing.Size(260, 45);
            this.btnOPUNO.TabIndex = 1;
            this.btnOPUNO.Text = "Uno";
            this.btnOPUNO.UseVisualStyleBackColor = true;
            this.btnOPUNO.Click += new System.EventHandler(this.btnOPUNO_Click);
            // 
            // picApp
            // 
            this.picApp.Image = global::PVIERNES.Properties.Resources.IMG_5948;
            this.picApp.Location = new System.Drawing.Point(568, 251);
            this.picApp.Name = "picApp";
            this.picApp.Size = new System.Drawing.Size(428, 212);
            this.picApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picApp.TabIndex = 4;
            this.picApp.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(801, 475);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(195, 25);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "label2";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(600, 475);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(195, 25);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "label2";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 509);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.picApp);
            this.Controls.Add(this.panelSubMenu);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelHeader);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMenu_KeyDown);
            this.panelHeader.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button btnCINCO;
        private System.Windows.Forms.Button btnCUATRO;
        private System.Windows.Forms.Button btnTRES;
        private System.Windows.Forms.Button btnDOS;
        private System.Windows.Forms.Button btnUNO;
        private System.Windows.Forms.Button btnOPTRES;
        private System.Windows.Forms.Button btnOPDOS;
        private System.Windows.Forms.Button btnOPUNO;
        private System.Windows.Forms.PictureBox picApp;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
    }
}