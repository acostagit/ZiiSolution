using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZiiSolution.ZiiSensor.Repositorio
{
    public class Base
    {

        private String _stringConexao = null;
        protected string ConsultarStringConexao()
        {
            if (this._stringConexao == null) _stringConexao = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return _stringConexao;
        }

       
        private String _stringConexaoDocs = null;
        //protected string ConsultarStringConexao()
        //{
        //    SqlConnection _stringConexao = new SqlConnection(ConfigurationManager.AppSettings["DefaultConnection"].ToString());
        //    //Conn.Open();

        //   // if (_stringConexao == null) _stringConexao = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        //    return _stringConexao;
        //}

        protected string ConsultarStringConexaoDocs()
        {
            if (this._stringConexaoDocs == null) _stringConexaoDocs = ConfigurationManager.ConnectionStrings["DocumentosConnection"].ConnectionString;
            return _stringConexaoDocs;
        }
        protected static T CarregarTipo<T>(SqlDataReader dr)
        {

            T objItem = (T)Activator.CreateInstance(typeof(T));

            for (int i = 0; i <= dr.FieldCount - 1; i++)
            {
                PropertyInfo item = objItem.GetType().GetProperty(dr.GetName(i));

                if ((item != null))
                {
                    object value = null;

                    if (object.ReferenceEquals(dr[i], DBNull.Value))
                    {

                        switch (Type.GetTypeCode(item.PropertyType))
                        {
                            case TypeCode.Int16:
                                value = 0;
                                break;
                            case TypeCode.Int32:
                                value = 0;
                                break;
                            case TypeCode.Int64:
                                value = 0;
                                break;
                            case TypeCode.DateTime:
                                value = DateTime.MinValue;
                                break;
                            case TypeCode.String:
                                value = String.Empty;
                                break;
                            case TypeCode.Char:
                                value = System.Convert.ToChar(value.ToString()[0]);
                                break;
                            default:
                                value = null;
                                break;
                        }
                    }
                    else
                    {
                        if (dr.GetDataTypeName(i).ToLower().Contains("uniqueidentifier")) value = dr[item.Name].ToString();
                        else value = dr[item.Name];
                    }

                    item.SetValue(objItem, value, null);

                }


            }

            return objItem;
        }
    }
}
