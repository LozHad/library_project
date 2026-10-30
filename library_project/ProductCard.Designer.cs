namespace library_project
{
    partial class ProductCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPublisher = new Label();
            lblQuantity = new Label();
            lblGenre = new Label();
            lblHeader = new Label();
            pbImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // lblPublisher
            // 
            lblPublisher.Font = new Font("Calibri", 12F);
            lblPublisher.Location = new Point(150, 99);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(634, 22);
            lblPublisher.TabIndex = 10;
            lblPublisher.Text = "label1";
            // 
            // lblQuantity
            // 
            lblQuantity.Font = new Font("Calibri", 12F);
            lblQuantity.Location = new Point(150, 73);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(634, 22);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "label1";
            // 
            // lblGenre
            // 
            lblGenre.Font = new Font("Calibri", 12F);
            lblGenre.Location = new Point(150, 47);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(634, 22);
            lblGenre.TabIndex = 8;
            lblGenre.Text = "label1";
            // 
            // lblHeader
            // 
            lblHeader.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblHeader.Location = new Point(159, 13);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(625, 34);
            lblHeader.TabIndex = 7;
            lblHeader.Text = "label1";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(14, 14);
            pbImage.Margin = new Padding(3, 4, 3, 4);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(120, 120);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 6;
            pbImage.TabStop = false;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPublisher);
            Controls.Add(lblQuantity);
            Controls.Add(lblGenre);
            Controls.Add(lblHeader);
            Controls.Add(pbImage);
            Name = "ProductCard";
            Size = new Size(795, 150);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblPublisher;
        private Label lblQuantity;
        private Label lblGenre;
        private Label lblHeader;
        private PictureBox pbImage;
    }
}
