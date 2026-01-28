namespace NChapman_Miller_Lab_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblCardName = new Label();
            picBoxSixDia = new PictureBox();
            picBoxAceSpa = new PictureBox();
            picBoxFiveHea = new PictureBox();
            picBoxKingClub = new PictureBox();
            butExit = new Button();
            picBoxTenDia = new PictureBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)picBoxSixDia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxAceSpa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxFiveHea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxKingClub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxTenDia).BeginInit();
            SuspendLayout();
            // 
            // lblCardName
            // 
            lblCardName.AutoSize = true;
            lblCardName.BackColor = Color.FromArgb(252, 244, 188);
            lblCardName.BorderStyle = BorderStyle.FixedSingle;
            lblCardName.Font = new Font("Palatino Linotype", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCardName.Location = new Point(180, 317);
            lblCardName.MaximumSize = new Size(500, 50);
            lblCardName.MinimumSize = new Size(400, 50);
            lblCardName.Name = "lblCardName";
            lblCardName.Size = new Size(400, 50);
            lblCardName.TabIndex = 0;
            lblCardName.Text = "                              ";
            lblCardName.TextAlign = ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(lblCardName, "The name of the card will appear here");
            lblCardName.Click += label1_Click;
            // 
            // picBoxSixDia
            // 
            picBoxSixDia.Image = (Image)resources.GetObject("picBoxSixDia.Image");
            picBoxSixDia.Location = new Point(22, 79);
            picBoxSixDia.Name = "picBoxSixDia";
            picBoxSixDia.Size = new Size(123, 174);
            picBoxSixDia.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxSixDia.TabIndex = 0;
            picBoxSixDia.TabStop = false;
            toolTip1.SetToolTip(picBoxSixDia, "Click the card to reveal its name");
            picBoxSixDia.Click += PictureBox1_Click;
            // 
            // picBoxAceSpa
            // 
            picBoxAceSpa.Image = (Image)resources.GetObject("picBoxAceSpa.Image");
            picBoxAceSpa.Location = new Point(174, 79);
            picBoxAceSpa.Name = "picBoxAceSpa";
            picBoxAceSpa.Size = new Size(123, 174);
            picBoxAceSpa.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxAceSpa.TabIndex = 2;
            picBoxAceSpa.TabStop = false;
            toolTip1.SetToolTip(picBoxAceSpa, "Click the card to reveal its name");
            picBoxAceSpa.Click += pictureBox2_Click;
            // 
            // picBoxFiveHea
            // 
            picBoxFiveHea.Image = (Image)resources.GetObject("picBoxFiveHea.Image");
            picBoxFiveHea.Location = new Point(326, 79);
            picBoxFiveHea.Name = "picBoxFiveHea";
            picBoxFiveHea.Size = new Size(123, 174);
            picBoxFiveHea.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxFiveHea.TabIndex = 3;
            picBoxFiveHea.TabStop = false;
            toolTip1.SetToolTip(picBoxFiveHea, "Click the card to reveal its name");
            picBoxFiveHea.Click += pictureBox3_Click;
            // 
            // picBoxKingClub
            // 
            picBoxKingClub.Image = (Image)resources.GetObject("picBoxKingClub.Image");
            picBoxKingClub.Location = new Point(478, 79);
            picBoxKingClub.Name = "picBoxKingClub";
            picBoxKingClub.Size = new Size(123, 174);
            picBoxKingClub.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxKingClub.TabIndex = 4;
            picBoxKingClub.TabStop = false;
            toolTip1.SetToolTip(picBoxKingClub, "Click the card to reveal its name");
            picBoxKingClub.Click += picBoxKingClub_Click;
            // 
            // butExit
            // 
            butExit.Location = new Point(348, 404);
            butExit.Name = "butExit";
            butExit.Size = new Size(75, 23);
            butExit.TabIndex = 1;
            butExit.Text = "Exit";
            toolTip1.SetToolTip(butExit, "Click here to exit");
            butExit.UseVisualStyleBackColor = true;
            butExit.Click += butExit_Click;
            // 
            // picBoxTenDia
            // 
            picBoxTenDia.Image = (Image)resources.GetObject("picBoxTenDia.Image");
            picBoxTenDia.Location = new Point(630, 79);
            picBoxTenDia.Name = "picBoxTenDia";
            picBoxTenDia.Size = new Size(123, 174);
            picBoxTenDia.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxTenDia.TabIndex = 6;
            picBoxTenDia.TabStop = false;
            toolTip1.SetToolTip(picBoxTenDia, "Click the card to reveal its name");
            picBoxTenDia.Click += picBoxTenDia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 209, 158);
            CancelButton = butExit;
            ClientSize = new Size(800, 450);
            Controls.Add(picBoxTenDia);
            Controls.Add(butExit);
            Controls.Add(picBoxKingClub);
            Controls.Add(picBoxFiveHea);
            Controls.Add(picBoxAceSpa);
            Controls.Add(lblCardName);
            Controls.Add(picBoxSixDia);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picBoxSixDia).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxAceSpa).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxFiveHea).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxKingClub).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxTenDia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCardName;
        private PictureBox picBoxSixDia;
        private PictureBox picBoxAceSpa;
        private PictureBox picBoxFiveHea;
        private PictureBox picBoxKingClub;
        private Button butExit;
        private PictureBox picBoxTenDia;
        private ToolTip toolTip1;
    }
}
