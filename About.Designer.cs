namespace CPU_GPU_Namer
{
    partial class About
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
            subheader_label = new Label();
            Header_label = new Label();
            apply_button = new Button();
            exit_button = new Button();
            description_label = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // subheader_label
            // 
            subheader_label.Anchor = AnchorStyles.Top;
            subheader_label.AutoSize = true;
            subheader_label.BackColor = Color.Transparent;
            subheader_label.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subheader_label.ForeColor = Color.FromArgb(223, 208, 184);
            subheader_label.Location = new Point(140, 43);
            subheader_label.Name = "subheader_label";
            subheader_label.Size = new Size(151, 16);
            subheader_label.TabIndex = 11;
            subheader_label.Text = "By Ahmad Morningstar";
            subheader_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Header_label
            // 
            Header_label.Anchor = AnchorStyles.Top;
            Header_label.BackColor = Color.Transparent;
            Header_label.Font = new Font("Arial", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Header_label.ForeColor = Color.FromArgb(223, 208, 184);
            Header_label.Location = new Point(14, 1);
            Header_label.Name = "Header_label";
            Header_label.Size = new Size(394, 38);
            Header_label.TabIndex = 10;
            Header_label.Text = "Easy CPU GPU Namer";
            Header_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // apply_button
            // 
            apply_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            apply_button.BackColor = Color.FromArgb(49, 54, 63);
            apply_button.BackgroundImageLayout = ImageLayout.None;
            apply_button.Cursor = Cursors.Hand;
            apply_button.FlatStyle = FlatStyle.Flat;
            apply_button.Font = new Font("Segoe UI", 10F);
            apply_button.ForeColor = Color.FromArgb(223, 208, 184);
            apply_button.Location = new Point(351, 330);
            apply_button.Name = "apply_button";
            apply_button.Size = new Size(68, 32);
            apply_button.TabIndex = 22;
            apply_button.Text = "Link";
            apply_button.UseVisualStyleBackColor = false;
            apply_button.Click += apply_button_Click;
            // 
            // exit_button
            // 
            exit_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            exit_button.BackColor = Color.FromArgb(49, 54, 63);
            exit_button.BackgroundImageLayout = ImageLayout.None;
            exit_button.Cursor = Cursors.Hand;
            exit_button.FlatStyle = FlatStyle.Flat;
            exit_button.Font = new Font("Segoe UI", 10F);
            exit_button.ForeColor = Color.FromArgb(255, 105, 97);
            exit_button.Location = new Point(12, 330);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(68, 32);
            exit_button.TabIndex = 24;
            exit_button.Text = "Exit";
            exit_button.UseVisualStyleBackColor = false;
            // 
            // description_label
            // 
            description_label.Anchor = AnchorStyles.Top;
            description_label.BackColor = Color.Transparent;
            description_label.Font = new Font("Segoe UI", 19F);
            description_label.ForeColor = Color.FromArgb(148, 137, 121);
            description_label.Location = new Point(14, 105);
            description_label.Name = "description_label";
            description_label.Size = new Size(405, 222);
            description_label.TabIndex = 25;
            description_label.Text = "This is a free, easy, and quick CPU and GPU namer; you can change the name to anything you want. If you found this program useful, consider supporting me by clicking on the link below";
            description_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(223, 208, 184);
            label1.Location = new Point(14, 59);
            label1.Name = "label1";
            label1.Size = new Size(405, 46);
            label1.TabIndex = 26;
            label1.Text = "Version 1.0.0 (BETA)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(431, 374);
            Controls.Add(label1);
            Controls.Add(description_label);
            Controls.Add(exit_button);
            Controls.Add(apply_button);
            Controls.Add(subheader_label);
            Controls.Add(Header_label);
            Name = "About";
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label subheader_label;
        private Label Header_label;
        private Button apply_button;
        private Button exit_button;
        private Label description_label;
        private Label label1;
    }
}