namespace Usuariosp
{
    partial class GestionarClientes
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
            this.listClientes = new System.Windows.Forms.ListBox();
            this.labNombre = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.boxNombre = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.boxApellido = new System.Windows.Forms.TextBox();
            this.labApellido = new System.Windows.Forms.Label();
            this.boxTelefono = new System.Windows.Forms.TextBox();
            this.labTelefono = new System.Windows.Forms.Label();
            this.boxTarjeta = new System.Windows.Forms.TextBox();
            this.labTarjeta = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listClientes
            // 
            this.listClientes.FormattingEnabled = true;
            this.listClientes.Location = new System.Drawing.Point(12, 12);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(280, 316);
            this.listClientes.TabIndex = 0;
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(316, 39);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(58, 15);
            this.labNombre.TabIndex = 1;
            this.labNombre.Text = "Nombre: ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(498, 305);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // boxNombre
            // 
            this.boxNombre.Location = new System.Drawing.Point(383, 38);
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.Size = new System.Drawing.Size(190, 20);
            this.boxNombre.TabIndex = 3;
            this.boxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxNombre_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(319, 305);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // boxApellido
            // 
            this.boxApellido.Location = new System.Drawing.Point(383, 74);
            this.boxApellido.Name = "boxApellido";
            this.boxApellido.Size = new System.Drawing.Size(190, 20);
            this.boxApellido.TabIndex = 6;
            this.boxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxApellido_KeyPress);
            // 
            // labApellido
            // 
            this.labApellido.AutoSize = true;
            this.labApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApellido.Location = new System.Drawing.Point(316, 74);
            this.labApellido.Name = "labApellido";
            this.labApellido.Size = new System.Drawing.Size(57, 15);
            this.labApellido.TabIndex = 5;
            this.labApellido.Text = "Apellido: ";
            // 
            // boxTelefono
            // 
            this.boxTelefono.Location = new System.Drawing.Point(383, 111);
            this.boxTelefono.Name = "boxTelefono";
            this.boxTelefono.Size = new System.Drawing.Size(190, 20);
            this.boxTelefono.TabIndex = 8;
            this.boxTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxTelefono_KeyPress);
            // 
            // labTelefono
            // 
            this.labTelefono.AutoSize = true;
            this.labTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTelefono.Location = new System.Drawing.Point(316, 112);
            this.labTelefono.Name = "labTelefono";
            this.labTelefono.Size = new System.Drawing.Size(61, 15);
            this.labTelefono.TabIndex = 7;
            this.labTelefono.Text = "Teléfono: ";
            // 
            // boxTarjeta
            // 
            this.boxTarjeta.Location = new System.Drawing.Point(319, 183);
            this.boxTarjeta.Name = "boxTarjeta";
            this.boxTarjeta.Size = new System.Drawing.Size(254, 20);
            this.boxTarjeta.TabIndex = 10;
            this.boxTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxTarjeta_KeyPress);
            // 
            // labTarjeta
            // 
            this.labTarjeta.AutoSize = true;
            this.labTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTarjeta.Location = new System.Drawing.Point(316, 150);
            this.labTarjeta.Name = "labTarjeta";
            this.labTarjeta.Size = new System.Drawing.Size(107, 15);
            this.labTarjeta.TabIndex = 9;
            this.labTarjeta.Text = "Tarjeta de Crédito:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(408, 305);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(380, 12);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 13);
            this.labelId.TabIndex = 13;
            // 
            // GestionarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 345);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.boxTarjeta);
            this.Controls.Add(this.labTarjeta);
            this.Controls.Add(this.boxTelefono);
            this.Controls.Add(this.labTelefono);
            this.Controls.Add(this.boxApellido);
            this.Controls.Add(this.labApellido);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.boxNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labNombre);
            this.Controls.Add(this.listClientes);
            this.Name = "GestionarClientes";
            this.Text = "GestionarClientes";
            this.Load += new System.EventHandler(this.GestionarClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listClientes;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox boxNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox boxApellido;
        private System.Windows.Forms.Label labApellido;
        private System.Windows.Forms.TextBox boxTelefono;
        private System.Windows.Forms.Label labTelefono;
        private System.Windows.Forms.TextBox boxTarjeta;
        private System.Windows.Forms.Label labTarjeta;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelId;
    }
}