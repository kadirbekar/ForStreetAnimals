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
            this.cbxFalse = new System.Windows.Forms.CheckBox();
            this.cbxTrue = new System.Windows.Forms.CheckBox();
            this.dtpDeliveryTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDateOfFood = new System.Windows.Forms.DateTimePicker();
            this.lblPickSomething = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.cbxPickAList = new System.Windows.Forms.ComboBox();
            this.dgwManagementWorker = new System.Windows.Forms.DataGridView();
            this.cbxManagementId = new System.Windows.Forms.ComboBox();
            this.cbxManagementName = new System.Windows.Forms.ComboBox();
            this.cbxResponsibleName = new System.Windows.Forms.ComboBox();
            this.cbxResponsibleId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwManagementWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTakeMission
            // 
            this.btnTakeMission.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTakeMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTakeMission.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTakeMission.Location = new System.Drawing.Point(452, 369);
            this.btnTakeMission.Name = "btnTakeMission";
            this.btnTakeMission.Size = new System.Drawing.Size(170, 54);
            this.btnTakeMission.TabIndex = 49;
            this.btnTakeMission.Text = "Take this mission";
            this.btnTakeMission.UseVisualStyleBackColor = false;
            // 
            // cbxFalse
            // 
            this.cbxFalse.AutoSize = true;
            this.cbxFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxFalse.Location = new System.Drawing.Point(521, 307);
            this.cbxFalse.Name = "cbxFalse";
            this.cbxFalse.Size = new System.Drawing.Size(72, 24);
            this.cbxFalse.TabIndex = 48;
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
            this.cbxTrue.TabIndex = 47;
            this.cbxTrue.Text = "Yes";
            this.cbxTrue.UseVisualStyleBackColor = true;
            // 
            // dtpDeliveryTime
            // 
            this.dtpDeliveryTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDeliveryTime.Location = new System.Drawing.Point(454, 273);
            this.dtpDeliveryTime.Name = "dtpDeliveryTime";
            this.dtpDeliveryTime.Size = new System.Drawing.Size(283, 26);
            this.dtpDeliveryTime.TabIndex = 45;
            // 
            // dtpDateOfFood
            // 
            this.dtpDateOfFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDateOfFood.Location = new System.Drawing.Point(452, 237);
            this.dtpDateOfFood.Name = "dtpDateOfFood";
            this.dtpDateOfFood.Size = new System.Drawing.Size(283, 26);
            this.dtpDateOfFood.TabIndex = 44;
            // 
            // lblPickSomething
            // 
            this.lblPickSomething.AutoSize = true;
            this.lblPickSomething.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPickSomething.Location = new System.Drawing.Point(37, 170);
            this.lblPickSomething.Name = "lblPickSomething";
            this.lblPickSomething.Size = new System.Drawing.Size(182, 20);
            this.lblPickSomething.TabIndex = 42;
            this.lblPickSomething.Text = "Pick Something to list";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnApply.Location = new System.Drawing.Point(41, 308);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(170, 54);
            this.btnApply.TabIndex = 41;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            // 
            // cbxPickAList
            // 
            this.cbxPickAList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxPickAList.FormattingEnabled = true;
            this.cbxPickAList.Items.AddRange(new object[] {
            "See who works at the same area with you",
            "See is there any food entry",
            "See which shelter and animal you can access"});
            this.cbxPickAList.Location = new System.Drawing.Point(41, 203);
            this.cbxPickAList.Name = "cbxPickAList";
            this.cbxPickAList.Size = new System.Drawing.Size(379, 28);
            this.cbxPickAList.TabIndex = 40;
            // 
            // dgwManagementWorker
            // 
            this.dgwManagementWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwManagementWorker.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwManagementWorker.Location = new System.Drawing.Point(0, 0);
            this.dgwManagementWorker.Name = "dgwManagementWorker";
            this.dgwManagementWorker.Size = new System.Drawing.Size(800, 150);
            this.dgwManagementWorker.TabIndex = 50;
            // 
            // cbxManagementId
            // 
            this.cbxManagementId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxManagementId.FormattingEnabled = true;
            this.cbxManagementId.Location = new System.Drawing.Point(452, 203);
            this.cbxManagementId.Name = "cbxManagementId";
            this.cbxManagementId.Size = new System.Drawing.Size(46, 28);
            this.cbxManagementId.TabIndex = 51;
            // 
            // cbxManagementName
            // 
            this.cbxManagementName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxManagementName.FormattingEnabled = true;
            this.cbxManagementName.Location = new System.Drawing.Point(504, 203);
            this.cbxManagementName.Name = "cbxManagementName";
            this.cbxManagementName.Size = new System.Drawing.Size(231, 28);
            this.cbxManagementName.TabIndex = 52;
            // 
            // cbxResponsibleName
            // 
            this.cbxResponsibleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxResponsibleName.FormattingEnabled = true;
            this.cbxResponsibleName.Location = new System.Drawing.Point(506, 337);
            this.cbxResponsibleName.Name = "cbxResponsibleName";
            this.cbxResponsibleName.Size = new System.Drawing.Size(231, 28);
            this.cbxResponsibleName.TabIndex = 54;
            // 
            // cbxResponsibleId
            // 
            this.cbxResponsibleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxResponsibleId.FormattingEnabled = true;
            this.cbxResponsibleId.Location = new System.Drawing.Point(454, 337);
            this.cbxResponsibleId.Name = "cbxResponsibleId";
            this.cbxResponsibleId.Size = new System.Drawing.Size(46, 28);
            this.cbxResponsibleId.TabIndex = 53;
            // 
            // ManagementWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.cbxResponsibleName);
            this.Controls.Add(this.cbxResponsibleId);
            this.Controls.Add(this.cbxManagementName);
            this.Controls.Add(this.cbxManagementId);
            this.Controls.Add(this.dgwManagementWorker);
            this.Controls.Add(this.btnTakeMission);
            this.Controls.Add(this.cbxFalse);
            this.Controls.Add(this.cbxTrue);
            this.Controls.Add(this.dtpDeliveryTime);
            this.Controls.Add(this.dtpDateOfFood);
            this.Controls.Add(this.lblPickSomething);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.cbxPickAList);
            this.Name = "ManagementWorker";
            this.Text = "Management Worker";
            ((System.ComponentModel.ISupportInitialize)(this.dgwManagementWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTakeMission;
        private System.Windows.Forms.CheckBox cbxFalse;
        private System.Windows.Forms.CheckBox cbxTrue;
        private System.Windows.Forms.DateTimePicker dtpDeliveryTime;
        private System.Windows.Forms.DateTimePicker dtpDateOfFood;
        private System.Windows.Forms.Label lblPickSomething;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cbxPickAList;
        private System.Windows.Forms.DataGridView dgwManagementWorker;
        private System.Windows.Forms.ComboBox cbxManagementId;
        private System.Windows.Forms.ComboBox cbxManagementName;
        private System.Windows.Forms.ComboBox cbxResponsibleName;
        private System.Windows.Forms.ComboBox cbxResponsibleId;
    }
}