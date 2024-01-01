namespace CarRentalSystem
{
    partial class ManageVehicleListing
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
            this.dgManageVehicleListing = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgManageVehicleListing)).BeginInit();
            this.SuspendLayout();
            // 
            // dgManageVehicleListing
            // 
            this.dgManageVehicleListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgManageVehicleListing.Location = new System.Drawing.Point(33, 164);
            this.dgManageVehicleListing.Name = "dgManageVehicleListing";
            this.dgManageVehicleListing.Size = new System.Drawing.Size(729, 252);
            this.dgManageVehicleListing.TabIndex = 0;
            this.dgManageVehicleListing.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCarrentalViewer_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car Rental Viewer";
            // 
            // ManageVehicleListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgManageVehicleListing);
            this.Name = "ManageVehicleListing";
            this.Text = "Car Rental Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.dgManageVehicleListing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgManageVehicleListing;
        private System.Windows.Forms.Label label1;
    }
}