namespace CarRentalProject
{
    partial class OrderForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carRentalDBDataSet = new CarRentalProject.CarRentalDBDataSet();
            this.orderTableAdapter = new CarRentalProject.CarRentalDBDataSetTableAdapters.OrderTableAdapter();
            this.lblDate = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.tbClientId = new System.Windows.Forms.TextBox();
            this.lblCar = new System.Windows.Forms.Label();
            this.tbCarId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(577, 419);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.carRentalDBDataSet;
            // 
            // carRentalDBDataSet
            // 
            this.carRentalDBDataSet.DataSetName = "CarRentalDBDataSet";
            this.carRentalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(634, 52);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Дата";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(700, 47);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(100, 22);
            this.tbDate.TabIndex = 2;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(621, 105);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(71, 17);
            this.lblClient.TabIndex = 3;
            this.lblClient.Text = "Id клієнта";
            // 
            // tbClientId
            // 
            this.tbClientId.Location = new System.Drawing.Point(700, 102);
            this.tbClientId.Name = "tbClientId";
            this.tbClientId.Size = new System.Drawing.Size(100, 22);
            this.tbClientId.TabIndex = 4;
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(595, 151);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(97, 17);
            this.lblCar.TabIndex = 5;
            this.lblCar.Text = "Id автомобіля";
            // 
            // tbCarId
            // 
            this.tbCarId.Location = new System.Drawing.Point(700, 151);
            this.tbCarId.Name = "tbCarId";
            this.tbCarId.Size = new System.Drawing.Size(100, 22);
            this.tbCarId.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(723, 216);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(88, 33);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(723, 268);
            this.btnDel.Name = "btnDel";
            this.btnDel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDel.Size = new System.Drawing.Size(88, 33);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Видалити";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(620, 268);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdate.Size = new System.Drawing.Size(88, 33);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Оновити";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(620, 216);
            this.btnShow.Name = "btnShow";
            this.btnShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShow.Size = new System.Drawing.Size(88, 33);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Відобразити";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(833, 496);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbCarId);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.tbClientId);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CarRentalDBDataSet carRentalDBDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private CarRentalDBDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idЗамовленняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idКлієнтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idАвтомобіляDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox tbClientId;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.TextBox tbCarId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnShow;
    }
}