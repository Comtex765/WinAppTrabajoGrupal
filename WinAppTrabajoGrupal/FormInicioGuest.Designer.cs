﻿namespace WinAppTrabajoGrupal
{
    partial class FormInicioGuest
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonVer = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonListar = new System.Windows.Forms.Button();
            this.panelCargarForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.panelMenu.Controls.Add(this.buttonVer);
            this.panelMenu.Controls.Add(this.buttonSalir);
            this.panelMenu.Controls.Add(this.buttonListar);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(127, 486);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonVer
            // 
            this.buttonVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.buttonVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVer.ForeColor = System.Drawing.Color.White;
            this.buttonVer.Location = new System.Drawing.Point(0, 0);
            this.buttonVer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonVer.Name = "buttonVer";
            this.buttonVer.Size = new System.Drawing.Size(127, 162);
            this.buttonVer.TabIndex = 1;
            this.buttonVer.Text = "Visualizar Empleados";
            this.buttonVer.UseVisualStyleBackColor = false;
            this.buttonVer.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.buttonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.White;
            this.buttonSalir.Location = new System.Drawing.Point(0, 324);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(127, 162);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonListar
            // 
            this.buttonListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.buttonListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListar.ForeColor = System.Drawing.Color.White;
            this.buttonListar.Location = new System.Drawing.Point(0, 162);
            this.buttonListar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(127, 162);
            this.buttonListar.TabIndex = 3;
            this.buttonListar.Text = "Listar Empleados";
            this.buttonListar.UseVisualStyleBackColor = false;
            this.buttonListar.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelCargarForm
            // 
            this.panelCargarForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.panelCargarForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCargarForm.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelCargarForm.Location = new System.Drawing.Point(127, 0);
            this.panelCargarForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCargarForm.Name = "panelCargarForm";
            this.panelCargarForm.Size = new System.Drawing.Size(907, 486);
            this.panelCargarForm.TabIndex = 1;
            // 
            // FormInicioGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 486);
            this.Controls.Add(this.panelCargarForm);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormInicioGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicación de Empresa";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.Button buttonVer;
        private System.Windows.Forms.Panel panelCargarForm;
    }
}