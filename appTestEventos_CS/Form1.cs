using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTestEventos_CS
{
  public partial class Form1 : Form
  {
    private Image[] pacmanImage = new Image[4];
    private int currentMouthPosition = 0;
    private int xPosition = 0;
    private int yPosition = 0;

    // The index of the current frame.
    private int FrameNum = 0;
    public Form1()
    {
      InitializeComponent();
      timer1.Interval = 100;
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      timer1.Start();
      switch (e.KeyCode)
      {
        case Keys.Left:
          currentMouthPosition = 0;
          picFrame.Image = Image.FromFile(@"pac-izquierda.png");
        break;
        case Keys.Right:
          currentMouthPosition = 1;
          picFrame.Image = Image.FromFile(@"pac-derecha.png");
        
        break;
        case Keys.Up:
          currentMouthPosition = 2;
          picFrame.Image = Image.FromFile(@"pac-arriba.png");
        
        break;
        case Keys.Down:
          currentMouthPosition = 3;
          picFrame.Image = Image.FromFile(@"pac-abajo.png");
        
        break;
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      switch (currentMouthPosition)
      {
        case 0:
          picFrame.Location = new Point(picFrame.Location.X - 10, picFrame.Location.Y);
          if (picFrame.Location.X < 0)
          {
            picFrame.Location = new Point(this.Width, picFrame.Location.Y);
          }
        break;
        case 1:
          picFrame.Location = new Point(picFrame.Location.X + 10, picFrame.Location.Y);
          if (picFrame.Location.X >= this.Width)
          {
            picFrame.Location = new Point(0, picFrame.Location.Y);
          }
        break;
        case 2:
          picFrame.Location = new Point(picFrame.Location.X, picFrame.Location.Y - 10);
          if (picFrame.Location.Y < 0)
          {
            picFrame.Location = new Point(picFrame.Location.X, this.Height);
          }
        break;
        case 3:
          picFrame.Location = new Point(picFrame.Location.X, picFrame.Location.Y + 10);
          if (picFrame.Location.Y > this.Height)
          {
            picFrame.Location = new Point(picFrame.Location.X, 0);
          }
        break;
      }
    }
  }
}
