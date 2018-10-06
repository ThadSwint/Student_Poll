namespace StudentPoll
{
   partial class StudentPollForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(66, 86);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ShortcutsEnabled = false;
            this.inputTextBox.Size = new System.Drawing.Size(100, 27);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
            this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter an integer result (1 - 10) and press Enter:";
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(66, 174);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Size = new System.Drawing.Size(205, 229);
            this.displayTextBox.TabIndex = 5;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(252, 135);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(118, 33);
            this.doneButton.TabIndex = 6;
            this.doneButton.Text = "Done";
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click_1);
            // 
            // displayButton
            // 
            this.displayButton.Enabled = false;
            this.displayButton.Location = new System.Drawing.Point(66, 135);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(100, 33);
            this.displayButton.TabIndex = 7;
            this.displayButton.Text = "display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // StudentPollForm
            // 
            this.ClientSize = new System.Drawing.Size(382, 438);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StudentPollForm";
            this.Text = "Student Poll";
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.TextBox inputTextBox;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button displayButton;
    }

}