namespace Googlebook
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Shell = new DevComponents.DotNetBar.Metro.MetroShell();
            this.tabPanelLogin = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bGoogleLogin = new DevComponents.DotNetBar.ButtonX();
            this.tabPanelSync = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.tabPanelLink = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.tabLogin = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.tabLink = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.tabSync = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.Style = new DevComponents.DotNetBar.StyleManager(this.components);
            this.status = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.lbState = new DevComponents.DotNetBar.LabelItem();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.step = new DevComponents.DotNetBar.Controls.StepIndicator();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.Shell.SuspendLayout();
            this.tabPanelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // Shell
            // 
            this.Shell.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.Shell.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Shell.CaptionVisible = true;
            this.Shell.Controls.Add(this.tabPanelLogin);
            this.Shell.Controls.Add(this.tabPanelSync);
            this.Shell.Controls.Add(this.tabPanelLink);
            this.Shell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Shell.ForeColor = System.Drawing.Color.Black;
            this.Shell.HelpButtonText = null;
            this.Shell.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabLogin,
            this.tabLink,
            this.tabSync});
            this.Shell.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.Shell.Location = new System.Drawing.Point(0, 1);
            this.Shell.Name = "Shell";
            this.Shell.Size = new System.Drawing.Size(624, 394);
            this.Shell.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.Shell.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.Shell.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.Shell.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.Shell.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.Shell.SystemText.QatDialogAddButton = "&Add >>";
            this.Shell.SystemText.QatDialogCancelButton = "Cancel";
            this.Shell.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.Shell.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.Shell.SystemText.QatDialogOkButton = "OK";
            this.Shell.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.Shell.SystemText.QatDialogRemoveButton = "&Remove";
            this.Shell.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.Shell.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.Shell.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.Shell.TabIndex = 0;
            this.Shell.TabStripFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shell.Text = "Shell";
            // 
            // tabPanelLogin
            // 
            this.tabPanelLogin.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tabPanelLogin.Controls.Add(this.labelX2);
            this.tabPanelLogin.Controls.Add(this.labelX1);
            this.tabPanelLogin.Controls.Add(this.step);
            this.tabPanelLogin.Controls.Add(this.textBoxX2);
            this.tabPanelLogin.Controls.Add(this.textBoxX1);
            this.tabPanelLogin.Controls.Add(this.bGoogleLogin);
            this.tabPanelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelLogin.Location = new System.Drawing.Point(0, 51);
            this.tabPanelLogin.Name = "tabPanelLogin";
            this.tabPanelLogin.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tabPanelLogin.Size = new System.Drawing.Size(624, 343);
            // 
            // 
            // 
            this.tabPanelLogin.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.tabPanelLogin.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.tabPanelLogin.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tabPanelLogin.TabIndex = 1;
            // 
            // textBoxX1
            // 
            this.textBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.ForeColor = System.Drawing.Color.Black;
            this.textBoxX1.Location = new System.Drawing.Point(234, 100);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(192, 22);
            this.textBoxX1.TabIndex = 4;
            // 
            // bGoogleLogin
            // 
            this.bGoogleLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bGoogleLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bGoogleLogin.Location = new System.Drawing.Point(264, 194);
            this.bGoogleLogin.Name = "bGoogleLogin";
            this.bGoogleLogin.Size = new System.Drawing.Size(75, 23);
            this.bGoogleLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bGoogleLogin.TabIndex = 0;
            this.bGoogleLogin.Text = "Login";
            // 
            // tabPanelSync
            // 
            this.tabPanelSync.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tabPanelSync.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelSync.Location = new System.Drawing.Point(0, 51);
            this.tabPanelSync.Name = "tabPanelSync";
            this.tabPanelSync.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tabPanelSync.Size = new System.Drawing.Size(624, 343);
            // 
            // 
            // 
            this.tabPanelSync.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.tabPanelSync.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.tabPanelSync.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tabPanelSync.TabIndex = 3;
            this.tabPanelSync.Visible = false;
            // 
            // tabPanelLink
            // 
            this.tabPanelLink.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tabPanelLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelLink.Location = new System.Drawing.Point(0, 51);
            this.tabPanelLink.Name = "tabPanelLink";
            this.tabPanelLink.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tabPanelLink.Size = new System.Drawing.Size(624, 343);
            // 
            // 
            // 
            this.tabPanelLink.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.tabPanelLink.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.tabPanelLink.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tabPanelLink.TabIndex = 2;
            this.tabPanelLink.Visible = false;
            // 
            // tabLogin
            // 
            this.tabLogin.Checked = true;
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Panel = this.tabPanelLogin;
            this.tabLogin.Text = "&LOGIN";
            // 
            // tabLink
            // 
            this.tabLink.Name = "tabLink";
            this.tabLink.Panel = this.tabPanelLink;
            this.tabLink.Text = "&LINK";
            // 
            // tabSync
            // 
            this.tabSync.Name = "tabSync";
            this.tabSync.Panel = this.tabPanelSync;
            this.tabSync.Text = "&SYNC";
            // 
            // Style
            // 
            this.Style.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.Style.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(238))))));
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.status.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.status.ContainerControlProcessDialogKey = true;
            this.status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Black;
            this.status.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lbState});
            this.status.Location = new System.Drawing.Point(0, 374);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(624, 21);
            this.status.TabIndex = 1;
            this.status.Text = "Status";
            // 
            // lbState
            // 
            this.lbState.Name = "lbState";
            this.lbState.Text = "READY";
            // 
            // textBoxX2
            // 
            this.textBoxX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.ForeColor = System.Drawing.Color.Black;
            this.textBoxX2.Location = new System.Drawing.Point(234, 128);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(192, 22);
            this.textBoxX2.TabIndex = 5;
            // 
            // step
            // 
            this.step.Dock = System.Windows.Forms.DockStyle.Top;
            this.step.Location = new System.Drawing.Point(3, 0);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(618, 4);
            this.step.StepCount = 3;
            this.step.TabIndex = 6;
            this.step.Text = "stepIndicator1";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(153, 100);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "Username";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(153, 127);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Password";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 396);
            this.Controls.Add(this.status);
            this.Controls.Add(this.Shell);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Googlebook";
            this.Shell.ResumeLayout(false);
            this.Shell.PerformLayout();
            this.tabPanelLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroShell Shell;
        private DevComponents.DotNetBar.Metro.MetroTabPanel tabPanelLogin;
        private DevComponents.DotNetBar.Metro.MetroTabPanel tabPanelLink;
        private DevComponents.DotNetBar.Metro.MetroTabItem tabLogin;
        private DevComponents.DotNetBar.Metro.MetroTabItem tabLink;
        private DevComponents.DotNetBar.StyleManager Style;
        private DevComponents.DotNetBar.Metro.MetroStatusBar status;
        private DevComponents.DotNetBar.LabelItem lbState;
        private DevComponents.DotNetBar.Metro.MetroTabPanel tabPanelSync;
        private DevComponents.DotNetBar.Metro.MetroTabItem tabSync;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.ButtonX bGoogleLogin;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.StepIndicator step;

    }
}

