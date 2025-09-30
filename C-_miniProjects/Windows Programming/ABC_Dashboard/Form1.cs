using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.AxHost;

namespace ABC_Dashboard
{
    public partial class Form1 : Form
    {
        Graphics g;

        string Title;
        public string TITLE
            { get { return Title; } }
        Font Title_font;
        public Font TITLE_FONT
        { get { return Title_font; } }

        int TitleFontSZ;
        Point Title_start;
        Color Title_color;
        public Color TITLE_COLOR
        {
            get { return Title_color; }
        }
        Brush Title_brush;
        PointF Title_point;
        Pen Title_pen;
        PointF TitleUL_end;
        PointF TitleUL_start;

        string txt1;
        Font txt1_font;
        Point txt1start;
        Color txt1_color;
        Brush txt1_brush;
        PointF txt1_point;
        Pen txt1_pen;
        PointF txt1UL_end;
        PointF txt1UL_start;

        //table

        Color cellColor;
        Pen cellPen;
        Brush cellBrush;
        Font cellFont;
        Rectangle cell;
        Size cellSize;

        ArrayList table;
        Point tableStart;

        //chart
        int axisX_Y;
        Point axisX_Start;
        Point axisX_End;
        Point axisY_Start;
        Point axisY_End;
        Color axisColor;
        Pen axisPen;
        Color barColor;
        Color barHatchColor;
        HatchStyle barHatchStyle;
        int Ydivisions;
        int Y_scale;

        //Mouse
        float MouseX, MouseY;
        List<Rectangle> bars;

        public Form1()
        {
            InitializeComponent();

            g = this.CreateGraphics();
            this.Paint += Form1_Paint;
            //this.MouseMove += Form1_MouseMove;
            this.MouseDoubleClick += form1_MouseDC;
            //context menu attachment
            this.ContextMenuStrip = contextMenuStrip1;

            Title = "ABC Company";
            TitleFontSZ = 20;
            Title_font = new Font("Times New Roman", TitleFontSZ);
            Title_color = Color.Blue;
            Title_brush = new SolidBrush(Title_color);
            SizeF textSize = (g.MeasureString(Title, Title_font));
            Title_point = new PointF(
                (this.ClientSize.Width - textSize.Width) / 2,
                50
            );
            Title_pen = new Pen(Title_color);

            TitleUL_start = new PointF(Title_point.X, Title_point.Y + textSize.Height);
            TitleUL_end = new PointF(
                Title_point.X + textSize.Width,
                Title_point.Y + textSize.Height
            );

            txt1 = "Annual Revenue";
            txt1_font = new Font("Times New Roman", 20);
            txt1_color = Color.Black;
            txt1_brush = new SolidBrush(txt1_color);
            SizeF txtSize = (g.MeasureString(Title, txt1_font));
            txt1_point = new PointF(
                (this.ClientSize.Width - txtSize.Width) / 2,
                TitleUL_end.Y + 2
            );
            txt1_pen = new Pen(txt1_color);

            txt1UL_start = new PointF(txt1_point.X, TitleUL_end.Y + txtSize.Height);
            txt1UL_end = new PointF(
                txt1_point.X + txtSize.Width,
                TitleUL_end.Y + txtSize.Height
            );

            //table

            cellColor = Color.Black;
            cellPen = new Pen(cellColor, 5);
            cellBrush = new SolidBrush(cellColor);
            cellFont = new Font("Times New Roman", 12);
            cellSize = new Size(100, 30);

            tableStart = new Point(500, 150);

            table = new ArrayList();

            AddRow("Year", "Revenue");
            AddRow("1999", "120");
            AddRow("2000", "50");
            AddRow("2003", "250");
            AddRow("2016", "320");



            //Axis
            axisX_Y = 350;
            axisX_Start = new Point(50, axisX_Y);
            axisX_End = new Point(450, axisX_Y);
            axisY_Start = axisX_Start;
            axisY_End = new Point(50, 150);
            axisColor = Color.Black;
            axisPen = new Pen(axisColor, 4);
            Y_scale = 10;

            //chart bars
            barColor = Color.DarkBlue;
            barHatchColor = Color.White;
            barHatchStyle = HatchStyle.DashedHorizontal;
            //Mouse_bar doubleClick event
            bars = new List<Rectangle>();

        }
        protected void Form1_Paint(object? sender, PaintEventArgs e)
        {
            DisplayTitle();
            DisplayTxt1();

            //DisplayCell(new Point(600, 100), "Hello");
            DisplayTable();


            DisplayChart();

            DisplayChartValue();


        }

        public void DisplayTitle()
        {
            g.DrawString(Title, Title_font, Title_brush, Title_point);
            g.DrawLine(Title_pen, TitleUL_start, TitleUL_end);


        }
        public void DisplayTxt1()
        {
            g.DrawString(txt1, txt1_font, txt1_brush, txt1_point);
            g.DrawLine(txt1_pen, txt1UL_start, txt1UL_end);
        }

