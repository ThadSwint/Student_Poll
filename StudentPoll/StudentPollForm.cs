// Thad Swint
// Ex. 17.8: StudentPoll.cs
// Allow student to take a survey
// and view the results in a TextBox
using System;
using System.Windows.Forms;
using System.IO;

namespace StudentPoll
{
   public partial class StudentPollForm : Form
   {
      StreamWriter writer;
      StreamReader input;
      int number;
 

      // parameterless constructor
      public StudentPollForm()
      {
         InitializeComponent();

            //Create the StreamWriter object
            writer = new StreamWriter("numbers.txt");
      } // end constructor

      private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            //Add exception handling
            if (String.IsNullOrEmpty(inputTextBox.Text))
            {
               MessageBox.Show("Please fill in the TextBox.");
            } // end if
            else
            {

               number = Convert.ToInt32(inputTextBox.Text);

               //  Validate that the number is 1 - 10. When valid, use method Write to put the value into the file
               //  Write or else pop up error
              if(number > 0 && number < 11)
                    {
                        writer.Write(number + ":");                        
                    }
                    else
                    {
                        MessageBox.Show("Number must be between 1 and 10");
                    }
               
            } // end else

            inputTextBox.Clear();
         } // end if
      }
        private void doneButton_Click_1(object sender, EventArgs e)
        {

            writer.Close();
            //Change properties such that the display button can be used and this button can't be used. The textbox should be read-only
            displayButton.Enabled = true;
            doneButton.Enabled = false;
            displayTextBox.ReadOnly = true;


        }

        private void displayButton_Click(object sender, EventArgs e)
        {

            input = new StreamReader("numbers.txt");

            string inputString = input.ReadToEnd();
            string[] stringArray;
            int[] frequency = new int[11];
            //Split the read data into the array. Populate another integer array with the values from the string array converted
            //   to integers. Update the frequency array to include a count for each of the responses. Refer to Figure 8.8

            stringArray = inputString.Split(':');
            for (int i = 0; i < stringArray.Length; i++)
            {
                
                for (int j = 0; j < frequency.Length; j++)
                {
                    if (stringArray[i] == "")
                    {
                        break;
                    }
                    else if (j == System.Convert.ToInt32(stringArray[i]))
                    {
                        frequency[j]++;
                    }
                }
            }

        
            displayTextBox.Clear();
            displayTextBox.AppendText("Rating\tFrequency\n");
            for (var rating = 1; rating < frequency.Length; ++rating)
            {
                displayTextBox.AppendText($"{rating}\t{frequency[rating]}\n");
            }
        }
        // Prevent non numeric digits
        private void inputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    } // end class StudentPollForm
} // end namespace StudentPoll

