//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Entity
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using LighTake.Infrastructure.Seedwork;
    
    public partial class WayBillInfo : Entity
    {
    
        ICollection<ApplicationInfo> _applicationInfos;
        ICollection<ReturnGoods> _returnGoods;
        ICollection<DeliveryFee> _deliveryFees;
        ICollection<ReceivingExpens> _receivingExpenses;
        ICollection<JobErrorLog> _jobErrorLogs;
        ICollection<EubWayBillApplicationInfo> _eubWayBillApplicationInfos;
    
    
        public virtual string WayBillNumber { get; set; }
        public virtual Nullable<int> CustomerOrderID { get; set; }
        public virtual string CustomerCode { get; set; }
        public virtual string TrackingNumber { get; set; }
        public virtual string RawTrackingNumber { get; set; }
        public virtual Nullable<decimal> Weight { get; set; }
        public virtual Nullable<decimal> SettleWeight { get; set; }
        public virtual Nullable<decimal> Length { get; set; }
        public virtual Nullable<decimal> Width { get; set; }
        public virtual Nullable<decimal> Height { get; set; }
        public virtual Nullable<int> GoodsTypeID { get; set; }
        public virtual bool IsReturn { get; set; }
        public virtual bool IsHold { get; set; }
        public virtual bool IsBattery { get; set; }
        public virtual int Status { get; set; }
        public virtual string OutStorageID { get; set; }
        public virtual string InStorageID { get; set; }
        public virtual Nullable<int> ShippingInfoID { get; set; }
        public virtual Nullable<int> SenderInfoID { get; set; }
        public virtual string CountryCode { get; set; }
        public virtual Nullable<int> InsuredID { get; set; }
        public virtual Nullable<int> AbnormalID { get; set; }
        public virtual Nullable<int> InShippingMethodID { get; set; }
        public virtual Nullable<int> OutShippingMethodID { get; set; }
        public virtual string InShippingMethodName { get; set; }
        public virtual string OutShippingMethodName { get; set; }
        public virtual System.DateTime CreatedOn { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual System.DateTime LastUpdatedOn { get; set; }
        public virtual string LastUpdatedBy { get; set; }
        public virtual Nullable<System.DateTime> TransferOrderDate { get; set; }
        public virtual string VenderCode { get; set; }
        public virtual string CustomerOrderNumber { get; set; }
        public virtual Nullable<System.DateTime> InStorageCreatedOn { get; set; }
        public virtual Nullable<System.DateTime> OutStorageCreatedOn { get; set; }
        public virtual string TrueTrackingNumber { get; set; }
        public virtual bool EnableTariffPrepay { get; set; }
    
        public virtual AbnormalWayBillLog AbnormalWayBillLog { get; set; }
        public virtual ICollection<ApplicationInfo> ApplicationInfos 
    	{
            get { return _applicationInfos  ?? (_applicationInfos  = new List<ApplicationInfo>()); }
            protected set { _applicationInfos  = value; }
        }
    
        public virtual CustomerOrderInfo CustomerOrderInfo { get; set; }
        public virtual ExpressRespons ExpressRespons { get; set; }
        public virtual GoodsTypeInfo GoodsTypeInfo { get; set; }
        public virtual InStorageInfo InStorageInfo { get; set; }
        public virtual InsuredCalculation InsuredCalculation { get; set; }
        public virtual ICollection<ReturnGoods> ReturnGoods 
    	{
            get { return _returnGoods  ?? (_returnGoods  = new List<ReturnGoods>()); }
            protected set { _returnGoods  = value; }
        }
    
        public virtual SenderInfo SenderInfo { get; set; }
        public virtual ShippingInfo ShippingInfo { get; set; }
        public virtual ICollection<DeliveryFee> DeliveryFees 
    	{
            get { return _deliveryFees  ?? (_deliveryFees  = new List<DeliveryFee>()); }
            protected set { _deliveryFees  = value; }
        }
    
        public virtual ICollection<ReceivingExpens> ReceivingExpenses 
    	{
            get { return _receivingExpenses  ?? (_receivingExpenses  = new List<ReceivingExpens>()); }
            protected set { _receivingExpenses  = value; }
        }
    
        public virtual ICollection<JobErrorLog> JobErrorLogs 
    	{
            get { return _jobErrorLogs  ?? (_jobErrorLogs  = new List<JobErrorLog>()); }
            protected set { _jobErrorLogs  = value; }
        }
    
        public virtual OutStorageInfo OutStorageInfo { get; set; }
        public virtual ICollection<EubWayBillApplicationInfo> EubWayBillApplicationInfos 
    	{
            get { return _eubWayBillApplicationInfos  ?? (_eubWayBillApplicationInfos  = new List<EubWayBillApplicationInfo>()); }
            protected set { _eubWayBillApplicationInfos  = value; }
        }
    
    }
}
