namespace WeAreTogetherEfCodeFirst
{
    partial class AdminShelter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminShelter));
            this.dgwAdminShelter = new System.Windows.Forms.DataGridView();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.cbxDistrict = new System.Windows.Forms.ComboBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.gbxAdminManagement = new System.Windows.Forms.GroupBox();
            this.btnDeleteShelter = new System.Windows.Forms.Button();
            this.btnAddShelter = new System.Windows.Forms.Button();
            this.btnUpdateShelter = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.adminAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminShelterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminOtherThingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminAddPart1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbxShelter = new System.Windows.Forms.PictureBox();
            this.lblFindSomeone = new System.Windows.Forms.Label();
            this.txtFindShelter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdminShelter)).BeginInit();
            this.gbxAdminManagement.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShelter)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwAdminShelter
            // 
            this.dgwAdminShelter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwAdminShelter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAdminShelter.Location = new System.Drawing.Point(0, 28);
            this.dgwAdminShelter.Name = "dgwAdminShelter";
            this.dgwAdminShelter.Size = new System.Drawing.Size(884, 220);
            this.dgwAdminShelter.TabIndex = 0;
            this.dgwAdminShelter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAdminShelter_CellClick);
            // 
            // cbxCity
            // 
            this.cbxCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(156, 342);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(295, 28);
            this.cbxCity.TabIndex = 2;
            this.cbxCity.SelectedIndexChanged += new System.EventHandler(this.cbxCity_SelectedIndexChanged);
            // 
            // cbxDistrict
            // 
            this.cbxDistrict.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxDistrict.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxDistrict.FormattingEnabled = true;
            this.cbxDistrict.Location = new System.Drawing.Point(156, 374);
            this.cbxDistrict.Name = "cbxDistrict";
            this.cbxDistrict.Size = new System.Drawing.Size(295, 28);
            this.cbxDistrict.TabIndex = 3;
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxName.Location = new System.Drawing.Point(156, 408);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(295, 26);
            this.tbxName.TabIndex = 5;
            this.tbxName.Validating += new System.ComponentModel.CancelEventHandler(this.tbxName_Validating);
            // 
            // tbxAddress
            // 
            this.tbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAddress.Location = new System.Drawing.Point(156, 442);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(295, 78);
            this.tbxAddress.TabIndex = 6;
            this.tbxAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbxAddress_Validating);
            // 
            // tbxPhone
            // 
            this.tbxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPhone.Location = new System.Drawing.Point(156, 527);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(295, 26);
            this.tbxPhone.TabIndex = 7;
            this.tbxPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPhone_Validating);
            // 
            // gbxAdminManagement
            // 
            this.gbxAdminManagement.Controls.Add(this.btnDeleteShelter);
            this.gbxAdminManagement.Controls.Add(this.btnAddShelter);
            this.gbxAdminManagement.Controls.Add(this.btnUpdateShelter);
            this.gbxAdminManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAdminManagement.Location = new System.Drawing.Point(587, 342);
            this.gbxAdminManagement.Name = "gbxAdminManagement";
            this.gbxAdminManagement.Size = new System.Drawing.Size(219, 223);
            this.gbxAdminManagement.TabIndex = 20;
            this.gbxAdminManagement.TabStop = false;
            this.gbxAdminManagement.Text = "CRUD";
            // 
            // btnDeleteShelter
            // 
            this.btnDeleteShelter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteShelter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteShelter.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteShelter.Image")));
            this.btnDeleteShelter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeleteShelter.Location = new System.Drawing.Point(30, 154);
            this.btnDeleteShelter.Name = "btnDeleteShelter";
            this.btnDeleteShelter.Size = new System.Drawing.Size(170, 54);
            this.btnDeleteShelter.TabIndex = 10;
            this.btnDeleteShelter.Text = "Delete";
            this.btnDeleteShelter.UseVisualStyleBackColor = false;
            this.btnDeleteShelter.Click += new System.EventHandler(this.btnDeleteShelter_Click);
            // 
            // btnAddShelter
            // 
            this.btnAddShelter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddShelter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddShelter.Image = ((System.Drawing.Image)(resources.GetObject("btnAddShelter.Image")));
            this.btnAddShelter.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAddShelter.Location = new System.Drawing.Point(30, 18);
            this.btnAddShelter.Name = "btnAddShelter";
            this.btnAddShelter.Size = new System.Drawing.Size(170, 54);
            this.btnAddShelter.TabIndex = 8;
            this.btnAddShelter.Text = "Add";
            this.btnAddShelter.UseVisualStyleBackColor = false;
            this.btnAddShelter.Click += new System.EventHandler(this.btnAddShelter_Click);
            // 
            // btnUpdateShelter
            // 
            this.btnUpdateShelter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateShelter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateShelter.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateShelter.Image")));
            this.btnUpdateShelter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdateShelter.Location = new System.Drawing.Point(30, 86);
            this.btnUpdateShelter.Name = "btnUpdateShelter";
            this.btnUpdateShelter.Size = new System.Drawing.Size(170, 54);
            this.btnUpdateShelter.TabIndex = 9;
            this.btnUpdateShelter.Text = "Update";
            this.btnUpdateShelter.UseVisualStyleBackColor = false;
            this.btnUpdateShelter.Click += new System.EventHandler(this.btnUpdateShelter_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCity.Location = new System.Drawing.Point(35, 342);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 20);
            this.lblCity.TabIndex = 21;
            this.lblCity.Text = "City";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDistrict.Location = new System.Drawing.Point(35, 377);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(66, 20);
            this.lblDistrict.TabIndex = 22;
            this.lblDistrict.Text = "District";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(35, 411);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.Location = new System.Drawing.Point(35, 445);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 20);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.Location = new System.Drawing.Point(35, 530);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(60, 20);
            this.lblPhone.TabIndex = 25;
            this.lblPhone.Text = "Phone";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(36, 280);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(308, 20);
            this.lblWarning.TabIndex = 26;
            this.lblWarning.Text = "Pick one entity to add,update, delete ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 25);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminAnimalToolStripMenuItem,
            this.adminShelterToolStripMenuItem,
            this.adminManagementToolStripMenuItem,
            this.adminUserToolStripMenuItem,
            this.adminOtherThingsToolStripMenuItem,
            this.adminAddPart1ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(99, 22);
            this.toolStripDropDownButton1.Text = "Admin General";
            // 
            // adminAnimalToolStripMenuItem
            // 
            this.adminAnimalToolStripMenuItem.Name = "adminAnimalToolStripMenuItem";
            this.adminAnimalToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.adminAnimalToolStripMenuItem.Text = "Admin Animal";
            this.adminAnimalToolStripMenuItem.Click += new System.EventHandler(this.adminAnimalToolStripMenuItem_Click);
            // 
            // adminShelterToolStripMenuItem
            // 
            this.adminShelterToolStripMenuItem.Name = "adminShelterToolStripMenuItem";
            this.adminShelterToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.adminShelterToolStripMenuItem.Text = "Admin Shelter";
            this.adminShelterToolStripMenuItem.Click += new System.EventHandler(this.adminShelterToolStripMenuItem_Click);
            // 
            // adminManagementToolStripMenuItem
            // 
            this.adminManagementToolStripMenuItem.Name = "adminManagementToolStripMenuItem";
            this.adminManagementToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.adminManagementToolStripMenuItem.Text = "Admin Management";
            this.adminManagementToolStripMenuItem.Click += new System.EventHandler(this.adminManagementToolStripMenuItem_Click);
            // 
            // adminUserToolStripMenuItem
            // 
            this.adminUserToolStripMenuItem.Name = "adminUserToolStripMenuItem";
            this.adminUserToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.adminUserToolStripMenuItem.Text = "Admin User";
            this.adminUserToolStripMenuItem.Click += new System.EventHandler(this.adminUserToolStripMenuItem_Click);
            // 
            // adminOtherThingsToolStripMenuItem
            // 
            this.adminOtherThingsToolStripMenuItem.Name = "adminOtherThingsToolStripMenuItem";
            this.adminOtherThingsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.adminOtherThingsToolStripMenuItem.Text = "Admin Other Things";
            this.adminOtherThingsToolStripMenuItem.Click += new System.EventHandler(this.adminOtherThingsToolStripMenuItem_Click);
            // 
            // adminAddPart1ToolStripMenuItem
            // 
            this.adminAddPart1ToolStripMenuItem.Name = "adminAddPart1ToolStripMenuItem";
            this.adminAddPart1ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.adminAddPart1ToolStripMenuItem.Text = "Admin Add Part 1";
            this.adminAddPart1ToolStripMenuItem.Click += new System.EventHandler(this.adminAddPart1ToolStripMenuItem_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 1000;
            this.errorProvider.ContainerControl = this;
            // 
            // pbxShelter
            // 
            this.pbxShelter.Image = ((System.Drawing.Image)(resources.GetObject("pbxShelter.Image")));
            this.pbxShelter.Location = new System.Drawing.Point(400, 277);
            this.pbxShelter.Name = "pbxShelter";
            this.pbxShelter.Size = new System.Drawing.Size(30, 29);
            this.pbxShelter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxShelter.TabIndex = 78;
            this.pbxShelter.TabStop = false;
            // 
            // lblFindSomeone
            // 
            this.lblFindSomeone.AutoSize = true;
            this.lblFindSomeone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFindSomeone.Location = new System.Drawing.Point(436, 283);
            this.lblFindSomeone.Name = "lblFindSomeone";
            this.lblFindSomeone.Size = new System.Drawing.Size(159, 20);
            this.lblFindSomeone.TabIndex = 77;
            this.lblFindSomeone.Text = "Search any shelter";
            // 
            // txtFindShelter
            // 
            this.txtFindShelter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFindShelter.Location = new System.Drawing.Point(601, 280);
            this.txtFindShelter.Name = "txtFindShelter";
            this.txtFindShelter.Size = new System.Drawing.Size(204, 26);
            this.txtFindShelter.TabIndex = 76;
            this.txtFindShelter.TextChanged += new System.EventHandler(this.txtFindShelter_TextChanged);
            // 
            // AdminShelter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(884, 591);
            this.Controls.Add(this.pbxShelter);
            this.Controls.Add(this.lblFindSomeone);
            this.Controls.Add(this.txtFindShelter);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.gbxAdminManagement);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.cbxDistrict);
            this.Controls.Add(this.cbxCity);
            this.Controls.Add(this.dgwAdminShelter);
            this.Name = "AdminShelter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminShelter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminShelter_FormClosing);
            this.Load += new System.EventHandler(this.AdminShelter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdminShelter)).EndInit();
            this.gbxAdminManagement.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShelter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAdminShelter;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.ComboBox cbxDistrict;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.GroupBox gbxAdminManagement;
        private System.Windows.Forms.Button btnDeleteShelter;
        private System.Windows.Forms.Button btnAddShelter;
        private System.Windows.Forms.Button btnUpdateShelter;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem adminAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminShelterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminOtherThingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminAddPart1ToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox pbxShelter;
        private System.Windows.Forms.Label lblFindSomeone;
        private System.Windows.Forms.TextBox txtFindShelter;
    }
}