using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFramework.BillGeneration
{
    //Create a Class by name Bill
 //Bill has properties: BillNo, BillDate, BillHolder, BillAmount
 //Create a class called Item: Id, Perticulars, UnitPrice, Quantity
 //Create a Program the provides Itemized billing for a given Customer.
    class Item
    {
        public int ItemId { get; set; }
        public string ItemPerticular { get; set; }
        public double ItemUnitPrice { get; set; }
        public int ItemQuantity { get; set; }
    }
    class Bill
    {
        private static int id = 0;
        public List<Item> BillItemList { get; set; }
        
        public int BillNo { get; set; }
        public DateTime BillDate { get; set; } = new DateTime();

        public string BillHolder { get; set; }
        public double BillAmount { get; private set; }
        public Bill(){
            id++;
            BillNo = id;
            }
        public void AddBillAmount(double amount)
        {
            BillAmount += amount;
        }

    }
    class Shopmanager
    {
        static List<Item> p  = new List<Item>();
        static List<Bill> BillList = new List<Bill>();
        //public HashSet<Item> ItemList { get; set; }
        public HashSet<Item> ItemList = new HashSet<Item>();
        public Shopmanager()
        {
            ItemList.Add(new Item { ItemId=1,ItemPerticular = "Bottle", ItemUnitPrice = 100 });
            ItemList.Add(new Item { ItemId = 2, ItemPerticular = "Pen", ItemUnitPrice = 80 });
            ItemList.Add(new Item {  ItemId=3,ItemPerticular = "Book", ItemUnitPrice = 60 });
            ItemList.Add(new Item {  ItemId=4,ItemPerticular = "Bag", ItemUnitPrice = 200 });
            ItemList.Add(new Item { ItemId=5,ItemPerticular = "Pencil", ItemUnitPrice = 12 });

        }
        public  Item findItem(int id)
        {
            foreach (var item in ItemList)
            {
                if (item.ItemId == id)
                    return item;
            }
            return null;
        }
        public void displayItems()
        {
            foreach (var item in ItemList)
            {
                Console.WriteLine($"{item.ItemPerticular.ToUpper()} ---{item.ItemUnitPrice}/- :------ ItemId:{item.ItemId}");
            }
        }
        public Bill newBill = new Bill();
        
    }
}
