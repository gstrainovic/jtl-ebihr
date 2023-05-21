namespace rec BihrClient.Types

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CatalogCompletion =
    | [<CompiledName "Differential">] Differential
    | [<CompiledName "Full">] Full
    member this.Format() =
        match this with
        | Differential -> "Differential"
        | Full -> "Full"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CatalogType =
    | [<CompiledName "Attributes">] Attributes
    | [<CompiledName "ExtendedReferences">] ExtendedReferences
    | [<CompiledName "HardPart">] HardPart
    | [<CompiledName "Images">] Images
    | [<CompiledName "Prices">] Prices
    | [<CompiledName "References">] References
    | [<CompiledName "RiderGear">] RiderGear
    | [<CompiledName "Stocks">] Stocks
    member this.Format() =
        match this with
        | Attributes -> "Attributes"
        | ExtendedReferences -> "ExtendedReferences"
        | HardPart -> "HardPart"
        | Images -> "Images"
        | Prices -> "Prices"
        | References -> "References"
        | RiderGear -> "RiderGear"
        | Stocks -> "Stocks"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CompressionType =
    | [<CompiledName "LZMA">] LZMA
    | [<CompiledName "ZIP">] ZIP
    member this.Format() =
        match this with
        | LZMA -> "LZMA"
        | ZIP -> "ZIP"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SerializationType =
    | [<CompiledName "CSV">] CSV
    | [<CompiledName "JSON">] JSON
    | [<CompiledName "XML">] XML
    member this.Format() =
        match this with
        | CSV -> "CSV"
        | JSON -> "JSON"
        | XML -> "XML"

type AddressDataContract =
    { ///The address name
      Name: string
      ///The first address line
      Line1: string
      ///The second address line
      Line2: Option<string>
      ///The ZIP code
      ZipCode: string
      ///The city
      City: string
      ///The ISO 3166 country code
      Country: string }
    ///Creates an instance of AddressDataContract with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string, line1: string, zipCode: string, city: string, country: string): AddressDataContract =
        { Name = name
          Line1 = line1
          Line2 = None
          ZipCode = zipCode
          City = city
          Country = country }

type AuthenticationErrorResponse =
    { ///The error type
      error: Option<string>
      ///The error description
      error_description: Option<string> }
    ///Creates an instance of AuthenticationErrorResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AuthenticationErrorResponse =
        { error = None
          error_description = None }

type AuthenticationResponse =
    { ///The token to reuse
      access_token: Option<string>
      ///The type of token
      token_type: Option<string>
      ///The duration before expiration in seconds
      expires_in: Option<string> }
    ///Creates an instance of AuthenticationResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AuthenticationResponse =
        { access_token = None
          token_type = None
          expires_in = None }

type CatalogGenerationDetail =
    { CreationDateTime: Option<string>
      CatalogCompletion: Option<string>
      CatalogType: Option<string>
      SerializationType: Option<string>
      CompressionType: Option<string>
      GenerationStatus: Option<string>
      TicketId: Option<string>
      DownloadId: Option<string> }
    ///Creates an instance of CatalogGenerationDetail with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): CatalogGenerationDetail =
        { CreationDateTime = None
          CatalogCompletion = None
          CatalogType = None
          SerializationType = None
          CompressionType = None
          GenerationStatus = None
          TicketId = None
          DownloadId = None }

type CatalogGenerationRequestDataContract =
    { ///The generation ticket Id.
      TicketId: Option<string>
      ///The generation result code.
      ResultCode: Option<string> }
    ///Creates an instance of CatalogGenerationRequestDataContract with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): CatalogGenerationRequestDataContract = { TicketId = None; ResultCode = None }

type CatalogGenerationResponseDataContract =
    { ///The generation position in queue.
      PositionInQueue: Option<int>
      ///The request status.
      RequestStatus: Option<string>
      ///The download Id.
      DownloadId: Option<string> }
    ///Creates an instance of CatalogGenerationResponseDataContract with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): CatalogGenerationResponseDataContract =
        { PositionInQueue = None
          RequestStatus = None
          DownloadId = None }

type DeliveryOrder =
    { ///The packages
      Packages: Option<list<Package>>
      ///The delivery order lines
      DeliveryOrderLines: Option<list<DeliveryOrderLine>>
      ShippingAddress: Option<AddressDataContract>
      ///The weight in g
      Weight: Option<float>
      ///The volume in dm³ (1 dm³ = 1L)
      Volume: Option<float>
      ///The excluded VAT price
      ExclVatPrice: Option<float32>
      ///The included VAT price
      InclVatPrice: Option<float32>
      ///The creation date
      CreationDate: Option<System.DateTimeOffset>
      ///The dispatch date
      DispatchDate: Option<System.DateTimeOffset>
      ///The transporter ID
      TransporterId: Option<string>
      ///The status
      Status: Option<int> }
    ///Creates an instance of DeliveryOrder with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): DeliveryOrder =
        { Packages = None
          DeliveryOrderLines = None
          ShippingAddress = None
          Weight = None
          Volume = None
          ExclVatPrice = None
          InclVatPrice = None
          CreationDate = None
          DispatchDate = None
          TransporterId = None
          Status = None }

