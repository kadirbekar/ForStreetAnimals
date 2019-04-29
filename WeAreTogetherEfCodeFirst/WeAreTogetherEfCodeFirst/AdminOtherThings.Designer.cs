namespace WeAreTogetherEfCodeFirst
{
    partial class AdminOtherThings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminOtherThings));
            this.gbxAoT1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddPart1 = new System.Windows.Forms.Button();
            this.dgwOtherThings = new System.Windows.Forms.DataGridView();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.gbxAddSomething = new System.Windows.Forms.GroupBox();
            this.lblDegisken = new System.Windows.Forms.Label();
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
            this.gbxAoT1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOtherThings)).BeginInit();
            this.gbxAddSomething.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAoT1
            // 
            this.gbxAoT1.Controls.Add(this.btnDelete);
            this.gbxAoT1.Controls.Add(this.btnUpdate);
            this.gbxAoT1.Controls.Add(this.btnAddPart1);
            this.gbxAoT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAoT1.Location = new System.Drawing.Point(569, 303);
            this.gbxAoT1.Name = "gbxAoT1";
            this.gbxAoT1.Size = new System.Drawing.Size(219, 229);
            this.gbxAoT1.TabIndex = 21;
            this.gbxAoT1.TabStop = false;
            this.gbxAoT1.Text = "CRUD";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDelete.Location = new System.Drawing.Point(28, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 54);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdate.Location = new System.Drawing.Point(28, 96);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 54);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddPart1
            // 
            this.btnAddPart1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddPart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddPart1.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPart1.Image")));
            this.btnAddPart1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPart1.Location = new System.Drawing.Point(28, 30);
            this.btnAddPart1.Name = "btnAddPart1";
            this.btnAddPart1.Size = new System.Drawing.Size(170, 54);
            this.btnAddPart1.TabIndex = 8;
            this.btnAddPart1.Text = "Add";
            this.btnAddPart1.UseVisualStyleBackColor = false;
            this.btnAddPart1.Click += new System.EventHandler(this.btnAddPart1_Click);
            // 
            // dgwOtherThings
            // 
            this.dgwOtherThings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwOtherThings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOtherThings.Location = new System.Drawing.Point(0, 28);
            this.dgwOtherThings.Name = "dgwOtherThings";
            this.dgwOtherThings.Size = new System.Drawing.Size(884, 220);
            this.dgwOtherThings.TabIndex = 22;
            this.dgwOtherThings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOtherThings_CellClick);
            // 
            // cbxType
            // 
            this.cbxType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Phone Type",
            "Management Type",
            "Kind Of Animal"});
            this.cbxType.Location = new System.Drawing.Point(73, 30);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(318, 28);
            this.cbxType.TabIndex = 23;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdd.Location = new System.Drawing.Point(6, 33);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(61, 20);
            this.lblAdd.TabIndex = 24;
            this.lblAdd.Text = "Add a ";
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxName.Location = new System.Drawing.Point(73, 80);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(318, 26);
            this.tbxName.TabIndex = 25;
            this.tbxName.Validating += new System.ComponentModel.CancelEventHandler(this.tbxName_Validating);
            // 
            // gbxAddSomething
            // 
            this.gbxAddSomething.Controls.Add(this.lblDegisken);
            this.gbxAddSomething.Controls.Add(this.tbxName);
            this.gbxAddSomething.Controls.Add(this.cbxType);
            this.gbxAddSomething.Controls.Add(this.lblAdd);
            this.gbxAddSomething.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAddSomething.Location = new System.Drawing.Point(27, 333);
            this.gbxAddSomething.Name = "gbxAddSomething";
            this.gbxAddSomething.Size = new System.Drawing.Size(410, 141);
            this.gbxAddSomething.TabIndex = 26;
            this.gbxAddSomething.TabStop = false;
            this.gbxAddSomething.Text = "Add something";
            // 
            // lblDegisken
            // 
            this.lblDegisken.AutoSize = true;
            this.lblDegisken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDegisken.Location = new System.Drawing.Point(6, 83);
            this.lblDegisken.Name = "lblDegisken";
            this.lblDegisken.Size = new System.Drawing.Size(15, 20);
            this.lblDegisken.TabIndex = 63;
            this.lblDegisken.Text = "-";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(23, 300);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(313, 20);
            this.lblWarning.TabIndex = 62;
            this.lblWarning.Text = "Pick one entity to add, update, delete ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 25);
            this.toolStrip1.TabIndex = 64;
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
            // AdminOtherThings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.dgwOtherThings);
            this.Controls.Add(this.gbxAoT1);
            this.Controls.Add(this.gbxAddSomething);
            this.Name = "AdminOtherThings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminOtherThings";
            this.Load += new System.EventHandler(this.AdminOtherThings_Load);
            this.gbxAoT1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOtherThings)).EndInit();
            this.gbxAddSomething.ResumeLayout(false);
            this.gbxAddSomething.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAoT1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddPart1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgwOtherThings;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.GroupBox gbxAddSomething;
        private System.Windows.Forms.Label lblDegisken;
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
    }
}