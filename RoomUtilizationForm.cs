/**
 * Program: Room Utilization Form
 * Date : 4/17/2020
 * Author : Lisa Legawa, Niel Creary, Gabriel Legawa, Ngoc Diep Nguyen
 * Description : This is a C# program that implements  crystal report and viewer to display data 
 *              regarding the room utilization report for all rooms at MVCHDataSet.
 *              It accomplishes this using a run-time dataset based on a local SQL server db.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MountainViewCommunityHospitalCrystalReport
{
    public partial class RoomUtilizationForm : Form
    {
        public RoomUtilizationForm()
        {
            InitializeComponent();
        }
        //Data Object declaration
        //Dataset object
        private MVCHDataDataSet roomUtilizationDataSet;
        //Table Adapter Objects
        private MVCHDataDataSetTableAdapters.admissionsTableAdapter admissionsTableAdapter;
        private MVCHDataDataSetTableAdapters.bedTableAdapter bedTableAdapter;
        private MVCHDataDataSetTableAdapters.roomTableAdapter roomsTableAdapter;
        private MVCHDataDataSetTableAdapters.patientTableAdapter patientTableAdapter;


        private void MVCHForm_Load(object sender, EventArgs e)
        {
            //Declare a report object for the use at runtime
            roomUtilizationReport aRoomUtilizationReport;
            //Intantiate the report
            aRoomUtilizationReport = new roomUtilizationReport();

            try
            {
                //Instatiate the dataset and table adapters
                roomUtilizationDataSet = new MVCHDataDataSet();
                admissionsTableAdapter = new MVCHDataDataSetTableAdapters.admissionsTableAdapter();
                bedTableAdapter = new MVCHDataDataSetTableAdapters.bedTableAdapter();
                roomsTableAdapter = new MVCHDataDataSetTableAdapters.roomTableAdapter();
                patientTableAdapter = new MVCHDataDataSetTableAdapters.patientTableAdapter();
                
                //Fille the dataset using via theese 4 table adapters
                //Fill with admission
                admissionsTableAdapter.Fill(roomUtilizationDataSet.admissions);
                //Fill with bed
                bedTableAdapter.Fill(roomUtilizationDataSet.bed);
                //Fill with rooms
                roomsTableAdapter.Fill(roomUtilizationDataSet.room);
                //Fill with patient
                patientTableAdapter.Fill(roomUtilizationDataSet.patient);

                //Set up the report viewer object on the form to show the runtime report object
                aRoomUtilizationReport.SetDataSource(roomUtilizationDataSet);
                rptCrystalViewer.ReportSource = aRoomUtilizationReport;

            }
            catch (Exception dataException)
            {
                //Catch any exception thrown during data object instantiation or report generation
                MessageBox.Show("Data Error Encountered: " + dataException.Message);
            }
        }


    }
}
