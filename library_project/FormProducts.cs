using library_project.Models;

namespace library_project
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
            this.Load += FormProducts_Load;
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            LoadCatalog();
            flowLayoutPanelProducts.Dock = DockStyle.Fill;
            flowLayoutPanelProducts.AutoScroll = true;
        }

        private void LoadCatalog()
        {
            flowLayoutPanelProducts.Controls.Clear();

            try
            {
                using (var db = new LibraryDbContext())
                {
                    var products = db.Books
                        .Select(b => new
                        {
                            Book = b,
                            GenreName = db.Genres.Where(g => g.Id == b.IdGenres).Select(g => g.Genre1).FirstOrDefault() ?? "Без жанра",
                            AuthorName = db.Authors.Where(a => a.Id == b.IdAuthor).Select(a => a.Author1).FirstOrDefault() ?? "Без автора",
                            PublisherName = db.Publishers.Where(pb => pb.Id == b.IdPublisher).Select(pb => pb.Publisher1).FirstOrDefault() ?? "Не указано"
                        })
                        .ToList();


                    foreach (var p in products)
                    {
                        ProductCard card = new ProductCard();

                        Image productImg = LoadProductImage(p.Book.Image);

                        card.FillData(
                            author: p.AuthorName,
                            name: p.Book.Name,
                            genre: p.GenreName,
                            publisher: p.PublisherName ?? "Не указано",
                            totalPairs: (int)p.Book.CopiesAvaliable,
                            productImages: productImg
                        );

                        flowLayoutPanelProducts.Controls.Add(card);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить каталог товаров: {ex.Message}", "Ошибка подключения к БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image LoadProductImage(string imageName)
        {
            if (string.IsNullOrWhiteSpace(imageName))
                return null;

            try
            {
                string imagesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
                string fullPath = Path.Combine(imagesFolder, imageName);

                if (File.Exists(fullPath))
                {
                    return Image.FromFile(fullPath);
                }
            }
            catch
            {
            }

            return null;
        }
    }
}
