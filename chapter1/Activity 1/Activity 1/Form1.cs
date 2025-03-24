namespace CartoonImageFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] selectanitem = { "peter", "lois", "meg", "stewie" };
            comboBox1.Items.AddRange(selectanitem);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] selectedItems = { "peter", "lois", "meg", "stewie" };
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(selectedItems);

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            switch (selectedItem)

            {
                case "peter":
                    pictureBox1.Image = Image.FromFile("@C:\\Users\\PC\\Downloads\\family guy\\peter.jpg");
                    break;
                case "lois":
                    pictureBox1.Image = Image.FromFile("@C:\\Users\\PC\\Downloads\\family guy\\lois.jpg");
                    break;
                case "meg":
                    pictureBox1.Image = Image.FromFile("@C:\\Users\\PC\\Downloads\\family guy\\meg.jpg");
                    break;
                case "stewie":
                    pictureBox1.Image = Image.FromFile("C:\\Users\\PC\\Downloads\\family guy\\stewie.jpg");
                    break;

                default:
                    pictureBox1.Image = null;
                    break;
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }
    }

