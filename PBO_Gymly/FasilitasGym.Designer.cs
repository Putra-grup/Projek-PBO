﻿namespace PBO_Gymly
{
    partial class FasilitasGym
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FasilitasGym));
            ButtonBack = new Button();
            ButtonAddFasilitasGym = new Button();
            ButtonChange = new Button();
            ButtonDelete = new Button();
            DataGridView_FasilitasGym = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridView_FasilitasGym).BeginInit();
            SuspendLayout();
            // 
            // ButtonBack
            // 
            ButtonBack.BackColor = Color.FromArgb(127, 200, 248);
            ButtonBack.FlatAppearance.BorderSize = 0;
            ButtonBack.FlatStyle = FlatStyle.Flat;
            ButtonBack.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonBack.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonBack.Location = new Point(23, 516);
            ButtonBack.Margin = new Padding(3, 4, 3, 4);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(69, 40);
            ButtonBack.TabIndex = 0;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // ButtonAddFasilitasGym
            // 
            ButtonAddFasilitasGym.BackColor = Color.FromArgb(127, 200, 248);
            ButtonAddFasilitasGym.FlatAppearance.BorderSize = 0;
            ButtonAddFasilitasGym.FlatStyle = FlatStyle.Flat;
            ButtonAddFasilitasGym.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonAddFasilitasGym.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonAddFasilitasGym.Location = new Point(815, 32);
            ButtonAddFasilitasGym.Margin = new Padding(3, 4, 3, 4);
            ButtonAddFasilitasGym.Name = "ButtonAddFasilitasGym";
            ButtonAddFasilitasGym.Size = new Size(49, 40);
            ButtonAddFasilitasGym.TabIndex = 1;
            ButtonAddFasilitasGym.Text = "Add";
            ButtonAddFasilitasGym.UseVisualStyleBackColor = true;
            ButtonAddFasilitasGym.Click += ButtonAddFasilitasGym_Click;
            // 
            // ButtonChange
            // 
            ButtonChange.BackColor = Color.FromArgb(127, 200, 248);
            ButtonChange.FlatAppearance.BorderSize = 0;
            ButtonChange.FlatStyle = FlatStyle.Flat;
            ButtonChange.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonChange.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonChange.Location = new Point(725, 32);
            ButtonChange.Margin = new Padding(3, 4, 3, 4);
            ButtonChange.Name = "ButtonChange";
            ButtonChange.Size = new Size(83, 40);
            ButtonChange.TabIndex = 2;
            ButtonChange.Text = "Change";
            ButtonChange.UseVisualStyleBackColor = true;
            ButtonChange.Click += ButtonChange_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.BackColor = Color.FromArgb(127, 200, 248);
            ButtonDelete.FlatAppearance.BorderSize = 0;
            ButtonDelete.FlatStyle = FlatStyle.Flat;
            ButtonDelete.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonDelete.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonDelete.Location = new Point(648, 32);
            ButtonDelete.Margin = new Padding(3, 4, 3, 4);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(71, 40);
            ButtonDelete.TabIndex = 3;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // DataGridView_FasilitasGym
            // 
            DataGridView_FasilitasGym.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_FasilitasGym.Location = new Point(49, 108);
            DataGridView_FasilitasGym.Margin = new Padding(3, 4, 3, 4);
            DataGridView_FasilitasGym.Name = "DataGridView_FasilitasGym";
            DataGridView_FasilitasGym.RowHeadersWidth = 51;
            DataGridView_FasilitasGym.Size = new Size(811, 373);
            DataGridView_FasilitasGym.TabIndex = 4;
            // 
            // FasilitasGym
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 600);
            Controls.Add(DataGridView_FasilitasGym);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonChange);
            Controls.Add(ButtonAddFasilitasGym);
            Controls.Add(ButtonBack);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FasilitasGym";
            Text = "FasilitasGym";
            Load += FasilitasGym_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView_FasilitasGym).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonBack;
        private Button ButtonAddFasilitasGym;
        private Button ButtonChange;
        private Button ButtonDelete;
        private DataGridView DataGridView_FasilitasGym;
    }
}