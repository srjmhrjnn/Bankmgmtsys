namespace moneymanagementinbank
{
    partial class statement
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
            this.userinfoDataSet = new moneymanagementinbank.userinfoDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tchangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tballanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statemtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statemtTableAdapter = new moneymanagementinbank.userinfoDataSetTableAdapters.statemtTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userinfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statemtBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userinfoDataSet
            // 
            this.userinfoDataSet.DataSetName = "userinfoDataSet";
            this.userinfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 76;
            this.button1.Text = "View Statement";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(282, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 75;
            this.label9.Text = "Account id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 22);
            this.label1.TabIndex = 72;
            this.label1.Text = "Account Statement";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(367, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 69;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tidDataGridViewTextBoxColumn,
            this.tdateDataGridViewTextBoxColumn,
            this.aidDataGridViewTextBoxColumn,
            this.tinfoDataGridViewTextBoxColumn,
            this.tchangeDataGridViewTextBoxColumn,
            this.tballanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.statemtBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(111, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 301);
            this.dataGridView1.TabIndex = 77;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tidDataGridViewTextBoxColumn
            // 
            this.tidDataGridViewTextBoxColumn.DataPropertyName = "t_id";
            this.tidDataGridViewTextBoxColumn.HeaderText = "t_id";
            this.tidDataGridViewTextBoxColumn.Name = "tidDataGridViewTextBoxColumn";
            this.tidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tdateDataGridViewTextBoxColumn
            // 
            this.tdateDataGridViewTextBoxColumn.DataPropertyName = "t_date";
            this.tdateDataGridViewTextBoxColumn.HeaderText = "t_date";
            this.tdateDataGridViewTextBoxColumn.Name = "tdateDataGridViewTextBoxColumn";
            // 
            // aidDataGridViewTextBoxColumn
            // 
            this.aidDataGridViewTextBoxColumn.DataPropertyName = "a_id";
            this.aidDataGridViewTextBoxColumn.HeaderText = "a_id";
            this.aidDataGridViewTextBoxColumn.Name = "aidDataGridViewTextBoxColumn";
            // 
            // tinfoDataGridViewTextBoxColumn
            // 
            this.tinfoDataGridViewTextBoxColumn.DataPropertyName = "t_info";
            this.tinfoDataGridViewTextBoxColumn.HeaderText = "t_info";
            this.tinfoDataGridViewTextBoxColumn.Name = "tinfoDataGridViewTextBoxColumn";
            // 
            // tchangeDataGridViewTextBoxColumn
            // 
            this.tchangeDataGridViewTextBoxColumn.DataPropertyName = "t_change";
            this.tchangeDataGridViewTextBoxColumn.HeaderText = "t_change";
            this.tchangeDataGridViewTextBoxColumn.Name = "tchangeDataGridViewTextBoxColumn";
            // 
            // tballanceDataGridViewTextBoxColumn
            // 
            this.tballanceDataGridViewTextBoxColumn.DataPropertyName = "t_ballance";
            this.tballanceDataGridViewTextBoxColumn.HeaderText = "t_ballance";
            this.tballanceDataGridViewTextBoxColumn.Name = "tballanceDataGridViewTextBoxColumn";
            // 
            // statemtBindingSource
            // 
            this.statemtBindingSource.DataMember = "statemt";
            this.statemtBindingSource.DataSource = this.userinfoDataSet;
            // 
            // statemtTableAdapter
            // 
            this.statemtTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 78;
            this.button2.Text = "View Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 470);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "statement";
            this.Text = "statement";
            this.Load += new System.EventHandler(this.statement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userinfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statemtBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private userinfoDataSet userinfoDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tchangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tballanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource statemtBindingSource;
        private moneymanagementinbank.userinfoDataSetTableAdapters.statemtTableAdapter statemtTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}