
namespace Assesmenthasankaraduman
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.regular = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.Button();
            this.degistir = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dosya_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.esc = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(475, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(475, 374);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(313, 35);
            this.textBox2.TabIndex = 2;
            this.textBox2.Visible = false;
            // 
            // regular
            // 
            this.regular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.regular.Location = new System.Drawing.Point(475, 229);
            this.regular.Name = "regular";
            this.regular.Size = new System.Drawing.Size(313, 46);
            this.regular.TabIndex = 3;
            this.regular.Text = "Regular Tanımla";
            this.regular.UseVisualStyleBackColor = true;
            this.regular.Visible = false;
            this.regular.Click += new System.EventHandler(this.regular_Click);
            // 
            // ara
            // 
            this.ara.Location = new System.Drawing.Point(475, 302);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(313, 46);
            this.ara.TabIndex = 7;
            this.ara.Text = "Ara";
            this.ara.UseVisualStyleBackColor = true;
            this.ara.Visible = false;
            this.ara.Click += new System.EventHandler(this.ara_Click);
            // 
            // degistir
            // 
            this.degistir.Location = new System.Drawing.Point(475, 440);
            this.degistir.Name = "degistir";
            this.degistir.Size = new System.Drawing.Size(313, 46);
            this.degistir.TabIndex = 9;
            this.degistir.Text = "Değiştir";
            this.degistir.UseVisualStyleBackColor = true;
            this.degistir.Visible = false;
            this.degistir.Click += new System.EventHandler(this.degistir_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(475, 508);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(313, 35);
            this.textBox3.TabIndex = 10;
            this.textBox3.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(457, 719);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8127, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(5697, 12299);
            this.button1.TabIndex = 14;
            this.button1.Text = "Arama Yapmak İçin =>F\r\nDeğiştirme Yapmak İçin =>R\r\nSilme Yapmak İçin=>D\r\n\r\n";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dosya_text
            // 
            this.dosya_text.Location = new System.Drawing.Point(475, 25);
            this.dosya_text.Name = "dosya_text";
            this.dosya_text.Size = new System.Drawing.Size(313, 26);
            this.dosya_text.TabIndex = 15;
            this.dosya_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dosya_text_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 40);
            this.label1.TabIndex = 17;
            this.label1.Text = "Dosya ismini girip Entera basınız\r\nÖrneğin  =>radar";
            // 
            // esc
            // 
            this.esc.Location = new System.Drawing.Point(595, 652);
            this.esc.Name = "esc";
            this.esc.Size = new System.Drawing.Size(75, 63);
            this.esc.TabIndex = 18;
            this.esc.Text = "Çıkış";
            this.esc.UseVisualStyleBackColor = true;
            this.esc.Visible = false;
            this.esc.Click += new System.EventHandler(this.esc_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(475, 571);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(313, 38);
            this.sil.TabIndex = 19;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Visible = false;
            this.sil.Click += new System.EventHandler(this.sil_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 786);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.esc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dosya_text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.degistir);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.regular);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button regular;
        private System.Windows.Forms.Button ara;
        private System.Windows.Forms.Button degistir;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dosya_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button esc;
        private System.Windows.Forms.Button sil;
    }
}

