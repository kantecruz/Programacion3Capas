using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using example.fisic_layer;
using example.data_layer;
using example.tools;

namespace example.business_layer
{
    public static class clspBLProduct
    {
        public static Int32 queryToDataBase(ref List<clspFLProduct> vflListProduct, clspSQLServer vsqlServer) //AQUI en vez de retornar entero.. puedes retornar una lista o un objeto.. para no usar ref  y ya en tu vista o windows form solo invocas el metodo
        {
            try{
                return clspDLProduct.queryToDataBase(ref vflListProduct, vsqlServer);
            }
            catch (Exception vexception){
                throw new Exception(vexception.Message, vexception.InnerException);
            }
        }       
    }
}