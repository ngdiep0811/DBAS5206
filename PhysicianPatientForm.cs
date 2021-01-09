/**
 * Program: Physician Patient Form
 * Date : 4/17/2020
 * Author : Lisa Legawa, Niel Creary, Gabriel Legawa, Ngoc Diep Nguyen
 * Description : This is a C# program that implements  crystal report and viewer to display data 
 *              regarding the physician patirnt relation at MVCHDataSet.
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
    public partial class PhysicianPatientForm : Form
    {
        public PhysicianPatientForm()
        {
            InitializeComponent();
        }

        //Data Object declaration
        //Dataset object
        private MVCHDataDataSet physicianPatientDataSet;
        //Table Adapter Objects
        private MVCHDataDataSetTableAdapters.admissionsTableAdapter admissionsTableAdapter;
        private MVCHDataDataSetTableAdapters.patientTableAdapter patientTableAdapter;
        private MVCHDataDataSetTableAdapters.physicianTableAdapter physicianTableAdapter;
        private MVCHDataDataSetTableAdapters.bedTableAdapter bedTableAdapter;

        private void PhysicianPatientForm_Load(object sender, EventArgs e)
        {
            //Declare a report object for the use at runtime
            physicianPatientReport aPhysicianPatientReport;
            //Intantiate the report
            aPhysicianPatientReport = new physicianPatientReport();

            try
            {
                //Instatiate the dataset and table adapters
                physicianPatientDataSet = new MVCHDataDataSet();
                admissionsTableAdapter = new MVCHDataDataSetTableAdapters.admissionsTableAdapter();
                bedTableAdapter = new MVCHDataDataSetTableAdapters.bedTableAdapter();
                physicianTableAdapter = new MVCHDataDataSetTableAdapters.physicianTableAdapter();
                patientTableAdapter = new MVCHDataDataSetTableAdapters.patientTableAdapter();

                //Fill the dataset using a via these 4 table adapters
                //Fill with admission
                admissionsTableAdapter.Fill(physicianPatientDataSet.admissions);
                //Fill with bed
                bedTableAdapter.Fill(physicianPatientDataSet.bed);
                //Fill with physician
                physicianTableAdapter.Fill(physicianPatientDataSet.physician);
                //Fill with patient
                patientTableAdapter.Fill(physicianPatientDataSet.patient);

                //set up the report viewer object on the form to show the runtime report obect
                aPhysicianPatientReport.SetDataSource(physicianPatientDataSet);
                rptCrystalViewerPhysicianPatient.ReportSource = aPhysicianPatientReport;

            }
            catch (Exception dataException)
            {
                //catch any exception thrown during data object instantiation or report generation
                MessageBox.Show("Data Error Encountered: " + dataException.Message);
            }
        }
    }
}
