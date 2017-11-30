using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using ASF.Entities;
using ASF.Services.Contracts;
using ASF.UI.Process;

namespace ASF.UI.Process
{
    public class CartProcess : ProcessComponent
    {
        public List<Cart> SelectList()
        {
            var response = HttpGet<AllResponse>("rest/Cart/All", new Dictionary<string, object>(), MediaType.Json);
            return response.ResulstCart;
        }

        public void insertCart(Cart cart)
        {
            HttpPost<Cart>("rest/Cart/Add", cart, MediaType.Json);
        }
        public Cart findCart(int id)
        {
            var dic = new Dictionary<string, object>();
            dic.Add("Id", id);
            var response = HttpGet<FindResponse>("rest/Cart/Find", dic, MediaType.Json);
            return response.ResultCart;

        }

        public void editCart(Cart cart)
        {
            HttpPost<Cart>("rest/Cart/Edit", cart, MediaType.Json);
        }

        public void deteleCart(int id)
        {
            var dic = new Dictionary<string, object>();
            dic.Add("Id", id);
            HttpGet<Cart>("rest/Cart/Remove/{id}", dic, MediaType.Json);
        }
    }
}
