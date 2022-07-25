
namespace Bus_Sytem
{
    partial class MANAGERDATA
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.online_BusDataSet3 = new Bus_Sytem.Online_BusDataSet3();
            this.managerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.online_BusDataSet39 = new Bus_Sytem.Online_BusDataSet39();
            this.managerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.online_BusDataSet24 = new Bus_Sytem.Online_BusDataSet24();
            this.managerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.online_BusDataSet17 = new Bus_Sytem.Online_BusDataSet17();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.managerTableAdapter = new Bus_Sytem.Online_BusDataSet3TableAdapters.managerTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.managerTableAdapter1 = new Bus_Sytem.Online_BusDataSet17TableAdapters.managerTableAdapter();
            this.managerTableAdapter2 = new Bus_Sytem.Online_BusDataSet24TableAdapters.managerTableAdapter();
            this.online_BusDataSet40 = new Bus_Sytem.Online_BusDataSet40();
            this.managerBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.managerTableAdapter3 = new Bus_Sytem.Online_BusDataSet40TableAdapters.managerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_BusDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_BusDataSet39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_BusDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_BusDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_BusDataSet40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Working E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.managerBindingSource4;
            this.comboBox1.DisplayMember = "managerid";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(410, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "managerid";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataMember = "manager";
            this.managerBindingSource.DataSource = this.online_BusDataSet3;
            // 
            // online_BusDataSet3
            // 
            this.online_BusDataSet3.DataSetName = "Online_BusDataSet3";
            this.online_BusDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerBindingSource3
            // 
            this.managerBindingSource3.DataMember = "manager";
            this.managerBindingSource3.DataSource = this.online_BusDataSet39;
            // 
            // online_BusDataSet39
            // 
            this.online_BusDataSet39.DataSetName = "Online_BusDataSet39";
            this.online_BusDataSet39.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerBindingSource2
            // 
            this.managerBindingSource2.DataMember = "manager";
            this.managerBindingSource2.DataSource = this.online_BusDataSet24;
            // 
            // online_BusDataSet24
            // 
            this.online_BusDataSet24.DataSetName = "Online_BusDataSet24";
            this.online_BusDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerBindingSource1
            // 
            this.managerBindingSource1.DataMember = "manager";
            this.managerBindingSource1.DataSource = this.online_BusDataSet17;
            // 
            // online_BusDataSet17
            // 
            this.online_BusDataSet17.DataSetName = "Online_BusDataSet17";
            this.online_BusDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(363, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 24);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(363, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 24);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(363, 246);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 24);
            this.textBox3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 66);
            this.button1.TabIndex = 8;
            this.button1.Text = "ADD MANAGER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 66);
            this.button2.TabIndex = 9;
            this.button2.Text = "UPDATE MANAGER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 66);
            this.button3.TabIndex = 10;
            this.button3.Text = "DELETE MANAGER";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contact:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(363, 298);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(135, 24);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(363, 348);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(135, 24);
            this.textBox5.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "CHOOSE ID OF THE MANAGER:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(585, 432);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 66);
            this.button4.TabIndex = 15;
            this.button4.Text = "BACK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // managerTableAdapter
            // 
            this.managerTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Password:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(363, 173);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(135, 24);
            this.textBox6.TabIndex = 17;
            this.textBox6.UseSystemPasswordChar = true;
            // 
            // managerTableAdapter1
            // 
            this.managerTableAdapter1.ClearBeforeFill = true;
            // 
            // managerTableAdapter2
            // 
            this.managerTableAdapter2.ClearBeforeFill = true;
            // 
            // online_BusDataSet40
            // 
            this.online_BusDataSet40.DataSetName = "Online_BusDataSet40";
            this.online_BusDataSet40.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerBindingSource4
            // 
            this.managerBindingSource4.DataMember = "manager";
            this.managerBindingSource4.DataSource = this.online_BusDataSet40;
            // 
            // managerTableAdapter3
            // 
            this.managerTableAdapter3.ClearBeforeFill = true;
            // 
            // MANAGERDATA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 552);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MANAGERDATA";
            this.Text = "MANAGERDATA";
            this.Load += new System.EventHandler(this.MANAGERDATA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_BusDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_BusDataSet39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_BusDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_BusDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_BusDataSet40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private Online_BusDataSet3 online_BusDataSet3;
        private System.Windows.Forms.BindingSource managerBindingSource;
        private Online_BusDataSet3TableAdapters.managerTableAdapter managerTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private Online_BusDataSet17 online_BusDataSet17;
        private System.Windows.Forms.BindingSource managerBindingSource1;
        private Online_BusDataSet17TableAdapters.managerTableAdapter managerTableAdapter1;
        private Online_BusDataSet24 online_BusDataSet24;
        private System.Windows.Forms.BindingSource managerBindingSource2;
        private Online_BusDataSet24TableAdapters.managerTableAdapter managerTableAdapter2;
        private System.Windows.Forms.BindingSource managerBindingSource3;
        private Online_BusDataSet39 online_BusDataSet39;
        private Online_BusDataSet40 online_BusDataSet40;
        private System.Windows.Forms.BindingSource managerBindingSource4;
        private Online_BusDataSet40TableAdapters.managerTableAdapter managerTableAdapter3;
    }
}