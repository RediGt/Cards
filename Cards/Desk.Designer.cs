namespace Cards
{
    partial class Desk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desk));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLoadCards = new System.Windows.Forms.ToolStripButton();
            this.btnStackCards = new System.Windows.Forms.ToolStripButton();
            this.btnDeckCards = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadCards,
            this.btnStackCards,
            this.btnDeckCards});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLoadCards
            // 
            this.btnLoadCards.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLoadCards.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadCards.Image")));
            this.btnLoadCards.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadCards.Name = "btnLoadCards";
            this.btnLoadCards.Size = new System.Drawing.Size(70, 22);
            this.btnLoadCards.Text = "Load Cards";
            this.btnLoadCards.Click += new System.EventHandler(this.btnLoadCards_Click);
            // 
            // btnStackCards
            // 
            this.btnStackCards.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStackCards.Image = ((System.Drawing.Image)(resources.GetObject("btnStackCards.Image")));
            this.btnStackCards.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStackCards.Name = "btnStackCards";
            this.btnStackCards.Size = new System.Drawing.Size(39, 22);
            this.btnStackCards.Text = "Stack";
            this.btnStackCards.Click += new System.EventHandler(this.btnStackCards_Click);
            // 
            // btnDeckCards
            // 
            this.btnDeckCards.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeckCards.Image = ((System.Drawing.Image)(resources.GetObject("btnDeckCards.Image")));
            this.btnDeckCards.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeckCards.Name = "btnDeckCards";
            this.btnDeckCards.Size = new System.Drawing.Size(37, 22);
            this.btnDeckCards.Text = "Deck";
            this.btnDeckCards.Click += new System.EventHandler(this.btnDeckCards_Click);
            // 
            // Desk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Desk";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLoadCards;
        private System.Windows.Forms.ToolStripButton btnStackCards;
        private System.Windows.Forms.ToolStripButton btnDeckCards;
    }
}

