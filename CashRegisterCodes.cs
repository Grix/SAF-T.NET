namespace Softcash.SAFT
{
    public class CashRegisterCodes
    {
        private CashRegisterCodes() { }

        public class StandardVatCode
        {
            public static readonly string ZeroRate = "0";
            public static readonly string LowRate = "33";
            public static readonly string ReducedRate = "31";
            public static readonly string RegularRate = "3";
        }

        public class BasicType
        {
            public static readonly string CostCodes = "01";
            public static readonly string ProductCodes = "02";
            public static readonly string ProjectCodes = "03";
            public static readonly string ArticleGroupCodes = "04";
            public static readonly string TicketLineCodes = "05";
            public static readonly string LoggingCodes = "06";
            public static readonly string SavingsCodes = "07";
            public static readonly string DiscountCodes = "08";
            public static readonly string QuantityCodes = "09";
            public static readonly string RaiseCodes = "10";
            public static readonly string TransactionCodes = "11";
            public static readonly string PaymentCodes = "12";
            public static readonly string EventCodes = "13";
            public static readonly string SerivceCode = "14";
            public static readonly string UserCodes = "15";
            public static readonly string Other = "16";
        }

        public class ArticleGroupCode
        {
            public static readonly string WithdrawalOfTreatmentServices = "04001";
            public static readonly string WithdrawalOfGoodsUsedForTreatmentServices = "04002";
            public static readonly string SaleOfGoods = "04003";
            public static readonly string SaleOfTreatmentServices = "04004";
            public static readonly string SaleOfHaircut = "04005";
            public static readonly string Food = "04006";
            public static readonly string Beer = "04007";
            public static readonly string Wine = "04008";
            public static readonly string Liquor = "04009";
            public static readonly string Alcopops_Cider = "04010";
            public static readonly string MineralWater = "04011";
            public static readonly string OtherDrinks = "04012";
            public static readonly string Tobacco = "04013";
            public static readonly string OtherGoods = "04014";
            public static readonly string EntranceFee = "04015";
            public static readonly string FreeEntrance = "04016";
            public static readonly string CloakroomFee = "04017";
            public static readonly string FreeCloakroom = "04018";
            public static readonly string AccomodationFullBoard = "04019";
            public static readonly string AccomodationHalfBoard = "04020";
            public static readonly string AccomodationWithBreakfast = "04021";
            public static readonly string Other = "04999";
        }

        public class RaiseCode
        {
            public static readonly string TipAmount = "10001";
            public static readonly string Other = "10999";
        }

        public class TransactionCode
        {
            public static readonly string CashSale = "11001";
            public static readonly string CreditSale = "11002";
            public static readonly string Purchase = "11003";
            public static readonly string Payment = "11004";
            public static readonly string ReceivingPayment = "11005";
            public static readonly string ReturnPayment = "11006";
            public static readonly string CashDeclaration = "11007";
            public static readonly string CashDifference = "11008";
            public static readonly string Correction = "11009";
            public static readonly string OutPayment = "11010";
            public static readonly string InPayment = "11011";
            public static readonly string TradeInExchange = "11012";
            public static readonly string ReturnProducts = "11013";
            public static readonly string InventoryStock = "11014";
            public static readonly string Other = "11999";
        }

        public class PaymentCode
        {
            public static readonly string Cash = "12001";
            public static readonly string Debitcard = "12002";
            public static readonly string Creditcard = "12003";
            public static readonly string Bankaccount = "12004";
            public static readonly string Gifttoken = "12005";
            public static readonly string Customercard = "12006";
            public static readonly string Loyaltystamps = "12007";
            public static readonly string BottleDeposit = "12008";
            public static readonly string Check = "12009";
            public static readonly string Creditnote = "12010";
            public static readonly string MobilePhoneApps = "12011";
            public static readonly string Other = "12999";
        }

        public class EventCode
        {
            public static readonly string POSApplicationStart = "13001";
            public static readonly string POSApplicationShutdown = "13002";
            public static readonly string EmployeeLogin = "13003";
            public static readonly string EmployeeLogout = "13004";
            public static readonly string OpenCashdrawer = "13005";
            public static readonly string CloseCashdrawer = "13006";
            public static readonly string UpdateofPOSApplication = "13007";
            public static readonly string XReport = "13008";
            public static readonly string ZReport = "13009";
            public static readonly string SuspendTransaction = "13010";
            public static readonly string ResumeTransaction = "13011";
            public static readonly string SalesReceipt = "13012";
            public static readonly string ReturnReceipt = "13013";
            public static readonly string CopyReceipt = "13014";
            public static readonly string ProformaReceipt = "13015";
            public static readonly string DeliveryReceipt = "13016";
            public static readonly string TrainingReceipt = "13017";
            public static readonly string OtherReportsOrReceipts = "13018";
            public static readonly string CashWithdrawal = "13019";
            public static readonly string ExportOfJournalToExternalStorage = "13020";
            public static readonly string PriceChange = "13021";
            public static readonly string PriceLookup = "13022";
            public static readonly string TrainingModeOn = "13023";
            public static readonly string TrainingModeOff = "13024";
            public static readonly string MemoryFull = "13025";
            public static readonly string Other = "13999";
        }
    }
}
