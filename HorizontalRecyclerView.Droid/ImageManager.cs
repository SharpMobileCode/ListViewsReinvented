using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.Content.Res;
using Android.Graphics;

namespace HorizontalRecyclerView.Droid
{
    public class ImageManager : IDisposable
    {
        private readonly Dictionary<int, Bitmap> _imageCache = new Dictionary<int, Bitmap>();
        private Resources _resources;

        public ImageManager(Resources resources)
        {
            _resources = resources;
        }

        private Task<BitmapFactory.Options> GetBitmapOptionsOfImageAsync(int resourceId)
        {
            return Task.Run(() => GetBitmapOptionsOfImage(resourceId));
        }

        private BitmapFactory.Options GetBitmapOptionsOfImage(int resourceId)
        {
            var options = new BitmapFactory.Options
            {
                InJustDecodeBounds = true
            };

            var result = BitmapFactory.DecodeResource(_resources, resourceId, options);

            return options;
        }

        private int CalculateInSampleSize(BitmapFactory.Options options, int reqWidth, int reqHeight)
        {
            float height = options.OutHeight;
            float width = options.OutWidth;
            double inSampleSize = 1D;

            if (height > reqHeight || width > reqWidth)
            {
                int halfHeight = (int)(height / 2);
                int halfWidth = (int)(width / 2);

                while ((halfHeight / inSampleSize) > reqHeight && (halfWidth / inSampleSize) > reqWidth)
                {
                    inSampleSize *= 2;
                }

            }

            return (int)inSampleSize;
        }

        private Task<Bitmap> LoadScaledDownBitmapForDisplayAsync(BitmapFactory.Options options, int resourceId, int reqWidth, int reqHeight)
        {
            return Task.Run(() => LoadScaledDownBitmapForDisplay(options, resourceId, reqWidth, reqHeight));
        }

        private Bitmap LoadScaledDownBitmapForDisplay(BitmapFactory.Options options, int resourceId, int reqWidth, int reqHeight)
        {
            options.InSampleSize = CalculateInSampleSize(options, reqWidth, reqHeight);
            options.InJustDecodeBounds = false;

            var bitmap = BitmapFactory.DecodeResource(_resources, resourceId, options);

            return bitmap;
        }

        public Task<Bitmap> GetScaledDownBitmapFromResourceAsync(int resourceId, int requiredWidth, int requiredHeight)
        {
            return Task.Run(() => GetScaledDownBitmapFromResource(resourceId, requiredWidth, requiredHeight));
            
        }

        public Bitmap GetScaledDownBitmapFromResource(int resourceId, int requiredWidth, int requiredHeight)
        {
            Bitmap bitmap;
            if(_imageCache.TryGetValue(resourceId, out bitmap))
            {
                return bitmap;
            }

            var options = GetBitmapOptionsOfImage(resourceId);
            bitmap = LoadScaledDownBitmapForDisplay(options, resourceId, requiredWidth, requiredHeight);

            _imageCache.Add(resourceId, bitmap);

            return bitmap;
        }

        #region IDisposable implementation

        public void Dispose()
        {
            if(_imageCache == null)
                return;

            foreach(var key in _imageCache.Keys)
            {
                Bitmap bitmap;
                if(_imageCache.TryGetValue(key, out bitmap))
                {
                    Console.WriteLine(String.Format("Recycling bitmap {0} . . .", key));
                    bitmap.Recycle();
                }
            }
            _imageCache.Clear();
        }

        #endregion
    }
}

