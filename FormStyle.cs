using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;

namespace avtoplanirovshik_start_exit
{
    public partial class FormStyle : Component
    {
        private readonly Form _form;
        private readonly int _headerHeight = 25;

        private Control? _mainContainer;

        private Color _headerColor = Color.DimGray;
        // Цвета для кнопок: обычный и при наведении
        private readonly Color _btnNormalColor = Color.FromArgb(60, 60, 60);
        private readonly Color _btnCloseHoverColor = Color.FromArgb(230, 50, 50); // Красный при наведении
        private readonly Color _btnOtherHoverColor = Color.FromArgb(100, 100, 100); // Серый для свернуть

        private bool _closeHovered;
        private bool _minimizeHovered;

        private bool _isDragging;
        private Point _dragStartPoint;

        private Rectangle _closeRect;
        private Rectangle _minimizeRect;

        public FormStyle(Form form, Control? mainContainer = null)
        {
            _form = form ?? throw new ArgumentNullException(nameof(form));
            _mainContainer = mainContainer;
            _form.Height += _headerHeight;
            Initialize();
        }

        private void Initialize()
        {
            _form.FormBorderStyle = FormBorderStyle.None;
            _form.AllowTransparency = false; // Важно для полного закрашивания
            _form.TransparencyKey = Color.Empty;

            SetDoubleBuffered(_form);

            _form.Paint += OnPaint;
            _form.Resize += OnResize;

            _form.MouseDown += OnMouseDown;
            _form.MouseUp += OnMouseUp;
            _form.MouseMove += OnMouseMove;
            _form.MouseLeave += OnMouseLeave;

            ApplyLayout();
        }

        private void ApplyLayout()
        {
            if (_mainContainer == null) return;

            // 1. Снимаем Dock, чтобы управлять позицией вручную
            _mainContainer.Dock = DockStyle.None;

            // 2. Сдвигаем контейнер ВНИЗ на высоту шапки
            _mainContainer.Location = new Point(0, _headerHeight);

            // 3. ГЛАВНЫЙ МОМЕНТ:
            // Вычисляем высоту контейнера как: (Вся высота формы) - (Высота шапки)
            // Мы НЕ вычитаем лишний пиксель (-1), если у формы нет рамок (FormBorderStyle.None).
            // Если скроллбар все равно появляется, значит, у самого _mainContainer (например, TabControl)
            // есть внутренние отступы (Padding).

            int availableHeight = _form.ClientSize.Height - _headerHeight;

            _mainContainer.Size = new Size(
                _form.ClientSize.Width,
                availableHeight
            );

            // 4. Закрепляем, чтобы при растягивании формы контейнер тянулся вместе с ней
            _mainContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                                    AnchorStyles.Left | AnchorStyles.Right;

            // 5. Обновляем координаты кнопок (они зависят от ширины формы)
            UpdateButtonRects();

            // 6. Принудительно перерисовываем форму, чтобы кнопки и шапка встали на места
            _form.Invalidate();
        }


        private void OnResize(object? sender, EventArgs e)
        {
            ApplyLayout(); // Обновляем и контейнер, и кнопки
        }

        private void UpdateButtonRects()
        {
            int h = _headerHeight;
            int w = _form.ClientSize.Width;

            // Кнопки квадратные, прижаты к правому краю
            _closeRect = new Rectangle(w - h, 0, h, h);
            _minimizeRect = new Rectangle(w - 2 * h, 0, h, h);
        }

        private void OnMouseLeave(object? sender, EventArgs e)
        {
            bool changed = _closeHovered || _minimizeHovered;
            _closeHovered = false;
            _minimizeHovered = false;
            if (changed)
                _form.Invalidate();
        }

        private void OnMouseMove(object? sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                int dx = e.X - _dragStartPoint.X;
                int dy = e.Y - _dragStartPoint.Y;
                _form.Location = new Point(_form.Location.X + dx, _form.Location.Y + dy);
                return;
            }

