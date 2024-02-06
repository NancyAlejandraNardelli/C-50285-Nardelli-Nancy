namespace C_50285_Nardelli_Nancy
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
            dgvUser = new DataGridView();
            btnListar = new Button();
            txtId = new TextBox();
            label1 = new Label();
            btnAgregar = new Button();
            btnBorrar = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(115, 71);
            dgvUser.Name = "dgvUser";
            dgvUser.RowTemplate.Height = 25;
            dgvUser.Size = new Size(466, 221);
            dgvUser.TabIndex = 0;
            dgvUser.CellClick += dgvUser_CellClick;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(489, 39);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(92, 27);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(182, 42);
            txtId.Name = "txtId";
            txtId.Size = new Size(128, 23);
            txtId.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 45);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(293, 298);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(92, 27);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Nuevo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(489, 298);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(92, 27);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(391, 298);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(92, 27);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 450);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(btnBorrar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(btnListar);
            Controls.Add(dgvUser);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUser;
        private Button btnListar;
        private TextBox txtId;
        private Label label1;
        private Button btnAgregar;
        private Button btnBorrar;
        private Button btnEditar;
    }
}