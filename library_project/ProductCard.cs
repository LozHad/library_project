namespace library_project
{
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }

        public void FillData(string author, string name, string genre, string publisher, int totalPairs, Image productImages)
        {
            lblHeader.Text = $"{author} | {name}";

            lblGenre.Text = $"Жанр: {genre}";
            lblPublisher.Text = $"Издатель: {publisher}";

            if (totalPairs > 5)
            {
                lblQuantity.Text = "Количество: много";
            }
            else
            {
                lblQuantity.Text = "Количество: мало";
            }

            if (productImages != null)
            {
                pbImage.Image = productImages;
            }
            else
            {
                pbImage.Image = Properties.Resources.picture;
            }

            if (totalPairs <= 3)
            {
                this.BackColor = Color.FromArgb(255, 220, 220);
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
