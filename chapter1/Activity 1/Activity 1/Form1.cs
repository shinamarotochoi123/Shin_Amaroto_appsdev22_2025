namespace FoodPickerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] foodGenre = { "Filipino", "Korean", "Chinese", "Italian" };
            foodCuisine.Items.AddRange(foodGenre);

            foodCuisine.DropDownStyle = ComboBoxStyle.DropDownList;
            foodCuisine.SelectedIndex = 0;
            checkedListBox1.CheckOnClick = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            string[] filipinoCuisineList = { "Pancit Canton", "Sisig", "Lumpia", "Sinigang", "Taho" };
            string[] chineseCuisineList = { "Tofu", "Udon", "Dumpling", "Kung pao chicken" };
            string[] koreanCuisineList = { "Kimchi", "Seaweed soup", "Japchae" };
            string[] italianCuisineList = { "Pasta", "Pizza", "Ravioli", "Lasagna" };

            checkedListBox1.Items.Clear();

            if (foodCuisine.SelectedItem != null)
            {
                string selectedCuisine = foodCuisine.SelectedItem.ToString();

                if (selectedCuisine.Contains("Filipino"))
                {
                    checkedListBox1.Items.AddRange(filipinoCuisineList);
                }
                else if (selectedCuisine.Contains("Chinese"))
                {
                    checkedListBox1.Items.AddRange(chineseCuisineList);
                }
                else if (selectedCuisine.Contains("Korean"))
                {
                    checkedListBox1.Items.AddRange(koreanCuisineList);
                }
                else if (selectedCuisine.Contains("Italian"))
                {
                    checkedListBox1.Items.AddRange(italianCuisineList);
                }
            }
            else
            {
                MessageBox.Show("Select a Cuisine.");
            }
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) 
            {
                listBox1.Items.Remove(listBox1.SelectedItem); 
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            foreach (var item in checkedListBox1.CheckedItems)
            {
                if (!listBox1.Items.Contains(item))
                {
                    listBox1.Items.Add(item);
                }
            }
        }
 
        private void clearBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }

}
