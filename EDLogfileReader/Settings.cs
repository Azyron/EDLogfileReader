using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDLogfileReader
{
    public partial class SettingsForm : Form
    {
        private EDLogFileReader readerInstance;


        public SettingsForm(EDLogFileReader readerInstance)
        {
            this.readerInstance = readerInstance;

            InitializeComponent();

            if (string.IsNullOrEmpty(readerInstance.getLogsPath()))
            {
                textBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Frontier_Developments\\Products\\elite-dangerous-64\\Logs";
            }
            else
            {
                textBox1.Text = readerInstance.getLogsPath();
            }

            DistanceTraveledBox.Text = readerInstance.getDistanceTraveled().ToString();
            outputFileBox.Text = readerInstance.getOutputFileName();
            EnableDistanceToSol.Checked = readerInstance.showSolDistance;
            ShowTraveledSoFarBox.Checked = readerInstance.showDistanceTraveled;
            ShowDestinationBox.Checked = readerInstance.showDestination;
            DestinationBox.Text = readerInstance.destinationName;
            destinationX.Text = readerInstance.destinationPosition.X.ToString();
            destinationZ.Text = readerInstance.destinationPosition.Y.ToString();
            destinationY.Text = readerInstance.destinationPosition.Z.ToString();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void onSaveClick(object sender, EventArgs e)
        {
            try
            {
                double newValue = double.Parse(DistanceTraveledBox.Text);
                readerInstance.setDistanceTraveled(newValue);
                readerInstance.setLogsPath(textBox1.Text);
                readerInstance.setShowSolDistance(EnableDistanceToSol.Checked);
                readerInstance.setShowDestination(ShowDestinationBox.Checked);
                readerInstance.setDestinationName(DestinationBox.Text);
                double x = double.Parse(destinationX.Text);
                double y = double.Parse(destinationZ.Text);
                double z = double.Parse(destinationY.Text);
                readerInstance.setDestinationPosition(new Position(x, y, z));
                readerInstance.setOutputFileName(outputFileBox.Text);
                this.Dispose();
            }
            catch
            {
            }
        }


        private void onOutputFileButtonClick(object sender, EventArgs e)
        {
            // openFileDialog1.ShowHelp = true;
            if ((outputFileBox.Text == null) || (outputFileBox.Text.Equals("")))
            {
                saveFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog1.FileName = "current-ed-system-data.txt";
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outputFileBox.Text = saveFileDialog1.FileName;
                readerInstance.setOutputFileName(outputFileBox.Text);
            }
        }


        private void onSelectLogPathClick(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = readerInstance.getLogsPath();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void onShowTraveledSoFarBoxChanged(object sender, EventArgs e)
        {
            // ShowTraveledSoFarBox
            readerInstance.setShowDistanceTraveled(ShowTraveledSoFarBox.Checked);
        }


        private void onEnableDistanceToSolChanged(object sender, EventArgs e)
        {

        }

        private void DistanceTraveledBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void onCancel(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
    }
}
