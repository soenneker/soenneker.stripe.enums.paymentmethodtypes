using Intellenum;

namespace Soenneker.Stripe.Enums.PaymentMethodTypes;

/// <summary>
/// Represents all supported Stripe PaymentMethod values used for creating, listing, and managing payment methods via the Stripe API.
/// </summary>
[Intellenum<string>]
public partial class StripePaymentMethodType
{
    /// <summary>Canadian bank debit payments.</summary>
    public static readonly StripePaymentMethodType AcssDebit = new("acss_debit");

    /// <summary>Buy now, pay later service (e.g., Afterpay or Clearpay).</summary>
    public static readonly StripePaymentMethodType AfterpayClearpay = new("afterpay_clearpay");

    /// <summary>Alipay payments (popular in China).</summary>
    public static readonly StripePaymentMethodType Alipay = new("alipay");

    /// <summary>Australian BECS debit payments.</summary>
    public static readonly StripePaymentMethodType AuBecsDebit = new("au_becs_debit");

    /// <summary>UK BACS debit payments.</summary>
    public static readonly StripePaymentMethodType BacsDebit = new("bacs_debit");

    /// <summary>Bancontact payments (Belgium).</summary>
    public static readonly StripePaymentMethodType Bancontact = new("bancontact");

    /// <summary>BLIK payments (Poland).</summary>
    public static readonly StripePaymentMethodType Blik = new("blik");

    /// <summary>Boleto payments (Brazil bank slip method).</summary>
    public static readonly StripePaymentMethodType Boleto = new("boleto");

    /// <summary>Credit and debit card payments.</summary>
    public static readonly StripePaymentMethodType Card = new("card");

    /// <summary>Cash App Pay (U.S. only).</summary>
    public static readonly StripePaymentMethodType CashApp = new("cashapp");

    /// <summary>Stripe-managed customer balance payments.</summary>
    public static readonly StripePaymentMethodType CustomerBalance = new("customer_balance");

    /// <summary>EPS bank transfers (Austria).</summary>
    public static readonly StripePaymentMethodType Eps = new("eps");

    /// <summary>FPX bank transfers (Malaysia).</summary>
    public static readonly StripePaymentMethodType Fpx = new("fpx");

    /// <summary>Giropay bank payments (Germany).</summary>
    public static readonly StripePaymentMethodType Giropay = new("giropay");

    /// <summary>GrabPay digital wallet (Southeast Asia).</summary>
    public static readonly StripePaymentMethodType Grabpay = new("grabpay");

    /// <summary>iDEAL bank transfers (Netherlands).</summary>
    public static readonly StripePaymentMethodType Ideal = new("ideal");

    /// <summary>Klarna buy now, pay later service.</summary>
    public static readonly StripePaymentMethodType Klarna = new("klarna");

    /// <summary>Konbini cash payments at convenience stores (Japan).</summary>
    public static readonly StripePaymentMethodType Konbini = new("konbini");

    /// <summary>Stripe Link – fast, saved checkout method.</summary>
    public static readonly StripePaymentMethodType Link = new("link");

    /// <summary>OXXO cash-based payments (Mexico).</summary>
    public static readonly StripePaymentMethodType Oxxo = new("oxxo");

    /// <summary>Przelewy24 (P24) payments (Poland).</summary>
    public static readonly StripePaymentMethodType P24 = new("p24");

    /// <summary>PayNow QR payments (Singapore).</summary>
    public static readonly StripePaymentMethodType PayNow = new("paynow");

    /// <summary>PayPal (currently invite-only in Stripe).</summary>
    public static readonly StripePaymentMethodType Paypal = new("paypal");

    /// <summary>PromptPay QR payments (Thailand).</summary>
    public static readonly StripePaymentMethodType PromptPay = new("promptpay");

    /// <summary>Revolut Pay (UK/Europe).</summary>
    public static readonly StripePaymentMethodType RevolutPay = new("revolut_pay");

    /// <summary>SEPA direct debits (Eurozone).</summary>
    public static readonly StripePaymentMethodType SepaDebit = new("sepa_debit");

    /// <summary>Sofort bank payments (Europe).</summary>
    public static readonly StripePaymentMethodType Sofort = new("sofort");

    /// <summary>Swish mobile payments (Sweden).</summary>
    public static readonly StripePaymentMethodType Swish = new("swish");

    /// <summary>ACH bank accounts (U.S.).</summary>
    public static readonly StripePaymentMethodType UsBankAccount = new("us_bank_account");

    /// <summary>WeChat Pay (China).</summary>
    public static readonly StripePaymentMethodType WeChatPay = new("wechat_pay");

    /// <summary>Zip pay-later service (formerly QuadPay).</summary>
    public static readonly StripePaymentMethodType Zip = new("zip");
}