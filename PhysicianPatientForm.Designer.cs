namespace MountainViewCommunityHospitalCrystalReport
{
    partial class PhysicianPatientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rptCrystalViewerPhysicianPatient = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptCrystalViewerPhysicianPatient
            // 
            this.rptCrystalViewerPhysicianPatient.ActiveViewIndex = -1;
            this.rptCrystalViewerPhysicianPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptCrystalViewerPhysicianPatient.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptCrystalViewerPhysicianPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptCrystalViewerPhysicianPatient.Location = new System.Drawing.Point(0, 0);
            this.rptCrystalViewerPhysicianPatient.Name = "rptCrystalViewerPhysicianPatient";
            this.rptCrystalViewerPhysicianPatient.Size = new System.Drawing.Size(800, 450);
            this.rptCrystalViewerPhysicianPatient.TabIndex = 0;
            // 
            // PhysicianPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptCrystalViewerPhysicianPatient);
            this.Name = "PhysicianPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhysicianPatientForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PhysicianPatientForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptCrystalViewerPhysicianPatient;
    }
}