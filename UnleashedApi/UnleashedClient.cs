using System;
using UnleashedApi.Resources;
using UnleashedApi.Services;

namespace UnleashedApi
{
    public class UnleashedClient : IApiSettings
    {
        private readonly string _apiId;
        private readonly string _apiKey;
        private readonly string _url;

        private readonly IClientExecutionService _executionService;
        private readonly Lazy<CustomerResource> _customers;
        private readonly Lazy<ProductResource> _products;
        private readonly Lazy<SalesOrderResource> _salesOrders;
        private readonly Lazy<SalesInvoiceResource> _salesInvoice;
        private readonly Lazy<SalesPersonResource> _salesPerson;
        private readonly Lazy<TaxResource> _taxes;
        private readonly Lazy<WarehouseResource> _warehouses;
        private readonly Lazy<UnitOfMeasureResource> _unitOfMeasures;
        private readonly Lazy<ProductGroupResource> _productGroups;
        private readonly Lazy<SupplierResource> _suppliers;
        private readonly Lazy<SalesOrderGroupResource> _salesOrderGroups;
        private readonly Lazy<CustomerTypeResource> _customerTypes;
        private readonly Lazy<SalesShipmentResource> _salesShipments;
        private readonly Lazy<ShippingCompanyResource> _shippingCompanies;
        private readonly Lazy<BillOfMaterialResource> _billOfMaterials;
        private readonly Lazy<PurchaseOrderResource> _purchaseOrders;
        private readonly Lazy<StockAdjustmentResource> _stockAdjustments;
        private readonly Lazy<DeliveryMethodResource> _deliveryMethods;
        private readonly Lazy<PaymentTermResource> _paymentTerms;
        private readonly Lazy<StockOnHandResource> _stockOnHand;
        private readonly Lazy<WarehouseStockTransferResource> _warehouseStockTransfers; 

        public UnleashedClient(string apiId, string apiKey, string url = null)
        {
            _apiId = apiId;
            _apiKey = apiKey;
            _url = url ?? "https://api.unleashedsoftware.com/";

            _executionService = new ClientExecutionService(this);
            _customers = new Lazy<CustomerResource>(() => new CustomerResource(_executionService), true);
            _products = new Lazy<ProductResource>(() => new ProductResource(_executionService), true);
            _salesOrders = new Lazy<SalesOrderResource>(() => new SalesOrderResource(_executionService), true);
            _salesInvoice = new Lazy<SalesInvoiceResource>(() => new SalesInvoiceResource(_executionService), true);
            _salesPerson = new Lazy<SalesPersonResource>(() => new SalesPersonResource(_executionService), true);
            _taxes = new Lazy<TaxResource>(() => new TaxResource(_executionService), true);
            _warehouses = new Lazy<WarehouseResource>(() => new WarehouseResource(_executionService), true);
            _unitOfMeasures = new Lazy<UnitOfMeasureResource>(() => new UnitOfMeasureResource(_executionService), true);
            _productGroups = new Lazy<ProductGroupResource>(() => new ProductGroupResource(_executionService), true);
            _suppliers = new Lazy<SupplierResource>(() => new SupplierResource(_executionService), true);
            _salesOrderGroups = new Lazy<SalesOrderGroupResource>(() => new SalesOrderGroupResource(_executionService), true);
            _customerTypes = new Lazy<CustomerTypeResource>(() => new CustomerTypeResource(_executionService), true);
            _salesShipments = new Lazy<SalesShipmentResource>(() => new SalesShipmentResource(_executionService), true);
            _shippingCompanies = new Lazy<ShippingCompanyResource>(() => new ShippingCompanyResource(_executionService), true);
            _billOfMaterials = new Lazy<BillOfMaterialResource>(() => new BillOfMaterialResource(_executionService), true);
            _purchaseOrders = new Lazy<PurchaseOrderResource>(() => new PurchaseOrderResource(_executionService), true);
            _stockAdjustments = new Lazy<StockAdjustmentResource>(() => new StockAdjustmentResource(_executionService), true);
            _deliveryMethods = new Lazy<DeliveryMethodResource>(() => new DeliveryMethodResource(_executionService), true);
            _paymentTerms = new Lazy<PaymentTermResource>(() => new PaymentTermResource(_executionService), true);
            _stockOnHand = new Lazy<StockOnHandResource>(() => new StockOnHandResource(_executionService), true);
            _warehouseStockTransfers = new Lazy<WarehouseStockTransferResource>(() => new WarehouseStockTransferResource(_executionService), true);
        }

        public CustomerResource Customers
        {
            get { return _customers.Value; }
        }

        public ProductResource Products
        {
            get { return _products.Value; }
        }

        public SalesOrderResource SalesOrders
        {
            get { return _salesOrders.Value; }
        }

        public SalesInvoiceResource SalesInvoice
        {
            get { return _salesInvoice.Value; }
        }

        public SalesPersonResource SalesPersons
        {
            get { return _salesPerson.Value; }
        }

        public TaxResource Taxes
        {
            get { return _taxes.Value; }
        }

        public WarehouseResource Warehouses
        {
            get { return _warehouses.Value; }
        }

        public UnitOfMeasureResource UnitOfMeasures
        {
            get { return _unitOfMeasures.Value; }
        }

        public ProductGroupResource ProductGroups
        {
            get { return _productGroups.Value; }
        }

        public SupplierResource Suppliers
        {
            get { return _suppliers.Value; }
        }

        public SalesOrderGroupResource SalesOrderGroups
        {
            get { return _salesOrderGroups.Value; }
        }

        public CustomerTypeResource CustomerTypes
        {
            get { return _customerTypes.Value; }
        }

        public SalesShipmentResource SalesShipments
        {
            get { return _salesShipments.Value; }
        }

        public ShippingCompanyResource ShippingCompanies
        {
            get { return _shippingCompanies.Value; }
        }

        public BillOfMaterialResource BillOfMaterials
        {
            get { return _billOfMaterials.Value; }
        }

        public PurchaseOrderResource PurchaseOrders
        {
            get { return _purchaseOrders.Value; }
        }

        public StockAdjustmentResource StockAdjustments
        {
            get { return _stockAdjustments.Value; }
        }

        public DeliveryMethodResource DeliveryMethods
        {
            get { return _deliveryMethods.Value; }
        }

        public PaymentTermResource PaymentTerms
        {
            get { return _paymentTerms.Value; }
        }

        public StockOnHandResource StockOnHand
        {
            get { return _stockOnHand.Value; }
        }

        public WarehouseStockTransferResource WarehouseStockTransfers
        {
            get { return _warehouseStockTransfers.Value; }
        }

        public string ApiId
        {
            get { return _apiId; }
        }

        public string ApiKey
        {
            get { return _apiKey; }
        }

        public string Url
        {
            get { return _url; }
        }
    }
}
