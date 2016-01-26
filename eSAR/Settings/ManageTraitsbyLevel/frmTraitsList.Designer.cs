﻿namespace eSAR.Settings.ManageTraitsbyLevel
{
    partial class frmTraitsList
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btCancel = new Telerik.WinControls.UI.RadButton();
            this.btEdit = new Telerik.WinControls.UI.RadButton();
            this.btAdd = new Telerik.WinControls.UI.RadButton();
            this.gvTraits = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTraits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTraits.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.btCancel);
            this.radPanel1.Controls.Add(this.btEdit);
            this.radPanel1.Controls.Add(this.btAdd);
            this.radPanel1.Controls.Add(this.gvTraits);
            this.radPanel1.Location = new System.Drawing.Point(2, 10);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(593, 386);
            this.radPanel1.TabIndex = 0;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(520, 349);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(69, 24);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(447, 349);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(69, 24);
            this.btEdit.TabIndex = 2;
            this.btEdit.Text = "Edit";
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(375, 349);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(69, 24);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Add";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // gvTraits
            // 
            this.gvTraits.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            this.gvTraits.MasterTemplate.AllowDragToGroup = false;
            gridViewCheckBoxColumn1.FieldName = "CurrTrait";
            gridViewCheckBoxColumn1.HeaderText = "Current";
            gridViewCheckBoxColumn1.Name = "CurrTrait";
            gridViewTextBoxColumn1.FieldName = "Description";
            gridViewTextBoxColumn1.HeaderText = "Description";
            gridViewTextBoxColumn1.Name = "Description";
            gridViewTextBoxColumn1.Width = 300;
            gridViewTextBoxColumn2.FieldName = "Cat";
            gridViewTextBoxColumn2.HeaderText = "Category";
            gridViewTextBoxColumn2.Name = "Cat";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.FieldName = "TraitsID";
            gridViewTextBoxColumn3.HeaderText = "TraitsID";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "TraitsID";
            gridViewTextBoxColumn4.FieldName = "Category";
            gridViewTextBoxColumn4.HeaderText = "column1";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "Category";
            this.gvTraits.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.gvTraits.MasterTemplate.EnableGrouping = false;
            this.gvTraits.Name = "gvTraits";
            this.gvTraits.ReadOnly = true;
            this.gvTraits.Size = new System.Drawing.Size(586, 326);
            this.gvTraits.TabIndex = 0;
            this.gvTraits.Text = "radGridView1";
            this.gvTraits.SelectionChanged += new System.EventHandler(this.gvTraits_SelectionChanged);
            // 
            // frmTraitsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 405);
            this.Controls.Add(this.radPanel1);
            this.Name = "frmTraitsList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "List of Traits";
            this.ThemeName = "ControlDefault";
            this.Activated += new System.EventHandler(this.frmTraitsList_Activated);
            this.Load += new System.EventHandler(this.frmTraitsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTraits.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTraits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton btEdit;
        private Telerik.WinControls.UI.RadButton btAdd;
        private Telerik.WinControls.UI.RadGridView gvTraits;
        private Telerik.WinControls.UI.RadButton btCancel;
    }
}
