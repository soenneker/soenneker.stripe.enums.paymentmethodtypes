[![](https://img.shields.io/nuget/v/soenneker.stripe.enums.paymentmethodtypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.stripe.enums.paymentmethodtypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.enums.paymentmethodtypes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.stripe.enums.paymentmethodtypes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.stripe.enums.paymentmethodtypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.stripe.enums.paymentmethodtypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.enums.paymentmethodtypes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.stripe.enums.paymentmethodtypes/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Stripe.Enums.PaymentMethodTypes

Provides strongly typed identifiers for Stripe payment-method types, including cards, bank debits, wallets, bank redirects, buy-now-pay-later methods, cash methods, and region-specific options.

## Installation

```bash
dotnet add package Soenneker.Stripe.Enums.PaymentMethodTypes
```

## Usage

```csharp
using Soenneker.Stripe.Enums.PaymentMethodTypes;

StripePaymentMethodType type = StripePaymentMethodType.Card;
string stripeValue = type.Value; // "card"

if (StripePaymentMethodType.TryFromValue(apiValue, out StripePaymentMethodType? parsed))
{
    // Branch on a known payment-method type.
}
```

Presence in this package does not mean a payment method is enabled or available for every account, country, currency, or API operation. Check the configured Stripe account and use `TryFromValue` for forward-compatible handling of newly introduced identifiers.
