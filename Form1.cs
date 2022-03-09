
namespace ImageViewer
{
   

    public partial class Form1 : Form
    {
       


        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("To display an image click the 'open' button. This is located on your menu.", "Helpful Hints!", MessageBoxButtons.OK, MessageBoxIcon.Information); /* When the application form is loaded, the user is prompted with a 'helpful' message */ 
        }

        private void pictureBox1_Click(object sender, EventArgs e) 
        {
           
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); /* This component called 'OpenFileDialog' opens the windows dialog box for browsing and/or selectingh files */
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png|Gif (*.gif)|*.gif"; // By Typing the example: Gif (*.gif)|*.gif     I was able to filter what images I wish to open/view/saveas   
            
            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                pbDisplay.SizeMode = PictureBoxSizeMode.Zoom;
                pbDisplay.Image = Image.FromFile(ofd.FileName);
                
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png|Gif (*.gif)|*.gif";

            MessageBox.Show("You are about to save this image. Be careful not to make duplicates!", "Helpful Hints!", MessageBoxButtons.OK, MessageBoxIcon.Information); /* This clears the picturebox for any given reason */
           
            if (sfd.ShowDialog() == DialogResult.Yes)
            {
                pbDisplay.Image.Save(sfd.FileName);
            }



        }

        private void tsmDelete_Click(object sender, EventArgs e) //* This enables us to clear an image from the picturebox, should it have one
        {
            MessageBox.Show("Open another picture to view something!", "Helpful Hints!", MessageBoxButtons.OK, MessageBoxIcon.Information); /* When the user chooses to save an image, the user is prompted with a 'helpful' message */
            pbDisplay.Image = null;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //* This enables us to close the application simply, by clicking the Exit button
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
            

      
}
    
    }

