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
            this.lblPickSomething = new System.Windows.Forms.Label();
            this.dtpDeliveryTime = new System.Windows.Forms.DateTimePicker();
            this.tbxUserId = new System.Windows.Forms.TextBox();
            this.cbxFalse = new System.Windows.Forms.CheckBox();
            this.cbxTrue = new System.Windows.Forms.CheckBox();
            this.btnTakeMission = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblDeliveryTime = new System.Windows.Forms.Label();
            this.lblSupplyDelivery = new System.Windows.Forms.Label();
            this.btnLeave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVoluteerWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwVoluteerWorker
            // 
            this.dgwVoluteerWorker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwVoluteerWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVoluteerWorker.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwVoluteerWorker.Location = new System.Drawing.Point(0, 0);
            this.dgwVoluteerWorker.Name = "dgwVoluteerWorker";
            this.dgwVoluteerWorker.Size = new System.Drawing.Size(984, 190);
            this.dgwVoluteerWorker.TabIndex = 0;
            this.dgwVoluteerWorker.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwVoluteerWorker_CellClick);
            // 
            // cbxPickWorkType
            // 
            this.cbxPickWorkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxPickWorkType.FormattingEnabled = true;
            this.cbxPickWorkType.Items.AddRange(new object[] {
            "See who works at the same area with you",
            "See is there any food entry",
            "See which shelter and animal you can access"});
            this.cbxPickWorkType.Location = new System.Drawing.Point(39, 277);
            this.cbxPickWorkType.Name = "cbxPickWorkType";
            this.cbxPickWorkType.Size = new System.Drawing.Size(379, 28);
            this.cbxPickWorkType.TabIndex = 2;
            this.cbxPickWorkType.SelectedIndexChanged += new System.EventHandler(this.cbxPickWorkType_SelectedIndexChanged);
            // 
            // lblPickSomething
            // 
            this.lblPickSomething.AutoSize = true;
            this.lblPickSomething.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPickSomething.Location = new System.Drawing.Point(35, 244);
            this.lblPickSomething.Name = "lblPickSomething";
            this.lblPickSomething.Size = new System.Drawing.Size(182, 20);
            this.lblPickSomething.TabIndex = 31;
            this.lblPickSomething.Text = "Pick Something to list";
            // 
            // dtpDeliveryTime
            // 
            this.dtpDeliveryTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDeliveryTime.Location = new System.Drawing.Point(675, 288);
            this.dtpDeliveryTime.Name = "dtpDeliveryTime";
            this.dtpDeliveryTime.Size = new System.Drawing.Size(261, 26);
            this.dtpDeliveryTime.TabIndex = 35;
            // 
            // tbxUserId
            // 
            this.tbxUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUserId.Location = new System.Drawing.Point(786, 256);
            this.tbxUserId.Name = "tbxUserId";
            this.tbxUserId.Size = new System.Drawing.Size(150, 26);
            this.tbxUserId.TabIndex = 36;
            // 
            // cbxFalse
            // 
            this.cbxFalse.AutoSize = true;
            this.cbxFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxFalse.Location = new System.Drawing.Point(739, 333);
            this.cbxFalse.Name = "cbxFalse";
            this.cbxFalse.Size = new System.Drawing.Size(72, 24);
            this.cbxFalse.TabIndex = 38;
            this.cbxFalse.Text = "False";
            this.cbxFalse.UseVisualStyleBackColor = true;
            this.cbxFalse.CheckedChanged += new System.EventHandler(this.cbxFalse_CheckedChanged);
            // 
            // cbxTrue
            // 
            this.cbxTrue.AutoSize = true;
            this.cbxTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxTrue.Location = new System.Drawing.Point(674, 333);
            this.cbxTrue.Name = "cbxTrue";
            this.cbxTrue.Size = new System.Drawing.Size(59, 24);
            this.cbxTrue.TabIndex = 37;
            this.cbxTrue.Text = "Yes";
            this.cbxTrue.UseVisualStyleBackColor = true;
            this.cbxTrue.CheckedChanged += new System.EventHandler(this.cbxTrue_CheckedChanged);
            // 
            // btnTakeMission
            // 
            this.btnTakeMission.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTakeMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTakeMission.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTakeMission.Location = new System.Drawing.Point(674, 363);
            this.btnTakeMission.Name = "btnTakeMission";
            this.btnTakeMission.Size = new System.Drawing.Size(137, 49);
            this.btnTakeMission.TabIndex = 39;
            this.btnTakeMission.Text = "Take this mission";
            this.btnTakeMission.UseVisualStyleBackColor = false;
            this.btnTakeMission.Click += new System.EventHandler(this.btnTakeMission_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsername.ForeColor = System.Drawing.Color.Red;
            this.lblUsername.Location = new System.Drawing.Point(519, 203);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(15, 20);
            this.lblUsername.TabIndex = 40;
            this.lblUsername.Text = "-";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserId.Location = new System.Drawing.Point(519, 259);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(63, 20);
            this.lblUserId.TabIndex = 42;
            this.lblUserId.Text = "UserId";
            // 
            // lblDeliveryTime
            // 
            this.lblDeliveryTime.AutoSize = true;
            this.lblDeliveryTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeliveryTime.Location = new System.Drawing.Point(519, 293);
            this.lblDeliveryTime.Name = "lblDeliveryTime";
            this.lblDeliveryTime.Size = new System.Drawing.Size(115, 20);
            this.lblDeliveryTime.TabIndex = 43;
            this.lblDeliveryTime.Text = "Delivery Time";
            // 
            // lblSupplyDelivery
            // 
            this.lblSupplyDelivery.AutoSize = true;
            this.lblSupplyDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSupplyDelivery.Location = new System.Drawing.Point(519, 334);
            this.lblSupplyDelivery.Name = "lblSupplyDelivery";
            this.lblSupplyDelivery.Size = new System.Drawing.Size(131, 20);
            this.lblSupplyDelivery.TabIndex = 45;
            this.lblSupplyDelivery.Text = "Supply Delivery";
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLeave.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLeave.Location = new System.Drawing.Point(674, 418);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(137, 49);
            this.btnLeave.TabIndex = 46;
            this.btnLeave.Text = "Leave the register";
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // VolunteerWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.lblSupplyDelivery);
            this.Controls.Add(this.lblDeliveryTime);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnTakeMission);
            this.Controls.Add(this.cbxFalse);
            this.Controls.Add(this.cbxTrue);
            this.Controls.Add(this.tbxUserId);
            this.Controls.Add(this.dtpDeliveryTime);
            this.Controls.Add(this.lblPickSomething);
            this.Controls.Add(this.cbxPickWorkType);
            this.Controls.Add(this.dgwVoluteerWorker);
            this.Name = "VolunteerWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VolunteerWorker";
            this.Load += new System.EventHandler(this.VolunteerWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwVoluteerWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwVoluteerWorker;
        private System.Windows.Forms.ComboBox cbxPickWorkType;
        private System.Windows.Forms.Label lblPickSomething;
        private System.Windows.Forms.DateTimePicker dtpDeliveryTime;
        private System.Windows.Forms.TextBox tbxUserId;
        private System.Windows.Forms.CheckBox cbxFalse;
        private System.Windows.Forms.CheckBox cbxTrue;
        private System.Windows.Forms.Button btnTakeMission;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblDeliveryTime;
        private System.Windows.Forms.Label lblSupplyDelivery;
        private System.Windows.Forms.Button btnLeave;
    }
}