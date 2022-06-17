using System;
using System.Drawing;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class SC_58029_form : Form
    {

        public SC_58029_form()
        {

            InitializeComponent();

            KeyPreview = true;

            sc_58029_Label.MouseMove += new MouseEventHandler(Sc_58029_ObjectMove);
            sc_58029_Label.MouseDown += new MouseEventHandler(Sc_58029_ObjectDown);

        }



        private void Sc_58029_Klawisze(object sc_58029_Sender, KeyEventArgs sc_58029_E)
        {

            if (sc_58029_E.KeyData == Keys.A)
            {
                sc_58029_Lewo.PerformClick();
            }

            if (sc_58029_E.KeyData == Keys.D)
            {
                sc_58029_Prawy.PerformClick();
            }

            if (sc_58029_E.KeyCode == Keys.W)
            {
                sc_58029_Up.PerformClick();
            }

            if (sc_58029_E.KeyData == Keys.S)
            {
                sc_58029_Down.PerformClick();
            }


            if (sc_58029_E.KeyData == Keys.P)
            {
                sc_58029_Powieksz.PerformClick();
            }

            if (sc_58029_E.KeyData == Keys.M)
            {
                sc_58029_Pomniejsz.PerformClick();
            }


            if (sc_58029_E.KeyCode == Keys.T)
            {
                sc_58029_Ul.PerformClick();
            }

            if (sc_58029_E.KeyData == Keys.Y)
            {
                sc_58029_Up2.PerformClick();
            }
            if (sc_58029_E.KeyCode == Keys.G)
            {
                sc_58029_Dl.PerformClick();
            }

            if (sc_58029_E.KeyData == Keys.H)
            {
                sc_58029_Dp.PerformClick();
            }
        }



        private void Sc_58029_ObjectDown(object sc_58029_Sender, MouseEventArgs sc_58029_E)
        {
            if (sc_58029_E.Button == MouseButtons.Left)
            {

                sc_58029_Label.Tag = sc_58029_E.Location;
            }
        }

        private void Sc_58029_ObjectMove(object sc_58029_Sender, MouseEventArgs sc_58029_E)
        {
            if (sc_58029_E.Button == MouseButtons.Left)
            {
                sc_58029_Label.Left += sc_58029_E.X - ((Point)sc_58029_Label.Tag).X;
                sc_58029_Label.Top += sc_58029_E.Y - ((Point)sc_58029_Label.Tag).Y;
            }
        }



        #region Klawisze góra dół lewo prawo 

        private void sc_58029_Up_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {

            sc_58029_Label.Top += -5;
        }

        private void sc_58029_Down_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {

            sc_58029_Label.Top += 5;
        }

        private void sc_58029_Lewo_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {

            sc_58029_Label.Left += -5;
        }

        private void sc_58029_Prawy_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {

            sc_58029_Label.Left += 5;
        }
        #endregion


        #region sokosy

        private void sc_58029_Ul_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {

            sc_58029_Label.Top += -5;
            sc_58029_Label.Left += -5;
        }

        private void sc_58029_Up2_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {

            sc_58029_Label.Top += -5;
            sc_58029_Label.Left += 5;
        }

        private void sc_58029_Dl_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {

            sc_58029_Label.Top += 5;
            sc_58029_Label.Left += -5;
        }

        private void sc_58029_Dp_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            sc_58029_Label.Top += 5;
            sc_58029_Label.Left += 5;
        }
        #endregion

        #region zmiana rozmiaru

        private void sc_58029_Powieksz_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {

            sc_58029_Label.Width += 2;
            sc_58029_Label.Height += 2;


            if (sc_58029_Label.Width < 200)
            {

                sc_58029_Label.Top += -1;
                sc_58029_Label.Left += -1;
            }
        }

        private void sc_58029_Pomniejsz_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {

            sc_58029_Label.Width += -2;
            sc_58029_Label.Height += -2;


            if (sc_58029_Label.Width > 10)
            {

                sc_58029_Label.Top += 1;
                sc_58029_Label.Left += 1;
            }
        }
        #endregion


    }
}
