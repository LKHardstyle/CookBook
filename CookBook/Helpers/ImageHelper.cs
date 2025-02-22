﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Helpers
{
    internal class ImageHelper
    {
        public static Image PlaceholderImage
        {
            get
            {
                var executingAssemblyLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                var imagePath = Path.Combine(executingAssemblyLocation, "Assets\\Images\\recipe_placeholder_image.png");
                return Image.FromFile(imagePath);
            }
        }
        //Convert image that user can see into a format that can be stored in DB
        public static byte[] ConvertToDbImage(string imagePath)
        {
            FileInfo fileInfo = new FileInfo(imagePath);
            long bytes = fileInfo.Length;
            FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] convertedImage = binaryReader.ReadBytes((int)bytes);
            return convertedImage;
        }

        //Convert image from DB into format that user can see
        public static Image ConvertFromDbImage(byte[] bytes) 
        {
            using(MemoryStream ms = new MemoryStream(bytes))
            {
                Image convertedImage = Image.FromStream(ms);
                return convertedImage;
            }
        }        
    }
}
