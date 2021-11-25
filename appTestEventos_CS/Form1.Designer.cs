
namespace appTestEventos_CS
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.picFrame = new System.Windows.Forms.PictureBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.picFrame)).BeginInit();
      this.SuspendLayout();
      // 
      // picFrame
      // 
      this.picFrame.Image = ((System.Drawing.Image)(resources.GetObject("picFrame.Image")));
      this.picFrame.Location = new System.Drawing.Point(444, 251);
      this.picFrame.Name = "picFrame";
      this.picFrame.Size = new System.Drawing.Size(50, 50);
      this.picFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picFrame.TabIndex = 0;
      this.picFrame.TabStop = false;
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(991, 599);
      this.Controls.Add(this.picFrame);
      this.KeyPreview = true;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.picFrame)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox picFrame;
    private System.Windows.Forms.Timer timer1;
  }
}

