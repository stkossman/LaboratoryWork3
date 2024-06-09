namespace LaboratoryWork_3
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
            studentsListView = new ListView();
            availablePlaces = new Label();
            occupiedPlaces = new Label();
            addStd = new Button();
            editStd = new Button();
            deleteStd = new Button();
            settleStd = new Button();
            settledStudentsListView = new ListView();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // studentsListView
            // 
            studentsListView.Location = new Point(12, 77);
            studentsListView.Name = "studentsListView";
            studentsListView.Size = new Size(489, 361);
            studentsListView.TabIndex = 0;
            studentsListView.UseCompatibleStateImageBehavior = false;
            // 
            // availablePlaces
            // 
            availablePlaces.AutoSize = true;
            availablePlaces.Location = new Point(853, 16);
            availablePlaces.Name = "availablePlaces";
            availablePlaces.Size = new Size(163, 15);
            availablePlaces.TabIndex = 1;
            availablePlaces.Text = "Available places in dormitory:";
            // 
            // occupiedPlaces
            // 
            occupiedPlaces.AutoSize = true;
            occupiedPlaces.Location = new Point(853, 45);
            occupiedPlaces.Name = "occupiedPlaces";
            occupiedPlaces.Size = new Size(166, 15);
            occupiedPlaces.TabIndex = 2;
            occupiedPlaces.Text = "Occupied places in dormitory:";
            // 
            // addStd
            // 
            addStd.Location = new Point(12, 12);
            addStd.Name = "addStd";
            addStd.Size = new Size(250, 23);
            addStd.TabIndex = 3;
            addStd.Text = "Add student";
            addStd.UseVisualStyleBackColor = true;
            addStd.Click += addStd_Click;
            // 
            // editStd
            // 
            editStd.Location = new Point(268, 41);
            editStd.Name = "editStd";
            editStd.Size = new Size(233, 23);
            editStd.TabIndex = 4;
            editStd.Text = "Edit student";
            editStd.UseVisualStyleBackColor = true;
            editStd.Click += editStd_Click;
            // 
            // deleteStd
            // 
            deleteStd.Location = new Point(268, 12);
            deleteStd.Name = "deleteStd";
            deleteStd.Size = new Size(233, 23);
            deleteStd.TabIndex = 5;
            deleteStd.Text = "Delete student";
            deleteStd.UseVisualStyleBackColor = true;
            deleteStd.Click += deleteStd_Click;
            // 
            // settleStd
            // 
            settleStd.Location = new Point(507, 223);
            settleStd.Name = "settleStd";
            settleStd.Size = new Size(80, 41);
            settleStd.TabIndex = 6;
            settleStd.Text = "Settle student";
            settleStd.UseVisualStyleBackColor = true;
            settleStd.Click += settleStd_Click;
            // 
            // settledStudentsListView
            // 
            settledStudentsListView.Location = new Point(593, 77);
            settledStudentsListView.Name = "settledStudentsListView";
            settledStudentsListView.Size = new Size(489, 361);
            settledStudentsListView.TabIndex = 7;
            settledStudentsListView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(593, 45);
            label1.Name = "label1";
            label1.Size = new Size(197, 23);
            label1.TabIndex = 8;
            label1.Text = "Settled students:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(213, 23);
            label2.TabIndex = 9;
            label2.Text = "Students to settle:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(settledStudentsListView);
            Controls.Add(settleStd);
            Controls.Add(deleteStd);
            Controls.Add(editStd);
            Controls.Add(addStd);
            Controls.Add(occupiedPlaces);
            Controls.Add(availablePlaces);
            Controls.Add(studentsListView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView studentsListView;
        private Label availablePlaces;
        private Label occupiedPlaces;
        private Button addStd;
        private Button editStd;
        private Button deleteStd;
        private Button settleStd;
        private ListView settledStudentsListView;
        private Label label1;
        private Label label2;
    }
}
