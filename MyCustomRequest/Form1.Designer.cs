namespace MyCustomRequest
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GetErrors = new System.Windows.Forms.Button();
            this.Categories = new System.Windows.Forms.Button();
            this.MakeJson = new System.Windows.Forms.Button();
            this.ShowCategories = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MakeAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(697, 526);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 37);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("Candara Light", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(284, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тестовое задание";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // GetErrors
            // 
            this.GetErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GetErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.GetErrors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetErrors.Location = new System.Drawing.Point(40, 43);
            this.GetErrors.Name = "GetErrors";
            this.GetErrors.Size = new System.Drawing.Size(121, 23);
            this.GetErrors.TabIndex = 3;
            this.GetErrors.Text = "Get Errors";
            this.GetErrors.UseVisualStyleBackColor = false;
            this.GetErrors.Click += new System.EventHandler(this.GetErrors_Click);
            // 
            // Categories
            // 
            this.Categories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Categories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.Categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Categories.Location = new System.Drawing.Point(235, 43);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(121, 23);
            this.Categories.TabIndex = 4;
            this.Categories.Text = "Get Categories";
            this.Categories.UseVisualStyleBackColor = false;
            this.Categories.Click += new System.EventHandler(this.Categories_Click);
            // 
            // MakeJson
            // 
            this.MakeJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MakeJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.MakeJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeJson.Location = new System.Drawing.Point(439, 43);
            this.MakeJson.Name = "MakeJson";
            this.MakeJson.Size = new System.Drawing.Size(121, 23);
            this.MakeJson.TabIndex = 5;
            this.MakeJson.Text = "Make Json";
            this.MakeJson.UseVisualStyleBackColor = false;
            this.MakeJson.Click += new System.EventHandler(this.MakeJson_Click);
            // 
            // ShowCategories
            // 
            this.ShowCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.ShowCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowCategories.Location = new System.Drawing.Point(335, 72);
            this.ShowCategories.Name = "ShowCategories";
            this.ShowCategories.Size = new System.Drawing.Size(121, 23);
            this.ShowCategories.TabIndex = 6;
            this.ShowCategories.Text = "Show Categories";
            this.ShowCategories.UseVisualStyleBackColor = false;
            this.ShowCategories.Click += new System.EventHandler(this.ShowCategories_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 123);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(784, 397);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // MakeAll
            // 
            this.MakeAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MakeAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.MakeAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeAll.Location = new System.Drawing.Point(624, 43);
            this.MakeAll.Name = "MakeAll";
            this.MakeAll.Size = new System.Drawing.Size(121, 23);
            this.MakeAll.TabIndex = 9;
            this.MakeAll.Text = "Make All";
            this.MakeAll.UseVisualStyleBackColor = false;
            this.MakeAll.Click += new System.EventHandler(this.MakeAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MakeAll);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ShowCategories);
            this.Controls.Add(this.MakeJson);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.GetErrors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Test program";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetErrors;
        private System.Windows.Forms.Button Categories;
        private System.Windows.Forms.Button MakeJson;
        private System.Windows.Forms.Button ShowCategories;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button MakeAll;
    }
}

