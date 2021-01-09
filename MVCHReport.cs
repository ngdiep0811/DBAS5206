/**
 * Program: MVCH Report
 * Date : 4/17/2020
 * Author : Lisa Legawa, Niel Creary, Gabriel Legawa, Ngoc Diep Nguyen
 * Description : This is a C# main program to runs the crystal reports, 
 *               which are physician patient report and room utilization report.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MountainViewCommunityHospitalCrystalReport
{
    static class MVCHReport
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Run the physician patient form
            Application.Run(new PhysicianPatientForm());
            //Run the room utilization form
            Application.Run(new RoomUtilizationForm());
        }
    }
}
