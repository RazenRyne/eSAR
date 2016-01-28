﻿namespace eSAR.Course_Related_Resources.ManageGradeLevelSection
{
    partial class frmGradeSectionList
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn21 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn22 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn23 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn24 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.gvGradeSection = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGradeSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGradeSection.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.btnCancel);
            this.radPanel1.Controls.Add(this.btnEdit);
            this.radPanel1.Controls.Add(this.btnAdd);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel1.Location = new System.Drawing.Point(0, 401);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(747, 50);
            this.radPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(660, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 24);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(580, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(77, 24);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(499, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 24);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gvGradeSection
            // 
            this.gvGradeSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGradeSection.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gvGradeSection.MasterTemplate.AllowAddNewRow = false;
            this.gvGradeSection.MasterTemplate.AllowColumnReorder = false;
            this.gvGradeSection.MasterTemplate.AllowDeleteRow = false;
            this.gvGradeSection.MasterTemplate.AllowDragToGroup = false;
            this.gvGradeSection.MasterTemplate.AllowEditRow = false;
            this.gvGradeSection.MasterTemplate.AllowSearchRow = true;
            gridViewTextBoxColumn19.FieldName = "SY";
            gridViewTextBoxColumn19.HeaderText = "School Year";
            gridViewTextBoxColumn19.Name = "SY";
            gridViewTextBoxColumn19.Width = 100;
            gridViewTextBoxColumn20.FieldName = "GradeLevel";
            gridViewTextBoxColumn20.HeaderText = "Grade Level";
            gridViewTextBoxColumn20.Name = "GradeLevel";
            gridViewTextBoxColumn20.Width = 100;
            gridViewTextBoxColumn21.FieldName = "Section";
            gridViewTextBoxColumn21.HeaderText = "Section";
            gridViewTextBoxColumn21.Name = "Section";
            gridViewTextBoxColumn21.Width = 150;
            gridViewTextBoxColumn22.FieldName = "HomeRoom.RoomCode";
            gridViewTextBoxColumn22.HeaderText = "Home Room";
            gridViewTextBoxColumn22.Name = "HomeRoom";
            gridViewTextBoxColumn22.Width = 100;
            gridViewTextBoxColumn23.FieldName = "TeacherName";
            gridViewTextBoxColumn23.HeaderText = "Adviser";
            gridViewTextBoxColumn23.Name = "TeacherName";
            gridViewTextBoxColumn23.Width = 200;
            gridViewTextBoxColumn24.FieldName = "GradeSectionCode";
            gridViewTextBoxColumn24.HeaderText = "column1";
            gridViewTextBoxColumn24.IsVisible = false;
            gridViewTextBoxColumn24.Name = "GradeSectionCode";
            this.gvGradeSection.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn19,
            gridViewTextBoxColumn20,
            gridViewTextBoxColumn21,
            gridViewTextBoxColumn22,
            gridViewTextBoxColumn23,
            gridViewTextBoxColumn24});
            this.gvGradeSection.MasterTemplate.EnableGrouping = false;
            this.gvGradeSection.Name = "gvGradeSection";
            this.gvGradeSection.ReadOnly = true;
            this.gvGradeSection.Size = new System.Drawing.Size(747, 401);
            this.gvGradeSection.TabIndex = 1;
            this.gvGradeSection.SelectionChanged += new System.EventHandler(this.gvGradeSection_SelectionChanged);
            this.gvGradeSection.DoubleClick += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmGradeSectionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 451);
            this.Controls.Add(this.gvGradeSection);
            this.Controls.Add(this.radPanel1);
            this.Name = "frmGradeSectionList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "List of HomeRoom Information";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmGradeSectionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGradeSection.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGradeSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadGridView gvGradeSection;
    }
}
