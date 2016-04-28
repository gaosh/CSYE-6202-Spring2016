using System;
using System.Windows.Forms;

namespace FinalProject.Win
{
    partial class FlightView
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
            this.btn_detail = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_book = new System.Windows.Forms.Button();
            this.btn_bkhistory = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_viewall = new System.Windows.Forms.Button();
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
            this.FlightDataView.SelectionChanged += new System.EventHandler(this.HandleFlightDataViewSelectionChanged);
            // 
            // btn_detail
            // 
            this.btn_detail.Location = new System.Drawing.Point(44, 363);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(118, 44);
            this.btn_detail.TabIndex = 1;
            this.btn_detail.Text = "Flight Detail";
            this.btn_detail.UseVisualStyleBackColor = true;
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
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
            // btn_book
            // 
            this.btn_book.Location = new System.Drawing.Point(315, 363);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(118, 44);
            this.btn_book.TabIndex = 3;
            this.btn_book.Text = "Book this Flight";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // btn_bkhistory
            // 
            this.btn_bkhistory.Location = new System.Drawing.Point(589, 363);
            this.btn_bkhistory.Name = "btn_bkhistory";
            this.btn_bkhistory.Size = new System.Drawing.Size(118, 44);
            this.btn_bkhistory.TabIndex = 4;
            this.btn_bkhistory.Text = "Booking History";
            this.btn_bkhistory.UseVisualStyleBackColor = true;
            this.btn_bkhistory.Click += new System.EventHandler(this.btn_bkhistory_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(315, 442);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(118, 44);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(41, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Depature/Arrival:";
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Search.Location = new System.Drawing.Point(191, 451);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(106, 26);
            this.txt_Search.TabIndex = 7;
            // 
            // btn_viewall
            // 
            this.btn_viewall.Location = new System.Drawing.Point(589, 442);
            this.btn_viewall.Name = "btn_viewall";
            this.btn_viewall.Size = new System.Drawing.Size(118, 44);
            this.btn_viewall.TabIndex = 8;
            this.btn_viewall.Text = "View All";
            this.btn_viewall.UseVisualStyleBackColor = true;
            this.btn_viewall.Click += new System.EventHandler(this.btn_viewall_Click);
            // 
            // FlightView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 512);
            this.Controls.Add(this.btn_viewall);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_bkhistory);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_detail);
            this.Controls.Add(this.FlightDataView);
            this.Name = "FlightView";
            this.Text = "FlightView";
            ((System.ComponentModel.ISupportInitialize)(this.FlightDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.DataGridView FlightDataView;
        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Button btn_bkhistory;
        private Button btn_Search;
        private Label label1;
        private TextBox txt_Search;
        private Button btn_viewall;
    }
}