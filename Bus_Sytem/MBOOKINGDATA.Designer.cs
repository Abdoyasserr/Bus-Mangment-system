﻿
namespace Bus_Sytem
{
    partial class MBOOKINGDATA
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
            this.components = new System.ComponentModel.Container();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bookingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.online_BusDataSet19 = new Bus_Sytem.Online_BusDataSet19();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.online_BusDataSet14 = new Bus_Sytem.Online_BusDataSet14();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new Bus_Sytem.Online_BusDataSet19TableAdapters.bookingTableAdapter();
            this.online_BusDataSet25 = new Bus_Sytem.Online_BusDataSet25();
            this.bookingBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter1 = new Bus_Sytem.Online_BusDataSet25TableAdapters.bookingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_BusDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_BusDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_BusDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(405, 400);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 66);
            this.button4.TabIndex = 46;
            this.button4.Text = "BACK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "SEARCH BOOKING ID:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(370, 282);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(88, 24);
            this.textBox4.TabIndex = 43;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 66);
            this.button3.TabIndex = 41;
            this.button3.Text = "DELETE BOOKING";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(370, 230);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(88, 24);
            this.textBox3.TabIndex = 38;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(370, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 24);
            this.textBox2.TabIndex = 37;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(370, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 24);
            this.textBox1.TabIndex = 36;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bookingBindingSource2;
            this.comboBox1.DisplayMember = "bookingid";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(417, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 24);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.ValueMember = "bookingid";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bookingBindingSource1
            // 
            this.bookingBindingSource1.DataMember = "booking";
            this.bookingBindingSource1.DataSource = this.online_BusDataSet19;
            // 
            // online_BusDataSet19
            // 
            this.online_BusDataSet19.DataSetName = "Online_BusDataSet19";
            this.online_BusDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Journey Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Seat Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Bus Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Booking ID:";
            // 
            // online_BusDataSet14
            // 
            this.online_BusDataSet14.DataSetName = "Online_BusDataSet14";
            this.online_BusDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "booking";
            this.bookingBindingSource.DataSource = this.online_BusDataSet14;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // online_BusDataSet25
            // 
            this.online_BusDataSet25.DataSetName = "Online_BusDataSet25";
            this.online_BusDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingBindingSource2
            // 
            this.bookingBindingSource2.DataMember = "booking";
            this.bookingBindingSource2.DataSource = this.online_BusDataSet25;
            // 
            // bookingTableAdapter1
            // 
            this.bookingTableAdapter1.ClearBeforeFill = true;
            // 
            // MBOOKINGDATA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 523);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MBOOKINGDATA";
            this.Text = "MBOOKINGDATA";
            this.Load += new System.EventHandler(this.MBOOKINGDATA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_BusDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_BusDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_BusDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private Online_BusDataSet14 online_BusDataSet14;
        private Online_BusDataSet19 online_BusDataSet19;
        private System.Windows.Forms.BindingSource bookingBindingSource1;
        private Online_BusDataSet19TableAdapters.bookingTableAdapter bookingTableAdapter;
        private Online_BusDataSet25 online_BusDataSet25;
        private System.Windows.Forms.BindingSource bookingBindingSource2;
        private Online_BusDataSet25TableAdapters.bookingTableAdapter bookingTableAdapter1;
    }
}