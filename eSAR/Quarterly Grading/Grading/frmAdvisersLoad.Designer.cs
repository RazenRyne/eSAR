namespace eSAR.Quarterly_Grading.Grading
{
    partial class frmAdvisersLoad
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.gvGradeSection = new Telerik.WinControls.UI.RadGridView();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnAddGrades = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvGradeSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGradeSection.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gvGradeSection
            // 
            this.gvGradeSection.Location = new System.Drawing.Point(0, -2);
            // 
            // 
            // 
            this.gvGradeSection.MasterTemplate.AllowAddNewRow = false;
            this.gvGradeSection.MasterTemplate.AllowColumnReorder = false;
            this.gvGradeSection.MasterTemplate.AllowDeleteRow = false;
            this.gvGradeSection.MasterTemplate.AllowDragToGroup = false;
            this.gvGradeSection.MasterTemplate.AllowEditRow = false;
            this.gvGradeSection.MasterTemplate.AllowSearchRow = true;
            gridViewTextBoxColumn1.FieldName = "GradeLevel";
            gridViewTextBoxColumn1.HeaderText = "Grade Level";
            gridViewTextBoxColumn1.Name = "GradeLevel";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.FieldName = "Section";
            gridViewTextBoxColumn2.HeaderText = "Section";
            gridViewTextBoxColumn2.Name = "Section";
            gridViewTextBoxColumn2.Width = 150;
            gridViewTextBoxColumn3.FieldName = "HomeRoom.RoomCode";
            gridViewTextBoxColumn3.HeaderText = "Home Room";
            gridViewTextBoxColumn3.Name = "HomeRoom";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.FieldName = "TeacherName";
            gridViewTextBoxColumn4.HeaderText = "Adviser";
            gridViewTextBoxColumn4.Name = "TeacherName";
            gridViewTextBoxColumn4.Width = 200;
            gridViewTextBoxColumn5.FieldName = "GradeSectionCode";
            gridViewTextBoxColumn5.HeaderText = "column1";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "GradeSectionCode";
            this.gvGradeSection.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.gvGradeSection.MasterTemplate.EnableGrouping = false;
            this.gvGradeSection.Name = "gvGradeSection";
            this.gvGradeSection.ReadOnly = true;
            this.gvGradeSection.Size = new System.Drawing.Size(795, 421);
            this.gvGradeSection.TabIndex = 2;
            this.gvGradeSection.SelectionChanged += new System.EventHandler(this.gvGradeSection_SelectionChanged);
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.btnCancel);
            this.radPanel2.Controls.Add(this.btnAddGrades);
            this.radPanel2.Location = new System.Drawing.Point(0, 410);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(795, 39);
            this.radPanel2.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(709, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 24);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddGrades
            // 
            this.btnAddGrades.Location = new System.Drawing.Point(626, 10);
            this.btnAddGrades.Name = "btnAddGrades";
            this.btnAddGrades.Size = new System.Drawing.Size(77, 24);
            this.btnAddGrades.TabIndex = 0;
            this.btnAddGrades.Text = "Add Grades";
            this.btnAddGrades.Click += new System.EventHandler(this.btnAddGrades_Click);
            // 
            // frmAdvisersLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.gvGradeSection);
            this.Name = "frmAdvisersLoad";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "List of Advisory Classes";
            this.Load += new System.EventHandler(this.frmAdvisersLoad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvGradeSection.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGradeSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gvGradeSection;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnAddGrades;
    }
}
