namespace WeAreTogetherEfCodeFirst
{
    partial class VolunteerWorker
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
            this.dgwVoluteerWorker = new System.Windows.Forms.DataGridView();
            this.cbxPickWorkType = new System.Windows.Forms.ComboBox();
            this.btnList = new System.Windows.Forms.Button();
            this.lblPickSomething = new System.Windows.Forms.Label();
            this.tbxResponsibleUser = new System.Windows.Forms.TextBox();
            this.dtpDateOfFood = new System.Windows.Forms.DateTimePicker();
            this.dtpDeliveryTime = new System.Windows.Forms.DateTimePicker();
            this.txtManagementId = new System.Windows.Forms.TextBox();
            this.cbxFalse = new System.Windows.Forms.CheckBox();
            this.cbxTrue = new System.Windows.Forms.CheckBox();
            this.btnTakeMission = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVoluteerWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwVoluteerWorker
            // 
            this.dgwVoluteerWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVoluteerWorker.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwVoluteerWorker.Location = new System.Drawing.Point(0, 0);
            this.dgwVoluteerWorker.Name = "dgwVoluteerWorker";
            this.dgwVoluteerWorker.Size = new System.Drawing.Size(800, 156);
            this.dgwVoluteerWorker.TabIndex = 0;
            // 
            // cbxPickWorkType
            // 
            this.cbxPickWorkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxPickWorkType.FormattingEnabled = true;
            this.cbxPickWorkType.Items.AddRange(new object[] {
            "See who works at the same area with you",
            "See is there any food entry",
            "See which shelter and animal you can access"});
            this.cbxPickWorkType.Location = new System.Drawing.Point(16, 204);
            this.cbxPickWorkType.Name = "cbxPickWorkType";
            this.cbxPickWorkType.Size = new System.Drawing.Size(379, 28);
            this.cbxPickWorkType.TabIndex = 2;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnList.Location = new System.Drawing.Point(16, 309);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(170, 54);
            this.btnList.TabIndex = 9;
            this.btnList.Text = "Apply";
            this.btnList.UseVisualStyleBackColor = false;
            // 
            // lblPickSomething
            // 
            this.lblPickSomething.AutoSize = true;
            this.lblPickSomething.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPickSomething.Location = new System.Drawing.Point(12, 171);
            this.lblPickSomething.Name = "lblPickSomething";
            this.lblPickSomething.Size = new System.Drawing.Size(182, 20);
            this.lblPickSomething.TabIndex = 31;
            this.lblPickSomething.Text = "Pick Something to list";
            // 
            // tbxResponsibleUser
            // 
            this.tbxResponsibleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxResponsibleUser.Location = new System.Drawing.Point(452, 337);
            this.tbxResponsibleUser.Name = "tbxResponsibleUser";
            this.tbxResponsibleUser.Size = new System.Drawing.Size(283, 26);
            this.tbxResponsibleUser.TabIndex = 33;
            // 
            // dtpDateOfFood
            // 
            this.dtpDateOfFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDateOfFood.Location = new System.Drawing.Point(452, 237);
            this.dtpDateOfFood.Name = "dtpDateOfFood";
            this.dtpDateOfFood.Size = new System.Drawing.Size(283, 26);
            this.dtpDateOfFood.TabIndex = 34;
            // 
            // dtpDeliveryTime
            // 
            this.dtpDeliveryTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDeliveryTime.Location = new System.Drawing.Point(454, 273);
            this.dtpDeliveryTime.Name = "dtpDeliveryTime";
            this.dtpDeliveryTime.Size = new System.Drawing.Size(283, 26);
            this.dtpDeliveryTime.TabIndex = 35;
            // 
            // txtManagementId
            // 
            this.txtManagementId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtManagementId.Location = new System.Drawing.Point(452, 205);
            this.txtManagementId.Name = "txtManagementId";
            this.txtManagementId.Size = new System.Drawing.Size(283, 26);
            this.txtManagementId.TabIndex = 36;
            // 
            // cbxFalse
            // 
            this.cbxFalse.AutoSize = true;
            this.cbxFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxFalse.Location = new System.Drawing.Point(521, 307);
            this.cbxFalse.Name = "cbxFalse";
            this.cbxFalse.Size = new System.Drawing.Size(72, 24);
            this.cbxFalse.TabIndex = 38;
            this.cbxFalse.Text = "False";
            this.cbxFalse.UseVisualStyleBackColor = true;
            // 
            // cbxTrue
            // 
            this.cbxTrue.AutoSize = true;
            this.cbxTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxTrue.Location = new System.Drawing.Point(456, 307);
            this.cbxTrue.Name = "cbxTrue";
            this.cbxTrue.Size = new System.Drawing.Size(59, 24);
            this.cbxTrue.TabIndex = 37;
            this.cbxTrue.Text = "Yes";
            this.cbxTrue.UseVisualStyleBackColor = true;
            // 
            // btnTakeMission
            // 
            this.btnTakeMission.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTakeMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTakeMission.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTakeMission.Location = new System.Drawing.Point(452, 369);
            this.btnTakeMission.Name = "btnTakeMission";
            this.btnTakeMission.Size = new System.Drawing.Size(170, 54);
            this.btnTakeMission.TabIndex = 39;
            this.btnTakeMission.Text = "Take this mission";
            this.btnTakeMission.UseVisualStyleBackColor = false;
            // 
            // VolunteerWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.btnTakeMission);
            this.Controls.Add(this.cbxFalse);
            this.Controls.Add(this.cbxTrue);
            this.Controls.Add(this.txtManagementId);
            this.Controls.Add(this.dtpDeliveryTime);
            this.Controls.Add(this.dtpDateOfFood);
            this.Controls.Add(this.tbxResponsibleUser);
            this.Controls.Add(this.lblPickSomething);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.cbxPickWorkType);
            this.Controls.Add(this.dgwVoluteerWorker);
            this.Name = "VolunteerWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VolunteerWorker";
            ((System.ComponentModel.ISupportInitialize)(this.dgwVoluteerWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwVoluteerWorker;
        private System.Windows.Forms.ComboBox cbxPickWorkType;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label lblPickSomething;
        private System.Windows.Forms.TextBox tbxResponsibleUser;
        private System.Windows.Forms.DateTimePicker dtpDateOfFood;
        private System.Windows.Forms.DateTimePicker dtpDeliveryTime;
        private System.Windows.Forms.TextBox txtManagementId;
        private System.Windows.Forms.CheckBox cbxFalse;
        private System.Windows.Forms.CheckBox cbxTrue;
        private System.Windows.Forms.Button btnTakeMission;
    }
}