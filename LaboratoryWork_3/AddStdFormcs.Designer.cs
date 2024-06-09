namespace LaboratoryWork_3
{
    partial class AddStdFormcs
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
            nameBox = new TextBox();
            contactBox = new TextBox();
            priorityBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // nameBox
            // 
            nameBox.Location = new Point(12, 33);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(263, 23);
            nameBox.TabIndex = 0;
            // 
            // contactBox
            // 
            contactBox.Location = new Point(12, 86);
            contactBox.Name = "contactBox";
            contactBox.Size = new Size(263, 23);
            contactBox.TabIndex = 1;
            // 
            // priorityBox
            // 
            priorityBox.Location = new Point(12, 149);
            priorityBox.Name = "priorityBox";
            priorityBox.Size = new Size(263, 23);
            priorityBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 3;
            label1.Text = "Name of student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 4;
            label2.Text = "Contact information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "Priority level";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(12, 197);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(263, 23);
            saveBtn.TabIndex = 6;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // AddStdFormcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 234);
            Controls.Add(saveBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(priorityBox);
            Controls.Add(contactBox);
            Controls.Add(nameBox);
            Name = "AddStdFormcs";
            Text = "AddStdFormcs";
            Load += AddStdFormcs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameBox;
        private TextBox contactBox;
        private TextBox priorityBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button saveBtn;
    }
}