using System.Numerics;

namespace Lab5
{
    //i got to the end of the lab without realizing i never pushed my commits haha
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Random rand = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            radOneRoll.Checked = true;
            Text += "Lucas";


        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            ClearOneRoll();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            ClearStats();

        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            int dice1, dice2;
            dice1 = RollDice();
            dice2 = RollDice();
            lblDice1.Text = dice1.ToString();
            lblDice2.Text = dice2.ToString();
            lblRollName.Text = GetName(dice1, dice2);

        }

        private void ClearOneRoll()
        {

            lblDice1.Text = "";
            lblDice2.Text = "";
            lblRollName.Text = "";

        }

        /* Name: ClearStats
        *  Sent: nothing
        *  Return: nothing
        *  Reset nud to minimum value, chkbox unselected, 
        *  clear labels and listbox */

        private void ClearStats()
        {
            lblPass.Text = "";
            lblFail.Text = "";
            lblAverage.Text = "";
            lstMarks.Text = "";

            lstMarks.Items.Clear();
        }


        private int RollDice()
        {
            int dice = rand.Next(1, 7);
            return dice;

        }

        private string GetName(int dice1, int dice2)
        {
            int total = dice1 + dice2;

            switch (total)
            {
                case 2:
                    return "Snake Eyes";
                case 3:
                    return "Little Joe";
                case 5:
                    return "Fever";
                case 7:
                    return "Most Commmon";
                case 9:
                    return "Center field";
                case 11:
                    return "Yo-leven";
                case 12:
                    return "Boxcars";
                default:
                    return lblRollName.Text = "No special Name";
            }
        }


        private void btnSwapNumbers_Click(object sender, EventArgs e)
        {
            SwapData();
        }

        /* Name: DataPresent
        * Sent: string
        * Return: bool (true if data, false if not) 
        * See if string is empty or not*/


        /* Name: SwapData
        * Sent: 2 strings
        * Return: none 
        * Swaps the memory locations of two strings*/
        private void SwapData()
        {
            string temp = lblDice1.Text;

            lblDice1.Text = lblDice2.Text;

            lblDice2.Text = temp;

        }




        private void btnGenerate_Click(object sender, EventArgs e)
        {





            lstMarks.Items.Clear();
            int[] array = new int[Convert.ToInt32(nudNumber.Value)];


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(40, 101);
                lstMarks.Items.Add(array[i]);


            }

            int pass = 0;
            int fail = 0;
           
            //check if seed value


            //fill array using random number

            //call CalcStats sending and returning data
            double total = CalcStats(array, ref pass, ref fail);

            lblPass.Text = pass.ToString();
            lblFail.Text = fail.ToString();
            lblAverage.Text = total.ToString();
           

            
            //display data sent back in labels - average, pass and fail
            // Format average always showing 2 decimal places 

        } // end Generate click

        private void chkSeed_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do you want to use a random seed value", "Confirm seed value", MessageBoxButtons.YesNo);

            if (Result == DialogResult.No)
            {
                chkSeed.Checked = false;
                rand = new Random();
            }

            else if (Result == DialogResult.Yes)
            {
                rand = new Random(1000);
            }
           
        }

        /* Name: CalcStats
        * Sent: array and 2 integers
        * Return: average (double) 
        * Run a foreach loop through the array.
        * Passmark is 60%
        * Calculate average and count how many marks pass and fail
        * The pass and fail values must also get returned for display*/
        private double CalcStats(int[] array , ref int pass, ref int fail)
        {
            double total = 0; 
             pass = 0;
             fail = 0;
            foreach (int num in array)
            {

                total += num;

                if( num >= 60)
                {
                    pass++;
                }

                else
                {
                    fail++;
                }

            }
            total /= array.Length;
                return total;
                
        }

    }
}
