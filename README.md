# BitcoinTrade (brazilian exchange) SDK .NET

The [BitcoinTrade](https://bitcointrade.com.br) API client wrapper for .NET projects.

![Bitcointrade](https://raw.githubusercontent.com/guibranco/bitcointrade-sdk-dotnet/master/logo.png)

## CI/CD

[![Build status](https://ci.appveyor.com/api/projects/status/dekoywhywve3258w?svg=true)](https://ci.appveyor.com/project/guibranco/bitcointrade-sdk-dotnet)
[![GitHub last commit](https://img.shields.io/github/last-commit/guibranco/bitcointrade-sdk-dotnet)](https://github.com/guibranco/bitcointrade-sdk-dotnet)
[![GitHub last release](https://img.shields.io/github/release-date/guibranco/bitcointrade-sdk-dotnet.svg?style=flat)](https://github.com/guibranco/bitcointrade-sdk-dotnet)
[![GitHub license](https://img.shields.io/github/license/guibranco/bitcointrade-sdk-dotnet)](https://github.com/guibranco/bitcointrade-sdk-dotnet)
[![time tracker](https://wakatime.com/badge/github/guibranco/bitcointrade-sdk-dotnet.svg)](https://wakatime.com/badge/github/guibranco/bitcointrade-sdk-dotnet)

## Code Quality

[![Codacy Badge](https://app.codacy.com/project/badge/Grade/bd0f2cac323e4b28a4560cd8bae1fd2d)](https://www.codacy.com/manual/guilherme_9/bitcointrade-sdk-dotnet)
[![Codacy Badge](https://api.codacy.com/project/badge/Coverage/bd0f2cac323e4b28a4560cd8bae1fd2d)](https://www.codacy.com/manual/guilherme_9/cbitcointrade-sdk-dotnet)
[![Codecov](https://codecov.io/gh/guibranco/bitcointrade-sdk-dotnet/branch/master/graph/badge.svg)](https://codecov.io/gh/guibranco/bitcointrade-sdk-dotnet)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=alert_status)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=coverage)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet)

[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet)
[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=ncloc)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet)
[![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=sqale_index)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet)
[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=duplicated_lines_density)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet)

[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=security_rating)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet)
[![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=code_smells)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=bugs)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=vulnerabilities)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet)

---

## Installation

[![PacakgeName NuGet Version](https://img.shields.io/nuget/v/BitcoinTrade.svg?style=flat)](https://www.nuget.org/packages/BitcoinTrade/)
[![PacakgeName NuGet Downloads](https://img.shields.io/nuget/dt/BitcoinTrade.svg?style=flat)](https://www.nuget.org/packages/BitcoinTrade/)
[![Github All Releases](https://img.shields.io/github/downloads/guibranco/bitcointrade-sdk-dotnet/total.svg?style=flat)](https://github.com/guibranco/bitcointrade-sdk-dotnet)

Download the latest zip file from the [Release pages](https://github.com/guibranco/bitcointrade-sdk-dotnet/releases) or simple install from [NuGet](https://www.nuget.org/packages/BitcoinTrade) package manager.

NuGet URL: [https://www.nuget.org/packages/BitcoinTrade](https://www.nuget.org/packages/BitcoinTrade)

NuGet installation via *Package Manager Console*:

```ps

Install-Package BitcoinTrade

```

---

## Features

Implements all features of BitcoinTrade API available at [BitcoinTrade API Docs](https://apidocs.bitcointrade.com.br/)

- Public
- Market
- Transfers

---

## Usage

```cs

//sample CSharp code showing how to use the lib
var client = new BitcointradeClient();
client.CallSomeMethod();

```