namespace ProjectStaj
{
    partial class RecipesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipesForm));
            picPotion1 = new PictureBox();
            lblPotion1 = new Label();
            lblPotionInfo = new Label();
            btnBack1 = new Button();
            btnShow1 = new Button();
            ((System.ComponentModel.ISupportInitialize)picPotion1).BeginInit();
            SuspendLayout();
            // 
            // picPotion1
            // 
            picPotion1.BackColor = Color.Transparent;
            picPotion1.BackgroundImage = (Image)resources.GetObject("picPotion1.BackgroundImage");
            picPotion1.Location = new Point(1072, 300);
            picPotion1.Name = "picPotion1";
            picPotion1.Size = new Size(397, 360);
            picPotion1.SizeMode = PictureBoxSizeMode.Zoom;
            picPotion1.TabIndex = 0;
            picPotion1.TabStop = false;
            // 
            // lblPotion1
            // 
            lblPotion1.AutoSize = true;
            lblPotion1.BackColor = Color.Transparent;
            lblPotion1.Font = new Font("Segoe UI", 15F);
            lblPotion1.Location = new Point(485, 190);
            lblPotion1.Name = "lblPotion1";
            lblPotion1.Size = new Size(158, 35);
            lblPotion1.TabIndex = 1;
            lblPotion1.Text = "Невидимост";
            lblPotion1.Click += lblPotion1_Click;
            // 
            // lblPotionInfo
            // 
            lblPotionInfo.AutoSize = true;
            lblPotionInfo.BackColor = Color.Transparent;
            lblPotionInfo.Font = new Font("Segoe UI", 13F);
            lblPotionInfo.Location = new Point(428, 318);
            lblPotionInfo.Name = "lblPotionInfo";
            lblPotionInfo.Size = new Size(486, 270);
            lblPotionInfo.TabIndex = 2;
            lblPotionInfo.Text = resources.GetString("lblPotionInfo.Text");
            lblPotionInfo.Click += lblPotionInfo_Click;
            // 
            // btnBack1
            // 
            btnBack1.Location = new Point(591, 783);
            btnBack1.Name = "btnBack1";
            btnBack1.Size = new Size(94, 29);
            btnBack1.TabIndex = 3;
            btnBack1.Text = "Назад";
            btnBack1.UseVisualStyleBackColor = true;
            btnBack1.Click += btnBack1_Click;
            // 
            // btnShow1
            // 
            btnShow1.Location = new Point(748, 190);
            btnShow1.Name = "btnShow1";
            btnShow1.Size = new Size(123, 44);
            btnShow1.TabIndex = 4;
            btnShow1.Text = "Покажи";
            btnShow1.UseVisualStyleBackColor = true;
            btnShow1.Click += btnShow1_Click;
            // 
            // RecipesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnShow1);
            Controls.Add(btnBack1);
            Controls.Add(lblPotionInfo);
            Controls.Add(lblPotion1);
            Controls.Add(picPotion1);
            Name = "RecipesForm";
            Text = "RecipesForm";
            Load += RecipesForm_Load;
            ((System.ComponentModel.ISupportInitialize)picPotion1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picPotion1;
        private Label lblPotion1;
        private Label lblPotionInfo;
        private Button btnBack1;
        private Button btnShow1;
    }
}