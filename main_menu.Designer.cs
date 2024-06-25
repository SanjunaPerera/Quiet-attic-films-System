namespace Quiet_attic_films_GUI
{
    partial class main_menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_client = new System.Windows.Forms.Button();
            this.bt_pyt = new System.Windows.Forms.Button();
            this.bt_prodct = new System.Windows.Forms.Button();
            this.bt_property = new System.Windows.Forms.Button();
            this.bt_location = new System.Windows.Forms.Button();
            this.bt_staff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // bt_client
            // 
            this.bt_client.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_client.Location = new System.Drawing.Point(156, 85);
            this.bt_client.Name = "bt_client";
            this.bt_client.Size = new System.Drawing.Size(146, 56);
            this.bt_client.TabIndex = 1;
            this.bt_client.Text = "Client";
            this.bt_client.UseVisualStyleBackColor = true;
            this.bt_client.Click += new System.EventHandler(this.bt_client_Click);
            // 
            // bt_pyt
            // 
            this.bt_pyt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pyt.Location = new System.Drawing.Point(156, 172);
            this.bt_pyt.Name = "bt_pyt";
            this.bt_pyt.Size = new System.Drawing.Size(146, 56);
            this.bt_pyt.TabIndex = 2;
            this.bt_pyt.Text = "Payment";
            this.bt_pyt.UseVisualStyleBackColor = true;
            // 
            // bt_prodct
            // 
            this.bt_prodct.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_prodct.Location = new System.Drawing.Point(156, 259);
            this.bt_prodct.Name = "bt_prodct";
            this.bt_prodct.Size = new System.Drawing.Size(146, 56);
            this.bt_prodct.TabIndex = 3;
            this.bt_prodct.Text = "Production";
            this.bt_prodct.UseVisualStyleBackColor = true;
            // 
            // bt_property
            // 
            this.bt_property.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_property.Location = new System.Drawing.Point(156, 347);
            this.bt_property.Name = "bt_property";
            this.bt_property.Size = new System.Drawing.Size(146, 56);
            this.bt_property.TabIndex = 4;
            this.bt_property.Text = "Property";
            this.bt_property.UseVisualStyleBackColor = true;
            // 
            // bt_location
            // 
            this.bt_location.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_location.Location = new System.Drawing.Point(156, 437);
            this.bt_location.Name = "bt_location";
            this.bt_location.Size = new System.Drawing.Size(146, 56);
            this.bt_location.TabIndex = 5;
            this.bt_location.Text = "Location";
            this.bt_location.UseVisualStyleBackColor = true;
            // 
            // bt_staff
            // 
            this.bt_staff.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_staff.Location = new System.Drawing.Point(156, 532);
            this.bt_staff.Name = "bt_staff";
            this.bt_staff.Size = new System.Drawing.Size(146, 56);
            this.bt_staff.TabIndex = 6;
            this.bt_staff.Text = "Staff";
            this.bt_staff.UseVisualStyleBackColor = true;
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 626);
            this.Controls.Add(this.bt_staff);
            this.Controls.Add(this.bt_location);
            this.Controls.Add(this.bt_property);
            this.Controls.Add(this.bt_prodct);
            this.Controls.Add(this.bt_pyt);
            this.Controls.Add(this.bt_client);
            this.Controls.Add(this.label1);
            this.Name = "main_menu";
            this.Text = "main_menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_client;
        private System.Windows.Forms.Button bt_pyt;
        private System.Windows.Forms.Button bt_prodct;
        private System.Windows.Forms.Button bt_property;
        private System.Windows.Forms.Button bt_location;
        private System.Windows.Forms.Button bt_staff;
    }
}