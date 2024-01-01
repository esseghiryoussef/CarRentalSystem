namespace CarRentalSystem
{
    partial class AddCarRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCarRecordForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.rentedDate = new System.Windows.Forms.DateTimePicker();
            this.returnedDate = new System.Windows.Forms.DateTimePicker();
            this.typeOfCar = new System.Windows.Forms.ComboBox();
            this.ctCost = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(23, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(23, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type of Car";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(23, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date Returned";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(23, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date Rented";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(229, 71);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(175, 20);
            this.tbCustomerName.TabIndex = 8;
            // 
            // rentedDate
            // 
            this.rentedDate.Location = new System.Drawing.Point(229, 110);
            this.rentedDate.Name = "rentedDate";
            this.rentedDate.Size = new System.Drawing.Size(175, 20);
            this.rentedDate.TabIndex = 9;
            // 
            // returnedDate
            // 
            this.returnedDate.Location = new System.Drawing.Point(229, 145);
            this.returnedDate.Name = "returnedDate";
            this.returnedDate.Size = new System.Drawing.Size(175, 20);
            this.returnedDate.TabIndex = 10;
            // 
            // typeOfCar
            // 
            this.typeOfCar.AutoCompleteCustomSource.AddRange(new string[] {
            "Toyota",
            "Mercedes",
            "Audi",
            "Nissan",
            "Ford",
            "Other"});
            this.typeOfCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfCar.FormattingEnabled = true;
            this.typeOfCar.Location = new System.Drawing.Point(229, 184);
            this.typeOfCar.Name = "typeOfCar";
            this.typeOfCar.Size = new System.Drawing.Size(175, 21);
            this.typeOfCar.TabIndex = 12;
            // 
            // ctCost
            // 
            this.ctCost.Location = new System.Drawing.Point(229, 226);
            this.ctCost.Name = "ctCost";
            this.ctCost.Size = new System.Drawing.Size(175, 20);
            this.ctCost.TabIndex = 14;
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Cost.Location = new System.Drawing.Point(23, 226);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(42, 20);
            this.Cost.TabIndex = 15;
            this.Cost.Text = "Cost";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 41);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add Rental Record";
            // 
            // AddCarRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.ctCost);
            this.Controls.Add(this.typeOfCar);
            this.Controls.Add(this.returnedDate);
            this.Controls.Add(this.rentedDate);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCarRecordForm";
            this.Text = "Add Rental Record";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.DateTimePicker rentedDate;
        private System.Windows.Forms.DateTimePicker returnedDate;
        private System.Windows.Forms.ComboBox typeOfCar;
        private System.Windows.Forms.TextBox ctCost;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

