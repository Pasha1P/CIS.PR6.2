using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ПР6._2
{
    public partial class Form1 : Form
    {
        public delegate void MyDelegate(char s);

        OrderFulfillmentFacade f = new OrderFulfillmentFacade();
        string oneN, twoN;
        public MyDelegate myDelegate;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            labelTime.BackColor = Color.Transparent;
            labelNumberOfShop.ForeColor = Color.White;
            labelNumberOfShop.TextAlign = ContentAlignment.TopLeft;
            labelNumberOfShop.BackColor = Color.Transparent;
            labelNumber.Location = new Point(245, 159);
            timer1.Enabled = true;
            labelNumberOfShop.Visible = false;
            timer1.Interval = 1000;
            myDelegate += NumberTelefon;
            myDelegate += CodeShop;
            labelNumberOfShop.AutoSize = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = string.Format("{0:d2}:{1:d2}", DateTime.Now.Hour, DateTime.Now.Minute);
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            labelNumber.Size = new Size(308, 44);
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            labelNumberOfShop.TextAlign = ContentAlignment.TopLeft;
            pictureBox5.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            labelNumber.Location = new Point(245, 159);
            labelNumber.Visible = false;
            pictureBoxP0.Visible = false;
            pictureBoxP1.Visible = false;
            pictureBoxP2.Visible = false;
            pictureBoxP3.Visible = false;
            pictureBoxP4.Visible = false;
            pictureBoxP5.Visible = false;
            pictureBoxP6.Visible = false;
            pictureBoxP7.Visible = false;
            pictureBoxP8.Visible = false;
            pictureBoxP9.Visible = false;
            pictureBoxPX.Visible = false;
            labelNumberOfShop.Visible = false;
            labelMenu.Visible = false;
            labelNumber.Visible = false;
            pictureBoxPH.Visible = false;
            pictureBoxPP.Visible = false;
            labelMenu.Text = null;
            oneN = null;
            twoN = null;
            labelTime.ForeColor = Color.Black;
            labelNumber.ForeColor = Color.Black;
            pictureBox2.Image = Properties.Resources.Vxwpcs3dC2w;
            BackgroundImage = Properties.Resources.e39eef7f13d585924394efd742c90694;
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        { MessageBox.Show("Система временно не доступна.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        private void pictureBox5_Click(object sender, EventArgs e)
        { MessageBox.Show("Система временно не доступна."); }
        private void pictureBox4_Click(object sender, EventArgs e)
        { MessageBox.Show("Система временно не доступна."); }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            labelNumber.Size = new Size(308, 150);
            labelNumber.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox8.Visible = false;
            pictureBox6.Visible = false;
            labelNumber.BackColor = Color.White;
            labelNumber.Text = "Телефонный магазин\n8-888-999-45-04";
            BackgroundImage = Properties.Resources.e4;
            labelNumber.TextAlign = ContentAlignment.TopLeft;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox8.Visible = false;
            pictureBox6.Visible = false;
            labelNumber.Location = new Point(237, 339);
            labelNumber.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.asd2e;
            BackgroundImage = Properties.Resources.e5;
            labelTime.ForeColor = Color.White;
            labelNumber.ForeColor = Color.White;
            pictureBoxP0.Visible = true;
            pictureBoxP1.Visible = true;
            pictureBoxP2.Visible = true;
            pictureBoxP3.Visible = true;
            labelNumber.Text = null;
            pictureBoxP4.Visible = true;
            pictureBoxP5.Visible = true;
            pictureBoxP6.Visible = true;
            pictureBoxP7.Visible = true;
            pictureBoxP8.Visible = true;
            pictureBoxP9.Visible = true;
            pictureBoxPX.Visible = true;
            pictureBoxPH.Visible = true;
            pictureBoxPP.Visible = true;
        }
        private void pictureBoxP1_Click(object sender, EventArgs e)
        {
                myDelegate('1');
        }
        private void pictureBoxP2_Click(object sender, EventArgs e)
        {
                myDelegate('2');
        }
        private void pictureBoxP3_Click(object sender, EventArgs e)
        {
                myDelegate('3');
        }
        private void pictureBoxP4_Click(object sender, EventArgs e)
        {
            if (labelNumberOfShop.Visible == false)
                myDelegate('4');
        }
        private void pictureBoxP5_Click(object sender, EventArgs e)
        {
            if (labelNumberOfShop.Visible == false)
                myDelegate('5');
        }
        private void pictureBoxP6_Click(object sender, EventArgs e)
        {
            if (labelNumberOfShop.Visible == false)
                myDelegate('6');
        }
        private void pictureBoxP7_Click(object sender, EventArgs e)
        {
            if (labelNumberOfShop.Visible == false)
                myDelegate('7');
        }
        private void pictureBoxP8_Click(object sender, EventArgs e)
        {
            if (labelNumberOfShop.Visible == false)
                myDelegate('8');
        }
        private void pictureBoxP9_Click(object sender, EventArgs e)
        {
            if (labelNumberOfShop.Visible == false)
                myDelegate('9');
        }
        private void pictureBoxP0_Click(object sender, EventArgs e)
        {
            if (labelNumberOfShop.Visible == false)
                myDelegate('0');
        }
        private void pictureBoxPP_Click(object sender, EventArgs e)
        {
            if (oneN.Length == 11)
            {
                if (oneN == "88889994504")
                {
                    labelNumber.Text = "";
                    labelNumberOfShop.Visible = true;
                    labelNumberOfShop.TextAlign = ContentAlignment.MiddleRight;
                    labelMenu.Visible = true;
                    oneN = null;
                    labelMenu.Text = null;
                    labelMenu.Text = f.Menu();
                    labelMenu.Text += "*  Заказать\n#  Отмена\n\nЕсли хотите заказать более одного предмета нажмите несколько раз";
                }
                else
                {
                    MessageBox.Show("Вы должны позвонить по нужному номеру", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    oneN = null;
                    twoN = null;
                }
            }
            else if (labelNumberOfShop.Visible == false)
            {
                labelNumber.Text = "";
                MessageBox.Show("Неправильно набран номер", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oneN = null;
                twoN = null;
            }
        }
        private void NumberTelefon(char s)
        {
            if (labelNumberOfShop.Visible == false)
            {
                if (oneN == null || oneN.Length <= 11)
                    oneN += s;
                if (oneN != null && oneN.Length <= 11)
                {

                    labelNumber.TextAlign = ContentAlignment.MiddleRight;
                    labelNumber.Visible = true;
                    if (oneN.Length < 3)
                        labelNumber.Text = String.Format("{0:             ##}", Convert.ToUInt64(oneN));
                    else if (oneN.Length < 5)
                        labelNumber.Text = String.Format("{0:          ##-##}", Convert.ToUInt64(oneN));
                    else if (oneN.Length < 8)
                        labelNumber.Text = String.Format("{0:      ###-##-##}", Convert.ToUInt64(oneN));
                    else if (oneN.Length < 11)
                        labelNumber.Text = String.Format("{0:  ###-###-##-##}", Convert.ToUInt64(oneN));
                    else labelNumber.Text = String.Format("{0:#-###-###-##-##}", Convert.ToUInt64(oneN));

                }
            }
        }
        private void CodeShop(char s)
        {
            if (labelNumberOfShop.Visible == true)
            {
                labelNumber.TextAlign = ContentAlignment.MiddleCenter;
                oneN += s;
                twoN += s;
                twoN += ',';
                oneN += ' ';
                if (oneN.Length > 14)
                {
                    oneN = oneN.Remove(0, 4);
                    oneN = oneN.Insert(0, ".").Insert(0, ".");
                }
                labelNumber.Text = oneN;
            }
        }
        private void pictureBoxPH_Click(object sender, EventArgs e)
        {
            if (labelMenu.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox8.Visible = false;
                pictureBox6.Visible = false;
                labelNumberOfShop.Visible = false;
                labelMenu.Visible = false;
                oneN = null;
                twoN = null;
                labelNumber.Location = new Point(237, 339);
                labelNumber.BackColor = Color.Transparent;
                pictureBox2.Image = Properties.Resources.asd2e;
                BackgroundImage = Properties.Resources.e5;
                labelTime.ForeColor = Color.White;
                labelNumber.ForeColor = Color.White;
                pictureBoxP0.Visible = true;
                labelMenu.Text = null;
                pictureBoxP1.Visible = true;
                pictureBoxP2.Visible = true;
                pictureBoxP3.Visible = true;
                pictureBoxP4.Visible = true;
                pictureBoxP5.Visible = true;
                pictureBoxP6.Visible = true;
                pictureBoxP7.Visible = true;
                pictureBoxP8.Visible = true;
                pictureBoxP9.Visible = true;
                labelNumber.Text = null;
                pictureBoxPX.Visible = true;
                pictureBoxPH.Visible = true;
                pictureBoxPP.Visible = true;
            }
        }
        private void pictureBoxPX_Click(object sender, EventArgs e)
        {
            if (labelNumberOfShop.Visible == true)
                if (oneN.Length > 0)
                {
                    f.Buy(twoN);
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox6.Visible = false;
                    labelNumberOfShop.Visible = false;
                    labelMenu.Visible = false;
                    oneN = null;
                    twoN = null;
                    labelNumber.Location = new Point(237, 339);
                    labelNumber.BackColor = Color.Transparent;
                    pictureBox2.Image = Properties.Resources.asd2e;
                    BackgroundImage = Properties.Resources.e5;
                    labelTime.ForeColor = Color.White;
                    labelNumber.ForeColor = Color.White;
                    pictureBoxP0.Visible = true;
                    labelMenu.Text = null;
                    pictureBoxP1.Visible = true;
                    pictureBoxP2.Visible = true;
                    pictureBoxP3.Visible = true;
                    pictureBoxP4.Visible = true;
                    pictureBoxP5.Visible = true;
                    pictureBoxP6.Visible = true;
                    pictureBoxP7.Visible = true;
                    pictureBoxP8.Visible = true;
                    pictureBoxP9.Visible = true;
                    pictureBoxPX.Visible = true;
                    pictureBoxPH.Visible = true;
                    pictureBoxPP.Visible = true;
                    labelNumber.Text = null;
                }
                else MessageBox.Show("Выдолжнычто-нибутьвыбрать", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // Фасад
        class OrderFulfillmentFacade
        {
            private Catalog c = new Catalog();

            public string Menu()
            {
                c.CatalogList();
                return c.RndCatalog();
            }
            public void Buy(string str)
            {
                str = c.NewOrder(str.TrimEnd(','));
                if (str == null)
                {
                    MessageBox.Show("Извените, произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Вашзаказ:\n" + str, "Заказ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
    /*
     88888 звонок
     88889994504 звонок 12321#
     88889994504 звонок 12*
     */
}
