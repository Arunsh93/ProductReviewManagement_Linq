using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagement
{
    public class Management
    {
        public DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductManagement> listProductReview)
        {
            var recordsData = (from productreviews in listProductReview
                               orderby productreviews.Rating descending
                               select productreviews).Take(3);

            foreach (var list in recordsData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            }
        }

        public void SelectedRecords(List<ProductManagement> listProductReview)
        {
            var recordData = from productReviews in listProductReview
                             where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9) &&
                             productReviews.Rating > 3
                             select productReviews;

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            }
        }

        public void RetrieveCountOfRecords(List<ProductManagement> listProductReview)
        {
            var RecordData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });


            foreach (var list in RecordData)
            {
                Console.WriteLine(list.ProductID + "------- " + list.Count);
            }
        }

        public void RetrieveProductID_Review(List<ProductManagement> listProductReview)
        {
            var recordedData = listProductReview.Select(x => new { ProductID = x.ProductID, ProductReview = x.Review });
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "Review:- " + list.ProductReview);
            }
        }

        public void SkipTop5Records(List<ProductManagement> listProductReview)
        {

            var recordedData = (from productReviews in listProductReview select productReviews).Skip(5).ToList(); ;
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                     + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }
        }
    }
}
