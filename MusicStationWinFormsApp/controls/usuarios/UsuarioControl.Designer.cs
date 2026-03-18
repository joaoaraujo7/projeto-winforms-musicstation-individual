namespace MusicStationWinFormsApp.controls.usuarios
{
    partial class UsuarioControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btnFechar = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.Location = new Point(673, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(68, 23);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(275, 45);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar usuarios...";
            textBox1.Size = new Size(361, 23);
            textBox1.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(642, 46);
            button2.Name = "button2";
            button2.Size = new Size(68, 23);
            button2.TabIndex = 7;
            button2.Text = "Pesquisar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(33, 45);
            button1.Name = "button1";
            button1.Size = new Size(178, 23);
            button1.TabIndex = 6;
            button1.Text = "Adicionar Usuário";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(677, 325);
            dataGridView1.TabIndex = 5;
            // 
            // UserControlCustom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnFechar);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "UserControlCustom";
            Size = new Size(744, 511);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFechar;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
    }
}
