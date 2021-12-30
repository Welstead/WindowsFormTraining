using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class frmMain : Form
    {

        private NumberGuessingLogic _gameLogic = new NumberGuessingLogic();
        private int lives = 5;
        private int maxNumber = 100;
        public frmMain()
        {
            InitializeComponent();

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            _gameLogic.GameSetup(lives,maxNumber+1);
            label4.Hide();
            lblRandomNumber.Hide();
            
            btnSubmitGuess.Enabled = true;
            
            txtRngNum.Enabled = true;
            

            lblFeedback.Text = "";
            lblRandomNumber.Text = _gameLogic.currentAnswer.ToString();
            lblLivesRemaining.Text = lives.ToString();
            lblHint.Text = _gameLogic.GiveRandomHint();
            
        }

        private void btnSubmitGuess_Click(object sender, EventArgs e)
        {
            try
            {
                int answer = Convert.ToInt32(txtRngNum.Text);
                lblFeedback.Text += "\n" + _gameLogic.CheckAnswer(answer);
            }
            catch (Exception ex)
            {
                lblFeedback.Text += "\n" + ex.Message;
                _gameLogic.Lives--;
            }
            txtRngNum.Text = "";
            lblLivesRemaining.Text = _gameLogic.Lives.ToString();
            if(_gameLogic.Lives < 1)
            {
                label4.Show();
                lblRandomNumber.Show();
                btnSubmitGuess.Enabled = false;
                txtRngNum.Enabled=false;
                lblFeedback.Text += "\n" + "Game Over";
            }
        }
    }
}
