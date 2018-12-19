namespace CarRentalProject
{
    partial class MainForm
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
            this.btnClientsList = new System.Windows.Forms.Button();
            this.btnCarsList = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnOrdersList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientsList
            // 
            this.btnClientsList.Location = new System.Drawing.Point(177, 143);
            this.btnClientsList.Name = "btnClientsList";
            this.btnClientsList.Size = new System.Drawing.Size(222, 96);
            this.btnClientsList.TabIndex = 0;
            this.btnClientsList.Text = "Список клієнтів";
            this.btnClientsList.UseVisualStyleBackColor = true;
            this.btnClientsList.Click += new System.EventHandler(this.btnClientsList_Click);
            // 
            // btnCarsList
            // 
            this.btnCarsList.Location = new System.Drawing.Point(177, 263);
            this.btnCarsList.Name = "btnCarsList";
            this.btnCarsList.Size = new System.Drawing.Size(222, 96);
            this.btnCarsList.TabIndex = 1;
            this.btnCarsList.Text = "Список автомобілів";
            this.btnCarsList.UseVisualStyleBackColor = true;
            this.btnCarsList.Click += new System.EventHandler(this.btnCarsList_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(177, 379);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(222, 96);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(177, 32);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(104, 96);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Нове замовлення";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnOrdersList
            // 
            this.btnOrdersList.Location = new System.Drawing.Point(295, 32);
            this.btnOrdersList.Name = "btnOrdersList";
            this.btnOrdersList.Size = new System.Drawing.Size(104, 96);
            this.btnOrdersList.TabIndex = 4;
            this.btnOrdersList.Text = "Список замовлень";
            this.btnOrdersList.UseVisualStyleBackColor = true;
            this.btnOrdersList.Click += new System.EventHandler(this.btnOrdersList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(663, 521);
            this.Controls.Add(this.btnOrdersList);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCarsList);
            this.Controls.Add(this.btnClientsList);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientsList;
        private System.Windows.Forms.Button btnCarsList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnOrdersList;
    }
}