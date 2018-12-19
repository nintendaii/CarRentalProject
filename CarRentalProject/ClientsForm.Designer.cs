namespace CarRentalProject
{
    partial class ClientsForm
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
            this.carRentalDBDataSet = new CarRentalProject.CarRentalDBDataSet();
            this.clientsTableAdapter = new CarRentalProject.CarRentalDBDataSetTableAdapters.ClientsTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPasp = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPasp = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carRentalDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // carRentalDBDataSet
            // 
            this.carRentalDBDataSet.DataSetName = "CarRentalDBDataSet";
            this.carRentalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(563, 183);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(502, 50);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(178, 22);
            this.tbName.TabIndex = 2;
            // 
            // tbPasp
            // 
            this.tbPasp.Location = new System.Drawing.Point(502, 98);
            this.tbPasp.Name = "tbPasp";
            this.tbPasp.Size = new System.Drawing.Size(178, 22);
            this.tbPasp.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(432, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(30, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "ПІБ";
            // 
            // lblPasp
            // 
            this.lblPasp.AutoSize = true;
            this.lblPasp.Location = new System.Drawing.Point(390, 101);
            this.lblPasp.Name = "lblPasp";
            this.lblPasp.Size = new System.Drawing.Size(106, 17);
            this.lblPasp.TabIndex = 5;
            this.lblPasp.Text = "Паспортні дані";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(353, 374);
            this.dataGridView1.TabIndex = 6;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.carRentalDBDataSet;
            // 
            // carRentalDBDataSetBindingSource
            // 
            this.carRentalDBDataSetBindingSource.DataSource = this.carRentalDBDataSet;
            this.carRentalDBDataSetBindingSource.Position = 0;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(424, 183);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(117, 33);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Відобразити";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(563, 237);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(117, 33);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Видалити";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(424, 237);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 33);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Оновити";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPasp);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbPasp);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnAdd);
            this.Name = "ClientsForm";
            this.Text = "ClientsForm";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CarRentalDBDataSet carRentalDBDataSet;
        private CarRentalDBDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPasp;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPasp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idКлієнтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортніДаніDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carRentalDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
    }
}