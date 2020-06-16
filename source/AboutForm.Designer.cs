namespace Text.NET
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.label_version = new System.Windows.Forms.Label();
            this.button_pastelsvg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_version
            // 
            this.label_version.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_version.Location = new System.Drawing.Point(12, 9);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(385, 153);
            this.label_version.TabIndex = 0;
            this.label_version.Text = resources.GetString("label_version.Text");
            this.label_version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_pastelsvg
            // 
            this.button_pastelsvg.Image = global::Text.NET.Properties.Resources.world_link;
            this.button_pastelsvg.Location = new System.Drawing.Point(31, 126);
            this.button_pastelsvg.Name = "button_pastelsvg";
            this.button_pastelsvg.Size = new System.Drawing.Size(24, 24);
            this.button_pastelsvg.TabIndex = 1;
            this.button_pastelsvg.UseVisualStyleBackColor = true;
            this.button_pastelsvg.Click += new System.EventHandler(this.Go_Url_SVG);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 171);
            this.Controls.Add(this.button_pastelsvg);
            this.Controls.Add(this.label_version);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About | Notepad.NET";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Button button_pastelsvg;
    }
}