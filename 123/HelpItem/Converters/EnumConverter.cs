using System;
using System.Globalization;
using System.Windows.Data;

namespace _123
{
    class EnumConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (value == null) return "";
            if (value is Tag)
            {
                switch ((Tag)value)
                {
                    case Tag.Comedy:
                        {
                            return "Комедия";
                        }
                    case Tag.Drama:
                        {
                            return "Драма";
                        }
                    case Tag.Horror:
                        {
                            return "Хоррор";
                        }
                    case Tag.Thriller:
                        {
                            return "Детектив";
                        }
                }
            }
            else
            {
                switch ((IventType)value)
                {
                    case IventType.Concert:
                        {
                            return "Концерт";
                        }
                    case IventType.Film:
                        {
                            return "Фильм";
                        }
                    case IventType.Piece:
                        {
                            return "Пьеса";
                        }
                    
                }
            }
            return "";
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {

            if (value == null) return "";
            switch (value.ToString())
            {
                case "Концерт":
                    {
                        return IventType.Concert;
                    }
                case "Фильм":
                    {
                        return IventType.Film;
                    }
                case "Пьеса":
                    {
                        return IventType.Piece;
                    }
                case "Комедия":
                    {
                        return Tag.Comedy;
                    }
                case "Драма":
                    {
                        return Tag.Drama;
                    }
                case "Детектив":
                    {
                        return Tag.Thriller;
                    }
                case "Хоррор":
                    {
                        return Tag.Horror;
                    }
            }
            return null;
        }
    }
}
