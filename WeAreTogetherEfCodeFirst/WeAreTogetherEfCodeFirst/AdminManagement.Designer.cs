namespace WeAreTogetherEfCodeFirst
{
    partial class AdminManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManagement));
            this.btnAddManagement = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.dgwManagement = new System.Windows.Forms.DataGridView();
            this.lblCity = new System.Windows.Forms.Label();
            this.cbxManagementType = new System.Windows.Forms.ComboBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.cbxDistrict = new System.Windows.Forms.ComboBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblManagementType = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnUpdateManagement = new System.Windows.Forms.Button();
            this.btnDeleteManagement = new System.Windows.Forms.Button();
            this.gbxAdminManagement = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.adminAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminShelterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminOtherThingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminAddPart1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwManagement)).BeginInit();
            this.gbxAdminManagement.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddManagement
            // 
            this.btnAddManagement.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnAddManagement.Image")));
            this.btnAddManagement.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAddManagement.Location = new System.Drawing.Point(30, 18);
            this.btnAddManagement.Name = "btnAddManagement";
            this.btnAddManagement.Size = new System.Drawing.Size(170, 54);
            this.btnAddManagement.TabIndex = 8;
            this.btnAddManagement.Text = "Add";
            this.btnAddManagement.UseVisualStyleBackColor = false;
            this.btnAddManagement.Click += new System.EventHandler(this.btnAddManagement_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(29, 274);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(308, 20);
            this.lblWarning.TabIndex = 1;
            this.lblWarning.Text = "Pick one entity to add,update, delete ";
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxName.Location = new System.Drawing.Point(212, 412);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(252, 26);
            this.tbxName.TabIndex = 4;
            this.tbxName.Validating += new System.ComponentModel.CancelEventHandler(this.tbxName_Validating);
            // 
            // dgwManagement
            // 
            this.dgwManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwManagement.Location = new System.Drawing.Point(0, 28);
            this.dgwManagement.Name = "dgwManagement";
            this.dgwManagement.Size = new System.Drawing.Size(904, 220);
            this.dgwManagement.TabIndex = 3;
            this.dgwManagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwManagement_CellClick);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCity.Location = new System.Drawing.Point(29, 348);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 20);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // cbxManagementType
            // 
            this.cbxManagementType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxManagementType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxManagementType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxManagementType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxManagementType.FormattingEnabled = true;
            this.cbxManagementType.Location = new System.Drawing.Point(212, 311);
            this.cbxManagementType.Name = "cbxManagementType";
            this.cbxManagementType.Size = new System.Drawing.Size(252, 28);
            this.cbxManagementType.TabIndex = 1;
            // 
            // cbxCity
            // 
            this.cbxCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(212, 345);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(252, 28);
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
            this.cbxDistrict.Location = new System.Drawing.Point(212, 379);
            this.cbxDistrict.Name = "cbxDistrict";
            this.cbxDistrict.Size = new System.Drawing.Size(252, 28);
            this.cbxDistrict.TabIndex = 3;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAddress.Location = new System.Drawing.Point(212, 444);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(252, 58);
            this.tbxAddress.TabIndex = 5;
            this.tbxAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbxAddress_Validating);
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUsername.Location = new System.Drawing.Point(212, 508);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(252, 26);
            this.tbxUsername.TabIndex = 6;
            this.tbxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbxUsername_Validating);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPassword.Location = new System.Drawing.Point(212, 540);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(252, 26);
            this.tbxPassword.TabIndex = 7;
            this.tbxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPassword_Validating);
            // 
            // lblManagementType
            // 
            this.lblManagementType.AutoSize = true;
            this.lblManagementType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblManagementType.Location = new System.Drawing.Point(29, 314);
            this.lblManagementType.Name = "lblManagementType";
            this.lblManagementType.Size = new System.Drawing.Size(156, 20);
            this.lblManagementType.TabIndex = 11;
            this.lblManagementType.Text = "Management Type";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDistrict.Location = new System.Drawing.Point(29, 379);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(69, 20);
            this.lblDistrict.TabIndex = 12;
            this.lblDistrict.Text = "Discrict";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(29, 415);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.Location = new System.Drawing.Point(29, 447);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 20);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Address";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsername.Location = new System.Drawing.Point(29, 511);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 20);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(29, 543);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 20);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // btnUpdateManagement
            // 
            this.btnUpdateManagement.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateManagement.Image")));
            this.btnUpdateManagement.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdateManagement.Location = new System.Drawing.Point(30, 86);
            this.btnUpdateManagement.Name = "btnUpdateManagement";
            this.btnUpdateManagement.Size = new System.Drawing.Size(170, 54);
            this.btnUpdateManagement.TabIndex = 9;
            this.btnUpdateManagement.Text = "Update";
            this.btnUpdateManagement.UseVisualStyleBackColor = false;
            this.btnUpdateManagement.Click += new System.EventHandler(this.btnUpdateManagement_Click);
            // 
            // btnDeleteManagement
            // 
            this.btnDeleteManagement.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteManagement.Image")));
            this.btnDeleteManagement.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeleteManagement.Location = new System.Drawing.Point(30, 151);
            this.btnDeleteManagement.Name = "btnDeleteManagement";
            this.btnDeleteManagement.Size = new System.Drawing.Size(170, 54);
            this.btnDeleteManagement.TabIndex = 10;
            this.btnDeleteManagement.Text = "Delete";
            this.btnDeleteManagement.UseVisualStyleBackColor = false;
            this.btnDeleteManagement.Click += new System.EventHandler(this.btnDeleteManagement_Click);
            // 
            // gbxAdminManagement
            // 
            this.gbxAdminManagement.Controls.Add(this.btnDeleteManagement);
            this.gbxAdminManagement.Controls.Add(this.btnAddManagement);
            this.gbxAdminManagement.Controls.Add(this.btnUpdateManagement);
            this.gbxAdminManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAdminManagement.Location = new System.Drawing.Point(604, 311);
            this.gbxAdminManagement.Name = "gbxAdminManagement";
            this.gbxAdminManagement.Size = new System.Drawing.Size(219, 223);
            this.gbxAdminManagement.TabIndex = 19;
            this.gbxAdminManagement.TabStop = false;
            this.gbxAdminManagement.Text = "CRUD";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(904, 25);
            this.toolStrip1.TabIndex = 20;
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
            // AdminManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(904, 611);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbxAdminManagement);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.lblManagementType);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.cbxDistrict);
            this.Controls.Add(this.cbxCity);
            this.Controls.Add(this.cbxManagementType);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.dgwManagement);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblWarning);
            this.Name = "AdminManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminManagement";
            this.Load += new System.EventHandler(this.AdminManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwManagement)).EndInit();
            this.gbxAdminManagement.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddManagement;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.DataGridView dgwManagement;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cbxManagementType;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.ComboBox cbxDistrict;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblManagementType;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnUpdateManagement;
        private System.Windows.Forms.Button btnDeleteManagement;
        private System.Windows.Forms.GroupBox gbxAdminManagement;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem adminAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminShelterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminOtherThingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminAddPart1ToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}