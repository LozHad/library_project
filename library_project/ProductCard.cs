namespace library_project
{
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }

        public void FillData(string ISBN, string author, string name, string genre, string publisher, int year, int lists, int totalPairs, int avaliablePairs, bool loan, Image productImages)
        {
            lblHeader.Text = $"{author} | {name} | {genre}";

            lblLists.Text = $"Количество страниц: {lists}";
            lblPublisher.Text = $"Издатель: {publisher}, {year} ({ISBN})";
            lblQuantity.Text = $"Доступное количество: {avaliablePairs}, общее количество: {totalPairs}";

            if (productImages != null)
            {
                pbImage.Image = productImages;
            }
            else
            {
                pbImage.Image = Properties.Resources.picture;
            }

            if (avaliablePairs <= 2 && avaliablePairs > 1)
            {
                this.BackColor = ColorTranslator.FromHtml("#FFF3CD");
            }
            else if(avaliablePairs == 0){
                this.BackColor = ColorTranslator.FromHtml("#FFCCCC");
            }
            else
            {
                this.BackColor = Color.White;
            }

            if (loan == true)
            {
                this.BackColor = ColorTranslator.FromHtml("#D4EDDA");
            }
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
