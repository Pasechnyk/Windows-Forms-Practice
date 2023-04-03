using GraphicRedactor.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

// Task - Create Graphic Editor immitating Paint Application
// Contains:
// - Pencil with color palette and size/smoothness configuration
// - Filling space with color
// - Saving / loading / clearing pictures

namespace GraphicRedactor
{
    public partial class Form1 : Form
    {
        // Shapes collection
        enum ShapeType { Pen, Line, Ellipse, Rectangle, Pie }
        private ShapeType selectedType = ShapeType.Pen;

        // Drawing properties
        private Point start;
        private Point end;

        Graphics graphics;
        Pen pencil;
        Bitmap bitmap = new Bitmap(200, 200);
        GraphicsPath graphicsPath = new GraphicsPath();

        bool isMoving = false;

        public Form1()
        {
            InitializeComponent();

            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            bitmap = new(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(bitmap);
            //graphics = pictureBox.CreateGraphics();
            pencil = new Pen(Color.Black, 4);

            foreach (var item in Enum.GetValues(typeof(ShapeType)))
            {
                shapeTypeBox.Items.Add(item);
            }
            shapeTypeBox.SelectedIndex = 0;
        }

        // Normalizing coords and setting size
        private void NormalizeCoords(ref Point start, ref Point end)
        {
            if (end.X < start.X)
            {
                (end.X, start.X) = (start.X, end.X);
            }
            if (end.Y < start.Y)
            {
                (end.Y, start.Y) = (start.Y, end.Y);
            }
        }
        static Point SetPoint(PictureBox pictureBox, Point pt)
        {
            float pointX = 1f * pictureBox.Width / pictureBox.Width;
            float pointY = 1f * pictureBox.Height / pictureBox.Height;

            return new Point((int)(pt.X * pointX), (int)(pt.Y * pointY));
        }

        private Size GetSize(Point start, Point end)
        {
            return new Size()
            {
                Width = Math.Abs(end.X - start.X),
                Height = Math.Abs(end.Y - start.Y)
            };
        }

        // Display changed color
        private void ChooseColorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            chosenPictureBox.BackColor = button.BackColor;
            pencil.Color = button.BackColor;
        }

        // Choose specific color
        private void ChooseColorBtnClick(object sender, EventArgs e)
        {
            ColorDialog dialog = new();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                chosenPictureBox.BackColor = dialog.Color;
                pencil.Color = dialog.Color;
            }
        }

        // Drawing methods:
        private void PicturePanelMouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            start = e.Location;
        }

        private void PicturePanelMouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
            end = e.Location;

            Size size = GetSize(start, end);

            IShape shape = null;
            var currentColor = chosenPictureBox.BackColor;

            switch (selectedType)
            {
                case ShapeType.Line:
                    shape = new MyLine(currentColor, 5, start, end);
                    break;
                case ShapeType.Ellipse:
                    NormalizeCoords(ref start, ref end);
                    shape = new MyEllipse(currentColor, start, size);
                    break;
                case ShapeType.Rectangle:
                    NormalizeCoords(ref start, ref end);
                    shape = new MyRectangle(currentColor, start, size);
                    break;
                case ShapeType.Pie:
                    shape = new MyPie(currentColor, Location, size);
                    break;
            }

            shape?.Print(graphics);
        }

        private void PicturePanelMouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving && selectedType == ShapeType.Pen)
            {
                pictureBox.Image = bitmap;
                graphics.DrawLine(pencil, new Point(start.X, start.Y), e.Location);
                start = e.Location;
            }
        }

        private void Validate(Bitmap bitmap, Stack<Point> points, int x, int y, Color chosenColor, Color newColor)
        {
            Color background = bitmap.GetPixel(x, y);
            if (background == chosenColor)
            {
                points.Push(new Point(x, y));
                bitmap.SetPixel(x, y, newColor);
            }
        }

        public void FillWithColor(Bitmap bitmap, int x, int y, Color newColor)
        {
            Color chosenColor = bitmap.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();

            pixel.Push(new Point(x, y));
            bitmap.SetPixel(x, y, newColor);

            if (chosenColor == newColor) { return; }

            while (pixel.Count > 0)
            {
                Point point = (Point)pixel.Pop();
                if (point.X > 0 && point.Y > 0
                    && point.X < bitmap.Width - 1 && point.Y < bitmap.Height - 1)
                {
                    Validate(bitmap, pixel, point.X - 1, point.Y, chosenColor, newColor);
                    Validate(bitmap, pixel, point.X, point.Y - 1, chosenColor, newColor);
                    Validate(bitmap, pixel, point.X + 1, point.Y, chosenColor, newColor);
                    Validate(bitmap, pixel, point.X, point.Y + 1, chosenColor, newColor);
                }
            }
        }

        // Panel tools:
        // Smooth touch
        private void EnableSmoothingCheckBoxChecked(object sender, EventArgs e)
        {
            if (enabledCheckBox.Checked)
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pencil.StartCap = pencil.EndCap = LineCap.Round;
            }
        }

        // Pencil size
        private void BrushSizeTrackBarVisibleChanged(object sender, EventArgs e)
        {
            pencil.Width = sizeTrackBar.Value;
        }

        // Eraser (adjusts to background color)
        private void EraseBtnClick(object sender, EventArgs e)
        {
            pencil.Color = pictureBox.BackColor;
        }

        // Fill space with color
        private void FillBtnMouseClick(object sender, MouseEventArgs e)
        {
            var currentColor = chosenPictureBox.BackColor;
            pictureBox.Image = bitmap;

            Point point = SetPoint(pictureBox, e.Location);
            FillWithColor(bitmap, point.X, point.Y, currentColor);
        }

        // Creating shapes
        private void ShapeTypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            selectedType = (ShapeType)shapeTypeBox.SelectedItem;
        }

        // Save .png
        private void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            SaveFileDialog dialogue = new();
            dialogue.DefaultExt = ".png";

            if (dialogue.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image.Save(dialogue.FileName);
            }
        }

        // Load picture
        private void LoadPictureToolStripMenuItemClick(object sender, EventArgs e)
        {
            OpenFileDialog dialogue = new();

            if (dialogue.ShowDialog() == DialogResult.OK)
            {
                bitmap = (Bitmap)Image.FromFile(dialogue.FileName);
                pictureBox.Image = bitmap;
            }
        }

        // Clear surface
        private void ClearAllToolStripMenuItemClick(object sender, EventArgs e)
        {
            graphics.Clear(pictureBox.BackColor);
            pictureBox.Image = bitmap;
        }

        // Exit application
        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
