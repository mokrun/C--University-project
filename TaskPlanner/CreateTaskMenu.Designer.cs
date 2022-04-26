
namespace TaskPlanner
{
    partial class CreateTaskMenu
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
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.DuedateTextbox = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelDescr = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(12, 45);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(115, 20);
            this.NameTextbox.TabIndex = 1;
            // 
            // DescriptionTextbox
            // 
            this.DescriptionTextbox.Location = new System.Drawing.Point(133, 45);
            this.DescriptionTextbox.Name = "DescriptionTextbox";
            this.DescriptionTextbox.Size = new System.Drawing.Size(339, 20);
            this.DescriptionTextbox.TabIndex = 2;
            // 
            // DuedateTextbox
            // 
            this.DuedateTextbox.Location = new System.Drawing.Point(478, 45);
            this.DuedateTextbox.Name = "DuedateTextbox";
            this.DuedateTextbox.Size = new System.Drawing.Size(100, 20);
            this.DuedateTextbox.TabIndex = 3;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(9, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(60, 13);
            this.LabelName.TabIndex = 4;
            this.LabelName.Text = "Task name";
            // 
            // LabelDescr
            // 
            this.LabelDescr.AutoSize = true;
            this.LabelDescr.Location = new System.Drawing.Point(130, 9);
            this.LabelDescr.Name = "LabelDescr";
            this.LabelDescr.Size = new System.Drawing.Size(85, 13);
            this.LabelDescr.TabIndex = 5;
            this.LabelDescr.Text = "Task description";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(475, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(51, 13);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Due date";
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(259, 88);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreate.TabIndex = 7;
            this.ButtonCreate.Text = "Create task";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // CreateTaskMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 123);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabelDescr);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.DuedateTextbox);
            this.Controls.Add(this.DescriptionTextbox);
            this.Controls.Add(this.NameTextbox);
            this.MaximizeBox = false;
            this.Name = "CreateTaskMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox DescriptionTextbox;
        private System.Windows.Forms.TextBox DuedateTextbox;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelDescr;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button ButtonCreate;
    }
}