using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using WinFormAnimation;

namespace CircularProgressBar
{
    /// <summary>
    ///     The circular progress bar windows form control
    /// </summary>
    public class CircularProgressBar : ProgressBar
    {
        private static readonly bool IsInDesignMode = LicenseManager.UsageMode == LicenseUsageMode.Designtime;

        private int? _animatedStartAngle;

        private float? _animatedValue;

        private Animator _animator = new Animator();

        private ProgressBarStyle? _lastStyle;

        private int _lastValue;

        /// <summary>
        ///     Initializes a new instance of the <see cref="CircularProgressBar" /> class.
        /// </summary>
        public CircularProgressBar()
        {
            _lastValue = Value;

            AnimationFunction = AnimationFunctions.CubicEaseIn;
            AnimationSpeed = 500;
            MarqueeAnimationSpeed = 2000;
            StartAngle = 270;

            // Child class should be responsible for handling this values at the constructor
            // ReSharper disable DoNotCallOverridableMethodsInConstructor
            BackColor = Color.White;
            ForeColor = Color.FromArgb(64, 64, 64);
            DoubleBuffered = true;
            Font = new Font(Font.FontFamily, 72, FontStyle.Bold);
            SecondaryFont = new Font(Font.FontFamily, (float) (Font.Size*.5), FontStyle.Regular);
            // ReSharper restore DoNotCallOverridableMethodsInConstructor

            OuterMargin = -25;
            OuterWidth = 26;
            OuterColor = Color.Gray;

            ProgressWidth = 25;
            ProgressColor = Color.FromArgb(255, 128, 0);

            InnerMargin = 2;
            InnerWidth = -1;
            InnerColor = Color.FromArgb(224, 224, 224);

            TextMargin = new Padding(8, 8, 0, 0);
            Value = 68;

            SuperscriptMargin = new Padding(10, 35, 0, 0);
            SuperscriptColor = Color.FromArgb(166, 166, 166);
            SuperscriptText = "°C";

            SubscriptMargin = new Padding(10, -35, 0, 0);
            SubscriptColor = Color.FromArgb(166, 166, 166);
            SubscriptText = ".23";

            Size = new Size(320, 320);


            SetStyle(
                ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw, true);

            Resize += (o, e) => Invalidate();
            LocationChanged += (o, e) => Invalidate();
            StyleChanged += (o, e) => Invalidate();
        }

