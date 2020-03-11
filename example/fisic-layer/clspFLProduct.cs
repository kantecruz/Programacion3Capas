using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example.fisic_layer
{
    public class clspFLProduct
    {
        private Int32 _idProduct;
        private clspFLTypeProduct _typeProduct;                
        private String _name;
        private decimal _price;
        private DateTime _dateOn;
        private bool _active;
        
        public Int32 idProduct{
            get{
                return _idProduct;
            }
            set{
                _idProduct = value;
            }
        }
        public clspFLTypeProduct typeProduct
        {
            get{
                return _typeProduct;
            }
            set{
                _typeProduct = value;
            }
        }

        public String name{
            get{
                return _name;
            }
            set{
                _name = value.Trim();
            }
        }
        public decimal price
        {
            get{
                return _price;
            }
            set{
                _price = value;
            }
        }
        public DateTime dateOn
        {
            get{
                return _dateOn;
            }
            set{
                _dateOn = value;
            }
        }
        public bool active
        {
            get{
                return _active;
            }
            set{
                _active = value;
            }
        }

        
        public clspFLProduct()
        {
            this.idProduct = 0;
            this.typeProduct = new clspFLTypeProduct();            
        }       
    }
}