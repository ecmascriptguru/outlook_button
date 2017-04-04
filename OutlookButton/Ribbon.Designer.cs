namespace OutlookButton
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
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
            this.alex_tab = this.Factory.CreateRibbonTab();
            this.Alex = this.Factory.CreateRibbonGroup();
            this.alex_click = this.Factory.CreateRibbonButton();
            this.alex_tab.SuspendLayout();
            this.Alex.SuspendLayout();
            this.SuspendLayout();
            // 
            // alex_tab
            // 
            this.alex_tab.Groups.Add(this.Alex);
            this.alex_tab.Label = "Alex Tab";
            this.alex_tab.Name = "alex_tab";
            // 
            // Alex
            // 
            this.Alex.Items.Add(this.alex_click);
            this.Alex.Label = "Alex";
            this.Alex.Name = "Alex";
            // 
            // alex_click
            // 
            this.alex_click.Label = "Click Me";
            this.alex_click.Name = "alex_click";
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.alex_tab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.alex_tab.ResumeLayout(false);
            this.alex_tab.PerformLayout();
            this.Alex.ResumeLayout(false);
            this.Alex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab alex_tab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Alex;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton alex_click;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