            bool closeWas = _closeHovered;
            bool minimizeWas = _minimizeHovered;

            _closeHovered = _closeRect.Contains(e.Location);
            _minimizeHovered = _minimizeRect.Contains(e.Location);

            if (closeWas != _closeHovered || minimizeWas != _minimizeHovered)
                _form.Invalidate();
        }

        private void OnMouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            if (_closeRect.Contains(e.Location))
            {
                _form.Close();
                return;
            }

            if (_minimizeRect.Contains(e.Location))
            {
                _form.WindowState = FormWindowState.Minimized;
                return;
            }

            // Если клик в пределах шапки (но не по кнопкам) - тащим форму
            if (e.Y <= _headerHeight)
            {
                _isDragging = true;
                _dragStartPoint = e.Location;
            }
        }

        private void OnMouseUp(object? sender, MouseEventArgs e)
        {
            _isDragging = false;
        }

        private void OnPaint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            // Настройки качества
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // 1. Рисуем шапку
            // ClientSize.Width гарантирует, что мы рисуем ровно по рабочей области
            // +2 к высоте перекрывает любые стыки пикселей
            var headerRect = new Rectangle(0, 0, _form.ClientSize.Width, _headerHeight + 2);

            using var headerBrush = new SolidBrush(_headerColor);
            g.FillRectangle(headerBrush, headerRect);

            // 2. Рисуем кнопку ЗАКРЫТЬ (X)
            Color closeColor = _closeHovered ? _btnCloseHoverColor : _btnNormalColor;
            using var closeBrush = new SolidBrush(closeColor);
            g.FillRectangle(closeBrush, _closeRect);

            // Рисуем крестик белым
            DrawCross(g, _closeRect, Color.White, 2);

            // 3. Рисуем кнопку СВЕРНУТЬ (-)
            Color minColor = _minimizeHovered ? _btnOtherHoverColor : _btnNormalColor;
            using var minBrush = new SolidBrush(minColor);
            g.FillRectangle(minBrush, _minimizeRect);

            // Рисуем минус белым
            DrawMinus(g, _minimizeRect, Color.White, 2);

            // 4. Рисуем заголовок (текст)
            using var titleBrush = new SolidBrush(Color.White);
            var font = new Font("Segoe UI", 10, FontStyle.Regular);

            // Отступ справа должен быть больше суммы ширин кнопок, чтобы текст не наезжал
            int rightPadding = _headerHeight * 3;
            var titleRect = new Rectangle(10, 0, _form.ClientSize.Width - rightPadding, _headerHeight);

            TextRenderer.DrawText(g, _form.Text, font, titleRect, Color.White, TextFormatFlags.VerticalCenter);
        }

        // Вспомогательный метод для рисования крестика
        private void DrawCross(Graphics g, Rectangle r, Color color, float thickness)
        {
            using var pen = new Pen(color, thickness) { StartCap = LineCap.Round, EndCap = LineCap.Round };
            int pad = 4;
            g.DrawLine(pen, r.X + pad, r.Y + pad, r.Right - pad, r.Bottom - pad);
            g.DrawLine(pen, r.Right - pad, r.Y + pad, r.X + pad, r.Bottom - pad);
        }

        // Вспомогательный метод для рисования минуса
        private void DrawMinus(Graphics g, Rectangle r, Color color, float thickness)
        {
            using var pen = new Pen(color, thickness) { StartCap = LineCap.Round, EndCap = LineCap.Round };
            int x = r.X + r.Width / 2 - 5;
            int y = r.Y + r.Height / 2 - 1;
            g.DrawLine(pen, x, y, x + 10, y);
        }

        public static void SetDoubleBuffered(Control c)
        {
            if (SystemInformation.TerminalServerSession)
                return;

            var prop = typeof(Control).GetProperty(
                "DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance);

            prop?.SetValue(c, true, null);
        }
        

    }
}