type DeliveryOrderLine =
    { ///The ordered quantity
      OrderedQuantity: Option<int>
      ///The displayed quantity
      DisplayedQuantity: Option<int>
      ///The dispatched quantity
      DispatchedQuantity: Option<int>
      ///The excluded VAT price
      ExclVatPrice: Option<float32>
      ///The included VAT price
      InclVatPrice: Option<float32>
      ///The customer reference
      CustomerReference: Option<string>
      ///The part number
      ProductId: Option<string>
      ///The product name
      ProductName: Option<string>
      ///The ID
      Id: Option<string>
      ///The Bihr order ID
      BihrOrderId: Option<string> }
    ///Creates an instance of DeliveryOrderLine with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): DeliveryOrderLine =
        { OrderedQuantity = None
          DisplayedQuantity = None
          DispatchedQuantity = None
          ExclVatPrice = None
          InclVatPrice = None
          CustomerReference = None
          ProductId = None
          ProductName = None
          Id = None
          BihrOrderId = None }

type OrderCreationRequest =
    { Order: OrderDataContract
      ShippingAddress: Option<AddressDataContract>
      ///The backOrder management
      BackorderManagement: Option<string> }
    ///Creates an instance of OrderCreationRequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (order: OrderDataContract): OrderCreationRequest =
        { Order = order
          ShippingAddress = None
          BackorderManagement = None }

type OrderDataContract =
    { ///The version of the order
      Version: Option<string>
      ///The customer ID
      CustomerId: Option<string>
      ///The customer reference
      CustomerReference: Option<string>
      ///The vendor order ID
      VendorOrderId: Option<string>
      ///The vendor key
      VendorKey: Option<string>
      ///The order lines
      Lines: list<OrderLineDataContract>
      ///The mac key
      MacKey: Option<string>
      ///The hash key used if HashKeyBase64 is empty
      HashKey: Option<byte []>
      ///The hash key in Base64 produced from SHA256(CustomerId;VendorOrderId[;line.ProductId;line.Quantity];MacKey)
      HashKeyBase64: Option<string>
      ///Boolean field to specify whether the cart must be transformed into order automatically
      IsAutomaticCheckoutActivated: Option<bool> }
    ///Creates an instance of OrderDataContract with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (lines: list<OrderLineDataContract>): OrderDataContract =
        { Version = None
          CustomerId = None
          CustomerReference = None
          VendorOrderId = None
          VendorKey = None
          Lines = lines
          MacKey = None
          HashKey = None
          HashKeyBase64 = None
          IsAutomaticCheckoutActivated = None }

type OrderLineDataContract =
    { ///The part number of the product
      ProductId: string
      ///The quantity
      Quantity: int
      ///The reference type
      ReferenceType: Option<string>
      ///The customer reference
      CustomerReference: Option<string>
      ///The reserved quantity
      ReservedQuantity: Option<int> }
    ///Creates an instance of OrderLineDataContract with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (productId: string, quantity: int): OrderLineDataContract =
        { ProductId = productId
          Quantity = quantity
          ReferenceType = None
          CustomerReference = None
          ReservedQuantity = None }

type OrderRequestDataContract =
    { ///The result code
      ResultCode: Option<string>
      ///The ticket ID
      TicketId: Option<string> }
    ///Creates an instance of OrderRequestDataContract with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): OrderRequestDataContract = { ResultCode = None; TicketId = None }

type OrderResponseDataContract =
    { ///The order URL
      OrderUrl: Option<string>
      ///The queue position
      OrderQueuePosition: Option<int>
      ///The status
      RequestStatus: Option<string> }
    ///Creates an instance of OrderResponseDataContract with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): OrderResponseDataContract =
        { OrderUrl = None
          OrderQueuePosition = None
          RequestStatus = None }

type OrderStatusResult =
    { ///The result code
      ResultCode: Option<string>
      ///The delivery orders
      DeliveryOrders: Option<list<DeliveryOrder>>
      ///The order lines
      OrderLines: Option<list<OrderLineDataContract>>
      ///The internal customer ID
      InternalCustomerId: Option<string>
      ///The customer ID
      CustomerId: Option<string> }
    ///Creates an instance of OrderStatusResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): OrderStatusResult =
        { ResultCode = None
          DeliveryOrders = None
          OrderLines = None
          InternalCustomerId = None
          CustomerId = None }

