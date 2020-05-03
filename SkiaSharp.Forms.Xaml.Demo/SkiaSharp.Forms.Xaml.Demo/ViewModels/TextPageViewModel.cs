using System;
using System.Collections.Generic;
using System.Text;

namespace SkiaSharp.Forms.Xaml.Demo.ViewModels
{
    public class TextPageViewModel : BaseViewModel
    {
        private float positionX;
        private float positionY;
        private float textSize;
        private string text;

        public float PositionX
        {
            get => positionX;
            set => SetProperty(ref positionX, value);
        }

        public float PositionY
        {
            get => positionY;
            set => SetProperty(ref positionY, value);
        }

        public float TextSize
        {
            get => textSize;
            set => SetProperty(ref textSize, value);
        }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public TextPageViewModel()
        {
            PositionX = 800;
            PositionY = 800;
            TextSize = 80;
            Text = "Welcome from Xaml-Skia!";
        }
    }
}
