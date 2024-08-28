namespace Buscador_Telefonos
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_documento = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.check_clientes = new System.Windows.Forms.CheckBox();
            this.toolTip_buscar = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOCUMENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TELEFONO";
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(40, 40);
            this.txt_documento.Margin = new System.Windows.Forms.Padding(2);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(115, 20);
            this.txt_documento.TabIndex = 1;
            this.txt_documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Escape);
            this.txt_documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Enter);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(224, 40);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(2);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(115, 20);
            this.txt_telefono.TabIndex = 2;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Escape);
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Enter);

            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(40, 96);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(104, 32);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.toolTip_buscar.SetToolTip(this.btn_buscar, "Enter");
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            this.btn_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Escape);
            // 
            // txt_cliente
            // 
            this.txt_cliente.Enabled = false;
            this.txt_cliente.Location = new System.Drawing.Point(408, 40);
            this.txt_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(115, 20);
            this.txt_cliente.TabIndex = 3;
            this.txt_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Enter);
            this.txt_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Escape);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CLIENTE";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(40, 160);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(104, 32);
            this.btn_limpiar.TabIndex = 6;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            this.btn_limpiar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Escape);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(416, 160);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(104, 32);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "Salir";
            this.toolTip_buscar.SetToolTip(this.btn_salir, "Salir (Esc)");
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            this.btn_salir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Escape);
            // 
            // check_clientes
            // 
            this.check_clientes.AutoSize = true;
            this.check_clientes.Location = new System.Drawing.Point(168, 104);
            this.check_clientes.Name = "check_clientes";
            this.check_clientes.Size = new System.Drawing.Size(172, 17);
            this.check_clientes.TabIndex = 8;
            this.check_clientes.Text = "Buscar solo Clientes del Banco";
            this.check_clientes.UseVisualStyleBackColor = true;
            this.check_clientes.CheckedChanged += new System.EventHandler(this.check_clientes_CheckedChanged);
            this.check_clientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Escape);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 224);
            this.Controls.Add(this.check_clientes);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_documento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador de Telefónos";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_documento;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.CheckBox check_clientes;
        private System.Windows.Forms.ToolTip toolTip_buscar;
    }
}

