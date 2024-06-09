namespace LaboratoryWork_3
{
    partial class EditStdForm
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
            saveBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // nameBox
            // 
            nameBox.Location = new Point(12, 46);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(265, 23);
            nameBox.TabIndex = 0;
            // 
            // contactBox
            // 
            contactBox.Location = new Point(12, 100);
            contactBox.Name = "contactBox";
            contactBox.Size = new Size(265, 23);
            contactBox.TabIndex = 1;
            // 
            // priorityBox
            // 
            priorityBox.Location = new Point(12, 154);
            priorityBox.Name = "priorityBox";
            priorityBox.Size = new Size(265, 23);
            priorityBox.TabIndex = 2;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(12, 201);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(265, 23);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 4;
            label1.Text = "Student's name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 5;
            label2.Text = "Contact info";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 6;
            label3.Text = "Priority level";
            // 
            // EditStdForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 252);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(saveBtn);
            Controls.Add(priorityBox);
            Controls.Add(contactBox);
            Controls.Add(nameBox);
            Name = "EditStdForm";
            Text = "EditStdForm";
            Load += EditStdForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameBox;
        private TextBox contactBox;
        private TextBox priorityBox;
        private Button saveBtn;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}