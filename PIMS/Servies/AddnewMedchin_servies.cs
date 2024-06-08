using PIMS.DataSet;
using PIMS.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PIMS.Servies
{
    public class AddnewMedchin_servies
    {
        Repository _Repo;

        public object Medicines { get; internal set; }
        public object Parameters { get; internal set; }

        public AddnewMedchin_servies()
        {
            _Repo = new Repository();
        }
            
       

        public IEnumerable<Table_add_new_medchin> ListAll()
        {
            return _Repo.GetAll<Table_add_new_medchin> ().ToList();
        }

        public void AddData(string addiname, string addicode, string addisize, string addbrand, string addcategory, string addsupplier, string addbarcode,
            string addothers , int AddQty, int addtotalqty, DateTime prchsDate, DateTime mDate, DateTime expDate, int addprchsprc, int addminiprc, int addsellprc, int adddiscount, byte[] img)
        {
            var mydata = new Table_add_new_medchin
            {
                Itemname = addiname,
                Itemcode = addicode,
                Itemsize = addisize,
                Itembrand = addbrand,
                Itemcategory = addcategory,
                Itamsupplier = addsupplier,
                Itembarcode = addbarcode,
                others = addothers,
                Itemquantity = AddQty,
                Totalquantity = addtotalqty,
                Purchesdate = prchsDate,
                Mdate = mDate,
                Expdate = expDate,
                Purchaseprice = addprchsprc,
                Minimumprice = addminiprc,
                Sallingprice = addsellprc,
                Imag = img,



            };

            _Repo.AddData(mydata);
        }

        public void UpdateData(string upname, string upicode, string upsize, string upbrand, string upcategory, string upsupplier, string upbarcode,
            string upothers, int upQty, int uptotalqty, DateTime upprchsDate, DateTime upmDate, DateTime upexpDate, int upprchsprc, int upminiprc, int upsellprc, int updiscount)
        {
            var Qu = ListAll().SingleOrDefault(x => x.Itemcode == upicode);

            Qu.Itemname = upname;
            Qu.Itemsize = upsize;
            Qu.Itembrand = upbrand;
            Qu.Itemcategory = upcategory;
            Qu.Itamsupplier = upsupplier;
            Qu.Itembarcode = upbarcode;
            Qu.others = upothers;
            Qu.Itemquantity = upQty;
            Qu.Totalquantity = uptotalqty;
            Qu.Purchesdate = upprchsDate;
            Qu.Mdate = upmDate;
            Qu.Expdate = upexpDate;

            _Repo.UpdateData(Qu);
        }

        public void ResetData(string Deusername)
        {
            var Qu = _Repo.GetAll<Table_add_new_user>().Where(x => x.Username == Deusername).ToList();

            foreach (var item in Qu)
            {
                _Repo.DeleteData(item.Username);
            }
        }




    }
}
