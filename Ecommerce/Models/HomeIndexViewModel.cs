using Ecommerce.DAL;
using Ecommerce.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class HomeIndexViewModel
    {
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();

        public IEnumerable<Product> ListOfProducts { get; set; }

        public HomeIndexViewModel CreateModel()
        {
            return new HomeIndexViewModel
            {
                ListOfProducts = _unitOfWork.GetRepositoryInstance<Product>().GetAllRecords()
            };
        }
    }
}