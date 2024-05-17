namespace MemoirRush
{
    partial class Todo
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
            today = new Label();
            weekly_list = new CheckedListBox();
            day_textbox = new TextBox();
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            add_day_task = new Button();
            add_week_task = new Button();
            week_textbox = new TextBox();
            create_file = new Button();
            append_to_file = new Button();
            todays_list = new CheckedListBox();
            checksheet = new Button();
            get_file = new Button();
            openFileDialog = new OpenFileDialog();
            remove = new Button();
            serialize_button = new Button();
            Deserialize_button = new Button();
            label2 = new Label();
            label3 = new Label();
            _Sticky_notes_richtextbox = new RichTextBox();
            _Monthly_listbox = new CheckedListBox();
            Add_sticky = new Button();
            _add_monthlyButton = new Button();
            monthly_textbox = new TextBox();
            _stickylistBOX = new CheckedListBox();
            vScrollBarSticky = new VScrollBar();
            vScrollBar_Weekly = new VScrollBar();
            vScrollBar_Today = new VScrollBar();
            vScrollBarMonthly = new VScrollBar();
            add_stickytextbox = new TextBox();
            RichtextBox_button = new Button();
            vScrollBar_richtextbox = new VScrollBar();
            Jukebox_button = new MaterialSkin.Controls.MaterialButton();
            
            SuspendLayout();
            // 
            // today
            // 
            today.AutoSize = true;
            today.Location = new Point(496, 455);
            today.Name = "today";
            today.Size = new Size(45, 18);
            today.TabIndex = 1;
            today.Text = "Today";
            // 
            // weekly_list
            // 
            weekly_list.FormattingEnabled = true;
            weekly_list.Location = new Point(791, 478);
            weekly_list.Name = "weekly_list";
            weekly_list.Size = new Size(223, 340);
            weekly_list.TabIndex = 2;
            weekly_list.SelectedIndexChanged += weekly_list_SelectedIndexChanged;
            // 
            // day_textbox
            // 
            day_textbox.Location = new Point(619, 842);
            day_textbox.Name = "day_textbox";
            day_textbox.Size = new Size(114, 26);
            day_textbox.TabIndex = 4;
            day_textbox.TextChanged += day_textbox_TextChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(2, 2);
            monthCalendar1.Location = new Point(791, 30);
            monthCalendar1.Margin = new Padding(9, 8, 9, 8);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(791, 455);
            label1.Name = "label1";
            label1.Size = new Size(51, 18);
            label1.TabIndex = 9;
            label1.Text = "Weekly";
            // 
            // add_day_task
            // 
            add_day_task.Location = new Point(496, 842);
            add_day_task.Name = "add_day_task";
            add_day_task.Size = new Size(117, 26);
            add_day_task.TabIndex = 10;
            add_day_task.Text = "Add Day Task";
            add_day_task.UseVisualStyleBackColor = true;
            add_day_task.Click += add_day_task_Click;
            // 
            // add_week_task
            // 
            add_week_task.Location = new Point(791, 847);
            add_week_task.Name = "add_week_task";
            add_week_task.Size = new Size(117, 26);
            add_week_task.TabIndex = 11;
            add_week_task.Text = "Add Week Task";
            add_week_task.UseVisualStyleBackColor = true;
            add_week_task.Click += add_week_task_Click;
            // 
            // week_textbox
            // 
            week_textbox.Location = new Point(914, 849);
            week_textbox.Name = "week_textbox";
            week_textbox.Size = new Size(100, 26);
            week_textbox.TabIndex = 12;
            week_textbox.TextChanged += week_textbox_TextChanged;
            // 
            // create_file
            // 
            create_file.Location = new Point(1362, 86);
            create_file.Name = "create_file";
            create_file.Size = new Size(70, 58);
            create_file.TabIndex = 13;
            create_file.Text = "Create A New File";
            create_file.UseVisualStyleBackColor = true;
            create_file.Click += create_file_Click;
            // 
            // append_to_file
            // 
            append_to_file.Location = new Point(1388, 150);
            append_to_file.Name = "append_to_file";
            append_to_file.Size = new Size(78, 58);
            append_to_file.TabIndex = 14;
            append_to_file.Text = "Append To File";
            append_to_file.UseVisualStyleBackColor = true;
            append_to_file.Click += append_to_file_Click;
            // 
            // todays_list
            // 
            todays_list.FormattingEnabled = true;
            todays_list.Location = new Point(496, 478);
            todays_list.Name = "todays_list";
            todays_list.Size = new Size(237, 340);
            todays_list.TabIndex = 15;
            todays_list.SelectedIndexChanged += todays_list_SelectedIndexChanged;
            // 
            // checksheet
            // 
            checksheet.Location = new Point(1446, 8);
            checksheet.Name = "checksheet";
            checksheet.Size = new Size(70, 72);
            checksheet.TabIndex = 16;
            checksheet.Text = "Check if Sheet exist";
            checksheet.UseVisualStyleBackColor = true;
            checksheet.Click += checksheet_Click;
            // 
            // get_file
            // 
            get_file.Location = new Point(1438, 86);
            get_file.Name = "get_file";
            get_file.Size = new Size(78, 58);
            get_file.TabIndex = 18;
            get_file.Text = "Get the File";
            get_file.UseVisualStyleBackColor = true;
            get_file.Click += get_file_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // remove
            // 
            remove.Location = new Point(1362, 18);
            remove.Name = "remove";
            remove.Size = new Size(78, 53);
            remove.TabIndex = 19;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // serialize_button
            // 
            serialize_button.Location = new Point(1331, 363);
            serialize_button.Name = "serialize_button";
            serialize_button.Size = new Size(185, 50);
            serialize_button.TabIndex = 20;
            serialize_button.Text = "Serialize";
            serialize_button.UseVisualStyleBackColor = true;
            // 
            // Deserialize_button
            // 
            Deserialize_button.Location = new Point(1331, 300);
            Deserialize_button.Name = "Deserialize_button";
            Deserialize_button.Size = new Size(185, 57);
            Deserialize_button.TabIndex = 21;
            Deserialize_button.Text = "Deserialize";
            Deserialize_button.UseVisualStyleBackColor = true;
            Deserialize_button.Click += Deserialize_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 455);
            label2.Name = "label2";
            label2.Size = new Size(137, 18);
            label2.TabIndex = 22;
            label2.Text = "MONTHLY OBJECTIVE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 8);
            label3.Name = "label3";
            label3.Size = new Size(82, 18);
            label3.TabIndex = 23;
            label3.Text = "Sticky Notes";
            // 
            // _Sticky_notes_richtextbox
            // 
            _Sticky_notes_richtextbox.Location = new Point(242, 30);
            _Sticky_notes_richtextbox.Name = "_Sticky_notes_richtextbox";
            _Sticky_notes_richtextbox.Size = new Size(514, 360);
            _Sticky_notes_richtextbox.TabIndex = 24;
            _Sticky_notes_richtextbox.Text = "";
            _Sticky_notes_richtextbox.TextChanged += _Sticky_notes_richtextbox_TextChanged;
            // 
            // _Monthly_listbox
            // 
            _Monthly_listbox.FormattingEnabled = true;
            _Monthly_listbox.Location = new Point(12, 478);
            _Monthly_listbox.Name = "_Monthly_listbox";
            _Monthly_listbox.Size = new Size(344, 340);
            _Monthly_listbox.TabIndex = 25;
            // 
            // Add_sticky
            // 
            Add_sticky.Location = new Point(12, 397);
            Add_sticky.Name = "Add_sticky";
            Add_sticky.Size = new Size(90, 26);
            Add_sticky.TabIndex = 26;
            Add_sticky.Text = "ADD STICKY NOTE";
            Add_sticky.UseVisualStyleBackColor = true;
            Add_sticky.Click += Add_sticky_Click;
            // 
            // _add_monthlyButton
            // 
            _add_monthlyButton.Location = new Point(8, 843);
            _add_monthlyButton.Name = "_add_monthlyButton";
            _add_monthlyButton.Size = new Size(94, 26);
            _add_monthlyButton.TabIndex = 27;
            _add_monthlyButton.Text = "ADD";
            _add_monthlyButton.UseVisualStyleBackColor = true;
            _add_monthlyButton.Click += _add_monthlyButton_Click;
            // 
            // monthly_textbox
            // 
            monthly_textbox.Location = new Point(108, 843);
            monthly_textbox.Name = "monthly_textbox";
            monthly_textbox.Size = new Size(248, 26);
            monthly_textbox.TabIndex = 28;
            // 
            // _stickylistBOX
            // 
            _stickylistBOX.FormattingEnabled = true;
            _stickylistBOX.Location = new Point(41, 30);
            _stickylistBOX.Name = "_stickylistBOX";
            _stickylistBOX.Size = new Size(150, 340);
            _stickylistBOX.TabIndex = 29;
            _stickylistBOX.SelectedIndexChanged += _stickylistBOX_SelectedIndexChanged;
            // 
            // vScrollBarSticky
            // 
            vScrollBarSticky.Location = new Point(12, 30);
            vScrollBarSticky.Name = "vScrollBarSticky";
            vScrollBarSticky.Size = new Size(26, 360);
            vScrollBarSticky.TabIndex = 30;
            // 
            // vScrollBar_Weekly
            // 
            vScrollBar_Weekly.Location = new Point(1017, 478);
            vScrollBar_Weekly.Name = "vScrollBar_Weekly";
            vScrollBar_Weekly.Size = new Size(26, 360);
            vScrollBar_Weekly.TabIndex = 32;
            // 
            // vScrollBar_Today
            // 
            vScrollBar_Today.Location = new Point(736, 478);
            vScrollBar_Today.Name = "vScrollBar_Today";
            vScrollBar_Today.Size = new Size(26, 360);
            vScrollBar_Today.TabIndex = 33;
            // 
            // vScrollBarMonthly
            // 
            vScrollBarMonthly.Location = new Point(359, 478);
            vScrollBarMonthly.Name = "vScrollBarMonthly";
            vScrollBarMonthly.Size = new Size(26, 360);
            vScrollBarMonthly.TabIndex = 34;
            // 
            // add_stickytextbox
            // 
            add_stickytextbox.Location = new Point(108, 399);
            add_stickytextbox.Name = "add_stickytextbox";
            add_stickytextbox.Size = new Size(102, 26);
            add_stickytextbox.TabIndex = 35;
            // 
            // RichtextBox_button
            // 
            RichtextBox_button.Location = new Point(242, 399);
            RichtextBox_button.Name = "RichtextBox_button";
            RichtextBox_button.Size = new Size(514, 26);
            RichtextBox_button.TabIndex = 36;
            RichtextBox_button.Text = "Show To Rich Text Box";
            RichtextBox_button.UseVisualStyleBackColor = true;
            RichtextBox_button.Click += RichtextBox_button_Click;
            // 
            // vScrollBar_richtextbox
            // 
            vScrollBar_richtextbox.Location = new Point(756, 30);
            vScrollBar_richtextbox.Name = "vScrollBar_richtextbox";
            vScrollBar_richtextbox.Size = new Size(26, 360);
            vScrollBar_richtextbox.TabIndex = 37;
            // 
            // Jukebox_button
            // 
            Jukebox_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Jukebox_button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Jukebox_button.Depth = 0;
            Jukebox_button.HighEmphasis = true;
            Jukebox_button.Icon = null;
            Jukebox_button.Location = new Point(1430, 827);
            Jukebox_button.Margin = new Padding(4, 6, 4, 6);
            Jukebox_button.MouseState = MaterialSkin.MouseState.HOVER;
            Jukebox_button.Name = "Jukebox_button";
            Jukebox_button.NoAccentTextColor = Color.Empty;
            Jukebox_button.Size = new Size(86, 36);
            Jukebox_button.TabIndex = 38;
            Jukebox_button.Text = "Jukebox";
            Jukebox_button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Jukebox_button.UseAccentColor = false;
            Jukebox_button.UseVisualStyleBackColor = true;
            // 
            // 
            // Todo
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1526, 878);
            Controls.Add(Jukebox_button);
            Controls.Add(vScrollBar_richtextbox);
            Controls.Add(RichtextBox_button);
            Controls.Add(add_stickytextbox);
            Controls.Add(vScrollBarMonthly);
            Controls.Add(vScrollBar_Today);
            Controls.Add(vScrollBar_Weekly);
            Controls.Add(vScrollBarSticky);
            Controls.Add(_stickylistBOX);
            Controls.Add(monthly_textbox);
            Controls.Add(_add_monthlyButton);
            Controls.Add(Add_sticky);
            Controls.Add(_Monthly_listbox);
            Controls.Add(_Sticky_notes_richtextbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Deserialize_button);
            Controls.Add(serialize_button);
            Controls.Add(remove);
            Controls.Add(get_file);
            Controls.Add(checksheet);
            Controls.Add(todays_list);
            Controls.Add(append_to_file);
            Controls.Add(create_file);
            Controls.Add(week_textbox);
            Controls.Add(add_week_task);
            Controls.Add(add_day_task);
            Controls.Add(label1);
            Controls.Add(monthCalendar1);
            Controls.Add(day_textbox);
            Controls.Add(weekly_list);
            Controls.Add(today);
            Font = new Font("Calibri", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.Fuchsia;
            Name = "Todo";
            Load += Weekly_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label today;
        private CheckedListBox weekly_list;
        private TextBox day_textbox;
        private MonthCalendar monthCalendar1;
        private Label label1;
        private Button add_day_task;
        private Button add_week_task;
        private TextBox week_textbox;
        private Button create_file;
        private Button append_to_file;
        private CheckedListBox todays_list;
        private Button checksheet;
        private Button get_file;
        private OpenFileDialog openFileDialog;
        private Button remove;
        private Button serialize_button;
        private Button Deserialize_button;
        private Label label2;
        private Label label3;
        private RichTextBox _Sticky_notes_richtextbox;
        private CheckedListBox _Monthly_listbox;
        private Button Add_sticky;
        private Button _add_monthlyButton;
        private TextBox monthly_textbox;
        private CheckedListBox _stickylistBOX;
        private VScrollBar vScrollBarSticky;
        private VScrollBar vScrollBar_Weekly;
        private VScrollBar vScrollBar_Today;
        private VScrollBar vScrollBar1;
        private TextBox textBox2;
        private VScrollBar vScrollBar2;
        private VScrollBar vScrollBar3;
        private VScrollBar vScrollBarMonthly;
        private TextBox add_stickytextbox;
        private Button RichtextBox_button;
        private VScrollBar vScrollBar_richtextbox;
        private MaterialSkin.Controls.MaterialButton Jukebox_button;
    }
}