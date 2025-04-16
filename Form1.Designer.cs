namespace GymCommander
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
            ControlsGroupBox = new GroupBox();
            Checkbox_ActiveMembersOnly = new CheckBox();
            Button_ScanCard = new Button();
            Button_AdvancedSearch = new Button();
            Button_ShowAllMembers = new Button();
            SearchTextBox = new TextBox();
            Button_Delete = new Button();
            Button_Edit = new Button();
            Button_AddNew = new Button();
            MainListView = new ListView();
            IDColumnHeader = new ColumnHeader();
            ControlsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ControlsGroupBox
            // 
            ControlsGroupBox.Controls.Add(Checkbox_ActiveMembersOnly);
            ControlsGroupBox.Controls.Add(Button_ScanCard);
            ControlsGroupBox.Controls.Add(Button_AdvancedSearch);
            ControlsGroupBox.Controls.Add(Button_ShowAllMembers);
            ControlsGroupBox.Controls.Add(SearchTextBox);
            ControlsGroupBox.Controls.Add(Button_Delete);
            ControlsGroupBox.Controls.Add(Button_Edit);
            ControlsGroupBox.Controls.Add(Button_AddNew);
            ControlsGroupBox.Location = new Point(1, 0);
            ControlsGroupBox.Name = "ControlsGroupBox";
            ControlsGroupBox.Size = new Size(320, 670);
            ControlsGroupBox.TabIndex = 0;
            ControlsGroupBox.TabStop = false;
            ControlsGroupBox.Text = "Control";
            // 
            // Checkbox_ActiveMembersOnly
            // 
            Checkbox_ActiveMembersOnly.AutoSize = true;
            Checkbox_ActiveMembersOnly.Location = new Point(79, 94);
            Checkbox_ActiveMembersOnly.Name = "Checkbox_ActiveMembersOnly";
            Checkbox_ActiveMembersOnly.Size = new Size(163, 24);
            Checkbox_ActiveMembersOnly.TabIndex = 10;
            Checkbox_ActiveMembersOnly.Text = "Doar membrii activi";
            Checkbox_ActiveMembersOnly.UseVisualStyleBackColor = true;
            Checkbox_ActiveMembersOnly.CheckedChanged += Checkbox_ActiveMembersOnly_CheckedChanged;
            // 
            // Button_ScanCard
            // 
            Button_ScanCard.Cursor = Cursors.Hand;
            Button_ScanCard.Font = new Font("Segoe UI", 9F);
            Button_ScanCard.Location = new Point(6, 515);
            Button_ScanCard.Name = "Button_ScanCard";
            Button_ScanCard.Size = new Size(308, 60);
            Button_ScanCard.TabIndex = 9;
            Button_ScanCard.Text = "Scanare card";
            Button_ScanCard.UseVisualStyleBackColor = true;
            // 
            // Button_AdvancedSearch
            // 
            Button_AdvancedSearch.Location = new Point(6, 59);
            Button_AdvancedSearch.Name = "Button_AdvancedSearch";
            Button_AdvancedSearch.Size = new Size(306, 29);
            Button_AdvancedSearch.TabIndex = 8;
            Button_AdvancedSearch.Text = "Cautare avansata";
            Button_AdvancedSearch.UseVisualStyleBackColor = true;
            // 
            // Button_ShowAllMembers
            // 
            Button_ShowAllMembers.Cursor = Cursors.Hand;
            Button_ShowAllMembers.Font = new Font("Segoe UI", 9F);
            Button_ShowAllMembers.Location = new Point(6, 472);
            Button_ShowAllMembers.Name = "Button_ShowAllMembers";
            Button_ShowAllMembers.Size = new Size(308, 37);
            Button_ShowAllMembers.TabIndex = 7;
            Button_ShowAllMembers.Text = "Afiseaza toti membrii";
            Button_ShowAllMembers.UseVisualStyleBackColor = true;
            Button_ShowAllMembers.Click += Button_ShowAllMembers_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            SearchTextBox.Cursor = Cursors.IBeam;
            SearchTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            SearchTextBox.Location = new Point(6, 26);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(306, 27);
            SearchTextBox.TabIndex = 3;
            SearchTextBox.Text = " Cautare...";
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            SearchTextBox.Enter += SearchTextBox_Enter;
            SearchTextBox.Leave += SearchTextBox_Leave;
            // 
            // Button_Delete
            // 
            Button_Delete.Location = new Point(162, 581);
            Button_Delete.Name = "Button_Delete";
            Button_Delete.Size = new Size(150, 37);
            Button_Delete.TabIndex = 2;
            Button_Delete.Text = "Sterge";
            Button_Delete.UseVisualStyleBackColor = true;
            // 
            // Button_Edit
            // 
            Button_Edit.Location = new Point(6, 581);
            Button_Edit.Name = "Button_Edit";
            Button_Edit.Size = new Size(150, 37);
            Button_Edit.TabIndex = 1;
            Button_Edit.Text = "Editeaza";
            Button_Edit.UseVisualStyleBackColor = true;
            // 
            // Button_AddNew
            // 
            Button_AddNew.Font = new Font("Segoe UI", 9F);
            Button_AddNew.Location = new Point(6, 624);
            Button_AddNew.Name = "Button_AddNew";
            Button_AddNew.Size = new Size(308, 37);
            Button_AddNew.TabIndex = 0;
            Button_AddNew.Text = "Adauga membru nou";
            Button_AddNew.UseVisualStyleBackColor = true;
            // 
            // MainListView
            // 
            MainListView.Columns.AddRange(new ColumnHeader[] { IDColumnHeader });
            MainListView.Location = new Point(327, 10);
            MainListView.Name = "MainListView";
            MainListView.Size = new Size(923, 660);
            MainListView.TabIndex = 1;
            MainListView.UseCompatibleStateImageBehavior = false;
            // 
            // IDColumnHeader
            // 
            IDColumnHeader.Text = "ID";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(MainListView);
            Controls.Add(ControlsGroupBox);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ControlsGroupBox.ResumeLayout(false);
            ControlsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ControlsGroupBox;
        private ListView MainListView;
        private Button Button_AddNew;
        private Button Button_Delete;
        private Button Button_Edit;
        private TextBox SearchTextBox;
        private Button Button_ShowAllMembers;
        private Button Button_AdvancedSearch;
        private ColumnHeader IDColumnHeader;
        private Button Button_ScanCard;
        private CheckBox Checkbox_ActiveMembersOnly;
    }
}
