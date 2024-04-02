namespace SistemaCRUD3.VISTAS.ClienteCRUD.VISTAS
{
    partial class PedidosCrud
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
            dataGridView1 = new DataGridView();
            Insertar_btn = new Button();
            Editar_btn = new Button();
            Eliminar_btn = new Button();
            Calcular_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(510, 272);
            dataGridView1.TabIndex = 0;
            // 
            // Insertar_btn
            // 
            Insertar_btn.Location = new Point(552, 36);
            Insertar_btn.Name = "Insertar_btn";
            Insertar_btn.Size = new Size(134, 36);
            Insertar_btn.TabIndex = 1;
            Insertar_btn.Text = "Insertar";
            Insertar_btn.UseVisualStyleBackColor = true;
            // 
            // Editar_btn
            // 
            Editar_btn.Location = new Point(552, 110);
            Editar_btn.Name = "Editar_btn";
            Editar_btn.Size = new Size(134, 36);
            Editar_btn.TabIndex = 2;
            Editar_btn.Text = "Editar";
            Editar_btn.UseVisualStyleBackColor = true;
            // 
            // Eliminar_btn
            // 
            Eliminar_btn.Location = new Point(552, 194);
            Eliminar_btn.Name = "Eliminar_btn";
            Eliminar_btn.Size = new Size(134, 36);
            Eliminar_btn.TabIndex = 3;
            Eliminar_btn.Text = "Eliminar";
            Eliminar_btn.UseVisualStyleBackColor = true;
            // 
            // Calcular_btn
            // 
            Calcular_btn.Location = new Point(552, 272);
            Calcular_btn.Name = "Calcular_btn";
            Calcular_btn.Size = new Size(134, 36);
            Calcular_btn.TabIndex = 4;
            Calcular_btn.Text = "Calcular Pedido";
            Calcular_btn.UseVisualStyleBackColor = true;
            // 
            // PedidosCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 358);
            Controls.Add(Calcular_btn);
            Controls.Add(Eliminar_btn);
            Controls.Add(Editar_btn);
            Controls.Add(Insertar_btn);
            Controls.Add(dataGridView1);
            Name = "PedidosCrud";
            Text = "PedidosCrud";
            Load += PedidosCrud_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Insertar_btn;
        private Button Editar_btn;
        private Button Eliminar_btn;
        private Button Calcular_btn;
    }
}