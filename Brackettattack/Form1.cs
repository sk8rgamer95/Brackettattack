using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brackettattack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Player_Instance(String playerName, object playerImage, int PlayerID)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NewPlayerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            Random randomN = new Random();
            int pID = randomN.Next(1, 999);
            
            string p = NewPlayerName.Text;
            var pImage = PlayerImageList.SelectedItem;
            int PlayerID = pID;
            
            
            Player_Instance(p, pImage, PlayerID);

            if (CurrentPlayerList.Items.Contains(p))
            {
                string caption = "Name already entered";
                string message = "Pleas enter a different name";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

               


            }
            else
            {
                CurrentPlayerList.Items.Add(p);

                NewPlayerName.ResetText();
            }
            
        }

        private void PlayerImageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RemovePlayerButton_Click(object sender, EventArgs e)
        {
            
            object Player = CurrentPlayerList.SelectedItem;

            CurrentPlayerList.Items.Remove(Player);
        }
    }
}
