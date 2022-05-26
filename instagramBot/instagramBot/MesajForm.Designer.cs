
namespace instagramBot
{
    partial class MesajForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnTMesajAt = new System.Windows.Forms.Button();
            this.btnBMesajAt = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnTakipciListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "MESAJ METNİ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(19, 180);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(236, 117);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnTMesajAt
            // 
            this.btnTMesajAt.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTMesajAt.Location = new System.Drawing.Point(278, 192);
            this.btnTMesajAt.Name = "btnTMesajAt";
            this.btnTMesajAt.Size = new System.Drawing.Size(154, 48);
            this.btnTMesajAt.TabIndex = 2;
            this.btnTMesajAt.Text = "Takipçilere Mesaj At";
            this.btnTMesajAt.UseVisualStyleBackColor = true;
            this.btnTMesajAt.Click += new System.EventHandler(this.btnTMesajAt_Click);
            // 
            // btnBMesajAt
            // 
            this.btnBMesajAt.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBMesajAt.Location = new System.Drawing.Point(278, 246);
            this.btnBMesajAt.Name = "btnBMesajAt";
            this.btnBMesajAt.Size = new System.Drawing.Size(154, 48);
            this.btnBMesajAt.TabIndex = 3;
            this.btnBMesajAt.Text = "Beğenenlere Mesaj At";
            this.btnBMesajAt.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(19, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(236, 125);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // btnTakipciListele
            // 
            this.btnTakipciListele.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTakipciListele.Location = new System.Drawing.Point(278, 40);
            this.btnTakipciListele.Name = "btnTakipciListele";
            this.btnTakipciListele.Size = new System.Drawing.Size(154, 48);
            this.btnTakipciListele.TabIndex = 5;
            this.btnTakipciListele.Text = "Takipçileri Listele";
            this.btnTakipciListele.UseVisualStyleBackColor = true;
            this.btnTakipciListele.Click += new System.EventHandler(this.btnTakipciListele_Click);
            // 
            // MesajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTakipciListele);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.btnBMesajAt);
            this.Controls.Add(this.btnTMesajAt);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MesajForm";
            this.Text = "MesajForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnTMesajAt;
        private System.Windows.Forms.Button btnBMesajAt;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btnTakipciListele;
    }
}