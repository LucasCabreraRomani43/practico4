namespace practico4
{
    partial class lista
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
            Lhasta = new Label();
            Llista = new Label();
            Ldesde = new Label();
            Tdesde = new TextBox();
            Thasta = new TextBox();
            listanum = new ListBox();
            Bgenerar = new Button();
            Bpares = new Button();
            Bimpar = new Button();
            Bprimos = new Button();
            SuspendLayout();
            // 
            // Lhasta
            // 
            Lhasta.AutoSize = true;
            Lhasta.Location = new Point(80, 165);
            Lhasta.Name = "Lhasta";
            Lhasta.Size = new Size(37, 15);
            Lhasta.TabIndex = 0;
            Lhasta.Text = "Hasta";
            // 
            // Llista
            // 
            Llista.AutoSize = true;
            Llista.Location = new Point(576, 57);
            Llista.Name = "Llista";
            Llista.Size = new Size(99, 15);
            Llista.TabIndex = 2;
            Llista.Text = "Lista de Numeros";
            // 
            // Ldesde
            // 
            Ldesde.AutoSize = true;
            Ldesde.Location = new Point(79, 105);
            Ldesde.Name = "Ldesde";
            Ldesde.Size = new Size(39, 15);
            Ldesde.TabIndex = 3;
            Ldesde.Text = "Desde";
            // 
            // Tdesde
            // 
            Tdesde.Location = new Point(139, 97);
            Tdesde.Name = "Tdesde";
            Tdesde.Size = new Size(204, 23);
            Tdesde.TabIndex = 4;
            Tdesde.KeyPress += textBox1_KeyPress;
            // 
            // Thasta
            // 
            Thasta.Location = new Point(139, 157);
            Thasta.Name = "Thasta";
            Thasta.Size = new Size(204, 23);
            Thasta.TabIndex = 5;
            Thasta.KeyPress += textBox2_KeyPress;
            // 
            // listanum
            // 
            listanum.FormattingEnabled = true;
            listanum.ItemHeight = 15;
            listanum.Location = new Point(489, 86);
            listanum.Name = "listanum";
            listanum.Size = new Size(270, 229);
            listanum.TabIndex = 6;
            // 
            // Bgenerar
            // 
            Bgenerar.Location = new Point(139, 204);
            Bgenerar.Name = "Bgenerar";
            Bgenerar.Size = new Size(118, 23);
            Bgenerar.TabIndex = 7;
            Bgenerar.Text = "Generar Funcion";
            Bgenerar.UseVisualStyleBackColor = true;
            Bgenerar.Click += Bgenerar_Click;
            // 
            // Bpares
            // 
            Bpares.Location = new Point(139, 233);
            Bpares.Name = "Bpares";
            Bpares.Size = new Size(118, 23);
            Bpares.TabIndex = 8;
            Bpares.Text = "Funcion pares";
            Bpares.UseVisualStyleBackColor = true;
            Bpares.Click += Bpares_Click;
            // 
            // Bimpar
            // 
            Bimpar.Location = new Point(139, 262);
            Bimpar.Name = "Bimpar";
            Bimpar.Size = new Size(118, 23);
            Bimpar.TabIndex = 9;
            Bimpar.Text = "Funcion Impar";
            Bimpar.UseVisualStyleBackColor = true;
            Bimpar.Click += Bimpar_Click;
            // 
            // Bprimos
            // 
            Bprimos.Location = new Point(139, 291);
            Bprimos.Name = "Bprimos";
            Bprimos.Size = new Size(118, 23);
            Bprimos.TabIndex = 10;
            Bprimos.Text = "Funcion Primos";
            Bprimos.UseVisualStyleBackColor = true;
            Bprimos.Click += Bprimos_Click;
            // 
            // lista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 505);
            Controls.Add(Bprimos);
            Controls.Add(Bimpar);
            Controls.Add(Bpares);
            Controls.Add(Bgenerar);
            Controls.Add(listanum);
            Controls.Add(Thasta);
            Controls.Add(Tdesde);
            Controls.Add(Ldesde);
            Controls.Add(Llista);
            Controls.Add(Lhasta);
            Name = "lista";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lhasta;
        private Label Llista;
        private Label Ldesde;
        private TextBox Tdesde;
        private TextBox Thasta;
        private ListBox listanum;
        private Button Bgenerar;
        private Button Bpares;
        private Button Bimpar;
        private Button Bprimos;
        private OxyPlot.WindowsForms.PlotView plotView1;
    }
}
