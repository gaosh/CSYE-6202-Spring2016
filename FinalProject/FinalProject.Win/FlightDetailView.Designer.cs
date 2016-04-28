namespace FinalProject.Win
{
    partial class FlightDetailView
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
            this.btn_carrier = new System.Windows.Forms.Button();
            this.btn_crew = new System.Windows.Forms.Button();
            this.btn_booked = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_carrier
            // 
            this.btn_carrier.Location = new System.Drawing.Point(67, 325);
            this.btn_carrier.Name = "btn_carrier";
            this.btn_carrier.Size = new System.Drawing.Size(123, 49);
            this.btn_carrier.TabIndex = 2;
            this.btn_carrier.Text = "Carrier Info";
            this.btn_carrier.UseVisualStyleBackColor = true;
            this.btn_carrier.Click += new System.EventHandler(this.btn_carrier_Click);
            // 
            // btn_crew
            // 
            this.btn_crew.Location = new System.Drawing.Point(286, 325);
            this.btn_crew.Name = "btn_crew";
            this.btn_crew.Size = new System.Drawing.Size(123, 49);
            this.btn_crew.TabIndex = 3;
            this.btn_crew.Text = "Crew Info";
            this.btn_crew.UseVisualStyleBackColor = true;
            this.btn_crew.Click += new System.EventHandler(this.btn_crew_Click);
            // 
            // btn_booked
            // 
            this.btn_booked.Location = new System.Drawing.Point(502, 325);
            this.btn_booked.Name = "btn_booked";
            this.btn_booked.Size = new System.Drawing.Size(123, 49);
            this.btn_booked.TabIndex = 4;
            this.btn_booked.Text = "Booked Info";
            this.btn_booked.UseVisualStyleBackColor = true;
            this.btn_booked.Click += new System.EventHandler(this.btn_booked_Click);
            // 
            // Display
            // 
            this.Display.AutoSize = true;
            this.Display.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Display.Location = new System.Drawing.Point(65, 74);
            this.Display.MaximumSize = new System.Drawing.Size(500, 0);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(189, 19);
            this.Display.TabIndex = 5;
            this.Display.Text = "Welcome, Customer!";
            // 
            // FlightDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 406);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.btn_booked);
            this.Controls.Add(this.btn_crew);
            this.Controls.Add(this.btn_carrier);
            this.Name = "FlightDetailView";
            this.Text = "FlightDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_carrier;
        private System.Windows.Forms.Button btn_crew;
        private System.Windows.Forms.Button btn_booked;
        private System.Windows.Forms.Label Display;
    }
}