namespace PR3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            TypesOfProducts = new Label();
            label1 = new Label();
            panel2 = new Panel();
            TypeOfPartners = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(TypesOfProducts);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 550);
            panel1.TabIndex = 0;
            // 
            // TypesOfProducts
            // 
            TypesOfProducts.AutoSize = true;
            TypesOfProducts.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TypesOfProducts.Location = new Point(12, 82);
            TypesOfProducts.Name = "TypesOfProducts";
            TypesOfProducts.Size = new Size(0, 23);
            TypesOfProducts.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 0;
            label1.Text = "Типы продукции";
            // 
            // panel2
            // 
            panel2.Controls.Add(TypeOfPartners);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(427, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(439, 550);
            panel2.TabIndex = 1;
            // 
            // TypeOfPartners
            // 
            TypeOfPartners.AutoSize = true;
            TypeOfPartners.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TypeOfPartners.Location = new Point(24, 82);
            TypeOfPartners.Name = "TypeOfPartners";
            TypeOfPartners.Size = new Size(0, 23);
            TypeOfPartners.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(8, 20);
            label2.Name = "label2";
            label2.Size = new Size(152, 23);
            label2.TabIndex = 0;
            label2.Text = "Типы партнеров";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 550);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label TypesOfProducts;
        private Label TypeOfPartners;
    }
}
