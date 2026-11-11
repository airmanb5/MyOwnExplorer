namespace MyExplorer
{
    partial class FormOptions
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
            radioButtonList = new RadioButton();
            radioButtonIcons = new RadioButton();
            buttonConfirm = new Button();
            buttonCancel = new Button();
            textBoxFileDisplayOptions = new TextBox();
            SuspendLayout();
            // 
            // radioButtonList
            // 
            radioButtonList.AutoSize = true;
            radioButtonList.Location = new Point(322, 177);
            radioButtonList.Name = "radioButtonList";
            radioButtonList.Size = new Size(63, 29);
            radioButtonList.TabIndex = 0;
            radioButtonList.TabStop = true;
            radioButtonList.Text = "List";
            radioButtonList.UseVisualStyleBackColor = true;
            radioButtonList.CheckedChanged += radioButtonList_CheckedChanged;
            // 
            // radioButtonIcons
            // 
            radioButtonIcons.AutoSize = true;
            radioButtonIcons.Location = new Point(322, 212);
            radioButtonIcons.Name = "radioButtonIcons";
            radioButtonIcons.Size = new Size(79, 29);
            radioButtonIcons.TabIndex = 1;
            radioButtonIcons.TabStop = true;
            radioButtonIcons.Text = "Icons\r\n";
            radioButtonIcons.UseVisualStyleBackColor = true;
            radioButtonIcons.CheckedChanged += radioButtonIcons_CheckedChanged;
            // 
            // buttonConfirm
            // 
            buttonConfirm.DialogResult = DialogResult.OK;
            buttonConfirm.Location = new Point(273, 380);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(112, 34);
            buttonConfirm.TabIndex = 2;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(443, 380);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxFileDisplayOptions
            // 
            textBoxFileDisplayOptions.Enabled = false;
            textBoxFileDisplayOptions.Location = new Point(322, 131);
            textBoxFileDisplayOptions.Name = "textBoxFileDisplayOptions";
            textBoxFileDisplayOptions.Size = new Size(150, 31);
            textBoxFileDisplayOptions.TabIndex = 4;
            textBoxFileDisplayOptions.Text = "File Display Type:";
            textBoxFileDisplayOptions.TextChanged += textBox1_TextChanged;
            // 
            // FormOptions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxFileDisplayOptions);
            Controls.Add(buttonCancel);
            Controls.Add(buttonConfirm);
            Controls.Add(radioButtonIcons);
            Controls.Add(radioButtonList);
            Name = "FormOptions";
            Text = "FormOptions";
            Load += FormOptions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonList;
        private RadioButton radioButtonIcons;
        private Button buttonConfirm;
        private Button buttonCancel;
        private TextBox textBoxFileDisplayOptions;
    }
}