type Package =
    { Waybill: Option<Waybill>
      ///The package lines
      PackageLines: Option<list<PackageLine>>
      ParentPackage: Option<Package>
      ///The weight in g
      Weight: Option<float>
      ///The volume in dm³ (1 dm³ = 1L)
      Volume: Option<float>
      ///The shipping date
      ShippingDate: Option<System.DateTimeOffset> }
    ///Creates an instance of Package with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Package =
        { Waybill = None
          PackageLines = None
          ParentPackage = None
          Weight = None
          Volume = None
          ShippingDate = None }

type PackageLine =
    { ///The part number
      ProductId: Option<string>
      ///The quantity
      Quantity: Option<int>
      ///The set ID
      SetId: Option<string>
      ///The use before date
      UseBeforeDate: Option<System.DateTimeOffset>
      ///The logistic product ID
      LogisticProductId: Option<string>
      ///The delivery order line ID
      DeliveryOrderLineId: Option<string> }
    ///Creates an instance of PackageLine with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): PackageLine =
        { ProductId = None
          Quantity = None
          SetId = None
          UseBeforeDate = None
          LogisticProductId = None
          DeliveryOrderLineId = None }

type ProductInventoryItem =
    { ///The part number of the product
      ProductId: string
      ///The product availability
      IsAvailable: bool }
    ///Creates an instance of ProductInventoryItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (productId: string, isAvailable: bool): ProductInventoryItem =
        { ProductId = productId
          IsAvailable = isAvailable }

type ProductInventoryRequest =
    { ///The part number of the product
      ProductId: string
      ///The product available quantity
      Quantity: int }
    ///Creates an instance of ProductInventoryRequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (productId: string, quantity: int): ProductInventoryRequest =
        { ProductId = productId
          Quantity = quantity }

type Waybill =
    { ///The ID
      Id: Option<string>
      ///The receiver name
      ReceiverName: Option<string>
      ///The weight in g
      Weight: Option<float>
      ///The shipping date
      ShippingDate: Option<System.DateTimeOffset>
      ///The timestamp
      Timestamp: Option<System.DateTimeOffset>
      ///The last transport update
      LastTransporterUpdate: Option<System.DateTimeOffset>
      ///The transporter instructions
      TransporterInstructions: Option<string>
      ///The transporter comments
      TransporterComments: Option<string>
      ///The tracking URL
      TrackingUrl: Option<string>
      ///The pack number
      PackNumber: Option<string>
      ///The transporter ID
      TransporterId: Option<string>
      ///The status
      Status: Option<int>
      ///The custom Reference 1
      CustomRef1: Option<string> }
    ///Creates an instance of Waybill with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Waybill =
        { Id = None
          ReceiverName = None
          Weight = None
          ShippingDate = None
          Timestamp = None
          LastTransporterUpdate = None
          TransporterInstructions = None
          TransporterComments = None
          TrackingUrl = None
          PackNumber = None
          TransporterId = None
          Status = None
          CustomRef1 = None }

[<RequireQualifiedAccess>]
type PostToken =
    ///if the authentication succeeded
    | OK of payload: AuthenticationResponse
    ///if the authentication failed
    | BadRequest of payload: AuthenticationErrorResponse
    ///if the server encountered an error
    | InternalServerError

[<RequireQualifiedAccess>]
type PostEssentialHardPartRequest =
    ///the already generated catalog
    | OK
    ///the catalog generation ticket ID if the catalog was not generated yet
    | Accepted of payload: CatalogGenerationRequestDataContract
    ///if the server encountered an error
    | InternalServerError
    ///if the Bearer token is invalid or expired
    | Unauthorized
    ///if the caller does not have authorization for the operation requested
    | Forbidden

[<RequireQualifiedAccess>]
type PostEssentialRiderGearRequest =
    ///the already generated catalog
    | OK
    ///the catalog generation ticket ID if the catalog was not generated yet
    | Accepted of payload: CatalogGenerationRequestDataContract
    ///if the server encountered an error
    | InternalServerError
    ///if the Bearer token is invalid or expired
    | Unauthorized
    ///if the caller does not have authorization for the operation requested
    | Forbidden

[<RequireQualifiedAccess>]
type GetCatalogGenerationHistory =
    ///the catalog generation list
    | OK of payload: list<CatalogGenerationDetail>
    ///if the server encountered an error
    | InternalServerError
    ///if the Bearer token is invalid or expired
    | Unauthorized
    ///if the caller does not have authorization for the operation requested
    | Forbidden

