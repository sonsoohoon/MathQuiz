using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class MathQuiz : Form
    {
        // Create a Random object called randomizer 
        // to generate random numbers.
        private Random randominizer = new Random();

        // These integer variables store the numbers 
        // for the addition problem. 
        private int addend1;
        private int addend2;


        // These integer variables store the numbers 
        // for the subtraction problem. 
        private int subtractionend1;
        private int subtractionend2;

        // These integer variables store the numbers 
        // for the multiplication problem. 
        private int multiplicationend1;
        private int multiplicationend2;

        // These integer variables store the numbers 
        // for the division problem. 
        private int divisionend1;
        private int divisionend2;

        // This integer variable keeps track of the 
        // remaining time.
        int timeLeft;

        public MathQuiz()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Start the quiz by filling in all of the problems
        /// and starting the timer.
        /// </summary>
        public void StartTheQuiz()
        {
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            addend1 = randominizer.Next(51);
            addend2 = randominizer.Next(51);

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            PlusLeftLabel.Text = addend1.ToString();
            PlusRightLabel.Text = addend2.ToString();

            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            PlusResult.Value = 0;

            // Fill in the subtraction problem.
            subtractionend1 = randominizer.Next(1,101);
            subtractionend2 = randominizer.Next(1, subtractionend1);

            MinusLeftLabel.Text = subtractionend1.ToString();
            MinusRightLabel.Text = subtractionend2.ToString();
            MinusResult.Value = 0;

            multiplicationend1 = randominizer.Next(2, 11);
            multiplicationend2 = randominizer.Next(2, 11);

            ProductLeftLabel.Text = multiplicationend1.ToString();
            ProductRightLabel.Text = multiplicationend2.ToString();
            ProductResult.Value = 0;

            divisionend2 = randominizer.Next(2, 11);
            int tempDivision = randominizer.Next(2, 11);
            divisionend1 = tempDivision * divisionend2;

            DivideLeftLabel.Text = divisionend1.ToString();
            DivideRightLabel.Text = divisionend2.ToString();
            DivideResult.Value = 0;





            timeLeft = 30;
            timeLabel.Text = $"{timeLeft} seconds";
            timer1.Start();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            StartButton.Enabled = false;
            timeLabel.BackColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("정답입니다.");
                StartButton.Enabled = true;
            }
            if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = $"{timeLeft} seconds";
                if (timeLeft < 6) timeLabel.BackColor = Color.Red;
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "you are time out!";
                PlusResult.Value = addend1 + addend2;
                MinusResult.Value = subtractionend1 - subtractionend2;
                ProductResult.Value = multiplicationend1 * multiplicationend2;
                DivideResult.Value = divisionend1 / divisionend2;
                MessageBox.Show("time finished!");
                StartButton.Enabled = true;
            }
        } // timer1_Tick end

        /// <summary>
        /// Check the answer to see if the user got everything right.
        /// </summary>
        /// <returns>True if the answer's correct, false otherwise.</returns>
        private bool CheckAnswer()
        {
            if ((addend1 + addend2) == PlusResult.Value &&
                (subtractionend1 - subtractionend2) == MinusResult.Value &&
                (multiplicationend1 * multiplicationend2) == ProductResult.Value &&
                (divisionend1 / divisionend2) == DivideResult.Value)
                return true;
            else
            {
                return false;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answer = sender as NumericUpDown;
            if (answer != null)
            {
                int answer_length =  answer.Value.ToString().Length;
                answer.Select(0,answer_length);
            }
        }
    } //Form end
} //namespace end
