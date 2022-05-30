namespace ToDo_Application.View
{
    partial class CreateTaskView
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
            this.txtTask = new System.Windows.Forms.TextBox();
            this.lblCrtTsk = new System.Windows.Forms.Label();
            this.lblTsk = new System.Windows.Forms.Label();
            this.dtpTask = new System.Windows.Forms.DateTimePicker();
            this.btnCrtTsk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(48, 176);
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(229, 34);
            this.txtTask.TabIndex = 0;
            // 
            // lblCrtTsk
            // 
            this.lblCrtTsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrtTsk.Location = new System.Drawing.Point(43, 28);
            this.lblCrtTsk.Name = "lblCrtTsk";
            this.lblCrtTsk.Size = new System.Drawing.Size(249, 91);
            this.lblCrtTsk.TabIndex = 1;
            this.lblCrtTsk.Text = "Create Task";
            this.lblCrtTsk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTsk
            // 
            this.lblTsk.AutoSize = true;
            this.lblTsk.Location = new System.Drawing.Point(71, 143);
            this.lblTsk.Name = "lblTsk";
            this.lblTsk.Size = new System.Drawing.Size(41, 16);
            this.lblTsk.TabIndex = 2;
            this.lblTsk.Text = "Task ";
            // 
            // dtpTask
            // 
            this.dtpTask.Location = new System.Drawing.Point(48, 232);
            this.dtpTask.Name = "dtpTask";
            this.dtpTask.Size = new System.Drawing.Size(229, 22);
            this.dtpTask.TabIndex = 3;
            // 
            // btnCrtTsk
            // 
            this.btnCrtTsk.Location = new System.Drawing.Point(125, 319);
            this.btnCrtTsk.Name = "btnCrtTsk";
            this.btnCrtTsk.Size = new System.Drawing.Size(75, 23);
            this.btnCrtTsk.TabIndex = 4;
            this.btnCrtTsk.Text = "Create";
            this.btnCrtTsk.UseVisualStyleBackColor = true;
            // 
            // CreateTaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 384);
            this.Controls.Add(this.btnCrtTsk);
            this.Controls.Add(this.dtpTask);
            this.Controls.Add(this.lblTsk);
            this.Controls.Add(this.lblCrtTsk);
            this.Controls.Add(this.txtTask);
            this.Name = "CreateTaskView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCrtTsk;
        private System.Windows.Forms.Label lblTsk;
        private System.Windows.Forms.DateTimePicker dtpTask;
        private System.Windows.Forms.Button btnCrtTsk;
        public System.Windows.Forms.TextBox txtTask;
    }
}