namespace CS3020
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            txtNewTask = new TextBox();
            clbTasks = new CheckedListBox();
            btnRemove = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(437, 186);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Task";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtNewTask
            // 
            txtNewTask.Location = new Point(552, 186);
            txtNewTask.Name = "txtNewTask";
            txtNewTask.Size = new Size(125, 27);
            txtNewTask.TabIndex = 2;
            txtNewTask.KeyPress += txtNewTask_KeyPress;
            // 
            // clbTasks
            // 
            clbTasks.FormattingEnabled = true;
            clbTasks.Location = new Point(167, 139);
            clbTasks.Name = "clbTasks";
            clbTasks.Size = new Size(150, 114);
            clbTasks.TabIndex = 3;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(191, 269);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove Task";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 49);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 5;
            label1.Text = "Anthony's Todo App";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 520);
            Controls.Add(label1);
            Controls.Add(btnRemove);
            Controls.Add(clbTasks);
            Controls.Add(txtNewTask);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtNewTask;
        private CheckedListBox clbTasks;
        private Button btnRemove;
        private Label label1;
    }
}
