﻿namespace Reed_Muller_marijuslau
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
            this.bitStringCoding = new System.Windows.Forms.GroupBox();
            this.BitFalseBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BitDecodedVectorBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BitTransmittedVectorBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BitCodedVectorBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bitInputGroup = new System.Windows.Forms.GroupBox();
            this.BitDecodeButton = new System.Windows.Forms.Button();
            this.bitEncodeButton = new System.Windows.Forms.Button();
            this.bitStringInputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bitQInputBox = new System.Windows.Forms.TextBox();
            this.bitRInputBox = new System.Windows.Forms.TextBox();
            this.bitMInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bitParamsLabel = new System.Windows.Forms.Label();
            this.bitStringCoding.SuspendLayout();
            this.bitInputGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // bitStringCoding
            // 
            this.bitStringCoding.Controls.Add(this.BitFalseBox);
            this.bitStringCoding.Controls.Add(this.label6);
            this.bitStringCoding.Controls.Add(this.BitDecodedVectorBox);
            this.bitStringCoding.Controls.Add(this.label5);
            this.bitStringCoding.Controls.Add(this.BitTransmittedVectorBox);
            this.bitStringCoding.Controls.Add(this.label4);
            this.bitStringCoding.Controls.Add(this.BitCodedVectorBox);
            this.bitStringCoding.Controls.Add(this.label3);
            this.bitStringCoding.Controls.Add(this.bitInputGroup);
            this.bitStringCoding.Location = new System.Drawing.Point(13, 13);
            this.bitStringCoding.Name = "bitStringCoding";
            this.bitStringCoding.Size = new System.Drawing.Size(1336, 517);
            this.bitStringCoding.TabIndex = 0;
            this.bitStringCoding.TabStop = false;
            this.bitStringCoding.Text = "Bitų kodavimas";
            // 
            // BitFalseBox
            // 
            this.BitFalseBox.Location = new System.Drawing.Point(814, 338);
            this.BitFalseBox.Multiline = true;
            this.BitFalseBox.Name = "BitFalseBox";
            this.BitFalseBox.Size = new System.Drawing.Size(516, 143);
            this.BitFalseBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(809, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Klaidos:";
            // 
            // BitDecodedVectorBox
            // 
            this.BitDecodedVectorBox.Location = new System.Drawing.Point(814, 86);
            this.BitDecodedVectorBox.Multiline = true;
            this.BitDecodedVectorBox.Name = "BitDecodedVectorBox";
            this.BitDecodedVectorBox.Size = new System.Drawing.Size(516, 143);
            this.BitDecodedVectorBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(814, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dekoduotas vektorius:";
            // 
            // BitTransmittedVectorBox
            // 
            this.BitTransmittedVectorBox.Location = new System.Drawing.Point(330, 338);
            this.BitTransmittedVectorBox.Multiline = true;
            this.BitTransmittedVectorBox.Name = "BitTransmittedVectorBox";
            this.BitTransmittedVectorBox.Size = new System.Drawing.Size(478, 143);
            this.BitTransmittedVectorBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Iš kanalo išėjęs vektorius:";
            // 
            // BitCodedVectorBox
            // 
            this.BitCodedVectorBox.Location = new System.Drawing.Point(330, 86);
            this.BitCodedVectorBox.Multiline = true;
            this.BitCodedVectorBox.Name = "BitCodedVectorBox";
            this.BitCodedVectorBox.Size = new System.Drawing.Size(478, 143);
            this.BitCodedVectorBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Užkoduotas vektorius:";
            // 
            // bitInputGroup
            // 
            this.bitInputGroup.Controls.Add(this.BitDecodeButton);
            this.bitInputGroup.Controls.Add(this.bitEncodeButton);
            this.bitInputGroup.Controls.Add(this.bitStringInputBox);
            this.bitInputGroup.Controls.Add(this.label2);
            this.bitInputGroup.Controls.Add(this.bitQInputBox);
            this.bitInputGroup.Controls.Add(this.bitRInputBox);
            this.bitInputGroup.Controls.Add(this.bitMInputBox);
            this.bitInputGroup.Controls.Add(this.label1);
            this.bitInputGroup.Controls.Add(this.bitParamsLabel);
            this.bitInputGroup.Location = new System.Drawing.Point(6, 58);
            this.bitInputGroup.Name = "bitInputGroup";
            this.bitInputGroup.Size = new System.Drawing.Size(312, 453);
            this.bitInputGroup.TabIndex = 0;
            this.bitInputGroup.TabStop = false;
            this.bitInputGroup.Text = "Įvestis";
            // 
            // BitDecodeButton
            // 
            this.BitDecodeButton.Location = new System.Drawing.Point(6, 345);
            this.BitDecodeButton.Name = "BitDecodeButton";
            this.BitDecodeButton.Size = new System.Drawing.Size(300, 88);
            this.BitDecodeButton.TabIndex = 8;
            this.BitDecodeButton.Text = "Dekoduoti";
            this.BitDecodeButton.UseVisualStyleBackColor = true;
            // 
            // bitEncodeButton
            // 
            this.bitEncodeButton.Location = new System.Drawing.Point(6, 251);
            this.bitEncodeButton.Name = "bitEncodeButton";
            this.bitEncodeButton.Size = new System.Drawing.Size(300, 88);
            this.bitEncodeButton.TabIndex = 7;
            this.bitEncodeButton.Text = "Koduoti";
            this.bitEncodeButton.UseVisualStyleBackColor = true;
            this.bitEncodeButton.Click += new System.EventHandler(this.bitEncodeButton_Click);
            // 
            // bitStringInputBox
            // 
            this.bitStringInputBox.Location = new System.Drawing.Point(6, 89);
            this.bitStringInputBox.Multiline = true;
            this.bitStringInputBox.Name = "bitStringInputBox";
            this.bitStringInputBox.Size = new System.Drawing.Size(299, 143);
            this.bitStringInputBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bitų eilutė:";
            // 
            // bitQInputBox
            // 
            this.bitQInputBox.Location = new System.Drawing.Point(235, 18);
            this.bitQInputBox.Name = "bitQInputBox";
            this.bitQInputBox.Size = new System.Drawing.Size(66, 31);
            this.bitQInputBox.TabIndex = 4;
            // 
            // bitRInputBox
            // 
            this.bitRInputBox.Location = new System.Drawing.Point(163, 18);
            this.bitRInputBox.Name = "bitRInputBox";
            this.bitRInputBox.Size = new System.Drawing.Size(66, 31);
            this.bitRInputBox.TabIndex = 3;
            // 
            // bitMInputBox
            // 
            this.bitMInputBox.Location = new System.Drawing.Point(91, 18);
            this.bitMInputBox.Name = "bitMInputBox";
            this.bitMInputBox.Size = new System.Drawing.Size(66, 31);
            this.bitMInputBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            // 
            // bitParamsLabel
            // 
            this.bitParamsLabel.AutoSize = true;
            this.bitParamsLabel.Location = new System.Drawing.Point(6, 27);
            this.bitParamsLabel.Name = "bitParamsLabel";
            this.bitParamsLabel.Size = new System.Drawing.Size(78, 25);
            this.bitParamsLabel.TabIndex = 0;
            this.bitParamsLabel.Text = "m, r, q:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 541);
            this.Controls.Add(this.bitStringCoding);
            this.Name = "MainForm";
            this.Text = "Reed-Muller kodavimas, siuntimas kanalu ir dekodavimas";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.bitStringCoding.ResumeLayout(false);
            this.bitStringCoding.PerformLayout();
            this.bitInputGroup.ResumeLayout(false);
            this.bitInputGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bitStringCoding;
        private System.Windows.Forms.GroupBox bitInputGroup;
        private System.Windows.Forms.Label bitParamsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BitFalseBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BitDecodedVectorBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BitTransmittedVectorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BitCodedVectorBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BitDecodeButton;
        private System.Windows.Forms.Button bitEncodeButton;
        private System.Windows.Forms.TextBox bitStringInputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bitQInputBox;
        private System.Windows.Forms.TextBox bitRInputBox;
        private System.Windows.Forms.TextBox bitMInputBox;
    }
}

