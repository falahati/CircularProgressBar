// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CircularProgressBar.cs" company="Soroush Falahati (soroush@falahati.net)">
//   This library is free software; you can redistribute it and/or
//   modify it under the terms of the GNU Lesser General Public
//   License as published by the Free Software Foundation; either
//   version 2.1 of the License, or (at your option) any later version.
//   
//   This library is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//   Lesser General Public License for more details.
// </copyright>
// <summary>
//   The circular progress bar control
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CircularProgressBar
{
    #region

    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Text;
    using System.Windows.Forms;

    using WinFormAnimation;

    #endregion

    /// <summary>
    ///     The circular progress bar control
    /// </summary>
    public sealed class CircularProgressBar : UserControl
    {
        #region Fields

        /// <summary>
        ///     The animated value.
        /// </summary>
        private float aniValue;

        /// <summary>
        ///     The animator.
        /// </summary>
        private Animator animator;

        /// <summary>
        /// The caption.
        /// </summary>
        private string caption;

        /// <summary>
        /// The caption margin.
        /// </summary>
        private int captionMargin;

        /// <summary>
        /// The inner circle color.
        /// </summary>
        private Color innerCircleColor;

        /// <summary>
        /// The inner circle margin.
        /// </summary>
        private int innerCircleMargin;

        /// <summary>
        /// The inner circle width.
        /// </summary>
        private int innerCircleWidth;

        /// <summary>
        ///     The max value.
        /// </summary>
        private float maxValue;

        /// <summary>
        ///     The min value.
        /// </summary>
        private float minValue;

        /// <summary>
        /// The outer circle color.
        /// </summary>
        private Color outerCircleColor;

        /// <summary>
        /// The outer circle margin.
        /// </summary>
        private int outerCircleMargin;

        /// <summary>
        /// The outer circle width.
        /// </summary>
        private int outerCircleWidth;

        /// <summary>
        /// The progress circle color.
        /// </summary>
        private Color progressCircleColor;

        /// <summary>
        /// The progress circle start angle.
        /// </summary>
        private int progressCircleStartAngle;

        /// <summary>
        /// The progress circle width.
        /// </summary>
        private int progressCircleWidth;

        /// <summary>
        /// The sub text.
        /// </summary>
        private string subText;

        /// <summary>
        /// The sub text color.
        /// </summary>
        private Color subTextColor;

        /// <summary>
        /// The sup sub font.
        /// </summary>
        private Font supSubFont;

        /// <summary>
        /// The sup text.
        /// </summary>
        private string supText;

        /// <summary>
        /// The sup text color.
        /// </summary>
        private Color supTextColor;

        /// <summary>
        ///     The value.
        /// </summary>
        private float value;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="CircularProgressBar" /> class.
        /// </summary>
        public CircularProgressBar()
        {
            this.animator = new Animator();
            this.AnimatorFunction = Functions.CubicEaseIn;
            this.AnimatorDuration = 500;
            this.SubTextColor = this.SupTextColor = Color.Gray;
            this.OuterCircleColor = this.InnerCircleColor = Color.FromArgb(118, 57, 3);
            this.ProgressCircleColor = Color.FromArgb(255, 87, 0);
            this.BackColor = Color.FromArgb(40, 39, 37);
            this.ForeColor = Color.White;
            this.OuterCircleWidth = 0;
            this.OuterCircleMargin = 0;
            this.ProgressCircleWidth = 9;
            this.InnerCircleMargin = 4;
            this.InnerCircleWidth = 3;
            this.CaptionMargin = 3;
            this.SupSubFont = new Font(this.Font.Name, (float)(this.Font.Size * .5), FontStyle.Regular);

            this.MaxValue = 100;
            this.MinValue = 0;
            this.Value = 85;
            this.ProgressCircleStartAngle = 0;
            this.DoubleBuffered = true;
            this.Resize += (o, e) => this.Invalidate();
            this.LocationChanged += (o, e) => this.Invalidate();
            this.StyleChanged += (o, e) => this.Invalidate();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the animator duration.
        /// </summary>
        public int AnimatorDuration { get; set; }

        /// <summary>
        ///     Gets or sets the animator function.
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public Functions.Function AnimatorFunction { get; set; }

        /// <summary>
        ///     Gets or sets the back color.
        /// </summary>
        /// <exception cref="ArgumentException">
        ///     Transparent color is not supported
        /// </exception>
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }

            set
            {
                if (value != Color.Empty && value != Color.Transparent)
                {
                    base.BackColor = value;
                    this.Invalidate();
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        ///     Gets or sets the caption.
        /// </summary>
        public string Caption
        {
            get
            {
                return this.caption;
            }

            set
            {
                this.caption = value;
                this.Invalidate();
            }
        }

        /// <summary>
        ///     Gets or sets the caption margin.
        /// </summary>
        public int CaptionMargin
        {
            get
            {
                return this.captionMargin;
            }

            set
            {
                this.captionMargin = value;
                this.Invalidate();
            }
        }

        /// <summary>
        ///     Gets or sets the inner circle color.
        /// </summary>
        public Color InnerCircleColor
        {
            get
            {
                return this.innerCircleColor;
            }

            set
            {
                this.innerCircleColor = value;
                this.Invalidate();
            }
        }

        /// <summary>
        ///     Gets or sets the inner circle margin.
        /// </summary>
        public int InnerCircleMargin
        {
            get
            {
                return this.innerCircleMargin;
            }

            set
            {
                this.innerCircleMargin = value;
                this.Invalidate();
            }
        }

        /// <summary>
        ///     Gets or sets the inner circle width.
        /// </summary>
        public int InnerCircleWidth
        {
            get
            {
                return this.innerCircleWidth;
            }

            set
            {
                this.innerCircleWidth = value;
                this.Invalidate();
            }
        }

        /// <summary>
        ///     Gets or sets the max value.
        /// </summary>
        /// <exception cref="ArgumentException">
        ///     Value is less than MinValue
        /// </exception>
        public float MaxValue
        {
            get
            {
                return this.maxValue;
            }

            set
            {
                if (value > this.MinValue)
                {
                    this.maxValue = value;
                    this.value = Math.Min(this.value, this.maxValue);
                    this.Invalidate();
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        ///     Gets or sets the min value.
        /// </summary>
        /// <exception cref="ArgumentException">
        ///     Value is more than MaxValue
        /// </exception>
        public float MinValue
        {
            get
            {
                return this.minValue;
            }

            set
            {
                if (value < this.MaxValue)
                {
                    this.minValue = value;
                    this.value = Math.Max(this.value, this.minValue);
                    this.Invalidate();
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        ///     Gets or sets the outer circle color.
        /// </summary>
        public Color OuterCircleColor
        {
            get
            {
                return this.outerCircleColor;
            }

            set
            {
                this.outerCircleColor = value;
                this.Invalidate();
            }
        }

        /// <summary>
        ///     Gets or sets the outer circle margin.
        /// </summary>
        public int OuterCircleMargin
        {
            get
            {
                return this.outerCircleMargin;
            }

            set
            {
                this.outerCircleMargin = value;
                this.Invalidate();
            }
        }

        /// <summary>
        ///     Gets or sets the outer circle width.
        /// </summary>
        public int OuterCircleWidth
        {
            get
            {
                return this.outerCircleWidth;
            }

            set
            {
                this.outerCircleWidth = value;
                this.Invalidate();
            }
        }

        /// <summary>
        ///     Gets or sets the progress circle color.
        /// </summary>
        public Color ProgressCircleColor
        {
            get
            {
                return this.progressCircleColor;
            }

            set
            {
                this.progressCircleColor = value;
                this.Invalidate();
            }
        }

        /// <summary>
        ///     Gets or sets the progress circle start angle.
        /// </summary>
        public int ProgressCircleStartAngle
        {
            get
            {
                return this.progressCircleStartAngle;
            }

            set
            {
                this.progressCircleStartAngle = value;
                this.Invalidate();
            }
        }

        /// <summary>
        ///     Gets or sets the progress circle width.
        /// </summary>
        public int ProgressCircleWidth
        {
            get
            {
                return this.progressCircleWidth;
            }

            set
            {
                this.progressCircleWidth = value;
                this.Invalidate();
            }
        }

        /// <summary>
        ///     Gets or sets the sub text.
        /// </summary>
        public string SubText
        {
            get
            {
                return this.subText;
            }

            set
            {
                this.subText = value;
                this.Invalidate();
            }
        }

        /// <summary>
        ///     Gets or sets the sub text color.
        /// </summary>
        public Color SubTextColor
        {
            get
            {
                return this.subTextColor;
            }

            set
            {
                this.subTextColor = value;
                this.Invalidate();
            }
        }

        /// <summary>
        ///     Gets or sets the sup sub font.
        /// </summary>
        public Font SupSubFont
        {
            get
            {
                return this.supSubFont;
            }

            set
            {
                this.supSubFont = value;
                this.Invalidate();
            }
        }

        /// <summary>
        ///     Gets or sets the sup text.
        /// </summary>
        public string SupText
        {
            get
            {
                return this.supText;
            }

            set
            {
                this.supText = value;
                this.Invalidate();
            }
        }

        /// <summary>
        ///     Gets or sets the sup text color.
        /// </summary>
        public Color SupTextColor
        {
            get
            {
                return this.supTextColor;
            }

            set
            {
                this.supTextColor = value;
                this.Invalidate();
            }
        }

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        /// <exception cref="ArgumentException">
        ///     Value is more than MaxValue or less than MinValue
        /// </exception>
        public float Value
        {
            // ReSharper disable once UnusedMember.Global
            get
            {
                return this.value;
            }

            set
            {
                if (value <= this.MaxValue && value >= this.MinValue)
                {
                    this.value = value;
                    if (this.animator == null)
                    {
                        this.animator = new Animator();
                    }

                    this.animator.Stop();
                    this.animator.SetPaths(new Path(this.aniValue, this.value, this.AnimatorDuration));
                    this.animator.Play(
                        new SafeInvoker(
                            v =>
                                {
                                    this.aniValue = v;
                                    this.Invalidate();
                                }, 
                            this));
                    this.Invalidate();
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// The on paint override
        /// </summary>
        /// <param name="e">
        /// The e.
        /// </param>
        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                g.TextRenderingHint = TextRenderingHint.AntiAlias;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                PointF point = AddPoint(Point.Empty, 2);
                SizeF size = AddSize(this.Size, -2 * 2);
                Brush backBrush = new SolidBrush(base.BackColor);
                if (this.OuterCircleColor != Color.Empty && this.OuterCircleColor != Color.Transparent
                    && this.OuterCircleWidth > 0)
                {
                    g.FillEllipse(new SolidBrush(this.OuterCircleColor), new RectangleF(point, size));
                    point = AddPoint(point, this.OuterCircleWidth);
                    size = AddSize(size, -2 * this.OuterCircleWidth);
                    g.FillEllipse(backBrush, new RectangleF(point, size));
                }

                point = AddPoint(point, this.OuterCircleMargin);
                size = AddSize(size, -2 * this.OuterCircleMargin);

                g.FillPie(
                    new SolidBrush(this.ProgressCircleColor), 
                    ToRectangle(new RectangleF(point, size)), 
                    this.ProgressCircleStartAngle, 
                    (this.aniValue / (this.MaxValue - this.MinValue)) * 360);
                point = AddPoint(point, this.ProgressCircleWidth);
                size = AddSize(size, -2 * this.ProgressCircleWidth);
                g.FillEllipse(backBrush, new RectangleF(point, size));

                point = AddPoint(point, this.InnerCircleMargin);
                size = AddSize(size, -2 * this.InnerCircleMargin);

                if (this.InnerCircleColor != Color.Empty && this.InnerCircleColor != Color.Transparent
                    && this.InnerCircleWidth > 0)
                {
                    g.FillEllipse(new SolidBrush(this.InnerCircleColor), new RectangleF(point, size));
                    point = AddPoint(point, this.InnerCircleWidth);
                    size = AddSize(size, -2 * this.InnerCircleWidth);
                    g.FillEllipse(backBrush, new RectangleF(point, size));
                }

                if (this.Caption != string.Empty)
                {
                    point = AddPoint(point, this.CaptionMargin);
                    size = AddSize(size, -2 * this.CaptionMargin);
                    SizeF textSize = g.MeasureString(this.Caption, this.Font);
                    PointF textPoint = new PointF(
                        point.X + ((size.Width - textSize.Width) / 2), 
                        point.Y + ((size.Height - textSize.Height) / 2));
                    if (this.SubText != string.Empty || this.SupText != string.Empty)
                    {
                        float maxSWidth = 0;
                        SizeF supSize = SizeF.Empty;
                        SizeF subSize = SizeF.Empty;
                        if (this.SupText != string.Empty)
                        {
                            supSize = g.MeasureString(this.SupText, this.SupSubFont);
                            maxSWidth = Math.Max(supSize.Width, maxSWidth);
                        }

                        if (this.SubText != string.Empty)
                        {
                            subSize = g.MeasureString(this.SubText, this.SupSubFont);
                            maxSWidth = Math.Max(subSize.Width, maxSWidth);
                        }

                        textPoint.X -= maxSWidth / 4;
                        if (this.SupText != string.Empty)
                        {
                            PointF supPoint = new PointF(
                                textPoint.X + textSize.Width - (supSize.Width / 2), 
                                textPoint.Y - (supSize.Height * 0.85f));
                            g.DrawString(
                                this.SupText, 
                                this.SupSubFont, 
                                new SolidBrush(this.SupTextColor), 
                                new RectangleF(supPoint, supSize));
                        }

                        if (this.SubText != string.Empty)
                        {
                            PointF subPoint = new PointF(
                                textPoint.X + textSize.Width - (subSize.Width / 2), 
                                textPoint.Y + (textSize.Height * 0.85f));
                            g.DrawString(
                                this.SubText, 
                                this.SupSubFont, 
                                new SolidBrush(this.SubTextColor), 
                                new RectangleF(subPoint, subSize));
                        }
                    }

                    g.DrawString(
                        this.Caption, 
                        this.Font, 
                        new SolidBrush(this.ForeColor), 
                        new RectangleF(textPoint, textSize));
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// The add point.
        /// </summary>
        /// <param name="p">
        /// The p.
        /// </param>
        /// <param name="v">
        /// The v.
        /// </param>
        /// <returns>
        /// The <see cref="PointF"/>.
        /// </returns>
        private static PointF AddPoint(PointF p, int v)
        {
            p.X += v;
            p.Y += v;
            return p;
        }

        /// <summary>
        /// The add size.
        /// </summary>
        /// <param name="s">
        /// The s.
        /// </param>
        /// <param name="v">
        /// The v.
        /// </param>
        /// <returns>
        /// The <see cref="SizeF"/>.
        /// </returns>
        private static SizeF AddSize(SizeF s, int v)
        {
            s.Height += v;
            s.Width += v;
            return s;
        }

        /// <summary>
        /// The to rectangle.
        /// </summary>
        /// <param name="rect">
        /// The rectangle.
        /// </param>
        /// <returns>
        /// The <see cref="Rectangle"/>.
        /// </returns>
        private static Rectangle ToRectangle(RectangleF rect)
        {
            return new Rectangle((int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height);
        }

        #endregion
    }
}