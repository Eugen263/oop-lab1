using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace lab1._1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(textBox2.Text, out double x))
            {
                MessageBox.Show("X must be a number!");
                return;
            }

            if (!double.TryParse(textBox1.Text, out double y))
            {
                MessageBox.Show("Y must be a number!");
                return;
            }

            if (x == 0)
            {
                MessageBox.Show("X should be more than zero!");
                return;
            }

            double result = Math.Pow(1 + (1 / Math.Pow(x, 2)), x) - (12 * x * x * y);

            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox4.Text, out double x))
            {
                double result = (((2 * x - 3) * x + 4) * x - 5) * x + 6;
                textBox5.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please provide correct X");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(textBox6.Text, out int a))
            {
                MessageBox.Show("Input correct a");
                return;
            }

            if (!int.TryParse(textBox7.Text, out int b))
            {
                MessageBox.Show("Input correct b");
                return;
            }

            if (!int.TryParse(textBox8.Text, out int c))
            {
                MessageBox.Show("Input correct c");
                return;
            }

            bool isPythagorean = c * c == a * a + b * b;
            label11.Text = isPythagorean.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox9.Text, out double x1))
            {
                MessageBox.Show("Input correct x1");
                return;
            }

            if (!double.TryParse(textBox10.Text, out double y1))
            {
                MessageBox.Show("Input correct y1");
                return;
            }

            if (!double.TryParse(textBox11.Text, out double x2))
            {
                MessageBox.Show("Input correct x2");
                return;
            }

            if (!double.TryParse(textBox12.Text, out double x3))
            {
                MessageBox.Show("Input correct x3");
                return;
            }

            if (!double.TryParse(textBox13.Text, out double y3))
            {
                MessageBox.Show("Input correct y3");
                return;
            }

            if (!double.TryParse(textBox14.Text, out double x4))
            {
                MessageBox.Show("Input correct x4");
                return;
            }

            double left_x = Math.Max(x1, x3);
            double right_x = Math.Min(x2, x4);
            double top_y = Math.Min(y1, y3);
            double bottom_y = 0;

            if (left_x < right_x && top_y > bottom_y)
            {
                double area = (right_x - left_x) * (top_y - bottom_y);

                label21.Text = $"Rectangles intersect. Common area: {area}";
            }
            else
            {
                label21.Text = "Rectangles do not intersect.";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox16.Text, out int n))
            {
                MessageBox.Show("Pleace provide correct n");
                return;
            }
            bool found = false;

            while (!found)
            {
                found = CheckNumber(n);
                n++;
            }
            textBox15.Text = (n - 1).ToString();
        }

        static bool CheckNumber(int n)
        {
            for (int a = 1; a <= n; a++)
            {
                for (int b = a; b <= n; b++)
                {
                    for (int c = 1; c <= n; c++)
                    {
                        for (int d = c; d <= n; d++)
                        {
                            if ((a != c || b != d) && (a * a * a + b * b * b == c * c * c + d * d * d) && (a + b < c + d)) // Перевіряємо, чи можна представити число n у вигляді суми кубів двох різних натуральних чисел
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox17.Text, out int n))
            {
                MessageBox.Show("Please provide correct nubmer of elements in array");
                return;
            }

            int[] inputArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                inputArray[i] = i;
            }

            List<int> evenArray = new List<int>();
            List<int> oddArray = new List<int>();
            //int evenIndex = 0;
            //int oddIndex = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenArray.Add(inputArray[i]);
                    //evenIndex++;
                }
                else
                {
                    oddArray.Add(inputArray[i]);
                    //oddIndex++;
                }
            }

            string even = "";
            for (int i = 0; i < evenArray.Count; i++)
            {
                even += evenArray[i] + " ";
            }
            textBox18.Text = even;

            string odd = "";
            for (int i = 0; i < oddArray.Count; i++)
            {
                odd += oddArray[i] + " ";
            }
            textBox19.Text = odd;
        }

        private void button7_Click(object sender, EventArgs e)
        {   
            HashSet<char> uniqueChars = new HashSet<char>();

            foreach (char c in textBox20.Text)
            {
                if (!uniqueChars.Contains(c))
                {
                    uniqueChars.Add(c);
                }
            }

            string q = "";
            foreach (char c in uniqueChars)
            {
                q += $"{c} ";
            }

            label29.Text = "Uniq symols: " + uniqueChars.Count;
            textBox21.Text = q;
        }
    }
}
