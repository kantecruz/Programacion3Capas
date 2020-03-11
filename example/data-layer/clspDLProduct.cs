using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using example.fisic_layer;
using example.tools;

namespace example.data_layer
{
    public static class clspDLProduct
    {
        public static Int32 queryToDataBase(ref List<clspFLProduct> vflListProduct, clspSQLServer vsqlServer)
        {
            clspFLProduct vflProduct = new clspFLProduct();
            try
            {
                String vsql = "SELECT P.id_product, P.fldname, P.fldprice, P.flddateOn, P.fldactive, TP.flddescription ";
                       vsql += "FROM dbo.c_typeProduct AS TP INNER JOIN ";
                       vsql += "dbo.product AS P ON TP.id_typeProduct = P.id_fktypeProduct ";

                vsqlServer.openConnection();
                SqlDataReader vrow = vsqlServer.executeQuery(vsql);
                if (vrow.HasRows){
                    while (vrow.Read())
                    {
                        vflProduct.idProduct = Convert.ToInt32(vrow.GetValue(vrow.GetOrdinal("id_product")));
                        vflProduct.typeProduct.description = vrow.GetValue(vrow.GetOrdinal("flddescription")).ToString();
                        vflProduct.name = vrow.GetValue(vrow.GetOrdinal("fldname")).ToString();
                        vflProduct.price = Convert.ToDecimal(vrow.GetValue(vrow.GetOrdinal("fldprice")));
                        vflProduct.dateOn = Convert.ToDateTime(vrow.GetValue(vrow.GetOrdinal("flddateOn")));
                        vflProduct.active = Convert.ToBoolean(vrow.GetValue(vrow.GetOrdinal("fldactive")));
                        vflListProduct.Add(vflProduct);
                    }
                }
                else{
                    vsqlServer.closeQuery();
                    return 0;
                }

                vsqlServer.closeQuery();
                return 1;
            }
            catch (Exception vexception){
                throw new Exception(vexception.Message, vexception.InnerException);
            }
        }

      
    }
}