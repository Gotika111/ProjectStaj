namespace ProjectStaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAdd = new Button();
            btnBrew = new Button();
            txtIngredient = new TextBox();
            lstIngredients = new ListBox();
            btnRecipes = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 20F);
            btnAdd.Location = new Point(206, 158);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(497, 106);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Добави съставка";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBrew
            // 
            btnBrew.Font = new Font("Segoe UI", 20F);
            btnBrew.Location = new Point(206, 491);
            btnBrew.Name = "btnBrew";
            btnBrew.Size = new Size(497, 132);
            btnBrew.TabIndex = 1;
            btnBrew.Text = "Свари отварата";
            btnBrew.UseVisualStyleBackColor = true;
            btnBrew.Click += btnBrew_Click;
            // 
            // txtIngredient
            // 
            txtIngredient.Font = new Font("Segoe UI", 25F);
            txtIngredient.Location = new Point(776, 167);
            txtIngredient.Name = "txtIngredient";
            txtIngredient.Size = new Size(658, 63);
            txtIngredient.TabIndex = 2;
            // 
            // lstIngredients
            // 
            lstIngredients.Font = new Font("Segoe UI", 25F);
            lstIngredients.FormattingEnabled = true;
            lstIngredients.ItemHeight = 57;
            lstIngredients.Location = new Point(786, 249);
            lstIngredients.Name = "lstIngredients";
            lstIngredients.Size = new Size(648, 346);
            lstIngredients.TabIndex = 3;
            // 
            // btnRecipes
            // 
            btnRecipes.Font = new Font("Segoe UI", 20F);
            btnRecipes.Location = new Point(206, 298);
            btnRecipes.Name = "btnRecipes";
            btnRecipes.Size = new Size(497, 157);
            btnRecipes.TabIndex = 4;
            btnRecipes.Text = "Рецепти";
            btnRecipes.UseVisualStyleBackColor = true;
            btnRecipes.Click += btnRecipes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1631, 895);
            Controls.Add(btnRecipes);
            Controls.Add(lstIngredients);
            Controls.Add(txtIngredient);
            Controls.Add(btnBrew);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnBrew;
        private TextBox txtIngredient;
        private ListBox lstIngredients;
        private Button btnRecipes;
    }
}
