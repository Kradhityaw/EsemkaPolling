namespace BootcampProject1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.optionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pollIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pollcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pollResponsesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 717);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(40, 477);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(401, 29);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Saya Telah Menyetujui, Kebijakan Pribadi";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(36, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login To Continue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(35, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Terpercaya, Akurat, Dan Aman";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Esemka Polling";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(40, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.optionIDDataGridViewTextBoxColumn,
            this.pollIDDataGridViewTextBoxColumn,
            this.pollcol,
            this.optionTextDataGridViewTextBoxColumn,
            this.pollResponsesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(557, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(802, 415);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(549, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Live Pooling";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(407, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pooling Yang Sedang Berlangsung Sekarang";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(BootcampProject1.PollOption);
            // 
            // optionIDDataGridViewTextBoxColumn
            // 
            this.optionIDDataGridViewTextBoxColumn.DataPropertyName = "OptionID";
            this.optionIDDataGridViewTextBoxColumn.HeaderText = "OptionID";
            this.optionIDDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.optionIDDataGridViewTextBoxColumn.Name = "optionIDDataGridViewTextBoxColumn";
            this.optionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.optionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pollIDDataGridViewTextBoxColumn
            // 
            this.pollIDDataGridViewTextBoxColumn.DataPropertyName = "PollID";
            this.pollIDDataGridViewTextBoxColumn.HeaderText = "PollID";
            this.pollIDDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.pollIDDataGridViewTextBoxColumn.Name = "pollIDDataGridViewTextBoxColumn";
            this.pollIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pollIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pollcol
            // 
            this.pollcol.DataPropertyName = "Poll";
            this.pollcol.HeaderText = "Poll";
            this.pollcol.MinimumWidth = 9;
            this.pollcol.Name = "pollcol";
            this.pollcol.ReadOnly = true;
            // 
            // optionTextDataGridViewTextBoxColumn
            // 
            this.optionTextDataGridViewTextBoxColumn.DataPropertyName = "OptionText";
            this.optionTextDataGridViewTextBoxColumn.HeaderText = "OptionText";
            this.optionTextDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.optionTextDataGridViewTextBoxColumn.Name = "optionTextDataGridViewTextBoxColumn";
            this.optionTextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pollResponsesDataGridViewTextBoxColumn
            // 
            this.pollResponsesDataGridViewTextBoxColumn.DataPropertyName = "PollResponses";
            this.pollResponsesDataGridViewTextBoxColumn.HeaderText = "PollResponses";
            this.pollResponsesDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.pollResponsesDataGridViewTextBoxColumn.Name = "pollResponsesDataGridViewTextBoxColumn";
            this.pollResponsesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 717);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esemka Pooling";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pollIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pollcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pollResponsesDataGridViewTextBoxColumn;
    }
}

