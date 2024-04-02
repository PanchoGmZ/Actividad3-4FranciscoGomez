namespace SistemaCRUD3.VISTAS.ClienteCRUD.VISTAS
{
    partial class AgregarPedidoVISTAS
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            Seleccionar_btn = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 41);
            label1.Name = "label1";
            label1.Size = new Size(91, 18);
            label1.TabIndex = 0;
            label1.Text = "ID Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 99);
            label2.Name = "label2";
            label2.Size = new Size(55, 18);
            label2.TabIndex = 1;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 156);
            label3.Name = "label3";
            label3.Size = new Size(48, 18);
            label3.TabIndex = 2;
            label3.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(26, 209);
            label4.Name = "label4";
            label4.Size = new Size(64, 18);
            label4.TabIndex = 3;
            label4.Text = "Estado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(123, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(270, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(123, 204);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(270, 23);
            textBox4.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(122, 96);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(271, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // Seleccionar_btn
            // 
            Seleccionar_btn.Location = new Point(404, 35);
            Seleccionar_btn.Name = "Seleccionar_btn";
            Seleccionar_btn.Size = new Size(123, 24);
            Seleccionar_btn.TabIndex = 9;
            Seleccionar_btn.Text = "Seleccionar";
            Seleccionar_btn.UseVisualStyleBackColor = true;
            Seleccionar_btn.Click += Seleccionar_btn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(204, 248);
            button2.Name = "button2";
            button2.Size = new Size(123, 24);
            button2.TabIndex = 10;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AgregarPedidoVISTAS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 294);
            Controls.Add(button2);
            Controls.Add(Seleccionar_btn);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarPedidoVISTAS";
            Text = "AgregarPedidoVISTAS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Button Seleccionar_btn;
        private Button button2;
    }
}