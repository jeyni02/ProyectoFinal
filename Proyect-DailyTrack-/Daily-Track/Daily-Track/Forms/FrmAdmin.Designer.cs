﻿namespace Daily_Track.Forms
{
    partial class FrmAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPaas = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbPaas);
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(231, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 327);
            this.panel1.TabIndex = 0;
            // 
            // btnInto
            // 
            this.btnInto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.btnInto.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInto.Location = new System.Drawing.Point(154, 259);
            this.btnInto.Name = "btnInto";
            this.btnInto.Size = new System.Drawing.Size(132, 36);
            this.btnInto.TabIndex = 10;
            this.btnInto.Text = "Ingresar";
            this.btnInto.UseVisualStyleBackColor = false;
            this.btnInto.Click += new System.EventHandler(this.btnInto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // tbPaas
            // 
            this.tbPaas.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPaas.Location = new System.Drawing.Point(59, 201);
            this.tbPaas.Name = "tbPaas";
            this.tbPaas.PasswordChar = '*';
            this.tbPaas.Size = new System.Drawing.Size(328, 29);
            this.tbPaas.TabIndex = 6;
            this.tbPaas.TextChanged += new System.EventHandler(this.tbPaas_TextChanged);
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(59, 111);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(338, 29);
            this.tbID.TabIndex = 5;
            this.tbID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.label2.Location = new System.Drawing.Point(139, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Iniciar secion ";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::Daily_Track.Properties.Resources.BOTONSalir;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(201)))), ((int)(((byte)(214)))));
            this.btnBack.Location = new System.Drawing.Point(12, 376);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 44);
            this.btnBack.TabIndex = 11;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(201)))), ((int)(((byte)(214)))));
            this.label.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.label.Location = new System.Drawing.Point(-3, 204);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(121, 18);
            this.label.TabIndex = 12;
            this.label.Text = "Administrador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(135, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(619, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Daily Track-UAM: Calendario Universitario";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Daily_Track.Properties.Resources.Fondosuserandadmin_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPaas;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInto;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
    }
}