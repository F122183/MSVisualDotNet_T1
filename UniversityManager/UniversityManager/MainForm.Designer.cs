namespace UniversityManager
{
    partial class MainForm
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
            groupBox1 = new GroupBox();
            professorsSortButton = new RadioButton();
            studentsSortButton = new RadioButton();
            allSortButton = new RadioButton();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lstPeople = new ListBox();
            rmvButton = new Button();
            addBtn = new Button();
            extraInfoTxt = new TextBox();
            extraInfoLabel = new Label();
            roleLabel = new Label();
            roleComboBox = new ComboBox();
            txtId = new TextBox();
            idLabel = new Label();
            nameLabel = new Label();
            txtName = new TextBox();
            groupBox1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(professorsSortButton);
            groupBox1.Controls.Add(studentsSortButton);
            groupBox1.Controls.Add(allSortButton);
            groupBox1.Controls.Add(statusStrip1);
            groupBox1.Controls.Add(lstPeople);
            groupBox1.Controls.Add(rmvButton);
            groupBox1.Controls.Add(addBtn);
            groupBox1.Controls.Add(extraInfoTxt);
            groupBox1.Controls.Add(extraInfoLabel);
            groupBox1.Controls.Add(roleLabel);
            groupBox1.Controls.Add(roleComboBox);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(idLabel);
            groupBox1.Controls.Add(nameLabel);
            groupBox1.Controls.Add(txtName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Person Details";
            // 
            // professorsSortButton
            // 
            professorsSortButton.AutoSize = true;
            professorsSortButton.Location = new Point(676, 19);
            professorsSortButton.Name = "professorsSortButton";
            professorsSortButton.Size = new Size(90, 19);
            professorsSortButton.TabIndex = 14;
            professorsSortButton.TabStop = true;
            professorsSortButton.Text = "Faculty Staff";
            professorsSortButton.UseVisualStyleBackColor = true;
            professorsSortButton.CheckedChanged += professorsSortButton_CheckedChanged;
            // 
            // studentsSortButton
            // 
            studentsSortButton.AutoSize = true;
            studentsSortButton.Location = new Point(554, 19);
            studentsSortButton.Name = "studentsSortButton";
            studentsSortButton.Size = new Size(71, 19);
            studentsSortButton.TabIndex = 13;
            studentsSortButton.TabStop = true;
            studentsSortButton.Text = "Students";
            studentsSortButton.UseVisualStyleBackColor = true;
            studentsSortButton.CheckedChanged += studentsSortButton_CheckedChanged;
            // 
            // allSortButton
            // 
            allSortButton.AutoSize = true;
            allSortButton.Location = new Point(429, 19);
            allSortButton.Name = "allSortButton";
            allSortButton.Size = new Size(39, 19);
            allSortButton.TabIndex = 12;
            allSortButton.TabStop = true;
            allSortButton.Text = "All";
            allSortButton.UseVisualStyleBackColor = true;
            allSortButton.CheckedChanged += allSortButton_CheckedChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(3, 401);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(770, 22);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 17);
            // 
            // lstPeople
            // 
            lstPeople.FormattingEnabled = true;
            lstPeople.Location = new Point(429, 49);
            lstPeople.Name = "lstPeople";
            lstPeople.Size = new Size(341, 349);
            lstPeople.TabIndex = 10;
            // 
            // rmvButton
            // 
            rmvButton.Location = new Point(178, 271);
            rmvButton.Name = "rmvButton";
            rmvButton.Size = new Size(118, 23);
            rmvButton.TabIndex = 9;
            rmvButton.Text = "Remove Selected";
            rmvButton.UseVisualStyleBackColor = true;
            rmvButton.Click += rmvButton_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(30, 271);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(99, 23);
            addBtn.TabIndex = 8;
            addBtn.Text = "Add Person";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // extraInfoTxt
            // 
            extraInfoTxt.Location = new Point(128, 150);
            extraInfoTxt.Name = "extraInfoTxt";
            extraInfoTxt.Size = new Size(192, 23);
            extraInfoTxt.TabIndex = 7;
            extraInfoTxt.Visible = false;
            // 
            // extraInfoLabel
            // 
            extraInfoLabel.AutoSize = true;
            extraInfoLabel.Location = new Point(30, 150);
            extraInfoLabel.Name = "extraInfoLabel";
            extraInfoLabel.Size = new Size(0, 15);
            extraInfoLabel.TabIndex = 6;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new Point(30, 81);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(30, 15);
            roleLabel.TabIndex = 5;
            roleLabel.Text = "Role";
            // 
            // roleComboBox
            // 
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Items.AddRange(new object[] { "Select Role", "Student", "Faculty Staff" });
            roleComboBox.Location = new Point(91, 73);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(229, 23);
            roleComboBox.TabIndex = 4;
            roleComboBox.SelectedValueChanged += roleComboBox_SelectedValueChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(128, 114);
            txtId.Name = "txtId";
            txtId.Size = new Size(192, 23);
            txtId.TabIndex = 3;
            txtId.Visible = false;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(30, 117);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(0, 15);
            idLabel.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(29, 44);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(91, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 23);
            txtName.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "University Manager - Mario Nikolov";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label roleLabel;
        private ComboBox roleComboBox;
        private TextBox txtId;
        private Label idLabel;
        private Label nameLabel;
        private TextBox txtName;
        private Label extraInfoLabel;
        private TextBox extraInfoTxt;
        private StatusStrip statusStrip1;
        private ListBox lstPeople;
        private Button rmvButton;
        private Button addBtn;
        private ToolStripStatusLabel lblStatus;
        private RadioButton professorsSortButton;
        private RadioButton studentsSortButton;
        private RadioButton allSortButton;
    }
}
