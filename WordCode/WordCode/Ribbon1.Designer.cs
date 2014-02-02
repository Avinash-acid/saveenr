﻿namespace WordCode
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.tabDevCode = this.Factory.CreateRibbonTab();
            this.groupQuotes = this.Factory.CreateRibbonGroup();
            this.buttonRemoveFromSelection = this.Factory.CreateRibbonButton();
            this.buttonRemoveFromDocument = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.tabDevCode.SuspendLayout();
            this.groupQuotes.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // tabDevCode
            // 
            this.tabDevCode.Groups.Add(this.groupQuotes);
            this.tabDevCode.Label = "DevCode";
            this.tabDevCode.Name = "tabDevCode";
            // 
            // groupQuotes
            // 
            this.groupQuotes.Items.Add(this.buttonRemoveFromSelection);
            this.groupQuotes.Items.Add(this.buttonRemoveFromDocument);
            this.groupQuotes.Label = "SmartQuotes";
            this.groupQuotes.Name = "groupQuotes";
            // 
            // buttonRemoveFromSelection
            // 
            this.buttonRemoveFromSelection.Label = "Remove from Selection";
            this.buttonRemoveFromSelection.Name = "buttonRemoveFromSelection";
            this.buttonRemoveFromSelection.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click_1);
            // 
            // buttonRemoveFromDocument
            // 
            this.buttonRemoveFromDocument.Label = "Remove from Document";
            this.buttonRemoveFromDocument.Name = "buttonRemoveFromDocument";
            this.buttonRemoveFromDocument.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonRemoveFromDocument_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Tabs.Add(this.tabDevCode);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tabDevCode.ResumeLayout(false);
            this.tabDevCode.PerformLayout();
            this.groupQuotes.ResumeLayout(false);
            this.groupQuotes.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        private Microsoft.Office.Tools.Ribbon.RibbonTab tabDevCode;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupQuotes;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonRemoveFromSelection;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonRemoveFromDocument;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}