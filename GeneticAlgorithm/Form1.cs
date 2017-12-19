using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    public partial class Form1 : Form
    {
        Form2 fm;
        int[] best = new int[11];
        int[,] population = new int[r, 10];
        public int[,] matrix;
        int[,] selected;
        int[,] mutated;
        int rs = 0, cs = 0;
        int compSend;
        int compReceive;
        public static int r = 40, c = 10;

        public Form1()
        {
            InitializeComponent();
        }
        
        public void DataGridFill(DataGridView dg, int[,] matrix, int rows, int columns)
        {
            dg.RowCount = rows;
            dg.ColumnCount = columns;
            int j = 0, i = 0;
            foreach (DataGridViewRow r in dg.Rows)
                r.HeaderCell.Value = (i+=1).ToString();
            foreach (DataGridViewColumn c in dg.Columns)
                c.HeaderCell.Value = (j+=1).ToString();
            for (int m = 0; m < rows; m++)
            {
                for (int n = 0; n < columns; n++)
                    dg.Rows[m].Cells[n].Value = (matrix[m,n]).ToString();
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            matrix = new int[10, 10];
            fm = new Form2();
            fm.Owner = this;
            compSend = Convert.ToInt32(textBoxSend.Text);
            compReceive = Convert.ToInt32(textBoxReceive.Text);

            CreatePopulation(ref population, compSend, compReceive);
            CreateMatrix(ref matrix);
            selected = MainAlgorithms.Selection(population, matrix, ref rs, ref cs, ref best);
            mutated = MainAlgorithms.Mutation1(selected, rs);
            DataGridFill(dataGridView1, population, r, 10);
            DataGridFill(dataGridView2, selected, rs, 10);
            DataGridFill(dataGridView3, mutated, r, 10);
            WriteBest(best);
        }

        public void CreatePopulation(ref int[,] population, int start, int end)
        {
            for (int i = 0; i < r; i++)
            {
                population[i, 0] = start;
                population[i, 9] = end;
                for (int j = 1; j < 9; j++)
                    population[i, j] = Globals.rand.Next(1, 10);
            }
        }

        public void CreateMatrix(ref int[,] matrix)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    matrix[i, j] = Globals.rand.Next(1,10);
                    matrix[j, i] = Globals.rand.Next(1, 10);
                }
                matrix[i, i] = 0;
            }
        }

        public void WriteBest (int[] best)
        {
            string str = "";
            for (int i = 0; i < 10; i++)
                str += Convert.ToString(best[i]) + " ";
            string str1 = Convert.ToString(best[10]);
            textBoxBest.Text = str;
            textBoxBestSum.Text = str1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int compSend = Convert.ToInt32(textBoxSend.Text);
            int compReceive = Convert.ToInt32(textBoxReceive.Text);
            CreatePopulation(ref population, compSend, compReceive);
            selected = MainAlgorithms.Selection(population, matrix, ref rs, ref cs, ref best);
            mutated = MainAlgorithms.Mutation1(selected, rs);
            DataGridFill(dataGridView1, population, r, 10);
            DataGridFill(dataGridView2, selected, rs, 10);
            DataGridFill(dataGridView3, mutated, r, 10);
            WriteBest(best);
        }

        private void buttonCycle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                Experiment();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Experiment();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fm.ShowDialog();
        }

        public void Experiment()
        {
            for (int i = 0; i < r; i++)
                for (int j = 0; j < 10; j++)
                    population[i, j] = mutated[i, j];
            selected = MainAlgorithms.Selection(population, matrix, ref rs, ref cs, ref best);
            mutated = MainAlgorithms.Mutation1(selected, rs);
            DataGridFill(dataGridView1, population, r, 10);
            DataGridFill(dataGridView2, selected, rs, 10);
            DataGridFill(dataGridView3, mutated, r, 10);
            WriteBest(best);
        }

        public void ChangeMatrix()
        {
            matrix[1, 0] = Convert.ToInt32(fm.textBox21.Text);
            matrix[2, 0] = Convert.ToInt32(fm.textBox31.Text);
            matrix[2, 1] = Convert.ToInt32(fm.textBox32.Text);
            matrix[3, 0] = Convert.ToInt32(fm.textBox41.Text);
            matrix[3, 1] = Convert.ToInt32(fm.textBox42.Text);
            matrix[3, 2] = Convert.ToInt32(fm.textBox43.Text);
            matrix[4, 0] = Convert.ToInt32(fm.textBox51.Text);
            matrix[4, 1] = Convert.ToInt32(fm.textBox52.Text);
            matrix[4, 2] = Convert.ToInt32(fm.textBox53.Text);
            matrix[4, 3] = Convert.ToInt32(fm.textBox54.Text);
            matrix[5, 0] = Convert.ToInt32(fm.textBox61.Text);
            matrix[5, 1] = Convert.ToInt32(fm.textBox62.Text);
            matrix[5, 2] = Convert.ToInt32(fm.textBox63.Text);
            matrix[5, 3] = Convert.ToInt32(fm.textBox64.Text);
            matrix[5, 4] = Convert.ToInt32(fm.textBox65.Text);
            matrix[6, 0] = Convert.ToInt32(fm.textBox71.Text);
            matrix[6, 1] = Convert.ToInt32(fm.textBox72.Text);
            matrix[6, 2] = Convert.ToInt32(fm.textBox73.Text);
            matrix[6, 3] = Convert.ToInt32(fm.textBox74.Text);
            matrix[6, 4] = Convert.ToInt32(fm.textBox75.Text);
            matrix[6, 5] = Convert.ToInt32(fm.textBox76.Text);
            matrix[7, 0] = Convert.ToInt32(fm.textBox81.Text);
            matrix[7, 1] = Convert.ToInt32(fm.textBox82.Text);
            matrix[7, 2] = Convert.ToInt32(fm.textBox83.Text);
            matrix[7, 3] = Convert.ToInt32(fm.textBox84.Text);
            matrix[7, 4] = Convert.ToInt32(fm.textBox85.Text);
            matrix[7, 5] = Convert.ToInt32(fm.textBox86.Text);
            matrix[7, 6] = Convert.ToInt32(fm.textBox87.Text);
            matrix[8, 0] = Convert.ToInt32(fm.textBox91.Text);
            matrix[8, 1] = Convert.ToInt32(fm.textBox92.Text);
            matrix[8, 2] = Convert.ToInt32(fm.textBox93.Text);
            matrix[8, 3] = Convert.ToInt32(fm.textBox94.Text);
            matrix[8, 4] = Convert.ToInt32(fm.textBox95.Text);
            matrix[8, 5] = Convert.ToInt32(fm.textBox96.Text);
            matrix[8, 6] = Convert.ToInt32(fm.textBox97.Text);
            matrix[8, 7] = Convert.ToInt32(fm.textBox98.Text);
            matrix[9, 0] = Convert.ToInt32(fm.textBox101.Text);
            matrix[9, 1] = Convert.ToInt32(fm.textBox102.Text);
            matrix[9, 2] = Convert.ToInt32(fm.textBox103.Text);
            matrix[9, 3] = Convert.ToInt32(fm.textBox104.Text);
            matrix[9, 4] = Convert.ToInt32(fm.textBox105.Text);
            matrix[9, 5] = Convert.ToInt32(fm.textBox106.Text);
            matrix[9, 6] = Convert.ToInt32(fm.textBox107.Text);
            matrix[9, 7] = Convert.ToInt32(fm.textBox108.Text);
            matrix[9, 8] = Convert.ToInt32(fm.textBox109.Text);
            for (int i = 0; i < 10; i++)
            {
                matrix[i, i] = 0;
                for (int j = i; j < 10; j++)
                    matrix[i, j] = matrix[j, i];
            }
        }
    }
}
