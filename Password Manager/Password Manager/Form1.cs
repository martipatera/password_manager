namespace Password_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PasswordStorage.LoadFromFile(); // Naète hesla ze souboru
            PasswordStorage.DisplayPasswords(PasswordGrid); // Zobrazí hesla v DataGridView
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            PanelManager.HidePanel(MainMenuPanel);
            PanelManager.ShowPanel(QuitPanel);
        }

        private void MyPasswordsBtn_Click(object sender, EventArgs e)
        {
            PanelManager.HidePanel(MainMenuPanel);
            PanelManager.ShowPanel(MyPasswordsPanel);
        }

        private void GeneratePasswordBtn_Click(object sender, EventArgs e)
        {
            PanelManager.HidePanel(MainMenuPanel);
            PanelManager.ShowPanel(GeneratePasswordPanel);
        }
        private void YesBtn_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            PanelManager.HidePanel(QuitPanel);
            PanelManager.ShowPanel(MainMenuPanel);
        }

        private void PasswordTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            PanelManager.HidePanel(GeneratePasswordPanel);
            PanelManager.ShowPanel(MainMenuPanel);
        }

        private void PasswordLengthLabel_Click(object sender, EventArgs e)
        {

        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            PasswordManagerClass.PasswordManager(CharsNumsRadBtn, CharsNumsSymRadBtn, PasswordLengthBtn, PasswordTextBox, PasswordNameTextBox);
            PasswordStorage.DisplayPasswords(PasswordGrid);
        }

        private void PasswordNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordLengthBtn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CharsNumsSymRadBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CharsNumsRadBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BackMainMenuBtn_Click(object sender, EventArgs e)
        {
            PanelManager.HidePanel(MyPasswordsPanel);
            PanelManager.ShowPanel(MainMenuPanel);
        }

        private void DeletePasswordBtn_Click(object sender, EventArgs e)
        {

        }

        private void PasswordGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Resetuje DataGridView a zobrazí hesla ze storage
            PasswordGrid.DataSource = null; // Odstraní starý zdroj dat
            PasswordGrid.DataSource = PasswordStorage.GetPasswords(); // Nastaví nový zdroj dat

        }

        private void SavePasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordManagerClass.SavePassword(PasswordNameTextBox, PasswordTextBox); // Uloží heslo a vyèistí TextBoxy
            PasswordStorage.DisplayPasswords(PasswordGrid);
        }
    }
}
