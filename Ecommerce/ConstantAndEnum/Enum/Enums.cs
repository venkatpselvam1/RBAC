using System;
using System.Collections.Generic;
using System.Text;

namespace ConstantAndEnum.Enum
{
    public class Enums
    {
        public enum Roles
        {
            Admin = 0,
            Customer = 1
        }

        public enum Category
        {
            Men = 1,
            Women = 2,
            Kids = 3
        }

        public enum ClothType
        {
            Shirt = 1,
            TShirt = 2,
            Trousers = 3
        }
        public enum Color
        {
            Red = 1,
            Green = 2,
            Blue = 3
        }

        public enum FirstSizeCategory
        {
            Small = 1,
            Medium = 2,
            Long = 3,
            XLong = 4,
            XXLong = 5
        }

        public enum SecondSizeCategory
        {
            CM_42 = 1,
            CM_44 = 2,
            CM_46 = 3,
            CM_48 = 4,
            CM_49 = 5
        }
    }
}
