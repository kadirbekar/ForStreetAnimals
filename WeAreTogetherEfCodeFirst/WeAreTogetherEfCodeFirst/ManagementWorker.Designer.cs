namespace WeAreTogetherEfCodeFirst
{
    partial class ManagementWorker
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
            this.btnTakeMission = new System.Windows.Forms.Button();
            this.dtpDateOfFood = new System.Windows.Forms.DateTimePicker();
            this.lblPickSomething = new System.Windows.Forms.Label();
            this.cbxPickAList = new System.Windows.Forms.ComboBox();
            this.dgwManagementWorker = new System.Windows.Forms.DataGridView();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxManagementId = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbxManagementName = new System.Windows.Forms.TextBox();
            this.lblManagementName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwManagementWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTakeMission
            // 
            this.btnTakeMission.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTakeMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTakeMission.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTakeMission.Location = new System.Drawing.Point(695, 335);
            this.btnTakeMission.Name = "btnTakeMission";
            this.btnTakeMission.Size = new System.Drawing.Size(269, 49);
            this.btnTakeMission.TabIndex = 49;
            this.btnTakeMission.Text = "Enter a register";
            this.btnTakeMission.UseVisualStyleBackColor = false;
            this.btnTakeMission.Click += new System.EventHandler(this.btnTakeMission_Click);
            // 
            // dtpDateOfFood
            // 
            this.dtpDateOfFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDateOfFood.Location = new System.Drawing.Point(695, 292);
            this.dtpDateOfFood.Name = "dtpDateOfFood";
            this.dtpDateOfFood.Size = new System.Drawing.Size(269, 26);
            this.dtpDateOfFood.TabIndex = 44;
            this.dtpDateOfFood.ValueChanged += new System.EventHandler(this.dtpDateOfFood_ValueChanged);
            // 
            // lblPickSomething
            // 
            this.lblPickSomething.AutoSize = true;
            this.lblPickSomething.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPickSomething.Location = new System.Drawing.Point(40, 243);
            this.lblPickSomething.Name = "lblPickSomething";
            this.lblPickSomething.Size = new System.Drawing.Size(182, 20);
            this.lblPickSomething.TabIndex = 42;
            this.lblPickSomething.Text = "Pick Something to list";
            // 
            // cbxPickAList
            // 
            this.cbxPickAList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxPickAList.FormattingEnabled = true;
            this.cbxPickAList.Items.AddRange(new object[] {
            "See who works as a management and user",
            "See is there any food entry",
            "See which shelter and animal you can access"});
            this.cbxPickAList.Location = new System.Drawing.Point(44, 276);
            this.cbxPickAList.Name = "cbxPickAList";
            this.cbxPickAList.Size = new System.Drawing.Size(400, 28);
            this.cbxPickAList.TabIndex = 40;
            this.cbxPickAList.SelectedIndexChanged += new System.EventHandler(this.cbxPickAList_SelectedIndexChanged);
            // 
            // dgwManagementWorker
            // 
            this.dgwManagementWorker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwManagementWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwManagementWorker.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwManagementWorker.Location = new System.Drawing.Point(0, 0);
            this.dgwManagementWorker.Name = "dgwManagementWorker";
            this.dgwManagementWorker.Size = new System.Drawing.Size(984, 190);
            this.dgwManagementWorker.TabIndex = 50;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsername.ForeColor = System.Drawing.Color.Red;
            this.lblUsername.Location = new System.Drawing.Point(561, 199);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(15, 20);
            this.lblUsername.TabIndex = 55;
            this.lblUsername.Text = "-";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(561, 201);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(0, 20);
            this.lblPassword.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(560, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(560, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Date of food";
            // 
            // tbxManagementId
            // 
            this.tbxManagementId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxManagementId.Location = new System.Drawing.Point(695, 247);
            this.tbxManagementId.Name = "tbxManagementId";
            this.tbxManagementId.Size = new System.Drawing.Size(82, 26);
            this.tbxManagementId.TabIndex = 59;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnUpdate.Location = new System.Drawing.Point(695, 391);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(269, 49);
            this.btnUpdate.TabIndex = 60;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDelete.Location = new System.Drawing.Point(695, 446);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(269, 49);
            this.btnDelete.TabIndex = 61;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbxManagementName
            // 
            this.tbxManagementName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxManagementName.Location = new System.Drawing.Point(852, 247);
            this.tbxManagementName.Name = "tbxManagementName";
            this.tbxManagementName.Size = new System.Drawing.Size(112, 26);
            this.tbxManagementName.TabIndex = 62;
            // 
            // lblManagementName
            // 
            this.lblManagementName.AutoSize = true;
            this.lblManagementName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblManagementName.Location = new System.Drawing.Point(785, 250);
            this.lblManagementName.Name = "lblManagementName";
            this.lblManagementName.Size = new System.Drawing.Size(55, 20);
            this.lblManagementName.TabIndex = 63;
            this.lblManagementName.Text = "Name";
            // 
            // ManagementWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lblManagementName);
            this.Controls.Add(this.tbxManagementName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbxManagementId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.dgwManagementWorker);
            this.Controls.Add(this.btnTakeMission);
            this.Controls.Add(this.dtpDateOfFood);
            this.Controls.Add(this.lblPickSomething);
            this.Controls.Add(this.cbxPickAList);
            this.Name = "ManagementWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Worker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagementWorker_FormClosing);
            this.Load += new System.EventHandler(this.ManagementWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwManagementWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTakeMission;
        private System.Windows.Forms.DateTimePicker dtpDateOfFood;
        private System.Windows.Forms.Label lblPickSomething;
        private System.Windows.Forms.ComboBox cbxPickAList;
        private System.Windows.Forms.DataGridView dgwManagementWorker;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxManagementId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbxManagementName;
        private System.Windows.Forms.Label lblManagementName;
    }
}