Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Module GlobalVariables
    'KARTHI
    'KARTHI jun 13
    Public GDOSPRINT As Boolean
    Public ssql As String
    'KARTHI jun 13
    Public gsalerate As String
    Public chkClsQty As Boolean
    Public chkStorecode As String
    Public ACC_ENTRY, POS_ENTREE As Boolean
    Public DefaultPayment As String
    Public kotupdate As Boolean
    Public MCODE_GBL As String
    Public POSCODE_GBL, DOCTYPE_GBL As String
    Public POSNAME_GBL As String
    Public POS_CHECK As Boolean
    Public cardcode As String
    Public POS_AMT_GBL As Double 'AMT WITHOUT TAX
    Public POS_RATE_GBL, BILLAMT_GBL As Double 'BILL_AMT WITH TAX
    Public dc_trans_closed As Boolean
    Public NAME_GBL As String
    Public MNAME_GBL, PAYMENTMODE_GBL As String
    Public gindentno As String
    Public gTAXcode As String
    Public DateClsValue As Double

    'KARTHI
    Public Membercode() As String
    Public MDIParentobj As Object
    Public gIssueregister As Boolean
    Public gvoucherprefix As String
    Public GbatchNo As Long
    Public gridviewstatus As String
    Public gFinancialEnd As String
    Public gSQLString As String
    Public M_Groupby As String
    Public M_ORDERBY As String
    Public M_WhereCondition As String
    Public M_WhereConditionlike As Integer = 0
    Public strexcelpath As String
    Public gUsername As String
    Public gPrint As Boolean
    Public AppPath As String
    Public gCompanyname As String
    Public gCompanyAddress(10) As String
    Public gDatabase As String
    Public gDivCode As String
    Public gDivName As String
    Public gSeasion As String
    Public gUserCategory As String
    Public wemp1, wemp2, wemp3 As String
    Public Reportsql As String
    Public VFilePath As String
    Public printfile As String
    Public tables As String
    Public Gheader As String
    Public gserver, ggusername, ggpassword, ggproductkey As String
    Public gdataset As New DataSet
    Public gdreader As SqlDataReader
    Public gadapter As SqlDataAdapter
    Public gcommand As SqlCommand
    Public gfstream As FileStream
    Public gtrans As SqlTransaction
    Public GroupMasterbool As Boolean
    'Prov_Master
    Public SubGroupMasterbool As Boolean
    Public StoreMasterbool As Boolean
    Public ItemMasterbool As Boolean
    Public TenderMasterbool As Boolean
    Public UOMRelationMasterbool As Boolean
    Public BillingMaterialbool As Boolean
    Public PurchaseOrderbool As Boolean
    Public IndentOrderbool As Boolean
    Public UserAdminbool As Boolean
    Public GRNCumPurchaseBillTransbool As Boolean
    Public StockIssueTransbool As Boolean
    Public CockTailRatioTransbool As Boolean
    Public StockTransferTransbool As Boolean
    Public StockAdjustmentTransbool As Boolean
    Public StockDamageTransbool As Boolean
    Public vOutfile, vheader, vLine As String
    Public gFinancalyearStart As String
    Public gFinancialyearEnd As String
    Public gTinNo As String
    Public gServiceTax As String
    Public gGSTINCode As String
    Public gAuditFlg As String
    Public Filewrite As StreamWriter
    Public provmasterbool As Boolean
    Public scissuemasterbool As Boolean
    Public finalbillbool As Boolean
    Public manualbillbool As Boolean
    Public cashreceiptbool As Boolean
    Public Printername As String = "EpsonCom"
    Public computername As String = "debasish"
    Public search As String
    Public MyCompanyName As String
    Public gCompanyShortName As String
    Public gshortname As String
    Public Address1 As String
    Public Address2 As String
    Public gCity As String
    Public gState As String
    Public gPincode As String
    Public GPHONE As String
    Public gPhone1 As String
    Public gFax As String
    Public gEmail As String
    Public gWebsite As String
    Public chkdatevalidate As Boolean
    Public PrintTaxheading1 As String
    Public PrintTaxheading2 As String
    Public gCreditors As String
    Public gDebitors As String
    Public GmoduleName As String
    'FOR SMART CARD
    Public clearcheck As Boolean
    Public Cardidcheck As Boolean
    Public vCardcode, vTmp As String
    Public boolchk As Boolean

    Public gInventoryVersion As String

    ' PO
    Public vrowcnt As Int16
    Public gMAINCompanyname As String
    Public intRowcount, intPageNo As Int16
    Public PoNumber As String
    Public ShowCompany As Boolean
    Public vFormatstring1 As String

    'VenuJD     19-11-2011  --For RSI Club
    Public DefaultGRN As String = "NA"
End Module
