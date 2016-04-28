using System.Windows.Forms;

namespace FinalProject.Win
{
    partial class AdministratorView
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
            this.FlightDataView = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_flightdetail = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FlightDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // FlightDataView
            // 
            this.FlightDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightDataView.Location = new System.Drawing.Point(11, 24);
            this.FlightDataView.Name = "FlightDataView";
            this.FlightDataView.RowTemplate.Height = 23;
            this.FlightDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FlightDataView.Size = new System.Drawing.Size(740, 307);
            this.FlightDataView.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(44, 363);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(118, 44);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add Flight";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 12);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(224, 363);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(118, 44);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_flightdetail
            // 
            this.btn_flightdetail.Location = new System.Drawing.Point(589, 363);
            this.btn_flightdetail.Name = "btn_flightdetail";
            this.btn_flightdetail.Size = new System.Drawing.Size(118, 44);
            this.btn_flightdetail.TabIndex = 4;
            this.btn_flightdetail.Text = "Flight Detail";
            this.btn_flightdetail.UseVisualStyleBackColor = true;
            this.btn_flightdetail.Click += new System.EventHandler(this.btn_flightdetail_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(408, 363);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(118, 44);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // AdministratorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 456);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_flightdetail);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.FlightDataView);
            this.Name = "AdministratorView";
            this.Text = "FlightView";
            ((System.ComponentModel.ISupportInitialize)(this.FlightDataView)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.DataGridView FlightDataView;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_flightdetail;
        private Button btn_delete;
    }
}