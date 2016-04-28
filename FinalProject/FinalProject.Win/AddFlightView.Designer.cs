using System;
using System.Windows.Forms;

namespace FinalProject.Win
{
    partial class AddFlightView
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_FN = new System.Windows.Forms.TextBox();
            this.rtxt_carrierinfo = new System.Windows.Forms.RichTextBox();
            this.txt_arrival = new System.Windows.Forms.TextBox();
            this.txt_carrier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_eprice = new System.Windows.Forms.Label();
            this.txt_ep = new System.Windows.Forms.TextBox();
            this.txt_epp = new System.Windows.Forms.TextBox();
            this.txt_ebp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rtxt_crewinfo = new System.Windows.Forms.RichTextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(36, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(36, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(36, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departure/Arrival";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(36, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Carrier";
            // 
            // txt_FN
            // 
            this.txt_FN.Location = new System.Drawing.Point(187, 48);
            this.txt_FN.Name = "txt_FN";
            this.txt_FN.Size = new System.Drawing.Size(124, 21);
            this.txt_FN.TabIndex = 4;
            // 
            // rtxt_carrierinfo
            // 
            this.rtxt_carrierinfo.Location = new System.Drawing.Point(154, 252);
            this.rtxt_carrierinfo.Name = "rtxt_carrierinfo";
            this.rtxt_carrierinfo.Size = new System.Drawing.Size(405, 85);
            this.rtxt_carrierinfo.TabIndex = 5;
            this.rtxt_carrierinfo.Text = "";
            // 
            // txt_arrival
            // 
            this.txt_arrival.Location = new System.Drawing.Point(187, 144);
            this.txt_arrival.Name = "txt_arrival";
            this.txt_arrival.Size = new System.Drawing.Size(124, 21);
            this.txt_arrival.TabIndex = 6;
            // 
            // txt_carrier
            // 
            this.txt_carrier.Location = new System.Drawing.Point(187, 186);
            this.txt_carrier.Name = "txt_carrier";
            this.txt_carrier.Size = new System.Drawing.Size(124, 21);
            this.txt_carrier.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(361, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bussiness Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(361, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Economy Plus Price";
            // 
            // txt_eprice
            // 
            this.txt_eprice.AutoSize = true;
            this.txt_eprice.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_eprice.Location = new System.Drawing.Point(361, 47);
            this.txt_eprice.Name = "txt_eprice";
            this.txt_eprice.Size = new System.Drawing.Size(112, 16);
            this.txt_eprice.TabIndex = 9;
            this.txt_eprice.Text = "Economy Price";
            // 
            // txt_ep
            // 
            this.txt_ep.Location = new System.Drawing.Point(528, 48);
            this.txt_ep.Name = "txt_ep";
            this.txt_ep.Size = new System.Drawing.Size(124, 21);
            this.txt_ep.TabIndex = 17;
            // 
            // txt_epp
            // 
            this.txt_epp.Location = new System.Drawing.Point(528, 94);
            this.txt_epp.Name = "txt_epp";
            this.txt_epp.Size = new System.Drawing.Size(124, 21);
            this.txt_epp.TabIndex = 18;
            // 
            // txt_ebp
            // 
            this.txt_ebp.Location = new System.Drawing.Point(528, 138);
            this.txt_ebp.Name = "txt_ebp";
            this.txt_ebp.Size = new System.Drawing.Size(124, 21);
            this.txt_ebp.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(36, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Carrier Info";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(36, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Crew Info";
            // 
            // rtxt_crewinfo
            // 
            this.rtxt_crewinfo.Location = new System.Drawing.Point(154, 390);
            this.rtxt_crewinfo.Name = "rtxt_crewinfo";
            this.rtxt_crewinfo.Size = new System.Drawing.Size(405, 85);
            this.rtxt_crewinfo.TabIndex = 22;
            this.rtxt_crewinfo.Text = "";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(320, 532);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(103, 44);
            this.btn_add.TabIndex = 23;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(456, 532);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(103, 44);
            this.btn_cancel.TabIndex = 24;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // date_picker
            //
            this.date_picker.Value = DateTime.Today; 
            this.date_picker.CustomFormat = "yyyy-MM-dd";
            this.date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_picker.Location = new System.Drawing.Point(187, 94);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(128, 21);
            this.date_picker.TabIndex = 25;
            // 
            // AddFlightView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 618);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.rtxt_crewinfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ebp);
            this.Controls.Add(this.txt_epp);
            this.Controls.Add(this.txt_ep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_eprice);
            this.Controls.Add(this.txt_carrier);
            this.Controls.Add(this.txt_arrival);
            this.Controls.Add(this.rtxt_carrierinfo);
            this.Controls.Add(this.txt_FN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddFlightView";
            this.Text = "AddFlightView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_FN;
        private System.Windows.Forms.RichTextBox rtxt_carrierinfo;
        private System.Windows.Forms.TextBox txt_arrival;
        private System.Windows.Forms.TextBox txt_carrier;
        private System.Windows.Forms.Label txt_eprice;
        private System.Windows.Forms.TextBox txt_ep;
        private System.Windows.Forms.TextBox txt_ebp;
        private System.Windows.Forms.TextBox txt_epp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtxt_crewinfo;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DateTimePicker date_picker;
    }
}