namespace Registro_Usuarios
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_clientes = new System.Windows.Forms.Panel();
            this.btn_borrar_cliente = new System.Windows.Forms.Button();
            this.btn_actualizar_cliente = new System.Windows.Forms.Button();
            this.btn_editar_cliente = new System.Windows.Forms.Button();
            this.btn_crear_cliente = new System.Windows.Forms.Button();
            this.dataGridView_Clientes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_buscar_cliente = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btn_buscar_cliente = new System.Windows.Forms.Button();
            this.txt_Correo_cliente = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_edad_cliente = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_nombre_cliente = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.menuStrip1.SuspendLayout();
            this.panel_clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(743, 51);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(84, 27);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(89, 27);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Margin = new System.Windows.Forms.Padding(200, 10, 10, 10);
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(56, 27);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // panel_clientes
            // 
            this.panel_clientes.Controls.Add(this.btn_borrar_cliente);
            this.panel_clientes.Controls.Add(this.btn_actualizar_cliente);
            this.panel_clientes.Controls.Add(this.btn_editar_cliente);
            this.panel_clientes.Controls.Add(this.btn_crear_cliente);
            this.panel_clientes.Controls.Add(this.dataGridView_Clientes);
            this.panel_clientes.Controls.Add(this.txt_buscar_cliente);
            this.panel_clientes.Controls.Add(this.btn_buscar_cliente);
            this.panel_clientes.Controls.Add(this.txt_Correo_cliente);
            this.panel_clientes.Controls.Add(this.bunifuCustomLabel4);
            this.panel_clientes.Controls.Add(this.txt_edad_cliente);
            this.panel_clientes.Controls.Add(this.bunifuCustomLabel3);
            this.panel_clientes.Controls.Add(this.txt_nombre_cliente);
            this.panel_clientes.Controls.Add(this.bunifuCustomLabel2);
            this.panel_clientes.Controls.Add(this.bunifuCustomLabel1);
            this.panel_clientes.Location = new System.Drawing.Point(12, 67);
            this.panel_clientes.Name = "panel_clientes";
            this.panel_clientes.Size = new System.Drawing.Size(709, 557);
            this.panel_clientes.TabIndex = 1;
            // 
            // btn_borrar_cliente
            // 
            this.btn_borrar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar_cliente.Location = new System.Drawing.Point(563, 505);
            this.btn_borrar_cliente.Name = "btn_borrar_cliente";
            this.btn_borrar_cliente.Size = new System.Drawing.Size(119, 49);
            this.btn_borrar_cliente.TabIndex = 14;
            this.btn_borrar_cliente.Text = "Borrar";
            this.btn_borrar_cliente.UseVisualStyleBackColor = true;
            this.btn_borrar_cliente.Click += new System.EventHandler(this.btn_borrar_cliente_Click);
            // 
            // btn_actualizar_cliente
            // 
            this.btn_actualizar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar_cliente.Location = new System.Drawing.Point(563, 441);
            this.btn_actualizar_cliente.Name = "btn_actualizar_cliente";
            this.btn_actualizar_cliente.Size = new System.Drawing.Size(119, 49);
            this.btn_actualizar_cliente.TabIndex = 13;
            this.btn_actualizar_cliente.Text = "Actualizar";
            this.btn_actualizar_cliente.UseVisualStyleBackColor = true;
            this.btn_actualizar_cliente.Click += new System.EventHandler(this.btn_actualizar_cliente_Click);
            // 
            // btn_editar_cliente
            // 
            this.btn_editar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_cliente.Location = new System.Drawing.Point(563, 369);
            this.btn_editar_cliente.Name = "btn_editar_cliente";
            this.btn_editar_cliente.Size = new System.Drawing.Size(119, 49);
            this.btn_editar_cliente.TabIndex = 12;
            this.btn_editar_cliente.Text = "Editar";
            this.btn_editar_cliente.UseVisualStyleBackColor = true;
            this.btn_editar_cliente.Click += new System.EventHandler(this.btn_editar_cliente_Click);
            // 
            // btn_crear_cliente
            // 
            this.btn_crear_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear_cliente.Location = new System.Drawing.Point(563, 292);
            this.btn_crear_cliente.Name = "btn_crear_cliente";
            this.btn_crear_cliente.Size = new System.Drawing.Size(119, 49);
            this.btn_crear_cliente.TabIndex = 11;
            this.btn_crear_cliente.Text = "Crear";
            this.btn_crear_cliente.UseVisualStyleBackColor = true;
            this.btn_crear_cliente.Click += new System.EventHandler(this.btn_crear_cliente_Click);
            // 
            // dataGridView_Clientes
            // 
            this.dataGridView_Clientes.AllowUserToAddRows = false;
            this.dataGridView_Clientes.AllowUserToDeleteRows = false;
            this.dataGridView_Clientes.AllowUserToResizeColumns = false;
            this.dataGridView_Clientes.AllowUserToResizeRows = false;
            this.dataGridView_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Edad,
            this.Correo});
            this.dataGridView_Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_Clientes.Location = new System.Drawing.Point(30, 325);
            this.dataGridView_Clientes.Name = "dataGridView_Clientes";
            this.dataGridView_Clientes.RowHeadersVisible = false;
            this.dataGridView_Clientes.RowHeadersWidth = 51;
            this.dataGridView_Clientes.RowTemplate.Height = 24;
            this.dataGridView_Clientes.Size = new System.Drawing.Size(515, 229);
            this.dataGridView_Clientes.TabIndex = 10;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 147;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.Width = 60;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.Width = 175;
            // 
            // txt_buscar_cliente
            // 
            this.txt_buscar_cliente.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_buscar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_cliente.Location = new System.Drawing.Point(30, 292);
            this.txt_buscar_cliente.Name = "txt_buscar_cliente";
            this.txt_buscar_cliente.Size = new System.Drawing.Size(428, 27);
            this.txt_buscar_cliente.TabIndex = 9;
            // 
            // btn_buscar_cliente
            // 
            this.btn_buscar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_cliente.Location = new System.Drawing.Point(464, 292);
            this.btn_buscar_cliente.Name = "btn_buscar_cliente";
            this.btn_buscar_cliente.Size = new System.Drawing.Size(81, 30);
            this.btn_buscar_cliente.TabIndex = 8;
            this.btn_buscar_cliente.Text = "Buscar";
            this.btn_buscar_cliente.UseVisualStyleBackColor = true;
            this.btn_buscar_cliente.Click += new System.EventHandler(this.btn_buscar_cliente_Click);
            // 
            // txt_Correo_cliente
            // 
            this.txt_Correo_cliente.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Correo_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Correo_cliente.Location = new System.Drawing.Point(30, 227);
            this.txt_Correo_cliente.Name = "txt_Correo_cliente";
            this.txt_Correo_cliente.Size = new System.Drawing.Size(336, 27);
            this.txt_Correo_cliente.TabIndex = 6;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(36, 204);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(60, 20);
            this.bunifuCustomLabel4.TabIndex = 5;
            this.bunifuCustomLabel4.Text = "Correo";
            // 
            // txt_edad_cliente
            // 
            this.txt_edad_cliente.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_edad_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edad_cliente.Location = new System.Drawing.Point(30, 154);
            this.txt_edad_cliente.Name = "txt_edad_cliente";
            this.txt_edad_cliente.Size = new System.Drawing.Size(81, 27);
            this.txt_edad_cliente.TabIndex = 4;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(36, 131);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(47, 20);
            this.bunifuCustomLabel3.TabIndex = 3;
            this.bunifuCustomLabel3.Text = "Edad";
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_nombre_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_cliente.Location = new System.Drawing.Point(30, 81);
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.Size = new System.Drawing.Size(336, 27);
            this.txt_nombre_cliente.TabIndex = 2;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(36, 58);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(68, 20);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Nombre";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(25, 10);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(101, 29);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Clientes";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 636);
            this.Controls.Add(this.panel_clientes);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_clientes.ResumeLayout(false);
            this.panel_clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel panel_clientes;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_nombre_cliente;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Correo_cliente;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_edad_cliente;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Button btn_buscar_cliente;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_buscar_cliente;
        private System.Windows.Forms.DataGridView dataGridView_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.Button btn_crear_cliente;
        private System.Windows.Forms.Button btn_borrar_cliente;
        private System.Windows.Forms.Button btn_actualizar_cliente;
        private System.Windows.Forms.Button btn_editar_cliente;
    }
}