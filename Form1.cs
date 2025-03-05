namespace SimpleFormMessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Submit Information?",
                "Confirmation", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
            }

            {
                string fNameValue = firstName.Text;
                string mNameValue = middleName.Text;
                string lNameValue = lastName.Text;
                string suffixValue = suffix.Text;
                MessageBox.Show($"Hello there! {fNameValue} {mNameValue} {lNameValue} {suffixValue}", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}