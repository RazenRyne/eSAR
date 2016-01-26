﻿namespace eSAR.Settings.ManageCurriculum
{
    partial class frmManageCurriculum
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.gvCurriculum = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCurriculum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCurriculum.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.btnAdd);
            this.radPanel1.Controls.Add(this.btnEdit);
            this.radPanel1.Controls.Add(this.radButton1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel1.Location = new System.Drawing.Point(0, 336);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(825, 50);
            this.radPanel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(559, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 24);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(648, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 24);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // radButton1
            // 
            this.radButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton1.Location = new System.Drawing.Point(737, 14);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(83, 24);
            this.radButton1.TabIndex = 36;
            this.radButton1.Text = "Cancel";
            this.radButton1.Visible = false;
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // gvCurriculum
            // 
            this.gvCurriculum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvCurriculum.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gvCurriculum.MasterTemplate.AllowAddNewRow = false;
            this.gvCurriculum.MasterTemplate.AllowColumnReorder = false;
            this.gvCurriculum.MasterTemplate.AllowDeleteRow = false;
            this.gvCurriculum.MasterTemplate.AllowDragToGroup = false;
            this.gvCurriculum.MasterTemplate.AllowEditRow = false;
            this.gvCurriculum.MasterTemplate.AllowSearchRow = true;
            gridViewTextBoxColumn4.FieldName = "CurriculumCode";
            gridViewTextBoxColumn4.HeaderText = "Curriculum";
            gridViewTextBoxColumn4.Name = "CurriculumCode";
            gridViewTextBoxColumn4.Width = 150;
            gridViewTextBoxColumn5.FieldName = "Description";
            gridViewTextBoxColumn5.HeaderText = "Description";
            gridViewTextBoxColumn5.Name = "Description";
            gridViewTextBoxColumn5.Width = 300;
            gridViewTextBoxColumn6.FieldName = "CurrentCurr";
            gridViewTextBoxColumn6.HeaderText = "Current";
            gridViewTextBoxColumn6.Name = "Current";
            gridViewTextBoxColumn6.Width = 244;
            this.gvCurriculum.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.gvCurriculum.MasterTemplate.EnableGrouping = false;
            this.gvCurriculum.Name = "gvCurriculum";
            this.gvCurriculum.ReadOnly = true;
            this.gvCurriculum.Size = new System.Drawing.Size(825, 336);
            this.gvCurriculum.TabIndex = 36;
            this.gvCurriculum.SelectionChanged += new System.EventHandler(this.gvCurriculum_SelectionChanged);
            this.gvCurriculum.DoubleClick += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmManageCurriculum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 386);
            this.Controls.Add(this.gvCurriculum);
            this.Controls.Add(this.radPanel1);
            this.Name = "frmManageCurriculum";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Manage Curriculum";
            this.ThemeName = "ControlDefault";
            this.Activated += new System.EventHandler(this.frmManageCurriculum_Activated);
            this.Load += new System.EventHandler(this.frmManageCurriculum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCurriculum.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCurriculum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadGridView gvCurriculum;
    }
}