[<RequireQualifiedAccess>]
type PostRequest =
    ///the catalog generation ticket ID
    | Accepted of payload: CatalogGenerationRequestDataContract
    ///if the server encountered an error
    | InternalServerError
    ///if the Bearer token is invalid or expired
    | Unauthorized
    ///if the caller does not have authorization for the operation requested
    | Forbidden

[<RequireQualifiedAccess>]
type GetGenerationStatus =
    ///the catalog generation status
    | OK of payload: CatalogGenerationResponseDataContract
    ///if the server encountered an error
    | InternalServerError
    ///if the Bearer token is invalid or expired
    | Unauthorized
    ///if the caller does not have authorization for the operation requested
    | Forbidden

[<RequireQualifiedAccess>]
type GetProductsImagesRootUrl =
    ///the root URL to concatenate with the product images URL provided in the corresponding catalog
    | OK of payload: string
    ///if the server encountered an error
    | InternalServerError
    ///if the Bearer token is invalid or expired
    | Unauthorized
    ///if the caller does not have authorization for the operation requested
    | Forbidden

[<RequireQualifiedAccess>]
type GetBrandImageRootUrl =
    ///the root URL to concatenate with the brand images URL provided by the Catalog/BrandImageUrl API.
    | OK of payload: string
    ///if the server encountered an error
    | InternalServerError
    ///if the Bearer token is invalid or expired
    | Unauthorized
    ///if the caller does not have authorization for the operation requested
    | Forbidden

[<RequireQualifiedAccess>]
type GetBrandImageUrl =
    ///the brand image URL
    | OK of payload: string
    ///if the server encountered an error
    | InternalServerError
    ///if the Bearer token is invalid or expired
    | Unauthorized
    ///if the caller does not have authorization for the operation requested
    | Forbidden

[<RequireQualifiedAccess>]
type GetGeneratedFile =
    ///the generated catalog file
    | OK
    ///if the server encountered an error
    | InternalServerError
    ///if the Bearer token is invalid or expired
    | Unauthorized
    ///if the caller does not have authorization for the operation requested
    | Forbidden

[<RequireQualifiedAccess>]
type GetStockLevel =
    ///a string indicating the availability of the product (InStock, Short, OutOfStock)
    | OK of payload: string
    ///if the part number is not found
    | NotFound of payload: string
    ///if the server encountered an error
    | InternalServerError
    ///if the Bearer token is invalid or expired
    | Unauthorized
    ///if the caller does not have authorization for the operation requested
    | Forbidden

[<RequireQualifiedAccess>]
type GetStockValue =
    ///the current stock value of the product
    | OK of payload: int
    ///if the part number is not found
    | NotFound of payload: string
    ///if the server encountered an error
    | InternalServerError
    ///if the Bearer token is invalid or expired
    | Unauthorized
    ///if the caller does not have authorization for the operation requested
    | Forbidden

type GetProductsInfoPayloadArrayItem =
    { ///The part number of the product
      ProductId: string
      ///The product available quantity
      Quantity: int }
    ///Creates an instance of GetProductsInfoPayloadArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (productId: string, quantity: int): GetProductsInfoPayloadArrayItem =
        { ProductId = productId
          Quantity = quantity }

type GetProductsInfoPayload = list<GetProductsInfoPayloadArrayItem>

[<RequireQualifiedAccess>]
type GetProductsInfo =
    ///the list of requested Bihr part numbers and their availability (true/false)
    | OK of payload: list<ProductInventoryItem>
    ///if the server encountered an error
    | InternalServerError
    ///if the Bearer token is invalid or expired
    | Unauthorized
    ///if the caller does not have authorization for the operation requested
    | Forbidden

[<RequireQualifiedAccess>]
type PostCreationRequest =
    ///the order generation ticket ID
    | OK of payload: OrderRequestDataContract
    ///if a problem is detected in the given data
    | BadRequest
    ///if the server encountered an error
    | InternalServerError
    ///if the Bearer token is invalid or expired
    | Unauthorized
    ///if the caller does not have authorization for the operation requested
    | Forbidden

[<RequireQualifiedAccess>]
type GetStatus =
    ///the order generation status
    | OK of payload: OrderResponseDataContract
    ///if the server encountered an error
    | InternalServerError
    ///if the Bearer token is invalid or expired
    | Unauthorized
    ///if the caller does not have authorization for the operation requested
    | Forbidden

[<RequireQualifiedAccess>]
type GetData =
    ///the order data
    | OK of payload: OrderStatusResult
    ///if the server encountered an error
    | InternalServerError
    ///if the Bearer token is invalid or expired
    | Unauthorized
    ///if the caller does not have authorization for the operation requested
    | Forbidden
