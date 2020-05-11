using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GambitCalculatorApp
{
    public partial class Form1 : Form
    {
        public int wins;
        public int losses;
        public string A;
        public string B;
        public int points;
        public int wantedpoints;
        public int Guardian; public int Guardian2; public int Guardian3;
        public int Brave; public int Brave2; public int Brave3;
        public int Heroic; public int Heroic2; public int Heroic3;
        public int Fabled; public int Fabled2; public int Fabled3;
        public int Mythic; public int Mythic2; public int Mythic3;
        public int Legend; public int Max;
        public string over;
        public bool C;
        public bool D;
        public string L;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Note: This calculator isn't perfect and will often overcalculate the wins and losses. It also doesn't account for streaks.";
        }

        private void InfamyRank_SelectedIndexChanged(object sender, EventArgs e)
        {
        A = InfamyRank.SelectedItem.ToString();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            B = listBox1.SelectedItem.ToString();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        static bool StringChecker(string String1,string String2)
        {
            if(String1 == String2) { return true; }
            else { return false; }
        }
        static bool IntChecker(int int1, int int2)
        {
            if (int1 >= int2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            Thread.Sleep(100);
            wins = 0; losses = 0;
            Guardian = 0; Guardian2 = 250; Guardian3 = 600;
            Brave = 1000; Brave2 = 1450; Brave3 = 1950;
            Heroic = 2500; Heroic2 = 3100; Heroic3 = 3750;
            Fabled = 4500;  Fabled2 = 5350; Fabled3 = 6350;
            Mythic = 7500; Mythic2 = 8800; Mythic3 = 10300;
            Legend = 12000; Max = 15000;
            points = 0; wantedpoints = 0;
            progressBar1.Value = 10;
            Thread.Sleep(100);
            if(StringChecker(A,"Guardian 1"))
            {
                points = Guardian;
            }
            if (StringChecker(A, "Guardian 2"))
            {
                points = Guardian2;
            }
            if (StringChecker(A, "Guardian 3"))
            {
                points = Guardian3;
            }
            if (StringChecker(A, "Brave 1"))
            {
                points = Brave;
            }
            if (StringChecker(A, "Brave 2"))
            {
                points = Brave2;
            }
            if (StringChecker(A, "Brave 3"))
            {
                points = Brave3;
            }
            if (StringChecker(A, "Heroic 1"))
            {
                points = Heroic;
            }
            if (StringChecker(A, "Heroic 2"))
            {
                points = Heroic2;
            }
            if (StringChecker(A, "Heroic 3"))
            {
                points = Heroic3;
            }
            if (StringChecker(A, "Fabled 1"))
            {
                points = Fabled;
            }
            if (StringChecker(A, "Fabled 2"))
            {
                points = Fabled2;
            }
            if (StringChecker(A, "Fabled 3"))
            {
                points = Fabled3;
            }
            if (StringChecker(A, "Mythic 1"))
            {
                points = Mythic;
            }
            if (StringChecker(A, "Mythic 2"))
            {
                points = Mythic2;
            }
            if (StringChecker(A, "Mythic 3"))
            {
                points = Mythic3;
            }
            if (StringChecker(A, "Legend"))
            {
                points = Legend;
            }
            progressBar1.Value = 40;
            Thread.Sleep(100);
            if (StringChecker(B, "Guardian 1"))
            {
               wantedpoints = Guardian;
            }
            if (StringChecker(B, "Guardian 2"))
            {
               wantedpoints = Guardian2;
            }
            if (StringChecker(B, "Guardian 3"))
            {
               wantedpoints = Guardian3;
            }
            if (StringChecker(B, "Brave 1"))
            {
               wantedpoints = Brave;
            }
            if (StringChecker(B, "Brave 2"))
            {
               wantedpoints = Brave2;
            }
            if (StringChecker(B, "Brave 3"))
            {
               wantedpoints = Brave3;
            }
            if (StringChecker(B, "Heroic 1"))
            {
               wantedpoints = Heroic;
            }
            if (StringChecker(B, "Heroic 2"))
            {
               wantedpoints = Heroic2;
            }
            if (StringChecker(B, "Heroic 3"))
            {
               wantedpoints = Heroic3;
            }
            if (StringChecker(B, "Fabled 1"))
            {
               wantedpoints = Fabled;
            }
            if (StringChecker(B, "Fabled 2"))
            {
               wantedpoints = Fabled2;
            }
            if (StringChecker(B, "Fabled 3"))
            {
               wantedpoints = Fabled3;
            }
            if (StringChecker(B, "Mythic 1"))
            {
               wantedpoints = Mythic;
            }
            if (StringChecker(B, "Mythic 2"))
            {
               wantedpoints = Mythic2;
            }
            if (StringChecker(B, "Mythic 3"))
            {
               wantedpoints = Mythic3;
            }
            if (StringChecker(B, "Legend"))
            {
               wantedpoints = Legend;
            }
            if (StringChecker(B, "Max"))
            {
               wantedpoints = Max;
            }
            textBox4.Text = "" + wantedpoints;
            progressBar1.Value = 75;
            Thread.Sleep(100);
            for ( ; IntChecker(points, wantedpoints);)
            {
                points = points + 100;
                if (points < 7500)
                {
                    losses = losses + 2;
                }
                else
                {
                    if (points < 12000)
                    {
                        losses = losses + 4;
                    }
                }
                wins = wins + 1;
            }
            progressBar1.Value = 100;
            Thread.Sleep(200);
            if (checkBox1.Checked)
            {
                textBox5.Visible = true;
                textBox5.Text = "Points: " + points;
            }
            else
            {
                textBox5.Visible = false;
                textBox5.Text = "";
            }
            textBox3.Text = "Wins: " + wins;
            textBox4.Text = "Losses: " + losses + " " + over;
            progressBar1.Visible = false;
        }

       
    }
}
