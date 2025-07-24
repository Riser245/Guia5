namespace Ejemplo5_complementario_FC250417
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtcap = new System.Windows.Forms.TextBox();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.Dgvcontactos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcam = new System.Windows.Forms.TextBox();
            this.txtvel = new System.Windows.Forms.TextBox();
            this.txtbateria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvcontactos)).BeginInit();
            this.SuspendLayout();
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btneliminar.Location = new System.Drawing.Point(610, 157);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(119, 31);
            this.btneliminar.TabIndex = 21;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnguardar.Location = new System.Drawing.Point(460, 154);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(119, 34);
            this.btnguardar.TabIndex = 20;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtcap
            // 
            this.txtcap.Location = new System.Drawing.Point(479, 64);
            this.txtcap.Name = "txtcap";
            this.txtcap.Size = new System.Drawing.Size(100, 23);
            this.txtcap.TabIndex = 19;
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(340, 64);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(100, 23);
            this.txtcolor.TabIndex = 18;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(180, 61);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(100, 23);
            this.txtmodelo.TabIndex = 17;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(12, 64);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(100, 23);
            this.txtmarca.TabIndex = 16;
            // 
            // Dgvcontactos
            // 
            this.Dgvcontactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvcontactos.Location = new System.Drawing.Point(12, 231);
            this.Dgvcontactos.Name = "Dgvcontactos";
            this.Dgvcontactos.RowTemplate.Height = 25;
            this.Dgvcontactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgvcontactos.Size = new System.Drawing.Size(776, 207);
            this.Dgvcontactos.TabIndex = 15;
            this.Dgvcontactos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvcontactos_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Capacidad de RAM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Bateria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(632, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cámara principal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "velocidad de procesador";
            // 
            // txtcam
            // 
            this.txtcam.Location = new System.Drawing.Point(632, 64);
            this.txtcam.Name = "txtcam";
            this.txtcam.Size = new System.Drawing.Size(100, 23);
            this.txtcam.TabIndex = 25;
            // 
            // txtvel
            // 
            this.txtvel.Location = new System.Drawing.Point(12, 154);
            this.txtvel.Name = "txtvel";
            this.txtvel.Size = new System.Drawing.Size(100, 23);
            this.txtvel.TabIndex = 26;
            // 
            // txtbateria
            // 
            this.txtbateria.Location = new System.Drawing.Point(185, 154);
            this.txtbateria.Name = "txtbateria";
            this.txtbateria.Size = new System.Drawing.Size(100, 23);
            this.txtbateria.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbateria);
            this.Controls.Add(this.txtvel);
            this.Controls.Add(this.txtcam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtcap);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.Dgvcontactos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Dgvcontactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btneliminar;
        private Button btnguardar;
        private TextBox txtcap;
        private TextBox txtcolor;
        private TextBox txtmodelo;
        private TextBox txtmarca;
        private DataGridView Dgvcontactos;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtcam;
        private TextBox txtvel;
        private TextBox txtbateria;
    }
}