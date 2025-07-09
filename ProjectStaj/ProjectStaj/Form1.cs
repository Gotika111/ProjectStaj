namespace ProjectStaj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            var suggestions = new AutoCompleteStringCollection();
            suggestions.AddRange(new string[]
            {
        "Златен морков",
        "Бутилка с вода",
        "Око на паяк",
        //"Драконова кръв",
        //"Експлозивна смола"
            });

            txtIngredient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtIngredient.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtIngredient.AutoCompleteCustomSource = suggestions;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // За btnAdd_Click
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

        private void btnBrew_Click(object sender, EventArgs e)
        {

            if (lstIngredients.Items.Count == 0)
            {
                MessageBox.Show("Няма съставки за сваряване!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<string> ingredients = lstIngredients.Items.Cast<string>().ToList();

            string result = "";

            // Преобразуваме всички съставки в малки букви за по-лесно сравнение
            List<string> lowerIngredients = ingredients.Select(i => i.ToLower()).ToList();

            if (lowerIngredients.Contains("златен морков") && lowerIngredients.Contains("бутилка с вода") && lowerIngredients.Contains("око на паяк"))
                result = "Създаде невидимост за 10 минути!";
            //else if (lowerIngredients.Contains("драконова кръв") && lowerIngredients.Contains("експлозивна смола"))
            //    result = "Създаде експлозивен серум… стой далеч!";
            else
                result = "Бълбука, но нищо интересно не стана.";

            // ❗ Тук добавяш липсващия MessageBox:
            MessageBox.Show(result, "Резултат", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ❗ И изчистване на списъка след сваряване:
            lstIngredients.Items.Clear();

        }

        private void btnRecipes_Click(object sender, EventArgs e)
        {
            RecipesForm recipesForm = new RecipesForm();
            recipesForm.Show(); 
        }
    }
}
