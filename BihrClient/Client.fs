namespace rec BihrClient

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open BihrClient.Types
open BihrClient.Http

///## Introduction
///The following API will help you to get catalogs ([Catalog](#operations-tag-Catalog)), check products availability ([Inventory](#operations-tag-Inventory)), and create or get orders ([Order](#operations-tag-Order)).
///The first step is always to get credentials with the [Authentication](#operations-tag-Authentication) section. Then you can call any API you need with the autentication [bearer](https://tools.ietf.org/html/rfc6750).
///*Note: the Authentication token is only valid during 30 minutes after its creation (see `expires_in` value in Authentication/Token response). Then you will have to ask for a new token to continue using the API.*
///You can call this REST API:
///- directly from this page (fill the green lock below with the token from the [authentication](#operations-Authentication-PostToken) call)
///- with a [PHP client](https://www.php.net/manual/en/book.curl.php) (see [example](help/eBihrApi.php.html) to get a catalog and place orders)
///- with a [.Net client](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/console-webapiclient)
///- with a [Java client](https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html)
///- with [Postman](https://god.gw.postman.com/run-collection/24333098-c6354588-3454-4fc6-b6a5-3876e41121de?action=collection%2Ffork&amp;collection-url=entityId%3D24333098-c6354588-3454-4fc6-b6a5-3876e41121de%26entityType%3Dcollection%26workspaceId%3Db98cf813-d824-4f36-80d7-97a6e189a6e7#?env%5BeBihr%5D=W3sia2V5IjoiZWJpaHJfdG9rZW4iLCJ2YWx1ZSI6IngiLCJlbmFibGVkIjp0cnVlLCJ0eXBlIjoidGV4dCJ9LHsia2V5IjoiZG93bmxvYWRJZCIsInZhbHVlIjoieCIsImVuYWJsZWQiOnRydWUsInR5cGUiOiJ0ZXh0In0seyJrZXkiOiJ0aWNrZXRJZCIsInZhbHVlIjoieCIsImVuYWJsZWQiOnRydWUsInR5cGUiOiJkZWZhdWx0In1d)
///## Details
///### Catalogs
///To get a catalog, the workflow is defined as follow:
///- [post a generation request](#operations-Catalog-PostRequest)
///  - if the response has a HTTP 200 code, the catalog is in the response
///  - if the response has a HTTP 202 code, you got a `ticketId`
///- [check the catalog generation status with the ticketId](#operations-Catalog-GetGenerationStatus)
///  - if the response contains RequestStatus = WAITING, you have the request position in queue too
///  - if the response contains RequestStatus = PROCESSING, the generation has started
///  - if the response contains RequestStatus = DONE, the generation is finished and you got a `downloadId`
///  - if the response contains RequestStatus = ERROR, the generation failed
///- [download the catalog with the downloadId](#operations-Catalog-GetGeneratedFile)
///Catalogs structure details are available in this [document](help/CatalogsContent.pdf). They are available as [CSV](https://en.wikipedia.org/wiki/Comma-separated_values) (open properly CSV files with Excel with [these instructions](help/ExcelCsvImport.pdf)), [JSON](https://en.wikipedia.org/wiki/JSON) or [XML](https://en.wikipedia.org/wiki/XML) files, [UTF-8](https://en.wikipedia.org/wiki/UTF-8) encoded and compressed in [ZIP](https://en.wikipedia.org/wiki/Zip_(file_format)) or [LZMA](https://en.wikipedia.org/wiki/Lempel–Ziv–Markov_chain_algorithm) formats.
///**Nota: Most of the catalogs are generated automatically every morning because they are common to several customers but the Prices catalogs are specific to each one and generated on demand. This is the reason why the Prices catalogs' generation seems longer than the others.**
///### Inventory
///The stock catalogs are generated once a day so their stock is only accurate when they are generated. To check the current stock during the day. You can use these calls:
///- [StockLevel](#operations-Inventory-GetStockLevel) to get a single product stock level (ex: InStock, Short, OutOfStock)
///- [StockValue](#operations-Inventory-GetStockValue) to get a single product stock value
///- [ProductsInfo](#operations-Inventory-GetProductsInfo) to know if you can order a certain amount of several products (2 of one and 6 of another, for example)
///### Orders
///Depending on your preferences, you can **create carts, or orders** directly with eBihr: details are available [here](help/OrderingUserManual.pdf).
///&amp;lt;a href="/"&amp;gt;Back to welcome page&amp;lt;/a&amp;gt;
type BihrClientClient(httpClient: HttpClient) =
    ///<summary>
    ///The following input are required:
    ///- username: your Bihr Customer Code
    ///- password: your MacKey
    ///Once the access token is obtained, it must be provided in the Header of all the following Web API with this "key : value" pattern:
    ///- Authorization: bearer {access_token}
    ///</summary>
    ///<param name="passWord">Your MacKey</param>
    ///<param name="userName">Your Bihr Customer Code</param>
    ///<param name="cancellationToken"></param>
    member this.PostToken(passWord: string, userName: string, ?cancellationToken: CancellationToken) =
        let requestParts =
            [ RequestPart.multipartFormData ("PassWord", passWord)
              RequestPart.multipartFormData ("UserName", userName) ]

        let (status, content) =
            OpenApiHttp.post httpClient "/api/v2.1/Authentication/Token" requestParts cancellationToken

        if status = HttpStatusCode.OK then
            PostToken.OK(Serializer.deserialize content)
        else if status = HttpStatusCode.BadRequest then
            PostToken.BadRequest(Serializer.deserialize content)
        else
            PostToken.InternalServerError

    ///<summary>
    ///The returned catalog is a zipped CSV file.
    ///</summary>
    member this.PostEssentialHardPartRequest(?cancellationToken: CancellationToken) =
        let requestParts = []

        let (status, content) =
            OpenApiHttp.post httpClient "/api/v2.1/Catalog/EssentialHardPart" requestParts cancellationToken

        if status = HttpStatusCode.OK then
            PostEssentialHardPartRequest.OK
        else if status = HttpStatusCode.Accepted then
            PostEssentialHardPartRequest.Accepted(Serializer.deserialize content)
        else if status = HttpStatusCode.InternalServerError then
            PostEssentialHardPartRequest.InternalServerError
        else if status = HttpStatusCode.Unauthorized then
            PostEssentialHardPartRequest.Unauthorized
        else
            PostEssentialHardPartRequest.Forbidden

    ///<summary>
    ///The returned catalog is a zipped CSV file.
    ///</summary>
    member this.PostEssentialRiderGearRequest(?cancellationToken: CancellationToken) =
        let requestParts = []

        let (status, content) =
            OpenApiHttp.post httpClient "/api/v2.1/Catalog/EssentialRiderGear" requestParts cancellationToken

        if status = HttpStatusCode.OK then
            PostEssentialRiderGearRequest.OK
        else if status = HttpStatusCode.Accepted then
            PostEssentialRiderGearRequest.Accepted(Serializer.deserialize content)
        else if status = HttpStatusCode.InternalServerError then
            PostEssentialRiderGearRequest.InternalServerError
        else if status = HttpStatusCode.Unauthorized then
            PostEssentialRiderGearRequest.Unauthorized
        else
            PostEssentialRiderGearRequest.Forbidden

    ///<summary>
    ///Requests the catalog generation list of the day.
    ///</summary>
    member this.GetCatalogGenerationHistory(?cancellationToken: CancellationToken) =
        let requestParts = []

        let (status, content) =
            OpenApiHttp.get httpClient "/api/v2.1/Catalog/CatalogGenerationHistory" requestParts cancellationToken

        if status = HttpStatusCode.OK then
            GetCatalogGenerationHistory.OK(Serializer.deserialize content)
        else if status = HttpStatusCode.InternalServerError then
            GetCatalogGenerationHistory.InternalServerError
        else if status = HttpStatusCode.Unauthorized then
            GetCatalogGenerationHistory.Unauthorized
        else
            GetCatalogGenerationHistory.Forbidden

    ///<summary>
    ///For the images catalog, the image names must be prefixed by the Product Root URL (provided by the Catalog/ProductsImagesRootUrl API) and suffixed by ".jpg" to get the full image URL.
    ///</summary>
    ///<param name="compressionType">LZMA for 7z file, ZIP for zip file</param>
    ///<param name="serializationType">CSV for Comma Separated Values, JSON for JavaScript Object Notation, XML for Extensible Markup Language</param>
    ///<param name="catalogType">Attributes, ExtendedReferences (References with more information), HardPart (only), Images, Prices, References, RiderGear (only), Stocks</param>
    ///<param name="catalogCompletion">Differential (products added since the last request during the last 60 days, automatically set to Full otherwise), Full</param>
    ///<param name="cancellationToken"></param>
    member this.PostRequest
        (
            compressionType: string,
            serializationType: string,
            catalogType: string,
            catalogCompletion: string,
            ?cancellationToken: CancellationToken
        ) =
        let requestParts =
            [ RequestPart.path ("compressionType", compressionType)
              RequestPart.path ("serializationType", serializationType)
              RequestPart.path ("catalogType", catalogType)
              RequestPart.path ("catalogCompletion", catalogCompletion) ]

        let (status, content) =
            OpenApiHttp.post
                httpClient
                "/api/v2.1/Catalog/{compressionType}/{serializationType}/{catalogType}/{catalogCompletion}"
                requestParts
                cancellationToken

        if status = HttpStatusCode.Accepted then
            PostRequest.Accepted(Serializer.deserialize content)
        else if status = HttpStatusCode.InternalServerError then
            PostRequest.InternalServerError
        else if status = HttpStatusCode.Unauthorized then
            PostRequest.Unauthorized
        else
            PostRequest.Forbidden

    ///<summary>
    ///Returns the generation status. Maximum 1 call per second.
    ///</summary>
    ///<param name="ticketId">the generation ticket ID</param>
    ///<param name="cancellationToken"></param>
    member this.GetGenerationStatus(ticketId: string, ?cancellationToken: CancellationToken) =
        let requestParts =
            [ RequestPart.query ("ticketId", ticketId) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/v2.1/Catalog/GenerationStatus" requestParts cancellationToken

        if status = HttpStatusCode.OK then
            GetGenerationStatus.OK(Serializer.deserialize content)
        else if status = HttpStatusCode.InternalServerError then
            GetGenerationStatus.InternalServerError
        else if status = HttpStatusCode.Unauthorized then
            GetGenerationStatus.Unauthorized
        else
            GetGenerationStatus.Forbidden

    ///<summary>
    ///This root URL is to be concatenated with the product images URL provided in the corresponding catalog if needed.
    ///</summary>
    member this.GetProductsImagesRootUrl(?cancellationToken: CancellationToken) =
        let requestParts = []

        let (status, content) =
            OpenApiHttp.get httpClient "/api/v2.1/Catalog/ProductsImagesRootUrl" requestParts cancellationToken

        if status = HttpStatusCode.OK then
            GetProductsImagesRootUrl.OK content
        else if status = HttpStatusCode.InternalServerError then
            GetProductsImagesRootUrl.InternalServerError
        else if status = HttpStatusCode.Unauthorized then
            GetProductsImagesRootUrl.Unauthorized
        else
            GetProductsImagesRootUrl.Forbidden

    ///<summary>
    ///This root URL has to be concatenated with the brand images provided by the Catalog/BrandImageUrl API.
    ///</summary>
    member this.GetBrandImageRootUrl(?cancellationToken: CancellationToken) =
        let requestParts = []

        let (status, content) =
            OpenApiHttp.get httpClient "/api/v2.1/Catalog/BrandImageRootUrl" requestParts cancellationToken

        if status = HttpStatusCode.OK then
            GetBrandImageRootUrl.OK content
        else if status = HttpStatusCode.InternalServerError then
            GetBrandImageRootUrl.InternalServerError
        else if status = HttpStatusCode.Unauthorized then
            GetBrandImageRootUrl.Unauthorized
        else
            GetBrandImageRootUrl.Forbidden

    ///<summary>
    ///Returns the image URL of the requested brand.
    ///</summary>
    ///<param name="brandId">the brand ID</param>
    ///<param name="cancellationToken"></param>
    member this.GetBrandImageUrl(brandId: int, ?cancellationToken: CancellationToken) =
        let requestParts =
            [ RequestPart.query ("brandId", brandId) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/v2.1/Catalog/BrandImageUrl" requestParts cancellationToken

        if status = HttpStatusCode.OK then
            GetBrandImageUrl.OK content
        else if status = HttpStatusCode.InternalServerError then
            GetBrandImageUrl.InternalServerError
        else if status = HttpStatusCode.Unauthorized then
            GetBrandImageUrl.Unauthorized
        else
            GetBrandImageUrl.Forbidden

    ///<summary>
    ///Downloads the file containing the catalog.
    ///</summary>
    ///<param name="downloadId">the download ID given by the status request</param>
    ///<param name="cancellationToken"></param>
    member this.GetGeneratedFile(downloadId: string, ?cancellationToken: CancellationToken) =
        let requestParts =
            [ RequestPart.query ("downloadId", downloadId) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/v2.1/Catalog/GeneratedFile" requestParts cancellationToken

        if status = HttpStatusCode.OK then
            GetGeneratedFile.OK
        else if status = HttpStatusCode.InternalServerError then
            GetGeneratedFile.InternalServerError
        else if status = HttpStatusCode.Unauthorized then
            GetGeneratedFile.Unauthorized
        else
            GetGeneratedFile.Forbidden

    ///<summary>
    ///The value is given at the query time.
    ///</summary>
    ///<param name="productCode">the Bihr part number</param>
    ///<param name="cancellationToken"></param>
    member this.GetStockLevel(productCode: string, ?cancellationToken: CancellationToken) =
        let requestParts =
            [ RequestPart.query ("productCode", productCode) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/v2.1/Inventory/StockLevel" requestParts cancellationToken

        if status = HttpStatusCode.OK then
            GetStockLevel.OK content
        else if status = HttpStatusCode.NotFound then
            GetStockLevel.NotFound content
        else if status = HttpStatusCode.InternalServerError then
            GetStockLevel.InternalServerError
        else if status = HttpStatusCode.Unauthorized then
            GetStockLevel.Unauthorized
        else
            GetStockLevel.Forbidden

    ///<summary>
    ///The value is given at the query time.
    ///</summary>
    ///<param name="productCode">the Bihr part number</param>
    ///<param name="cancellationToken"></param>
    member this.GetStockValue(productCode: string, ?cancellationToken: CancellationToken) =
        let requestParts =
            [ RequestPart.query ("productCode", productCode) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/v2.1/Inventory/StockValue" requestParts cancellationToken

        if status = HttpStatusCode.OK then
            GetStockValue.OK(Serializer.deserialize content)
        else if status = HttpStatusCode.NotFound then
            GetStockValue.NotFound content
        else if status = HttpStatusCode.InternalServerError then
            GetStockValue.InternalServerError
        else if status = HttpStatusCode.Unauthorized then
            GetStockValue.Unauthorized
        else
            GetStockValue.Forbidden

    ///<summary>
    ///Returns a list of products and their availability.
    ///</summary>
    member this.GetProductsInfo(body: GetProductsInfoPayload, ?cancellationToken: CancellationToken) =
        let requestParts = [ RequestPart.jsonContent body ]

        let (status, content) =
            OpenApiHttp.post httpClient "/api/v2.1/Inventory/ProductsInfo" requestParts cancellationToken

        if status = HttpStatusCode.OK then
            GetProductsInfo.OK(Serializer.deserialize content)
        else if status = HttpStatusCode.InternalServerError then
            GetProductsInfo.InternalServerError
        else if status = HttpStatusCode.Unauthorized then
            GetProductsInfo.Unauthorized
        else
            GetProductsInfo.Forbidden

    ///<summary>
    ///Requests an order generation.
    ///</summary>
    member this.PostCreationRequest(body: OrderCreationRequest, ?cancellationToken: CancellationToken) =
        let requestParts = [ RequestPart.jsonContent body ]

        let (status, content) =
            OpenApiHttp.post httpClient "/api/v2.1/Order/Request" requestParts cancellationToken

        if status = HttpStatusCode.OK then
            PostCreationRequest.OK(Serializer.deserialize content)
        else if status = HttpStatusCode.BadRequest then
            PostCreationRequest.BadRequest
        else if status = HttpStatusCode.InternalServerError then
            PostCreationRequest.InternalServerError
        else if status = HttpStatusCode.Unauthorized then
            PostCreationRequest.Unauthorized
        else
            PostCreationRequest.Forbidden

    ///<summary>
    ///Returns the generation status. Maximum 1 call per second.
    ///</summary>
    ///<param name="ticketId">the order generation ticket ID</param>
    ///<param name="cancellationToken"></param>
    member this.GetStatus(ticketId: string, ?cancellationToken: CancellationToken) =
        let requestParts =
            [ RequestPart.query ("ticketId", ticketId) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/v2.1/Order/GenerationStatus" requestParts cancellationToken

        if status = HttpStatusCode.OK then
            GetStatus.OK(Serializer.deserialize content)
        else if status = HttpStatusCode.InternalServerError then
            GetStatus.InternalServerError
        else if status = HttpStatusCode.Unauthorized then
            GetStatus.Unauthorized
        else
            GetStatus.Forbidden

    ///<summary>
    ///Returns the data of a given order.
    ///</summary>
    ///<param name="orderId">the order ID</param>
    ///<param name="cancellationToken"></param>
    member this.GetData(orderId: string, ?cancellationToken: CancellationToken) =
        let requestParts =
            [ RequestPart.query ("orderId", orderId) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/v2.1/Order/Data" requestParts cancellationToken

        if status = HttpStatusCode.OK then
            GetData.OK(Serializer.deserialize content)
        else if status = HttpStatusCode.InternalServerError then
            GetData.InternalServerError
        else if status = HttpStatusCode.Unauthorized then
            GetData.Unauthorized
        else
            GetData.Forbidden
