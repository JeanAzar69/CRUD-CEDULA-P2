namespace WinFormsIDs
{
    partial class Main
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
            this.gridData = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BarraEstetica = new System.Windows.Forms.Panel();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarNacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sangreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estCivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaExpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridData
            // 
            this.gridData.AutoGenerateColumns = false;
            this.gridData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(12)))));
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.lugarNacDataGridViewTextBoxColumn,
            this.fechaNacDataGridViewTextBoxColumn,
            this.nacDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.sangreDataGridViewTextBoxColumn,
            this.estCivDataGridViewTextBoxColumn,
            this.ocupDataGridViewTextBoxColumn,
            this.fechaExpDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn});
            this.gridData.DataSource = this.contactBindingSource;
            this.gridData.Location = new System.Drawing.Point(18, 85);
            this.gridData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersWidth = 62;
            this.gridData.Size = new System.Drawing.Size(1164, 565);
            this.gridData.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.Location = new System.Drawing.Point(18, 31);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(921, 19);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(241)))), ((int)(((byte)(210)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Apercu Pro", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(948, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 60);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Apercu Pro", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1070, 15);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 60);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = " Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BarraEstetica
            // 
            this.BarraEstetica.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarraEstetica.Location = new System.Drawing.Point(18, 60);
            this.BarraEstetica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BarraEstetica.Name = "BarraEstetica";
            this.BarraEstetica.Size = new System.Drawing.Size(921, 3);
            this.BarraEstetica.TabIndex = 5;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(WinFormsIDs.Contact);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lugarNacDataGridViewTextBoxColumn
            // 
            this.lugarNacDataGridViewTextBoxColumn.DataPropertyName = "LugarNac";
            this.lugarNacDataGridViewTextBoxColumn.HeaderText = "LugarNac";
            this.lugarNacDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lugarNacDataGridViewTextBoxColumn.Name = "lugarNacDataGridViewTextBoxColumn";
            this.lugarNacDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaNacDataGridViewTextBoxColumn
            // 
            this.fechaNacDataGridViewTextBoxColumn.DataPropertyName = "FechaNac";
            this.fechaNacDataGridViewTextBoxColumn.HeaderText = "FechaNac";
            this.fechaNacDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaNacDataGridViewTextBoxColumn.Name = "fechaNacDataGridViewTextBoxColumn";
            this.fechaNacDataGridViewTextBoxColumn.Width = 150;
            // 
            // nacDataGridViewTextBoxColumn
            // 
            this.nacDataGridViewTextBoxColumn.DataPropertyName = "Nac";
            this.nacDataGridViewTextBoxColumn.HeaderText = "Nac";
            this.nacDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nacDataGridViewTextBoxColumn.Name = "nacDataGridViewTextBoxColumn";
            this.nacDataGridViewTextBoxColumn.Width = 150;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.Width = 150;
            // 
            // sangreDataGridViewTextBoxColumn
            // 
            this.sangreDataGridViewTextBoxColumn.DataPropertyName = "Sangre";
            this.sangreDataGridViewTextBoxColumn.HeaderText = "Sangre";
            this.sangreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sangreDataGridViewTextBoxColumn.Name = "sangreDataGridViewTextBoxColumn";
            this.sangreDataGridViewTextBoxColumn.Width = 150;
            // 
            // estCivDataGridViewTextBoxColumn
            // 
            this.estCivDataGridViewTextBoxColumn.DataPropertyName = "EstCiv";
            this.estCivDataGridViewTextBoxColumn.HeaderText = "EstCiv";
            this.estCivDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.estCivDataGridViewTextBoxColumn.Name = "estCivDataGridViewTextBoxColumn";
            this.estCivDataGridViewTextBoxColumn.Width = 150;
            // 
            // ocupDataGridViewTextBoxColumn
            // 
            this.ocupDataGridViewTextBoxColumn.DataPropertyName = "Ocup";
            this.ocupDataGridViewTextBoxColumn.HeaderText = "Ocup";
            this.ocupDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ocupDataGridViewTextBoxColumn.Name = "ocupDataGridViewTextBoxColumn";
            this.ocupDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaExpDataGridViewTextBoxColumn
            // 
            this.fechaExpDataGridViewTextBoxColumn.DataPropertyName = "FechaExp";
            this.fechaExpDataGridViewTextBoxColumn.HeaderText = "FechaExp";
            this.fechaExpDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaExpDataGridViewTextBoxColumn.Name = "fechaExpDataGridViewTextBoxColumn";
            this.fechaExpDataGridViewTextBoxColumn.Width = 150;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.Width = 150;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1198, 692);
            this.Controls.Add(this.BarraEstetica);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gridData);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "IDs Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel BarraEstetica;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarNacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sangreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estCivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaExpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contactBindingSource;
    }
}

