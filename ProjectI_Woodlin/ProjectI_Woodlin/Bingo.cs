using ProjectI_Woodlin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Ayanna Woodlin
 * Frank Friedman
 * Project 1: Bingo
 * 1/24/2019
 * Driver class of the game
 * */

namespace ProjectI_Woodlin
{
    public partial class frmBingo : Form
    {
        public frmBingo()
        {
            InitializeComponent();
        }
        private Player player;
        private const int BINGOCARDSIZE = 5;
        private const int NUMBERSPERCOLUMN = 15;
        private const int MAXBINGONUMBER = 75;
        private int calledNumberCount;
        private Button[,] newButton = new Button[BINGOCARDSIZE, BINGOCARDSIZE];
        private int nextCalledNumber = 0;
        private char bingoHeader;
        //total width and height of a card cell
        int cardCellWidth = 75;
        int cardCellHeight = 75;
        int barWidth = 6;  // Width or thickness of horizontal and vertical bars
        int xcardUpperLeft = 45;
        int ycardUpperLeft = 45;
        int padding = 20;
        char[] bingoLetters = new char[BINGOCARDSIZE];
        int rowID;
        int colID;
        private void showOtherControls()
        {
            txtRules.Visible = true;
            txtCalledNumber.Visible = true;
            btnDontHave.Visible = true;
            pnlBingoCard.Visible = true;
        }

        //Creates the BINGO card for play
        private void createCard()
        {
            Size size = new Size(75, 75);
            Point loc = new Point(0, 0);
            int topMargin = 60;
            int x;
            int y;
            bingoLetters[0] = 'B';
            bingoLetters[1] = 'I';
            bingoLetters[2] = 'N';
            bingoLetters[3] = 'G';
            bingoLetters[4] = 'O';
            //Draw column indexes
            y = 0;
            drawColumnLabels();

            x = xcardUpperLeft;
            y = ycardUpperLeft;

            //Draw top line for card
            drawHorizBar(x, y, BINGOCARDSIZE);
            y = y + barWidth;

            //The board is treated like a 5x5 array
            drawVertBar(x, y);
            for (int row = 0; row < BINGOCARDSIZE; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 50;
                for (int col = 0; col < BINGOCARDSIZE; col++)
                {
                    newButton[row, col] = new Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding) + barWidth, loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);

                    if (row == BINGOCARDSIZE / 2 && col == BINGOCARDSIZE / 2)
                    {
                        newButton[row, col].Font = new Font("Arial", 10, FontStyle.Bold);
                        newButton[row, col].Text = "Free \n Space";
                        newButton[row, col].BackColor = System.Drawing.Color.Orange;
                        newButton[row, col].Enabled = false;
                    }
                    else
                    {
                        newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                        newButton[row, col].Text = Globals.RNGObj.getRandomValue(bingoLetters[col]).ToString();
                    }  // end if    
                   // newButton[row, col].Enabled = true;
                    newButton[row, col].Name = "btn" + row.ToString() + col.ToString();

                    // Associates the same event handler with each of the buttons generated
                    newButton[row, col].Click += new EventHandler(Button_Click);

                    // Add button to the form
                    pnlBingoCard.Controls.Add(newButton[row, col]);

                    // Draw vertical delimiter                 
                    x += cardCellWidth + padding;
                    if (row == 0) drawVertBar(x - 5, y);
                } // end for col
                // One row now complete

                // Draw bottom square delimiter if square complete
                x = xcardUpperLeft - 20;
                y = y + cardCellHeight + padding;
                drawHorizBar(x + 25, y - 10, BINGOCARDSIZE - 10);
            } // end for row

