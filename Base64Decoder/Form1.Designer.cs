namespace Base64Decoder
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encodedTextBox = new System.Windows.Forms.TextBox();
            this.decodedTextBox = new System.Windows.Forms.TextBox();
            this.decodeBtn = new System.Windows.Forms.Button();
            this.encodeBtn = new System.Windows.Forms.Button();
            this.copyDecodeBtn = new System.Windows.Forms.Button();
            this.encodeCopyBtn = new System.Windows.Forms.Button();
            this.openHttpBtn = new System.Windows.Forms.Button();
            this.encodedPasteBtn = new System.Windows.Forms.Button();
            this.decodedPasteBtn = new System.Windows.Forms.Button();
            this.clearEncodeBtn = new System.Windows.Forms.Button();
            this.clearDecodeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encoded:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Decoded:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // encodedTextBox
            // 
            this.encodedTextBox.Location = new System.Drawing.Point(126, 48);
            this.encodedTextBox.Name = "encodedTextBox";
            this.encodedTextBox.Size = new System.Drawing.Size(563, 22);
            this.encodedTextBox.TabIndex = 2;
            // 
            // decodedTextBox
            // 
            this.decodedTextBox.Location = new System.Drawing.Point(126, 125);
            this.decodedTextBox.Name = "decodedTextBox";
            this.decodedTextBox.Size = new System.Drawing.Size(563, 22);
            this.decodedTextBox.TabIndex = 3;
            // 
            // decodeBtn
            // 
            this.decodeBtn.Location = new System.Drawing.Point(205, 85);
            this.decodeBtn.Name = "decodeBtn";
            this.decodeBtn.Size = new System.Drawing.Size(75, 23);
            this.decodeBtn.TabIndex = 4;
            this.decodeBtn.Text = "Decode";
            this.decodeBtn.UseVisualStyleBackColor = true;
            this.decodeBtn.Click += new System.EventHandler(this.decodeBtn_Click);
            // 
            // encodeBtn
            // 
            this.encodeBtn.Location = new System.Drawing.Point(449, 85);
            this.encodeBtn.Name = "encodeBtn";
            this.encodeBtn.Size = new System.Drawing.Size(75, 23);
            this.encodeBtn.TabIndex = 5;
            this.encodeBtn.Text = "Encode";
            this.encodeBtn.UseVisualStyleBackColor = true;
            this.encodeBtn.Click += new System.EventHandler(this.encodeBtn_Click);
            // 
            // copyDecodeBtn
            // 
            this.copyDecodeBtn.Location = new System.Drawing.Point(695, 125);
            this.copyDecodeBtn.Name = "copyDecodeBtn";
            this.copyDecodeBtn.Size = new System.Drawing.Size(75, 23);
            this.copyDecodeBtn.TabIndex = 6;
            this.copyDecodeBtn.Text = "Copy";
            this.copyDecodeBtn.UseVisualStyleBackColor = true;
            this.copyDecodeBtn.Click += new System.EventHandler(this.copyDecodeBtn_Click);
            // 
            // encodeCopyBtn
            // 
            this.encodeCopyBtn.Location = new System.Drawing.Point(695, 48);
            this.encodeCopyBtn.Name = "encodeCopyBtn";
            this.encodeCopyBtn.Size = new System.Drawing.Size(75, 23);
            this.encodeCopyBtn.TabIndex = 7;
            this.encodeCopyBtn.Text = "Copy";
            this.encodeCopyBtn.UseVisualStyleBackColor = true;
            this.encodeCopyBtn.Click += new System.EventHandler(this.encodeCopyBtn_Click);
            // 
            // openHttpBtn
            // 
            this.openHttpBtn.Location = new System.Drawing.Point(695, 154);
            this.openHttpBtn.Name = "openHttpBtn";
            this.openHttpBtn.Size = new System.Drawing.Size(156, 23);
            this.openHttpBtn.TabIndex = 8;
            this.openHttpBtn.Text = "Open";
            this.openHttpBtn.UseVisualStyleBackColor = true;
            this.openHttpBtn.Click += new System.EventHandler(this.openHttpBtn_Click);
            // 
            // encodedPasteBtn
            // 
            this.encodedPasteBtn.Location = new System.Drawing.Point(771, 48);
            this.encodedPasteBtn.Name = "encodedPasteBtn";
            this.encodedPasteBtn.Size = new System.Drawing.Size(75, 23);
            this.encodedPasteBtn.TabIndex = 9;
            this.encodedPasteBtn.Text = "Paste";
            this.encodedPasteBtn.UseVisualStyleBackColor = true;
            this.encodedPasteBtn.Click += new System.EventHandler(this.encodedPasteBtn_Click);
            // 
            // decodedPasteBtn
            // 
            this.decodedPasteBtn.Location = new System.Drawing.Point(776, 124);
            this.decodedPasteBtn.Name = "decodedPasteBtn";
            this.decodedPasteBtn.Size = new System.Drawing.Size(75, 23);
            this.decodedPasteBtn.TabIndex = 10;
            this.decodedPasteBtn.Text = "Paste";
            this.decodedPasteBtn.UseVisualStyleBackColor = true;
            this.decodedPasteBtn.Click += new System.EventHandler(this.decodedPasteBtn_Click);
            // 
            // clearEncodeBtn
            // 
            this.clearEncodeBtn.Location = new System.Drawing.Point(613, 77);
            this.clearEncodeBtn.Name = "clearEncodeBtn";
            this.clearEncodeBtn.Size = new System.Drawing.Size(75, 23);
            this.clearEncodeBtn.TabIndex = 11;
            this.clearEncodeBtn.Text = "Clear";
            this.clearEncodeBtn.UseVisualStyleBackColor = true;
            this.clearEncodeBtn.Click += new System.EventHandler(this.clearEncodeBtn_Click);
            // 
            // clearDecodeBtn
            // 
            this.clearDecodeBtn.Location = new System.Drawing.Point(613, 153);
            this.clearDecodeBtn.Name = "clearDecodeBtn";
            this.clearDecodeBtn.Size = new System.Drawing.Size(75, 23);
            this.clearDecodeBtn.TabIndex = 12;
            this.clearDecodeBtn.Text = "Clear";
            this.clearDecodeBtn.UseVisualStyleBackColor = true;
            this.clearDecodeBtn.Click += new System.EventHandler(this.clearDecodeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 198);
            this.Controls.Add(this.clearDecodeBtn);
            this.Controls.Add(this.clearEncodeBtn);
            this.Controls.Add(this.decodedPasteBtn);
            this.Controls.Add(this.encodedPasteBtn);
            this.Controls.Add(this.openHttpBtn);
            this.Controls.Add(this.encodeCopyBtn);
            this.Controls.Add(this.copyDecodeBtn);
            this.Controls.Add(this.encodeBtn);
            this.Controls.Add(this.decodeBtn);
            this.Controls.Add(this.decodedTextBox);
            this.Controls.Add(this.encodedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Base64";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox encodedTextBox;
        private System.Windows.Forms.TextBox decodedTextBox;
        private System.Windows.Forms.Button decodeBtn;
        private System.Windows.Forms.Button encodeBtn;
        private System.Windows.Forms.Button copyDecodeBtn;
        private System.Windows.Forms.Button encodeCopyBtn;
        private System.Windows.Forms.Button openHttpBtn;
        private System.Windows.Forms.Button encodedPasteBtn;
        private System.Windows.Forms.Button decodedPasteBtn;
        private System.Windows.Forms.Button clearEncodeBtn;
        private System.Windows.Forms.Button clearDecodeBtn;
    }
}

