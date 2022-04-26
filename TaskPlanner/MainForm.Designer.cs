
namespace TaskPlanner
{
    partial class MainForm
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
            this.CreateGlobalbutton = new System.Windows.Forms.Button();
            this.CreateGroupbutton = new System.Windows.Forms.Button();
            this.CreatePersonalbutton = new System.Windows.Forms.Button();
            this.DataGridViewMain = new System.Windows.Forms.DataGridView();
            this.CreateKidTaskButton = new System.Windows.Forms.Button();
            this.MarkdoneButton = new System.Windows.Forms.Button();
            this.DonetaskTextBox = new System.Windows.Forms.TextBox();
            this.DonetaskLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateGlobalbutton
            // 
            this.CreateGlobalbutton.Location = new System.Drawing.Point(12, 12);
            this.CreateGlobalbutton.Name = "CreateGlobalbutton";
            this.CreateGlobalbutton.Size = new System.Drawing.Size(128, 23);
            this.CreateGlobalbutton.TabIndex = 0;
            this.CreateGlobalbutton.Text = "Create global task";
            this.CreateGlobalbutton.UseVisualStyleBackColor = true;
            this.CreateGlobalbutton.Click += new System.EventHandler(this.createGlobalbutton_Click);
            // 
            // CreateGroupbutton
            // 
            this.CreateGroupbutton.Location = new System.Drawing.Point(12, 41);
            this.CreateGroupbutton.Name = "CreateGroupbutton";
            this.CreateGroupbutton.Size = new System.Drawing.Size(128, 23);
            this.CreateGroupbutton.TabIndex = 1;
            this.CreateGroupbutton.Text = "Create group task";
            this.CreateGroupbutton.UseVisualStyleBackColor = true;
            this.CreateGroupbutton.Click += new System.EventHandler(this.createGroupbutton_Click);
            // 
            // CreatePersonalbutton
            // 
            this.CreatePersonalbutton.Location = new System.Drawing.Point(12, 70);
            this.CreatePersonalbutton.Name = "CreatePersonalbutton";
            this.CreatePersonalbutton.Size = new System.Drawing.Size(128, 23);
            this.CreatePersonalbutton.TabIndex = 2;
            this.CreatePersonalbutton.Text = "Create personal task";
            this.CreatePersonalbutton.UseVisualStyleBackColor = true;
            this.CreatePersonalbutton.Click += new System.EventHandler(this.createPersonalbutton_Click);
            // 
            // DataGridViewMain
            // 
            this.DataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMain.Location = new System.Drawing.Point(146, 12);
            this.DataGridViewMain.Name = "DataGridViewMain";
            this.DataGridViewMain.Size = new System.Drawing.Size(746, 441);
            this.DataGridViewMain.TabIndex = 3;
            // 
            // CreateKidTaskButton
            // 
            this.CreateKidTaskButton.Location = new System.Drawing.Point(12, 115);
            this.CreateKidTaskButton.Name = "CreateKidTaskButton";
            this.CreateKidTaskButton.Size = new System.Drawing.Size(128, 23);
            this.CreateKidTaskButton.TabIndex = 4;
            this.CreateKidTaskButton.Text = "Create a task for kids";
            this.CreateKidTaskButton.UseVisualStyleBackColor = true;
            this.CreateKidTaskButton.Click += new System.EventHandler(this.createKidTaskButton_Click);
            // 
            // MarkdoneButton
            // 
            this.MarkdoneButton.Location = new System.Drawing.Point(12, 229);
            this.MarkdoneButton.Name = "MarkdoneButton";
            this.MarkdoneButton.Size = new System.Drawing.Size(128, 23);
            this.MarkdoneButton.TabIndex = 5;
            this.MarkdoneButton.Text = "Mark \"Done\"";
            this.MarkdoneButton.UseVisualStyleBackColor = true;
            this.MarkdoneButton.Click += new System.EventHandler(this.markdoneButton_Click);
            // 
            // DonetaskTextBox
            // 
            this.DonetaskTextBox.Location = new System.Drawing.Point(13, 203);
            this.DonetaskTextBox.Name = "DonetaskTextBox";
            this.DonetaskTextBox.Size = new System.Drawing.Size(127, 20);
            this.DonetaskTextBox.TabIndex = 6;
            // 
            // DonetaskLabel
            // 
            this.DonetaskLabel.AutoSize = true;
            this.DonetaskLabel.Location = new System.Drawing.Point(-1, 187);
            this.DonetaskLabel.Name = "DonetaskLabel";
            this.DonetaskLabel.Size = new System.Drawing.Size(135, 13);
            this.DonetaskLabel.TabIndex = 7;
            this.DonetaskLabel.Text = "Enter a part of task to hide:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 465);
            this.Controls.Add(this.DonetaskLabel);
            this.Controls.Add(this.DonetaskTextBox);
            this.Controls.Add(this.MarkdoneButton);
            this.Controls.Add(this.CreateKidTaskButton);
            this.Controls.Add(this.DataGridViewMain);
            this.Controls.Add(this.CreatePersonalbutton);
            this.Controls.Add(this.CreateGroupbutton);
            this.Controls.Add(this.CreateGlobalbutton);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Task Planner";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateGlobalbutton;
        private System.Windows.Forms.Button CreateGroupbutton;
        private System.Windows.Forms.Button CreatePersonalbutton;
        private System.Windows.Forms.DataGridView DataGridViewMain;
        private System.Windows.Forms.Button CreateKidTaskButton;
        private System.Windows.Forms.Button MarkdoneButton;
        private System.Windows.Forms.TextBox DonetaskTextBox;
        private System.Windows.Forms.Label DonetaskLabel;
    }
}

