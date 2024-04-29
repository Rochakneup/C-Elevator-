namespace L5finalproject
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
            leftDoorDown = new PictureBox();
            rightDoorDown = new PictureBox();
            groundFloorPicture = new PictureBox();
            firstFloorPicture = new PictureBox();
            callDownBtn = new PictureBox();
            elevatorupBtn = new PictureBox();
            groupBox1 = new GroupBox();
            closeDoorBtn = new PictureBox();
            openDoorBtn = new PictureBox();
            goUpBtn = new PictureBox();
            goDownBtn = new PictureBox();
            controlPannelPicture = new PictureBox();
            pictureBox11 = new PictureBox();
            doorOpenTimer = new System.Windows.Forms.Timer(components);
            doorCloseTimer = new System.Windows.Forms.Timer(components);
            goDownTimer = new System.Windows.Forms.Timer(components);
            counterTimer = new System.Windows.Forms.Timer(components);
            goUpTimer = new System.Windows.Forms.Timer(components);
            elevatorUnit = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            datadisplay = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            elevatorIndoor = new PictureBox();
            rightDoorUp = new PictureBox();
            leftDoorUp = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)leftDoorDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightDoorDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groundFloorPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)firstFloorPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)callDownBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elevatorupBtn).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeDoorBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openDoorBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goUpBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goDownBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)controlPannelPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elevatorUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datadisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elevatorIndoor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightDoorUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftDoorUp).BeginInit();
            SuspendLayout();
            // 
            // leftDoorDown
            // 
            leftDoorDown.Image = Properties.Resources.door123;
            leftDoorDown.Location = new Point(243, 560);
            leftDoorDown.Name = "leftDoorDown";
            leftDoorDown.Size = new Size(123, 308);
            leftDoorDown.SizeMode = PictureBoxSizeMode.StretchImage;
            leftDoorDown.TabIndex = 4;
            leftDoorDown.TabStop = false;
            // 
            // rightDoorDown
            // 
            rightDoorDown.Image = Properties.Resources.door123;
            rightDoorDown.Location = new Point(360, 560);
            rightDoorDown.Name = "rightDoorDown";
            rightDoorDown.Size = new Size(118, 308);
            rightDoorDown.SizeMode = PictureBoxSizeMode.StretchImage;
            rightDoorDown.TabIndex = 0;
            rightDoorDown.TabStop = false;
            // 
            // groundFloorPicture
            // 
            groundFloorPicture.Image = Properties.Resources.black;
            groundFloorPicture.Location = new Point(341, 497);
            groundFloorPicture.Name = "groundFloorPicture";
            groundFloorPicture.Size = new Size(45, 30);
            groundFloorPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            groundFloorPicture.TabIndex = 16;
            groundFloorPicture.TabStop = false;
            // 
            // firstFloorPicture
            // 
            firstFloorPicture.Image = Properties.Resources.black;
            firstFloorPicture.Location = new Point(341, 27);
            firstFloorPicture.Name = "firstFloorPicture";
            firstFloorPicture.Size = new Size(45, 30);
            firstFloorPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            firstFloorPicture.TabIndex = 17;
            firstFloorPicture.TabStop = false;
            // 
            // callDownBtn
            // 
            callDownBtn.Image = Properties.Resources.button111;
            callDownBtn.Location = new Point(511, 677);
            callDownBtn.Name = "callDownBtn";
            callDownBtn.Size = new Size(31, 30);
            callDownBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            callDownBtn.TabIndex = 18;
            callDownBtn.TabStop = false;
            callDownBtn.Click += callDownBtn_Click;
            // 
            // elevatorupBtn
            // 
            elevatorupBtn.Image = Properties.Resources.button12;
            elevatorupBtn.Location = new Point(511, 196);
            elevatorupBtn.Name = "elevatorupBtn";
            elevatorupBtn.Size = new Size(31, 30);
            elevatorupBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            elevatorupBtn.TabIndex = 19;
            elevatorupBtn.TabStop = false;
            elevatorupBtn.Click += callUpBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(closeDoorBtn);
            groupBox1.Controls.Add(openDoorBtn);
            groupBox1.Controls.Add(goUpBtn);
            groupBox1.Controls.Add(goDownBtn);
            groupBox1.Controls.Add(controlPannelPicture);
            groupBox1.Controls.Add(pictureBox11);
            groupBox1.Location = new Point(836, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(179, 452);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Elevator Controls";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // closeDoorBtn
            // 
            closeDoorBtn.Image = Properties.Resources.close;
            closeDoorBtn.Location = new Point(92, 375);
            closeDoorBtn.Name = "closeDoorBtn";
            closeDoorBtn.Size = new Size(37, 42);
            closeDoorBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            closeDoorBtn.TabIndex = 21;
            closeDoorBtn.TabStop = false;
            closeDoorBtn.Click += closeDoorBtn_Click;
            // 
            // openDoorBtn
            // 
            openDoorBtn.Image = Properties.Resources.open;
            openDoorBtn.Location = new Point(38, 375);
            openDoorBtn.Name = "openDoorBtn";
            openDoorBtn.Size = new Size(37, 42);
            openDoorBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            openDoorBtn.TabIndex = 21;
            openDoorBtn.TabStop = false;
            openDoorBtn.Click += openDoorBtn_Click;
            // 
            // goUpBtn
            // 
            goUpBtn.Image = Properties.Resources.GoFirstFloor;
            goUpBtn.Location = new Point(56, 171);
            goUpBtn.Name = "goUpBtn";
            goUpBtn.Size = new Size(64, 64);
            goUpBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            goUpBtn.TabIndex = 21;
            goUpBtn.TabStop = false;
            goUpBtn.Click += goUpBtn_Click;
            // 
            // goDownBtn
            // 
            goDownBtn.Image = Properties.Resources.GoZeroFloor;
            goDownBtn.Location = new Point(56, 273);
            goDownBtn.Name = "goDownBtn";
            goDownBtn.Size = new Size(64, 65);
            goDownBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            goDownBtn.TabIndex = 22;
            goDownBtn.TabStop = false;
            goDownBtn.Click += goDownBtn_Click;
            // 
            // controlPannelPicture
            // 
            controlPannelPicture.Image = Properties.Resources.black;
            controlPannelPicture.Location = new Point(39, 26);
            controlPannelPicture.Name = "controlPannelPicture";
            controlPannelPicture.Size = new Size(91, 111);
            controlPannelPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            controlPannelPicture.TabIndex = 0;
            controlPannelPicture.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = SystemColors.ScrollBar;
            pictureBox11.Image = Properties.Resources.bgbg;
            pictureBox11.Location = new Point(0, 26);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(173, 425);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 0;
            pictureBox11.TabStop = false;
            // 
            // doorOpenTimer
            // 
            doorOpenTimer.Interval = 1;
            doorOpenTimer.Tick += doorOpenTimer_Tick;
            // 
            // doorCloseTimer
            // 
            doorCloseTimer.Interval = 1;
            doorCloseTimer.Tick += doorCloseTimer_Tick;
            // 
            // goDownTimer
            // 
            goDownTimer.Interval = 1;
            goDownTimer.Tick += goDownTimer_Tick;
            // 
            // counterTimer
            // 
            counterTimer.Interval = 1;
            counterTimer.Tick += counterTimer_Tick;
            // 
            // goUpTimer
            // 
            goUpTimer.Interval = 1;
            goUpTimer.Tick += goUpTimer_Tick;
            // 
            // elevatorUnit
            // 
            elevatorUnit.Image = Properties.Resources.elevatorunit2;
            elevatorUnit.Location = new Point(883, 97);
            elevatorUnit.Name = "elevatorUnit";
            elevatorUnit.Size = new Size(57, 362);
            elevatorUnit.SizeMode = PictureBoxSizeMode.StretchImage;
            elevatorUnit.TabIndex = 21;
            elevatorUnit.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(1614, 728);
            button1.Name = "button1";
            button1.Size = new Size(112, 44);
            button1.TabIndex = 23;
            button1.Text = "Exit ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1093, 728);
            button2.Name = "button2";
            button2.Size = new Size(129, 44);
            button2.TabIndex = 24;
            button2.Text = "Delete Records";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // datadisplay
            // 
            datadisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datadisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datadisplay.Location = new Point(1093, 46);
            datadisplay.Name = "datadisplay";
            datadisplay.RowHeadersWidth = 51;
            datadisplay.RowTemplate.Height = 29;
            datadisplay.Size = new Size(633, 611);
            datadisplay.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.background;
            pictureBox1.Location = new Point(-12, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(741, 474);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.background;
            pictureBox2.Location = new Point(-12, 465);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(741, 468);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.floor;
            pictureBox3.Location = new Point(-9, 874);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(738, 236);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // elevatorIndoor
            // 
            elevatorIndoor.Image = Properties.Resources.inside;
            elevatorIndoor.Location = new Point(274, 102);
            elevatorIndoor.Name = "elevatorIndoor";
            elevatorIndoor.Size = new Size(185, 291);
            elevatorIndoor.SizeMode = PictureBoxSizeMode.StretchImage;
            elevatorIndoor.TabIndex = 8;
            elevatorIndoor.TabStop = false;
            // 
            // rightDoorUp
            // 
            rightDoorUp.Image = Properties.Resources.door123;
            rightDoorUp.Location = new Point(360, 102);
            rightDoorUp.Name = "rightDoorUp";
            rightDoorUp.Size = new Size(126, 296);
            rightDoorUp.SizeMode = PictureBoxSizeMode.StretchImage;
            rightDoorUp.TabIndex = 0;
            rightDoorUp.TabStop = false;
            // 
            // leftDoorUp
            // 
            leftDoorUp.Image = Properties.Resources.door123;
            leftDoorUp.Location = new Point(243, 102);
            leftDoorUp.Name = "leftDoorUp";
            leftDoorUp.Size = new Size(123, 298);
            leftDoorUp.SizeMode = PictureBoxSizeMode.StretchImage;
            leftDoorUp.TabIndex = 4;
            leftDoorUp.TabStop = false;
            leftDoorUp.Click += leftDoorUp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1738, 1055);
            Controls.Add(leftDoorDown);
            Controls.Add(rightDoorDown);
            Controls.Add(leftDoorUp);
            Controls.Add(rightDoorUp);
            Controls.Add(elevatorIndoor);
            Controls.Add(pictureBox3);
            Controls.Add(datadisplay);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(elevatorupBtn);
            Controls.Add(callDownBtn);
            Controls.Add(firstFloorPicture);
            Controls.Add(elevatorUnit);
            Controls.Add(groundFloorPicture);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)leftDoorDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightDoorDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)groundFloorPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)firstFloorPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)callDownBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)elevatorupBtn).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeDoorBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)openDoorBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)goUpBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)goDownBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)controlPannelPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)elevatorUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)datadisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)elevatorIndoor).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightDoorUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftDoorUp).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox leftDoorDown;
        private PictureBox rightDoorDown;
        private PictureBox groundFloorPicture;
        private PictureBox firstFloorPicture;
        private PictureBox callDownBtn;
        private PictureBox elevatorupBtn;
        private GroupBox groupBox1;
        private PictureBox pictureBox11;
        private PictureBox controlPannelPicture;
        private PictureBox goUpBtn;
        private PictureBox goDownBtn;
        private System.Windows.Forms.Timer doorOpenTimer;
        private System.Windows.Forms.Timer doorCloseTimer;
        private System.Windows.Forms.Timer goDownTimer;
        private System.Windows.Forms.Timer counterTimer;
        private System.Windows.Forms.Timer goUpTimer;
        private PictureBox closeDoorBtn;
        private PictureBox openDoorBtn;
        private PictureBox elevatorUnit;
        private Button button1;
        private Button button2;
        private DataGridView datadisplay;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox elevatorIndoor;
        private PictureBox rightDoorUp;
        private PictureBox leftDoorUp;
    }
}