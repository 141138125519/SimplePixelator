
namespace Pixelator
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
            System.Windows.Forms.Button loadImageUrlButton;
            System.Windows.Forms.Button button1;
            this.originalImageBox = new System.Windows.Forms.PictureBox();
            this.pixelateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.urlImageSourceInput = new System.Windows.Forms.TextBox();
            this.pixelateSizeInput = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.pixelSizeLabel = new System.Windows.Forms.Label();
            loadImageUrlButton = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadImageUrlButton
            // 
            loadImageUrlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            loadImageUrlButton.Location = new System.Drawing.Point(1682, 1131);
            loadImageUrlButton.Name = "loadImageUrlButton";
            loadImageUrlButton.Size = new System.Drawing.Size(250, 52);
            loadImageUrlButton.TabIndex = 4;
            loadImageUrlButton.Tag = "url";
            loadImageUrlButton.Text = "Load Image From Url";
            loadImageUrlButton.UseVisualStyleBackColor = true;
            loadImageUrlButton.Click += new System.EventHandler(this.LoadFromUrl);
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.Location = new System.Drawing.Point(1632, 1195);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(300, 52);
            button1.TabIndex = 8;
            button1.Tag = "file";
            button1.Text = "Load Image From File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.LoadFromFile);
            // 
            // originalImageBox
            // 
            this.originalImageBox.Location = new System.Drawing.Point(12, 12);
            this.originalImageBox.Name = "originalImageBox";
            this.originalImageBox.Size = new System.Drawing.Size(1920, 1108);
            this.originalImageBox.TabIndex = 0;
            this.originalImageBox.TabStop = false;
            // 
            // pixelateButton
            // 
            this.pixelateButton.Enabled = false;
            this.pixelateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pixelateButton.Location = new System.Drawing.Point(1320, 1195);
            this.pixelateButton.Name = "pixelateButton";
            this.pixelateButton.Size = new System.Drawing.Size(150, 52);
            this.pixelateButton.TabIndex = 2;
            this.pixelateButton.Text = "Pixelate";
            this.pixelateButton.UseVisualStyleBackColor = true;
            this.pixelateButton.Click += new System.EventHandler(this.pixelateImage);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(1476, 1195);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 52);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SavePixelated);
            // 
            // urlImageSourceInput
            // 
            this.urlImageSourceInput.Location = new System.Drawing.Point(51, 1144);
            this.urlImageSourceInput.Name = "urlImageSourceInput";
            this.urlImageSourceInput.Size = new System.Drawing.Size(1588, 26);
            this.urlImageSourceInput.TabIndex = 5;
            // 
            // pixelateSizeInput
            // 
            this.pixelateSizeInput.Location = new System.Drawing.Point(1214, 1208);
            this.pixelateSizeInput.Name = "pixelateSizeInput";
            this.pixelateSizeInput.Size = new System.Drawing.Size(100, 26);
            this.pixelateSizeInput.TabIndex = 9;
            this.pixelateSizeInput.Text = "32";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(12, 1147);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(33, 20);
            this.urlLabel.TabIndex = 10;
            this.urlLabel.Text = "Url:";
            // 
            // pixelSizeLabel
            // 
            this.pixelSizeLabel.AutoSize = true;
            this.pixelSizeLabel.Location = new System.Drawing.Point(1128, 1211);
            this.pixelSizeLabel.Name = "pixelSizeLabel";
            this.pixelSizeLabel.Size = new System.Drawing.Size(80, 20);
            this.pixelSizeLabel.TabIndex = 11;
            this.pixelSizeLabel.Text = "Pixel Size:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1947, 1575);
            this.Controls.Add(this.pixelSizeLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.pixelateSizeInput);
            this.Controls.Add(button1);
            this.Controls.Add(this.urlImageSourceInput);
            this.Controls.Add(loadImageUrlButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pixelateButton);
            this.Controls.Add(this.originalImageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originalImageBox;
        private System.Windows.Forms.PictureBox pixelatedImage;
        private System.Windows.Forms.Button pixelateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox urlImageSourceInput;
        private System.Windows.Forms.TextBox pixelateSizeInput;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label pixelSizeLabel;
    }
}

