using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example.fisic_layer
{
    public class clspFLTypeProduct
    {
        private Int32 _idTypeProduct;
        
        private String _description;
        
        
        public Int32 id_typeProduct
        {
            get{
                return _idTypeProduct;
            }
            set{
                _idTypeProduct = value;
            }
        }
  
    
        public String description
        {
            get{
                return _description;
            }
            set{
                _description = value.Trim();
            }
        }      

        
    }
}