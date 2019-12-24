using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ballfurious
{
    public class Food
    {
        Dictionary<FoodType, Image> d = null;

        private Ground _g;
        public Ground GroundArea
        {
            set
            {
                _g = value;
            }
        }

        public Food(Ground pG)
        {
            _g = pG;

            InitiateFoodImages();
        }

        public void InitiateFoodImages()
        {
            d = new Dictionary<FoodType, Image>(10);
            try
            {
                d.Add(FoodType.Apple, Image.FromFile("Icons/apple.ico"));
                d.Add(FoodType.Banana, Image.FromFile("Icons/banana.ico"));
                d.Add(FoodType.Grape, Image.FromFile("Icons/grape.ico"));
                d.Add(FoodType.Orange, Image.FromFile("Icons/orange.ico"));
                d.Add(FoodType.Papaya, Image.FromFile("Icons/papaya.ico"));
                d.Add(FoodType.Pineapple, Image.FromFile("Icons/pineapple.ico"));
                d.Add(FoodType.Strawberry, Image.FromFile("Icons/strawberry.ico"));
                d.Add(FoodType.Watermelon, Image.FromFile("Icons/watermelon.ico"));
            }
            catch
            {
                ;;
            }
        }

        public Point GetFoodLocation()
        {
            Point p = new Point();
            Random r = new Random();

            p.X = r.Next(_g.Width);
            p.Y = r.Next(_g.Height);

            return p;
        }

        public FoodType GetFoodType()
        {
            return (FoodType)(new Random().Next(7));
        }

        public Image GetImageForFoodItem(FoodType ft)
        {
            if (d == null || (!d.ContainsKey(ft)))
                return null;

            // Return the image
            return d[ft];
        }
    }
}
