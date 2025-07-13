namespace ProjectStaj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.MaximizeBox = false; 
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            var suggestions = new AutoCompleteStringCollection();
            suggestions.AddRange(new string[]
            {
        "Златен морков",
        "Бутилка с вода",
        "Око на паяк",
        "Заешка лапа",
        "Огнена прах",
        "Адска ягода",
        "Прах от блейз"
            });

            txtIngredient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtIngredient.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtIngredient.AutoCompleteCustomSource = suggestions;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string ingredient = txtIngredient.Text.Trim();

            if (!string.IsNullOrEmpty(ingredient))
            {
                lstIngredients.Items.Add(ingredient);
                txtIngredient.Clear();
                txtIngredient.Focus();
            }
            else
            {
                MessageBox.Show("Моля, въведи съставка!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private bool brewClicked = false;
        private void btnBrew_Click(object sender, EventArgs e)
        {
            if (brewClicked) return;

            brewClicked = true;

            if (lstIngredients.Items.Count == 0)
            {
                MessageBox.Show("Няма съставки за сваряване!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                brewClicked = false;
                return;
            }

            List<string> ingredients = lstIngredients.Items.Cast<string>().ToList();
            List<string> lowerIngredients = ingredients.Select(i => i.ToLower()).ToList();

            string result = "";

            if (lowerIngredients.Contains("златен морков") && lowerIngredients.Contains("бутилка с вода") && lowerIngredients.Contains("око на паяк"))
                result = "Ти изчезна! Само обувките ти се виждат... Надявам се да не си гол!";
            else if (lowerIngredients.Contains("заешка лапа") && lowerIngredients.Contains("бутилка с вода") && lowerIngredients.Contains("огнена прах"))
                result = "ПОДСКОК! Вече можеш да влезеш през прозореца, вместо през вратата!";
            else if (lowerIngredients.Contains("адска ягода") && lowerIngredients.Contains("бутилка с вода") && lowerIngredients.Contains("прах от блейз"))
                result = "Суперсила активирана! Можеш да счупиш планини... или поне да накараш баба да се срамува от твоите 'мускули'. Хълк чака твоето предизвикателство!";


            else
            {
                string[] funnyFails = new string[]
                {
            "Бълбука, но изглежда имаш нужда от по-добра рецепта...",
            "Отварата ти прилича повече на супа, отколкото на еликсир.",
            "Това е... просто топла вода. Опитай пак!",
            "Магията не е твоята сила днес.",
            "Нищо интересно, но поне опита е важен!"
                };

                Random rnd = new Random();
                int index = rnd.Next(funnyFails.Length);
                result = funnyFails[index];
            }

            MessageBox.Show(result, "Отвара", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lstIngredients.Items.Clear();

            brewClicked = false;

        }

        private void btnRecipes_Click(object sender, EventArgs e)
        {
            RecipesForm recipesForm = new RecipesForm();
            recipesForm.Show(); 
        }
    }
}
