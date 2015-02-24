using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioISRAEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
       
        private void btSoma_Click(object sender, EventArgs e)
        {
            int num1, num2, result;
            num1 = Int32.Parse(txtNum1.Text);
            num2 = Int32.Parse(txtNum2.Text);            
            result = num1 + num2;
            lblResult.Text = Convert.ToString(result);
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            lblResult.Text = "0";
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            int num1, num2, result;
            num1 = Int32.Parse(txtNum1.Text);
            num2 = Int32.Parse(txtNum2.Text);
            result = num1 - num2;
            lblResult.Text = Convert.ToString(result);
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            float num1, num2;
            float result;
            num1 = Convert.ToSingle(txtNum1.Text);
            num2 = Convert.ToSingle(txtNum2.Text);
            if (num2 == 0)
            {
                MessageBox.Show("Não é possível efetuar uma divisão por zero!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNum2.Text = "";
                return;
            }
            result = num1 / num2;
            lblResult.Text = Convert.ToString(result);
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            int num1, num2, result;
            num1 = Int32.Parse(txtNum1.Text);
            num2 = Int32.Parse(txtNum2.Text);
            result = num1 * num2;
            lblResult.Text = Convert.ToString(result);
        }
        
    }
}
