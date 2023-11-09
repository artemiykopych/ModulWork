using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ModulWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            try
            {
                double a1 = Convert.ToInt32(aTr.Text);
                double b1 = Convert.ToInt32(bTr.Text);
                Triangle Tr = new Triangle(b1, a1);

                double a2 = Convert.ToInt32(aSq.Text);
                Square Sq = new Square(a2);

                double a3 = Convert.ToInt32(aPar.Text);
                double b3 = Convert.ToInt32(bPar.Text);
                double c3 = Convert.ToInt32(cPar.Text);
                Parallelepiped Par = new Parallelepiped(a3, b3, c3);

                double r1 = Convert.ToInt32(rCon.Text);
                double h = Convert.ToInt32(hCon.Text);
                Conus Con = new Conus(r1, h);

                double r2 = Convert.ToInt32(rSph.Text);
                Sphere Sph = new Sphere(r2);

                dataGridView1.Rows.Add("Трикутник".ToString(), Math.Round(Tr.CalcArea(), 2), Tr.CalcPerimeter(), Math.Round(Tr.OpisRadius(), 2), Math.Round(Tr.WpisRadius(), 2), "-".ToString());
                dataGridView1.Rows.Add("Квадрат".ToString(), Sq.CalcArea(), Sq.CalcPerimeter(), Math.Round(Sq.OpisRadius(), 2), Math.Round(Sq.WpisRadius(), 2), "-".ToString());
                dataGridView1.Rows.Add("Паралелепіпед".ToString(), Par.CalcSurfaceArea(), "-".ToString(), "-".ToString(), "-".ToString(), Par.CalcVolume());
                dataGridView1.Rows.Add("Конус".ToString(), Math.Round(Con.CalcSurfaceArea(), 2), "-".ToString(), "-".ToString(), "-".ToString(), Math.Round(Con.CalcVolume(), 2));
                dataGridView1.Rows.Add("Шар".ToString(), Math.Round(Sph.CalcSurfaceArea(), 2), "-".ToString(), "-".ToString(), "-".ToString(), Math.Round(Sph.CalcVolume(), 2));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
