namespace WeAreTogetherEfCodeFirst
{
    partial class AdminAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAnimal));
            this.gbxAdminAnimal = new System.Windows.Forms.GroupBox();
            this.btnDeleteAnimal = new System.Windows.Forms.Button();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnUpdateAnimal = new System.Windows.Forms.Button();
            this.dgwAnimal = new System.Windows.Forms.DataGridView();
            this.cbxKindOfAnimal = new System.Windows.Forms.ComboBox();
            this.dtpAnimal = new System.Windows.Forms.DateTimePicker();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxNote = new System.Windows.Forms.TextBox();
            this.cbxTrue = new System.Windows.Forms.CheckBox();
            this.lblKinfOfAnimal = new System.Windows.Forms.Label();
            this.lblShelterId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDateOfRegister = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblPet = new System.Windows.Forms.Label();
            this.cbxFalse = new System.Windows.Forms.CheckBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.cbxShelterId = new System.Windows.Forms.ComboBox();
            this.beraberiz2DataSet3 = new WeAreTogetherEfCodeFirst.Beraberiz2DataSet3();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.adminAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminShelterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminOtherThingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminAddPart1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxAdminAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beraberiz2DataSet3)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAdminAnimal
            // 
            this.gbxAdminAnimal.Controls.Add(this.btnDeleteAnimal);
            this.gbxAdminAnimal.Controls.Add(this.btnAddAnimal);
            this.gbxAdminAnimal.Controls.Add(this.btnUpdateAnimal);
            this.gbxAdminAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAdminAnimal.Location = new System.Drawing.Point(588, 301);
            this.gbxAdminAnimal.Name = "gbxAdminAnimal";
            this.gbxAdminAnimal.Size = new System.Drawing.Size(219, 223);
            this.gbxAdminAnimal.TabIndex = 20;
            this.gbxAdminAnimal.TabStop = false;
            this.gbxAdminAnimal.Text = "CRUD";
            // 
            // btnDeleteAnimal
            // 
            this.btnDeleteAnimal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteAnimal.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAnimal.Image")));
            this.btnDeleteAnimal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeleteAnimal.Location = new System.Drawing.Point(30, 151);
            this.btnDeleteAnimal.Name = "btnDeleteAnimal";
            this.btnDeleteAnimal.Size = new System.Drawing.Size(170, 54);
            this.btnDeleteAnimal.TabIndex = 10;
            this.btnDeleteAnimal.Text = "Delete";
            this.btnDeleteAnimal.UseVisualStyleBackColor = false;
            this.btnDeleteAnimal.Click += new System.EventHandler(this.btnDeleteAnimal_Click);
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddAnimal.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAnimal.Image")));
            this.btnAddAnimal.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAddAnimal.Location = new System.Drawing.Point(30, 18);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(170, 54);
            this.btnAddAnimal.TabIndex = 8;
            this.btnAddAnimal.Text = "Add";
            this.btnAddAnimal.UseVisualStyleBackColor = false;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnUpdateAnimal
            // 
            this.btnUpdateAnimal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateAnimal.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateAnimal.Image")));
            this.btnUpdateAnimal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdateAnimal.Location = new System.Drawing.Point(30, 86);
            this.btnUpdateAnimal.Name = "btnUpdateAnimal";
            this.btnUpdateAnimal.Size = new System.Drawing.Size(170, 54);
            this.btnUpdateAnimal.TabIndex = 9;
            this.btnUpdateAnimal.Text = "Update";
            this.btnUpdateAnimal.UseVisualStyleBackColor = false;
            this.btnUpdateAnimal.Click += new System.EventHandler(this.btnUpdateAnimal_Click);
            // 
            // dgwAnimal
            // 
            this.dgwAnimal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAnimal.Location = new System.Drawing.Point(0, 28);
            this.dgwAnimal.Name = "dgwAnimal";
            this.dgwAnimal.Size = new System.Drawing.Size(884, 220);
            this.dgwAnimal.TabIndex = 21;
            this.dgwAnimal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAnimal_CellClick);
            // 
            // cbxKindOfAnimal
            // 
            this.cbxKindOfAnimal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxKindOfAnimal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxKindOfAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKindOfAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxKindOfAnimal.FormattingEnabled = true;
            this.cbxKindOfAnimal.Location = new System.Drawing.Point(167, 302);
            this.cbxKindOfAnimal.Name = "cbxKindOfAnimal";
            this.cbxKindOfAnimal.Size = new System.Drawing.Size(198, 28);
            this.cbxKindOfAnimal.TabIndex = 1;
            // 
            // dtpAnimal
            // 
            this.dtpAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpAnimal.Location = new System.Drawing.Point(167, 404);
            this.dtpAnimal.Name = "dtpAnimal";
            this.dtpAnimal.Size = new System.Drawing.Size(283, 26);
            this.dtpAnimal.TabIndex = 4;
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxName.Location = new System.Drawing.Point(167, 370);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(198, 26);
            this.tbxName.TabIndex = 3;
            // 
            // tbxNote
            // 
            this.tbxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxNote.Location = new System.Drawing.Point(167, 440);
            this.tbxNote.Multiline = true;
            this.tbxNote.Name = "tbxNote";
            this.tbxNote.Size = new System.Drawing.Size(283, 84);
            this.tbxNote.TabIndex = 5;
            // 
            // cbxTrue
            // 
            this.cbxTrue.AutoSize = true;
            this.cbxTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxTrue.Location = new System.Drawing.Point(167, 536);
            this.cbxTrue.Name = "cbxTrue";
            this.cbxTrue.Size = new System.Drawing.Size(59, 24);
            this.cbxTrue.TabIndex = 6;
            this.cbxTrue.Text = "Yes";
            this.cbxTrue.UseVisualStyleBackColor = true;
            this.cbxTrue.CheckedChanged += new System.EventHandler(this.cbxTrue_CheckedChanged);
            // 
            // lblKinfOfAnimal
            // 
            this.lblKinfOfAnimal.AutoSize = true;
            this.lblKinfOfAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKinfOfAnimal.Location = new System.Drawing.Point(14, 305);
            this.lblKinfOfAnimal.Name = "lblKinfOfAnimal";
            this.lblKinfOfAnimal.Size = new System.Drawing.Size(127, 20);
            this.lblKinfOfAnimal.TabIndex = 29;
            this.lblKinfOfAnimal.Text = "Kind Of Animal";
            // 
            // lblShelterId
            // 
            this.lblShelterId.AutoSize = true;
            this.lblShelterId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblShelterId.Location = new System.Drawing.Point(14, 336);
            this.lblShelterId.Name = "lblShelterId";
            this.lblShelterId.Size = new System.Drawing.Size(83, 20);
            this.lblShelterId.TabIndex = 30;
            this.lblShelterId.Text = "ShelterId";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(14, 373);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Name";
            // 
            // lblDateOfRegister
            // 
            this.lblDateOfRegister.AutoSize = true;
            this.lblDateOfRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDateOfRegister.Location = new System.Drawing.Point(14, 409);
            this.lblDateOfRegister.Name = "lblDateOfRegister";
            this.lblDateOfRegister.Size = new System.Drawing.Size(145, 20);
            this.lblDateOfRegister.TabIndex = 32;
            this.lblDateOfRegister.Text = "Date Of Register";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNote.Location = new System.Drawing.Point(14, 443);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(113, 20);
            this.lblNote.TabIndex = 33;
            this.lblNote.Text = "Leave a note";
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPet.Location = new System.Drawing.Point(14, 536);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(36, 20);
            this.lblPet.TabIndex = 34;
            this.lblPet.Text = "Pet";
            // 
            // cbxFalse
            // 
            this.cbxFalse.AutoSize = true;
            this.cbxFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxFalse.Location = new System.Drawing.Point(232, 536);
            this.cbxFalse.Name = "cbxFalse";
            this.cbxFalse.Size = new System.Drawing.Size(72, 24);
            this.cbxFalse.TabIndex = 7;
            this.cbxFalse.Text = "False";
            this.cbxFalse.UseVisualStyleBackColor = true;
            this.cbxFalse.CheckedChanged += new System.EventHandler(this.cbxFalse_CheckedChanged);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(12, 261);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(313, 20);
            this.lblWarning.TabIndex = 36;
            this.lblWarning.Text = "Pick one entity to add, update, delete ";
            // 
            // cbxShelterId
            // 
            this.cbxShelterId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxShelterId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxShelterId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxShelterId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxShelterId.FormattingEnabled = true;
            this.cbxShelterId.Location = new System.Drawing.Point(167, 336);
            this.cbxShelterId.Name = "cbxShelterId";
            this.cbxShelterId.Size = new System.Drawing.Size(86, 28);
            this.cbxShelterId.TabIndex = 37;
            // 
            // beraberiz2DataSet3
            // 
            this.beraberiz2DataSet3.DataSetName = "Beraberiz2DataSet3";
            this.beraberiz2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 25);
            this.toolStrip1.TabIndex = 38;
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
            // AdminAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(884, 631);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cbxShelterId);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.cbxFalse);
            this.Controls.Add(this.lblPet);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblDateOfRegister);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblShelterId);
            this.Controls.Add(this.lblKinfOfAnimal);
            this.Controls.Add(this.cbxTrue);
            this.Controls.Add(this.tbxNote);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.dtpAnimal);
            this.Controls.Add(this.cbxKindOfAnimal);
            this.Controls.Add(this.dgwAnimal);
            this.Controls.Add(this.gbxAdminAnimal);
            this.Name = "AdminAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAnimal";
            this.Load += new System.EventHandler(this.AdminAnimal_Load);
            this.gbxAdminAnimal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beraberiz2DataSet3)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAdminAnimal;
        private System.Windows.Forms.Button btnDeleteAnimal;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnUpdateAnimal;
        private System.Windows.Forms.DataGridView dgwAnimal;
        private System.Windows.Forms.ComboBox cbxKindOfAnimal;
        private System.Windows.Forms.DateTimePicker dtpAnimal;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxNote;
        private System.Windows.Forms.CheckBox cbxTrue;
        private System.Windows.Forms.Label lblKinfOfAnimal;
        private System.Windows.Forms.Label lblShelterId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDateOfRegister;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.CheckBox cbxFalse;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.ComboBox cbxShelterId;
        private Beraberiz2DataSet3 beraberiz2DataSet3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem adminAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminShelterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminOtherThingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminAddPart1ToolStripMenuItem;
    }
}