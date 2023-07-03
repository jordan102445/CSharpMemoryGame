using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarskaRabota
{
    public partial class Form1 : Form
    {

        Random lokacija = new Random(); // deklaracija na Radom funkcija za promena na mestata na kartite
        List<Point> poeni = new List<Point>();
        Button slika1; // ja zima vrednosta na prvoto kopce za sporeduvanje na 2te
        Button slika2;  // ja zima vrednosta na prvoto kopce za sporeduvanje na 2 te

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BrojacNaPoeni.Text = "0";
            secZaZapocnuvanje.Text = "150";

            foreach (Button but in ButHolder.Controls)
            {
                but.Enabled = false; // false t.e deka ne se otkrieni ne se enabled prvo posle 5 sekundi stanuvat enabled ili true
                poeni.Add(but.Location);  // vo listata poeni dodaveme slika so nejzinata lokacija 
            }

            foreach (Button but in ButHolder.Controls) // go pravi za sekoe kopce vo panelot 
            {
                int next = lokacija.Next(poeni.Count); // broe kolku poeni so Count od listata poeni, pa potoa odbere nekoj random broj i go zacuva vo next
                Point poen = poeni[next];  // poeno go zima od zacuvanoto vo next 
                but.Location = poen;   // taka seekoja PictureBox ili slika ima poen so dobien od random
                poeni.Remove(poen);  // ke go izbriseme , isti poen ke bide upotrebuvan na razlicni karti povekje pati
                //  zeme se random poen, dodele go na nekoja slika ili PictureBox zacuva go vo next stoe pa potoa go izbrise i etc 

            }


            timer1.Start();

            But1.BackgroundImage = Properties.Resources._7BB12381_5859_4966_8EFA_04A11DA1C79B; // dodeluvame na sekoe kopce odredena slika taka i na ostanatite
            DupBut1.BackgroundImage = Properties.Resources._7BB12381_5859_4966_8EFA_04A11DA1C79B;
            But2.BackgroundImage = Properties.Resources._15F861F5_5708_44FF_A87E_0D0A87F954C4;
            DupBut2.BackgroundImage = Properties.Resources._15F861F5_5708_44FF_A87E_0D0A87F954C4;
            But3.BackgroundImage = Properties.Resources.LightningMcQueen;
            DupBut3.BackgroundImage = Properties.Resources.LightningMcQueen;
            But4.BackgroundImage = Properties.Resources.Fdta;
            DupBut4.BackgroundImage = Properties.Resources.Fdta;
            But5.BackgroundImage = Properties.Resources.Bobby;
            DupBut5.BackgroundImage = Properties.Resources.Bobby;
            But6.BackgroundImage = Properties.Resources.Brick_yardley;
            DupBut6.BackgroundImage = Properties.Resources.Brick_yardley;
            But7.BackgroundImage = Properties.Resources.ca3f41a61e7ea66a2f29e3710f957c0b;
            DupBut7.BackgroundImage = Properties.Resources.ca3f41a61e7ea66a2f29e3710f957c0b;
            But8.BackgroundImage = Properties.Resources.Floyd_Mulvihill;
            DupBut8.BackgroundImage = Properties.Resources.Floyd_Mulvihill;
            But9.BackgroundImage = Properties.Resources.Jdta;
            DupBut9.BackgroundImage = Properties.Resources.Jdta;
            But10.BackgroundImage = Properties.Resources.Junior_Moon;
            DupBut10.BackgroundImage = Properties.Resources.Junior_Moon;
            But11.BackgroundImage = Properties.Resources.Markus_Krankzler_Artwork;
            DupBut11.BackgroundImage = Properties.Resources.Markus_Krankzler_Artwork;
            But12.BackgroundImage = Properties.Resources.Terryk;
            DupBut12.BackgroundImage = Properties.Resources.Terryk;
            But13.BackgroundImage = Properties.Resources.Rcta;
            DupBut13.BackgroundImage = Properties.Resources.Rcta;
            But14.BackgroundImage = Properties.Resources.Chaseta;
            DupBut14.BackgroundImage = Properties.Resources.Chaseta;
            But15.BackgroundImage = Properties.Resources.Doc_Hudson;
            DupBut15.BackgroundImage = Properties.Resources.Doc_Hudson;
            But16.BackgroundImage = Properties.Resources.A1F358B2_EC8B_44E3_A5E0_9556DFE71781;
            DupBut16.BackgroundImage = Properties.Resources.A1F358B2_EC8B_44E3_A5E0_9556DFE71781;
            But17.BackgroundImage = Properties.Resources.Curbler;
            DupBut17.BackgroundImage = Properties.Resources.Curbler;
            But18.BackgroundImage = Properties.Resources.CalWeathers;
            DupBut18.BackgroundImage = Properties.Resources.CalWeathers;

        }

        private void But1_Click(object sender, EventArgs e) // pri samiokot klik na kopceto se otvara slikata i e spremna za sporeduvanje 
        {
            But1.BackgroundImage = Properties.Resources._7BB12381_5859_4966_8EFA_04A11DA1C79B;
            if (slika1 == null)
            {
                slika1 = But1;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = But1;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)      // sporeduvanje so nivniot Tag,na site sliki koj sto e zadaden 
                {
                    slika1 = null;
                    slika2 = null;
                    But1.Enabled = false;
                    DupBut1.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start(); //  za da se vrnat karite na question marko ili pak na prasalniceto
                }

            }

        }

        private void DupBut1_Click(object sender, EventArgs e)
        {
            DupBut1.BackgroundImage = Properties.Resources._7BB12381_5859_4966_8EFA_04A11DA1C79B;

            if (slika1 == null)
            {
                slika1 = DupBut1;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = DupBut1;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But1.Enabled = false;
                    DupBut1.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }

        }

        private void But2_Click(object sender, EventArgs e)
        {
            But2.BackgroundImage = Properties.Resources._15F861F5_5708_44FF_A87E_0D0A87F954C4;

            if (slika1 == null)
            {
                slika1 = But2;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = But2;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But2.Enabled = false;
                    DupBut2.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }

        }

        private void DupBut2_Click(object sender, EventArgs e)
        {
            DupBut2.BackgroundImage = Properties.Resources._15F861F5_5708_44FF_A87E_0D0A87F954C4;

            if (slika1 == null)
            {
                slika1 = DupBut2;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = DupBut2;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But2.Enabled = false;
                    DupBut2.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }



            }

        }

        private void But3_Click(object sender, EventArgs e)
        {
            But3.BackgroundImage = Properties.Resources.LightningMcQueen;
            if (slika1 == null)
            {
                slika1 = But3;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = But3;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But3.Enabled = false;
                    DupBut3.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }


        }

        private void DupBut3_Click(object sender, EventArgs e)
        {
            DupBut3.BackgroundImage = Properties.Resources.LightningMcQueen;
            if (slika1 == null)
            {
                slika1 = DupBut3;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = But3;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But3.Enabled = false;
                    DupBut3.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void But4_Click(object sender, EventArgs e)
        {
            But4.BackgroundImage = Properties.Resources.Fdta;
            if (slika1 == null)
            {
                slika1 = But4;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = But4;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But4.Enabled = false;
                    DupBut4.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }

        }

        private void DupBut4_Click(object sender, EventArgs e)
        {
            DupBut4.BackgroundImage = Properties.Resources.Fdta;
            if (slika1 == null)
            {
                slika1 = DupBut4;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = DupBut4;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But4.Enabled = false;
                    DupBut4.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }

        }

        private void But5_Click(object sender, EventArgs e)
        {
            But5.BackgroundImage = Properties.Resources.Bobby;
            if (slika1 == null)
            {
                slika1 = But5;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = But5;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But5.Enabled = false;
                    DupBut5.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }

            }

        }

        private void DupBut5_Click(object sender, EventArgs e)
        {
            DupBut5.BackgroundImage = Properties.Resources.Bobby;
            if (slika1 == null)
            {
                slika1 = DupBut5;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = DupBut5;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But5.Enabled = false;
                    DupBut5.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }
        }

        private void But6_Click(object sender, EventArgs e)
        {
            But6.BackgroundImage = Properties.Resources.Brick_yardley;

            if (slika1 == null)
            {
                slika1 = But6;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = But6;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But6.Enabled = false;
                    DupBut6.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void DupBut6_Click(object sender, EventArgs e)
        {
            DupBut6.BackgroundImage = Properties.Resources.Brick_yardley;

            if (slika1 == null)
            {
                slika1 = DupBut6;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = DupBut6;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But6.Enabled = false;
                    DupBut6.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }

            }

        }

        private void But7_Click(object sender, EventArgs e)
        {
            But7.BackgroundImage = Properties.Resources.ca3f41a61e7ea66a2f29e3710f957c0b;

            if (slika1 == null)
            {
                slika1 = But7;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = But7;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But7.Enabled = false;
                    DupBut7.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }

        }

        private void DupBut7_Click(object sender, EventArgs e)
        {
            DupBut7.BackgroundImage = Properties.Resources.ca3f41a61e7ea66a2f29e3710f957c0b;

            if (slika1 == null)
            {
                slika1 = DupBut7;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = DupBut7;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But7.Enabled = false;
                    DupBut7.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }

        }

        private void But8_Click(object sender, EventArgs e)
        {
            But8.BackgroundImage = Properties.Resources.Floyd_Mulvihill;

            if (slika1 == null)
            {
                slika1 = But8;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = But8;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But8.Enabled = false;
                    DupBut8.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }
        }

        private void DupBut8_Click(object sender, EventArgs e)
        {
            DupBut8.BackgroundImage = Properties.Resources.Floyd_Mulvihill;

            if (slika1 == null)
            {
                slika1 = DupBut8;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = DupBut8;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But8.Enabled = false;
                    DupBut8.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }
        }

        private void But9_Click(object sender, EventArgs e)
        {
            But9.BackgroundImage = Properties.Resources.Jdta;

            if (slika1 == null)
            {
                slika1 = But9;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = But9;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But9.Enabled = false;
                    DupBut9.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }

        }

        private void DupBut9_Click(object sender, EventArgs e)
        {
            DupBut9.BackgroundImage = Properties.Resources.Jdta;

            if (slika1 == null)
            {
                slika1 = DupBut9;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = DupBut9;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But9.Enabled = false;
                    DupBut9.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }
        }

        private void But10_Click(object sender, EventArgs e)
        {
            But10.BackgroundImage = Properties.Resources.Junior_Moon;

            if (slika1 == null)
            {
                slika1 = But10;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = But10;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But10.Enabled = false;
                    DupBut10.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }

        }

        private void DupBut10_Click(object sender, EventArgs e)
        {
            DupBut10.BackgroundImage = Properties.Resources.Junior_Moon;

            if (slika1 == null)
            {
                slika1 = DupBut10;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = DupBut10;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But10.Enabled = false;
                    DupBut10.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }
        }

        private void But11_Click(object sender, EventArgs e)
        {
            But11.BackgroundImage = Properties.Resources.Markus_Krankzler_Artwork;

            if (slika1 == null)
            {
                slika1 = But11;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = But11;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But11.Enabled = false;
                    DupBut11.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void DupBut11_Click(object sender, EventArgs e)
        {
            DupBut11.BackgroundImage = Properties.Resources.Markus_Krankzler_Artwork;

            if (slika1 == null)
            {
                slika1 = But11;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = DupBut11;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But11.Enabled = false;
                    DupBut11.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void But12_Click(object sender, EventArgs e)
        {
            But12.BackgroundImage = Properties.Resources.Terryk;
            if (slika1 == null)
            {
                slika1 = But12;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = But12;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But12.Enabled = false;
                    DupBut12.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void DupBut12_Click(object sender, EventArgs e)
        {
            DupBut12.BackgroundImage = Properties.Resources.Terryk;
            if (slika1 == null)
            {
                slika1 = DupBut12;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = DupBut12;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But12.Enabled = false;
                    DupBut12.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }

            }

        }

        private void But13_Click(object sender, EventArgs e)
        {
            But13.BackgroundImage = Properties.Resources.Rcta;

            if (slika1 == null)
            {
                slika1 = But13;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = But13;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But13.Enabled = false;
                    DupBut13.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }

            }

        }

        private void DupBut13_Click(object sender, EventArgs e)
        {
            DupBut13.BackgroundImage = Properties.Resources.Rcta;

            if (slika1 == null)
            {
                slika1 = DupBut13;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = DupBut13;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But13.Enabled = false;
                    DupBut13.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }

            }

        }

        private void But14_Click(object sender, EventArgs e)
        {
            But14.BackgroundImage = Properties.Resources.Chaseta;
            if (slika1 == null)
            {
                slika1 = But14;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = But14;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But14.Enabled = false;
                    DupBut14.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }

        }

        private void DupBut14_Click(object sender, EventArgs e)
        {
            DupBut14.BackgroundImage = Properties.Resources.Chaseta;
            if (slika1 == null)
            {
                slika1 = DupBut14;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = DupBut14;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But14.Enabled = false;
                    DupBut14.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }

        }

        private void But15_Click(object sender, EventArgs e)
        {

            But15.BackgroundImage = Properties.Resources.Doc_Hudson;

            if (slika1 == null)
            {
                slika1 = But15;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = But15;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But15.Enabled = false;
                    DupBut15.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DupBut15_Click(object sender, EventArgs e)
        {
            DupBut15.BackgroundImage = Properties.Resources.Doc_Hudson;

            if (slika1 == null)
            {
                slika1 = DupBut15;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = DupBut15;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But15.Enabled = false;
                    DupBut15.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }

        }

        private void But16_Click(object sender, EventArgs e)
        {
            But16.BackgroundImage = Properties.Resources.A1F358B2_EC8B_44E3_A5E0_9556DFE71781;

            if (slika1 == null)
            {
                slika1 = But16;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = But16;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But16.Enabled = false;
                    DupBut16.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }
        }

        private void DupBut16_Click(object sender, EventArgs e)
        {
            DupBut16.BackgroundImage = Properties.Resources.A1F358B2_EC8B_44E3_A5E0_9556DFE71781;

            if (slika1 == null)
            {
                slika1 = DupBut16;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = DupBut16;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But16.Enabled = false;
                    DupBut16.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }
        }

        private void But17_Click(object sender, EventArgs e)
        {
            But17.BackgroundImage = Properties.Resources.Curbler;

            if (slika1 == null)
            {
                slika1 = But17;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = But17;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But17.Enabled = false;
                    DupBut17.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }

        }

        private void DupBut17_Click(object sender, EventArgs e)
        {
            DupBut17.BackgroundImage = Properties.Resources.Curbler;

            if (slika1 == null)
            {
                slika1 = DupBut17;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = DupBut17;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But17.Enabled = false;
                    DupBut17.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }

        }

        private void But18_Click(object sender, EventArgs e)
        {
            But18.BackgroundImage = Properties.Resources.CalWeathers;

            if (slika1 == null)
            {
                slika1 = But18;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = But18;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But18.Enabled = false;
                    DupBut18.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }


            }
        }

        private void DupBut18_Click(object sender, EventArgs e)
        {
            DupBut18.BackgroundImage = Properties.Resources.CalWeathers;

            if (slika1 == null)
            {
                slika1 = DupBut18;
            }
            else if (slika1 != null && slika2 == null)
            {
                slika2 = DupBut18;
            }
            if (slika1 != null && slika2 != null)
            {
                if (slika1.Tag == slika2.Tag)
                {
                    slika1 = null;
                    slika2 = null;
                    But18.Enabled = false;
                    DupBut18.Enabled = false;
                    BrojacNaPoeni.Text = Convert.ToString(Convert.ToInt32(BrojacNaPoeni.Text) + 1);
                }
                else
                {
                    timer3.Start();
                }

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();

            foreach (Button but in ButHolder.Controls)
            {
                but.Enabled = true;
                but.Cursor = Cursors.Hand; // so samoto odenje so glusecot da ja semene formata koga ke se pretisne na kopceto ili slikata
                but.BackgroundImage = Properties.Resources.question;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int tajmer = Convert.ToInt32(secZaZapocnuvanje.Text);  // tajmer za namaluvanje ili preostanato vreme za igranje na korisnikot , vo label.Text ni e
            tajmer--;
            secZaZapocnuvanje.Text = Convert.ToString(tajmer);

            if (tajmer == 0)
            {

                timer2.Stop(); // go stopirame koga ke dojde do label == 0
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            slika1.BackgroundImage = Properties.Resources.question;
            slika2.BackgroundImage = Properties.Resources.question;
            slika1 = null;
            slika2 = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e); // so load na samata Forma again da se igra igrata.
        }
    }
}