        void AddRow(params string[] entry)
        {
            ArrayList row = new ArrayList();
            row.AddRange(entry);
            table.Add(row);
        }


        void DisplayTable()
        {


            Point Location = tableStart;

            foreach (ArrayList row in table)
            {
                DisplayCell(Location, row[0].ToString());
                Location.X += cellSize.Width;
                DisplayCell(Location, row[1].ToString());
                Location.Y += cellSize.Height;
                Location.X = tableStart.X;
            }



        }

        void DisplayCell(Point loc, string data)
        {
            Rectangle cell = new Rectangle(loc, cellSize);

            g.DrawString(data, cellFont, cellBrush, cell);
            g.DrawRectangle(cellPen, cell);

        }

        void DisplayAxeses()
        {
            g.DrawLine(axisPen, axisX_Start, axisX_End);
            g.DrawLine(axisPen, axisY_Start, axisY_End);

        }
        void DisplayChart()
        {
            DisplayAxeses();
            bars.Clear();
            //table origin x=50 y=300=axisX_Y
            int div_x = 50;
            int div_y = axisX_Y;
            Size barSize;

            int tableMax = 0;

            int Xdivisions = (axisX_End.X - axisX_Start.X) / table.Count;//XstepSize


            Brush barBrush = new HatchBrush(barHatchStyle, barHatchColor, barColor);

            for (int i = 1; i < table.Count; i++)
            {   //get y_axis max value
                ArrayList row = (ArrayList)table[i];
                //find maximum value to use to calculate the drawing step size
                if (int.Parse(row[1].ToString()) > tableMax)
                {
                    tableMax = int.Parse(row[1].ToString());
                }
            }
            //loop over table values
            for (int i = 1; i < table.Count; i++)
            {   //get y_axis max value
                ArrayList row = (ArrayList)table[i];

                Ydivisions = (axisY_Start.Y - axisY_End.Y) / ((tableMax + Y_scale) / Y_scale);//Y drawing step size   Drawingaxislength / {(tableMax+Y_scale)/Y_scale}->number of divisions

                //g.DrawString("Y div= " + Ydivisions, Title_font, Title_brush, new Point(400, 400));

                div_x += Xdivisions;//with each x value shift division size

                div_y = axisX_Y - (int.Parse(row[1].ToString()) / Y_scale) * Ydivisions;//locate UL point for each bar
                barSize = new Size(25, axisX_Y - div_y);//specify the bar size
                Rectangle bar = new Rectangle(div_x, div_y, barSize.Width, barSize.Height);//create your bar

                g.FillRectangle(barBrush, bar);//draw your bar

                bars.Add(bar);//add rectangle to your list for doubleClick event

            }



        }

        void DisplayChartValue()
        {
            g.DrawString("X= " + MouseX + "\tY= " + MouseY, Title_font, Title_brush, new Point(axisX_End.X, axisX_Y + 20));
        }
        void form1_MouseDC(object sender, MouseEventArgs e)
        {
            if (((e.Location.X >= TitleUL_start.X) & (e.Location.X <= TitleUL_end.X) & (e.Location.Y <= TitleUL_end.Y) & (e.Location.Y >= Title_start.Y)))
            {
                //clicked on title string 
                DBox titleDialog = new DBox();
                DialogResult result = titleDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if(titleDialog.New_Title!="")//fixed the empty entry bug
                    {
                        this.Title = titleDialog.New_Title;
                    }
                    if(titleDialog.New_Font != "")
                    {
                        this.Title_font = new Font(titleDialog.New_Font, this.TitleFontSZ);
                    }
                    
                    this.Title_color= titleDialog.New_Color;
                    this.Title_pen = new Pen(Title_color);
                    this.Title_brush = new SolidBrush(Title_color);
                    Invalidate();
                }
            }
            else
            {
                for (int i = 0; i < bars.Count; i++)
                {

                    if (bars[i].Contains(e.Location))
                    {
                        ArrayList bar = (ArrayList)table[i + 1];
                        MouseX = int.Parse(bar[0].ToString());
                        MouseY = (((axisX_Y - e.Y) / (float)Ydivisions) * Y_scale);
                        Invalidate();
                    }

                }
            }
                
            
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barColor = Color.Red;
            Invalidate();
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barColor = Color.Green;
            Invalidate();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barColor = Color.DarkBlue;
            Invalidate();
        }

        private void dottedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barHatchStyle = HatchStyle.DottedGrid;
            Invalidate();
        }

        private void backwardDiagonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barHatchStyle = HatchStyle.BackwardDiagonal;
            Invalidate();
        }

        private void dashedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barHatchStyle = HatchStyle.DashedHorizontal;
            Invalidate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
