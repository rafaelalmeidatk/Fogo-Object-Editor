using Caliburn.Micro;
using Fogo_Sprite_Editor.Extensions;
using Gemini.Modules.MonoGame.Controls;
using Gemini.Modules.Output;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Fogo_Sprite_Editor.Modules.ObjectViewer.Views
{
    /// <summary>
    /// Interaction logic for SpriteView.xaml
    /// </summary>
    public partial class ObjectView : UserControl, IDisposable
    {
        private readonly IOutput _output;

        private System.Windows.Media.ImageSource _lastSpritesheetImage;

        private SpriteBatch _spriteBatch;
        private Texture2D _spritesheetTexture;

        private bool _mouseDown;
        private Point _mousePoint;
        private System.Windows.Point _previousMousePosition;

        private Texture2D _selectionTexture;

        public ObjectView()
        {
            InitializeComponent();
            _output = IoC.Get<IOutput>();
        }

        public void Invalidate()
        {
            GraphicsControl.Invalidate();
        }

        public void Dispose()
        {
            GraphicsControl.Dispose();
        }

        private void OnGraphicsControlLoadContent(object sender, GraphicsDeviceEventArgs e)
        {
            _spriteBatch = new SpriteBatch(e.GraphicsDevice);
            _selectionTexture = new Texture2D(e.GraphicsDevice, 1, 1);
            _selectionTexture.SetData(new[] { Color.Orange });
        }
        
        private void OnGraphicsControlDraw(object sender, DrawEventArgs e)
        {
            e.GraphicsDevice.Clear(Color.CornflowerBlue);
            if (Spritesheet.Source != null && _lastSpritesheetImage != Spritesheet.Source)
            {
                _lastSpritesheetImage = Spritesheet.Source;
                var stream = (FileStream)((BitmapImage)Spritesheet.Source).StreamSource;
                using (FileStream fileStream = new FileStream(stream.Name, FileMode.Open))
                    _spritesheetTexture = Texture2D.FromStream(e.GraphicsDevice, fileStream);
            }

            _spriteBatch.Begin();

            if (_spritesheetTexture != null)
            {
                var texture = _spritesheetTexture;
                var vp = e.GraphicsDevice.Viewport;
                var dest = new Vector2((vp.Width - texture.Width) / 2, (vp.Height - texture.Height) / 2);
                _spriteBatch.Draw(texture, dest, Color.White);
            }

            if (_mouseDown)
            {
                var newSize = new Point((int)(_previousMousePosition.X - _mousePoint.X), (int)(_previousMousePosition.Y - _mousePoint.Y));
                var rect = new Rectangle(_mousePoint, newSize);
                _spriteBatch.Draw(_selectionTexture, rect, Color.White * 0.5f);
                _spriteBatch.DrawRectangleBorder(_selectionTexture, rect, 2);
            }

            _spriteBatch.End();
        }
        
        private void OnGraphicsControlMouseMove(object sender, MouseEventArgs e)
        {
            var position = e.GetPosition(this);

            if (_mouseDown)
            {

            }

            _previousMousePosition = position;
        }
        
        private void OnGraphicsControlHwndLButtonDown(object sender, MouseEventArgs e)
        {
            _previousMousePosition = e.GetPosition(this);

            _mouseDown = true;
            _mousePoint = new Point((int)_previousMousePosition.X, (int)_previousMousePosition.Y);

            GraphicsControl.CaptureMouse();
            GraphicsControl.Focus();
        }

        private void OnGraphicsControlHwndLButtonUp(object sender, MouseEventArgs e)
        {
            _output.AppendLine("Mouse left button up");
            GraphicsControl.ReleaseMouseCapture();

            _mouseDown = false;
        }

        private void OnGraphicsControlKeyDown(object sender, KeyEventArgs e)
        {
            _output.AppendLine("Key down: " + e.Key);
        }

        private void OnGraphicsControlKeyUp(object sender, KeyEventArgs e)
        {
            _output.AppendLine("Key up: " + e.Key);
        }

        private void OnGraphicsControlHwndMouseWheel(object sender, MouseWheelEventArgs e)
        {
            _output.AppendLine("Mouse wheel: " + e.Delta);
        }
    }
}
