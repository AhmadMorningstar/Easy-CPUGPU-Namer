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
            description_label = new Label();
            label1 = new Label();
            github_button = new Button();
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
            apply_button.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            apply_button.ForeColor = Color.FromArgb(223, 208, 184);
            apply_button.Location = new Point(14, 320);
            apply_button.Name = "apply_button";
            apply_button.Size = new Size(299, 42);
            apply_button.TabIndex = 22;
            apply_button.Text = "Link button";
            apply_button.UseVisualStyleBackColor = false;
            apply_button.Click += apply_button_Click;
            // 
            // description_label
            // 
            description_label.Anchor = AnchorStyles.Top;
            description_label.BackColor = Color.Transparent;
            description_label.Font = new Font("Segoe UI", 19F);
            description_label.ForeColor = Color.FromArgb(148, 137, 121);
            description_label.Location = new Point(14, 95);
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
            label1.Size = new Size(405, 36);
            label1.TabIndex = 26;
            label1.Text = "Version 1.0.0 (BETA)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // github_button
            // 
            github_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            github_button.BackColor = Color.FromArgb(49, 54, 63);
            github_button.BackgroundImageLayout = ImageLayout.None;
            github_button.Cursor = Cursors.Hand;
            github_button.FlatStyle = FlatStyle.Flat;
            github_button.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            github_button.ForeColor = Color.FromArgb(223, 208, 184);
            github_button.Location = new Point(319, 320);
            github_button.Name = "github_button";
            github_button.Size = new Size(100, 42);
            github_button.TabIndex = 27;
            github_button.Text = "Github";
            github_button.UseVisualStyleBackColor = false;
            github_button.Click += github_button_Click;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(431, 374);
            Controls.Add(github_button);
            Controls.Add(label1);
            Controls.Add(description_label);
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
        private Label description_label;
        private Label label1;
        private Button github_button;
    }
}