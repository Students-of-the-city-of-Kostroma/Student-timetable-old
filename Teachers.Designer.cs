﻿namespace TimetableOfClasses
{
    partial class Teachers
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
            this.DG = new System.Windows.Forms.DataGridView();
            this.Fam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademicDegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademicRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheSizeOfTeachingExperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // DG
            // 
            this.DG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fam,
            this.Name,
            this.SurName,
            this.AcademicDegree,
            this.AcademicRank,
            this.TheSizeOfTeachingExperience});
            this.DG.Location = new System.Drawing.Point(12, 12);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(690, 287);
            this.DG.TabIndex = 0;
            this.DG.SelectionChanged += new System.EventHandler(this.DG_SelectionChanged);
            this.DG.SizeChanged += new System.EventHandler(this.DG_SizeChanged);
            // 
            // Fam
            // 
            this.Fam.HeaderText = "Фамилия";
            this.Fam.Name = "Fam";
            this.Fam.Width = 81;
            // 
            // Name
            // 
            this.Name.HeaderText = "Имя";
            this.Name.Name = "Name";
            this.Name.Width = 54;
            // 
            // SurName
            // 
            this.SurName.HeaderText = "Отчество";
            this.SurName.Name = "SurName";
            this.SurName.Width = 79;
            // 
            // AcademicDegree
            // 
            this.AcademicDegree.HeaderText = "Ученая степень";
            this.AcademicDegree.Name = "AcademicDegree";
            this.AcademicDegree.Width = 104;
            // 
            // AcademicRank
            // 
            this.AcademicRank.HeaderText = "Ученое звание";
            this.AcademicRank.Name = "AcademicRank";
            this.AcademicRank.Width = 99;
            // 
            // TheSizeOfTeachingExperience
            // 
            this.TheSizeOfTeachingExperience.HeaderText = "Размер педагогического стажа";
            this.TheSizeOfTeachingExperience.Name = "TheSizeOfTeachingExperience";
            this.TheSizeOfTeachingExperience.Width = 177;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(608, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(508, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 343);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DG);
          //  this.Name = "Teachers";
            this.Text = "Teachers";
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAcademicDegree;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAcademicRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTheSizeOfTeachingExperience;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademicDegree;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademicRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheSizeOfTeachingExperience;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}