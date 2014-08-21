using System;
using System.Collections.Generic;

namespace Gift_WebServices.CSharp
{
    public class E2ETKN 
    {
        // Transaction Varialbles
        private static string merchantID = "118725340908147";
        private static string password = "xyz";
        private static string invoiceNo = string.Empty;
        private static string memo = "Testing: Gift_WebServices.CSharp";
        private static decimal purchase = 2.25m;
        private static string operatorID = "test";

        // Test Gift Card # 6050110010021825160
        private static string swipedGiftTrack2EncryptedBlock = "FFFBE71805C791341D15F948ECDFE50134B5903A9E12DBF8CB940547D0DB53BB";
        private static string swipedGiftTrack2EncryptedKey = "9500030000039420016E";
        private static string keyedGiftEncryptedBlock = "DB1E14F6686E2B7FE7C11765046ECA13B99971ED642BC1CEB8DF746A0692CC3AEE5425BC8E1FF126";
        private static string keyedGiftEncryptedKey = "9500030000039420016F";

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
            requestDictionary.Add("EncryptedFormat", "MagneSafe");
            requestDictionary.Add("AccountSource", "Swiped");
            requestDictionary.Add("EncryptedBlock", swipedGiftTrack2EncryptedBlock);
            requestDictionary.Add("EncryptedKey", swipedGiftTrack2EncryptedKey);
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
            requestDictionary.Add("EncryptedFormat", "MagneSafe");
            requestDictionary.Add("AccountSource", "Swiped");
            requestDictionary.Add("EncryptedBlock", swipedGiftTrack2EncryptedBlock);
            requestDictionary.Add("EncryptedKey", swipedGiftTrack2EncryptedKey);
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
            requestDictionary.Add("EncryptedFormat", "MagneSafe");
            requestDictionary.Add("AccountSource", "Swiped");
            requestDictionary.Add("EncryptedBlock", swipedGiftTrack2EncryptedBlock);
            requestDictionary.Add("EncryptedKey", swipedGiftTrack2EncryptedKey);
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
            requestDictionary.Add("EncryptedFormat", "MagneSafe");
            requestDictionary.Add("AccountSource", "Keyed");
            requestDictionary.Add("EncryptedBlock", keyedGiftEncryptedBlock);
            requestDictionary.Add("EncryptedKey", keyedGiftEncryptedKey);
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
            requestDictionary.Add("EncryptedFormat", "MagneSafe");
            requestDictionary.Add("AccountSource", "Keyed");
            requestDictionary.Add("EncryptedBlock", keyedGiftEncryptedBlock);
            requestDictionary.Add("EncryptedKey", keyedGiftEncryptedKey);
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
            requestDictionary.Add("EncryptedFormat", "MagneSafe");
            requestDictionary.Add("AccountSource", "Keyed");
            requestDictionary.Add("EncryptedBlock", keyedGiftEncryptedBlock);
            requestDictionary.Add("EncryptedKey", keyedGiftEncryptedKey);
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
