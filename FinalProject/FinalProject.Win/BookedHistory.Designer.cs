using System.Windows.Forms;

namespace FinalProject.Win
{
    partial class BookedHistory
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
            this.BookedInfoView = new System.Windows.Forms.DataGridView();
            this.btn_unbook = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookedInfoView)).BeginInit();
            this.SuspendLayout();
            // 
            // BookedInfoView
            // 
            this.BookedInfoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookedInfoView.Location = new System.Drawing.Point(12, 12);
            this.BookedInfoView.Name = "BookedInfoView";
            this.BookedInfoView.RowTemplate.Height = 23;
            this.BookedInfoView.Size = new System.Drawing.Size(536, 286);
            this.BookedInfoView.TabIndex = 0;
            this.BookedInfoView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // btn_unbook
            // 
            this.btn_unbook.Location = new System.Drawing.Point(105, 330);
            this.btn_unbook.Name = "btn_unbook";
            this.btn_unbook.Size = new System.Drawing.Size(124, 47);
            this.btn_unbook.TabIndex = 1;
            this.btn_unbook.Text = "Unbook This Flight";
            this.btn_unbook.UseVisualStyleBackColor = true;
            this.btn_unbook.Click += new System.EventHandler(this.btn_unbook_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(309, 330);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(124, 47);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // BookedHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 403);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_unbook);
            this.Controls.Add(this.BookedInfoView);
            this.Name = "BookedHistory";
            this.Text = "BookedHistory";
            ((System.ComponentModel.ISupportInitialize)(this.BookedInfoView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BookedInfoView;
        private System.Windows.Forms.Button btn_unbook;
        private System.Windows.Forms.Button btn_cancel;
    }
}