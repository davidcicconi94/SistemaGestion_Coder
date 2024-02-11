namespace SistemaGestionUI
{
    partial class newUserBtn
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
            groupBox1 = new GroupBox();
            cleanBtn = new Button();
            nuevoBtn = new Button();
            borrarBtn = new Button();
            searchUserBtn = new Button();
            passUserBox = new TextBox();
            usernameUserBox = new TextBox();
            lastnameUserBox = new TextBox();
            nameUserBox = new TextBox();
            idUserBox = new TextBox();
            passUserLabel = new Label();
            usernameUsuarioLabel = new Label();
            lastnameUserLabel = new Label();
            nameUsuarioLabel = new Label();
            idUsuarioLabel = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox2 = new GroupBox();
            dataGridListUsers = new DataGridView();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridListUsers).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cleanBtn);
            groupBox1.Controls.Add(nuevoBtn);
            groupBox1.Controls.Add(borrarBtn);
            groupBox1.Controls.Add(searchUserBtn);
            groupBox1.Controls.Add(passUserBox);
            groupBox1.Controls.Add(usernameUserBox);
            groupBox1.Controls.Add(lastnameUserBox);
            groupBox1.Controls.Add(nameUserBox);
            groupBox1.Controls.Add(idUserBox);
            groupBox1.Controls.Add(passUserLabel);
            groupBox1.Controls.Add(usernameUsuarioLabel);
            groupBox1.Controls.Add(lastnameUserLabel);
            groupBox1.Controls.Add(nameUsuarioLabel);
            groupBox1.Controls.Add(idUsuarioLabel);
            groupBox1.Location = new Point(46, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(616, 261);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Usuario";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cleanBtn
            // 
            cleanBtn.Location = new Point(439, 201);
            cleanBtn.Name = "cleanBtn";
            cleanBtn.Size = new Size(85, 36);
            cleanBtn.TabIndex = 11;
            cleanBtn.Text = "Limpiar";
            cleanBtn.UseVisualStyleBackColor = true;
            cleanBtn.Click += button2_Click;
            // 
            // nuevoBtn
            // 
            nuevoBtn.Location = new Point(343, 201);
            nuevoBtn.Name = "nuevoBtn";
            nuevoBtn.Size = new Size(85, 36);
            nuevoBtn.TabIndex = 10;
            nuevoBtn.Text = "Crear";
            nuevoBtn.UseVisualStyleBackColor = true;
            // 
            // borrarBtn
            // 
            borrarBtn.Location = new Point(128, 201);
            borrarBtn.Name = "borrarBtn";
            borrarBtn.Size = new Size(85, 36);
            borrarBtn.TabIndex = 9;
            borrarBtn.Text = "Borrar";
            borrarBtn.UseVisualStyleBackColor = true;
            borrarBtn.Click += button1_Click_1;
            // 
            // searchUserBtn
            // 
            searchUserBtn.Location = new Point(26, 201);
            searchUserBtn.Name = "searchUserBtn";
            searchUserBtn.Size = new Size(85, 36);
            searchUserBtn.TabIndex = 1;
            searchUserBtn.Text = "Buscar";
            searchUserBtn.UseVisualStyleBackColor = true;
            searchUserBtn.Click += button1_Click;
            // 
            // passUserBox
            // 
            passUserBox.Location = new Point(439, 84);
            passUserBox.Name = "passUserBox";
            passUserBox.ReadOnly = true;
            passUserBox.Size = new Size(140, 27);
            passUserBox.TabIndex = 8;
            passUserBox.TextChanged += textBox5_TextChanged;
            // 
            // usernameUserBox
            // 
            usernameUserBox.Location = new Point(411, 34);
            usernameUserBox.Name = "usernameUserBox";
            usernameUserBox.ReadOnly = true;
            usernameUserBox.Size = new Size(140, 27);
            usernameUserBox.TabIndex = 7;
            // 
            // lastnameUserBox
            // 
            lastnameUserBox.Location = new Point(88, 139);
            lastnameUserBox.Name = "lastnameUserBox";
            lastnameUserBox.ReadOnly = true;
            lastnameUserBox.Size = new Size(140, 27);
            lastnameUserBox.TabIndex = 6;
            // 
            // nameUserBox
            // 
            nameUserBox.Location = new Point(88, 84);
            nameUserBox.Name = "nameUserBox";
            nameUserBox.ReadOnly = true;
            nameUserBox.Size = new Size(140, 27);
            nameUserBox.TabIndex = 5;
            nameUserBox.TextChanged += textBox2_TextChanged;
            // 
            // idUserBox
            // 
            idUserBox.Location = new Point(104, 34);
            idUserBox.Name = "idUserBox";
            idUserBox.Size = new Size(41, 27);
            idUserBox.TabIndex = 1;
            // 
            // passUserLabel
            // 
            passUserLabel.AutoSize = true;
            passUserLabel.Location = new Point(343, 87);
            passUserLabel.Name = "passUserLabel";
            passUserLabel.Size = new Size(90, 20);
            passUserLabel.TabIndex = 4;
            passUserLabel.Text = "Contraseña: ";
            passUserLabel.Click += label1_Click_1;
            // 
            // usernameUsuarioLabel
            // 
            usernameUsuarioLabel.AutoSize = true;
            usernameUsuarioLabel.Location = new Point(343, 37);
            usernameUsuarioLabel.Name = "usernameUsuarioLabel";
            usernameUsuarioLabel.Size = new Size(62, 20);
            usernameUsuarioLabel.TabIndex = 3;
            usernameUsuarioLabel.Text = "Usuario:";
            usernameUsuarioLabel.Click += label4_Click;
            // 
            // lastnameUserLabel
            // 
            lastnameUserLabel.AutoSize = true;
            lastnameUserLabel.Location = new Point(15, 139);
            lastnameUserLabel.Name = "lastnameUserLabel";
            lastnameUserLabel.Size = new Size(69, 20);
            lastnameUserLabel.TabIndex = 2;
            lastnameUserLabel.Text = "Apellido:";
            // 
            // nameUsuarioLabel
            // 
            nameUsuarioLabel.AutoSize = true;
            nameUsuarioLabel.Location = new Point(15, 87);
            nameUsuarioLabel.Name = "nameUsuarioLabel";
            nameUsuarioLabel.Size = new Size(67, 20);
            nameUsuarioLabel.TabIndex = 1;
            nameUsuarioLabel.Text = "Nombre:";
            nameUsuarioLabel.Click += label2_Click;
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new Point(15, 37);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new Size(83, 20);
            idUsuarioLabel.TabIndex = 0;
            idUsuarioLabel.Text = "Id Usuario: ";
            idUsuarioLabel.Click += label1_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridListUsers);
            groupBox2.Location = new Point(46, 319);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1334, 369);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de Usuarios";
            // 
            // dataGridListUsers
            // 
            dataGridListUsers.AllowUserToAddRows = false;
            dataGridListUsers.AllowUserToDeleteRows = false;
            dataGridListUsers.AllowUserToOrderColumns = true;
            dataGridListUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridListUsers.Dock = DockStyle.Fill;
            dataGridListUsers.Location = new Point(3, 23);
            dataGridListUsers.Name = "dataGridListUsers";
            dataGridListUsers.ReadOnly = true;
            dataGridListUsers.RowHeadersWidth = 51;
            dataGridListUsers.RowTemplate.Height = 29;
            dataGridListUsers.Size = new Size(1328, 343);
            dataGridListUsers.TabIndex = 0;
            dataGridListUsers.CellContentClick += dataGridView1_CellContentClick;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(710, 36);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(644, 264);
            listBox1.TabIndex = 2;
            // 
            // newUserBtn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 700);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "newUserBtn";
            Text = "Sistema Gestión";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridListUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label usernameUsuarioLabel;
        private Label lastnameUserLabel;
        private Label nameUsuarioLabel;
        private Label idUsuarioLabel;
        private Label passUserLabel;
        private TextBox passUserBox;
        private TextBox usernameUserBox;
        private TextBox lastnameUserBox;
        private TextBox nameUserBox;
        private TextBox idUserBox;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button searchUserBtn;
        private GroupBox groupBox2;
        private DataGridView dataGridListUsers;
        private ListBox listBox1;
        private Button borrarBtn;
        private Button cleanBtn;
        private Button nuevoBtn;
    }
}
