namespace library_project
{
    partial class FormProducts
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanelProducts = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.Dock = DockStyle.Fill;
            flowLayoutPanelProducts.Location = new Point(0, 0);
            flowLayoutPanelProducts.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(834, 561);
            flowLayoutPanelProducts.TabIndex = 1;
            // 
            // FormProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 561);
            Controls.Add(flowLayoutPanelProducts);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список книг";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelProducts;
    }
}