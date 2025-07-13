using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;
using static System.Windows.Forms.Design.AxImporter;

namespace ProjectStaj
{
    public partial class RecipesForm : Form
    {

        private string potionInfoText = "";

        public RecipesForm()
        {
            InitializeComponent();

            lblPotion1.Paint += lblPotion1_Paint;
            lblPotion1.ForeColor = Color.White;
            lblPotion1.BackColor = Color.Transparent;

            lblPotionJump.Paint += lblPotion1_Paint;
            lblPotionJump.ForeColor = Color.White;
            lblPotionJump.BackColor = Color.Transparent;

            lblPotionName2.Paint += lblPotion1_Paint;
            lblPotionName2.ForeColor = Color.White;
            lblPotionName2.BackColor = Color.Transparent;

        }



        private void RecipesForm_Load(object sender, EventArgs e)
        {
            picPotion1.Visible = false;
            lblPotionInfo.Visible = false;
            btnBack1.Visible = false;

            lblPotionInfo.BackColor = Color.Transparent;
            lblPotionInfo.ForeColor = lblPotion1.ForeColor;


            picPotionJump.Visible = false;
            lblInfoJump.Visible = false;
            btnBackJump.Visible = false;

            picPotion2.Visible = false;
            lblPotionInfo2.Visible = false;
            btnBack2.Visible = false;

        }

        private void lblPotion1_Click(object sender, EventArgs e)
        {
            lblPotion1.Visible = false;

            lblPotionInfo.Visible = true;

            picPotion1.Image = Image.FromFile("images/invs.png");
            picPotion1.Visible = true;

            btnBack1.Visible = true;
        }

        private void lblPotionInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnBack1_Click(object sender, EventArgs e)
        {

            picPotion1.Visible = false;
            lblPotionInfo.Visible = false;
            lblPotionInfo.Text = "";
            lblPotionInfo.Invalidate();
            btnBack1.Visible = false;

            lblPotion1.Visible = true;
            btnShow1.Visible = true;
            lblPotion1.Text = "Невидимост";

            lblPotionJump.Visible = true;
            btnShowJump.Visible = true;

            lblPotionName2.Visible = true;
            btnShow2.Visible = true;

            labelMagic.Visible = true;
            labelMagic2.Visible = true;

        }

        private void btnShow1_Click(object sender, EventArgs e)
        {
            picPotion1.Visible = true;
            lblPotionInfo.Visible = true;
            btnBack1.Visible = true;

            lblPotion1.Visible = false;
            btnShow1.Visible = false;

            lblPotionJump.Visible = false;
            btnShowJump.Visible = false;

            lblPotionName2.Visible = false;
            btnShow2.Visible = false;

            labelMagic.Visible = false;
            labelMagic2.Visible = false;

            potionInfoText = "Отвара за Невидимост\n\n" +
                "Ефект:\n" +
                "    Ставаш невидим за 10 минути.\n\n" +
                "Рецепта:\n" +
                "    - Златен морков\n" +
                "    - Бутилка с вода\n" +
                "    - Око на паяк\n\n" +
                "Внимание: Използвай с повишено внимание!";

            lblPotionInfo.Text = potionInfoText;

            lblPotionInfo.ForeColor = Color.Black;
            lblPotionInfo.Visible = true;

        }





        private void lblPotion1_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl == null) return;

            string text = lbl.Text;
            Font font = lbl.Font;
            Graphics g = e.Graphics;

            int shadowSize = 2;
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(180, Color.Black)))
            {
                for (int x = -shadowSize; x <= shadowSize; x++)
                {
                    for (int y = -shadowSize; y <= shadowSize; y++)
                    {
                        if (x == 0 && y == 0) continue;
                        g.DrawString(text, font, shadowBrush, new PointF(x, y));
                    }
                }
            }

            using (SolidBrush whiteBrush = new SolidBrush(Color.White))
            {
                g.DrawString(text, font, whiteBrush, new PointF(0, 0));
            }

        }

        private void lblPotionInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShowJump_Click(object sender, EventArgs e)
        {

            picPotionJump.Visible = true;
            lblInfoJump.Visible = true;
            btnBackJump.Visible = true;

            lblPotionJump.Visible = false;
            btnShowJump.Visible = false;

            lblPotion1.Visible = false;
            btnShow1.Visible = false;

            lblPotionName2.Visible = false;
            btnShow2.Visible = false;

            labelMagic.Visible = false;
            labelMagic2.Visible = false;

            lblInfoJump.Text =
         @"Отвара за Скок
     Ефект
      Повишава височината на скока.

       Рецепта:
         - Заешка лапа
         - Бутилка с вода
         - Огнена прах
     Внимание: 
       Да не се използва преди битка с дракон!";

        }

        private void btnBackJump_Click(object sender, EventArgs e)
        {

            picPotionJump.Visible = false;
            lblInfoJump.Visible = false;
            btnBackJump.Visible = false;
            lblInfoJump.Text = "";

            lblPotionJump.Visible = true;
            btnShowJump.Visible = true;

            lblPotion1.Visible = true;
            btnShow1.Visible = true;

            lblPotionName2.Visible = true;
            btnShow2.Visible = true;

            labelMagic.Visible = true;
            labelMagic2.Visible = true;


        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            picPotion2.Visible = true;
            lblPotionInfo2.Visible = true;
            btnBack2.Visible = true;

            lblPotionName2.Visible = false;
            btnShow2.Visible = false;

            lblPotion1.Visible = false;
            btnShow1.Visible = false;

            lblPotionJump.Visible = false;
            btnShowJump.Visible = false;

            labelMagic.Visible = false;
            labelMagic2.Visible = false;

            lblPotionInfo2.Text =
    @"Отвара за Сила
    Ефект:
    Ставаш силен като бик за 5 минути!

     Рецепта:
        - Адска ягода
        - Огнена прах
        - Бутилка с вода
  Внимание:
   Не се бий с Хълк, освен ако не искаш да загубиш!";
        }

        private void lblPotionName2_Click(object sender, EventArgs e)
        {

        }

        private void lblPotionInfo2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            picPotion2.Visible = false;
            lblPotionInfo2.Visible = false;
            btnBack2.Visible = false;
            lblPotionInfo2.Text = "";

            lblPotion1.Visible = true;
            btnShow1.Visible = true;

            lblPotionJump.Visible = true;
            btnShowJump.Visible = true;

            lblPotionName2.Visible = true;
            btnShow2.Visible = true;

            labelMagic.Visible = true;
            labelMagic2.Visible = true;
        }

        private void picPotion2_Click(object sender, EventArgs e)
        {

        }
    }
}

