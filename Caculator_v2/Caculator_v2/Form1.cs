using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // local variable
        List<string> expression = new List<string>();
        string savedNumber = "";
        int indexNow = 0;
        string calculation = "+-*/";

        // helper functions - start
        string TextResultOfExpression(List<string> expression)
        {
            string Text = "";

            foreach (string element in expression)
            {
                Text += element;
            }

            return Text;
        }
        void ShowExpression(List<string> expression)
        {
            Console.WriteLine("Count: " + expression.Count);
            Console.WriteLine("=======================");
            foreach (string element in expression)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("=======================");
            Console.WriteLine();
        }
        void AddNumberToExpresstion (string number)
        {

            if(expression.Count == 0)
            {
                expression.Add(number);
            }
            else
            {
                string lastElement = expression[expression.Count - 1];
                if(calculation.Contains(lastElement))
                {
                    expression.Add(number);
                    indexNow += 1;
                }
                else
                {
                    expression[indexNow] = number;
                }
            }
            ShowExpression(expression);
        }
        void HandleBehaviorOfKey (string char1, string dupChar)
        {
            int i = 0;
            Console.WriteLine("Step " + (i + 1));

            if(expression.Count == 1 && expression[0] + "0" == dupChar)
            {
                if (!expression[0].Contains("."))
                {
                    return;
                }
            }

            Console.WriteLine("Step " + (i + 1));

            if (savedNumber == "0")
            {

                Console.WriteLine("Step " + (i + 1));

                if (expression.Count == 0)
                {
                    savedNumber = char1;
                }
                else
                {
                    string lastElement = expression[expression.Count - 1];
                    if(lastElement.Contains("."))
                    {
                        savedNumber += char1;
                    }
                    else
                    {
                        savedNumber = char1;
                    }
                }
            }
            else
            {
                Console.WriteLine("Step " + (i + 1));

                savedNumber += char1;
            }

            AddNumberToExpresstion(savedNumber);
            txtDisplayLastNumber.Text = savedNumber;
            txtDisplayExpression.Text += char1;

            if(txtDisplayExpression.Text.Length == 2 && txtDisplayExpression.Text[0] == '0')
            {
                txtDisplayExpression.Text = txtDisplayExpression.Text.Substring(1);
            }

            ShowExpression(expression);
        }
        void HandleOnClickCaculationKey(string input)
        {
            if (expression.Count == 0)
            {
                return;
            }

            string lastElement = expression[expression.Count - 1];
            if (calculation.Contains(lastElement))
            {
                return;
            }
            else
            {
                if(expression.Count == 1 && (txtDisplayExpression.Text != TextResultOfExpression(expression)))
                {
                    txtDisplayExpression.Text = expression[0];
                }

                char lastChar = txtDisplayLastNumber.Text[txtDisplayLastNumber.Text.Length - 1];
                if(lastChar == '.')
                {
                    // Remove '.' if not add more number behind it
                    expression[expression.Count - 1] = expression[expression.Count - 1].Substring(0, expression[expression.Count - 1].Length - 1);
                    txtDisplayExpression.Text = txtDisplayExpression.Text.Substring(0, txtDisplayExpression.Text.Length-1);
                }

                indexNow += 1;
                expression.Add(input);
                txtDisplayExpression.Text += input;
                txtDisplayLastNumber.Text = "0";
                savedNumber = "0";
            }
        }
        // helper functions - end

        // key 0 -> 9 - start
        private void btn_num_0_Click(object sender, EventArgs e)
        {
            HandleBehaviorOfKey("0", "00");
        }

        private void btn_num_1_Click(object sender, EventArgs e)
        {
            HandleBehaviorOfKey("1", "");
        }

        private void btn_num_2_Click(object sender, EventArgs e)
        {
            HandleBehaviorOfKey("2", "");
        }

        private void btn_num_3_Click(object sender, EventArgs e)
        {
            HandleBehaviorOfKey("3", "");
        }

        private void btn_num_4_Click(object sender, EventArgs e)
        {
            HandleBehaviorOfKey("4", "");
        }

        private void btn_num_5_Click(object sender, EventArgs e)
        {
            HandleBehaviorOfKey("5", "");
        }

        private void btn_num_6_Click(object sender, EventArgs e)
        {
            HandleBehaviorOfKey("6", "");
        }

        private void btn_num_7_Click(object sender, EventArgs e)
        {
            HandleBehaviorOfKey("7", "");
        }

        private void btn_num_8_Click(object sender, EventArgs e)
        {
            HandleBehaviorOfKey("8", "");
        }

        private void btn_num_9_Click(object sender, EventArgs e)
        {
            HandleBehaviorOfKey("9", "");
        }
        // key 0 -> 9 - end

        // basic expression - start
        // plus
        private void btn_plus_Click(object sender, EventArgs e)
        {
            HandleOnClickCaculationKey("+");
        }

        // sub
        private void btn_sub_Click(object sender, EventArgs e)
        {
            HandleOnClickCaculationKey("-");
        }

        // multi
        private void btn_multi_Click(object sender, EventArgs e)
        {
            HandleOnClickCaculationKey("*");
        }

        // div
        private void btn_div_Click(object sender, EventArgs e)
        {
            HandleOnClickCaculationKey("/");
        }


        // dot
        private void btn_dot_Click(object sender, EventArgs e)
        {
            if(expression.Count == 0)
            {
                return;
            }

            if (expression.Count == 1 && (txtDisplayExpression.Text != TextResultOfExpression(expression)))
            {
                txtDisplayExpression.Text = expression[0];
            }

            string lastElement = expression[expression.Count - 1];
            if(calculation.Contains(lastElement))
            {
                return;
            }

            savedNumber += ".";
            txtDisplayLastNumber.Text = savedNumber;
            expression[indexNow] = savedNumber;
            txtDisplayExpression.Text += ".";
        }


        // negative
        private void btn_negative_num_Click(object sender, EventArgs e)
        {
            if(expression.Count == 0)
            {
                return;
            }

            string lastElement = expression[expression.Count - 1];
            if (lastElement[lastElement.Length - 1] == '.')
            {
                // Remove XX. Example: 123.
                lastElement = lastElement.Substring(0, lastElement.Length - 1);

                if (lastElement.Contains("-"))
                {
                    expression[expression.Count - 1] = lastElement.Substring(1);
                }
                else
                {
                    expression[expression.Count - 1] = "-" + lastElement;
                }
            }
            else
            {
                if (lastElement.Contains("-"))
                {
                    expression[expression.Count - 1] = lastElement.Substring(1);
                }
                else
                {
                    expression[expression.Count - 1] = "-" + lastElement;
                }
            }

            savedNumber = expression[expression.Count - 1];
            txtDisplayLastNumber.Text = savedNumber;

            int lengthPreLastNumber = savedNumber.Length + 1;
            if (savedNumber.Contains("-"))
            {
                lengthPreLastNumber = savedNumber.Length - 1;
            }

            txtDisplayExpression.Text = txtDisplayExpression.Text.Substring(0, txtDisplayExpression.Text.Length - lengthPreLastNumber);
            txtDisplayExpression.Text += savedNumber;
            ShowExpression(expression);
        }

        // basic expression - end

        // advenced expression - start
        private void btn_percent_Click(object sender, EventArgs e)
        {
            string TextExpression = "(" + TextResultOfExpression(expression) + ")/100";
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(double), TextExpression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);

            double Result = (double)row["expression"];
            string TextResult = Result.ToString();

            expression.Clear();
            indexNow = 0;
            expression.Add(TextResult);

            txtDisplayLastNumber.Text = TextResult;
            txtDisplayExpression.Text = TextResult;

            ShowExpression(expression);
        }

        private void btn_1_div_x_Click(object sender, EventArgs e)
        {
            string TextExpression = "1/("+ TextResultOfExpression(expression)+")";
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(double), TextExpression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);

            double Result = (double)row["expression"];
            string TextResult = Result.ToString();

            expression.Clear();
            indexNow = 0;
            expression.Add(TextResult);

            txtDisplayLastNumber.Text = TextResult;
            txtDisplayExpression.Text = TextResult;

            ShowExpression(expression);
        }

        private void btn_power_2_Click(object sender, EventArgs e)
        {
            string TextExpression = TextResultOfExpression(expression);
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(double), TextExpression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);

            double Result = (double)row["expression"];
            Result = Result * Result;
            string TextResult = Result.ToString();

            expression.Clear();
            indexNow = 0;
            expression.Add(TextResult);

            txtDisplayLastNumber.Text = TextResult;
            txtDisplayExpression.Text = TextResult;

            ShowExpression(expression);
        }

        private void btn_square_root_Click(object sender, EventArgs e)
        {
            string TextExpression = TextResultOfExpression(expression);
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(double), TextExpression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);

            double Result = (double)row["expression"];
            Result = Math.Sqrt(Result);
            string TextResult = Result.ToString();

            expression.Clear();
            indexNow = 0;
            expression.Add(TextResult);

            txtDisplayLastNumber.Text = TextResult;
            txtDisplayExpression.Text = TextResult;

            ShowExpression(expression);
        }
        // advenced expression - end

        // del functions  - start
        // del a char in last number
        private void btn_del_a_char_Click(object sender, EventArgs e)
        {
            savedNumber = savedNumber.Substring(0, savedNumber.Length - 1);
            txtDisplayLastNumber.Text = savedNumber;
            txtDisplayExpression.Text = txtDisplayExpression.Text.Substring(0, txtDisplayExpression.Text.Length - 1);

            expression[expression.Count - 1] = expression[expression.Count - 1].Substring(0, expression[expression.Count - 1].Length - 1);

            ShowExpression(expression);
        }
        // del last number
        private void btn_del_a_number_Click(object sender, EventArgs e)
        {
            savedNumber = "";
            string lastElement = expression[expression.Count - 1];

            expression[expression.Count - 1] = "0";
            txtDisplayExpression.Text = txtDisplayExpression.Text.Substring(0, txtDisplayExpression.Text.Length - lastElement.Length);
            txtDisplayLastNumber.Text = "0";

            ShowExpression(expression);
        }
        // del all
        private void btn_del_all_Click(object sender, EventArgs e)
        {
            savedNumber = "";
            txtDisplayLastNumber.Text = "0";
            txtDisplayExpression.Text = "";
            expression.Clear();
            indexNow = 0;

            ShowExpression(expression);
        }


        // Equal
        private void btn_equal_Click(object sender, EventArgs e)
        {
            string TextExpression = TextResultOfExpression(expression);
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(double), TextExpression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);

            double Result = (double)row["expression"];
            string TextResult = Result.ToString();

            expression.Clear();
            indexNow = 0;
            expression.Add(TextResult);

            txtDisplayLastNumber.Text = TextResult;

            if (txtDisplayExpression.Text[txtDisplayExpression.Text.Length - 1] == '.')
            {
                txtDisplayExpression.Text = TextResult;
            }

            ShowExpression(expression);
        }
        // del functions  - end
    }
}
