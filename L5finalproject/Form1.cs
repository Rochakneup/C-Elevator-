using System.ComponentModel;
using System.Data.Common;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace L5finalproject
{
    public partial class Form1 : Form
    {
        DatabaseCommands record = new DatabaseCommands();
        //objects for the door and elevator components
        Door doorobj = new Door();
        ElevatorUnit elevobj = new ElevatorUnit();
        private System.Windows.Forms.Timer dataRefreshTimer;

        //coordinate variables
        int xLeftDoorOpen = 156;
        int xLeftDoorClosed = 243;
        int xRightDoorOpen = 466;
        int xRightDoorClosed = 363;
        int yElevatorUp = 105;
        int yElevatorDown = 560;

        //function variables
        public bool goUpBool = false;
        public bool goDownBool = false;
        public bool doorClosedBool = true;

        //counter variables
        public int counter = 1;

        public Form1()
        {
            InitializeComponent();
            dataRefreshTimer = new System.Windows.Forms.Timer();
            dataRefreshTimer.Interval = 1; // Set the interval in milliseconds (e.g., 10000ms = 10 seconds)
            dataRefreshTimer.Tick += new EventHandler(dataRefreshTimer_Tick); // Hook up the event handler
            dataRefreshTimer.Start(); // Start the timer
        }
        private void dataRefreshTimer_Tick(object sender, EventArgs e)
        {
            updateDatalog(); // Refresh the data in the DataGridView
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            dataRefreshTimer.Stop(); // Stop the timer when the form is closing
        }
        private void doorOpen()
        {
            counterTimer.Enabled = false;
            counter = 0;
            if (elevatorUnit.Top >= yElevatorUp)
            {
                if (rightDoorDown.Left <= xRightDoorOpen && leftDoorDown.Left >= xLeftDoorOpen)
                {
                    doorobj.doorOpenDown(rightDoorDown, leftDoorDown);
                    disableButtons();
                }
                else
                {
                    record.InsertData(DateTime.Now, "Doors Opening at Ground Floor");
                    doorClosedBool = false;
                    doorOpenTimer.Enabled = false;
                    enableButtons();
                    counter = 0;
                    counterTimer.Enabled = true;
                }
            }
            else
            {
                if (rightDoorUp.Left <= xRightDoorOpen && leftDoorUp.Left >= xLeftDoorOpen)
                {
                    doorobj.doorOpenUp(rightDoorUp, leftDoorUp);
                    disableButtons();
                }

                else
                {
                    record.InsertData(DateTime.Now, "Doors Opening  at First Floor");
                    doorClosedBool = false;
                    doorOpenTimer.Enabled = false;
                    enableButtons();
                    counter = 0;
                    counterTimer.Enabled = true;
                }
            }
        }

        private void doorClose()
        {
            counterTimer.Enabled = false;
            counter = 0;
            if (elevatorUnit.Top >= yElevatorUp)
            {
                if (rightDoorDown.Left >= xRightDoorClosed && leftDoorDown.Left <= xLeftDoorClosed)
                {
                    doorobj.doorCloseDown(rightDoorDown, leftDoorDown);
                    disableButtons();
                }
                else
                {
                    record.InsertData(DateTime.Now, "Doors Closing at Ground Floor");
                    doorCloseTimer.Enabled = false;
                    doorClosedBool = true;
                    checkDoorClosed();
                    enableButtons();
                }
            }
            else
            {
                if (rightDoorUp.Left >= xRightDoorClosed && leftDoorUp.Left <= xLeftDoorClosed)
                {
                    doorobj.doorCloseUp(rightDoorUp, leftDoorUp);
                    disableButtons();
                }
                else
                {
                    record.InsertData(DateTime.Now, "Doors Closing at First  Floor");
                    doorCloseTimer.Enabled = false;
                    doorClosedBool = true;
                    checkDoorClosed();
                    enableButtons();
                }
            }
        }
        private void elevatorUp()
        {
            counterTimer.Enabled = false;
            counter = 0;
            if (elevatorUnit.Top >= yElevatorUp)
            {
                elevobj.elevatorUp(elevatorUnit, elevatorIndoor);
                //  firstFloorDisplay.Text = "GOING UP";
                //  groundFloorDisplay.Text = "GOING UP";
                firstFloorPicture.Image = Properties.Resources.uparrowgif;
                groundFloorPicture.Image = Properties.Resources.uparrowgif; ;
                controlPannelPicture.Image = Properties.Resources.uparrowgif; ;
                disableButtons();

            }
            else
            {
                record.InsertData(DateTime.Now, "Elevator at First Floor");
                goUpBool = false;
                goDownBool = false;
                goUpTimer.Enabled = false;
                doorOpenTimer.Enabled = true;
                // firstFloorDisplay.Text = "FIRST FLOOR";
                // groundFloorDisplay.Text = "FIRST FLOOR";
                firstFloorPicture.Image = Properties.Resources.onegif;
                groundFloorPicture.Image = Properties.Resources.onegif;
                controlPannelPicture.Image = Properties.Resources.onegif;
                enableButtons();
            }
        }

        //function to move the elevator down
        private void elevatorDown()
        {
            counterTimer.Enabled = false;
            counter = 0;
            if (elevatorUnit.Top <= yElevatorDown)
            {
                elevobj.elevatorDown(elevatorUnit, elevatorIndoor);
                firstFloorPicture.Image = Properties.Resources.downgif;
                groundFloorPicture.Image = Properties.Resources.downgif;
                controlPannelPicture.Image = Properties.Resources.downgif;
                disableButtons();
            }
            else
            {
                record.InsertData(DateTime.Now, "Elevator at Ground Floor");
                goDownBool = false;
                goUpBool = false;
                goDownTimer.Enabled = false;
                doorOpenTimer.Enabled = true;
                firstFloorPicture.Image = Properties.Resources.zerogif;
                groundFloorPicture.Image = Properties.Resources.zerogif;
                controlPannelPicture.Image = Properties.Resources.zerogif;
                enableButtons();

            }
        }

        //function to check whether doors are closed or open
        private void checkDoorClosed()
        {
            if (!doorClosedBool)
            {
                doorCloseTimer.Enabled = true;
            }
            else
            {
                if (goUpBool)
                {
                    goUpTimer.Enabled = true;
                }
                else if (goDownBool)
                {
                    goDownTimer.Enabled = true;
                }
            }
        }
        public void disableButtons()
        {
            goUpBtn.Enabled = false;
            goDownBtn.Enabled = false;
            openDoorBtn.Enabled = false;
            closeDoorBtn.Enabled = false;
            callDownBtn.Enabled = false;
            elevatorupBtn.Enabled = false;
        }

        public void enableButtons()
        {
            goUpBtn.Enabled = true;
            goDownBtn.Enabled = true;
            openDoorBtn.Enabled = true;
            closeDoorBtn.Enabled = true;
            callDownBtn.Enabled = true;
            elevatorupBtn.Enabled = true;
        }

        private void openDoorBtn_Click(object sender, EventArgs e)
        {
            doorOpenTimer.Enabled = true;

        }

        private void doorOpenTimer_Tick(object sender, EventArgs e)
        {
            doorOpen();
        }

        private void closeDoorBtn_Click(object sender, EventArgs e)
        {
            doorCloseTimer.Enabled = true;
        }

        private void doorCloseTimer_Tick(object sender, EventArgs e)
        {
            doorClose();
        }

        private void goDownBtn_Click(object sender, EventArgs e)
        {
            goDownBool = true;
            checkDoorClosed();
        }

        private void goDownTimer_Tick(object sender, EventArgs e)
        {
            elevatorDown();



        }

        private void goUpBtn_Click(object sender, EventArgs e)
        {
            goUpBool = true;
            checkDoorClosed();
        }

        private void goUpTimer_Tick(object sender, EventArgs e)
        {
            elevatorUp();
        }

        private void callUpBtn_Click(object sender, EventArgs e)
        {
            goUpBool = true;
            checkDoorClosed();
        }

        private void callDownBtn_Click(object sender, EventArgs e)
        {
            goDownBool = true;
            checkDoorClosed();
        }

        private void counterTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter >= 200)
            {
                counter = 0;
                doorCloseTimer.Enabled = true;
                counterTimer.Enabled = false;
            }
        }
        public void updateDatalog()
        {
            string connectionString = "datasource=localhost; Database=elevatordata; port=3306; User=root; Password=root";
            string query = "SELECT log_date , Actions_log FROM action_log";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Assuming logTable is a DataGridView control
                        datadisplay.DataSource = dataTable;

                        // Scroll to the latest added row (if any)
                        if (datadisplay.Rows.Count > 0)
                        {
                            datadisplay.FirstDisplayedScrollingRowIndex = datadisplay.Rows.Count - 1;
                        }
                    }
                }
            }



        }




        private void button2_Click(object sender, EventArgs e)
        {
            record.deleteRecords();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void leftDoorUp_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void emptyDatabase()
        {
            try
            {
                datadisplay.DataSource = null;
                record.deleteRecords();
                MessageBox.Show("Successfully deleted records", "Database Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to delete Records", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
