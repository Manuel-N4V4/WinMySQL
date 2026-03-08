namespace WinMySQL.Views
{
    partial class frmMaestro
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
            components = new System.ComponentModel.Container();
            mySqlDataAdapter1 = new MySqlConnector.MySqlDataAdapter();
            dgvMaestros = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            textBox1 = new TextBox();
            btnAgregar = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMaestros).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mySqlDataAdapter1
            // 
            mySqlDataAdapter1.DeleteCommand = null;
            mySqlDataAdapter1.InsertCommand = null;
            mySqlDataAdapter1.SelectCommand = null;
            mySqlDataAdapter1.UpdateBatchSize = 0;
            mySqlDataAdapter1.UpdateCommand = null;
            // 
            // dgvMaestros
            // 
            dgvMaestros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaestros.ContextMenuStrip = contextMenuStrip1;
            dgvMaestros.Location = new Point(12, 60);
            dgvMaestros.Name = "dgvMaestros";
            dgvMaestros.RowHeadersWidth = 51;
            dgvMaestros.Size = new Size(1429, 304);
            dgvMaestros.TabIndex = 0;
            dgvMaestros.CellContentClick += dgvMaestros_CellContentClick;
            dgvMaestros.CellContentDoubleClick += dgvMaestros_CellContentDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(133, 28);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            contextMenuStrip1.Click += eliminarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(132, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(634, 27);
            textBox1.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(746, 16);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 21);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 6;
            label2.Text = "Buscar";
            // 
            // frmMaestro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1444, 376);
            Controls.Add(label2);
            Controls.Add(btnAgregar);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dgvMaestros);
            Name = "frmMaestro";
            Text = "frmMaestro";
            Activated += frmMaestro_Activated;
            ((System.ComponentModel.ISupportInitialize)dgvMaestros).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter1;
        private DataGridView dgvMaestros;
        private Label label1;
        private TextBox textBox1;
        private Button btnAgregar;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private Label label2;
    }
}