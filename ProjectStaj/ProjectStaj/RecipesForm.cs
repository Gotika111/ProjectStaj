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



            lblPotionInfo.Paint += lblPotion1_Paint;
            lblPotionInfo.ForeColor = Color.White;
            lblPotionInfo.BackColor = Color.Transparent;




            lblPotionInfo.BackColor = Color.Transparent;


        }



        private void RecipesForm_Load(object sender, EventArgs e)
        {
            picPotion1.Visible = false;
            lblPotionInfo.Visible = false;
            btnBack1.Visible = false;

            lblPotionInfo.BackColor = Color.Transparent;
            lblPotionInfo.ForeColor = lblPotion1.ForeColor;



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

        }

        private void btnShow1_Click(object sender, EventArgs e)
        {
            picPotion1.Visible = true;
            lblPotionInfo.Visible = true;
            btnBack1.Visible = true;

            lblPotion1.Visible = false;
            btnShow1.Visible = false;

            potionInfoText = "Отвара за Невидимост\n\n" +
                "Ефект:\n" +
                "    Ставаш невидим за 10 минути.\n\n" +
                "Рецепта:\n" +
                "    - Златен морков\n" +
                "    - Бутилка с вода\n" +
                "    - Око на паяк\n\n" +
                "Внимание: Използвай с повишено внимание!";

            lblPotionInfo.Text = potionInfoText;

            lblPotionInfo.ForeColor = Color.White;
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
            Label lbl = sender as Label;
            if (lbl == null) return;

            string text = lbl.Text;
            Font font = lbl.Font;
            Graphics g = e.Graphics;

            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            // Няма изчистване! (НЕ използвай e.Graphics.Clear())

            // Жълт блясък
            int glowSize = 2;
            using (SolidBrush glowBrush = new SolidBrush(Color.Gold))
            {
                for (int dx = -glowSize; dx <= glowSize; dx++)
                {
                    for (int dy = -glowSize; dy <= glowSize; dy++)
                    {
                        if (dx == 0 && dy == 0) continue;
                        g.DrawString(text, font, glowBrush, new PointF(dx, dy));
                    }
                }
            }

            // Основен бял текст
            using (SolidBrush whiteBrush = new SolidBrush(Color.White))
            {
                g.DrawString(text, font, whiteBrush, new PointF(0, 0));
            }



        }
    }
}