        /// <summary>
        ///     Gets or sets the background color of the control.
        /// </summary>
        /// <exception cref="ArgumentException">
        ///     Transparent is not supported
        /// </exception>
        public override Color BackColor
        {
            get { return base.BackColor; }

            set
            {
                if (value != Color.Empty && value != Color.Transparent)
                {
                    base.BackColor = value;
                    Invalidate();
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        ///     Gets or sets the font of text in the <see cref="CircularProgressBar" />.
        /// </summary>
        /// <returns>
        ///     The <see cref="T:System.Drawing.Font" /> of the text. The default is the font set by the container.
        /// </returns>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public override Font Font
        {
            get { return base.Font; }
            set { base.Font = value; }
        }

        /// <summary>
        ///     Gets or sets the text in the <see cref="CircularProgressBar" />.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        /// <summary>
        ///     Gets or sets the animation function.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public AnimationFunctions.Function AnimationFunction { get; set; }

        /// <summary>
        ///     Gets or sets the animation speed in milliseconds.
        /// </summary>
        [Category("Behavior")]
        public int AnimationSpeed { get; set; }

        /// <summary>
        /// </summary>
        [Category("Layout")]
        public Padding TextMargin { get; set; }

        /// <summary>
        /// </summary>
        [Category("Layout")]
        public Padding SuperscriptMargin { get; set; }


        /// <summary>
        /// </summary>
        [Category("Layout")]
        public Padding SubscriptMargin { get; set; }

        /// <summary>
        /// </summary>
        [Category("Appearance")]
        public Color InnerColor { get; set; }

        /// <summary>
        /// </summary>
        [Category("Layout")]
        public int InnerMargin { get; set; }

        /// <summary>
        /// </summary>
        [Category("Layout")]
        public int InnerWidth { get; set; }

        /// <summary>
        /// </summary>
        [Category("Appearance")]
        public Color OuterColor { get; set; }

        /// <summary>
        /// </summary>
        [Category("Layout")]
        public int OuterMargin { get; set; }

        /// <summary>
        /// </summary>
        [Category("Layout")]
        public int OuterWidth { get; set; }

        /// <summary>
        /// </summary>
        [Category("Appearance")]
        public Color ProgressColor { get; set; }

        /// <summary>
        /// </summary>
        [Category("Layout")]
        public int StartAngle { get; set; }

        /// <summary>
        /// </summary>
        [Category("Layout")]
        public int ProgressWidth { get; set; }

        /// <summary>
        /// </summary>
        [Category("Appearance")]
        public string SubscriptText { get; set; }

        /// <summary>
        /// </summary>
        [Category("Appearance")]
        public Color SubscriptColor { get; set; }

        /// <summary>
        /// </summary>
        [Category("Appearance")]
        public Font SecondaryFont { get; set; }

        /// <summary>
        /// </summary>
        [Category("Appearance")]
        public string SuperscriptText { get; set; }

        /// <summary>
        /// </summary>
        [Category("Appearance")]
        public Color SuperscriptColor { get; set; }


        /// <summary>
        ///     Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data. </param>
        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                if (!IsInDesignMode)
                {
                    if (Style == ProgressBarStyle.Marquee)
                    {
                        InitializeMarquee(_lastStyle != Style);
                    }
                    else
                    {
                        InitializeContinues(_lastStyle != Style);
                    }
                    _lastStyle = Style;
                }
                StartPaint(e);
            }
            catch
            {
                // ignored
            }
        }

        private void InitializeContinues(bool firstTime)
        {
            if (_lastValue != Value || firstTime)
            {
                _lastValue = Value;
                if (_animator == null)
                {
                    _animator = new Animator();
                }

                _animator.Stop();
                _animator.Paths = new Path(_animatedValue ?? Value, Value, (ulong) AnimationSpeed).ToArray();
                _animator.Repeat = false;
                _animatedStartAngle = null;
                _animator.Play(
                    new SafeInvoker<float>(
                        v =>
                        {
                            _animatedValue = v;
                            Invalidate();
                        },
                        this));
            }
        }

        private void InitializeMarquee(bool firstTime)
        {
            if (firstTime ||
                (_animator.ActivePath != null && _animator.ActivePath.Duration != (ulong) MarqueeAnimationSpeed))
            {
                _animator.Stop();
                _animator.Paths = new Path(0, 359, (ulong) MarqueeAnimationSpeed).ToArray();
                _animator.Repeat = true;
                _animatedValue = null;
                _animator.Play(
                    new SafeInvoker<float>(
                        v =>
                        {
                            _animatedStartAngle = (int) v;
                            Invalidate();
                        },
                        this));
            }
        }

        private void StartPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var point = AddPoint(Point.Empty, 2);
            var size = AddSize(Size, -2*2);
            if (OuterWidth + OuterMargin < 0)
            {
                var offset = Math.Abs(OuterWidth + OuterMargin);
                point = AddPoint(Point.Empty, offset);
                size = AddSize(Size, -2*offset);
            }
            Brush backBrush = new SolidBrush(base.BackColor);
            if (OuterColor != Color.Empty && OuterColor != Color.Transparent && OuterWidth != 0)
            {
                g.FillEllipse(new SolidBrush(OuterColor), new RectangleF(point, size));
                if (OuterWidth >= 0)
                {
                    point = AddPoint(point, OuterWidth);
                    size = AddSize(size, -2*OuterWidth);
                    g.FillEllipse(backBrush, new RectangleF(point, size));
                }
            }

            point = AddPoint(point, OuterMargin);
            size = AddSize(size, -2*OuterMargin);

            g.FillPie(
                new SolidBrush(ProgressColor),
                ToRectangle(new RectangleF(point, size)),
                _animatedStartAngle ?? StartAngle,
                ((_animatedValue ?? Value)/(Maximum - Minimum))*360);
            if (ProgressWidth >= 0)
            {
                point = AddPoint(point, ProgressWidth);
                size = AddSize(size, -2*ProgressWidth);
                g.FillEllipse(backBrush, new RectangleF(point, size));
            }

            point = AddPoint(point, InnerMargin);
            size = AddSize(size, -2*InnerMargin);

            if (InnerColor != Color.Empty && InnerColor != Color.Transparent && InnerWidth != 0)
            {
                g.FillEllipse(new SolidBrush(InnerColor), new RectangleF(point, size));
                if (InnerWidth >= 0)
                {
                    point = AddPoint(point, InnerWidth);
                    size = AddSize(size, -2*InnerWidth);
                    g.FillEllipse(backBrush, new RectangleF(point, size));
                }
            }

            if (Text != string.Empty)
            {
                point.X += TextMargin.Left;
                point.Y += TextMargin.Top;
                size.Width -= TextMargin.Right;
                size.Height -= TextMargin.Bottom;
                var stringFormat =
                    new StringFormat(RightToLeft == RightToLeft.Yes ? StringFormatFlags.DirectionRightToLeft : 0)
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Near
                    };
                var textSize = g.MeasureString(Text, Font);
                var textPoint = new PointF(
                    point.X + ((size.Width - textSize.Width)/2),
                    point.Y + ((size.Height - textSize.Height)/2));
                if (SubscriptText != string.Empty || SuperscriptText != string.Empty)
                {
                    float maxSWidth = 0;
                    var supSize = SizeF.Empty;
                    var subSize = SizeF.Empty;
                    if (SuperscriptText != string.Empty)
                    {
                        supSize = g.MeasureString(SuperscriptText, SecondaryFont);
                        maxSWidth = Math.Max(supSize.Width, maxSWidth);
                        supSize.Width -= SuperscriptMargin.Right;
                        supSize.Height -= SuperscriptMargin.Bottom;
                    }

                    if (SubscriptText != string.Empty)
                    {
                        subSize = g.MeasureString(SubscriptText, SecondaryFont);
                        maxSWidth = Math.Max(subSize.Width, maxSWidth);
                        subSize.Width -= SubscriptMargin.Right;
                        subSize.Height -= SubscriptMargin.Bottom;
                    }

                    textPoint.X -= maxSWidth/4;
                    if (SuperscriptText != string.Empty)
                    {
                        var supPoint = new PointF(
                            textPoint.X + textSize.Width - (supSize.Width/2),
                            textPoint.Y - (supSize.Height*0.85f));
                        supPoint.X += SuperscriptMargin.Left;
                        supPoint.Y += SuperscriptMargin.Top;
                        g.DrawString(
                            SuperscriptText,
                            SecondaryFont,
                            new SolidBrush(SuperscriptColor),
                            new RectangleF(supPoint, supSize),
                            stringFormat);
                    }

                    if (SubscriptText != string.Empty)
                    {
                        var subPoint = new PointF(
                            textPoint.X + textSize.Width - (subSize.Width/2),
                            textPoint.Y + (textSize.Height*0.85f));
                        subPoint.X += SubscriptMargin.Left;
                        subPoint.Y += SubscriptMargin.Top;
                        g.DrawString(
                            SubscriptText,
                            SecondaryFont,
                            new SolidBrush(SubscriptColor),
                            new RectangleF(subPoint, subSize),
                            stringFormat);
                    }
                }

                g.DrawString(
                    Text,
                    Font,
                    new SolidBrush(ForeColor),
                    new RectangleF(textPoint, textSize),
                    stringFormat);
            }
        }

        private static PointF AddPoint(PointF p, int v)
        {
            p.X += v;
            p.Y += v;
            return p;
        }

        private static SizeF AddSize(SizeF s, int v)
        {
            s.Height += v;
            s.Width += v;
            return s;
        }

        private static Rectangle ToRectangle(RectangleF rect)
        {
            return new Rectangle((int) rect.X, (int) rect.Y, (int) rect.Width, (int) rect.Height);
        }
    }
}