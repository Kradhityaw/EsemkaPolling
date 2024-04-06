namespace BootcampProject1
{
    partial class FormPemungutan
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
            System.Windows.Forms.Label questionLabel;
            System.Windows.Forms.Label optionTextLabel;
            this.pollDataGridView = new System.Windows.Forms.DataGridView();
            this.pollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pollOptionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editoptionCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pollOptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.optionTextTextBox = new System.Windows.Forms.TextBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isclosedcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.isclosecol = new System.Windows.Forms.DataGridViewButtonColumn();
            questionLabel = new System.Windows.Forms.Label();
            optionTextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pollDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollOptionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollOptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new System.Drawing.Point(31, 48);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new System.Drawing.Size(97, 25);
            questionLabel.TabIndex = 7;
            questionLabel.Text = "Question:";
            // 
            // optionTextLabel
            // 
            optionTextLabel.AutoSize = true;
            optionTextLabel.Location = new System.Drawing.Point(31, 46);
            optionTextLabel.Name = "optionTextLabel";
            optionTextLabel.Size = new System.Drawing.Size(120, 25);
            optionTextLabel.TabIndex = 10;
            optionTextLabel.Text = "Option Text:";
            // 
            // pollDataGridView
            // 
            this.pollDataGridView.AllowUserToAddRows = false;
            this.pollDataGridView.AllowUserToDeleteRows = false;
            this.pollDataGridView.AutoGenerateColumns = false;
            this.pollDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pollDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pollDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.isclosedcolumn,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.delCol,
            this.editCol,
            this.isclosecol});
            this.pollDataGridView.DataSource = this.pollBindingSource;
            this.pollDataGridView.Location = new System.Drawing.Point(34, 120);
            this.pollDataGridView.Name = "pollDataGridView";
            this.pollDataGridView.ReadOnly = true;
            this.pollDataGridView.RowHeadersVisible = false;
            this.pollDataGridView.RowHeadersWidth = 72;
            this.pollDataGridView.RowTemplate.Height = 31;
            this.pollDataGridView.Size = new System.Drawing.Size(1320, 320);
            this.pollDataGridView.TabIndex = 1;
            this.pollDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pollDataGridView_CellContentClick);
            this.pollDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.pollDataGridView_CellFormatting);
            // 
            // pollBindingSource
            // 
            this.pollBindingSource.DataSource = typeof(BootcampProject1.Poll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // questionTextBox
            // 
            this.questionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Question", true));
            this.questionTextBox.Location = new System.Drawing.Point(134, 46);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(199, 29);
            this.questionTextBox.TabIndex = 8;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(BootcampProject1.Poll);
            // 
            // pollOptionDataGridView
            // 
            this.pollOptionDataGridView.AllowUserToAddRows = false;
            this.pollOptionDataGridView.AllowUserToDeleteRows = false;
            this.pollOptionDataGridView.AutoGenerateColumns = false;
            this.pollOptionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pollOptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pollOptionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.removeCol,
            this.editoptionCol});
            this.pollOptionDataGridView.DataSource = this.pollOptionBindingSource;
            this.pollOptionDataGridView.Location = new System.Drawing.Point(272, 32);
            this.pollOptionDataGridView.Name = "pollOptionDataGridView";
            this.pollOptionDataGridView.ReadOnly = true;
            this.pollOptionDataGridView.RowHeadersVisible = false;
            this.pollOptionDataGridView.RowHeadersWidth = 72;
            this.pollOptionDataGridView.RowTemplate.Height = 31;
            this.pollOptionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pollOptionDataGridView.Size = new System.Drawing.Size(590, 260);
            this.pollOptionDataGridView.TabIndex = 8;
            this.pollOptionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pollOptionDataGridView_CellContentClick);
            this.pollOptionDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.pollOptionDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OptionID";
            this.dataGridViewTextBoxColumn9.HeaderText = "OptionID";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PollID";
            this.dataGridViewTextBoxColumn10.HeaderText = "PollID";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "OptionText";
            this.dataGridViewTextBoxColumn11.HeaderText = "OptionText";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Poll";
            this.dataGridViewTextBoxColumn12.HeaderText = "Poll";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "PollResponses";
            this.dataGridViewTextBoxColumn13.HeaderText = "PollResponses";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // removeCol
            // 
            this.removeCol.HeaderText = "";
            this.removeCol.MinimumWidth = 9;
            this.removeCol.Name = "removeCol";
            this.removeCol.ReadOnly = true;
            this.removeCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.removeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // editoptionCol
            // 
            this.editoptionCol.HeaderText = "";
            this.editoptionCol.MinimumWidth = 9;
            this.editoptionCol.Name = "editoptionCol";
            this.editoptionCol.ReadOnly = true;
            // 
            // pollOptionBindingSource
            // 
            this.pollOptionBindingSource.DataSource = typeof(BootcampProject1.PollOption);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // optionTextTextBox
            // 
            this.optionTextTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "OptionText", true));
            this.optionTextTextBox.Location = new System.Drawing.Point(36, 84);
            this.optionTextTextBox.Name = "optionTextTextBox";
            this.optionTextTextBox.Size = new System.Drawing.Size(202, 29);
            this.optionTextTextBox.TabIndex = 11;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(BootcampProject1.PollOption);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.questionTextBox);
            this.groupBox1.Controls.Add(questionLabel);
            this.groupBox1.Location = new System.Drawing.Point(41, 481);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 198);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add To Polls";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pollOptionDataGridView);
            this.groupBox2.Controls.Add(optionTextLabel);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.optionTextTextBox);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(446, 481);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(881, 315);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add To Poll Options";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(58, 721);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 52);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(239, 721);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 52);
            this.button4.TabIndex = 14;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1390, 100);
            this.panel2.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::BootcampProject1.Properties.Resources.toppng_com_kudos_back_white_icon_600x1059;
            this.pictureBox1.Location = new System.Drawing.Point(20, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.85714F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(96, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pemungutan Suara";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PollID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PollID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AdminID";
            this.dataGridViewTextBoxColumn2.HeaderText = "AdminID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Question";
            this.dataGridViewTextBoxColumn3.HeaderText = "Question";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // isclosedcolumn
            // 
            this.isclosedcolumn.DataPropertyName = "IsClosed";
            this.isclosedcolumn.HeaderText = "IsClosed";
            this.isclosedcolumn.MinimumWidth = 9;
            this.isclosedcolumn.Name = "isclosedcolumn";
            this.isclosedcolumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CreatedAt";
            this.dataGridViewTextBoxColumn5.HeaderText = "CreatedAt";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Admin";
            this.dataGridViewTextBoxColumn6.HeaderText = "Admin";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PollOptions";
            this.dataGridViewTextBoxColumn7.HeaderText = "PollOptions";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PollResponses";
            this.dataGridViewTextBoxColumn8.HeaderText = "PollResponses";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // delCol
            // 
            this.delCol.HeaderText = "";
            this.delCol.MinimumWidth = 9;
            this.delCol.Name = "delCol";
            this.delCol.ReadOnly = true;
            // 
            // editCol
            // 
            this.editCol.HeaderText = "";
            this.editCol.MinimumWidth = 9;
            this.editCol.Name = "editCol";
            this.editCol.ReadOnly = true;
            // 
            // isclosecol
            // 
            this.isclosecol.HeaderText = "";
            this.isclosecol.MinimumWidth = 9;
            this.isclosecol.Name = "isclosecol";
            this.isclosecol.ReadOnly = true;
            this.isclosecol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isclosecol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormPemungutan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 815);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pollDataGridView);
            this.Name = "FormPemungutan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPemungutan";
            this.Load += new System.EventHandler(this.FormPemungutan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pollDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollOptionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollOptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource pollBindingSource;
        private System.Windows.Forms.DataGridView pollDataGridView;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.BindingSource pollOptionBindingSource;
        private System.Windows.Forms.DataGridView pollOptionDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.TextBox optionTextTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewButtonColumn removeCol;
        private System.Windows.Forms.DataGridViewButtonColumn editoptionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn isclosedcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewButtonColumn delCol;
        private System.Windows.Forms.DataGridViewButtonColumn editCol;
        private System.Windows.Forms.DataGridViewButtonColumn isclosecol;
    }
}