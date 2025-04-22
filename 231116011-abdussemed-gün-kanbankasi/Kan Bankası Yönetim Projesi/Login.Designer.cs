namespace Kan_Bankası_Yönetim_Projesi
{
	partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            kullanıcıTxt = new Bunifu.UI.WinForms.BunifuTextBox();
            sifreTxt = new Bunifu.UI.WinForms.BunifuTextBox();
            bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(28, 93);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(65, 22);
            label2.Name = "label2";
            label2.Size = new Size(296, 30);
            label2.TabIndex = 2;
            label2.Text = "Kan Bankası Yönetim Sistemi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(28, 128);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 4;
            label3.Text = "Sifre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(91, 223);
            label4.Name = "label4";
            label4.Size = new Size(242, 30);
            label4.TabIndex = 7;
            label4.Text = "Admin olarak devam et";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(377, 9);
            label5.Name = "label5";
            label5.Size = new Size(24, 25);
            label5.TabIndex = 8;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // kullanıcıTxt
            // 
            kullanıcıTxt.AcceptsReturn = false;
            kullanıcıTxt.AcceptsTab = false;
            kullanıcıTxt.AnimationSpeed = 200;
            kullanıcıTxt.AutoCompleteMode = AutoCompleteMode.None;
            kullanıcıTxt.AutoCompleteSource = AutoCompleteSource.None;
            kullanıcıTxt.AutoSizeHeight = true;
            kullanıcıTxt.BackColor = Color.Transparent;
            kullanıcıTxt.BackgroundImage = (Image)resources.GetObject("kullanıcıTxt.BackgroundImage");
            kullanıcıTxt.BorderColorActive = Color.DodgerBlue;
            kullanıcıTxt.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            kullanıcıTxt.BorderColorHover = Color.FromArgb(105, 181, 255);
            kullanıcıTxt.BorderColorIdle = Color.Silver;
            kullanıcıTxt.BorderRadius = 1;
            kullanıcıTxt.BorderThickness = 1;
            kullanıcıTxt.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            kullanıcıTxt.CharacterCasing = CharacterCasing.Normal;
            kullanıcıTxt.DefaultFont = new Font("Segoe UI", 9.25F);
            kullanıcıTxt.DefaultText = "";
            kullanıcıTxt.FillColor = Color.White;
            kullanıcıTxt.HideSelection = true;
            kullanıcıTxt.IconLeft = null;
            kullanıcıTxt.IconLeftCursor = Cursors.IBeam;
            kullanıcıTxt.IconPadding = 10;
            kullanıcıTxt.IconRight = null;
            kullanıcıTxt.IconRightCursor = Cursors.IBeam;
            kullanıcıTxt.Location = new Point(141, 93);
            kullanıcıTxt.MaxLength = 32767;
            kullanıcıTxt.MinimumSize = new Size(1, 1);
            kullanıcıTxt.Modified = false;
            kullanıcıTxt.Multiline = false;
            kullanıcıTxt.Name = "kullanıcıTxt";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            kullanıcıTxt.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            kullanıcıTxt.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            kullanıcıTxt.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            kullanıcıTxt.OnIdleState = stateProperties4;
            kullanıcıTxt.Padding = new Padding(3);
            kullanıcıTxt.PasswordChar = '\0';
            kullanıcıTxt.PlaceholderForeColor = Color.Silver;
            kullanıcıTxt.PlaceholderText = "Enter text";
            kullanıcıTxt.ReadOnly = false;
            kullanıcıTxt.ScrollBars = ScrollBars.None;
            kullanıcıTxt.SelectedText = "";
            kullanıcıTxt.SelectionLength = 0;
            kullanıcıTxt.SelectionStart = 0;
            kullanıcıTxt.ShortcutsEnabled = true;
            kullanıcıTxt.Size = new Size(227, 29);
            kullanıcıTxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            kullanıcıTxt.TabIndex = 9;
            kullanıcıTxt.TextAlign = HorizontalAlignment.Left;
            kullanıcıTxt.TextMarginBottom = 0;
            kullanıcıTxt.TextMarginLeft = 3;
            kullanıcıTxt.TextMarginTop = 1;
            kullanıcıTxt.TextPlaceholder = "Enter text";
            kullanıcıTxt.UseSystemPasswordChar = false;
            kullanıcıTxt.WordWrap = true;
            // 
            // sifreTxt
            // 
            sifreTxt.AcceptsReturn = false;
            sifreTxt.AcceptsTab = false;
            sifreTxt.AnimationSpeed = 200;
            sifreTxt.AutoCompleteMode = AutoCompleteMode.None;
            sifreTxt.AutoCompleteSource = AutoCompleteSource.None;
            sifreTxt.AutoSizeHeight = true;
            sifreTxt.BackColor = Color.Transparent;
            sifreTxt.BackgroundImage = (Image)resources.GetObject("sifreTxt.BackgroundImage");
            sifreTxt.BorderColorActive = Color.DodgerBlue;
            sifreTxt.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            sifreTxt.BorderColorHover = Color.FromArgb(105, 181, 255);
            sifreTxt.BorderColorIdle = Color.Silver;
            sifreTxt.BorderRadius = 1;
            sifreTxt.BorderThickness = 1;
            sifreTxt.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            sifreTxt.CharacterCasing = CharacterCasing.Normal;
            sifreTxt.DefaultFont = new Font("Segoe UI", 9.25F);
            sifreTxt.DefaultText = "";
            sifreTxt.FillColor = Color.White;
            sifreTxt.HideSelection = true;
            sifreTxt.IconLeft = null;
            sifreTxt.IconLeftCursor = Cursors.IBeam;
            sifreTxt.IconPadding = 10;
            sifreTxt.IconRight = null;
            sifreTxt.IconRightCursor = Cursors.IBeam;
            sifreTxt.Location = new Point(141, 134);
            sifreTxt.MaxLength = 32767;
            sifreTxt.MinimumSize = new Size(1, 1);
            sifreTxt.Modified = false;
            sifreTxt.Multiline = false;
            sifreTxt.Name = "sifreTxt";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            sifreTxt.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            sifreTxt.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            sifreTxt.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.White;
            stateProperties8.ForeColor = Color.Empty;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            sifreTxt.OnIdleState = stateProperties8;
            sifreTxt.Padding = new Padding(3);
            sifreTxt.PasswordChar = '\0';
            sifreTxt.PlaceholderForeColor = Color.Silver;
            sifreTxt.PlaceholderText = "Enter text";
            sifreTxt.ReadOnly = false;
            sifreTxt.ScrollBars = ScrollBars.None;
            sifreTxt.SelectedText = "";
            sifreTxt.SelectionLength = 0;
            sifreTxt.SelectionStart = 0;
            sifreTxt.ShortcutsEnabled = true;
            sifreTxt.Size = new Size(227, 39);
            sifreTxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            sifreTxt.TabIndex = 10;
            sifreTxt.TextAlign = HorizontalAlignment.Left;
            sifreTxt.TextMarginBottom = 0;
            sifreTxt.TextMarginLeft = 3;
            sifreTxt.TextMarginTop = 1;
            sifreTxt.TextPlaceholder = "Enter text";
            sifreTxt.UseSystemPasswordChar = false;
            sifreTxt.WordWrap = true;
            // 
            // bunifuButton1
            // 
            bunifuButton1.AllowAnimations = true;
            bunifuButton1.AllowMouseEffects = true;
            bunifuButton1.AllowToggling = false;
            bunifuButton1.AnimationSpeed = 200;
            bunifuButton1.AutoGenerateColors = false;
            bunifuButton1.AutoRoundBorders = false;
            bunifuButton1.AutoSizeLeftIcon = true;
            bunifuButton1.AutoSizeRightIcon = true;
            bunifuButton1.BackColor = Color.Transparent;
            bunifuButton1.BackColor1 = Color.FromArgb(51, 122, 183);
            bunifuButton1.BackgroundImage = (Image)resources.GetObject("bunifuButton1.BackgroundImage");
            bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.ButtonText = "GİRİŞ";
            bunifuButton1.ButtonTextMarginLeft = 0;
            bunifuButton1.ColorContrastOnClick = 45;
            bunifuButton1.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            bunifuButton1.CustomizableEdges = borderEdges1;
            bunifuButton1.DialogResult = DialogResult.None;
            bunifuButton1.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton1.DisabledFillColor = Color.Empty;
            bunifuButton1.DisabledForecolor = Color.Empty;
            bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            bunifuButton1.Font = new Font("Segoe UI", 9F);
            bunifuButton1.ForeColor = Color.White;
            bunifuButton1.IconLeft = null;
            bunifuButton1.IconLeftAlign = ContentAlignment.MiddleLeft;
            bunifuButton1.IconLeftCursor = Cursors.Default;
            bunifuButton1.IconLeftPadding = new Padding(11, 3, 3, 3);
            bunifuButton1.IconMarginLeft = 11;
            bunifuButton1.IconPadding = 10;
            bunifuButton1.IconRight = null;
            bunifuButton1.IconRightAlign = ContentAlignment.MiddleRight;
            bunifuButton1.IconRightCursor = Cursors.Default;
            bunifuButton1.IconRightPadding = new Padding(3, 3, 7, 3);
            bunifuButton1.IconSize = 25;
            bunifuButton1.IdleBorderColor = Color.Empty;
            bunifuButton1.IdleBorderRadius = 0;
            bunifuButton1.IdleBorderThickness = 0;
            bunifuButton1.IdleFillColor = Color.Empty;
            bunifuButton1.IdleIconLeftImage = null;
            bunifuButton1.IdleIconRightImage = null;
            bunifuButton1.IndicateFocus = false;
            bunifuButton1.Location = new Point(153, 179);
            bunifuButton1.Name = "bunifuButton1";
            bunifuButton1.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton1.OnDisabledState.BorderRadius = 1;
            bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.OnDisabledState.BorderThickness = 1;
            bunifuButton1.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuButton1.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuButton1.OnDisabledState.IconLeftImage = null;
            bunifuButton1.OnDisabledState.IconRightImage = null;
            bunifuButton1.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            bunifuButton1.onHoverState.BorderRadius = 1;
            bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.onHoverState.BorderThickness = 1;
            bunifuButton1.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            bunifuButton1.onHoverState.ForeColor = Color.White;
            bunifuButton1.onHoverState.IconLeftImage = null;
            bunifuButton1.onHoverState.IconRightImage = null;
            bunifuButton1.OnIdleState.BorderColor = Color.DodgerBlue;
            bunifuButton1.OnIdleState.BorderRadius = 1;
            bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.OnIdleState.BorderThickness = 1;
            bunifuButton1.OnIdleState.FillColor = Color.DodgerBlue;
            bunifuButton1.OnIdleState.ForeColor = Color.White;
            bunifuButton1.OnIdleState.IconLeftImage = null;
            bunifuButton1.OnIdleState.IconRightImage = null;
            bunifuButton1.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            bunifuButton1.OnPressedState.BorderRadius = 1;
            bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.OnPressedState.BorderThickness = 1;
            bunifuButton1.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            bunifuButton1.OnPressedState.ForeColor = Color.White;
            bunifuButton1.OnPressedState.IconLeftImage = null;
            bunifuButton1.OnPressedState.IconRightImage = null;
            bunifuButton1.Size = new Size(150, 39);
            bunifuButton1.TabIndex = 11;
            bunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton1.TextAlignment = HorizontalAlignment.Center;
            bunifuButton1.TextMarginLeft = 0;
            bunifuButton1.TextPadding = new Padding(0);
            bunifuButton1.UseDefaultRadiusAndThickness = true;
            bunifuButton1.Click += bunifuButton1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 263);
            Controls.Add(bunifuButton1);
            Controls.Add(sifreTxt);
            Controls.Add(kullanıcıTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
        private Bunifu.UI.WinForms.BunifuTextBox kullanıcıTxt;
        private Bunifu.UI.WinForms.BunifuTextBox sifreTxt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
    }
}