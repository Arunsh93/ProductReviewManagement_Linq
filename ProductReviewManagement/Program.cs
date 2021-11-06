using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product review management problem statement");

            List<ProductManagement> ProductReviewlist = new List<ProductManagement>()
            {
                 new ProductManagement(){ProductID=1,UserID=1,Rating=5,Review="Good",isLike=true},
                 new ProductManagement(){ProductID=2,UserID=1,Rating=4,Review="Good",isLike=true},
                 new ProductManagement(){ProductID=3,UserID=2,Rating=2,Review="Good",isLike=true},
                 new ProductManagement(){ProductID=4,UserID=2,Rating=4,Review="Good",isLike=true},
                 new ProductManagement(){ProductID=5,UserID=3,Rating=2,Review="nice",isLike=false},
                 new ProductManagement(){ProductID=9,UserID=4,Rating=5,Review="Bad",isLike=false},
                 new ProductManagement(){ProductID=1,UserID=3,Rating=1,Review="Good",isLike=false},
                 new ProductManagement(){ProductID=11,UserID=10,Rating=3,Review="Good",isLike=true},
                 new ProductManagement(){ProductID=10,UserID=10,Rating=3,Review="Good",isLike=true},
                 new ProductManagement(){ProductID=12,UserID=10,Rating=3,Review="Good",isLike=true},
                 new ProductManagement(){ProductID=13,UserID=10,Rating=3,Review="Good",isLike=true},
                 new ProductManagement(){ProductID=14,UserID=10,Rating=3,Review="Good",isLike=true},
                 new ProductManagement(){ProductID=15,UserID=10,Rating=3,Review="Good",isLike=true},
                 new ProductManagement(){ProductID=13,UserID=1,Rating=2,Review="Good",isLike=true},
                 new ProductManagement(){ProductID=16,UserID=10,Rating=3,Review="Good",isLike=true}
            };
            //foreach(var list in ProductReviewlist)
            //{
            //    Console.WriteLine("ProductID:-"+list.ProductID+" "+"UserID:-"+list.UserID+" "+"Rating:-"+list.Rating+" "+"Review:-"+list.Review+" "+"isLike:-"+list.isLike);
            //}

            Management management = new Management();
            //Uc-2
            //management.TopRecords(ProductReviewlist);

            //uc-3
            //management.SelectedRecords(ProductReviewlist);

            //uc-4
            management.RetrieveCountOfRecords(ProductReviewlist);

            //UC5
            management.RetrieveProductID_Review(ProductReviewlist);

            //UC6
            management.SkipTop5Records(ProductReviewlist);
        }
    }
}
