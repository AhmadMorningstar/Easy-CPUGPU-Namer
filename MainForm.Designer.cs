namespace CPU_GPU_Namer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label2 = new Label();
            label1 = new Label();
            original_cpu_name_label = new Label();
            current_cpu_name_label = new Label();
            new_cpu_name_label = new Label();
            new_cpu_name_textbox = new TextBox();
            original_gpu_name_label = new Label();
            current_gpu_name_label = new Label();
            current_cpu_name_textbox = new TextBox();
            original_cpu_name_textbox = new TextBox();
            current_gpu_name_textbox = new TextBox();
            original_gpu_name_textbox = new TextBox();
            new_gpu_name_textbox = new TextBox();
            new_gpu_name_label = new Label();
            apply_button = new Button();
            restore_defaults_button = new Button();
            exit_button = new Button();
            cpu_status_label = new Label();
            gpu_selection_comobox = new ComboBox();
            label3 = new Label();
            gpu_status_label = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(223, 208, 184);
            label2.Location = new Point(132, 42);
            label2.Name = "label2";
            label2.Size = new Size(151, 16);
            label2.TabIndex = 9;
            label2.Text = "By Ahmad Morningstar";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(148, 137, 121);
            label1.Location = new Point(6, 0);
            label1.Name = "label1";
            label1.Size = new Size(394, 38);
            label1.TabIndex = 1;
            label1.Text = "Easy CPU GPU Namer";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // original_cpu_name_label
            // 
            original_cpu_name_label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            original_cpu_name_label.BackColor = Color.Transparent;
            original_cpu_name_label.Font = new Font("Segoe UI", 14F);
            original_cpu_name_label.ForeColor = Color.FromArgb(234, 239, 239);
            original_cpu_name_label.Location = new Point(17, 156);
            original_cpu_name_label.Name = "original_cpu_name_label";
            original_cpu_name_label.Size = new Size(184, 28);
            original_cpu_name_label.TabIndex = 10;
            original_cpu_name_label.Text = "Original CPU Name: ";
            original_cpu_name_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // current_cpu_name_label
            // 
            current_cpu_name_label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            current_cpu_name_label.BackColor = Color.Transparent;
            current_cpu_name_label.Font = new Font("Segoe UI", 14F);
            current_cpu_name_label.ForeColor = Color.FromArgb(234, 239, 239);
            current_cpu_name_label.Location = new Point(17, 196);
            current_cpu_name_label.Name = "current_cpu_name_label";
            current_cpu_name_label.Size = new Size(184, 28);
            current_cpu_name_label.TabIndex = 11;
            current_cpu_name_label.Text = "Current CPU Name: ";
            current_cpu_name_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // new_cpu_name_label
            // 
            new_cpu_name_label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            new_cpu_name_label.BackColor = Color.Transparent;
            new_cpu_name_label.Font = new Font("Segoe UI", 14F);
            new_cpu_name_label.ForeColor = Color.FromArgb(234, 239, 239);
            new_cpu_name_label.Location = new Point(17, 236);
            new_cpu_name_label.Name = "new_cpu_name_label";
            new_cpu_name_label.Size = new Size(184, 28);
            new_cpu_name_label.TabIndex = 12;
            new_cpu_name_label.Text = "New CPU Name:";
            new_cpu_name_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // new_cpu_name_textbox
            // 
            new_cpu_name_textbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            new_cpu_name_textbox.BackColor = Color.FromArgb(34, 40, 49);
            new_cpu_name_textbox.ForeColor = SystemColors.Control;
            new_cpu_name_textbox.Location = new Point(207, 240);
            new_cpu_name_textbox.Name = "new_cpu_name_textbox";
            new_cpu_name_textbox.Size = new Size(195, 21);
            new_cpu_name_textbox.TabIndex = 2;
            // 
            // original_gpu_name_label
            // 
            original_gpu_name_label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            original_gpu_name_label.BackColor = Color.Transparent;
            original_gpu_name_label.Font = new Font("Segoe UI", 14F);
            original_gpu_name_label.ForeColor = Color.FromArgb(234, 239, 239);
            original_gpu_name_label.Location = new Point(17, 304);
            original_gpu_name_label.Name = "original_gpu_name_label";
            original_gpu_name_label.Size = new Size(184, 28);
            original_gpu_name_label.TabIndex = 14;
            original_gpu_name_label.Text = "Original GPU Name: ";
            original_gpu_name_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // current_gpu_name_label
            // 
            current_gpu_name_label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            current_gpu_name_label.BackColor = Color.Transparent;
            current_gpu_name_label.Font = new Font("Segoe UI", 14F);
            current_gpu_name_label.ForeColor = Color.FromArgb(234, 239, 239);
            current_gpu_name_label.Location = new Point(17, 347);
            current_gpu_name_label.Name = "current_gpu_name_label";
            current_gpu_name_label.Size = new Size(184, 28);
            current_gpu_name_label.TabIndex = 16;
            current_gpu_name_label.Text = "Current GPU Name:";
            current_gpu_name_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // current_cpu_name_textbox
            // 
            current_cpu_name_textbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            current_cpu_name_textbox.BackColor = Color.FromArgb(34, 40, 49);
            current_cpu_name_textbox.ForeColor = SystemColors.Control;
            current_cpu_name_textbox.Location = new Point(207, 200);
            current_cpu_name_textbox.Name = "current_cpu_name_textbox";
            current_cpu_name_textbox.ReadOnly = true;
            current_cpu_name_textbox.Size = new Size(195, 21);
            current_cpu_name_textbox.TabIndex = 5;
            // 
            // original_cpu_name_textbox
            // 
            original_cpu_name_textbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            original_cpu_name_textbox.BackColor = Color.FromArgb(34, 40, 49);
            original_cpu_name_textbox.ForeColor = SystemColors.Control;
            original_cpu_name_textbox.Location = new Point(207, 160);
            original_cpu_name_textbox.Name = "original_cpu_name_textbox";
            original_cpu_name_textbox.ReadOnly = true;
            original_cpu_name_textbox.Size = new Size(195, 21);
            original_cpu_name_textbox.TabIndex = 4;
            // 
            // current_gpu_name_textbox
            // 
            current_gpu_name_textbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            current_gpu_name_textbox.BackColor = Color.FromArgb(34, 40, 49);
            current_gpu_name_textbox.ForeColor = SystemColors.Control;
            current_gpu_name_textbox.Location = new Point(207, 351);
            current_gpu_name_textbox.Name = "current_gpu_name_textbox";
            current_gpu_name_textbox.ReadOnly = true;
            current_gpu_name_textbox.Size = new Size(195, 21);
            current_gpu_name_textbox.TabIndex = 7;
            // 
            // original_gpu_name_textbox
            // 
            original_gpu_name_textbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            original_gpu_name_textbox.BackColor = Color.FromArgb(34, 40, 49);
            original_gpu_name_textbox.ForeColor = SystemColors.Control;
            original_gpu_name_textbox.Location = new Point(207, 308);
            original_gpu_name_textbox.Name = "original_gpu_name_textbox";
            original_gpu_name_textbox.ReadOnly = true;
            original_gpu_name_textbox.Size = new Size(195, 21);
            original_gpu_name_textbox.TabIndex = 6;
            // 
            // new_gpu_name_textbox
            // 
            new_gpu_name_textbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            new_gpu_name_textbox.BackColor = Color.FromArgb(34, 40, 49);
            new_gpu_name_textbox.ForeColor = SystemColors.Control;
            new_gpu_name_textbox.Location = new Point(207, 389);
            new_gpu_name_textbox.Name = "new_gpu_name_textbox";
            new_gpu_name_textbox.Size = new Size(195, 21);
            new_gpu_name_textbox.TabIndex = 3;
            // 
            // new_gpu_name_label
            // 
            new_gpu_name_label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            new_gpu_name_label.BackColor = Color.Transparent;
            new_gpu_name_label.Font = new Font("Segoe UI", 14F);
            new_gpu_name_label.ForeColor = Color.FromArgb(234, 239, 239);
            new_gpu_name_label.Location = new Point(17, 385);
            new_gpu_name_label.Name = "new_gpu_name_label";
            new_gpu_name_label.Size = new Size(184, 28);
            new_gpu_name_label.TabIndex = 20;
            new_gpu_name_label.Text = "New GPU Name:";
            new_gpu_name_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // apply_button
            // 
            apply_button.BackColor = Color.FromArgb(49, 54, 63);
            apply_button.BackgroundImageLayout = ImageLayout.None;
            apply_button.Cursor = Cursors.Hand;
            apply_button.FlatStyle = FlatStyle.Flat;
            apply_button.Font = new Font("Segoe UI", 10F);
            apply_button.ForeColor = Color.FromArgb(223, 208, 184);
            apply_button.Location = new Point(17, 74);
            apply_button.Name = "apply_button";
            apply_button.Size = new Size(68, 32);
            apply_button.TabIndex = 21;
            apply_button.Text = "Apply";
            apply_button.UseVisualStyleBackColor = false;
            apply_button.Click += apply_button_Click;
            // 
            // restore_defaults_button
            // 
            restore_defaults_button.Anchor = AnchorStyles.Top;
            restore_defaults_button.BackColor = Color.FromArgb(49, 54, 63);
            restore_defaults_button.BackgroundImageLayout = ImageLayout.None;
            restore_defaults_button.Cursor = Cursors.Hand;
            restore_defaults_button.FlatStyle = FlatStyle.Flat;
            restore_defaults_button.Font = new Font("Segoe UI", 10F);
            restore_defaults_button.ForeColor = Color.FromArgb(223, 208, 184);
            restore_defaults_button.Location = new Point(165, 74);
            restore_defaults_button.Name = "restore_defaults_button";
            restore_defaults_button.Size = new Size(163, 32);
            restore_defaults_button.TabIndex = 22;
            restore_defaults_button.Text = "Restore Defaults";
            restore_defaults_button.UseVisualStyleBackColor = false;
            restore_defaults_button.Click += restore_defaults_button_Click;
            // 
            // exit_button
            // 
            exit_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exit_button.BackColor = Color.FromArgb(49, 54, 63);
            exit_button.BackgroundImageLayout = ImageLayout.None;
            exit_button.Cursor = Cursors.Hand;
            exit_button.FlatStyle = FlatStyle.Flat;
            exit_button.Font = new Font("Segoe UI", 10F);
            exit_button.ForeColor = Color.FromArgb(255, 105, 97);
            exit_button.Location = new Point(334, 74);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(68, 32);
            exit_button.TabIndex = 23;
            exit_button.Text = "Exit";
            exit_button.UseVisualStyleBackColor = false;
            exit_button.Click += exit_button_Click;
            // 
            // cpu_status_label
            // 
            cpu_status_label.Anchor = AnchorStyles.Bottom;
            cpu_status_label.Font = new Font("Segoe UI", 14F);
            cpu_status_label.ForeColor = SystemColors.Control;
            cpu_status_label.Location = new Point(6, 110);
            cpu_status_label.Name = "cpu_status_label";
            cpu_status_label.Size = new Size(402, 46);
            cpu_status_label.TabIndex = 24;
            cpu_status_label.Text = "Status:";
            cpu_status_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gpu_selection_comobox
            // 
            gpu_selection_comobox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            gpu_selection_comobox.BackColor = Color.FromArgb(34, 40, 49);
            gpu_selection_comobox.Cursor = Cursors.Hand;
            gpu_selection_comobox.Font = new Font("Arial Narrow", 10F);
            gpu_selection_comobox.ForeColor = Color.FromArgb(223, 208, 184);
            gpu_selection_comobox.FormattingEnabled = true;
            gpu_selection_comobox.ImeMode = ImeMode.NoControl;
            gpu_selection_comobox.Location = new Point(207, 270);
            gpu_selection_comobox.Name = "gpu_selection_comobox";
            gpu_selection_comobox.Size = new Size(195, 24);
            gpu_selection_comobox.TabIndex = 25;
            gpu_selection_comobox.SelectedIndexChanged += gpu_selection_comobox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.FromArgb(234, 239, 239);
            label3.Location = new Point(12, 270);
            label3.Name = "label3";
            label3.Size = new Size(184, 28);
            label3.TabIndex = 26;
            label3.Text = "Select Desired GPU:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gpu_status_label
            // 
            gpu_status_label.Anchor = AnchorStyles.Bottom;
            gpu_status_label.Font = new Font("Segoe UI", 14F);
            gpu_status_label.ForeColor = SystemColors.Control;
            gpu_status_label.Location = new Point(6, 413);
            gpu_status_label.Name = "gpu_status_label";
            gpu_status_label.Size = new Size(402, 46);
            gpu_status_label.TabIndex = 27;
            gpu_status_label.Text = "Status:";
            gpu_status_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(49, 54, 63);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = Color.FromArgb(223, 208, 184);
            button1.Location = new Point(91, 74);
            button1.Name = "button1";
            button1.Size = new Size(68, 32);
            button1.TabIndex = 28;
            button1.Text = "About";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(414, 461);
            Controls.Add(button1);
            Controls.Add(gpu_status_label);
            Controls.Add(label3);
            Controls.Add(gpu_selection_comobox);
            Controls.Add(cpu_status_label);
            Controls.Add(exit_button);
            Controls.Add(restore_defaults_button);
            Controls.Add(apply_button);
            Controls.Add(new_gpu_name_textbox);
            Controls.Add(new_gpu_name_label);
            Controls.Add(original_gpu_name_textbox);
            Controls.Add(current_gpu_name_textbox);
            Controls.Add(original_cpu_name_textbox);
            Controls.Add(current_cpu_name_textbox);
            Controls.Add(current_gpu_name_label);
            Controls.Add(original_gpu_name_label);
            Controls.Add(new_cpu_name_textbox);
            Controls.Add(new_cpu_name_label);
            Controls.Add(current_cpu_name_label);
            Controls.Add(original_cpu_name_label);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial Narrow", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Easy CPU And GPU Namer";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label original_cpu_name_label;
        private Label current_cpu_name_label;
        private Label new_cpu_name_label;
        private TextBox new_cpu_name_textbox;
        private Label original_gpu_name_label;
        private Label current_gpu_name_label;
        private TextBox current_cpu_name_textbox;
        private TextBox original_cpu_name_textbox;
        private TextBox current_gpu_name_textbox;
        private TextBox original_gpu_name_textbox;
        private TextBox new_gpu_name_textbox;
        private Label new_gpu_name_label;
        private Button restore_defaults_button;
        private Button exit_button;
        private Button apply_button;
        private Label cpu_status_label;
        private ComboBox gpu_selection_comobox;
        private Label label3;
        private Label gpu_status_label;
        private Button button1;
    }
}
