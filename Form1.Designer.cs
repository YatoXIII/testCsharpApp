
namespace ЦВД_тестовоеЗадание
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.depSalaryTab = new System.Windows.Forms.TabPage();
            this.depSalaryButton = new System.Windows.Forms.Button();
            this.showChief = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.depSalary = new System.Windows.Forms.DataGridView();
            this.maxDepSalaryTab = new System.Windows.Forms.TabPage();
            this.maxDepSalaryButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maxDepSalary = new System.Windows.Forms.DataGridView();
            this.chiefSalaryTab = new System.Windows.Forms.TabPage();
            this.chiefSalaryButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chiefSalary = new System.Windows.Forms.DataGridView();
            this.addTestData = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.depSalaryTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depSalary)).BeginInit();
            this.maxDepSalaryTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxDepSalary)).BeginInit();
            this.chiefSalaryTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiefSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.depSalaryTab);
            this.tabControl.Controls.Add(this.maxDepSalaryTab);
            this.tabControl.Controls.Add(this.chiefSalaryTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(766, 367);
            this.tabControl.TabIndex = 0;
            // 
            // depSalaryTab
            // 
            this.depSalaryTab.Controls.Add(this.depSalaryButton);
            this.depSalaryTab.Controls.Add(this.showChief);
            this.depSalaryTab.Controls.Add(this.groupBox1);
            this.depSalaryTab.Location = new System.Drawing.Point(4, 22);
            this.depSalaryTab.Name = "depSalaryTab";
            this.depSalaryTab.Padding = new System.Windows.Forms.Padding(3);
            this.depSalaryTab.Size = new System.Drawing.Size(758, 341);
            this.depSalaryTab.TabIndex = 0;
            this.depSalaryTab.Text = "Суммарная з/п департаментов";
            this.depSalaryTab.UseVisualStyleBackColor = true;
            // 
            // depSalaryButton
            // 
            this.depSalaryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.depSalaryButton.Location = new System.Drawing.Point(661, 1);
            this.depSalaryButton.Name = "depSalaryButton";
            this.depSalaryButton.Size = new System.Drawing.Size(94, 23);
            this.depSalaryButton.TabIndex = 3;
            this.depSalaryButton.Text = "Сформировать";
            this.depSalaryButton.UseVisualStyleBackColor = true;
            this.depSalaryButton.Click += new System.EventHandler(this.depSalaryButton_Click);
            // 
            // showChief
            // 
            this.showChief.AutoSize = true;
            this.showChief.Location = new System.Drawing.Point(6, 5);
            this.showChief.Name = "showChief";
            this.showChief.Size = new System.Drawing.Size(222, 17);
            this.showChief.TabIndex = 2;
            this.showChief.Text = "Показывать в разрезе руководителей";
            this.showChief.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.depSalary);
            this.groupBox1.Location = new System.Drawing.Point(0, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 322);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // depSalary
            // 
            this.depSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depSalary.Location = new System.Drawing.Point(3, 16);
            this.depSalary.Name = "depSalary";
            this.depSalary.ReadOnly = true;
            this.depSalary.Size = new System.Drawing.Size(752, 303);
            this.depSalary.TabIndex = 0;
            // 
            // maxDepSalaryTab
            // 
            this.maxDepSalaryTab.Controls.Add(this.maxDepSalaryButton);
            this.maxDepSalaryTab.Controls.Add(this.groupBox2);
            this.maxDepSalaryTab.Location = new System.Drawing.Point(4, 22);
            this.maxDepSalaryTab.Name = "maxDepSalaryTab";
            this.maxDepSalaryTab.Padding = new System.Windows.Forms.Padding(3);
            this.maxDepSalaryTab.Size = new System.Drawing.Size(758, 341);
            this.maxDepSalaryTab.TabIndex = 1;
            this.maxDepSalaryTab.Text = "Сотрудники департаментов с максимальной з/п";
            this.maxDepSalaryTab.UseVisualStyleBackColor = true;
            // 
            // maxDepSalaryButton
            // 
            this.maxDepSalaryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxDepSalaryButton.Location = new System.Drawing.Point(661, 1);
            this.maxDepSalaryButton.Name = "maxDepSalaryButton";
            this.maxDepSalaryButton.Size = new System.Drawing.Size(94, 23);
            this.maxDepSalaryButton.TabIndex = 5;
            this.maxDepSalaryButton.Text = "Сформировать";
            this.maxDepSalaryButton.UseVisualStyleBackColor = true;
            this.maxDepSalaryButton.Click += new System.EventHandler(this.maxDepSalaryButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.maxDepSalary);
            this.groupBox2.Location = new System.Drawing.Point(0, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 322);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // maxDepSalary
            // 
            this.maxDepSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maxDepSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxDepSalary.Location = new System.Drawing.Point(3, 16);
            this.maxDepSalary.Name = "maxDepSalary";
            this.maxDepSalary.ReadOnly = true;
            this.maxDepSalary.Size = new System.Drawing.Size(752, 303);
            this.maxDepSalary.TabIndex = 0;
            // 
            // chiefSalaryTab
            // 
            this.chiefSalaryTab.Controls.Add(this.chiefSalaryButton);
            this.chiefSalaryTab.Controls.Add(this.groupBox3);
            this.chiefSalaryTab.Location = new System.Drawing.Point(4, 22);
            this.chiefSalaryTab.Name = "chiefSalaryTab";
            this.chiefSalaryTab.Padding = new System.Windows.Forms.Padding(3);
            this.chiefSalaryTab.Size = new System.Drawing.Size(758, 341);
            this.chiefSalaryTab.TabIndex = 2;
            this.chiefSalaryTab.Text = "З/п руководителей";
            this.chiefSalaryTab.UseVisualStyleBackColor = true;
            // 
            // chiefSalaryButton
            // 
            this.chiefSalaryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chiefSalaryButton.Location = new System.Drawing.Point(661, 1);
            this.chiefSalaryButton.Name = "chiefSalaryButton";
            this.chiefSalaryButton.Size = new System.Drawing.Size(94, 23);
            this.chiefSalaryButton.TabIndex = 5;
            this.chiefSalaryButton.Text = "Сформировать";
            this.chiefSalaryButton.UseVisualStyleBackColor = true;
            this.chiefSalaryButton.Click += new System.EventHandler(this.chiefSalaryButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.chiefSalary);
            this.groupBox3.Location = new System.Drawing.Point(0, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(758, 322);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // chiefSalary
            // 
            this.chiefSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chiefSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chiefSalary.Location = new System.Drawing.Point(3, 16);
            this.chiefSalary.Name = "chiefSalary";
            this.chiefSalary.ReadOnly = true;
            this.chiefSalary.Size = new System.Drawing.Size(752, 303);
            this.chiefSalary.TabIndex = 0;
            // 
            // addTestData
            // 
            this.addTestData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addTestData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTestData.Location = new System.Drawing.Point(595, 0);
            this.addTestData.Name = "addTestData";
            this.addTestData.Size = new System.Drawing.Size(170, 20);
            this.addTestData.TabIndex = 1;
            this.addTestData.Text = "Добавить тестовые значения";
            this.addTestData.UseVisualStyleBackColor = true;
            this.addTestData.Click += new System.EventHandler(this.addTestData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 367);
            this.Controls.Add(this.addTestData);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.depSalaryTab.ResumeLayout(false);
            this.depSalaryTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.depSalary)).EndInit();
            this.maxDepSalaryTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxDepSalary)).EndInit();
            this.chiefSalaryTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chiefSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button addTestData;
        private System.Windows.Forms.TabPage depSalaryTab;
        private System.Windows.Forms.TabPage maxDepSalaryTab;
        private System.Windows.Forms.TabPage chiefSalaryTab;
        private System.Windows.Forms.Button depSalaryButton;
        private System.Windows.Forms.CheckBox showChief;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView depSalary;
        private System.Windows.Forms.Button maxDepSalaryButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView maxDepSalary;
        private System.Windows.Forms.Button chiefSalaryButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView chiefSalary;
    }
}

