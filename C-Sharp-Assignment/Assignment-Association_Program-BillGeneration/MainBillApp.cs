using SampleConsleApp.BillGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFramework.BillGeneration
{
    class MainBillApp
    {
        static int ItemManager(Shopmanager BillSystem)
        {
            var item = BillSystem.newBill;
            if (item.BillItemList == null) item.BillItemList = new List<Item>();
            //if (item == null) item = new List<Item>();
            BillSystem.displayItems();
            int id = Utilities.GetNumber("Enter Item Id \\ TO Generate Bill enter 0");
            if (id == 0) return 0;
            int Qnt = Utilities.GetNumber("Enter Qantity");
          
            if (item.BillItemList.Exists(e => e.ItemId == id))
            {
                item.BillItemList.Find(e => e.ItemId == id).ItemQuantity +=
                    Qnt;
            }
            else
            {
                var fItem = BillSystem.findItem(id);//    .Find((e) => e.ItemId == id);
                //if (item.BillItemList != null)
                    fItem.ItemQuantity = Qnt;

                item.BillItemList.Add(fItem);
            }
            return id;
            

        }
        static void Billmanager()
        {
            Shopmanager BillSystem = new Shopmanager();
            string CName = Utilities.Prompt("Enter Custmore Name"); 
            BillSystem.newBill.BillHolder = CName;
            while (Convert.ToBoolean(ItemManager(BillSystem)));
            GenerateBill(BillSystem.newBill);



        }

        private static void GenerateBill(Bill newBill)
        {
            Console.Clear();
            var newList = newBill.BillItemList;
            Console.WriteLine($"Bill Holder Name:{newBill.BillHolder}                                 Date: {newBill.BillDate}\nBill No: {newBill.BillNo}");
            double amount = 0;
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Perticula        Quantity        Rate        Total");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var i in newList)
            {
                if (i.ItemQuantity != 0)
                {
                    var price = i.ItemQuantity * i.ItemUnitPrice;
                    Console.WriteLine($"{i.ItemPerticular}        {i.ItemQuantity}        {i.ItemUnitPrice}        {price}");
                    amount += price;
                }
            }
            Console.WriteLine("-------------------------------------------------------");
            Utilities.Prompt($"Total Bill                           {amount}");
            newBill.AddBillAmount(amount);
            
        }

        public const string menu = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~BILL MANAGMENT SOFTWARE~~~~~~~~~~~~~~~~~~~\nTO ADD NEW ITEM------------------------>PRESS 1\nTO GENERATE BILL---------------->PRESS 2\nTO DELETE Customer------------------------->PRESS 3\nTO Display Customer ----------------->PRESS 4\nPS: ANY OTHER KEY IS CONSIDERED AS EXIT.....................................";
        static void Main(string[] args)
        {

            while (true)
            {
                Billmanager();
            }
           
        }
    }
}
