namespace ToDo_Application.View
{
    partial class InAppView
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
            this.lblToDoApp = new System.Windows.Forms.Label();
            this.ToDoDgv = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnShare = new System.Windows.Forms.Button();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toDoAppDbDataSet = new ToDo_Application.ToDoAppDbDataSet();
            this.taskTableTableAdapter = new ToDo_Application.ToDoAppDbDataSetTableAdapters.TaskTableTableAdapter();
            this.txtTsk = new System.Windows.Forms.TextBox();
            this.dtpTsk = new System.Windows.Forms.DateTimePicker();
            this.lblTask = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ToDoDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoAppDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblToDoApp
            // 
            this.lblToDoApp.BackColor = System.Drawing.Color.Transparent;
            this.lblToDoApp.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDoApp.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblToDoApp.Location = new System.Drawing.Point(323, 9);
            this.lblToDoApp.Name = "lblToDoApp";
            this.lblToDoApp.Size = new System.Drawing.Size(350, 80);
            this.lblToDoApp.TabIndex = 0;
            this.lblToDoApp.Text = "ToDo App";
            this.lblToDoApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToDoDgv
            // 
            this.ToDoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToDoDgv.Location = new System.Drawing.Point(12, 103);
            this.ToDoDgv.Name = "ToDoDgv";
            this.ToDoDgv.RowHeadersWidth = 51;
            this.ToDoDgv.RowTemplate.Height = 24;
            this.ToDoDgv.Size = new System.Drawing.Size(582, 330);
            this.ToDoDgv.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Location = new System.Drawing.Point(32, 527);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 37);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCreate.Location = new System.Drawing.Point(792, 471);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(144, 74);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.Location = new System.Drawing.Point(604, 471);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(144, 75);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "UPDATE";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDel.Location = new System.Drawing.Point(411, 471);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(144, 74);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnShare
            // 
            this.btnShare.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnShare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShare.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShare.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShare.Location = new System.Drawing.Point(230, 471);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(144, 74);
            this.btnShare.TabIndex = 12;
            this.btnShare.Text = "Share";
            this.btnShare.UseVisualStyleBackColor = false;
            // 
            // dgvTask
            // 
            this.dgvTask.AutoGenerateColumns = false;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tasksDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgvTask.DataSource = this.taskTableBindingSource;
            this.dgvTask.Location = new System.Drawing.Point(12, 103);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.RowHeadersWidth = 51;
            this.dgvTask.RowTemplate.Height = 24;
            this.dgvTask.Size = new System.Drawing.Size(582, 330);
            this.dgvTask.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // tasksDataGridViewTextBoxColumn
            // 
            this.tasksDataGridViewTextBoxColumn.DataPropertyName = "Tasks";
            this.tasksDataGridViewTextBoxColumn.HeaderText = "Tasks";
            this.tasksDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tasksDataGridViewTextBoxColumn.Name = "tasksDataGridViewTextBoxColumn";
            this.tasksDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // taskTableBindingSource
            // 
            this.taskTableBindingSource.DataMember = "TaskTable";
            this.taskTableBindingSource.DataSource = this.toDoAppDbDataSet;
            // 
            // toDoAppDbDataSet
            // 
            this.toDoAppDbDataSet.DataSetName = "ToDoAppDbDataSet";
            this.toDoAppDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskTableTableAdapter
            // 
            this.taskTableTableAdapter.ClearBeforeFill = true;
            // 
            // txtTsk
            // 
            this.txtTsk.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTsk.Location = new System.Drawing.Point(721, 103);
            this.txtTsk.Multiline = true;
            this.txtTsk.Name = "txtTsk";
            this.txtTsk.Size = new System.Drawing.Size(242, 101);
            this.txtTsk.TabIndex = 14;
            this.txtTsk.TextChanged += new System.EventHandler(this.txtTsk_TextChanged);
            // 
            // dtpTsk
            // 
            this.dtpTsk.Location = new System.Drawing.Point(721, 236);
            this.dtpTsk.Name = "dtpTsk";
            this.dtpTsk.Size = new System.Drawing.Size(242, 22);
            this.dtpTsk.TabIndex = 15;
            // 
            // lblTask
            // 
            this.lblTask.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTask.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTask.Location = new System.Drawing.Point(600, 103);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(100, 51);
            this.lblTask.TabIndex = 16;
            this.lblTask.Text = "Task";
            this.lblTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDate.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDate.Location = new System.Drawing.Point(600, 221);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(96, 51);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InAppView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ToDo_Application.Properties.Resources.InAppBackround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 587);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.dtpTsk);
            this.Controls.Add(this.txtTsk);
            this.Controls.Add(this.dgvTask);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ToDoDgv);
            this.Controls.Add(this.lblToDoApp);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InAppView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InAppView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToDoDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoAppDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToDoApp;
        private System.Windows.Forms.DataGridView ToDoDgv;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.DataGridView dgvTask;
        private ToDoAppDbDataSet toDoAppDbDataSet;
        private System.Windows.Forms.BindingSource taskTableBindingSource;
        private ToDoAppDbDataSetTableAdapters.TaskTableTableAdapter taskTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtTsk;
        private System.Windows.Forms.DateTimePicker dtpTsk;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblDate;
    }
}