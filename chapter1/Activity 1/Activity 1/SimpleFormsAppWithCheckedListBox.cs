using System.Windows.Forms;

namespace MoviePickerCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] movie = { "The Simpsons", "Rick and Morty", "Squid Game", "Venom" };
            txtBox.Items.AddRange(movie);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
           
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
 
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            foreach (var movie in txtBox.Items)
            {
                bool isSelected = txtBox.GetItemChecked(txtBox.Items.IndexOf(movie));
                if (isSelected && !listBox.Items.Contains(movie))
                {
                    {
                        listBox.Items.Add(movie);
                    }
                }
            }
        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            if (listBox.Items.Count >= 1)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }
        }

        private void clearBtn_Click_1(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
    