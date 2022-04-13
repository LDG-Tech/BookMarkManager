namespace BookMark_Manager
{
    partial class Form_main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.dataGridView_links = new System.Windows.Forms.DataGridView();
            this.col_link_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_link_name = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_link_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_link_cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_category = new System.Windows.Forms.DataGridView();
            this.col_cat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cat_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_assign_cat = new System.Windows.Forms.Button();
            this.checkBox_desc = new System.Windows.Forms.CheckBox();
            this.checkBox_link = new System.Windows.Forms.CheckBox();
            this.Button_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_reinitlist = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_add_desc = new System.Windows.Forms.TextBox();
            this.Button_addlink = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_add_link = new System.Windows.Forms.TextBox();
            this.Button_del_link = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Button_add_cat = new System.Windows.Forms.Button();
            this.textBox_cat_add = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Button_del_cat = new System.Windows.Forms.Button();
            this.Button_show_links = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_links)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_category)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_links
            // 
            this.dataGridView_links.AllowUserToAddRows = false;
            this.dataGridView_links.AllowUserToDeleteRows = false;
            this.dataGridView_links.AllowUserToResizeRows = false;
            this.dataGridView_links.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_links.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_link_id,
            this.col_link_name,
            this.col_link_desc,
            this.col_link_cat});
            this.dataGridView_links.Location = new System.Drawing.Point(12, 123);
            this.dataGridView_links.MultiSelect = false;
            this.dataGridView_links.Name = "dataGridView_links";
            this.dataGridView_links.ReadOnly = true;
            this.dataGridView_links.RowHeadersVisible = false;
            this.dataGridView_links.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_links.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_links.Size = new System.Drawing.Size(843, 369);
            this.dataGridView_links.TabIndex = 0;
            this.dataGridView_links.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_links_CellContentClick);
            // 
            // col_link_id
            // 
            this.col_link_id.HeaderText = "ID";
            this.col_link_id.Name = "col_link_id";
            this.col_link_id.ReadOnly = true;
            this.col_link_id.Width = 40;
            // 
            // col_link_name
            // 
            this.col_link_name.HeaderText = "Lien";
            this.col_link_name.Name = "col_link_name";
            this.col_link_name.ReadOnly = true;
            this.col_link_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_link_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_link_name.Width = 300;
            // 
            // col_link_desc
            // 
            this.col_link_desc.HeaderText = "Description";
            this.col_link_desc.Name = "col_link_desc";
            this.col_link_desc.ReadOnly = true;
            this.col_link_desc.Width = 250;
            // 
            // col_link_cat
            // 
            this.col_link_cat.HeaderText = "Catégorie";
            this.col_link_cat.Name = "col_link_cat";
            this.col_link_cat.ReadOnly = true;
            this.col_link_cat.Width = 250;
            // 
            // dataGridView_category
            // 
            this.dataGridView_category.AllowUserToAddRows = false;
            this.dataGridView_category.AllowUserToDeleteRows = false;
            this.dataGridView_category.AllowUserToResizeRows = false;
            this.dataGridView_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cat_id,
            this.col_cat_name});
            this.dataGridView_category.Location = new System.Drawing.Point(861, 123);
            this.dataGridView_category.MultiSelect = false;
            this.dataGridView_category.Name = "dataGridView_category";
            this.dataGridView_category.ReadOnly = true;
            this.dataGridView_category.RowHeadersVisible = false;
            this.dataGridView_category.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_category.Size = new System.Drawing.Size(302, 369);
            this.dataGridView_category.TabIndex = 1;
            // 
            // col_cat_id
            // 
            this.col_cat_id.HeaderText = "ID";
            this.col_cat_id.Name = "col_cat_id";
            this.col_cat_id.ReadOnly = true;
            this.col_cat_id.Width = 40;
            // 
            // col_cat_name
            // 
            this.col_cat_name.HeaderText = "Catégorie";
            this.col_cat_name.Name = "col_cat_name";
            this.col_cat_name.ReadOnly = true;
            this.col_cat_name.Width = 259;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(60, 18);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(213, 20);
            this.textBox_search.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_assign_cat);
            this.groupBox1.Controls.Add(this.checkBox_desc);
            this.groupBox1.Controls.Add(this.checkBox_link);
            this.groupBox1.Controls.Add(this.Button_search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_search);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche lien";
            // 
            // Button_assign_cat
            // 
            this.Button_assign_cat.Location = new System.Drawing.Point(504, 17);
            this.Button_assign_cat.Name = "Button_assign_cat";
            this.Button_assign_cat.Size = new System.Drawing.Size(142, 22);
            this.Button_assign_cat.TabIndex = 8;
            this.Button_assign_cat.Text = "Assigner catégorie";
            this.Button_assign_cat.UseVisualStyleBackColor = true;
            this.Button_assign_cat.Click += new System.EventHandler(this.Button_assign_cat_Click);
            // 
            // checkBox_desc
            // 
            this.checkBox_desc.AutoSize = true;
            this.checkBox_desc.Checked = true;
            this.checkBox_desc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_desc.Location = new System.Drawing.Point(331, 21);
            this.checkBox_desc.Name = "checkBox_desc";
            this.checkBox_desc.Size = new System.Drawing.Size(79, 17);
            this.checkBox_desc.TabIndex = 7;
            this.checkBox_desc.Text = "Description";
            this.checkBox_desc.UseVisualStyleBackColor = true;
            // 
            // checkBox_link
            // 
            this.checkBox_link.AutoSize = true;
            this.checkBox_link.Location = new System.Drawing.Point(279, 21);
            this.checkBox_link.Name = "checkBox_link";
            this.checkBox_link.Size = new System.Drawing.Size(46, 17);
            this.checkBox_link.TabIndex = 6;
            this.checkBox_link.Text = "Lien";
            this.checkBox_link.UseVisualStyleBackColor = true;
            // 
            // Button_search
            // 
            this.Button_search.Location = new System.Drawing.Point(416, 17);
            this.Button_search.Name = "Button_search";
            this.Button_search.Size = new System.Drawing.Size(82, 22);
            this.Button_search.TabIndex = 5;
            this.Button_search.Text = "Recherche...";
            this.Button_search.UseVisualStyleBackColor = true;
            this.Button_search.Click += new System.EventHandler(this.Button_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mot clé :";
            // 
            // Button_reinitlist
            // 
            this.Button_reinitlist.Location = new System.Drawing.Point(762, 77);
            this.Button_reinitlist.Name = "Button_reinitlist";
            this.Button_reinitlist.Size = new System.Drawing.Size(93, 35);
            this.Button_reinitlist.TabIndex = 4;
            this.Button_reinitlist.Text = "Réinitialiser la liste";
            this.Button_reinitlist.UseVisualStyleBackColor = true;
            this.Button_reinitlist.Click += new System.EventHandler(this.Button_reinitlist_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_add_desc);
            this.groupBox2.Controls.Add(this.Button_addlink);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_add_link);
            this.groupBox2.Location = new System.Drawing.Point(12, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 51);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajouter lien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description :";
            // 
            // textBox_add_desc
            // 
            this.textBox_add_desc.Location = new System.Drawing.Point(449, 19);
            this.textBox_add_desc.Name = "textBox_add_desc";
            this.textBox_add_desc.Size = new System.Drawing.Size(277, 20);
            this.textBox_add_desc.TabIndex = 6;
            // 
            // Button_addlink
            // 
            this.Button_addlink.Location = new System.Drawing.Point(732, 18);
            this.Button_addlink.Name = "Button_addlink";
            this.Button_addlink.Size = new System.Drawing.Size(105, 22);
            this.Button_addlink.TabIndex = 5;
            this.Button_addlink.Text = "Ajouter";
            this.Button_addlink.UseVisualStyleBackColor = true;
            this.Button_addlink.Click += new System.EventHandler(this.Button_addlink_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lien :";
            // 
            // textBox_add_link
            // 
            this.textBox_add_link.Location = new System.Drawing.Point(60, 19);
            this.textBox_add_link.Name = "textBox_add_link";
            this.textBox_add_link.Size = new System.Drawing.Size(311, 20);
            this.textBox_add_link.TabIndex = 2;
            // 
            // Button_del_link
            // 
            this.Button_del_link.BackColor = System.Drawing.Color.Red;
            this.Button_del_link.Location = new System.Drawing.Point(670, 77);
            this.Button_del_link.Name = "Button_del_link";
            this.Button_del_link.Size = new System.Drawing.Size(86, 35);
            this.Button_del_link.TabIndex = 7;
            this.Button_del_link.Text = "Supprimer lien";
            this.Button_del_link.UseVisualStyleBackColor = false;
            this.Button_del_link.Click += new System.EventHandler(this.Button_del_link_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Button_add_cat);
            this.groupBox3.Controls.Add(this.textBox_cat_add);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(861, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 48);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ajouter catégorie";
            // 
            // Button_add_cat
            // 
            this.Button_add_cat.Location = new System.Drawing.Point(216, 15);
            this.Button_add_cat.Name = "Button_add_cat";
            this.Button_add_cat.Size = new System.Drawing.Size(80, 22);
            this.Button_add_cat.TabIndex = 6;
            this.Button_add_cat.Text = "Ajouter";
            this.Button_add_cat.UseVisualStyleBackColor = true;
            this.Button_add_cat.Click += new System.EventHandler(this.Button_add_cat_Click);
            // 
            // textBox_cat_add
            // 
            this.textBox_cat_add.Location = new System.Drawing.Point(70, 16);
            this.textBox_cat_add.Name = "textBox_cat_add";
            this.textBox_cat_add.Size = new System.Drawing.Size(140, 20);
            this.textBox_cat_add.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Catégorie :";
            // 
            // Button_del_cat
            // 
            this.Button_del_cat.BackColor = System.Drawing.Color.Red;
            this.Button_del_cat.Location = new System.Drawing.Point(1052, 77);
            this.Button_del_cat.Name = "Button_del_cat";
            this.Button_del_cat.Size = new System.Drawing.Size(111, 35);
            this.Button_del_cat.TabIndex = 9;
            this.Button_del_cat.Text = "Supprimer catégorie";
            this.Button_del_cat.UseVisualStyleBackColor = false;
            this.Button_del_cat.Click += new System.EventHandler(this.Button_del_cat_Click);
            // 
            // Button_show_links
            // 
            this.Button_show_links.Location = new System.Drawing.Point(870, 77);
            this.Button_show_links.Name = "Button_show_links";
            this.Button_show_links.Size = new System.Drawing.Size(176, 35);
            this.Button_show_links.TabIndex = 10;
            this.Button_show_links.Text = "Afficher les liens";
            this.Button_show_links.UseVisualStyleBackColor = true;
            this.Button_show_links.Click += new System.EventHandler(this.Button_show_links_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 505);
            this.Controls.Add(this.Button_show_links);
            this.Controls.Add(this.Button_del_cat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Button_del_link);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Button_reinitlist);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_category);
            this.Controls.Add(this.dataGridView_links);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_links)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_category)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_links;
        private System.Windows.Forms.DataGridView dataGridView_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cat_name;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_search;
        private System.Windows.Forms.Button Button_reinitlist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Button_addlink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_add_link;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_add_desc;
        private System.Windows.Forms.Button Button_del_link;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Button_add_cat;
        private System.Windows.Forms.TextBox textBox_cat_add;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Button_del_cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_link_id;
        private System.Windows.Forms.DataGridViewLinkColumn col_link_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_link_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_link_cat;
        private System.Windows.Forms.CheckBox checkBox_desc;
        private System.Windows.Forms.CheckBox checkBox_link;
        private System.Windows.Forms.Button Button_show_links;
        private System.Windows.Forms.Button Button_assign_cat;
    }
}

