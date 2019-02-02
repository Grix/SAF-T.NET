/**
 * XSD Command: xsd /c /n:Softcash.SAFT.Auditfile Norwegian_SAF-T_Cash_Register_Schema_v_1.00.xsd /o:out /f
 * This file WAS auto-generated, but it has been modified (removal of duplicate classes etc.)
 */

namespace Softcash.SAFT.Auditfile
{
    using System;
    using System.Xml.Serialization;
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    [XmlRoot(Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO", IsNullable = false)]
    public partial class auditfile
    {
        public Header header;
        public Company company;
        [XmlAttribute(DataType = "ID")]
        public string Id;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class Header
    {
        public string fiscalYear;
        [XmlElement(DataType = "date")]
        public DateTime startDate;
        [XmlElement(DataType = "date")]
        public DateTime endDate;
        public Currencycode curCode;
        [XmlElement(DataType = "date")]
        public DateTime dateCreated;

        [XmlIgnore()]
        public DateTime timeCreated;
        [XmlElement(ElementName = "timeCreated")]
        public string _timeCreated
        {
            get
            {
                return timeCreated.ToString("HH:mm:ss");
            }
        }

        public string softwareDesc;
        public string softwareVersion;
        public string softwareCompanyName;
        public string auditfileVersion;
        public string headerComment;
        public string userID;
        public AuditfileSender auditfileSender;
    }

    [Serializable()]
    [XmlType(Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public enum Currencycode { AED, AFA, ALL, AMD, ANG, AOA, ARS, AUD, AWG, AZM, BAM, BBD, BDT, BGN, BHD, BIF, BMD, BND, BOB, BRL, BSD, BTN, BWP, BYR, BZD, CAD, CDF, CHF, CLP, CNY, COP, CRC, CSD, CUP, CVE, CYP, CZK, DJF, DKK, DOP, DZD, EEK, EGP, ERN, ETB, EUR, FJD, FKP, GBP, GEL, GGP, GHC, GIP, GMD, GNF, GTQ, GYD, HKD, HNL, HRK, HTG, HUF, IDR, ILS, IMP, INR, IQD, IRR, ISK, JEP, JMD, JOD, JPY, KES, KGS, KHR, KMF, KPW, KRW, KWD, KYD, KZT, LAK, LBP, LKR, LRD, LSL, LTL, LVL, LYD, MAD, MDL, MGA, MKD, MMK, MNT, MOP, MRO, MTL, MUR, MVR, MWK, MXN, MYR, MZM, NAD, NGN, NIO, NOK, NPR, NZD, OMR, PAB, PEN, PGK, PHP, PKR, PLN, PYG, QAR, ROL, RUR, RWF, SAR, SBD, SCR, SDD, SEK, SGD, SHP, SIT, SKK, SLL, SOS, SPL, SRD, STD, SVC, SYP, SZL, THB, TJS, TMM, TND, TOP, TRL, TTD, TVD, TWD, TZS, UAH, UGX, USD, UYU, UZS, VEB, VND, VUV, WST, XAF, XCD, XOF, XPF, YER, ZAR, ZMK, ZWD, ZZZ }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class AuditfileSender
    {
        public string companyIdent;
        public string companyName;
        public Countrycode taxRegistrationCountry;
        [XmlIgnore()]
        public bool taxRegistrationCountrySpecified;
        public string taxRegIdent;
        [XmlElement("streetAddress")]
        public PostalAddress[] streetAddress;
        [XmlElement("postalAddress")]
        public PostalAddress[] postalAddress;
    }

    [Serializable()]
    [XmlType(Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public enum Countrycode { AD, AE, AF, AG, AI, AL, AM, AN, AO, AQ, AR, AS, AT, AU, AW, AX, AZ, BA, BB, BD, BE, BF, BG, BH, BI, BJ, BL, BM, BN, BO, BQ, BR, BS, BT, BV, BW, BY, BZ, CA, CC, CD, CF, CG, CH, CI, CK, CL, CM, CN, CO, CR, CS, CU, CV, CW, CX, CY, CZ, DE, DJ, DK, DM, DO, DZ, EC, EE, EG, EH, ER, ES, ET, FI, FJ, FK, FM, FO, FR, GA, GB, GD, GE, GF, GG, GH, GI, GL, GM, GN, GP, GQ, GR, GS, GT, GU, GW, GY, HK, HM, HN, HR, HT, HU, ID, IE, IL, IM, IN, IO, IQ, IR, IS, IT, JE, JM, JO, JP, KE, KG, KH, KI, KM, KN, KP, KR, KW, KY, KZ, LA, LB, LC, LI, LK, LR, LS, LT, LU, LV, LY, MA, MC, MD, ME, MF, MG, MH, MK, ML, MM, MN, MO, MP, MQ, MR, MS, MT, MU, MV, MW, MX, MY, MZ, NA, NC, NE, NF, NG, NI, NL, NO, NP, NR, NU, NZ, OM, PA, PE, PF, PG, PH, PK, PL, PM, PN, PR, PS, PT, PW, PY, QA, RE, RO, RS, RU, RW, SA, SB, SC, SD, SE, SG, SH, SI, SJ, SK, SL, SM, SN, SO, SR, SS, ST, SV, SX, SY, SZ, TC, TD, TF, TG, TH, TJ, TK, TL, TM, TN, TO, TR, TT, TV, TW, TZ, UA, UG, UK, UM, US, UY, UZ, VA, VC, VE, VG, VI, VN, VU, WF, WS, YE, YT, ZA, ZM, ZW, }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class PostalAddress
    {
        public string streetname;
        public string number;
        public string additionalAddressDetail;
        public string city;
        public string postalCode;
        public string region;
        public Countrycode country;
        [XmlIgnore()]
        public bool countrySpecified;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class Company
    {
        public string companyIdent;
        public string companyName;
        public Countrycode taxRegistrationCountry;
        [XmlIgnore()]
        public bool taxRegistrationCountrySpecified;
        public string taxRegIdent;
        [XmlElement("streetAddress")]
        public PostalAddress[] streetAddress;
        [XmlElement("postalAddress")]
        public PostalAddress[] postalAddress;
        [XmlArrayItem("customerSupplier", IsNullable = false)]
        public CustomerSupplier[] customersSuppliers;
        [XmlArrayItem("ledgerAccount", IsNullable = false)]
        public LedgerAccount[] generalLedger;
        [XmlArrayItem("vatCodeDetail", IsNullable = false)]
        public VatCodeDetail[] vatCodeDetails;
        [XmlArrayItem("period", IsNullable = false)]
        public Period[] periods;
        [XmlArrayItem("employee", IsNullable = false)]
        public Employee[] employees;
        [XmlArrayItem("article", IsNullable = false)]
        public Article[] articles;
        [XmlArrayItem("basic", IsNullable = false)]
        public Basic[] basics;
        [XmlElement("location")]
        public Location[] location;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class CustomerSupplier
    {
        public string custSupID;
        public string custSupName;
        public Custsuptype custSupType;
        public string contact;
        public string telephone;
        public string fax;
        [XmlElement(DataType = "token")]
        public string eMail;
        [XmlElement(DataType = "token")]
        public string website;
        public Countrycode taxRegistrationCountry;
        [XmlIgnore()]
        public bool taxRegistrationCountrySpecified;
        public string taxRegIdent;
        [XmlElement("streetAddress")]
        public PostalAddress[] streetAddress;
        [XmlElement("postalAddress")]
        public PostalAddress[] postalAddress;
    }

    [Serializable()]
    [XmlType(Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public enum Custsuptype
    {
        Customer,
        Supplier,
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class LedgerAccount
    {
        public string accID;
        public string accDesc;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class VatCodeDetail
    {
        public string vatCode;
        [XmlElement(DataType = "date")]
        public DateTime dateOfEntry;
        public string vatDesc;
        public string standardVatCode;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class Period
    {
        [XmlElement(DataType = "nonNegativeInteger")]
        public string periodNumber;
        public string periodDesc;
        [XmlElement(DataType = "date")]
        public DateTime startDatePeriod;
        [XmlIgnore()]
        public bool startDatePeriodSpecified;
        [XmlElement(DataType = "time")]
        public DateTime startTimePeriod;
        [XmlIgnore()]
        public bool startTimePeriodSpecified;
        [XmlElement(DataType = "date")]
        public DateTime endDatePeriod;
        [XmlIgnore()]
        public bool endDatePeriodSpecified;
        [XmlElement(DataType = "time")]
        public DateTime endTimePeriod;
        [XmlIgnore()]
        public bool endTimePeriodSpecified;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class Employee
    {
        public string empID;
        [XmlElement(DataType = "date")]
        public DateTime dateOfEntry;
        [XmlElement(DataType = "time")]
        public DateTime timeOfEntry;
        public string firstName;
        public string surName;
        [XmlElement("employeeRole")]
        public EmployeeRole[] employeeRole;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class EmployeeRole
    {
        public string roleType;
        public string roleTypeDesc;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class Article
    {
        public string artID;
        [XmlElement(DataType = "date")]
        public DateTime dateOfEntry;
        public string artGroupID;
        public string artDesc;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class Basic
    {
        public string basicType;
        public string basicID;
        public string predefinedBasicID;
        public string basicDesc;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class Location
    {
        public string name;
        public PostalAddress streetAddress;
        [XmlElement("cashregister")]
        public Cashregister[] cashregister;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class Cashregister
    {
        public string registerID;
        public string regDesc;
        [XmlElement("event")]
        public CashregisterEvent[] @event;
        [XmlElement("cashtransaction")]
        public Cashtransaction[] cashtransaction;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class CashregisterEvent
    {
        public string eventID;
        public string eventType;
        public string transID;
        public string empID;
        [XmlElement(DataType = "date")]
        public DateTime eventDate;
        [XmlElement(DataType = "time")]
        public DateTime eventTime;
        public string eventText;
        public EventReport eventReport;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class EventReport
    {
        public string reportID;
        public ReportType reportType;
        public string companyIdent;
        public string companyName;
        [XmlElement(DataType = "date")]
        public DateTime reportDate;
        [XmlElement(DataType = "time")]
        public DateTime reportTime;
        public string registerID;
        public ReportTotalCashSales reportTotalCashSales;
        [XmlArrayItem("reportArtGroup", IsNullable = false)]
        public ReportArtGroup[] reportArtGroups;
        [XmlArrayItem("reportEmpArtGroup", IsNullable = false)]
        public ReportEmpArtGroup[] reportEmpArtGroups;
        [XmlArrayItem("reportPayment", IsNullable = false)]
        public ReportPayment[] reportPayments;
        [XmlArrayItem("reportEmpPayment", IsNullable = false)]
        public ReportEmpPayment[] reportEmpPayments;
        public ReportTip reportTip;
        [XmlArrayItem("reportCashSaleVat", IsNullable = false)]
        public ReportCashSaleVat[] reportCashSalesVat;
        public decimal reportOpeningChangeFloat;
        [XmlArrayItem("reportEmpOpeningChangeFloat", IsNullable = false)]
        public ReportEmpOpeningChangeFloat[] reportEmpOpeningChangeFloats;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string reportReceiptNum;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string reportOpenCashBoxNum;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string reportReceiptCopyNum;
        public decimal reportReceiptCopyAmnt;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string reportReceiptProformaNum;
        public decimal reportReceiptProformaAmnt;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string reportReturnNum;
        public decimal reportReturnAmnt;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string reportDiscountNum;
        public decimal reportDiscountAmnt;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string reportVoidTransNum;
        public decimal reportVoidTransAmnt;
        [XmlArrayItem("reportCorrLine", IsNullable = false)]
        public ReportCorrLine[] reportCorrLines;
        [XmlArrayItem("reportPriceInquiry", IsNullable = false)]
        public ReportPriceInquiry[] reportPriceInquiries;
        [XmlArrayItem("reportOtherCorr", IsNullable = false)]
        public ReportOtherCorr[] reportOtherCorrs;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string reportReceiptDeliveryNum;
        public decimal reportReceiptDeliveryAmnt;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string reportTrainingNum;
        public decimal reportTrainingAmnt;
        public ReportCreditSales reportCreditSales;
        public ReportCreditMemos reportCreditMemos;
        [XmlArrayItem("reportPayIn", IsNullable = false)]
        public ReportPayIn[] reportPayIns;
        [XmlArrayItem("reportPayOut", IsNullable = false)]
        public ReportPayOut[] reportPayOuts;
        public decimal reportGrandTotalSales;
        public decimal reportGrandTotalReturn;
        public decimal reportGrandTotalSalesNet;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public enum ReportType
    {
        [XmlEnum("Z report")]
        Zreport,
        [XmlEnum("X report")]
        Xreport,
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class ReportTotalCashSales
    {
        public decimal totalCashSaleAmnt;
        public string accID;
        public string accDesc;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class ReportArtGroup
    {
        public string artGroupID;
        public decimal artGroupNum;
        public decimal artGroupAmnt;
        public string accID;
        public string accDesc;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class ReportEmpArtGroup
    {
        public string empID;
        public string artGroupID;
        public decimal artGroupNum;
        public decimal artGroupAmnt;
        public string accID;
        public string accDesc;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class ReportPayment
    {
        public string paymentType;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string paymentNum;
        public decimal paymentAmnt;
        public string accID;
        public string accDesc;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class ReportEmpPayment
    {
        public string empID;
        public string paymentType;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string paymentNum;
        public decimal paymentAmnt;
        public string accID;
        public string accDesc;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class ReportTip
    {
        [XmlElement(DataType = "nonNegativeInteger")]
        public string tipNum;
        public decimal tipAmnt;
        public string accID;
        public string accDesc;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class ReportCashSaleVat
    {
        public string vatCode;
        public decimal vatPerc;
        public decimal cashSaleAmnt;
        public decimal vatAmnt;
        public Debitcredittype vatAmntTp;
        [XmlIgnore()]
        public bool vatAmntTpSpecified;
        public string accID;
        public string accDesc;
    }

    [Serializable()]
    [XmlType(Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public enum Debitcredittype
    {
        C,
        D,
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class ReportEmpOpeningChangeFloat
    {
        public string empID;
        public decimal openingChangeFloatAmnt;
        public string accID;
        public string accDesc;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class ReportCorrLine
    {
        public string corrLineType;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string corrLineNum;
        public decimal corrLineAmnt;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class ReportPriceInquiry
    {
        public string priceInquiryGroup;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string priceInquiryNum;
        public decimal priceInquiryAmnt;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class ReportOtherCorr
    {
        public string otherCorrType;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string otherCorrNum;
        public decimal otherCorrAmnt;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class ReportCreditSales
    {
        [XmlElement(DataType = "nonNegativeInteger")]
        public string creditSalesNum;
        public decimal creditSalesAmnt;
        public string accID;
        public string accDesc;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class ReportCreditMemos
    {
        [XmlElement(DataType = "nonNegativeInteger")]
        public string creditMemosNum;
        public decimal creditMemosAmnt;
        public string accID;
        public string accDesc;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class ReportPayIn
    {
        public string payInType;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string payInNum;
        public decimal payInAmnt;
        public string accID;
        public string accDesc;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class ReportPayOut
    {
        public string payOutType;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string payOutNum;
        public decimal payOutAmnt;
        public string accID;
        public string accDesc;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class Cashtransaction
    {
        public string nr;
        public string transID;
        public string transType;
        public decimal transAmntIn;
        public decimal transAmntEx;
        public Debitcredittype amntTp;
        public string empID;
        public string custSupID;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string periodNumber;
        [XmlElement(DataType = "date")]
        public DateTime transDate;
        [XmlElement(DataType = "time")]
        public DateTime transTime;
        [XmlElement(DataType = "date")]
        public DateTime bookDate;
        [XmlIgnore()]
        public bool bookDateSpecified;
        [XmlElement(DataType = "time")]
        public DateTime bookTime;
        [XmlIgnore()]
        public bool bookTimeSpecified;
        public string invoiceID;
        public string refID;
        public string desc;
        [XmlElement("ctLine")]
        public CtLine[] ctLine;
        [XmlElement("vat")]
        public Vat[] vat;
        [XmlElement("savings")]
        public Savings[] savings;
        [XmlElement("discount")]
        public Discount[] discount;
        [XmlElement("raise")]
        public Raise[] raise;
        public Rounding rounding;
        [XmlElement("payment")]
        public Payment[] payment;
        public string signature;
        public string keyVersion;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string receiptNum;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string receiptCopyNum;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string receiptProformaNum;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string receiptDeliveryNum;
        public bool voidTransaction;
        [XmlIgnore()]
        public bool voidTransactionSpecified;
        public bool trainingID;
        [XmlIgnore()]
        public bool trainingIDSpecified;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class CtLine
    {
        public string nr;
        public string lineID;
        public string lineType;
        public string artGroupID;
        public string artID;
        public decimal qnt;
        [XmlIgnore()]
        public bool qntSpecified;
        public decimal lineAmntIn;
        public decimal lineAmntEx;
        public Debitcredittype amntTp;
        public decimal ppu;
        [XmlIgnore()]
        public bool ppuSpecified;
        public decimal costPrice;
        [XmlIgnore()]
        public bool costPriceSpecified;
        public string costID;
        public string costObjID;
        public string projID;
        public string empID;
        public string lineAmntInAccID;
        public string cashTransLineDescr;
        [XmlElement(DataType = "date")]
        public DateTime lineDate;
        [XmlIgnore()]
        public bool lineDateSpecified;
        [XmlElement(DataType = "time")]
        public DateTime lineTime;
        [XmlIgnore()]
        public bool lineTimeSpecified;
        public Vat vat;
        [XmlElement("savings")]
        public Savings[] savings;
        [XmlElement("discount")]
        public Discount[] discount;
        [XmlElement("raise")]
        public Raise[] raise;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class Vat
    {
        public string vatCode;
        public decimal vatPerc;
        [XmlIgnore()]
        public bool vatPercSpecified;
        public decimal vatAmnt;
        public Debitcredittype vatAmntTp;
        [XmlIgnore()]
        public bool vatAmntTpSpecified;
        public decimal vatBasAmnt;
        [XmlIgnore()]
        public bool vatBasAmntSpecified;
        public string accID;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class Savings
    {
        public string savingsType;
        [XmlElement(DataType = "nonNegativeInteger")]
        public string savingsUnits;
        public string empID;
        public string accID;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class Discount
    {
        public string dscTp;
        public decimal dscAmnt;
        public string empID;
        public string accID;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class Raise
    {
        public string raiseType;
        public decimal raiseAmnt;
        public string empID;
        public string accID;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class Rounding
    {
        public decimal roundingAmnt;
        [XmlIgnore()]
        public bool roundingAmntSpecified;
        public string accID;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-CashRegister:NO")]
    public partial class Payment
    {
        public string paymentType;
        public decimal paidAmnt;
        public string empID;
        public Currencycode curCode;
        [XmlIgnore()]
        public bool curCodeSpecified;
        public decimal exchRt;
        [XmlIgnore()]
        public bool exchRtSpecified;
        public string paymentRefID;
        public string accID;
    }

}

