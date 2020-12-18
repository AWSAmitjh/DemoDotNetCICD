using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApplication.Controllers
{
    public class HomeController : Controller
    {
        static IAmazonS3 client;
        public IActionResult Index()
        {
            ViewData["Message"] = "Deployed using AWS Code* Services !!";            
            return View();
        }



        //ViewData["Message"] = ListingBuckets();
        public IActionResult Error()
        {
            ViewData["Message"] = "We've encountered an error :(";
            return View();
        }

        static string ListingBuckets()
        {
            string strS3buckets = "You own Bucket count: ";
            try
            {
                
                client = new AmazonS3Client();
                Task<ListBucketsResponse> response = ListBucketsAsync();
                strS3buckets = strS3buckets + " : " + response.Result.Buckets.Count;
                return strS3buckets;
            }
            catch (AmazonS3Exception amazonS3Exception)
            {
                return strS3buckets;            
            }
        }

        // Async method to get a list of Amazon S3 buckets.
        private static async Task<ListBucketsResponse> ListBucketsAsync()
        {         
            var response = await client.ListBucketsAsync();
            return response;
        }
    }
}
