

# IDPay.Sharp 

IDPay.Sharp is a .NET standard library for the [IDPay Payment Gateway](https://idpay.ir) that helps developers to easily speed up the integration process. 

IDPay is an Iranian online payment gateway that use customers to pay with credit cards or local banks which helps developers to implement payment systems into their applications.

This library provides an easy-to-use API that allows developers to access all the functionalities of the IDPay payment gateway including:

- Preparing an invoice
- Verifying an invoice
- Querying a transaction 
- Submitting a payment request
- Tracking the status of the payment request
- Settling a payment request 
- Refunding (return) a payment request

You can find a detailed documentation on each of the above functions in the [IDPay.Sharp Wiki](https://github.com/powerd3v/IDPay.Sharp/wiki).

## How to use IDPay.Sharp

To start using IDPay.Sharp, you will need to first add it to your project. You can do so by running the **Package Manager** command:

`Install-Package IDPay.Sharp`

You will now need to add your Client ID and Secret Key that were sent to you when you signed up for the IDPay Payment Gateway. You can add these to your project settings or as an environment variable.

The following code sample shows how to use the library to create an invoice and submit a payment request:

```csharp
// Initialize the IDPay Client
var client = new IDPayClient(clientId, secretKey);

// Create an Invoice object 
var invoice = new Invoice
{
    Amount = 100,
    CallbackUrl = "https://example.com/idpay-callback", 
    Mobile = "09xxxxxxxxx"
    // ...etc
};

// Create an Invoice using the IDPay Client
invoice = client.Invoice.Create(invoice);

// Submit a payment request 
var paymentRequest = new PaymentRequest
{
    OrderId = invoice.OrderId
};

paymentRequest = client.Payment.Request(paymentRequest);
```

For more information and usage samples, please refer to the [IDPay.Sharp Wiki](https://github.com/powerd3v/IDPay.Sharp/wiki).
