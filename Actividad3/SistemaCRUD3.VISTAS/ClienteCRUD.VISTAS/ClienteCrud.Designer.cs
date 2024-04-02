namespace SistemaCRUD3.VISTAS.ClienteCRUD.VISTAS
{
    partial class ClienteCrud
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
            Agregar_btn = new Button();
            Editar_btn = new Button();
            Eliminar_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(519, 294);
            dataGridView1.TabIndex = 0;
            // 
            // Agregar_btn
            // 
            Agregar_btn.Location = new Point(61, 336);
            Agregar_btn.Name = "Agregar_btn";
            Agregar_btn.Size = new Size(81, 27);
            Agregar_btn.TabIndex = 1;
            Agregar_btn.Text = "Agregar";
            Agregar_btn.UseVisualStyleBackColor = true;
            Agregar_btn.Click += Agregar_btn_Click;
            // 
            // Editar_btn
            // 
            Editar_btn.Location = new Point(223, 336);
            Editar_btn.Name = "Editar_btn";
            Editar_btn.Size = new Size(81, 27);
            Editar_btn.TabIndex = 2;
            Editar_btn.Text = "Editar";
            Editar_btn.UseVisualStyleBackColor = true;
            Editar_btn.Click += Editar_btn_Click;
            // 
            // Eliminar_btn
            // 
            Eliminar_btn.Location = new Point(394, 336);
            Eliminar_btn.Name = "Eliminar_btn";
            Eliminar_btn.Size = new Size(81, 27);
            Eliminar_btn.TabIndex = 3;
            Eliminar_btn.Text = "Eliminar";
            Eliminar_btn.UseVisualStyleBackColor = true;
            Eliminar_btn.Click += Eliminar_btn_Click;
            // 
            // ClienteCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 406);
            Controls.Add(Eliminar_btn);
            Controls.Add(Editar_btn);
            Controls.Add(Agregar_btn);
            Controls.Add(dataGridView1);
            Name = "ClienteCrud";
            Text = "ClienteCrud";
            Load += ClienteCrud_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Agregar_btn;
        private Button Editar_btn;
        private Button Eliminar_btn;
    }
}