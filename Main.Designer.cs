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
            this.tabPanelLink = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.itemPanel2 = new DevComponents.DotNetBar.ItemPanel();
            this.pUnlinkedContacts = new DevComponents.DotNetBar.ItemPanel();
            this.tabPanelLogin = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.pGoogleLogin = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lHeader = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tbPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bGoogleLogin = new DevComponents.DotNetBar.ButtonX();
            this.step = new DevComponents.DotNetBar.Controls.StepIndicator();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.tabPanelSync = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.tabLogin = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.tabLink = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.tabSync = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.Style = new DevComponents.DotNetBar.StyleManager(this.components);
            this.status = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.lbState = new DevComponents.DotNetBar.LabelItem();
            this.Shell.SuspendLayout();
            this.tabPanelLink.SuspendLayout();
            this.tabPanelLogin.SuspendLayout();
            this.pGoogleLogin.SuspendLayout();
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
            this.Shell.Controls.Add(this.tabPanelLink);
            this.Shell.Controls.Add(this.tabPanelLogin);
            this.Shell.Controls.Add(this.tabPanelSync);
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
            this.Shell.Size = new System.Drawing.Size(883, 460);
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
            // tabPanelLink
            // 
            this.tabPanelLink.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tabPanelLink.Controls.Add(this.itemPanel2);
            this.tabPanelLink.Controls.Add(this.pUnlinkedContacts);
            this.tabPanelLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelLink.Location = new System.Drawing.Point(0, 51);
            this.tabPanelLink.Name = "tabPanelLink";
            this.tabPanelLink.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tabPanelLink.Size = new System.Drawing.Size(883, 409);
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
            // 
            // itemPanel2
            // 
            this.itemPanel2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.itemPanel2.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel2.ContainerControlProcessDialogKey = true;
            this.itemPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel2.ForeColor = System.Drawing.Color.Black;
            this.itemPanel2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel2.Location = new System.Drawing.Point(322, 0);
            this.itemPanel2.Name = "itemPanel2";
            this.itemPanel2.Size = new System.Drawing.Size(558, 406);
            this.itemPanel2.TabIndex = 1;
            this.itemPanel2.Text = "itemPanel2";
            // 
            // pUnlinkedContacts
            // 
            this.pUnlinkedContacts.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.pUnlinkedContacts.BackgroundStyle.Class = "ItemPanel";
            this.pUnlinkedContacts.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pUnlinkedContacts.ContainerControlProcessDialogKey = true;
            this.pUnlinkedContacts.Dock = System.Windows.Forms.DockStyle.Left;
            this.pUnlinkedContacts.FitButtonsToContainerWidth = true;
            this.pUnlinkedContacts.ForeColor = System.Drawing.Color.Black;
            this.pUnlinkedContacts.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.pUnlinkedContacts.Location = new System.Drawing.Point(3, 0);
            this.pUnlinkedContacts.Name = "pUnlinkedContacts";
            this.pUnlinkedContacts.Size = new System.Drawing.Size(319, 406);
            this.pUnlinkedContacts.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.pUnlinkedContacts.TabIndex = 0;
            this.pUnlinkedContacts.Text = "itemPanel1";
            this.pUnlinkedContacts.ThemeAware = true;
            // 
            // tabPanelLogin
            // 
            this.tabPanelLogin.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tabPanelLogin.Controls.Add(this.pGoogleLogin);
            this.tabPanelLogin.Controls.Add(this.step);
            this.tabPanelLogin.Controls.Add(this.browser);
            this.tabPanelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelLogin.Location = new System.Drawing.Point(0, 51);
            this.tabPanelLogin.Name = "tabPanelLogin";
            this.tabPanelLogin.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tabPanelLogin.Size = new System.Drawing.Size(883, 409);
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
            this.tabPanelLogin.Visible = false;
            // 
            // pGoogleLogin
            // 
            this.pGoogleLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pGoogleLogin.BackColor = System.Drawing.Color.White;
            this.pGoogleLogin.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pGoogleLogin.Controls.Add(this.lHeader);
            this.pGoogleLogin.Controls.Add(this.labelX2);
            this.pGoogleLogin.Controls.Add(this.labelX1);
            this.pGoogleLogin.Controls.Add(this.tbPassword);
            this.pGoogleLogin.Controls.Add(this.tbUser);
            this.pGoogleLogin.Controls.Add(this.bGoogleLogin);
            this.pGoogleLogin.Location = new System.Drawing.Point(307, 103);
            this.pGoogleLogin.Name = "pGoogleLogin";
            this.pGoogleLogin.Size = new System.Drawing.Size(287, 203);
            // 
            // 
            // 
            this.pGoogleLogin.Style.BackColor = System.Drawing.Color.White;
            this.pGoogleLogin.Style.BackColor2 = System.Drawing.Color.White;
            this.pGoogleLogin.Style.BackColorGradientAngle = 90;
            this.pGoogleLogin.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pGoogleLogin.Style.BorderBottomWidth = 1;
            this.pGoogleLogin.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pGoogleLogin.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pGoogleLogin.Style.BorderLeftWidth = 1;
            this.pGoogleLogin.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pGoogleLogin.Style.BorderRightWidth = 1;
            this.pGoogleLogin.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pGoogleLogin.Style.BorderTopWidth = 1;
            this.pGoogleLogin.Style.CornerDiameter = 4;
            this.pGoogleLogin.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pGoogleLogin.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pGoogleLogin.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pGoogleLogin.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pGoogleLogin.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pGoogleLogin.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pGoogleLogin.TabIndex = 22;
            // 
            // lHeader
            // 
            this.lHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lHeader.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lHeader.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHeader.ForeColor = System.Drawing.Color.Black;
            this.lHeader.Location = new System.Drawing.Point(3, 3);
            this.lHeader.Name = "lHeader";
            this.lHeader.Size = new System.Drawing.Size(273, 46);
            this.lHeader.TabIndex = 27;
            this.lHeader.Text = "Google login";
            this.lHeader.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(3, 82);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 26;
            this.labelX2.Text = "Password";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(3, 55);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 25;
            this.labelX1.Text = "Username";
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbPassword.Border.Class = "TextBoxBorder";
            this.tbPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.Location = new System.Drawing.Point(84, 83);
            this.tbPassword.MaxLength = 50;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(192, 22);
            this.tbPassword.TabIndex = 24;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUser
            // 
            this.tbUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUser.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbUser.Border.Class = "TextBoxBorder";
            this.tbUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbUser.ForeColor = System.Drawing.Color.Black;
            this.tbUser.Location = new System.Drawing.Point(84, 55);
            this.tbUser.MaxLength = 50;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(192, 22);
            this.tbUser.TabIndex = 23;
            // 
            // bGoogleLogin
            // 
            this.bGoogleLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bGoogleLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bGoogleLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bGoogleLogin.Location = new System.Drawing.Point(102, 128);
            this.bGoogleLogin.Name = "bGoogleLogin";
            this.bGoogleLogin.Size = new System.Drawing.Size(75, 23);
            this.bGoogleLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bGoogleLogin.TabIndex = 22;
            this.bGoogleLogin.Text = "Login";
            this.bGoogleLogin.Click += new System.EventHandler(this.BGoogleLoginClick);
            // 
            // step
            // 
            this.step.Dock = System.Windows.Forms.DockStyle.Top;
            this.step.Location = new System.Drawing.Point(3, 0);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(877, 4);
            this.step.StepCount = 3;
            this.step.TabIndex = 6;
            // 
            // browser
            // 
            this.browser.AllowWebBrowserDrop = false;
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.IsWebBrowserContextMenuEnabled = false;
            this.browser.Location = new System.Drawing.Point(3, 0);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.ScrollBarsEnabled = false;
            this.browser.Size = new System.Drawing.Size(877, 406);
            this.browser.TabIndex = 10;
            this.browser.Visible = false;
            this.browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browser_DocumentCompleted);
            // 
            // tabPanelSync
            // 
            this.tabPanelSync.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tabPanelSync.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelSync.Location = new System.Drawing.Point(0, 51);
            this.tabPanelSync.Name = "tabPanelSync";
            this.tabPanelSync.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tabPanelSync.Size = new System.Drawing.Size(883, 409);
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
            // tabLogin
            // 
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Panel = this.tabPanelLogin;
            this.tabLogin.Text = "&LOGIN";
            // 
            // tabLink
            // 
            this.tabLink.Checked = true;
            this.tabLink.Name = "tabLink";
            this.tabLink.Panel = this.tabPanelLink;
            this.tabLink.Text = "L&INK";
            this.tabLink.Click += new System.EventHandler(this.TabLinkClick);
            // 
            // tabSync
            // 
            this.tabSync.Name = "tabSync";
            this.tabSync.Panel = this.tabPanelSync;
            this.tabSync.Text = "&SYNC";
            // 
            // Style
            // 
            this.Style.ManagerColorTint = System.Drawing.Color.White;
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
            this.status.Location = new System.Drawing.Point(0, 440);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(883, 21);
            this.status.TabIndex = 1;
            this.status.Text = "Status";
            // 
            // lbState
            // 
            this.lbState.Name = "lbState";
            this.lbState.Text = "READY";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.status);
            this.Controls.Add(this.Shell);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(884, 462);
            this.Name = "Main";
            this.Text = "Googlebook";
            this.Shell.ResumeLayout(false);
            this.Shell.PerformLayout();
            this.tabPanelLink.ResumeLayout(false);
            this.tabPanelLogin.ResumeLayout(false);
            this.pGoogleLogin.ResumeLayout(false);
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
        private DevComponents.DotNetBar.Controls.StepIndicator step;
        private System.Windows.Forms.WebBrowser browser;
        private DevComponents.DotNetBar.Controls.GroupPanel pGoogleLogin;
        private DevComponents.DotNetBar.LabelX lHeader;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX tbUser;
        private DevComponents.DotNetBar.ButtonX bGoogleLogin;
        private DevComponents.DotNetBar.ItemPanel pUnlinkedContacts;
        private DevComponents.DotNetBar.ItemPanel itemPanel2;

    }
}

