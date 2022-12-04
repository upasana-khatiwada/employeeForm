namespace employeeform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.TextBox();
            this.address1 = new System.Windows.Forms.TextBox();
            this.age1 = new System.Windows.Forms.TextBox();
            this.contact1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.e_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Tag = "";
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Contact";
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(167, 61);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(288, 23);
            this.name1.TabIndex = 6;
            this.name1.TextChanged += new System.EventHandler(this.name1_TextChanged);
            // 
            // address1
            // 
            this.address1.Location = new System.Drawing.Point(167, 105);
            this.address1.Name = "address1";
            this.address1.Size = new System.Drawing.Size(288, 23);
            this.address1.TabIndex = 7;
            this.address1.TextChanged += new System.EventHandler(this.address1_TextChanged);
            // 
            // age1
            // 
            this.age1.Location = new System.Drawing.Point(167, 134);
            this.age1.Name = "age1";
            this.age1.Size = new System.Drawing.Size(288, 23);
            this.age1.TabIndex = 8;
            this.age1.TextChanged += new System.EventHandler(this.age1_TextChanged);
            // 
            // contact1
            // 
            this.contact1.Location = new System.Drawing.Point(167, 169);
            this.contact1.Name = "contact1";
            this.contact1.Size = new System.Drawing.Size(288, 23);
            this.contact1.TabIndex = 9;
            this.contact1.TextChanged += new System.EventHandler(this.contact1_TextChange);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "display data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.e_name,
            this.e_address,
            this.e_age,
            this.e_contact});
            this.dataGridView1.Location = new System.Drawing.Point(50, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(437, 204);
            this.dataGridView1.TabIndex = 11;
            // 
            // e_name
            // 
            this.e_name.HeaderText = "e_name";
            this.e_name.Name = "e_name";
            // 
            // e_address
            // 
            this.e_address.HeaderText = "e_address";
            this.e_address.Name = "e_address";
            // 
            // e_age
            // 
            this.e_age.HeaderText = "e_age";
            this.e_age.Name = "e_age";
            // 
            // e_contact
            // 
            this.e_contact.HeaderText = "e_contact";
            this.e_contact.Name = "e_contact";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(637, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 39);
            this.button2.TabIndex = 12;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contact1);
            this.Controls.Add(this.age1);
            this.Controls.Add(this.address1);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox name1;
        private TextBox address1;
        private TextBox age1;
        private TextBox contact1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn e_name;
        private DataGridViewTextBoxColumn e_address;
        private DataGridViewTextBoxColumn e_age;
        private DataGridViewTextBoxColumn e_contact;
        private Button button2;
    }
}