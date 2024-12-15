namespace Password_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MainMenuPanel = new Panel();
            PasswordManagerLabel = new Label();
            QuitBtn = new Button();
            MyPasswordsBtn = new Button();
            GeneratePasswordBtn = new Button();
            QuitPanel = new Panel();
            NoBtn = new Button();
            QuitLabel = new Label();
            YesBtn = new Button();
            GeneratePasswordPanel = new Panel();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            GenerateBtn = new Button();
            PasswordLengthBtn = new NumericUpDown();
            PasswordLengthLabel = new Label();
            PasswordTypeLabel = new Label();
            CharsNumsSymRadBtn = new RadioButton();
            CharsNumsRadBtn = new RadioButton();
            MainMenuBtn = new Button();
            PasswordNameLabel = new Label();
            PasswordNameTextBox = new TextBox();
            MainMenuPanel.SuspendLayout();
            QuitPanel.SuspendLayout();
            GeneratePasswordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PasswordLengthBtn).BeginInit();
            SuspendLayout();
            // 
            // MainMenuPanel
            // 
            MainMenuPanel.Controls.Add(PasswordManagerLabel);
            MainMenuPanel.Controls.Add(QuitBtn);
            MainMenuPanel.Controls.Add(MyPasswordsBtn);
            MainMenuPanel.Controls.Add(GeneratePasswordBtn);
            MainMenuPanel.Location = new Point(0, 0);
            MainMenuPanel.Name = "MainMenuPanel";
            MainMenuPanel.Size = new Size(799, 449);
            MainMenuPanel.TabIndex = 0;
            // 
            // PasswordManagerLabel
            // 
            PasswordManagerLabel.AutoSize = true;
            PasswordManagerLabel.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            PasswordManagerLabel.Location = new Point(252, 43);
            PasswordManagerLabel.Name = "PasswordManagerLabel";
            PasswordManagerLabel.Size = new Size(319, 47);
            PasswordManagerLabel.TabIndex = 3;
            PasswordManagerLabel.Text = "Password Manager";
            // 
            // QuitBtn
            // 
            QuitBtn.Location = new Point(318, 298);
            QuitBtn.Name = "QuitBtn";
            QuitBtn.Size = new Size(193, 64);
            QuitBtn.TabIndex = 2;
            QuitBtn.Text = "Quit";
            QuitBtn.UseVisualStyleBackColor = true;
            QuitBtn.Click += QuitBtn_Click;
            // 
            // MyPasswordsBtn
            // 
            MyPasswordsBtn.Location = new Point(318, 210);
            MyPasswordsBtn.Name = "MyPasswordsBtn";
            MyPasswordsBtn.Size = new Size(193, 64);
            MyPasswordsBtn.TabIndex = 1;
            MyPasswordsBtn.Text = "My Passwords";
            MyPasswordsBtn.UseVisualStyleBackColor = true;
            MyPasswordsBtn.Click += MyPasswordsBtn_Click;
            // 
            // GeneratePasswordBtn
            // 
            GeneratePasswordBtn.Location = new Point(318, 122);
            GeneratePasswordBtn.Name = "GeneratePasswordBtn";
            GeneratePasswordBtn.Size = new Size(193, 64);
            GeneratePasswordBtn.TabIndex = 0;
            GeneratePasswordBtn.Text = "Generate Password";
            GeneratePasswordBtn.UseVisualStyleBackColor = true;
            GeneratePasswordBtn.Click += GeneratePasswordBtn_Click;
            // 
            // QuitPanel
            // 
            QuitPanel.Controls.Add(NoBtn);
            QuitPanel.Controls.Add(QuitLabel);
            QuitPanel.Controls.Add(YesBtn);
            QuitPanel.Location = new Point(0, 0);
            QuitPanel.Name = "QuitPanel";
            QuitPanel.Size = new Size(799, 453);
            QuitPanel.TabIndex = 1;
            QuitPanel.Visible = false;
            // 
            // NoBtn
            // 
            NoBtn.Location = new Point(470, 210);
            NoBtn.Name = "NoBtn";
            NoBtn.Size = new Size(153, 44);
            NoBtn.TabIndex = 2;
            NoBtn.Text = "No";
            NoBtn.UseVisualStyleBackColor = true;
            NoBtn.Click += NoBtn_Click;
            // 
            // QuitLabel
            // 
            QuitLabel.AutoSize = true;
            QuitLabel.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            QuitLabel.Location = new Point(185, 106);
            QuitLabel.Name = "QuitLabel";
            QuitLabel.Size = new Size(471, 47);
            QuitLabel.TabIndex = 1;
            QuitLabel.Text = "Are you sure u want to quit?";
            // 
            // YesBtn
            // 
            YesBtn.Location = new Point(234, 210);
            YesBtn.Name = "YesBtn";
            YesBtn.Size = new Size(153, 44);
            YesBtn.TabIndex = 0;
            YesBtn.Text = "Yes";
            YesBtn.UseVisualStyleBackColor = true;
            YesBtn.Click += YesBtn_Click;
            // 
            // GeneratePasswordPanel
            // 
            GeneratePasswordPanel.Controls.Add(PasswordLabel);
            GeneratePasswordPanel.Controls.Add(PasswordTextBox);
            GeneratePasswordPanel.Controls.Add(GenerateBtn);
            GeneratePasswordPanel.Controls.Add(PasswordLengthBtn);
            GeneratePasswordPanel.Controls.Add(PasswordLengthLabel);
            GeneratePasswordPanel.Controls.Add(PasswordTypeLabel);
            GeneratePasswordPanel.Controls.Add(CharsNumsSymRadBtn);
            GeneratePasswordPanel.Controls.Add(CharsNumsRadBtn);
            GeneratePasswordPanel.Controls.Add(MainMenuBtn);
            GeneratePasswordPanel.Controls.Add(PasswordNameLabel);
            GeneratePasswordPanel.Controls.Add(PasswordNameTextBox);
            GeneratePasswordPanel.Location = new Point(0, 0);
            GeneratePasswordPanel.Name = "GeneratePasswordPanel";
            GeneratePasswordPanel.Size = new Size(799, 453);
            GeneratePasswordPanel.TabIndex = 3;
            GeneratePasswordPanel.Visible = false;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(274, 262);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(87, 15);
            PasswordLabel.TabIndex = 11;
            PasswordLabel.Text = "Your password:";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(274, 280);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.ReadOnly = true;
            PasswordTextBox.Size = new Size(304, 23);
            PasswordTextBox.TabIndex = 10;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // GenerateBtn
            // 
            GenerateBtn.Location = new Point(444, 348);
            GenerateBtn.Name = "GenerateBtn";
            GenerateBtn.Size = new Size(154, 39);
            GenerateBtn.TabIndex = 9;
            GenerateBtn.Text = "Generate";
            GenerateBtn.UseVisualStyleBackColor = true;
            GenerateBtn.Click += GenerateBtn_Click;
            // 
            // PasswordLengthBtn
            // 
            PasswordLengthBtn.Location = new Point(458, 130);
            PasswordLengthBtn.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            PasswordLengthBtn.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            PasswordLengthBtn.Name = "PasswordLengthBtn";
            PasswordLengthBtn.Size = new Size(120, 23);
            PasswordLengthBtn.TabIndex = 8;
            PasswordLengthBtn.Value = new decimal(new int[] { 8, 0, 0, 0 });
            PasswordLengthBtn.ValueChanged += PasswordLengthBtn_ValueChanged;
            // 
            // PasswordLengthLabel
            // 
            PasswordLengthLabel.AutoSize = true;
            PasswordLengthLabel.Location = new Point(458, 106);
            PasswordLengthLabel.Name = "PasswordLengthLabel";
            PasswordLengthLabel.Size = new Size(140, 15);
            PasswordLengthLabel.TabIndex = 7;
            PasswordLengthLabel.Text = "Password Length: (8 - 32)";
            PasswordLengthLabel.Click += PasswordLengthLabel_Click;
            // 
            // PasswordTypeLabel
            // 
            PasswordTypeLabel.AutoSize = true;
            PasswordTypeLabel.Location = new Point(185, 106);
            PasswordTypeLabel.Name = "PasswordTypeLabel";
            PasswordTypeLabel.Size = new Size(86, 15);
            PasswordTypeLabel.TabIndex = 6;
            PasswordTypeLabel.Text = "Password type:";
            PasswordTypeLabel.Click += PasswordTypeLabel_Click;
            // 
            // CharsNumsSymRadBtn
            // 
            CharsNumsSymRadBtn.AutoSize = true;
            CharsNumsSymRadBtn.Location = new Point(185, 167);
            CharsNumsSymRadBtn.Name = "CharsNumsSymRadBtn";
            CharsNumsSymRadBtn.Size = new Size(187, 19);
            CharsNumsSymRadBtn.TabIndex = 5;
            CharsNumsSymRadBtn.TabStop = true;
            CharsNumsSymRadBtn.Text = "Characters, Numbers, Symbols";
            CharsNumsSymRadBtn.UseVisualStyleBackColor = true;
            CharsNumsSymRadBtn.CheckedChanged += CharsNumsSymRadBtn_CheckedChanged;
            // 
            // CharsNumsRadBtn
            // 
            CharsNumsRadBtn.AutoSize = true;
            CharsNumsRadBtn.Location = new Point(185, 142);
            CharsNumsRadBtn.Name = "CharsNumsRadBtn";
            CharsNumsRadBtn.Size = new Size(156, 19);
            CharsNumsRadBtn.TabIndex = 4;
            CharsNumsRadBtn.TabStop = true;
            CharsNumsRadBtn.Text = "Characters and Numbers";
            CharsNumsRadBtn.UseVisualStyleBackColor = true;
            CharsNumsRadBtn.CheckedChanged += CharsNumsRadBtn_CheckedChanged;
            // 
            // MainMenuBtn
            // 
            MainMenuBtn.Location = new Point(185, 348);
            MainMenuBtn.Name = "MainMenuBtn";
            MainMenuBtn.Size = new Size(154, 39);
            MainMenuBtn.TabIndex = 3;
            MainMenuBtn.Text = "Main Menu";
            MainMenuBtn.UseVisualStyleBackColor = true;
            MainMenuBtn.Click += MainMenuBtn_Click;
            // 
            // PasswordNameLabel
            // 
            PasswordNameLabel.AutoSize = true;
            PasswordNameLabel.Location = new Point(274, 49);
            PasswordNameLabel.Name = "PasswordNameLabel";
            PasswordNameLabel.Size = new Size(128, 15);
            PasswordNameLabel.TabIndex = 2;
            PasswordNameLabel.Text = "Enter a passwod name:";
            // 
            // PasswordNameTextBox
            // 
            PasswordNameTextBox.Location = new Point(274, 67);
            PasswordNameTextBox.Name = "PasswordNameTextBox";
            PasswordNameTextBox.Size = new Size(203, 23);
            PasswordNameTextBox.TabIndex = 1;
            PasswordNameTextBox.TextChanged += PasswordNameTextBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GeneratePasswordPanel);
            Controls.Add(QuitPanel);
            Controls.Add(MainMenuPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Password Manager";
            Load += Form1_Load;
            MainMenuPanel.ResumeLayout(false);
            MainMenuPanel.PerformLayout();
            QuitPanel.ResumeLayout(false);
            QuitPanel.PerformLayout();
            GeneratePasswordPanel.ResumeLayout(false);
            GeneratePasswordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PasswordLengthBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainMenuPanel;
        private Button GeneratePasswordBtn;
        private Label PasswordManagerLabel;
        private Button QuitBtn;
        private Button MyPasswordsBtn;
        private Panel QuitPanel;
        private Button NoBtn;
        private Label QuitLabel;
        private Button YesBtn;
        private Panel GeneratePasswordPanel;
        private RadioButton CharsNumsSymRadBtn;
        private RadioButton CharsNumsRadBtn;
        private Button MainMenuBtn;
        private Label PasswordNameLabel;
        private TextBox PasswordNameTextBox;
        private Label PasswordTypeLabel;
        private NumericUpDown PasswordLengthBtn;
        private Label PasswordLengthLabel;
        private Button GenerateBtn;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
    }
}
