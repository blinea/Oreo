using System;

namespace Oreo.Model
{
    struct Order
    {
        public int _id;
        public string _clientDocument;
        //private string _productId;

        public int Id
        {
            get { return _id; }
            set
            {
                if (value > 0 && value < 1000000000)
                {
                    _id = value;
                }
                else
                {
                    throw new ApplicationException("Invalid Order Id.");
                }
            }
        }

        public string ClientDocument
        {
            get { return _clientDocument; }
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    _clientDocument = value;
                }
                else
                {
                    throw new ApplicationException("Invalid Client Document.");
                }
            }
        }
        /*
        public string ProductId
        {
            get { return _productId; }
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    _productId = value;
                }
                else
                {
                    throw new ApplicationException("Invalid Product Id.");
                }
            }
        }
        */
        public Order(int id, string clientDocument)
        {
            _id = id;
            _clientDocument = clientDocument;
        }

        public override string ToString()
        {
            return "           Order ID = " + _id + " | Client Document = " + _clientDocument + "     ";
        }

    }
}
