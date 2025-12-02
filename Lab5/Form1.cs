namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Name: Lucas Nevelos
         * Date: November 2025
         * This program rolls one dice or calculates mark stats.
         * Link to your repo in GitHub: 
         * */

        //class-level random object
        Random rand = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            radOneRoll.Checked = true;
            Text += "Lucas";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //call the function
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //call the function

        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            int dice1, dice2;
            lblDice1.Text = RollDice().ToString();
            lblDice2.Text = RollDice().ToString();
            dice1 = Convert.ToInt32(lblDice1.Text);
            dice2 = Convert.ToInt32(lblDice1.Text);
            // call ftn GetName sending total and returning name

            //display name in label

        }

        /* Name: ClearOneRoll
        *  Sent: nothing
        *  Return: nothing
        *  Clear the labels */


        /* Name: ClearStats
        *  Sent: nothing
        *  Return: nothing
        *  Reset nud to minimum value, chkbox unselected, 
        *  clear labels and listbox */


        /* Name: RollDice
        * Sent: nothing
        * Return: integer (1-6)
        * Simulates rolling one dice */
        private int RollDice()
        {
            int dice = rand.Next(1, 7);
            return dice;
         
        }

        /* Name: GetName
        * Sent: 1 integer (total of dice1 and dice2) 
        * Return: string (name associated with total) 
        * Finds the name of dice roll based on total.
        * Use a switch statement with one return only
        * Names: 2 = Snake Eyes
        *        3 = Litle Joe
        *        5 = Fever
        *        7 = Most Common
        *        9 = Center Field
        *        11 = Yo-leven
        *        12 = Boxcars
        * Anything else = No special name*/

        private string GetName(ref int dice1, int dice2)
        {
            int total = dice1 + dice2;

            switch (total)
            {
                case 2:
                    lblRollName.Text = "Snake Eyes";

                    break;

                case 3:
                    lblRollName.Text = "Little Joe";
                    break;

                case 5: 
                    lblRollName.text



                default: return 0;
            }
             

            
        }


        private void btnSwapNumbers_Click(object sender, EventArgs e)
        {
            //call ftn DataPresent twice sending string returning boolean

            //if data present in both labels, call SwapData sending both strings

            //put data back into labels

            //if data not present in either label display error msg
        }

        /* Name: DataPresent
        * Sent: string
        * Return: bool (true if data, false if not) 
        * See if string is empty or not*/


        /* Name: SwapData
        * Sent: 2 strings
        * Return: none 
        * Swaps the memory locations of two strings*/

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //declare variables and array

            //check if seed value

            //fill array using random number

            //call CalcStats sending and returning data

            //display data sent back in labels - average, pass and fail
            // Format average always showing 2 decimal places 

        } // end Generate click

        /* Name: CalcStats
        * Sent: array and 2 integers
        * Return: average (double) 
        * Run a foreach loop through the array.
        * Passmark is 60%
        * Calculate average and count how many marks pass and fail
        * The pass and fail values must also get returned for display*/
    }
}
