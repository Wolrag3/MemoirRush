namespace MemoirRush
{
    partial class SignUp
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
            _SignupButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            _passwordTextboxsignup = new MaterialSkin.Controls.MaterialTextBox();
            _emailTextboxsignup = new MaterialSkin.Controls.MaterialTextBox();
            _nameTextboxsignup = new MaterialSkin.Controls.MaterialTextBox();
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            Login_page_Button = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // _SignupButton
            // 
            _SignupButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _SignupButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            _SignupButton.Depth = 0;
            _SignupButton.HighEmphasis = true;
            _SignupButton.Icon = null;
            _SignupButton.Location = new Point(405, 300);
            _SignupButton.Margin = new Padding(4, 6, 4, 6);
            _SignupButton.MouseState = MaterialSkin.MouseState.HOVER;
            _SignupButton.Name = "_SignupButton";
            _SignupButton.NoAccentTextColor = Color.Empty;
            _SignupButton.Size = new Size(77, 36);
            _SignupButton.TabIndex = 0;
            _SignupButton.Text = "Sign Up";
            _SignupButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            _SignupButton.UseAccentColor = false;
            _SignupButton.UseVisualStyleBackColor = true;
            _SignupButton.Click += _SignupButton_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(219, 174);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(41, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Email";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(219, 106);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(43, 19);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Name";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(219, 235);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(71, 19);
            materialLabel3.TabIndex = 3;
            materialLabel3.Text = "Password";
            // 
            // _passwordTextboxsignup
            // 
            _passwordTextboxsignup.AnimateReadOnly = false;
            _passwordTextboxsignup.BorderStyle = BorderStyle.None;
            _passwordTextboxsignup.Depth = 0;
            _passwordTextboxsignup.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            _passwordTextboxsignup.LeadingIcon = null;
            _passwordTextboxsignup.Location = new Point(332, 224);
            _passwordTextboxsignup.MaxLength = 50;
            _passwordTextboxsignup.MouseState = MaterialSkin.MouseState.OUT;
            _passwordTextboxsignup.Multiline = false;
            _passwordTextboxsignup.Name = "_passwordTextboxsignup";
            _passwordTextboxsignup.Size = new Size(251, 50);
            _passwordTextboxsignup.TabIndex = 4;
            _passwordTextboxsignup.Text = "";
            _passwordTextboxsignup.TrailingIcon = null;
            // 
            // _emailTextboxsignup
            // 
            _emailTextboxsignup.AnimateReadOnly = false;
            _emailTextboxsignup.BorderStyle = BorderStyle.None;
            _emailTextboxsignup.Depth = 0;
            _emailTextboxsignup.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            _emailTextboxsignup.LeadingIcon = null;
            _emailTextboxsignup.Location = new Point(332, 160);
            _emailTextboxsignup.MaxLength = 50;
            _emailTextboxsignup.MouseState = MaterialSkin.MouseState.OUT;
            _emailTextboxsignup.Multiline = false;
            _emailTextboxsignup.Name = "_emailTextboxsignup";
            _emailTextboxsignup.Size = new Size(251, 50);
            _emailTextboxsignup.TabIndex = 5;
            _emailTextboxsignup.Text = "";
            _emailTextboxsignup.TrailingIcon = null;
            // 
            // _nameTextboxsignup
            // 
            _nameTextboxsignup.AnimateReadOnly = false;
            _nameTextboxsignup.BorderStyle = BorderStyle.None;
            _nameTextboxsignup.Depth = 0;
            _nameTextboxsignup.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            _nameTextboxsignup.LeadingIcon = null;
            _nameTextboxsignup.Location = new Point(332, 87);
            _nameTextboxsignup.MaxLength = 50;
            _nameTextboxsignup.MouseState = MaterialSkin.MouseState.OUT;
            _nameTextboxsignup.Multiline = false;
            _nameTextboxsignup.Name = "_nameTextboxsignup";
            _nameTextboxsignup.Size = new Size(251, 50);
            _nameTextboxsignup.TabIndex = 6;
            _nameTextboxsignup.Text = "";
            _nameTextboxsignup.TrailingIcon = null;
            _nameTextboxsignup.TextChanged += _nameTextboxsignup_TextChanged_1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 24);
            menuStrip2.TabIndex = 8;
            menuStrip2.Text = "menuStrip2";
            // 
            // Login_page_Button
            // 
            Login_page_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Login_page_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Login_page_Button.Depth = 0;
            Login_page_Button.HighEmphasis = true;
            Login_page_Button.Icon = null;
            Login_page_Button.Location = new Point(13, 30);
            Login_page_Button.Margin = new Padding(4, 6, 4, 6);
            Login_page_Button.MouseState = MaterialSkin.MouseState.HOVER;
            Login_page_Button.Name = "Login_page_Button";
            Login_page_Button.NoAccentTextColor = Color.Empty;
            Login_page_Button.Size = new Size(158, 36);
            Login_page_Button.TabIndex = 9;
            Login_page_Button.Text = "Login Page";
            Login_page_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Login_page_Button.UseAccentColor = false;
            Login_page_Button.UseVisualStyleBackColor = true;
            Login_page_Button.Click += Login_page_Button_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Login_page_Button);
            Controls.Add(_emailTextboxsignup);
            Controls.Add(_passwordTextboxsignup);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(_SignupButton);
            Controls.Add(_nameTextboxsignup);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "SignUp";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton _SignupButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox _passwordTextboxsignup;
        private MaterialSkin.Controls.MaterialTextBox _emailTextboxsignup;
        private MaterialSkin.Controls.MaterialTextBox _nameTextboxsignup;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private MaterialSkin.Controls.MaterialButton Login_page_Button;
    }
}