namespace Messi_app
{
    partial class StarKiller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StarKiller));
            this.txtImg = new System.Windows.Forms.TextBox();
            this.PicPeque = new System.Windows.Forms.PictureBox();
            this.PicGeneral = new System.Windows.Forms.PictureBox();
            this.boto_return1 = new Messi_Control.Boto_return(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicPeque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImg
            // 
            this.txtImg.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtImg.Enabled = false;
            this.txtImg.Font = new System.Drawing.Font("ROG Fonts", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImg.ForeColor = System.Drawing.Color.White;
            this.txtImg.Location = new System.Drawing.Point(623, 69);
            this.txtImg.Name = "txtImg";
            this.txtImg.ReadOnly = true;
            this.txtImg.Size = new System.Drawing.Size(153, 22);
            this.txtImg.TabIndex = 4;
            this.txtImg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PicPeque
            // 
            this.PicPeque.BackColor = System.Drawing.Color.Transparent;
            this.PicPeque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicPeque.Location = new System.Drawing.Point(458, 24);
            this.PicPeque.Name = "PicPeque";
            this.PicPeque.Size = new System.Drawing.Size(159, 142);
            this.PicPeque.TabIndex = 3;
            this.PicPeque.TabStop = false;
            // 
            // PicGeneral
            // 
            this.PicGeneral.BackgroundImage = global::Messi_app.Properties.Resources.DSPlan1;
            this.PicGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicGeneral.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PicGeneral.Location = new System.Drawing.Point(12, 100);
            this.PicGeneral.Name = "PicGeneral";
            this.PicGeneral.Size = new System.Drawing.Size(440, 338);
            this.PicGeneral.TabIndex = 1;
            this.PicGeneral.TabStop = false;
            // 
            // boto_return1
            // 
            this.boto_return1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boto_return1.BackColor = System.Drawing.Color.Transparent;
            this.boto_return1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boto_return1.BackgroundImage")));
            this.boto_return1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boto_return1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boto_return1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boto_return1.ForeColor = System.Drawing.Color.Transparent;
            this.boto_return1.Location = new System.Drawing.Point(12, 12);
            this.boto_return1.Name = "boto_return1";
            this.boto_return1.Size = new System.Drawing.Size(50, 45);
            this.boto_return1.TabIndex = 0;
            this.boto_return1.TabStop = false;
            this.boto_return1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(330, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 114);
            this.panel1.TabIndex = 6;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel2
            // 
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(181, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 102);
            this.panel2.TabIndex = 7;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // panel3
            // 
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(12, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(67, 57);
            this.panel3.TabIndex = 8;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDesc.Enabled = false;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.ForeColor = System.Drawing.Color.Black;
            this.txtDesc.Location = new System.Drawing.Point(458, 172);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(330, 266);
            this.txtDesc.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "STAR KILLER";
            // 
            // StarKiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtImg);
            this.Controls.Add(this.PicPeque);
            this.Controls.Add(this.PicGeneral);
            this.Controls.Add(this.boto_return1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StarKiller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StarKiller";
            ((System.ComponentModel.ISupportInitialize)(this.PicPeque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Messi_Control.Boto_return boto_return1;
        private System.Windows.Forms.PictureBox PicPeque;
        private System.Windows.Forms.TextBox txtImg;
        private System.Windows.Forms.PictureBox PicGeneral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label1;
    }
}