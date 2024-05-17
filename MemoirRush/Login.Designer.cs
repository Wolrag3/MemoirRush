namespace MemoirRush
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            _loginButton = new MaterialSkin.Controls.MaterialButton();
            _SignUP_button = new MaterialSkin.Controls.MaterialButton();
            _passwordTextbox = new MaterialSkin.Controls.MaterialTextBox2();
            _usernameTextbox = new MaterialSkin.Controls.MaterialTextBox2();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(180, 150);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(72, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Username";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(180, 197);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(71, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Password";
            // 
            // _loginButton
            // 
            _loginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            _loginButton.Depth = 0;
            _loginButton.HighEmphasis = true;
            _loginButton.Icon = null;
            _loginButton.Location = new Point(302, 232);
            _loginButton.Margin = new Padding(4, 6, 4, 6);
            _loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            _loginButton.Name = "_loginButton";
            _loginButton.NoAccentTextColor = Color.Empty;
            _loginButton.Size = new Size(64, 36);
            _loginButton.TabIndex = 2;
            _loginButton.Text = "Login";
            _loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            _loginButton.UseAccentColor = false;
            _loginButton.UseVisualStyleBackColor = true;
            _loginButton.Click += _loginButton_Click;
            // 
            // _SignUP_button
            // 
            _SignUP_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _SignUP_button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            _SignUP_button.Depth = 0;
            _SignUP_button.HighEmphasis = true;
            _SignUP_button.Icon = null;
            _SignUP_button.Location = new Point(537, 232);
            _SignUP_button.Margin = new Padding(4, 6, 4, 6);
            _SignUP_button.MouseState = MaterialSkin.MouseState.HOVER;
            _SignUP_button.Name = "_SignUP_button";
            _SignUP_button.NoAccentTextColor = Color.Empty;
            _SignUP_button.Size = new Size(77, 36);
            _SignUP_button.TabIndex = 3;
            _SignUP_button.Text = "Sign Up";
            _SignUP_button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            _SignUP_button.UseAccentColor = false;
            _SignUP_button.UseVisualStyleBackColor = true;
            _SignUP_button.Click += _SignUP_button_Click;
            // 
            // _passwordTextbox
            // 
            _passwordTextbox.AnimateReadOnly = false;
            _passwordTextbox.BackgroundImageLayout = ImageLayout.None;
            _passwordTextbox.CharacterCasing = CharacterCasing.Normal;
            _passwordTextbox.Depth = 0;
            _passwordTextbox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            _passwordTextbox.HideSelection = true;
            _passwordTextbox.LeadingIcon = null;
            _passwordTextbox.Location = new Point(302, 175);
            _passwordTextbox.MaxLength = 32767;
            _passwordTextbox.MouseState = MaterialSkin.MouseState.OUT;
            _passwordTextbox.Name = "_passwordTextbox";
            _passwordTextbox.PasswordChar = '\0';
            _passwordTextbox.PrefixSuffixText = null;
            _passwordTextbox.ReadOnly = false;
            _passwordTextbox.RightToLeft = RightToLeft.No;
            _passwordTextbox.SelectedText = "";
            _passwordTextbox.SelectionLength = 0;
            _passwordTextbox.SelectionStart = 0;
            _passwordTextbox.ShortcutsEnabled = true;
            _passwordTextbox.Size = new Size(312, 48);
            _passwordTextbox.TabIndex = 4;
            _passwordTextbox.TabStop = false;
            _passwordTextbox.TextAlign = HorizontalAlignment.Left;
            _passwordTextbox.TrailingIcon = null;
            _passwordTextbox.UseSystemPasswordChar = false;
            // 
            // _usernameTextbox
            // 
            _usernameTextbox.AnimateReadOnly = false;
            _usernameTextbox.BackgroundImageLayout = ImageLayout.None;
            _usernameTextbox.CharacterCasing = CharacterCasing.Normal;
            _usernameTextbox.Depth = 0;
            _usernameTextbox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            _usernameTextbox.HideSelection = true;
            _usernameTextbox.LeadingIcon = null;
            _usernameTextbox.Location = new Point(302, 121);
            _usernameTextbox.MaxLength = 32767;
            _usernameTextbox.MouseState = MaterialSkin.MouseState.OUT;
            _usernameTextbox.Name = "_usernameTextbox";
            _usernameTextbox.PasswordChar = '\0';
            _usernameTextbox.PrefixSuffixText = null;
            _usernameTextbox.ReadOnly = false;
            _usernameTextbox.RightToLeft = RightToLeft.No;
            _usernameTextbox.SelectedText = "";
            _usernameTextbox.SelectionLength = 0;
            _usernameTextbox.SelectionStart = 0;
            _usernameTextbox.ShortcutsEnabled = true;
            _usernameTextbox.Size = new Size(312, 48);
            _usernameTextbox.TabIndex = 5;
            _usernameTextbox.TabStop = false;
            _usernameTextbox.TextAlign = HorizontalAlignment.Left;
            _usernameTextbox.TrailingIcon = null;
            _usernameTextbox.UseSystemPasswordChar = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_usernameTextbox);
            Controls.Add(_passwordTextbox);
            Controls.Add(_SignUP_button);
            Controls.Add(_loginButton);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton _loginButton;
        private MaterialSkin.Controls.MaterialButton _SignUP_button;
        private MaterialSkin.Controls.MaterialTextBox2 _passwordTextbox;
        private MaterialSkin.Controls.MaterialTextBox2 _usernameTextbox;
    }
}
