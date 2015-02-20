namespace UniversityAdoExampleApp
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
            this.showTableGrid = new System.Windows.Forms.DataGridView();
            this.addRowButton = new System.Windows.Forms.Button();
            this.saveChangeButton = new System.Windows.Forms.Button();
            this.changeSelectedButton = new System.Windows.Forms.Button();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.tableComboBox = new System.Windows.Forms.ComboBox();
            this.workingGrid = new System.Windows.Forms.DataGridView();
            this.groupToSubjectPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.showIdCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.showTableGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingGrid)).BeginInit();
            this.groupToSubjectPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // showTableGrid
            // 
            this.showTableGrid.AllowUserToAddRows = false;
            this.showTableGrid.AllowUserToDeleteRows = false;
            this.showTableGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showTableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showTableGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.showTableGrid.Location = new System.Drawing.Point(12, 77);
            this.showTableGrid.Name = "showTableGrid";
            this.showTableGrid.Size = new System.Drawing.Size(560, 275);
            this.showTableGrid.TabIndex = 0;
            // 
            // addRowButton
            // 
            this.addRowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addRowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRowButton.Location = new System.Drawing.Point(495, 527);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(75, 23);
            this.addRowButton.TabIndex = 1;
            this.addRowButton.Text = "Add Row";
            this.addRowButton.UseVisualStyleBackColor = false;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // saveChangeButton
            // 
            this.saveChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.saveChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangeButton.Location = new System.Drawing.Point(296, 527);
            this.saveChangeButton.Name = "saveChangeButton";
            this.saveChangeButton.Size = new System.Drawing.Size(126, 23);
            this.saveChangeButton.TabIndex = 2;
            this.saveChangeButton.Text = "Save Changes";
            this.saveChangeButton.UseVisualStyleBackColor = false;
            this.saveChangeButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // changeSelectedButton
            // 
            this.changeSelectedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeSelectedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.changeSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeSelectedButton.Location = new System.Drawing.Point(157, 527);
            this.changeSelectedButton.Name = "changeSelectedButton";
            this.changeSelectedButton.Size = new System.Drawing.Size(133, 23);
            this.changeSelectedButton.TabIndex = 3;
            this.changeSelectedButton.Text = "Change Selected";
            this.changeSelectedButton.UseVisualStyleBackColor = false;
            this.changeSelectedButton.Click += new System.EventHandler(this.changeSelectedButton_Click);
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteSelectedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deleteSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedButton.Location = new System.Drawing.Point(12, 527);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(113, 23);
            this.deleteSelectedButton.TabIndex = 4;
            this.deleteSelectedButton.Text = "Delete Selected";
            this.deleteSelectedButton.UseVisualStyleBackColor = false;
            this.deleteSelectedButton.Click += new System.EventHandler(this.deleteSelectedButton_Click);
            // 
            // tableComboBox
            // 
            this.tableComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tableComboBox.FormattingEnabled = true;
            this.tableComboBox.Items.AddRange(new object[] {
            "Groups",
            "Students",
            "Subjects",
            "GroupToSubject"});
            this.tableComboBox.Location = new System.Drawing.Point(59, 12);
            this.tableComboBox.Name = "tableComboBox";
            this.tableComboBox.Size = new System.Drawing.Size(513, 21);
            this.tableComboBox.TabIndex = 5;
            this.tableComboBox.SelectedIndexChanged += new System.EventHandler(this.tableComboBox_SelectedIndexChanged);
            // 
            // workingGrid
            // 
            this.workingGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workingGrid.Location = new System.Drawing.Point(12, 358);
            this.workingGrid.Name = "workingGrid";
            this.workingGrid.Size = new System.Drawing.Size(560, 150);
            this.workingGrid.TabIndex = 7;
            this.workingGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.workingGrid_CellEndEdit);
            // 
            // groupToSubjectPanel
            // 
            this.groupToSubjectPanel.Controls.Add(this.label2);
            this.groupToSubjectPanel.Controls.Add(this.subjectComboBox);
            this.groupToSubjectPanel.Controls.Add(this.label1);
            this.groupToSubjectPanel.Controls.Add(this.groupComboBox);
            this.groupToSubjectPanel.Location = new System.Drawing.Point(12, 39);
            this.groupToSubjectPanel.Name = "groupToSubjectPanel";
            this.groupToSubjectPanel.Size = new System.Drawing.Size(558, 32);
            this.groupToSubjectPanel.TabIndex = 8;
            this.groupToSubjectPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Select subject:";
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(95, 6);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(152, 21);
            this.subjectComboBox.TabIndex = 13;
            this.subjectComboBox.SelectedIndexChanged += new System.EventHandler(this.subjectComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select group:";
            // 
            // groupComboBox
            // 
            this.groupComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(374, 6);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(176, 21);
            this.groupComboBox.TabIndex = 11;
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
            // 
            // showIdCheckBox
            // 
            this.showIdCheckBox.AutoSize = true;
            this.showIdCheckBox.Location = new System.Drawing.Point(18, 14);
            this.showIdCheckBox.Name = "showIdCheckBox";
            this.showIdCheckBox.Size = new System.Drawing.Size(35, 17);
            this.showIdCheckBox.TabIndex = 9;
            this.showIdCheckBox.Text = "Id";
            this.showIdCheckBox.UseVisualStyleBackColor = true;
            this.showIdCheckBox.CheckedChanged += new System.EventHandler(this.showIdCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 571);
            this.Controls.Add(this.showIdCheckBox);
            this.Controls.Add(this.groupToSubjectPanel);
            this.Controls.Add(this.workingGrid);
            this.Controls.Add(this.tableComboBox);
            this.Controls.Add(this.deleteSelectedButton);
            this.Controls.Add(this.changeSelectedButton);
            this.Controls.Add(this.saveChangeButton);
            this.Controls.Add(this.addRowButton);
            this.Controls.Add(this.showTableGrid);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showTableGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingGrid)).EndInit();
            this.groupToSubjectPanel.ResumeLayout(false);
            this.groupToSubjectPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView showTableGrid;
        private System.Windows.Forms.Button addRowButton;
        private System.Windows.Forms.Button saveChangeButton;
        private System.Windows.Forms.Button changeSelectedButton;
        private System.Windows.Forms.Button deleteSelectedButton;
        private System.Windows.Forms.ComboBox tableComboBox;
        private System.Windows.Forms.DataGridView workingGrid;
        private System.Windows.Forms.Panel groupToSubjectPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.CheckBox showIdCheckBox;
    }
}

