using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cards
{
    public partial class Desk : Form
    {
        private string folderPath;
        //private List<string> fileNames = new List<string>();
        private string[] fileNames = null;
        private Random rand = new Random();
        private List<PictureBox> cardImages = new List<PictureBox>();
        private List<string> cardFilePaths = new List<string>();
        bool mouseHold = false;
        bool cardsFlipped = false;
        private int deltaX;
        private int deltaY;

        public Desk()
        {
            InitializeComponent();
            InitializeDesk();
        }

        private void InitializeDesk()
        {
            this.BackColor = Color.Green;
        }

        private string SelectFolder()
        {
            var selectFolderDg = new FolderBrowserDialog();         
            DialogResult result = selectFolderDg.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(selectFolderDg.SelectedPath))
            {
                return selectFolderDg.SelectedPath;
            }
            return null;
        }

        private void btnLoadCards_Click(object sender, EventArgs e)
        {
            folderPath = @"C:\Users\Brahmin\Downloads\Cards-master\Playing Cards\playing_card_images\face";

            fileNames = Directory.GetFiles(folderPath);
            PictureBox loadedCard = null;

            foreach (var fileName in fileNames)
            {
                cardFilePaths.Add(fileName);

                loadedCard = new PictureBox()
                {
                    Height = 100,
                    Width = 70,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Left = rand.Next(400),
                    Top = rand.Next(50, 300),
                    Image = Image.FromFile(fileName)
                };

                this.Controls.Add(loadedCard);
                cardImages.Add(loadedCard);
                loadedCard.DoubleClick += new EventHandler(Card_DoubleClick);
                loadedCard.MouseDown += new MouseEventHandler(Card_MouseDown);
                loadedCard.MouseUp += new MouseEventHandler(Card_MouseUp);
                loadedCard.MouseMove += new MouseEventHandler(Card_MouseMove);
            }
        }

        private void btnStackCards_Click(object sender, EventArgs e)
        {
            int x = 100;
            int y = 100;
            foreach (var card in cardImages)
            {
                card.Location = new Point(x++, y++);
            }
        }

        private void btnDeckCards_Click(object sender, EventArgs e)
        {
            int counter = 0;
            for (int x = 1; x < 10; x++)
            {
                for (int y = 1; y < 7; y++)
                {
                    cardImages[counter].Location = new Point(x * 75, y * 105);
                    counter++;
                }
            }
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
                var card = (PictureBox)sender;
                card.Location = new Point(0, 30);
                card.BringToFront();          
        }

        private void Card_MouseDown(object sender, MouseEventArgs e)
        {
            var card = (PictureBox)sender;
            if (e.Button == MouseButtons.Left)
            {
                mouseHold = true;
                deltaX = e.X;
                deltaY = e.Y;
                card.BringToFront();
            }           
        }

        private void Card_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseHold = false;
            }
        }

        private void Card_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseHold)
            {
                var card = (PictureBox)sender;
                card.Top = e.Y + card.Top - deltaY;
                card.Left = e.X + card.Left - deltaX;
            }           
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            if (cardsFlipped)
                ShowBack();
            else
                ShowFace();

            cardsFlipped = !cardsFlipped;
        }

        private void ShowBack()
        {
            string BackImage = @"C:\Users\Brahmin\Downloads\Cards-master\Playing Cards\playing_card_images\back\green_back.png";
            foreach (var card in cardImages)
            {
                card.Image = Image.FromFile(BackImage);
            }           
        }

        private void ShowFace()
        {
            for (int i = 0; i < 54; i++)
                cardImages[i].Image = Image.FromFile(cardFilePaths[i]);
        }
    }
}
