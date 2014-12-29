using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gift_WebServices.CSharp
{
    public class TOKEN
    {
        // Transaction Varialbles
        private static string merchantID = "023358150511666";
        private static string password = "xyz";
        private static string invoiceNo = string.Empty;
        private static string memo = "Testing: WebServices.CSharp";
        private static decimal purchase = 2.25m;
        private static string operatorID = "test";
       
        // Gift Test Card
        private static string swipedGiftTrack2 = "6050110010021825160=250110115";
        private static string keyedGiftAcctNo = "6050110010021825160";
        private static string keyedGiftExpDate = "0125";

        public void Run()
        {
            PrePaidBalanceSwiped();
            PrePaidNoNSFSaleSwiped();
            PrePaidReloadSwiped();
            PrePaidBalanceKeyed();
            PrePaidNoNSFSaleKeyed();
            PrePaidReloadKeyed();

            Console.Write("End of samples");
            Console.ReadLine();
        }
     
        private static void PrePaidBalanceSwiped()
        {
            Console.Write("Hit Enter to run PrePaid Balance (Swiped)");
            Console.ReadLine();

            invoiceNo = NewInvoiceNo();

            // Create Request KeyValuePairs
            Dictionary<string, object> requestDictionary = new Dictionary<string, object>();
            requestDictionary.Add("MerchantID", merchantID);
            requestDictionary.Add("IpPort", "9100");
            requestDictionary.Add("TranType", "PrePaid");
            requestDictionary.Add("TranCode", "Balance");
            requestDictionary.Add("InvoiceNo", invoiceNo);
            requestDictionary.Add("RefNo", invoiceNo);
            requestDictionary.Add("Memo", memo);
            requestDictionary.Add("Track2", swipedGiftTrack2);
            requestDictionary.Add("OperatorID", operatorID);

            // Process Transaction and get Response KeyValuePairs           
            Dictionary<string, string> responseDictionary = ProcessGiftTransaction(requestDictionary, password);

            DisplayResponseKeyValuePairs(responseDictionary, "PrePaid", "Balance");
        }

        private static void PrePaidNoNSFSaleSwiped()
        {
            Console.Write("Hit Enter to run PrePaid NoNSFSale (Swiped)");
            Console.ReadLine();

            invoiceNo = NewInvoiceNo();

            // Create Request KeyValuePairs
            Dictionary<string, object> requestDictionary = new Dictionary<string, object>();
            requestDictionary.Add("MerchantID", merchantID);
            requestDictionary.Add("IpPort", "9100");
            requestDictionary.Add("TranType", "PrePaid");
            requestDictionary.Add("TranCode", "NoNSFSale");
            requestDictionary.Add("InvoiceNo", invoiceNo);
            requestDictionary.Add("RefNo", invoiceNo);
            requestDictionary.Add("Memo", memo);
            requestDictionary.Add("Track2", swipedGiftTrack2);
            requestDictionary.Add("Purchase", purchase);
            requestDictionary.Add("OperatorID", operatorID);

            // Process Transaction and get Response KeyValuePairs           
            Dictionary<string, string> responseDictionary = ProcessGiftTransaction(requestDictionary, password);

            DisplayResponseKeyValuePairs(responseDictionary, "PrePaid", "NoNSFSale");
        }

        private static void PrePaidReloadSwiped()
        {
            Console.Write("Hit Enter to run PrePaid Reload (Swiped)");
            Console.ReadLine();

            invoiceNo = NewInvoiceNo();

            // Create Request KeyValuePairs
            Dictionary<string, object> requestDictionary = new Dictionary<string, object>();
            requestDictionary.Add("MerchantID", merchantID);
            requestDictionary.Add("IpPort", "9100");
            requestDictionary.Add("TranType", "PrePaid");
            requestDictionary.Add("TranCode", "Reload");
            requestDictionary.Add("InvoiceNo", invoiceNo);
            requestDictionary.Add("RefNo", invoiceNo);
            requestDictionary.Add("Memo", memo);
            requestDictionary.Add("Track2", swipedGiftTrack2);
            requestDictionary.Add("Purchase", purchase);
            requestDictionary.Add("OperatorID", operatorID);

            // Process Transaction and get Response KeyValuePairs           
            Dictionary<string, string> responseDictionary = ProcessGiftTransaction(requestDictionary, password);

            DisplayResponseKeyValuePairs(responseDictionary, "PrePaid", "Reload");
        }

        private static void PrePaidBalanceKeyed()
        {
            Console.Write("Hit Enter to run PrePaid Balance (Keyed)");
            Console.ReadLine();

            invoiceNo = NewInvoiceNo();

            // Create Request KeyValuePairs
            Dictionary<string, object> requestDictionary = new Dictionary<string, object>();
            requestDictionary.Add("MerchantID", merchantID);
            requestDictionary.Add("IpPort", "9100");
            requestDictionary.Add("TranType", "PrePaid");
            requestDictionary.Add("TranCode", "Balance");
            requestDictionary.Add("InvoiceNo", invoiceNo);
            requestDictionary.Add("RefNo", invoiceNo);
            requestDictionary.Add("Memo", memo);
            requestDictionary.Add("AcctNo", keyedGiftAcctNo);
            requestDictionary.Add("ExpDate", keyedGiftExpDate);
            requestDictionary.Add("OperatorID", operatorID);

            // Process Transaction and get Response KeyValuePairs           
            Dictionary<string, string> responseDictionary = ProcessGiftTransaction(requestDictionary, password);

            DisplayResponseKeyValuePairs(responseDictionary, "PrePaid", "Balance");
        }

        private static void PrePaidNoNSFSaleKeyed()
        {
            Console.Write("Hit Enter to run PrePaid NoNSFSale (Keyed)");
            Console.ReadLine();

            invoiceNo = NewInvoiceNo();

            // Create Request KeyValuePairs
            Dictionary<string, object> requestDictionary = new Dictionary<string, object>();
            requestDictionary.Add("MerchantID", merchantID);
            requestDictionary.Add("IpPort", "9100");
            requestDictionary.Add("TranType", "PrePaid");
            requestDictionary.Add("TranCode", "NoNSFSale");
            requestDictionary.Add("InvoiceNo", invoiceNo);
            requestDictionary.Add("RefNo", invoiceNo);
            requestDictionary.Add("Memo", memo);
            requestDictionary.Add("AcctNo", keyedGiftAcctNo);
            requestDictionary.Add("ExpDate", keyedGiftExpDate);
            requestDictionary.Add("Purchase", purchase);
            requestDictionary.Add("OperatorID", operatorID);

            // Process Transaction and get Response KeyValuePairs           
            Dictionary<string, string> responseDictionary = ProcessGiftTransaction(requestDictionary, password);

            DisplayResponseKeyValuePairs(responseDictionary, "PrePaid", "NoNSFSale");
        }

        private static void PrePaidReloadKeyed()
        {
            Console.Write("Hit Enter to run PrePaid Reload (Keyed)");
            Console.ReadLine();

            invoiceNo = NewInvoiceNo();

            // Create Request KeyValuePairs
            Dictionary<string, object> requestDictionary = new Dictionary<string, object>();
            requestDictionary.Add("MerchantID", merchantID);
            requestDictionary.Add("IpPort", "9100");
            requestDictionary.Add("TranType", "PrePaid");
            requestDictionary.Add("TranCode", "Reload");
            requestDictionary.Add("InvoiceNo", invoiceNo);
            requestDictionary.Add("RefNo", invoiceNo);
            requestDictionary.Add("Memo", memo);
            requestDictionary.Add("AcctNo", keyedGiftAcctNo);
            requestDictionary.Add("ExpDate", keyedGiftExpDate);
            requestDictionary.Add("Purchase", purchase);
            requestDictionary.Add("OperatorID", operatorID);

            // Process Transaction and get Response KeyValuePairs           
            Dictionary<string, string> responseDictionary = ProcessGiftTransaction(requestDictionary, password);

            DisplayResponseKeyValuePairs(responseDictionary, "PrePaid", "Reload");
        }

        private static string NewInvoiceNo()
        {
            return DateTime.Now.ToString("yyMMddhhmmssfff");
        }

        private static Dictionary<string, string> ProcessCreditTransaction(Dictionary<string, object> requestDictionary, string password)
        {
            // Build XML Request from KeyValuePairs
            string xmlRequest = XMLHelper.BuildXMLRequest(requestDictionary).ToString();
            string xmlResponse = string.Empty;

            using (MercuryWebServices.wsSoapClient client = new MercuryWebServices.wsSoapClient())
            {
                Console.WriteLine("Processing Credit Transaction...");
                xmlResponse = client.CreditTransaction(xmlRequest, password);
            }

            // Parse XML Response into KeyValuePairs
            return XMLHelper.ParseXMLResponse(xmlResponse);
        }

        private static Dictionary<string, string> ProcessGiftTransaction(Dictionary<string, object> requestDictionary, string password)
        {
            // Build XML Request from KeyValuePairs
            string xmlRequest = XMLHelper.BuildXMLRequest(requestDictionary).ToString();
            string xmlResponse = string.Empty;

            using (MercuryWebServices.wsSoapClient client = new MercuryWebServices.wsSoapClient())
            {
                Console.WriteLine("Processing Gift Transaction...");
                xmlResponse = client.GiftTransaction(xmlRequest, password);
            }

            // Parse XML Response into KeyValuePairs
            return XMLHelper.ParseXMLResponse(xmlResponse);
        }

        private static void DisplayResponseKeyValuePairs(Dictionary<string, string> responseDictionary, string tranType, string tranCode)
        {
            Console.WriteLine();
            Console.WriteLine(string.Format("--- Response Key Value Pairs for {0} {1} ---", tranType, tranCode));

            foreach (KeyValuePair<string, string> kvp in responseDictionary)
            {
                Console.WriteLine(string.Format("{0}:{1};", kvp.Key, kvp.Value));
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
