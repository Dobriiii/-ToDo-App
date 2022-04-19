namespace ToDo_Application.View
{
    partial class MainView
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
            this.MainViewHeadText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainViewHeadText
            // 
            this.MainViewHeadText.BackColor = System.Drawing.SystemColors.Control;
            this.MainViewHeadText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainViewHeadText.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainViewHeadText.ForeColor = System.Drawing.Color.Black;
            this.MainViewHeadText.Location = new System.Drawing.Point(245, 50);
            this.MainViewHeadText.Multiline = true;
            this.MainViewHeadText.Name = "MainViewHeadText";
            this.MainViewHeadText.Size = new System.Drawing.Size(260, 122);
            this.MainViewHeadText.TabIndex = 0;
            this.MainViewHeadText.Text = "WELCOME TO TODO APP";
            this.MainViewHeadText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MainViewHeadText.TextChanged += new System.EventHandler(this.MainViewHeadText_TextChanged);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ToDo_Application.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainViewHeadText);
            this.Name = "MainView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainViewHeadText;
    }
}