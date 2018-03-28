using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumOfNumbersLeoK
{
    public partial class frmSumOfNumbersLeoK : Form
    {
        public frmSumOfNumbersLeoK()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Local Variables
            Double sumAns;
            Double sumNum;
            int sumCount;

            //clear the listbox items
            this.lstSumNum.Items.Clear();

            //Initialize the answer to 0
            sumAns = 0;

            //get the number from the user
            sumNum = Convert.ToDouble(this.nudNum.Value);

            //Looping
            for (sumCount = 1; sumCount <= sumNum; sumCount++)
            {
                //add the counter number to the list
                this.lstSumNum.Items.Add(sumCount);

                //add the counter to the answer
                sumAns = sumAns + sumCount;
            }
            //display the answer
            this.lblAnswer.Text = this.nudNum.Value + " and all the numbers before it = " + Convert.ToString(sumAns);
        }
    }
}
