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
            this.components = new System.ComponentModel.Container();
            this.ProgBarLoad = new System.Windows.Forms.ProgressBar();
            this.TimerProgBar = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ProgBarLoad
            // 
            this.ProgBarLoad.BackColor = System.Drawing.Color.DarkOrchid;
            this.ProgBarLoad.ForeColor = System.Drawing.Color.White;
            this.ProgBarLoad.Location = new System.Drawing.Point(99, 372);
            this.ProgBarLoad.Name = "ProgBarLoad";
            this.ProgBarLoad.Size = new System.Drawing.Size(542, 14);
            this.ProgBarLoad.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgBarLoad.TabIndex = 0;
            // 
            // TimerProgBar
            // 
            this.TimerProgBar.Enabled = true;
            this.TimerProgBar.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ToDo_Application.Properties.Resources.Splash_screen1_jpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 417);
            this.Controls.Add(this.ProgBarLoad);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgBarLoad;
        private System.Windows.Forms.Timer TimerProgBar;
    }
}