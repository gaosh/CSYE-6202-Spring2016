﻿namespace FinalProject.Win
{
    partial class BookedInfoView
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
            this.BookedUserView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BookedUserView)).BeginInit();
            this.SuspendLayout();
            // 
            // BookedUserView
            // 
            this.BookedUserView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookedUserView.Location = new System.Drawing.Point(0, 0);
            this.BookedUserView.Name = "BookedUserView";
            this.BookedUserView.RowTemplate.Height = 23;
            this.BookedUserView.Size = new System.Drawing.Size(491, 266);
            this.BookedUserView.TabIndex = 0;
            // 
            // BookedInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 266);
            this.Controls.Add(this.BookedUserView);
            this.Name = "BookedInfoView";
            this.Text = "BookedInfo";
            ((System.ComponentModel.ISupportInitialize)(this.BookedUserView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BookedUserView;
    }
}