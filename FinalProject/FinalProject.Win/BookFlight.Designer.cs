namespace FinalProject.Win
{
    partial class BookFlight
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
            this.Class_E = new System.Windows.Forms.Label();
            this.Class_EP = new System.Windows.Forms.Label();
            this.Class_B = new System.Windows.Forms.Label();
            this.btn_confrim = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.rb_ec = new System.Windows.Forms.RadioButton();
            this.rb_bc = new System.Windows.Forms.RadioButton();
            this.rb_epc = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(140, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Choose a Class";
            // 
            // Class_E
            // 
            this.Class_E.AutoSize = true;
            this.Class_E.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Class_E.Location = new System.Drawing.Point(140, 105);
            this.Class_E.Name = "Class_E";
            this.Class_E.Size = new System.Drawing.Size(112, 16);
            this.Class_E.TabIndex = 1;
            this.Class_E.Text = "Economy Class";
            // 
            // Class_EP
            // 
            this.Class_EP.AutoSize = true;
            this.Class_EP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Class_EP.Location = new System.Drawing.Point(140, 142);
            this.Class_EP.Name = "Class_EP";
            this.Class_EP.Size = new System.Drawing.Size(152, 16);
            this.Class_EP.TabIndex = 2;
            this.Class_EP.Text = "Economy Plus Class";
            // 
            // Class_B
            // 
            this.Class_B.AutoSize = true;
            this.Class_B.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Class_B.Location = new System.Drawing.Point(140, 177);
            this.Class_B.Name = "Class_B";
            this.Class_B.Size = new System.Drawing.Size(128, 16);
            this.Class_B.TabIndex = 3;
            this.Class_B.Text = "Bussiness Class";
            // 
            // btn_confrim
            // 
            this.btn_confrim.Location = new System.Drawing.Point(107, 247);
            this.btn_confrim.Name = "btn_confrim";
            this.btn_confrim.Size = new System.Drawing.Size(93, 32);
            this.btn_confrim.TabIndex = 4;
            this.btn_confrim.Text = "Confirm";
            this.btn_confrim.UseVisualStyleBackColor = true;
            this.btn_confrim.Click += new System.EventHandler(this.btn_confrim_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(276, 247);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(93, 32);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // rb_ec
            // 
            this.rb_ec.AutoSize = true;
            this.rb_ec.Location = new System.Drawing.Point(120, 105);
            this.rb_ec.Name = "rb_ec";
            this.rb_ec.Size = new System.Drawing.Size(14, 13);
            this.rb_ec.TabIndex = 6;
            this.rb_ec.TabStop = true;
            this.rb_ec.UseVisualStyleBackColor = true;
            // 
            // rb_bc
            // 
            this.rb_bc.AutoSize = true;
            this.rb_bc.Location = new System.Drawing.Point(120, 180);
            this.rb_bc.Name = "rb_bc";
            this.rb_bc.Size = new System.Drawing.Size(14, 13);
            this.rb_bc.TabIndex = 7;
            this.rb_bc.TabStop = true;
            this.rb_bc.UseVisualStyleBackColor = true;
            // 
            // rb_epc
            // 
            this.rb_epc.AutoSize = true;
            this.rb_epc.Location = new System.Drawing.Point(120, 146);
            this.rb_epc.Name = "rb_epc";
            this.rb_epc.Size = new System.Drawing.Size(14, 13);
            this.rb_epc.TabIndex = 8;
            this.rb_epc.TabStop = true;
            this.rb_epc.UseVisualStyleBackColor = true;
            // 
            // BookFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 314);
            this.Controls.Add(this.rb_epc);
            this.Controls.Add(this.rb_bc);
            this.Controls.Add(this.rb_ec);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_confrim);
            this.Controls.Add(this.Class_B);
            this.Controls.Add(this.Class_EP);
            this.Controls.Add(this.Class_E);
            this.Controls.Add(this.label1);
            this.Name = "BookFlight";
            this.Text = "BookFlight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Class_E;
        private System.Windows.Forms.Label Class_EP;
        private System.Windows.Forms.Label Class_B;
        private System.Windows.Forms.Button btn_confrim;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.RadioButton rb_ec;
        private System.Windows.Forms.RadioButton rb_bc;
        private System.Windows.Forms.RadioButton rb_epc;
    }
}