            // Draw column indices at bottom of card
            y += barWidth - 1;
            drawColumnLabels();
            Globals.selectedNumbersListObj.reset();
        } //end createCard

        private void drawColumnLabels()
        {
            Label lblColID = new Label();
            lblColID.Font = new System.Drawing.Font("Lucida Sans", (float)24.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblColID.ForeColor = System.Drawing.Color.Orange;
            lblColID.Location = new System.Drawing.Point(cardCellWidth, 0);
            lblColID.Name = "lblColIDBINGO";
            lblColID.Size = new System.Drawing.Size(488, 32);
            lblColID.TabIndex = 0;
            lblColID.Text = "B\tI\tN\tG\tO";
            pnlBingoCard.Controls.Add(lblColID);
            lblColID.Visible = true;
            lblColID.Visible = true;
            lblColID.CreateControl();
            lblColID.Show();
        }   //end drawColumnLabels

        //draw the dark horizontal bar
        private void drawHorizBar(int x, int y, int cardSize)
        {
            int currentx;
            currentx = x;

            Label lblHorizBar = new Label();
            lblHorizBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblHorizBar.Location = new System.Drawing.Point(currentx, y);
            lblHorizBar.Name = "lblHorizBar";
            lblHorizBar.Size = new System.Drawing.Size((cardCellWidth + padding - 1) * BINGOCARDSIZE, barWidth);
            lblHorizBar.TabIndex = 20;
            pnlBingoCard.Controls.Add(lblHorizBar);
            lblHorizBar.Visible = true;
            lblHorizBar.CreateControl();
            lblHorizBar.Show();
            currentx = currentx + cardCellWidth;
        }   //end drawHorizBar

        //draw the dark vertical bar
        private void drawVertBar(int x, int y)
        {
            Label lblVertBar = new Label();
            lblVertBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblVertBar.Location = new System.Drawing.Point(x, y);
            lblVertBar.Name = "lblVertBar" + x.ToString();
            lblVertBar.Size = new System.Drawing.Size(barWidth, (cardCellHeight + padding - 1) * BINGOCARDSIZE);
            lblVertBar.TabIndex = 19;
            pnlBingoCard.Controls.Add(lblVertBar);
            lblVertBar.Visible = true;
            lblVertBar.CreateControl();
            lblVertBar.Show();
        }   //end drawVertBar

        private void Button_Click(object sender, EventArgs e)
        {
            int bingoCount;
            int selectedNumber; // number randomly selected
            Boolean bingoWinner;
           
            int rowID = convertCharToInt(((Button)sender).Name[3]);
            int colID = convertCharToInt(((Button)sender).Name[4]);

          //  MessageBox.Show("Cell[" + rowID + "," + colID + "] has been selected");

            selectedNumber = Convert.ToInt32(newButton[rowID, colID].Text);
            if (selectedNumber == nextCalledNumber)
            {
                newButton[rowID, colID].BackColor = Color.Orange;
                Globals.BingoCard.recordCalledNumber(rowID, colID);
                Globals.selectedNumbersListObj.setUsedNumber(selectedNumber);
                //MessageBox.Show("you selected " + selectedNumber + ".");
                //check for bingo
                bingoWinner = Globals.BingoCard.isBingo();
                if (bingoWinner == true)
                {
                    MessageBox.Show(player.getName() + " you are a winner!", "Winner!");
                    this.Close();
                }
                else
                {
                    playGame();
                }
            }
            else
            {
                MessageBox.Show("You selected " + selectedNumber + ". It does not match the called number: " + txtCalledNumber.Text + "\n, Please try again.");
            }
        }   //end Button_Click

        private int convertCharToInt(char c)
        {
            return ((int)c - (int)('0'));
        }   //end convertCharToInt

        private void playGame()
        {
            string calledNumber = "";
            calledNumberCount++;
            //System.Diagnostics.Debug.WriteLine(calledNumberCount);
            if (calledNumberCount < MAXBINGONUMBER)
            {
                bingoHeader = bingoLetters[Globals.RNGObj.getRandomColumnHeader()];
                nextCalledNumber = Globals.RNGObj.getRandomValue(bingoHeader);
                calledNumber = bingoHeader + " " + nextCalledNumber;
                txtCalledNumber.Text = calledNumber;
            }
            else
            {
                MessageBox.Show("All bingo numbers called. \n You must have missed one or more numbers. \n Game Over!", "All Numbers Used");
                this.Close();
            }
            
        }
        private string getFirstCalledNumber()
        {
            string calledNumber = "";
            bingoHeader = bingoLetters[Globals.RNGObj.getRandomColumnHeader()];
            nextCalledNumber = Globals.RNGObj.getRandomValue(bingoHeader);
            calledNumber = bingoHeader + " " + nextCalledNumber;
            return calledNumber;
        }

        




        //-----------------------------------------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (name == "")
            {
                MessageBox.Show("Name cannot be blank. Enter a name", "Try again");
                txtName.Text = "";
                txtName.Focus();
            }
            else
            {
                player = new Player(name);
                createCard();
                showOtherControls();
                txtCalledNumber.Text = getFirstCalledNumber();
            }
        }   //end btnPlay_Click   

        private void btnDontHave_Click(object sender, EventArgs e)
        {
            playGame();
        }
    }
}
